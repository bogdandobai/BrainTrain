﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Brain_Train.Design
{
    class LongLabelGames:Label
    {
        protected override void OnCreateControl()
        {

            this.Font = new Font("Times New Roman", 14);
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.Black;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Enabled = false;
            this.ForeColor = SystemColors.ControlDark;
            this.Left = 25;
            this.Top = 25;
            base.OnCreateControl();
        }
    }
}
