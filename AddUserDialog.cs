// Made by LenaKotik
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sales
{
    public partial class AddUserDialog : Form
    {
        public AddUserDialog()
        {
            InitializeComponent();
            AddButton.Click += Submit;
            CancelButton = CancelvButton;
            CancelvButton.Click += (o, e) => this.Close();
        }
        private void Submit(object sender, EventArgs e)
        {
            string
                code = CodeBox.Text,
                name = NameBox.Text,
                pass = PassBox.Text,
                pass2 = PassBox2.Text;
            string
                codeErr = "",
                nameErr = "",
                passErr = "",
                pass2Err = "";

            bool anyErr = false;
            if (code.Length != 6)
            {
                anyErr = true;
                codeErr += "Введите 6-значный код;";
            }
            if (code.Any(x => x < '0' || x > '9')) // if any char is beyond [0,9] char range
            {
                anyErr = true;
                codeErr += "Код должен состоять из цифр;";
            }
            if (pass == "")
            {
                anyErr = true;
                passErr += "Введите значение;";
            }
            if (pass2 == "")
            {
                anyErr = true;
                pass2Err += "Введите значение;";
            }
            if (name == "")
            {
                anyErr = true;
                nameErr += "Введите значение;";
            }
            if (pass.Length > 30)
            {
                anyErr = true;
                passErr += "Пароль не должен быть длиннее 30 сиволов;";
            }
            if (pass != pass2)
            {
                anyErr = true;
                pass2Err += "Пароли не совпадают;";
            }
            if (DataProvider.VerifyUser(code, pass) != null)
            {
                anyErr = true;
                codeErr += "Такой пользователь уже зарегестрирован;";
            }
            if (!anyErr)
            {
                User u = new User() { Code = code, Name = name, IsAdmin = IsAdminFlag.Checked, Password = pass, Branch = (byte)BranchUpDown.Value };
                DataProvider.AddUser(u);
                this.Close();
            }
            else
            {
                AddUserErr.SetError(CodeBox, codeErr);
                AddUserErr.SetError(NameBox, nameErr);
                AddUserErr.SetError(PassBox, passErr);
                AddUserErr.SetError(PassBox2, pass2Err);
            }
        }
    }
}
