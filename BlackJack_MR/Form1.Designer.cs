namespace BlackJack_MR
{
    partial class Blackjack
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blackjack));
            this.startButton = new System.Windows.Forms.Button();
            this.hitMeButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.splitButton = new System.Windows.Forms.Button();
            this.dealerScore = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Azure;
            this.startButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.startButton.Location = new System.Drawing.Point(53, 476);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // hitMeButton
            // 
            this.hitMeButton.Enabled = false;
            this.hitMeButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.hitMeButton.Location = new System.Drawing.Point(203, 476);
            this.hitMeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hitMeButton.Name = "hitMeButton";
            this.hitMeButton.Size = new System.Drawing.Size(100, 28);
            this.hitMeButton.TabIndex = 1;
            this.hitMeButton.Text = "Еще";
            this.hitMeButton.UseVisualStyleBackColor = true;
            this.hitMeButton.Click += new System.EventHandler(this.hitMeButton_Click_1);
            // 
            // standButton
            // 
            this.standButton.Enabled = false;
            this.standButton.Location = new System.Drawing.Point(361, 476);
            this.standButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(100, 28);
            this.standButton.TabIndex = 2;
            this.standButton.Text = "Хватит";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click_1);
            // 
            // splitButton
            // 
            this.splitButton.Enabled = false;
            this.splitButton.Location = new System.Drawing.Point(603, 476);
            this.splitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(100, 28);
            this.splitButton.TabIndex = 3;
            this.splitButton.Text = "Split";
            this.splitButton.UseVisualStyleBackColor = true;
            this.splitButton.Visible = false;
            // 
            // dealerScore
            // 
            this.dealerScore.AutoSize = true;
            this.dealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dealerScore.Location = new System.Drawing.Point(49, 36);
            this.dealerScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerScore.Name = "dealerScore";
            this.dealerScore.Size = new System.Drawing.Size(0, 24);
            this.dealerScore.TabIndex = 4;
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.playerScore.Location = new System.Drawing.Point(49, 64);
            this.playerScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(0, 24);
            this.playerScore.TabIndex = 5;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.resultLabel.Location = new System.Drawing.Point(273, 233);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 24);
            this.resultLabel.TabIndex = 6;
            // 
            // exit
            // 
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(631, 476);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 28);
            this.exit.TabIndex = 7;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.welcome.Location = new System.Drawing.Point(69, 230);
            this.welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(70, 25);
            this.welcome.TabIndex = 8;
            this.welcome.Text = "label1";
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(343, 304);
            this.help.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(31, 28);
            this.help.TabIndex = 9;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.button2_Click);
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(761, 554);
            this.Controls.Add(this.help);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.dealerScore);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.hitMeButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.splitButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Blackjack";
            this.Text = "Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button hitMeButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.Label dealerScore;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button help;
    }
}

