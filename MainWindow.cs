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
            ShowResultPannel.Visible = false;
            CreateRandomNums();
        }

        #region 設定變數

<<<<<<< HEAD
        private Random rnd = new Random();
        public static int maxNums = 4; // 最多猜幾個數字
        public int playRounds = 0; // 猜了幾回合
        public int rounds = 10; // 回合數
        public int maxRounds = 20; // 最大回合數
        public int[] randomNums = new int[maxNums]; // 亂數數字組
        public int[] userNums = new int[maxNums]; // 玩家猜的數字組

        public int[] aiNums = new int[maxNums]; // 電腦猜的數字組
        public List<int> correctLists = new List<int>(); // 電腦猜到完全正確的數字
        public List<int> rightLists = new List<int>(); // 電腦猜過的正確數字
        public List<int> wrongLists = new List<int>(); // 電腦猜過的錯的數字
        public List<int> guessedLists = new List<int>(); // 電腦已經猜過的數字
        public int[] correctNums = new int[maxNums]; // 電腦完全猜對的數組存放
        public int correctA = 0; // 電腦完全猜對(A)
        public int correctB = 0; // 電腦猜對數字(B)
=======
        private Random rnd = new Random();
        public static int maxNums = 4; // 最多猜幾個數字
        public int playRounds = 0; // 猜了幾回合
        public int rounds = 10; // 回合數
        public int maxRounds = 20; // 最大回合數
        public int[] randomNums = new int[maxNums]; // 亂數數字組
        public int[] userNums = new int[maxNums]; // 玩家猜的數字組

        public int[] aiNums = new int[maxNums]; // 電腦猜的數字組
        public int[] aiLastNums = new int[maxNums];  // 電腦上一次猜的數字組
        public List<int> correctLists = new List<int>(); // 電腦猜到完全正確的數字
        public List<int> rightLists = new List<int>(); // 電腦猜過的正確數字
        public List<int> wrongLists = new List<int>(); // 電腦猜過的錯的數字
        public List<int> guessedLists = new List<int>(); // 電腦已經猜過的數字
        public int[] correctNums = new int[maxNums]; // 電腦完全猜對的數組存放
        public int correctA = 0; // 完全猜對(A)
        public int correctB = 0; // 猜對數字(B)
>>>>>>> branch-0524

        #endregion 設定變數

        #region 畫面起始繪製

        private void Render()
        {
            int margin = 20;
<<<<<<< HEAD
            for (int i = 0; i < rounds; i++)
            {
                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Location = new Point(105 + margin * 2 * i, 200);
                panel.Name = "Round" + i.ToString();
                panel.Size = new Size(20, 20);

                this.Controls.Add(panel);
            }
        }

=======
            for (int i = 0; i < rounds; i++)
            {
                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Location = new Point(105 + margin * 2 * i, 200);
                panel.Name = "Round" + i.ToString();
                panel.Size = new Size(20, 20);

                this.Controls.Add(panel);
            }
        }

>>>>>>> branch-0524
        #endregion 畫面起始繪製

        #region 顯示目前第幾回合

<<<<<<< HEAD
        public void GuessRoundsShow()
        {
            Controls.Find("Round" + playRounds.ToString(), false)[0].BackColor = Color.DeepPink;
        }

=======
        public void GuessRoundsShow()
        {
            Controls.Find("Round" + playRounds.ToString(), false)[0].BackColor = Color.DeepPink;
        }

>>>>>>> branch-0524
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

<<<<<<< HEAD
        public void GuessNumsRender(int num)
        {
            int row = playRounds / 5;
            int col = playRounds % 5;
            Label showGuessLabel = new Label();
            showGuessLabel.AutoSize = true;
            showGuessLabel.ForeColor = SystemColors.GradientInactiveCaption;
            showGuessLabel.Name = "GuessLabel" + playRounds.ToString();
            showGuessLabel.Text = (playRounds + 1).ToString() + ". " + num.ToString();
            showGuessLabel.Location = new Point(30 + 100 * col, 30 + 40 * row);
            this.Controls.Add(showGuessLabel);
            BackGroundPanel.Controls.Add(showGuessLabel);
        }

