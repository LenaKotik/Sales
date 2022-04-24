// Made by LenaKotik
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sales
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            this.CenterControl(FormPanel, Point.Empty);
            this.CenterControl(QuitButton, new Point(0, 100));
            AuthButton.Click += Authorize;
            QuitButton.Click += (o, e) => this.Close(); 
        }
        void Authorize(object sndr, EventArgs e)
#nullable enable
        {
            string code = codeBox.Text;
            string pwd = passwordBox.Text;

            if (code.Length != 6)
            {
                MessageBox.Show("Код продавца должен быть 6-значным", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pwd.Length > 30)
            {
                MessageBox.Show("Пароль не может превышать 30 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pwd == "")
            {
                MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User? u = DataProvider.VerifyUser(code, pwd);
            if (u == null)
            { 
                MessageBox.Show("Пользователь не найден или неверно введен пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.user = u;
            // get the profile color index, based on the user's code
            Program.user.ProfileColorID = ((int)codeBox.Text.Average<char>(x => (double)x))%Header.profileColors.Length;
            PrintForm form = new PrintForm();
            form.AddOwnedForm(this);
            form.Show();
            this.Hide();
        }
#nullable restore
    }
}