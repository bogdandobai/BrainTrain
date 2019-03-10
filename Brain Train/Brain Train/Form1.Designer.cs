namespace Brain_Train
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gradientPanel1 = new Brain_Train.Containers.GradientPanel();
            this.exit_Information1 = new Brain_Train.Buttons.Exit_Information();
            this.BoxGame3 = new Brain_Train.Containers.GroupBoxGame();
            this.longLabel3 = new Brain_Train.Design.LongLabel();
            this.Pic3 = new Brain_Train.Design.PictureboxGame();
            this.BoxGame2 = new Brain_Train.Containers.GroupBoxGame();
            this.longLabel2 = new Brain_Train.Design.LongLabel();
            this.Pic2 = new Brain_Train.Design.PictureboxGame();
            this.BoxGame1 = new Brain_Train.Containers.GroupBoxGame();
            this.longLabel1 = new Brain_Train.Design.LongLabel();
            this.Pic1 = new Brain_Train.Design.PictureboxGame();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bigLabel1 = new Brain_Train.Design.BigLabel();
            this.imgButton12 = new Brain_Train.Buttons.ImgButton1();
            this.imgButton21 = new Brain_Train.Buttons.ImgButton2();
            this.gradientPanel1.SuspendLayout();
            this.BoxGame3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).BeginInit();
            this.BoxGame2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            this.BoxGame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(81)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.gradientPanel1.Controls.Add(this.exit_Information1);
            this.gradientPanel1.Controls.Add(this.BoxGame3);
            this.gradientPanel1.Controls.Add(this.BoxGame2);
            this.gradientPanel1.Controls.Add(this.BoxGame1);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1000, 449);
            this.gradientPanel1.TabIndex = 0;
            // 
            // exit_Information1
            // 
            this.exit_Information1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exit_Information1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.exit_Information1.FlatAppearance.BorderSize = 0;
            this.exit_Information1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_Information1.Image = global::Brain_Train.Properties.Resources.information;
            this.exit_Information1.Location = new System.Drawing.Point(972, 421);
            this.exit_Information1.Name = "exit_Information1";
            this.exit_Information1.Size = new System.Drawing.Size(28, 28);
            this.exit_Information1.TabIndex = 1;
            this.exit_Information1.UseVisualStyleBackColor = false;
            this.exit_Information1.Click += new System.EventHandler(this.exit_Information1_Click);
            // 
            // BoxGame3
            // 
            this.BoxGame3.BackColor = System.Drawing.Color.Transparent;
            this.BoxGame3.Controls.Add(this.longLabel3);
            this.BoxGame3.Controls.Add(this.Pic3);
            this.BoxGame3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.BoxGame3.ForeColor = System.Drawing.Color.White;
            this.BoxGame3.Location = new System.Drawing.Point(678, 49);
            this.BoxGame3.Name = "BoxGame3";
            this.BoxGame3.Size = new System.Drawing.Size(300, 350);
            this.BoxGame3.TabIndex = 3;
            this.BoxGame3.TabStop = false;
            this.BoxGame3.Text = "Vocabulary Training";
            this.BoxGame3.Click += new System.EventHandler(this.BoxGame3_Click);
            // 
            // longLabel3
            // 
            this.longLabel3.AutoSize = true;
            this.longLabel3.BackColor = System.Drawing.Color.Transparent;
            this.longLabel3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.longLabel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.longLabel3.Location = new System.Drawing.Point(77, 225);
            this.longLabel3.Name = "longLabel3";
            this.longLabel3.Size = new System.Drawing.Size(145, 105);
            this.longLabel3.TabIndex = 1;
            this.longLabel3.Text = "Test your visual\r\nprocessing skills,\r\nlanguage and your\r\nspeed.\r\n\r\n";
            this.longLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pic3
            // 
            this.Pic3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Pic3.BackColor = System.Drawing.Color.Transparent;
            this.Pic3.Image = global::Brain_Train.Properties.Resources.research;
            this.Pic3.Location = new System.Drawing.Point(82, 26);
            this.Pic3.Name = "Pic3";
            this.Pic3.Size = new System.Drawing.Size(135, 135);
            this.Pic3.TabIndex = 0;
            this.Pic3.TabStop = false;
            // 
            // BoxGame2
            // 
            this.BoxGame2.BackColor = System.Drawing.Color.Transparent;
            this.BoxGame2.Controls.Add(this.longLabel2);
            this.BoxGame2.Controls.Add(this.Pic2);
            this.BoxGame2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.BoxGame2.ForeColor = System.Drawing.Color.White;
            this.BoxGame2.Location = new System.Drawing.Point(355, 49);
            this.BoxGame2.Name = "BoxGame2";
            this.BoxGame2.Size = new System.Drawing.Size(300, 350);
            this.BoxGame2.TabIndex = 3;
            this.BoxGame2.TabStop = false;
            this.BoxGame2.Text = "Memory Training";
            this.BoxGame2.Click += new System.EventHandler(this.BoxGame2_Click);
            // 
            // longLabel2
            // 
            this.longLabel2.AutoSize = true;
            this.longLabel2.BackColor = System.Drawing.Color.Transparent;
            this.longLabel2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.longLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.longLabel2.Location = new System.Drawing.Point(70, 225);
            this.longLabel2.Name = "longLabel2";
            this.longLabel2.Size = new System.Drawing.Size(168, 84);
            this.longLabel2.TabIndex = 1;
            this.longLabel2.Text = "Test your short-term \r\nmemory, speed and\r\nattention to details.\r\n\r\n";
            this.longLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pic2
            // 
            this.Pic2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Pic2.BackColor = System.Drawing.Color.Transparent;
            this.Pic2.Image = global::Brain_Train.Properties.Resources.clock2;
            this.Pic2.Location = new System.Drawing.Point(82, 26);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(135, 135);
            this.Pic2.TabIndex = 0;
            this.Pic2.TabStop = false;
            // 
            // BoxGame1
            // 
            this.BoxGame1.BackColor = System.Drawing.Color.Transparent;
            this.BoxGame1.Controls.Add(this.longLabel1);
            this.BoxGame1.Controls.Add(this.Pic1);
            this.BoxGame1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.BoxGame1.ForeColor = System.Drawing.Color.White;
            this.BoxGame1.Location = new System.Drawing.Point(12, 49);
            this.BoxGame1.Name = "BoxGame1";
            this.BoxGame1.Size = new System.Drawing.Size(300, 350);
            this.BoxGame1.TabIndex = 2;
            this.BoxGame1.TabStop = false;
            this.BoxGame1.Text = "Attention Training";
            this.BoxGame1.Click += new System.EventHandler(this.BoxGame1_Click);
            // 
            // longLabel1
            // 
            this.longLabel1.AutoSize = true;
            this.longLabel1.BackColor = System.Drawing.Color.Transparent;
            this.longLabel1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.longLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.longLabel1.Location = new System.Drawing.Point(58, 225);
            this.longLabel1.Name = "longLabel1";
            this.longLabel1.Size = new System.Drawing.Size(184, 105);
            this.longLabel1.TabIndex = 1;
            this.longLabel1.Text = "Test your speed,\r\nattention to details\r\nand the ability to ignore\r\ncompeting info" +
    "rmation.\r\n\r\n";
            this.longLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.longLabel1.Click += new System.EventHandler(this.longLabel1_Click);
            // 
            // Pic1
            // 
            this.Pic1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Pic1.BackColor = System.Drawing.Color.Transparent;
            this.Pic1.Image = global::Brain_Train.Properties.Resources.storm;
            this.Pic1.Location = new System.Drawing.Point(82, 26);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(135, 135);
            this.Pic1.TabIndex = 0;
            this.Pic1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Controls.Add(this.imgButton12);
            this.panel1.Controls.Add(this.imgButton21);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Bold);
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(430, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(139, 30);
            this.bigLabel1.TabIndex = 7;
            this.bigLabel1.Text = "BrainTrain";
            // 
            // imgButton12
            // 
            this.imgButton12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imgButton12.BackColor = System.Drawing.Color.Transparent;
            this.imgButton12.FlatAppearance.BorderSize = 0;
            this.imgButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgButton12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgButton12.ForeColor = System.Drawing.Color.White;
            this.imgButton12.Location = new System.Drawing.Point(972, 1);
            this.imgButton12.Margin = new System.Windows.Forms.Padding(0);
            this.imgButton12.Name = "imgButton12";
            this.imgButton12.Size = new System.Drawing.Size(28, 28);
            this.imgButton12.TabIndex = 5;
            this.imgButton12.Text = "X";
            this.imgButton12.UseVisualStyleBackColor = false;
            this.imgButton12.Click += new System.EventHandler(this.imgButton12_Click);
            // 
            // imgButton21
            // 
            this.imgButton21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imgButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.imgButton21.FlatAppearance.BorderSize = 0;
            this.imgButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgButton21.Image = global::Brain_Train.Properties.Resources.home;
            this.imgButton21.Location = new System.Drawing.Point(0, 1);
            this.imgButton21.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.imgButton21.Name = "imgButton21";
            this.imgButton21.Size = new System.Drawing.Size(28, 28);
            this.imgButton21.TabIndex = 6;
            this.imgButton21.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 449);
            this.Controls.Add(this.gradientPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.BoxGame3.ResumeLayout(false);
            this.BoxGame3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).EndInit();
            this.BoxGame2.ResumeLayout(false);
            this.BoxGame2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            this.BoxGame1.ResumeLayout(false);
            this.BoxGame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Containers.GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private Buttons.ImgButton1 imgButton12;
        private Buttons.ImgButton2 imgButton21;
        private Design.BigLabel bigLabel1;
        private Containers.GroupBoxGame BoxGame3;
        private Design.LongLabel longLabel3;
        private Design.PictureboxGame Pic3;
        private Containers.GroupBoxGame BoxGame2;
        private Design.LongLabel longLabel2;
        private Design.PictureboxGame Pic2;
        private Containers.GroupBoxGame BoxGame1;
        private Design.LongLabel longLabel1;
        private Design.PictureboxGame Pic1;
        private Buttons.Exit_Information exit_Information1;
    }
}

