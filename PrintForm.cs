// Made by LenaKotik
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using ImageMagick;

namespace Sales
{
    public partial class PrintForm : Form
    {
#nullable enable
        Image? previewImage;
        MemoryStream? image;
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
            this.GotFocus += (e, o) => DeviceBox.DataSource = FileProvider.GetDeviceData();
            PrintButton.Click += Print;
            DeviceBox.SelectedValueChanged += (o, e) => VendorBox.DataSource = FileProvider.GetVendorData(DeviceBox.SelectedValue?.ToString()??"");
            VendorBox.SelectedValueChanged += (o, e) => ModelBox.DataSource = FileProvider.GetModelData(DeviceBox.SelectedValue?.ToString()??"", VendorBox.SelectedValue?.ToString()??"");
            ModelBox.SelectedValueChanged += (o, e) => TypeBox.DataSource = FileProvider.GetTypeData(DeviceBox.SelectedValue?.ToString()??"", VendorBox.SelectedValue?.ToString()??"", ModelBox.SelectedValue?.ToString()??"");
            SearchButton.Click += Search;
        }
#nullable enable
        public void LoadImage(Product _pr)
        {
            if (!File.Exists(_pr.Filepath))
            {
                PreviewErr.SetError(PreviewBox, $"Изображение по адресу {_pr.Filepath} не найдено");
                previewImage = null;
                return;
            }
            FileStream fileStr = File.OpenRead(_pr.Filepath);
            image = new MemoryStream(File.ReadAllBytes(_pr.Filepath));
            MagickReadSettings settings = new MagickReadSettings()
            { ColorType = ColorType.Grayscale, ColorSpace = ColorSpace.sRGB, Format = MagickFormat.Eps };
            MemoryStream imgMem = new MemoryStream();
            try
            {
                MagickImage img = new MagickImage(fileStr, settings);
                img.Scale(PreviewBox.Width-5, PreviewBox.Height-5);
                img.Write(imgMem, MagickFormat.Png);
            }
            catch (MagickException e)
            {
                MessageBox.Show(e.Message, "Ошибка при чтении файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            previewImage = Image.FromStream(imgMem);
            PreviewBox.Image = previewImage;
            PreviewErr.SetError(PreviewBox, "");
            prod_cache = _pr; // save for later
        }
        private void Search(object sender, EventArgs e)
        {
            // first, remove the previously loaded image
            previewImage = null;
            PreviewBox.Image = null;
            // then attempt to load a new one
            string Device = DeviceBox.SelectedItem?.ToString() ?? "",
                   Vendor = VendorBox.SelectedItem?.ToString() ?? "",
                     Model = ModelBox.SelectedItem?.ToString() ?? "",
                     Type = TypeBox.SelectedItem?.ToString() ?? "";
            Product? pr = FileProvider.SearchProduct(Device, Vendor, Model, Type);
            if (pr.HasValue)
            {
                material_cache = DataProvider.GetMaterial(pr.Value) ?? "[Нет данных]";
                LoadImage(pr.Value);
                DeviceLabel.Text = "Устройство:\n" + Device;
                VendorLabel.Text = "Производитель:\n" + Vendor;
                ModelLabel.Text = "Модель:\n" + Model;
                TypeLabel.Text = "Тип:\n" + Type;
                MaterialLabel.Text = "Плёнка:\n" + material_cache;
            }
            else
                PreviewErr.SetError(LeftPanel, "Продукт по указанным данным не найден");
        }
        private void Print(object sender, EventArgs e)
        {
            if (image == null)
            {
                MessageBox.Show("Невозможно печатать, изображение не загружено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string imgFile = Path.ChangeExtension(Path.GetTempFileName(), ".eps");
            File.WriteAllBytes(imgFile, image.ToArray());
            MessageBox.Show(imgFile);
            string strCmdText = $"-sDEVICE=mswinpr2 -dBATCH -dNOPAUSE -dNOPROMPT -dNoCancel -dPDFFitPage \"{imgFile}\"";
            using (Process? proc =
                Process.Start(
                    new ProcessStartInfo()
                    {
                        FileName = "GhostScript\\gswin64c.exe",
                        Arguments = strCmdText,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
            })) // syntax moment
            {
                if (proc == null) return;
                proc.WaitForExit();
                if (proc.StandardOutput.ReadToEnd().Contains("Error"))
                    MessageBox.Show("Произошла ошибка при печати", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataProvider.PushEntry(prod_cache);
            DataProvider.DecrementAmount(Program.user.Branch, material_cache);
            DataProvider.AddCostumer(new Costumer()
            {
                Phone = ClientPhoneBox.Text,
                Name = ClientNameBox.Text
            });
        }
#nullable restore
    }
}