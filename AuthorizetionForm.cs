using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            AuthButton.Click += Authorize;
        }
        void Authorize(object sndr, EventArgs e)
#nullable enable
        {
            string code = codeBox.Text;
            string pwd = passwordBox.Text;

            User? u = DataProvider.VerifyUser(code, pwd);
            if (u == null)
            { 
                MessageBox.Show("Пользователь не найден или неверно введен пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.user = u;
            // get the profile color index, based on the user's code
            Program.user.ProfileColorID = ((int)codeBox.Text.Average<char>(x => (double)x))%Header.profileColors.Length;
            DeviceSelectionForm form = new DeviceSelectionForm();
            form.AddOwnedForm(this);
            form.Show();
            this.Hide();
        }
#nullable restore
    }
}