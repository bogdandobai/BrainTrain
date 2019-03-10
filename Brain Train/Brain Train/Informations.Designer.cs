namespace Brain_Train
{
    partial class Informations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informations));
            this.exit_Information1 = new Brain_Train.Buttons.Exit_Information();
            this.longLabelGames1 = new Brain_Train.Design.LongLabelGames();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_Information1
            // 
            this.exit_Information1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exit_Information1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.exit_Information1.FlatAppearance.BorderSize = 0;
            this.exit_Information1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_Information1.Image = global::Brain_Train.Properties.Resources.exit;
            this.exit_Information1.Location = new System.Drawing.Point(719, 228);
            this.exit_Information1.Name = "exit_Information1";
            this.exit_Information1.Size = new System.Drawing.Size(28, 28);
            this.exit_Information1.TabIndex = 1;
            this.exit_Information1.UseVisualStyleBackColor = false;
            this.exit_Information1.Click += new System.EventHandler(this.exit_Information1_Click);
            // 
            // longLabelGames1
            // 
            this.longLabelGames1.AutoSize = true;
            this.longLabelGames1.BackColor = System.Drawing.Color.Transparent;
            this.longLabelGames1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.longLabelGames1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.longLabelGames1.Location = new System.Drawing.Point(12, 9);
            this.longLabelGames1.Name = "longLabelGames1";
            this.longLabelGames1.Size = new System.Drawing.Size(395, 210);
            this.longLabelGames1.TabIndex = 2;
            this.longLabelGames1.Text = resources.GetString("longLabelGames1.Text");
            this.longLabelGames1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name: Dobai Bogdan";
            // 
            // Informations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.longLabelGames1);
            this.Controls.Add(this.exit_Information1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Informations";
            this.Text = "Informations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Buttons.Exit_Information exit_Information1;
        private Design.LongLabelGames longLabelGames1;
        private System.Windows.Forms.Label label1;
    }
}