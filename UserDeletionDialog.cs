// Made by LenaKotik
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sales
{
    public partial class UserDeletionDialog : Form
    {
        public string Code { set; get; }
        public UserDeletionDialog()
        {
            InitializeComponent();
            OkButton.Click += Confirm;
        }
        private void Confirm(object sender, EventArgs e)
        {
            Code = CodeBox.Text;
            if (Code.Length != 6)
            {
                DeletionErr.SetError(CodeBox, "Код должен состоять из 6 символов");
                return;
            }
            if (Code.Any(x => x < '0' || x > '9'))
            {
                DeletionErr.SetError(CodeBox, "Код должен состоять исключительно из цифр");
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
