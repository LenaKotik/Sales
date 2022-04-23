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
    public partial class PasswordConfirmationDialog : Form
    {
        public PasswordConfirmationDialog()
        {
            InitializeComponent();
            ConfirmationB.Click += Confirm;
        }
        private void Confirm(object sender, EventArgs e)
        {
            if (PasswordBox.Text == Program.user.Password)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                PasswordErr.SetError(PasswordBox, "Неверный пароль");
        }
    }
}
