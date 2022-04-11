using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    static class Extensions
    {
        /// <summary>
        /// Allows for resolution independent control placement
        /// </summary>
        /// <param name="c">a control to position at the center of the screen</param>
        /// <param name="offsetFromCenter">an offset applied to the control</param>
        public static void CenterControl(this Form frm, Control c, Point offsetFromCenter)
        {
            Rectangle p = Screen.GetWorkingArea(frm);
            c.Location = new Point(p.X + p.Width / 2 - c.Width / 2 + offsetFromCenter.X, p.Y + p.Height / 2 - c.Height / 2 + offsetFromCenter.Y);
        }
    }
}
