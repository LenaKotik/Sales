// Made by LenaKotik
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ImageMagick;

namespace Sales
{
    public partial class PrintForm : Form
    {
#nullable enable
        Image? image;
#nullable restore
        Product prod_cache;
        string material_cache;
        public PrintForm()
        {
            int sideOffset = 500;
            int topOffset = 100;
            InitializeComponent();
            MagickNET.SetGhostscriptDirectory("GhostScript");
            this.CenterControl(PreviewBox, new Point(0, topOffset));
            this.CenterControl(LeftPanel, new Point(-sideOffset, topOffset));
            this.CenterControl(RightPanel, new Point(sideOffset, topOffset));
            Head.User = Program.user;
            this.GotFocus += (e, o) => DeviceBox.DataSource = DataProvider.GetDeviceData();
            PrintButton.Click += Print;
            DeviceBox.SelectedValueChanged += (o, e) => VendorBox.DataSource = DataProvider.GetVendorData(DeviceBox.SelectedValue?.ToString()??"");
            VendorBox.SelectedValueChanged += (o, e) => ModelBox.DataSource = DataProvider.GetModelData(DeviceBox.SelectedValue?.ToString()??"", VendorBox.SelectedValue?.ToString()??"");
            ModelBox.SelectedValueChanged += (o, e) => TypeBox.DataSource = DataProvider.GetTypeData(DeviceBox.SelectedValue?.ToString()??"", VendorBox.SelectedValue?.ToString()??"", ModelBox.SelectedValue?.ToString()??"");
            SearchButton.Click += Search;
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
            MemoryStream imgMem = new MemoryStream();
            try
            {
                MagickImage img = new MagickImage(fileStr, settings);
                img.Write(imgMem, MagickFormat.Png);
            }
            catch (MagickException e)
            {
                MessageBox.Show(e.Message, "Ошибка при чтении файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            string Material = DataProvider.GetMaterial(pr.Value) ?? "[Нет данных]";
            if (pr.HasValue)
            {
                LoadImage(pr.Value);
                DeviceLabel.Text = "Устройство:\n" + Device;
                VendorLabel.Text = "Производитель:\n" + Vendor;
                ModelLabel.Text = "Модель:\n" + Model;
                TypeLabel.Text = "Тип:\n" + Type;
                MaterialLabel.Text = "Плёнка:\n" + Material;
            }
            else
                PreviewErr.SetError(LeftPanel, "Продукт по указанным данным не найден");
            material_cache = Material;
        }
        private void Print(object sender, EventArgs e)
        {
            if (image == null)
            {
                MessageBox.Show("Невозможно печатать, изображение не загружено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (object sender, PrintPageEventArgs e) 
                => e.Graphics?.DrawImage(image, 0, 0);
            PrintDialog.Document = pd;
            if (PrintDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
                DataProvider.PushEntry(prod_cache);
                DataProvider.DecrementAmount(Program.user.Branch, material_cache);
                DataProvider.AddCostumer(new Costumer()
                {
                    Phone = ClientPhoneBox.Text,
                    Name = ClientNameBox.Text
                });
            }
        }
#nullable restore
    }
}