using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;
using ImageMagick.Formats;

namespace Sales
{
    public partial class PrintForm : Form
    {
#nullable enable
        Image? image;
#nullable restore
        Product prod_cache;
        public PrintForm()
        {
            InitializeComponent();
            this.ScaleToResolution();
            Head.User = Program.user;
            PrintButton.Click += Print;
            DeviceBox.DataSource = DataProvider.GetDeviceData();
            DeviceBox.SelectedValueChanged += (o, e) => VendorBox.DataSource = DataProvider.GetVendorData(DeviceBox.SelectedValue?.ToString()??"");
            VendorBox.SelectedValueChanged += (o, e) => ModelBox.DataSource = DataProvider.GetModelData(DeviceBox.SelectedValue?.ToString()??"", VendorBox.SelectedValue?.ToString()??"");
            ModelBox.SelectedValueChanged += (o, e) => TypeBox.DataSource = DataProvider.GetTypeData(DeviceBox.SelectedValue?.ToString()??"", VendorBox.SelectedValue?.ToString()??"", ModelBox.SelectedValue?.ToString()??"");
            SearchButton.Click += Search;
            MagickNET.SetGhostscriptDirectory("GhostScript");
        }
#nullable enable
        public void LoadImage(Product _pr)
        {
            if (!File.Exists(_pr.Filepath))
            {
                PreviewErr.SetError(PreviewBox, $"Изображение по адресу {_pr.Filepath} не найдено");
                image = null;
                return;
            }
            FileStream fileStr = File.OpenRead(_pr.Filepath);
            MagickReadSettings settings = new MagickReadSettings()
            { ColorType = ColorType.Grayscale, ColorSpace = ColorSpace.sRGB, Format = MagickFormat.Eps };
            MagickImage img = new MagickImage(fileStr, settings);
            MemoryStream imgMem = new MemoryStream();
            img.Write(imgMem, MagickFormat.Png);
            
            image = Image.FromStream(imgMem);
            PreviewBox.Image = image;
            PreviewErr.SetError(PreviewBox, "");
            prod_cache = _pr; // save for later
        }
        private void Search(object sender, EventArgs e)
        {
            // first, remove the previously loaded image
            image = null;
            PreviewBox.Image = null;
            // then attempt to load a new one
            string Device = DeviceBox.SelectedItem?.ToString() ?? "",
                   Vendor = VendorBox.SelectedItem?.ToString() ?? "",
                     Model = ModelBox.SelectedItem?.ToString() ?? "",
                     Type = TypeBox.SelectedItem?.ToString() ?? "";
            Product? pr = DataProvider.SearchProduct(Device, Vendor, Model, Type);
            if (pr.HasValue)
            {
                LoadImage(pr.Value);
                DeviceLabel.Text = "Устройство:\n" + Device;
                VendorLabel.Text = "Производитель:\n" + Vendor;
                ModelLabel.Text = "Модель:\n" + Model;
                TypeLabel.Text = "Тип:\n" + Type;
            }
            else
                PreviewErr.SetError(PreviewBox, "Продукт по указанным данным не найден");
        }
        private void Print(object sender, EventArgs e)
        {
            if (image == null)
            {
                MessageBox.Show("Невозможно печатать, изображение не загружено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.Duplex = Duplex.Simplex;
            pd.PrintPage += (object sender, PrintPageEventArgs e) 
                => e.Graphics?.DrawImage(image, 0, 0);
            pd.Print();
            History.Add(prod_cache);
        }
#nullable restore
    }
}