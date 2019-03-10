using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brain_Train
{
    public partial class MemoryGame : Form
    {
        public MemoryGame()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        int s;//secunda
        Random r = new Random();
        int x = 4;//poza
        float c = 0;//scor corect
        float g = 0;//scor gresit
        int y;//itermediar poza
        float re = 0;//reaction time
        float ac = 0;//accuracy
        int z;
        int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == 0)
            {
                timer1.Stop();
                exit_Information1.Enabled = true;
                re = 60/(c + g);
                ac = c / (c + g);
                longLabelGames1.Text = "Reaction time: " + re.ToString() + '\n' + "Accuracy: " + ac.ToString();

            }
            Countdown.Text = s.ToString();
        }


        public void Check(int y)
        {
            i++;
            shortLabels2.Text = i.ToString();
            if (s!=0)
            {
                if (z == x && y == 0)
                    c++;
                else if (z == x && y == 1)
                    g++;
                else if (z != x && y == 1)
                    c++;
                else if (z != x && y == 0)
                    g++;
                z = x;
                LabelRight.Text = c.ToString();
                LabelWrong.Text = g.ToString();
                x = r.Next(10, 17);
                pictureboxGame1.BackColor = Color.Red;
                pictureboxGame1.BackColor = Color.Transparent;
                pictureboxGame1.Image = Image.FromFile(x +".png");
                
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {
                case Keys.Enter:
                    s = 60;
                    i = 0;
                    timer1.Start();
                    z = 10;
                    x = 10;
                    longLabelGames1.Text = "Press the Right Arrow" + '\n' + "if the picture matches the" + '\n' + "previous one, or Left Arrow" + '\n' + "if it doesn't"
                        + '\n' + '\n' + "Press Enter to start" + '\n' + "Time: 60 seconds";
                    shortLabels2.Text = "0";
                    c = 0;
                    g = 0;
                    LabelWrong.Text = "0";
                    LabelRight.Text = "0";
                    pictureboxGame1.Image = Image.FromFile(x + ".png");
                    return true;
                case Keys.Left: // left arrow key
                    y = 1;
                    Check(y);
                    return true;

                case Keys.Right: // right arrow key
                    y = 0;
                    Check(y);
                    return true;
            }
            return true;
        }

        private void exit_Information1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}