=======
        public void GuessNumsRender(int num)
        {
            int row = playRounds / 5;
            int col = playRounds % 5;
            Label showGuessLabel = new Label();
            showGuessLabel.AutoSize = true;
            showGuessLabel.ForeColor = SystemColors.GradientInactiveCaption;
            showGuessLabel.Name = "GuessLabel" + playRounds.ToString();
            showGuessLabel.Text = (playRounds + 1).ToString() + ". " + num.ToString();
            showGuessLabel.Location = new Point(30 + 100 * col, 30 + 40 * row);
            this.Controls.Add(showGuessLabel);
            BackGroundPanel.Controls.Add(showGuessLabel);
        }

>>>>>>> branch-0524
        #endregion 猜過的數字顯示在面板

        #region 清空顯示面板

<<<<<<< HEAD
        public void ClearGuessNumsRender()
        {
            BackGroundPanel.Controls.Clear();
            playRounds = 0;
        }

=======
        public void ClearGuessNumsRender()
        {
            BackGroundPanel.Controls.Clear();
            playRounds = 0;
        }

>>>>>>> branch-0524
        #endregion 清空顯示面板

        #region 亂數產生4個數字 (1~9)

<<<<<<< HEAD
        public void CreateRandomNums()
        {
            Random rnd = new Random();
            for (int i = 0; i < maxNums; i++)
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
=======
        public void CreateRandomNums()
        {
            Random rnd = new Random();
            for (int i = 0; i < maxNums; i++)
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
>>>>>>> branch-0524
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
<<<<<<< HEAD

        #region 比對數字完全猜中(A)

        public void CompareNumPosition()
        {
            int correct = 0;
            for (int i = 0; i < maxNums; i++)
            {
                if (userNums[i] == randomNums[i])
                {
                    correct++;
                }
            }
            correctA = correct;
            CorrectNumLabel.Text = correct.ToString();
            CompareNumHit(correct);
        }

        #endregion 比對數字完全猜中(A)

        #region 比對猜中幾個數字(B)

        public void CompareNumHit(int correct)
        {
            int guessedNums = 0; // 猜中幾個數字
            for (int i = 0; i < maxNums; i++)
            {
                for (int j = 0; j < randomNums.Length; j++)
                {
                    if (randomNums[i] == userNums[j])
                    {
                        guessedNums++;
                    }
                }
            }
            correctB = guessedNums - correct;
            NotCorrectNumLabel.Text = correctB.ToString();
        }

        #endregion 比對猜中幾個數字(B)

        #region 玩家點擊開始猜

        private void NumTextBox_KeyDown(object sender, EventArgs e)
=======

        #region 比對數字完全猜中(A)

        public void CompareNumPosition()
        {
            int correct = 0;
            for (int i = 0; i < maxNums; i++)
            {
                if (userNums[i] == randomNums[i])
                {
                    correct++;
                }
            }
            correctA = correct;
            CorrectNumLabel.Text = correct.ToString();
            CompareNumHit(correct);
        }

        #endregion 比對數字完全猜中(A)

        #region 比對猜中幾個數字(B)

        public void CompareNumHit(int correct)
        {
            int guessedNums = 0; // 猜中幾個數字
            for (int i = 0; i < maxNums; i++)
            {
                for (int j = 0; j < randomNums.Length; j++)
                {
                    if (randomNums[i] == userNums[j])
                    {
                        guessedNums++;
                    }
                }
            }
            correctB = guessedNums - correct;
            NotCorrectNumLabel.Text = correctB.ToString();
        }

        #endregion 比對猜中幾個數字(B)

        #region 玩家點擊開始猜

        private void NumTextBox_Click(object sender, EventArgs e)
>>>>>>> branch-0524
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
                if (playRounds < maxRounds)
                {
                    if (playRounds < 10)
                    {
                        GuessRoundsShow();
                    }

                    // 1. 將數字分割轉換成 int 陣列 存放到 userNums
                    ConvertToNumsArr(guessNums);

                    // 2. 將 User 每回合猜的數字顯示在 UI 上
                    GuessNumsRender(guessNums);

                    // 3. 比對完全猜中
                    CompareNumPosition();

                    // 5. 每猜過一次，回合數增加 1
                    playRounds++;

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

        #region 重玩(初始化)

        private void RestartButton_Click(object sender, EventArgs e)
        {
            CreateRandomNums();
            ClearGuessNumsRender();
            ClearGuessRoundsShow();
            correctA = 0;
            correctB = 0;
            CorrectNumLabel.Text = "0";
            NotCorrectNumLabel.Text = "0";
            NumTextBox.Focus();
            rightLists.Clear();
            wrongLists.Clear();
            correctLists.Clear();
            for (int i = 0; i < maxNums; i++)
            {
                correctNums[i] = 0;
            }
        }

        #endregion 重玩(初始化)

        // ===============================================

        // 電腦去產生一個不重複數字
        public void AiCreateRandomNums()
        {
            if (rightLists.Count == 0 && wrongLists.Count == 0)
            {
                // MessageBox.Show("第一次猜");
                for (int i = 0; i < maxNums; i++)
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
<<<<<<< HEAD
            {
                // 4A
                if (correctA == 4)
                {
                    return;
                }
                // 0A0B
                else if (correctA == 0 && correctB == 0)
                {
                    for (int i = 0; i < maxNums; i++)
                    {
                        aiNums[i] = ReturnNotGuessedNum();
                        for (int j = 0; j < i;)
                        {
                            if (aiNums[i] == aiNums[j])
                            {
                                aiNums[i] = ReturnNotGuessedNum();
                                j = 0;
                            }
                            else
                            {
                                j++;
                            }
                        }
                    }
                }

                // 0ANB
                else if (correctA == 0)
                {
                    for (int i = 0; i < maxNums; i++)
                    {
                        if (i < correctB)
                        {
                            aiNums[i] = ReturnRightNum();
                            for (int j = 0; j < i;)
                            {
                                if (aiNums[i] == aiNums[j])
                                {
                                    aiNums[i] = ReturnRightNum();
                                    j = 0;
                                }
                                else
                                {
                                    j++;
                                }
                            }
                        }
                        else
                        {
                            aiNums[i] = ReturnNotGuessedNum();
                            for (int j = 0; j < i;)
                            {
                                if (aiNums[i] == aiNums[j])
                                {
                                    aiNums[i] = ReturnNotGuessedNum();
                                    j = 0;
                                }
                                else
                                {
                                    j++;
                                }
                            }
                        }
                    }
                }

                // NA0B
                else if (correctB == 0)
                {
                    for (int i = 0; i < maxNums; i++)
                    {
                        if (correctNums[i] != 0) continue;

                        aiNums[i] = ReturnNotGuessedNum();
                        for (int j = 0; j < i;)
                        {
                            if (aiNums[i] == aiNums[j])
                            {
                                aiNums[i] = ReturnNotGuessedNum();
                                j = 0;
                            }
                            else
                            {
                                j++;
                            }
                        }
                    }
                }

                //NANB
                else
                {
                    int rb = 0; // 紀錄B的放置次數
                    for (int i = 0; i < maxNums; i++)
                    {
                        if (correctNums[i] != 0) continue;
                        if (rightLists.Count == maxNums)
                        {
                            aiNums[i] = ReturnRightNum();
                            for (int j = 0; j < i;)
                            {
                                if (aiNums[i] == aiNums[j])
                                {
                                    aiNums[i] = ReturnRightNum();
                                    j = 0;
                                }
                                else
                                {
                                    j++;
                                }
                            }
                        }
                        else
                        {
                            if (rb < correctB)
                            {
                                for (int j = 0; j < i;)
                                {
                                    aiNums[i] = ReturnRightNum();
                                    if (aiNums[i] == aiNums[j])
                                    {
                                        aiNums[i] = ReturnRightNum();
                                        j = 0;
                                    }
                                    else
                                    {
                                        rb++;
                                        j++;
                                    }
                                }
                            }
                            else
                            {
                                aiNums[i] = ReturnNotGuessedNum();
                                for (int j = 0; j < i;)
                                {
                                    if (aiNums[i] == aiNums[j])
                                    {
                                        aiNums[i] = ReturnNotGuessedNum();
                                        j = 0;
                                    }
                                    else
                                    {
                                        j++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        #region 電腦猜的數組陣列轉成數字

        public int AiNumsToInt()
        {
            string nstr = "";
            int num = 0;
            foreach (int ainum in aiNums)
            {
                nstr += ainum.ToString();
            }
            bool isNum = int.TryParse(nstr, out num);
            if (!isNum)
            {
                return 0;
            }
            else
            {
                return num;
            }
        }

        #endregion 電腦猜的數組陣列轉成數字

        #region 排除完全猜對的(A)回傳已猜對的數字(B)

        public int ReturnRightNum()
        {
            int rndIndex = rnd.Next(0, rightLists.Count);
            int num = rightLists[rndIndex];

            for (int i = 0; i < correctLists.Count;)
            {
                if (num == correctLists[i])
                {
                    rndIndex = rnd.Next(0, rightLists.Count);
                    num = rightLists[rndIndex];
                    i = 0;
                }
                else
                {
                    i++;
                }
=======
            {
                AIGuessButton.Enabled = false;

                if (playRounds <= maxRounds)
                {
                    if (playRounds < 10)
                    {
                        GuessRoundsShow();
                    }

                    // 1. 將數字分割轉換成 int 陣列 存放到 userNums
                    ConvertToNumsArr(guessNums);

                    // 2. 將 User 每回合猜的數字顯示在 UI 上
                    GuessNumsRender(guessNums);

                    // 3. 比對完全猜中
                    CompareNumPosition();

                    // 5. 每猜過一次，回合數增加 1
                    if (correctA != 4) playRounds++;

                    // 6. 清除輸入框的文字
                    ClearNumTextBox();
                }

                ShowGameResult();
>>>>>>> branch-0524
            }

            return num;
        }

        #endregion 排除完全猜對的(A)回傳已猜對的數字(B)

        #region 回傳一個沒有猜過的數字

        public int ReturnNotGuessedNum()
        {
            int num = rnd.Next(1, 10);
            for (int i = 0; i < guessedLists.Count;)
            {
                if (num == guessedLists[i])
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

        #endregion 回傳一個沒有猜過的數字

        #region 比對AI完全猜中(A)

        public void CompareAiNumPosition()
        {
            int correct = 0;
            for (int i = 0; i < maxNums; i++)
            {
                if (aiNums[i] == randomNums[i])
                {
                    correctNums[i] = aiNums[i];
                    PushCorrectNum(aiNums[i]);
                    correct++;
                }
            }
            CompareAiNumHit(correct);
            correctA = correct;
            CorrectNumLabel.Text = correct.ToString();
        }

        #endregion 比對AI完全猜中(A)

        #region 比對AI猜中幾個(B)

        public void CompareAiNumHit(int correct)
        {
            int guessedNums = 0; // 猜中幾個數字
            for (int i = 0; i < maxNums; i++)
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
                PushGuessedNum(aiNums[i]);
            }
            correctB = guessedNums - correct;
            NotCorrectNumLabel.Text = correctB.ToString();
        }

        #endregion 比對AI猜中幾個(B)

        #region 完全猜對的數字放到 List

        public void PushCorrectNum(int num)
        {
            correctLists.Add(num);
            for (int i = 0; i < correctLists.Count; i++)
            {
                for (int j = 0; j < i;)
                {
                    if (correctLists[i] == correctLists[j] && correctLists[i] != 0)
                    {
                        correctLists[i] = 0;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            correctLists.RemoveAll(it => it == 0);
        }

        #endregion 完全猜對的數字放到 List

        #region 猜過的數字放到 List

        public void PushGuessedNum(int num)
        {
<<<<<<< HEAD
            guessedLists.Add(num);
            for (int i = 0; i < guessedLists.Count; i++)
            {
                for (int j = 0; j < i;)
                {
                    if (guessedLists[i] == guessedLists[j] && guessedLists[i] != 0)
                    {
                        guessedLists[i] = 0;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            guessedLists.RemoveAll(it => it == 0);
        }

        #endregion 猜過的數字放到 List

        #region 猜對的數字放到List

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

        #endregion 猜對的數字放到List

        #region 猜錯的數字放到List

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

        #endregion 猜錯的數字放到List

        // 點按電腦猜
        private void AIGuessButton_Click(object sender, EventArgs e)
        {
            AiCreateRandomNums();
            GuessNumsRender(AiNumsToInt());
            CompareAiNumPosition();
            if (playRounds < 10) GuessRoundsShow();
            playRounds++;

            /*
               MessageBox.Show("正確數組：" + randomNums[0].ToString() + randomNums[1].ToString() + randomNums[2].ToString() + randomNums[3].ToString());
               string wn = "";
               string rn = "";

               foreach (int wnum in wrongLists)
               {
                   wn += wnum.ToString();
               }
               foreach (int rnum in rightLists)
               {
                   rn += rnum.ToString();
               }
               MessageBox.Show("猜錯的數字是：" + wn);
               MessageBox.Show("猜對的數字是：" + rn.ToString());
               MessageBox.Show("電腦猜的數組：" + aiNums[0].ToString() + aiNums[1].ToString() + aiNums[2].ToString() + aiNums[3].ToString());
               MessageBox.Show("已經猜對的數組：" + correctNums[0].ToString() + correctNums[1].ToString() + correctNums[2].ToString() + correctNums[3].ToString());
           */
        }
=======
            if (e.KeyCode == Keys.Enter) NumTextBox_Click(this, (EventArgs)null);
        }

        #endregion Enter 觸發點擊事件

        #region 重玩(初始化)

        private void RestartButton_Click(object sender, EventArgs e)
        {
            CreateRandomNums();
            ClearGuessNumsRender();
            ClearGuessRoundsShow();
            correctA = 0;
            correctB = 0;
            CorrectNumLabel.Text = "0";
            NotCorrectNumLabel.Text = "0";
            NumTextBox.Focus();
            rightLists.Clear();
            wrongLists.Clear();
            correctLists.Clear();
            guessedLists.Clear();
            ShowResultPannel.Visible = false;
            GuessButton.Enabled = true;
            AIGuessButton.Enabled = true;
            AiTimer.Enabled = false;
            for (int i = 0; i < maxNums; i++)
            {
                correctNums[i] = 0;
            }
        }

        #endregion 重玩(初始化)

        #region 顯示輸贏

        public void ShowGameResult()
        {
            if (playRounds <= rounds && correctA == maxNums)
            {
                ShowResultPannel.BackColor = Color.Turquoise;
                ShowResultPannel.Visible = true;
                ResultLabel.Text = "WIN!";
                GuessButton.Enabled = false;
                AIGuessButton.Enabled = false;
            }
            else if (playRounds >= maxRounds)
            {
                ShowResultPannel.BackColor = Color.DeepPink;
                ShowResultPannel.Visible = true;
                ResultLabel.Text = "LOSE!";
                GuessButton.Enabled = false;
                AIGuessButton.Enabled = false;
            }
        }

        #endregion 顯示輸贏

        // ===============================================

        #region 電腦猜數組

        public void AiCreateRandomNums()
        {
            if (rightLists.Count == 0 && wrongLists.Count == 0)
            {
                for (int i = 0; i < maxNums; i++)
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
                // 4A
                if (correctA == 4)
                {
                    return;
                }
                // 0A0B
                else if (correctA == 0 && correctB == 0)
                {
                    for (int i = 0; i < maxNums; i++)
                    {
                        aiNums[i] = ReturnNotGuessedNum();
                        for (int j = 0; j < i;)
                        {
                            if (aiNums[i] == aiNums[j])
                            {
                                aiNums[i] = ReturnNotGuessedNum();
                                j = 0;
                            }
                            else
                            {
                                j++;
                            }
                        }
                    }
                }

                // 0ANB
                else if (correctA == 0)
                {
                    for (int i = 0; i < maxNums; i++)
                    {
                        if (i < correctB)
                        {
                            aiNums[i] = ReturnRightNum();
                            for (int j = 0; j < i;)
                            {
                                if (aiNums[i] == aiNums[j])
                                {
                                    aiNums[i] = ReturnRightNum();
                                    j = 0;
                                }
                                else
                                {
                                    j++;
                                }
                            }
                        }
                        else
                        {
                            aiNums[i] = ReturnNotGuessedNum();
                            for (int j = 0; j < i;)
                            {
                                if (aiNums[i] == aiNums[j])
                                {
                                    aiNums[i] = ReturnNotGuessedNum();
                                    j = 0;
                                }
                                else
                                {
                                    j++;
                                }
                            }
                        }
                    }
                }

                // NA0B
                else if (correctB == 0)
                {
                    for (int i = 0; i < maxNums; i++)
                    {
                        if (correctNums[i] != 0) continue;

                        aiNums[i] = ReturnNotGuessedNum();
                        for (int j = 0; j < i;)
                        {
                            if (aiNums[i] == aiNums[j])
                            {
                                aiNums[i] = ReturnNotGuessedNum();
                                j = 0;
                            }
                            else
                            {
                                j++;
                            }
                        }
                    }
                }

                //NANB
                else
                {
                    int rb = 0; // 紀錄B的放置次數
                    for (int i = 0; i < maxNums; i++)
                    {
                        if (correctNums[i] != 0) continue;

                        if (rightLists.Count == maxNums)
                        {
                            aiNums[i] = ReturnRightNum();
                            for (int j = 0; j < i;)
                            {
                                if (aiNums[i] == aiNums[j])
                                {
                                    aiNums[i] = ReturnRightNum();
                                    j = 0;
                                }
                                else
                                {
                                    j++;
                                }
                            }
                        }
                        else
                        {
                            if (rb < correctB)
                            {
                                aiNums[i] = ReturnRightNum();
                                for (int j = 0; j < i;)
                                {
                                    if (aiNums[i] == aiNums[j])
                                    {
                                        aiNums[i] = ReturnRightNum();
                                        j = 0;
                                    }
                                    else
                                    {
                                        j++;
                                    }
                                }
                                rb++;
                            }
                            else
                            {
                                aiNums[i] = ReturnNotGuessedNum();
                                for (int j = 0; j < i;)
                                {
                                    if (aiNums[i] == aiNums[j])
                                    {
                                        aiNums[i] = ReturnNotGuessedNum();
                                        j = 0;
                                    }
                                    else
                                    {
                                        j++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion 電腦猜數組

        #region 電腦猜的數組陣列轉成數字

        public int AiNumsToInt()
        {
            string nstr = "";
            int num = 0;
            foreach (int ainum in aiNums)
            {
                nstr += ainum.ToString();
            }
            bool isNum = int.TryParse(nstr, out num);
            if (!isNum)
            {
                return 0;
            }
            else
            {
                return num;
            }
        }

        #endregion 電腦猜的數組陣列轉成數字

        #region 排除完全猜對的(A)回傳已猜對的數字(B)

        public int ReturnRightNum()
        {
            int rndIndex = rnd.Next(0, rightLists.Count);
            int num = rightLists[rndIndex];

            for (int i = 0; i < correctLists.Count;)
            {
                if (num == correctLists[i])
                {
                    rndIndex = rnd.Next(0, rightLists.Count);
                    num = rightLists[rndIndex];
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            return num;
        }

        #endregion 排除完全猜對的(A)回傳已猜對的數字(B)

        #region 回傳一個沒有猜過的數字

        public int ReturnNotGuessedNum()
        {
            int num = rnd.Next(1, 10);
            for (int i = 0; i < guessedLists.Count;)
            {
                if (num == guessedLists[i])
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

        #endregion 回傳一個沒有猜過的數字

        #region 比對AI完全猜中(A)

        public void CompareAiNumPosition()
        {
            int correct = 0;
            for (int i = 0; i < maxNums; i++)
            {
                if (aiNums[i] == randomNums[i])
                {
                    correctNums[i] = aiNums[i];
                    PushCorrectNum(aiNums[i]);
                    correct++;
                }
            }
            CompareAiNumHit(correct);
            correctA = correct;
            CorrectNumLabel.Text = correct.ToString();
        }

        #endregion 比對AI完全猜中(A)

        #region 比對AI猜中幾個(B)

        public void CompareAiNumHit(int correct)
        {
            int guessedNums = 0; // 猜中幾個數字
            for (int i = 0; i < maxNums; i++)
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
                PushGuessedNum(aiNums[i]);
            }
            correctB = guessedNums - correct;
            NotCorrectNumLabel.Text = correctB.ToString();
        }

        #endregion 比對AI猜中幾個(B)

        #region 完全猜對的數字放到 List

        public void PushCorrectNum(int num)
        {
            correctLists.Add(num);
            for (int i = 0; i < correctLists.Count; i++)
            {
                for (int j = 0; j < i;)
                {
                    if (correctLists[i] == correctLists[j] && correctLists[i] != 0)
                    {
                        correctLists[i] = 0;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            correctLists.RemoveAll(it => it == 0);
        }

        #endregion 完全猜對的數字放到 List

        #region 猜過的數字放到 List

        public void PushGuessedNum(int num)
        {
            guessedLists.Add(num);
            for (int i = 0; i < guessedLists.Count; i++)
            {
                for (int j = 0; j < i;)
                {
                    if (guessedLists[i] == guessedLists[j] && guessedLists[i] != 0)
                    {
                        guessedLists[i] = 0;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            guessedLists.RemoveAll(it => it == 0);
        }

        #endregion 猜過的數字放到 List

        #region 猜對的數字放到List

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

        #endregion 猜對的數字放到List

        #region 猜錯的數字放到List

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

        #endregion 猜錯的數字放到List

        #region 將猜過的數字推到上一次猜的數組

        public void PushLastGuessedNums()
        {
            for (int i = 0; i < maxNums; i++)
            {
                aiLastNums[i] = aiNums[i];
            }
        }

        #endregion 將猜過的數字推到上一次猜的數組

        #region 是否和上次猜的一樣

        public bool IsLastNums()
        {
            string lastNums = "";
            string thisNums = "";
            foreach (int num in aiNums)
            {
                thisNums += num.ToString();
            }
            foreach (int num in aiLastNums)
            {
                lastNums += num.ToString();
            }

            return thisNums == lastNums ? true : false;
        }

        #endregion 是否和上次猜的一樣

        #region 點按電腦猜

        private void AIGuessButton_Click(object sender, EventArgs e)
        {
            GuessButton.Enabled = false;
            AiTimer.Enabled = true;
            if (correctA == 4 || playRounds == 20) AiTimer.Enabled = false;

            if (playRounds <= maxRounds)
            {
                //AiCreateRandomNums();
                //PushLastGuessedNums();
                do
                {
                    AiCreateRandomNums();
                } while (IsLastNums() && correctA != maxNums);
                PushLastGuessedNums();

                if (playRounds < 10) GuessRoundsShow();
                GuessNumsRender(AiNumsToInt());
                CompareAiNumPosition();
                if (correctA != 4) playRounds++;

                ShowGameResult();
            }

            /*
               MessageBox.Show("正確數組：" + randomNums[0].ToString() + randomNums[1].ToString() + randomNums[2].ToString() + randomNums[3].ToString());
               string wn = "";
               string rn = "";

               foreach (int wnum in wrongLists)
               {
                   wn += wnum.ToString();
               }
               foreach (int rnum in rightLists)
               {
                   rn += rnum.ToString();
               }
               MessageBox.Show("猜錯的數字是：" + wn);
               MessageBox.Show("猜對的數字是：" + rn.ToString());
               MessageBox.Show("電腦猜的數組：" + aiNums[0].ToString() + aiNums[1].ToString() + aiNums[2].ToString() + aiNums[3].ToString());
               MessageBox.Show("已經猜對的數組：" + correctNums[0].ToString() + correctNums[1].ToString() + correctNums[2].ToString() + correctNums[3].ToString());
           */
        }

        #endregion 點按電腦猜

        private void AiTimer_Tick(object sender, EventArgs e)
        {
            AIGuessButton_Click(this, (EventArgs)null);
        }
>>>>>>> branch-0524
    }
}