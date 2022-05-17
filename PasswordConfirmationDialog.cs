// Made by LenaKotik
using System;
using System.Windows.Forms;

namespace Sales
{
    public partial class PasswordConfirmationDialog : Form
    {
        public PasswordConfirmationDialog()
        {
            InitializeComponent();
            ConfirmationB.Click += Confirm;
            CancelButton.Click += (o, e) => this.Close();
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
