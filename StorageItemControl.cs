// Made by LenaKotik
using System;
using System.Windows.Forms;

namespace Sales
{
    public partial class StorageItemControl : UserControl
    {
        public event EventHandler Deleted;
        public int Amount { get => (int)AmountUpDown.Value; }
        public string MatName { get => NameLabel.Text; }
        public void SetEditable(bool value) // branchless programing!
        {
            NameLabel.Text = NameBox.Text;
            NameBox.Text = "";
            NameLabel.Visible = !value;
            EditButt.Visible = !value;
            NameBox.Visible = value;
        }
        public StorageItemControl()
        {
            InitializeComponent();
            NameBox.LostFocus += (o, e) => SetEditable(false);
            DeleteButton.Click += DeleteItem;
            EditButt.Click += (o, e) => SetEditable(true);
        }
        public StorageItemControl(bool editable) : this()
        {
            SetEditable(editable);
        }
        public StorageItemControl(StorageItem item) : this(false)
        {
            NameLabel.Text = item.Material;
            AmountUpDown.Value = item.Amount;
        }
        private void DeleteItem(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            Deleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
