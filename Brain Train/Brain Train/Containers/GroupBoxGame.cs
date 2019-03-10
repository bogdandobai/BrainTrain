using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Brain_Train.Containers
{
    class GroupBoxGame:GroupBox
    {
        protected override void OnCreateControl()
        {
            this.Size = new Size(300, 350);
            this.Top = (this.Parent.Height - this.Height) / 2;
            this.Font = new Font("Times New Roman", 15);
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this.BackColor = Color.FromArgb(22, 46, 58);
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackColor = Color.Transparent;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(68, 92, 105);
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.BackColor = Color.Transparent;
            base.OnMouseUp(e);
        }

    }
}
