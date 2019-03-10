using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Brain_Train.Design
{
    class ShortLabelWrong:Label
    {
        protected override void OnCreateControl()
        {

            this.Font = new Font("Times New Roman", 14);
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.Red;
            this.Anchor = AnchorStyles.Right;
            this.TextAlign = ContentAlignment.MiddleCenter;
            base.OnCreateControl();
        }
    }
}
