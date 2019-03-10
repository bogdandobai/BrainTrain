using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Brain_Train.Design
{
    class ShortLabels:Label
    {
        protected override void OnCreateControl()
        {

            this.Font = new Font("Times New Roman", 14);
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.Black;
            this.Anchor = AnchorStyles.Right;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Enabled = false;
            this.ForeColor = SystemColors.ControlDark;
            base.OnCreateControl();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this.BackColor = Color.FromArgb(76, 175, 80);
            this.ForeColor = Color.Black;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.DarkGray;
            base.OnMouseLeave(e);
        }
    }
}
