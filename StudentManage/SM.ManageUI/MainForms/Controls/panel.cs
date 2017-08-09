using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SM.ManageUI.Controls
{
    public class panel : System.Windows.Forms.Panel
    {
        //private Color imageTransparentColor;

        public panel()
            : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            
        }


        protected override void OnBackgroundImageChanged(EventArgs e)
        {
            base.OnBackgroundImageChanged(e);
        }


    }
}
