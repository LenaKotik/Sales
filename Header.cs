using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales
{
    public partial class Header : UserControl
    {
        /// <summary>
        /// Avaliable profile colors
        /// </summary>
        public static Brush[] profileColors = 
        {
            Brushes.Red,
            Brushes.BlueViolet,
            Brushes.Chocolate,
            Brushes.Olive,
            Brushes.Aquamarine,
        };
        /// <summary>
        /// index of displayed user's profile color
        /// </summary>
        int colorID;
        const int profileHoverDarkening = 10;
        public Header()
        {
            InitializeComponent();
            Profile.Paint += DrawProfile;
            Profile.MouseEnter += ProfileHover;
            Profile.MouseLeave += ProfileHovernt;
            //Profile.MouseClick;
        }

        private void ProfileHovernt(object sender, EventArgs e)
        {
            Color c = Profile.BackColor;
            c = Color.FromArgb(c.R + profileHoverDarkening, c.G + profileHoverDarkening, c.B + profileHoverDarkening);
            Profile.BackColor = c; // structs are passed by value, not by reference
        }

        private void ProfileHover(object sender, EventArgs e)
        {
            Color c = Profile.BackColor;
            c = Color.FromArgb(c.R - profileHoverDarkening, c.G - profileHoverDarkening, c.B - profileHoverDarkening);
            Profile.BackColor = c; // structs are passed by value, not by reference
        }

        [EditorBrowsable(EditorBrowsableState.Never)] User _user;
        public User User 
        {   set
            {
                if (value == null) return; // sneaky editor
                _user = value;
                Username.Text = _user.Name;
                colorID = _user.ProfileColorID;
            }
            get => _user;
        }
        /// <summary>
        /// Draws the Profile circle
        /// </summary>
        private void DrawProfile(object sender, PaintEventArgs e) => e.Graphics.FillEllipse(profileColors[colorID], e.ClipRectangle);
    }
}
