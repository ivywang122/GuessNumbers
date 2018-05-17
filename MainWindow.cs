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
        public int rounds = 10; // 贏回合數
        public int maxRounds = 20; // 最大回合數
        public int[] randomNums = new int[4]; // 亂數數字

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

        #region 顯示第幾回合

        public void GuessRoundsShow()
        {
            Controls.Find("Round" + userRounds.ToString(), false)[0].BackColor = Color.DeepPink;
        }

        #endregion 顯示第幾回合

        #region 猜過的數字顯示

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

        #endregion 猜過的數字顯示

        #region 亂數產生4個數字

        public void CreateRandomNums()
        {
            Random rnd = new Random();
            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = rnd.Next(0, 10);
                for (int j = 0; j < i;)
                {
                    if (randomNums[i] == randomNums[j])
                    {
                        randomNums[i] = rnd.Next(0, 10);
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
        }

        #endregion 亂數產生4個數字

        #region 清空 TextBox

        public void ClearNumTextBox()
        {
            NumTextBox.Focus();
            NumTextBox.Text = "";
        }

        #endregion 清空 TextBox

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
                    GuessNumsRender(guessNums);
                    userRounds++;
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
    }
}