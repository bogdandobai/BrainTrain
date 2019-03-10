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
    public partial class Form1 : Form
    {

        bool drag = false;
        Point start_point = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }
        /*Dragable FORM */
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void imgButton12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Basics*/
        private void Form1_Load(object sender, EventArgs e)
        {
            BoxGame1.Left = 20;
            BoxGame2.Left = (gradientPanel1.Width - BoxGame2.Width) / 2;
            BoxGame3.Left = (gradientPanel1.Width - BoxGame3.Width - 20);
        }

     
        private void BoxGame1_Click(object sender, EventArgs e)
        {
            AttentionGame at = new AttentionGame();
            //at.TopLevel = false;
            at.StartPosition = FormStartPosition.CenterParent;
            at.ShowDialog(this);
            
        }
        private void BoxGame2_Click(object sender, EventArgs e)
        {
            MemoryGame me = new MemoryGame();
            me.StartPosition = FormStartPosition.CenterParent;
            me.ShowDialog(this);
        }
        private void BoxGame3_Click(object sender, EventArgs e)
        {
            VocabularyGame vo = new VocabularyGame();
            vo.StartPosition = FormStartPosition.CenterParent;
            vo.ShowDialog(this);
        }

        private void exit_Information1_Click(object sender, EventArgs e)
        {
            Informations inf= new Informations();
            inf.StartPosition = FormStartPosition.CenterParent;
            inf.ShowDialog(this);
            
        }

        private void longLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
