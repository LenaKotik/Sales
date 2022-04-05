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
            bool anyErr = false;
            string code = CodeBox.Text, pass = PassBox.Text, pass2 = PassBox2.Text, name = NameBox.Text;
            if (code == "")
            {
                anyErr = true;
                AddUserErr.SetError(CodeBox, "Введите значение");
            }
            else AddUserErr.SetError(CodeBox, "");
            if (pass == "")
            {
                anyErr = true;
                AddUserErr.SetError(PassBox, "Введите значение");
            }
            else AddUserErr.SetError(PassBox, "");
            if (pass2 == "")
            {
                anyErr = true;
                AddUserErr.SetError(PassBox2, "Введите значение");
            }
            else AddUserErr.SetError(PassBox2, "");
            if (name == "")
            {
                anyErr = true;
                AddUserErr.SetError(NameBox, "Введите значение");
            }
            else AddUserErr.SetError(NameBox, "");
            if (pass != pass2)
            {
                anyErr = true;
                AddUserErr.SetError(PassBox2, "Пароли не совпадают");
            }
            else if (pass2 != "") AddUserErr.SetError(PassBox2, "");
            if (DataProvider.VerifyUser(code, pass) != null)
            {
                anyErr = true;
                AddUserErr.SetError(CodeBox, "Такой пользователь уже зарегестрирован");
            }
            else if (code != "")AddUserErr.SetError(CodeBox, "");
            if (!anyErr)
            {
                User u = new User() { Code = code, Name = name, IsAdmin = IsAdminFlag.Checked, Password = pass };
                DataProvider.AddUser(u);
                this.Close();
            }
        }
    }
}
