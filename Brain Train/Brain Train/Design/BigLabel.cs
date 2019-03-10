using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Brain_Train.Design
{
    class BigLabel : Label
    {
        protected override void OnCreateControl()
        {

            this.Font = new Font("Times New Roman", 19, FontStyle.Bold);
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;
            this.Left = (this.Parent.Width - this.Width) / 2;
            this.Top = (this.Parent.Height - this.Height) / 2;
            base.OnCreateControl();
        }
    }
}
