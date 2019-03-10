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
namespace Brain_Train.Buttons
{
    class Exit_Information:Button
    {
        protected override void OnCreateControl()
        {
            this.Size = new Size(28, 28);
            this.FlatStyle = FlatStyle.Flat;
            this.Anchor = AnchorStyles.Left;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.FromArgb(76, 175, 80);
            this.Top = (this.Parent.Height - this.Height);
            this.Left = (this.Parent.Width - this.Width);
            base.OnCreateControl();
        }

       
    }
}
