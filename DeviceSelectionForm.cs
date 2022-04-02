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
    public partial class DeviceSelectionForm : Form
    {
        public DeviceSelectionForm()
        {
            InitializeComponent();
            Head.User = Program.user;
            SearchButton.Click += Search;
            List<List<string>> data = DataProvider.GetDeviceData(); // cache the expensive call
            DeviceBox.DataSource = data[0];
            VendorBox.DataSource = data[1];
            ModelBox.DataSource  = data[2];
        }

        private void Search(object sender, EventArgs e)
        {
            Product? p = DataProvider.SearchProduct(DeviceBox.SelectedItem.ToString(), VendorBox.SelectedItem.ToString(), ModelBox.SelectedItem.ToString());
            if (!p.HasValue)
            {
                MessageBox.Show("Продукт не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PrintForm form = new PrintForm(p.Value);
            form.AddOwnedForm(this);
            form.Show();
            this.Hide();
        }
    }
}
