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
            Brushes.Green,
            Brushes.Blue,
            Brushes.Azure,
            Brushes.BlanchedAlmond,
            Brushes.Bisque,
        };
        /// <summary>
        /// index of displayed user's profile color
        /// </summary>
        int colorID;
        const int HoverDarkening = 10;
        bool DropdownOpen;
        public Header()
        {
            InitializeComponent();
            RelocateControls();
            BackDrawPanel.Paint += DrawBackArrow;
            BackDrawPanel.MouseEnter += Hover;
            BackDrawPanel.MouseLeave += Hovernt;
            BackDrawPanel.MouseClick += GoBack;
            Profile.Paint += DrawProfile;
            Profile.MouseEnter += Hover;
            Profile.MouseLeave += Hovernt;
            Profile.MouseClick += ProfileClick;
            AdminButton.Click += Admin;
            LogOutButton.Click += LogOut;
            Size = new Size(1400, 112);
            ButtonsPanel.Visible = false;
            DropdownOpen = false;
        }
        private void RelocateControls()
        {
            Rectangle p = Screen.GetWorkingArea(this);
            BP.Location = new Point(p.X + p.Width - BP.Width, BP.Top);
            UP.Location = new Point(p.X + p.Width - UP.Width, UP.Top);
        }
        private void GoBack(object sender, EventArgs e)
        {
            Form previous = ParentForm.OwnedForms[0];
            ParentForm.RemoveOwnedForm(previous);
            previous.Show();
            ParentForm.Close();
        }
        private void DrawBackArrow(object sender, PaintEventArgs e)
        {
            const int offset = 1;
            const int offset2 = 5;
            Pen p = SystemPens.ControlDarkDark;
            Rectangle r = e.ClipRectangle;
            // offset is doubled cuz we need to balance out rect's size after adding offset to the position, and then reduce it by the offset
            r = new Rectangle(r.X + offset, r.Y + offset, r.Width - 2*offset, r.Height - 2*offset); // make rect a bit smaller, so that the circle fits well
            e.Graphics.DrawEllipse(p, r); // a circle
            r = new Rectangle(r.X + offset2, r.Y + offset2, r.Width - 2*offset2, r.Height - 2*offset2); // make rect even smaller, so that the arrow fits well into the circle
            e.Graphics.DrawLine(p, r.X, r.Y+r.Height/2, r.X + r.Width, r.Y+r.Height/2); // it's diameter, parallel to X axis
            r = new Rectangle(r.X, r.Y + offset2, r.Width, r.Height - 2 * offset2); // make rect's height smaller so the arrow doesn't look to awkward 
            e.Graphics.DrawLine(p, r.X, r.Y+r.Height/2, r.X + r.Width / 2, r.Y); // right-center point to up-center point
            e.Graphics.DrawLine(p, r.X, r.Y+r.Height/2, r.X + r.Width / 2, r.Y+r.Height); // right-center point to bottom-center point
        }
        private void LogOut(object sender, EventArgs e)
        {
            Program.user = null;
            AuthorizationForm form = new AuthorizationForm();
            form.AddOwnedForm(ParentForm);
            form.Show();
            ParentForm.Hide();
        }
        private void Admin(object sender, EventArgs e)
        {
            if (!User.IsAdmin) return; // just in case
            AdminForm form = new AdminForm();
            form.AddOwnedForm(ParentForm);
            form.Show();
            ParentForm.Hide();
        }
        private void ProfileClick(object sender, MouseEventArgs e)
        {
            DropdownOpen = !DropdownOpen;
            ButtonsPanel.Visible = DropdownOpen;
            if (DropdownOpen)
                Size = new Size(1400, 162);
            else
                Size = new Size(1400, 112);
        }
        private void Hovernt(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            Color c = p.BackColor;
            c = Color.FromArgb(c.R + HoverDarkening, c.G + HoverDarkening, c.B + HoverDarkening);
            p.BackColor = c; // structs are passed by value, not by reference
        }
        private void Hover(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            Color c = p.BackColor;
            c = Color.FromArgb(c.R - HoverDarkening, c.G - HoverDarkening, c.B - HoverDarkening);
            p.BackColor = c; // structs are passed by value, not by reference
        }
        [EditorBrowsable(EditorBrowsableState.Never)] User _user;
        public User User 
        {   set
            {
                if (value == null) return; // sneaky editor
                _user = value;
                if (!User.IsAdmin)
                    AdminButton.Visible = false;
                Username.Text = _user.Name;
                colorID = _user.ProfileColorID;
            }
            get => _user;
        }
        /// <summary>
        /// Draws the Profile circle
        /// </summary>
        private void DrawProfile(object sender, PaintEventArgs e) 
            => e.Graphics.FillEllipse(profileColors[colorID], e.ClipRectangle);
    }
}
