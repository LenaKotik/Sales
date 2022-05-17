// Made by LenaKotik
using System;
using System.IO;
using System.Collections.Generic;
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
            List<string> l = FileProvider.GetDeviceData();
            l.Add("Добавить...");
            DeviceBox.DataSource = l;
            DeviceBox.SelectedValueChanged += (o, e) => 
            {
                ComboBoxChanged(DeviceBox, DeviceNVBox);
                List<string> list = FileProvider.GetVendorData(DeviceBox.SelectedValue?.ToString());
                list.Add("Добавить...");
                VendorBox.DataSource = list;
            };
            VendorBox.SelectedValueChanged += (o, e) => 
            {
                ComboBoxChanged(VendorBox, VendorNVBox); 
                List<string> list = FileProvider.GetModelData(DeviceBox.SelectedValue?.ToString(), VendorBox.SelectedValue?.ToString());
                list.Add("Добавить...");
                ModelBox.DataSource = list; 
            };
            ModelBox.SelectedValueChanged  += (o, e) => 
            { 
                ComboBoxChanged(ModelBox, ModelNVBox); 
                List<string> list = FileProvider.GetTypeData(DeviceBox.SelectedValue?.ToString(), VendorBox.SelectedValue?.ToString(), ModelBox.SelectedValue?.ToString());
                list.Add("Добавить...");
                TypeBox.DataSource = list; 
            };
            TypeBox.SelectedValueChanged += (o, e) =>
            {
                DeleteButton.Visible = TypeBox.SelectedValue?.ToString() != "Добавить...";
                ComboBoxChanged(TypeBox, TypeNVBox);
            };
            #endregion
            SubmitB.Click += Submit;
            DeleteButton.Click += (o, e) => FileProvider.DeleteProduct(new Product("","","","",$"Models\\{DeviceBox.SelectedValue}\\{VendorBox.SelectedValue}\\{ModelBox.SelectedValue}\\{TypeBox.SelectedValue}.eps" ));// only the path is necceseary
            LoadB.Click += (o,e) => ProductOFD.ShowDialog();
            CancelB.Click += (o, e) => this.Close();
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
                Type = GetVal(TypeBox, TypeNVBox),
                Material = MaterialBox.Text;
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
            if (Material == "")
            {
                SubmitEP.SetError(MaterialBox, "Введите значение");
                return;
            }
            #endregion
            if (image == null)
            {
                SubmitEP.SetError(LoadB, "Картинка не загружена");
                return;
            }
            string path = $@"Models\{Device}\{Vendor}\{Model}\";
            Directory.CreateDirectory(path);
            using (FileStream fOut = File.Create(path + Type + ".eps"))
            {
                fOut.Write(image, 0, image.Length);
                fOut.Flush();
            }
            DataProvider.SetMaterial(new Product(Device, Vendor, Model, Type, ""), Material, TypeBox.SelectedValue?.ToString() != "Добавить...");
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
