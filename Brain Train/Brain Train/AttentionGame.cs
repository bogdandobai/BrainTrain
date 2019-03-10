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
    public partial class AttentionGame : Form
    {
        int s;//secunda
        Random r = new Random();
        int x = 4;//poza
        float c = 0;//scor corect
        float g = 0;//scor gresit
        int y;//itermediar poza
        float re = 0;//reaction time
        float ac = 0;//accuracy
        int z;
        

        public AttentionGame()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if(s==0)
            {
                timer1.Stop();
                exit_Information1.Enabled = true;
                re =60/(c + g);
                ac = c / (c + g);
                longLabelGames1.Text = "Reaction time: " + re.ToString() + '\n' + "Accuracy: " + ac.ToString();

            }
            Countdown.Text = s.ToString();
        }

       
        public void Check(int y)
        {
            if (s != 0)
            {
                if (x % 4 == y)
                {
                    c++;

                }
                else
                {
                    g++;
                }
                LabelRight.Text = c.ToString();
                LabelWrong.Text = g.ToString();
                do
                {
                    x = r.Next(1, 5);
                } while (x == z);
                z = x;
                pictureboxGame1.Image = Image.FromFile(x + ".png");
            }
           
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {
                case Keys.Enter:
                    s = 60;
                    timer1.Start();
                    z = 3;
                    x = 3;
                    longLabelGames1.Text = "Press the arrow key" + '\n' + "pointing the same" + '\n' + "direction as the arrow" + '\n' + "on the screen"
                        + '\n' + '\n' + "Press Enter to start" + '\n' + "Time: 60 seconds";
                    c = 0;
                    g = 0;
                    LabelWrong.Text = "0";
                    LabelRight.Text = "0";
                    return true;
                case Keys.Left: // left arrow key
                    y = 2;
                    Check(y);
                    return true;

                case Keys.Right: // right arrow key
                    y = 0;
                    Check(y);
                    return true;
                case Keys.Up:
                    y = 3;
                    Check(y);
                    return true;
                case Keys.Down:
                    y = 1;
                    Check(y);
                    return true;

                   

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void exit_Information1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
