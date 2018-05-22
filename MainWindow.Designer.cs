namespace GuessNumbers
{
    partial class MainWindow
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.NumTextBox = new System.Windows.Forms.TextBox();
            this.TextBoxPanel = new System.Windows.Forms.Panel();
            this.GuessButton = new System.Windows.Forms.Button();
            this.CountsLabel = new System.Windows.Forms.Label();
            this.BackGroundPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.AIGuessButton = new System.Windows.Forms.Button();
            this.CorrectNumLabel = new System.Windows.Forms.Label();
            this.NotCorrectNumLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.TextLabel2 = new System.Windows.Forms.Label();
            this.HowToLabel = new System.Windows.Forms.Label();
            this.TextBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumTextBox
            // 
            this.NumTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.NumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumTextBox.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NumTextBox.Location = new System.Drawing.Point(76, 12);
            this.NumTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NumTextBox.Name = "NumTextBox";
            this.NumTextBox.Size = new System.Drawing.Size(262, 128);
            this.NumTextBox.TabIndex = 0;
            this.NumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumTextBox_KeyDown);
            // 
            // TextBoxPanel
            // 
            this.TextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPanel.Controls.Add(this.NumTextBox);
            this.TextBoxPanel.Location = new System.Drawing.Point(30, 30);
            this.TextBoxPanel.Name = "TextBoxPanel";
            this.TextBoxPanel.Padding = new System.Windows.Forms.Padding(10);
            this.TextBoxPanel.Size = new System.Drawing.Size(360, 150);
            this.TextBoxPanel.TabIndex = 1;
            // 
            // GuessButton
            // 
            this.GuessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuessButton.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GuessButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GuessButton.Location = new System.Drawing.Point(410, 30);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(150, 150);
            this.GuessButton.TabIndex = 2;
            this.GuessButton.Text = "GO";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.NumTextBox_KeyDown);
            // 
            // CountsLabel
            // 
            this.CountsLabel.AutoSize = true;
            this.CountsLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CountsLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CountsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CountsLabel.Location = new System.Drawing.Point(30, 197);
            this.CountsLabel.Name = "CountsLabel";
            this.CountsLabel.Size = new System.Drawing.Size(75, 26);
            this.CountsLabel.TabIndex = 3;
            this.CountsLabel.Text = "次數：";
            // 
            // BackGroundPanel
            // 
            this.BackGroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackGroundPanel.Location = new System.Drawing.Point(0, 241);
            this.BackGroundPanel.Name = "BackGroundPanel";
            this.BackGroundPanel.Size = new System.Drawing.Size(588, 205);
            this.BackGroundPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // RestartButton
            // 
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RestartButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RestartButton.Location = new System.Drawing.Point(30, 635);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(193, 93);
            this.RestartButton.TabIndex = 5;
            this.RestartButton.Text = "重玩";
            this.RestartButton.UseCompatibleTextRendering = true;
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // AIGuessButton
            // 
            this.AIGuessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AIGuessButton.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AIGuessButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AIGuessButton.Location = new System.Drawing.Point(248, 635);
            this.AIGuessButton.Name = "AIGuessButton";
            this.AIGuessButton.Size = new System.Drawing.Size(312, 93);
            this.AIGuessButton.TabIndex = 6;
            this.AIGuessButton.Text = "給電腦玩";
            this.AIGuessButton.UseCompatibleTextRendering = true;
            this.AIGuessButton.UseVisualStyleBackColor = true;
            this.AIGuessButton.Click += new System.EventHandler(this.AIGuessButton_Click);
            // 
            // CorrectNumLabel
            // 
            this.CorrectNumLabel.AutoSize = true;
            this.CorrectNumLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CorrectNumLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.CorrectNumLabel.Location = new System.Drawing.Point(79, 547);
            this.CorrectNumLabel.Name = "CorrectNumLabel";
            this.CorrectNumLabel.Size = new System.Drawing.Size(56, 61);
            this.CorrectNumLabel.TabIndex = 7;
            this.CorrectNumLabel.Text = "0";
            this.CorrectNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotCorrectNumLabel
            // 
            this.NotCorrectNumLabel.AutoSize = true;
            this.NotCorrectNumLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NotCorrectNumLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.NotCorrectNumLabel.Location = new System.Drawing.Point(272, 547);
            this.NotCorrectNumLabel.Name = "NotCorrectNumLabel";
            this.NotCorrectNumLabel.Size = new System.Drawing.Size(56, 61);
            this.NotCorrectNumLabel.TabIndex = 8;
            this.NotCorrectNumLabel.Text = "0";
            this.NotCorrectNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.TextLabel.Location = new System.Drawing.Point(131, 547);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(123, 61);
            this.TextLabel.TabIndex = 9;
            this.TextLabel.Text = "猜對";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextLabel2
            // 
            this.TextLabel2.AutoSize = true;
            this.TextLabel2.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextLabel2.ForeColor = System.Drawing.Color.DeepPink;
            this.TextLabel2.Location = new System.Drawing.Point(323, 547);
            this.TextLabel2.Name = "TextLabel2";
            this.TextLabel2.Size = new System.Drawing.Size(171, 61);
            this.TextLabel2.TabIndex = 10;
            this.TextLabel2.Text = "位置錯";
            this.TextLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HowToLabel
            // 
            this.HowToLabel.AutoSize = true;
            this.HowToLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HowToLabel.ForeColor = System.Drawing.Color.Snow;
            this.HowToLabel.Location = new System.Drawing.Point(31, 467);
            this.HowToLabel.Name = "HowToLabel";
            this.HowToLabel.Size = new System.Drawing.Size(303, 27);
            this.HowToLabel.TabIndex = 11;
            this.HowToLabel.Text = "玩法：請輸入1~9不重複的數字";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.HowToLabel);
            this.Controls.Add(this.TextLabel2);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.NotCorrectNumLabel);
            this.Controls.Add(this.CorrectNumLabel);
            this.Controls.Add(this.AIGuessButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.BackGroundPanel);
            this.Controls.Add(this.CountsLabel);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.TextBoxPanel);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainWindow";
            this.Text = "猜數字遊戲";
            this.TextBoxPanel.ResumeLayout(false);
            this.TextBoxPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumTextBox;
        private System.Windows.Forms.Panel TextBoxPanel;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Label CountsLabel;
        private System.Windows.Forms.Panel BackGroundPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button AIGuessButton;
        private System.Windows.Forms.Label CorrectNumLabel;
        private System.Windows.Forms.Label NotCorrectNumLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label TextLabel2;
        private System.Windows.Forms.Label HowToLabel;
    }
}

