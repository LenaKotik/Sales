using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales
{
    public partial class AddProductDialog : Form
    {
        byte[] image;
        public AddProductDialog()
        {
            InitializeComponent();
            #region mess
            List<string> l = DataProvider.GetDeviceData();
            l.Add("Добавить...");
            DeviceBox.DataSource = l;
            DeviceBox.SelectedValueChanged += (o, e) => 
            {
                ComboBoxChanged(DeviceBox, DeviceNVBox);
                List<string> list = DataProvider.GetVendorData(DeviceBox.SelectedValue?.ToString());
                list.Add("Добавить...");
                VendorBox.DataSource = list;
            };
            VendorBox.SelectedValueChanged += (o, e) => 
            {
                ComboBoxChanged(VendorBox, VendorNVBox); 
                List<string> list = DataProvider.GetModelData(DeviceBox.SelectedValue?.ToString(), VendorBox.SelectedValue?.ToString());
                list.Add("Добавить...");
                ModelBox.DataSource = list; 
            };
            ModelBox.SelectedValueChanged  += (o, e) => 
            { 
                ComboBoxChanged(ModelBox, ModelNVBox); 
                List<string> list = DataProvider.GetTypeData(DeviceBox.SelectedValue?.ToString(), VendorBox.SelectedValue?.ToString(), ModelBox.SelectedValue?.ToString());
                list.Add("Добавить...");
                TypeBox.DataSource = list; 
            };
            TypeBox.SelectedValueChanged += (o, e) => ComboBoxChanged(TypeBox, TypeNVBox);
            #endregion
            SubmitB.Click += Submit;
            LoadB.Click += (o,e) => ProductOFD.ShowDialog();
            ProductOFD.FileOk += LoadImage;
        }

        private void LoadImage(object sender, EventArgs e)
        {
            image = File.ReadAllBytes(ProductOFD.FileName);
        }

        private void Submit(object sender, EventArgs e)
        {
            string 
                Device = GetVal(DeviceBox, DeviceNVBox),
                Vendor = GetVal(VendorBox, VendorNVBox),
                Model = GetVal(ModelBox, ModelNVBox),
                Type = GetVal(TypeBox, TypeNVBox);
            #region empty_checks
            if (Vendor == "")
            {
                SubmitEP.SetError(VendorNVBox, "Введите значение");
                return;
            }
            if (Device == "")
            {
                SubmitEP.SetError(DeviceNVBox, "Введите значение");
                return;
            }
            if (Model == "")
            {
                SubmitEP.SetError(ModelNVBox, "Введите значение");
                return;
            }
            if (Type == "")
            {
                SubmitEP.SetError(TypeNVBox, "Введите значение");
                return;
            }
            #endregion
            if (image == null)
            {
                SubmitEP.SetError(LoadB, "Картинка не загружена");
                return;
            }
            string path = $@"D:\ProjectRoot\CSharpProj\Sales\Models\{Device}\{Vendor}\{Model}\";
            Directory.CreateDirectory(path);
            FileStream fOut = File.Create(path + Type + ".eps");
            fOut.Write(image, 0, image.Length);

            this.Close();
        }

        /// <param name="textBox"> the corresponding NV text box</param>
        void ComboBoxChanged(ComboBox sender, TextBox textBox) 
            => textBox.Visible = (sender.SelectedValue?.ToString() == "Добавить...");

        /// <param name="textBox"> the corresponding NV text box</param>
        string GetVal(ComboBox target, TextBox textBox)
            => (target.SelectedValue?.ToString() == "Добавить...") ? textBox.Text : target.SelectedValue?.ToString();
    }
}
