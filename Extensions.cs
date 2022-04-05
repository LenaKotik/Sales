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
        public static void ScaleToResolution(this Form frm)
        {
            float width_ratio = (Screen.PrimaryScreen.Bounds.Width / 1280);
            float heigh_ratio = (Screen.PrimaryScreen.Bounds.Height / 800f);
            SizeF scale = new SizeF(width_ratio, heigh_ratio);
            frm.Scale(scale);
            //And for font size
            foreach (Control control in frm.Controls)
            {
                control.Font = new Font(familyName: "Microsoft Sans Serif", control.Font.SizeInPoints * heigh_ratio * width_ratio);
            }
        }
    }
}
