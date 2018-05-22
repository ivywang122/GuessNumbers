using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumbers
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Render();
            CreateRandomNums();
        }

        #region 設定變數

        public int userRounds = 0; // User 猜了幾回合
        public int rounds = 10; // 回合數
        public int maxRounds = 20; // 最大回合數
        public int[] randomNums = new int[4]; // 亂數數字
        public int[] userNums = new int[4]; // 玩家猜的數字
        public int[] aiNums = new int[4]; // 電腦猜的數字
        public List<int> rightLists = new List<int>(); // 電腦猜過的正確數字
        public List<int> wrongLists = new List<int>(); // 電腦猜過的錯的數字
        public int[] correctNums = new int[4]; // 電腦完全猜對的數字
        private Random rnd = new Random();

        #endregion 設定變數

        #region 畫面起始繪製

        private void Render()
        {
            // panel 間距
            int margin = 20;
            for (int i = 0; i < rounds; i++)
            {
                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Location = new Point(105 + margin * 2 * i, 200);
                panel.Name = "Round" + i.ToString();
                panel.Size = new Size(20, 20);
                this.Controls.Add(panel);
                // panel.BackColor = Color.DeepPink;
            }
        }

        #endregion 畫面起始繪製

        #region 顯示目前第幾回合

        public void GuessRoundsShow()
        {
            Controls.Find("Round" + userRounds.ToString(), false)[0].BackColor = Color.DeepPink;
        }

        #endregion 顯示目前第幾回合

        #region 清空目前回合數

        public void ClearGuessRoundsShow()
        {
            for (int i = 0; i < rounds; i++)
            {
                Controls.Find("Round" + i.ToString(), false)[0].BackColor = Color.Transparent;
            }
        }

        #endregion 清空目前回合數

        #region 猜過的數字顯示在面板

        public void GuessNumsRender(int guessNums)
        {
            int row = userRounds / 5;
            int col = userRounds % 5;
            Label showGuessLabel = new Label();
            showGuessLabel.AutoSize = true;
            showGuessLabel.ForeColor = SystemColors.GradientInactiveCaption;
            showGuessLabel.Name = "GuessLabel" + userRounds.ToString();
            showGuessLabel.Text = (userRounds + 1).ToString() + ". " + guessNums.ToString();
            showGuessLabel.Location = new Point(30 + 100 * col, 30 + 40 * row);
            this.Controls.Add(showGuessLabel);
            BackGroundPanel.Controls.Add(showGuessLabel);
        }

        #endregion 猜過的數字顯示在面板

        #region 清空顯示面板

        public void ClearGuessNumsRender()
        {
            BackGroundPanel.Controls.Clear();
            userRounds = 0;
        }

        #endregion 清空顯示面板

        #region 亂數產生4個數字 (1~9)

        public void CreateRandomNums()
        {
            Random rnd = new Random();
            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = rnd.Next(1, 10);
                for (int j = 0; j < i;)
                {
                    if (randomNums[i] == randomNums[j])
                    {
                        randomNums[i] = rnd.Next(1, 10);
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
        }

        #endregion 亂數產生4個數字 (1~9)

        #region 清空 TextBox

        public void ClearNumTextBox()
        {
            NumTextBox.Focus();
            NumTextBox.Text = "";
        }

        #endregion 清空 TextBox

        #region 將字串分割轉換為整數陣列

        public void ConvertToNumsArr(int guessNums)
        {
            char[] charArr = guessNums.ToString().ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                userNums[i] = (int)Char.GetNumericValue(charArr[i]);
            }
        }

        #endregion 將字串分割轉換為整數陣列

        #region 比對數字完全猜中位置

        public void CompareNumPosition()
        {
            int correct = 0;
            for (int i = 0; i < randomNums.Length; i++)
            {
                if (userNums[i] == randomNums[i])
                {
                    correct++;
                }
            }
            CorrectNumLabel.Text = correct.ToString();
            CompareNumHit(correct);
        }

        #endregion 比對數字完全猜中位置

        #region 比對猜中幾個數字

        public void CompareNumHit(int correct)
        {
            int guessedNums = 0; // 猜中幾個數字
            for (int i = 0; i < randomNums.Length; i++)
            {
                for (int j = 0; j < randomNums.Length; j++)
                {
                    if (randomNums[i] == userNums[j])
                    {
                        guessedNums++;
                    }
                }
            }
            NotCorrectNumLabel.Text = (guessedNums - correct).ToString();
        }

        #endregion 比對猜中幾個數字

        #region 玩家點擊開始猜

        private void NumTextBox_KeyDown(object sender, EventArgs e)
        {
            int guessNums = 0;
            bool isNum = int.TryParse(NumTextBox.Text, out guessNums);
            if (!isNum)
            {
                MessageBox.Show("請輸入合法數字！");
                ClearNumTextBox();
            }
            else if (NumTextBox.Text.Length != 4)
            {
                MessageBox.Show("請輸入 4 個數字！");
                ClearNumTextBox();
            }
            else
            {
                if (userRounds < maxRounds)
                {
                    if (userRounds < 10)
                    {
                        GuessRoundsShow();
                    }

                    // 1. 將數字分割轉換成 int 陣列 存放到 userNums
                    ConvertToNumsArr(guessNums);

                    // 2. 將 User 每回合猜的數字顯示在 UI 上
                    GuessNumsRender(guessNums);

                    // 3. 比對完全猜中
                    CompareNumPosition();

                    // 4. 比對有猜對，但位置錯

                    // 5. 每猜過一次，回合數增加 1
                    userRounds++;

                    // 6. 清除輸入框的文字
                    ClearNumTextBox();
                }
                else
                {
                    MessageBox.Show("您已猜超過最大回合數" + maxRounds.ToString());
                    NumTextBox.Text = "";
                    RestartButton.Focus();
                }
            }
        }

        #endregion 玩家點擊開始猜

        #region Enter 觸發點擊事件

        public void NumTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) NumTextBox_KeyDown(this, (EventArgs)null);
        }

        #endregion Enter 觸發點擊事件

        #region 重玩一次

        private void RestartButton_Click(object sender, EventArgs e)
        {
            CreateRandomNums();
            ClearGuessNumsRender();
            ClearGuessRoundsShow();
            CorrectNumLabel.Text = "0";
            NotCorrectNumLabel.Text = "0";
            NumTextBox.Focus();
        }

        #endregion 重玩一次

        // 電腦去產生一個不重複數字
        public void AiCreateRandomNums()
        {
            if (rightLists.Count == 0)
            {
                MessageBox.Show("第一次猜");
                for (int i = 0; i < randomNums.Length; i++)
                {
                    aiNums[i] = rnd.Next(1, 10);

                    for (int j = 0; j < i;)
                    {
                        if (aiNums[i] == aiNums[j])
                        {
                            aiNums[i] = rnd.Next(1, 10);
                            j = 0;
                        }
                        else
                        {
                            j++;
                        }
                    }
                }
            }
            else
            {
                /* for (int i = 0; i < randomNums.Length; i++)
                 {
                     // 排除已經完全猜對的位置
                     if (correctNums[i] == 0)
                     {
                         //aiNums[i] = rnd.Next(1, 10);
                         //aiNums[i] = ReturnNotWrongNum(aiNums[i]);
                     }
                 }*/
            }
        }

        // 檢查是否是猜錯的數字
        public int ReturnNotWrongNum(int num)
        {
            // 排除猜錯的數字
            for (int i = 0; i < wrongLists.Count;)
            {
                if (num == wrongLists[i])
                {
                    num = rnd.Next(1, 10);
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            return num;
        }

        // 比對完全猜中
        public void CompareAiNumPosition()
        {
            int correct = 0;
            for (int i = 0; i < randomNums.Length; i++)
            {
                if (aiNums[i] == randomNums[i])
                {
                    correctNums[i] = aiNums[i];
                    correct++;
                }
            }
            CompareAiNumHit(correct);
            CorrectNumLabel.Text = correct.ToString();
        }

        // 比對猜中幾個
        public void CompareAiNumHit(int correct)
        {
            int guessedNums = 0; // 猜中幾個數字
            for (int i = 0; i < randomNums.Length; i++)
            {
                for (int j = 0; j < randomNums.Length; j++)
                {
                    if (randomNums[i] == aiNums[j])
                    {
                        guessedNums++;
                        PushRightNum(aiNums[j]);
                    }
                }
                PushWrongNum(aiNums[i]);
            }
            NotCorrectNumLabel.Text = (guessedNums - correct).ToString();
        }

        // 猜中的數字放到 List
        public void PushRightNum(int num)
        {
            rightLists.Add(num);
            for (int i = 0; i < rightLists.Count; i++)
            {
                for (int j = 0; j < i;)
                {
                    if (rightLists[i] == rightLists[j] && rightLists[i] != 0)
                    {
                        rightLists[i] = 0;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            rightLists.RemoveAll(it => it == 0);
        }

        // 猜過錯的放到 List
        public void PushWrongNum(int num)
        {
            wrongLists.Add(num);
            for (int i = 0; i < wrongLists.Count; i++)
            {
                for (int j = 0; j < i;)
                {
                    if (wrongLists[i] == wrongLists[j] && wrongLists[i] != 0)
                    {
                        wrongLists[i] = 0;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
                for (int k = 0; k < rightLists.Count; k++)
                {
                    if (wrongLists[i] == rightLists[k])
                    {
                        wrongLists[i] = 0;
                    }
                }
            }

            wrongLists.RemoveAll(it => it == 0);
        }

        private void AIGuessButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("正確數組：" + randomNums[0].ToString() + randomNums[1].ToString() + randomNums[2].ToString() + randomNums[3].ToString());

            AiCreateRandomNums();
            CompareAiNumPosition();
            string wn = "";
            string rn = "";

            foreach (int wnum in wrongLists)
            {
                wn += wnum.ToString();
            }
            MessageBox.Show("猜錯的數字是：" + wn);
            foreach (int rnum in rightLists)
            {
                rn += rnum.ToString();
            }
            MessageBox.Show("猜對的數字是：" + rn.ToString());
            MessageBox.Show("電腦猜的數組：" + aiNums[0].ToString() + aiNums[1].ToString() + aiNums[2].ToString() + aiNums[3].ToString());
            MessageBox.Show("已經猜對的數組：" + correctNums[0].ToString() + correctNums[1].ToString() + correctNums[2].ToString() + correctNums[3].ToString());
        }
    }
}