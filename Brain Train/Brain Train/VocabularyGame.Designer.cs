namespace Brain_Train
{
    partial class VocabularyGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LabelWrong = new Brain_Train.Design.ShortLabelWrong();
            this.LabelRight = new Brain_Train.Design.ShortLabelRight();
            this.shortLabels3 = new Brain_Train.Design.ShortLabels();
            this.Countdown = new Brain_Train.Design.ShortLabels();
            this.shortLabels1 = new Brain_Train.Design.ShortLabels();
            this.exit_Information1 = new Brain_Train.Buttons.Exit_Information();
            this.longLabelGames1 = new Brain_Train.Design.LongLabelGames();
            this.LabelV1 = new Brain_Train.Design.ShortLabels();
            this.LabelV2 = new Brain_Train.Design.ShortLabels();
            this.LabelV3 = new Brain_Train.Design.ShortLabels();
            this.LabelV4 = new Brain_Train.Design.ShortLabels();
            this.LabelQ = new Brain_Train.Design.ShortLabels();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabelWrong
            // 
            this.LabelWrong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelWrong.AutoSize = true;
            this.LabelWrong.BackColor = System.Drawing.Color.Transparent;
            this.LabelWrong.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.LabelWrong.ForeColor = System.Drawing.Color.Red;
            this.LabelWrong.Location = new System.Drawing.Point(761, 32);
            this.LabelWrong.Name = "LabelWrong";
            this.LabelWrong.Size = new System.Drawing.Size(19, 21);
            this.LabelWrong.TabIndex = 12;
            this.LabelWrong.Text = "0";
            this.LabelWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelRight
            // 
            this.LabelRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelRight.AutoSize = true;
            this.LabelRight.BackColor = System.Drawing.Color.Transparent;
            this.LabelRight.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.LabelRight.ForeColor = System.Drawing.Color.Green;
            this.LabelRight.Location = new System.Drawing.Point(731, 32);
            this.LabelRight.Name = "LabelRight";
            this.LabelRight.Size = new System.Drawing.Size(19, 21);
            this.LabelRight.TabIndex = 11;
            this.LabelRight.Text = "0";
            this.LabelRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shortLabels3
            // 
            this.shortLabels3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.shortLabels3.AutoSize = true;
            this.shortLabels3.BackColor = System.Drawing.Color.Transparent;
            this.shortLabels3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.shortLabels3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.shortLabels3.Location = new System.Drawing.Point(676, 32);
            this.shortLabels3.Name = "shortLabels3";
            this.shortLabels3.Size = new System.Drawing.Size(58, 21);
            this.shortLabels3.TabIndex = 10;
            this.shortLabels3.Text = "Score:";
            this.shortLabels3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Countdown
            // 
            this.Countdown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Countdown.AutoSize = true;
            this.Countdown.BackColor = System.Drawing.Color.Transparent;
            this.Countdown.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Countdown.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Countdown.Location = new System.Drawing.Point(761, -1);
            this.Countdown.Name = "Countdown";
            this.Countdown.Size = new System.Drawing.Size(19, 21);
            this.Countdown.TabIndex = 9;
            this.Countdown.Text = "0";
            this.Countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shortLabels1
            // 
            this.shortLabels1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.shortLabels1.AutoSize = true;
            this.shortLabels1.BackColor = System.Drawing.Color.Transparent;
            this.shortLabels1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.shortLabels1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.shortLabels1.Location = new System.Drawing.Point(676, -1);
            this.shortLabels1.Name = "shortLabels1";
            this.shortLabels1.Size = new System.Drawing.Size(79, 21);
            this.shortLabels1.TabIndex = 8;
            this.shortLabels1.Text = "Seconds:";
            this.shortLabels1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit_Information1
            // 
            this.exit_Information1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exit_Information1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.exit_Information1.FlatAppearance.BorderSize = 0;
            this.exit_Information1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_Information1.Image = global::Brain_Train.Properties.Resources.exit;
            this.exit_Information1.Location = new System.Drawing.Point(775, 318);
            this.exit_Information1.Name = "exit_Information1";
            this.exit_Information1.Size = new System.Drawing.Size(28, 28);
            this.exit_Information1.TabIndex = 13;
            this.exit_Information1.UseVisualStyleBackColor = false;
            this.exit_Information1.Click += new System.EventHandler(this.exit_Information1_Click);
            // 
            // longLabelGames1
            // 
            this.longLabelGames1.AutoSize = true;
            this.longLabelGames1.BackColor = System.Drawing.Color.Transparent;
            this.longLabelGames1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.longLabelGames1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.longLabelGames1.Location = new System.Drawing.Point(25, 25);
            this.longLabelGames1.Name = "longLabelGames1";
            this.longLabelGames1.Size = new System.Drawing.Size(181, 168);
            this.longLabelGames1.TabIndex = 14;
            this.longLabelGames1.Text = "Choose the scrambled\r\nword that has the same\r\nletters as the word in\r\n the middle" +
    "\r\n\r\n\r\nPress Enter to start\r\nTime: 60 seconds\r\n";
            this.longLabelGames1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelV1
            // 
            this.LabelV1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelV1.AutoSize = true;
            this.LabelV1.BackColor = System.Drawing.Color.Transparent;
            this.LabelV1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.LabelV1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelV1.Location = new System.Drawing.Point(312, 49);
            this.LabelV1.Name = "LabelV1";
            this.LabelV1.Size = new System.Drawing.Size(106, 21);
            this.LabelV1.TabIndex = 15;
            this.LabelV1.Text = "shortLabels2";
            this.LabelV1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelV1.Click += new System.EventHandler(this.LabelV1_Click);
            // 
            // LabelV2
            // 
            this.LabelV2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelV2.AutoSize = true;
            this.LabelV2.BackColor = System.Drawing.Color.Transparent;
            this.LabelV2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.LabelV2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelV2.Location = new System.Drawing.Point(435, 49);
            this.LabelV2.Name = "LabelV2";
            this.LabelV2.Size = new System.Drawing.Size(106, 21);
            this.LabelV2.TabIndex = 16;
            this.LabelV2.Text = "shortLabels4";
            this.LabelV2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelV2.Click += new System.EventHandler(this.LabelV2_Click);
            // 
            // LabelV3
            // 
            this.LabelV3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelV3.AutoSize = true;
            this.LabelV3.BackColor = System.Drawing.Color.Transparent;
            this.LabelV3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.LabelV3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelV3.Location = new System.Drawing.Point(312, 150);
            this.LabelV3.Name = "LabelV3";
            this.LabelV3.Size = new System.Drawing.Size(106, 21);
            this.LabelV3.TabIndex = 17;
            this.LabelV3.Text = "shortLabels5";
            this.LabelV3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelV3.Click += new System.EventHandler(this.LabelV3_Click);
            // 
            // LabelV4
            // 
            this.LabelV4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelV4.AutoSize = true;
            this.LabelV4.BackColor = System.Drawing.Color.Transparent;
            this.LabelV4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.LabelV4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelV4.Location = new System.Drawing.Point(435, 150);
            this.LabelV4.Name = "LabelV4";
            this.LabelV4.Size = new System.Drawing.Size(106, 21);
            this.LabelV4.TabIndex = 18;
            this.LabelV4.Text = "shortLabels6";
            this.LabelV4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelV4.Click += new System.EventHandler(this.LabelV4_Click);
            // 
            // LabelQ
            // 
            this.LabelQ.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelQ.AutoSize = true;
            this.LabelQ.BackColor = System.Drawing.Color.Transparent;
            this.LabelQ.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.LabelQ.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelQ.Location = new System.Drawing.Point(369, 99);
            this.LabelQ.Name = "LabelQ";
            this.LabelQ.Size = new System.Drawing.Size(106, 21);
            this.LabelQ.TabIndex = 19;
            this.LabelQ.Text = "shortLabels6";
            this.LabelQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VocabularyGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(787, 307);
            this.Controls.Add(this.LabelQ);
            this.Controls.Add(this.LabelV4);
            this.Controls.Add(this.LabelV3);
            this.Controls.Add(this.LabelV2);
            this.Controls.Add(this.LabelV1);
            this.Controls.Add(this.longLabelGames1);
            this.Controls.Add(this.exit_Information1);
            this.Controls.Add(this.LabelWrong);
            this.Controls.Add(this.LabelRight);
            this.Controls.Add(this.shortLabels3);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.shortLabels1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VocabularyGame";
            this.Opacity = 0.9D;
            this.Text = "VocabularyGame";
            this.Load += new System.EventHandler(this.VocabularyGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Design.ShortLabelWrong LabelWrong;
        private Design.ShortLabelRight LabelRight;
        private Design.ShortLabels shortLabels3;
        private Design.ShortLabels Countdown;
        private Design.ShortLabels shortLabels1;
        private Buttons.Exit_Information exit_Information1;
        private Design.LongLabelGames longLabelGames1;
        private Design.ShortLabels LabelV1;
        private Design.ShortLabels LabelV2;
        private Design.ShortLabels LabelV3;
        private Design.ShortLabels LabelV4;
        private Design.ShortLabels LabelQ;
        private System.Windows.Forms.Timer timer1;
    }
}