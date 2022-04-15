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
            this.CenterControl(HistLabel, new Point(0, Screen.GetWorkingArea(this).Height / 2 - HistoryView.Height - 10));
            this.CenterControl(AddUserButton, new Point(-Screen.GetWorkingArea(this).Width/2 + 200, -200));
            this.CenterControl(AddProductButton, new Point(-Screen.GetWorkingArea(this).Width / 2 + 200,-100));
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
