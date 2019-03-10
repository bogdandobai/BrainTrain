using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brain_Train.Design
{
    class PictureboxGame : PictureBox
    {
        protected override void OnCreateControl()
        {
            this.Size = new Size(135, 135);
            this.Anchor = AnchorStyles.Right;
            this.BackColor = Color.Transparent;
            this.Top = (this.Parent.Height - this.Height) / 8;
            this.Left = (this.Parent.Width - this.Width) / 2;
            this.Enabled = false;

            base.OnCreateControl();
        }


    }
}
