using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Brain_Train
{
    public partial class VocabularyGame : Form
    {
        public VocabularyGame()
        {
            InitializeComponent();
        }
        int i;
        int s = 0;//sec
        int ok = 0;
        float r = 0; //corect
        float w = 0; // gresit
        float re = 0;//reaction time
        float ac = 0;//accuracy
        string[] c = new string[100]; // cuvant
        string[] c1 = new string[30]; //primul raspuns
        string[] c2 = new string[30];//al 2-lea raspuns
        string[] c3 = new string[30];//al 3-lea raspuns
        string[] c4 = new string[30];//al 4-lea raspuns
        string[] cc = new string[30];//raspunsul corect


        private void VocabularyGame_Load(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader("vocabulary.txt");
            for (i = 1; i <= 10; i++)
            {
                c[i] = f.ReadLine();
                c1[i] = f.ReadLine();
                c2[i] = f.ReadLine();
                c3[i] = f.ReadLine();
                c4[i] = f.ReadLine();
                cc[i] = f.ReadLine();
            }
            LabelV1.Enabled = true;
            LabelV2.Enabled = true;
            LabelV3.Enabled = true;
            LabelV4.Enabled = true;
            LabelV1.Visible = false;
            LabelV2.Visible = false;
            LabelV3.Visible = false;
            LabelV4.Visible = false;
            LabelQ.Visible = false;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {
                case Keys.Enter:
                    s = 60;
                    timer1.Start();
                    longLabelGames1.Text = " Choose the scrambled" + '\n' + "word that has the same" + '\n' + "letters as the word in  " + '\n' + "the middle"
                        + '\n' + '\n' + "Press Enter to start" + '\n' + "Time: 60 seconds";
                    r = 0;
                    w = 0;
                    LabelWrong.Text = "0";
                    LabelRight.Text = "0";
                    LabelQ.Text = c[1].ToString();
                    LabelV1.Text = c1[1].ToString();
                    LabelV2.Text = c2[1].ToString();
                    LabelV3.Text = c3[1].ToString();
                    LabelV4.Text = c4[1].ToString();
                    LabelV1.Visible = true;
                    LabelV2.Visible = true;
                    LabelV3.Visible = true;
                    LabelV4.Visible = true;
                    LabelQ.Visible = true;
                    i = 1;
                    return true;
            }
            return true;
        }

       
        public void Stop()
        {
            timer1.Stop();
            LabelV1.Visible = false;
            LabelV2.Visible = false;
            LabelV3.Visible = false;
            LabelV4.Visible = false;
            LabelQ.Visible = false;
            re = (60-s)/(r + w) ;
            ac = r / (r + w);
            longLabelGames1.Text = "Reaction time: " + re.ToString() + '\n' + "Accuracy: " + ac.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == 0)
            {
                Stop();
            }
            Countdown.Text = s.ToString();
        }


        public void Check()
        {
            i++;
            ok = 0;
            if (i <= 10)
            {
                LabelQ.Text = c[i].ToString();
                LabelV1.Text = c1[i].ToString();
                LabelV2.Text = c2[i].ToString();
                LabelV3.Text = c3[i].ToString();
                LabelV4.Text = c4[i].ToString();
            }
            else
                if(r+w==10)
            {
                Stop();
            }
        }


        private void LabelV1_Click(object sender, EventArgs e)
        {
            if (ok == 0)
            {
                if (c1[i] == cc[i])
                {
                    r++;
                   LabelRight.Text = r.ToString();
                }
                else
                {
                    w++;
                    LabelWrong.Text = w.ToString();
                }
            }
            ok = 1;
            Check();
        }

        private void LabelV2_Click(object sender, EventArgs e)
        {
            if (ok == 0)
            {
                if (c2[i] == cc[i])
                {
                    r++;
                    LabelRight.Text = r.ToString();
                }
                else
                {
                    w++;
                    LabelWrong.Text = w.ToString();
                }
            }
            ok = 1;
            Check();

        }

        private void LabelV3_Click(object sender, EventArgs e)
        {
            if (ok == 0)
            {
                if (c3[i] == cc[i])
                {
                    r++;
                    LabelRight.Text = r.ToString();
                }
                else
                {
                    w++;
                    LabelWrong.Text = w.ToString();
                }
            }
            ok = 1;
            Check();

        }

        private void LabelV4_Click(object sender, EventArgs e)
        {
            if (ok == 0)
            {
                if (c4[i] == cc[i])
                {
                    r++;
                    LabelRight.Text = r.ToString();
                }
                else
                {
                    w++;
                    LabelWrong.Text = w.ToString();
                }
            }
            ok = 1;
            Check();

        }

        private void exit_Information1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
