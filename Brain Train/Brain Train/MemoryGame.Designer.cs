namespace Brain_Train
{
    partial class MemoryGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryGame));
            this.pictureboxGame1 = new Brain_Train.Design.PictureboxGame();
            this.longLabelGames1 = new Brain_Train.Design.LongLabelGames();
            this.exit_Information1 = new Brain_Train.Buttons.Exit_Information();
            this.LabelWrong = new Brain_Train.Design.ShortLabelWrong();
            this.LabelRight = new Brain_Train.Design.ShortLabelRight();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shortLabels2 = new Brain_Train.Design.ShortLabels();
            this.shortLabels3 = new Brain_Train.Design.ShortLabels();
            this.Countdown = new Brain_Train.Design.ShortLabels();
            this.shortLabels1 = new Brain_Train.Design.ShortLabels();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxGame1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxGame1
            // 
            this.pictureboxGame1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureboxGame1.BackColor = System.Drawing.Color.Transparent;
            this.pictureboxGame1.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxGame1.Image")));
            this.pictureboxGame1.Location = new System.Drawing.Point(334, 26);
            this.pictureboxGame1.Name = "pictureboxGame1";
            this.pictureboxGame1.Size = new System.Drawing.Size(135, 135);
            this.pictureboxGame1.TabIndex = 0;
            this.pictureboxGame1.TabStop = false;
            // 
            // longLabelGames1
            // 
            this.longLabelGames1.AutoSize = true;
            this.longLabelGames1.BackColor = System.Drawing.Color.Transparent;
            this.longLabelGames1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.longLabelGames1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.longLabelGames1.Location = new System.Drawing.Point(25, 25);
            this.longLabelGames1.Name = "longLabelGames1";
            this.longLabelGames1.Size = new System.Drawing.Size(219, 147);
            this.longLabelGames1.TabIndex = 1;
            this.longLabelGames1.Text = "Press the Right Arrow\r\nif the picture matches the \r\nprevious one, or Left Arrow\r\n" +
    "if it doesn\'t.\r\n\r\nPress Enter to start\r\nTime: 60 seconds\r\n";
            this.longLabelGames1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.exit_Information1.TabIndex = 2;
            this.exit_Information1.UseVisualStyleBackColor = false;
            this.exit_Information1.Click += new System.EventHandler(this.exit_Information1_Click);
            // 
            // LabelWrong
            // 
            this.LabelWrong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelWrong.AutoSize = true;
            this.LabelWrong.BackColor = System.Drawing.Color.Transparent;
            this.LabelWrong.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.LabelWrong.ForeColor = System.Drawing.Color.Red;
            this.LabelWrong.Location = new System.Drawing.Point(763, 42);
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
            this.LabelRight.Location = new System.Drawing.Point(733, 42);
            this.LabelRight.Name = "LabelRight";
            this.LabelRight.Size = new System.Drawing.Size(19, 21);
            this.LabelRight.TabIndex = 11;
            this.LabelRight.Text = "0";
            this.LabelRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // shortLabels2
            // 
            this.shortLabels2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.shortLabels2.AutoSize = true;
            this.shortLabels2.BackColor = System.Drawing.Color.Transparent;
            this.shortLabels2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.shortLabels2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.shortLabels2.Location = new System.Drawing.Point(450, 164);
            this.shortLabels2.Name = "shortLabels2";
            this.shortLabels2.Size = new System.Drawing.Size(19, 21);
            this.shortLabels2.TabIndex = 13;
            this.shortLabels2.Text = "0";
            this.shortLabels2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shortLabels3
            // 
            this.shortLabels3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.shortLabels3.AutoSize = true;
            this.shortLabels3.BackColor = System.Drawing.Color.Transparent;
            this.shortLabels3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.shortLabels3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.shortLabels3.Location = new System.Drawing.Point(678, 42);
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
            this.Countdown.Location = new System.Drawing.Point(763, 9);
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
            this.shortLabels1.Location = new System.Drawing.Point(678, 9);
            this.shortLabels1.Name = "shortLabels1";
            this.shortLabels1.Size = new System.Drawing.Size(79, 21);
            this.shortLabels1.TabIndex = 8;
            this.shortLabels1.Text = "Seconds:";
            this.shortLabels1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 307);
            this.Controls.Add(this.shortLabels2);
            this.Controls.Add(this.LabelWrong);
            this.Controls.Add(this.LabelRight);
            this.Controls.Add(this.shortLabels3);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.shortLabels1);
            this.Controls.Add(this.exit_Information1);
            this.Controls.Add(this.longLabelGames1);
            this.Controls.Add(this.pictureboxGame1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemoryGame";
            this.Opacity = 0.9D;
            this.Text = "MemoryGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxGame1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Design.PictureboxGame pictureboxGame1;
        private Design.LongLabelGames longLabelGames1;
        private Buttons.Exit_Information exit_Information1;
        private Design.ShortLabelWrong LabelWrong;
        private Design.ShortLabelRight LabelRight;
        private Design.ShortLabels shortLabels3;
        private Design.ShortLabels Countdown;
        private Design.ShortLabels shortLabels1;
        private System.Windows.Forms.Timer timer1;
        private Design.ShortLabels shortLabels2;
    }
}