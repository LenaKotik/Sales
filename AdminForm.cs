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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.ScaleToResolution();
            HistoryView.DataSource = History._data.Select(x => x.ToString()).ToList();
            GoBackButton.Click += GoBack;
            AddUserButton.Click += (o, e) => new AddUserDialog().ShowDialog();
            AddProductButton.Click += (o, e) => new AddProductDialog().ShowDialog();
        }

        private void GoBack(object sender, EventArgs e)
        {
            Form last = this.OwnedForms[0];
            this.RemoveOwnedForm(last);
            last.Show();
            this.Close();
        }
    }
}
