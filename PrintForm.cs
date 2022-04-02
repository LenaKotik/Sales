using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Aspose.Imaging;
//using Aspose.Imaging.FileFormats.Eps;
//using Aspose.Imaging.ImageOptions;
using ImageMagick;
using ImageMagick.Formats;

namespace Sales
{
    public partial class PrintForm : Form
    {
#nullable enable
        Product _pr;
        System.Drawing.Image? image;
#nullable restore
        public PrintForm()
        {
            InitializeComponent();
            Head.User = Program.user;
            PrintButton.Click += Print;
        }
        public PrintForm(Product pr) : this()
        {
#nullable enable
            _pr = pr;
            image = null;
            return;
            /*
            if (!File.Exists(_pr.Filepath))
            {
                PreviewErr.SetError(PreviewBox, $"Изображение не найдено '{_pr.Filepath}' ");
                image = null;
                return;
            }
            FileStream imgFile = File.OpenRead(_pr.Filepath);
            if (!EpsImage.CanLoad(imgFile))
            {
                PreviewErr.SetError(PreviewBox, $"Не удалось загрузить изображение '{_pr.Filepath}' ");
                image = null;
                return;
            }
            EpsImage img = (EpsImage)EpsImage.Load(imgFile);
            ImageOptionsBase o = new JpegOptions();
            if (!img.CanSave(o))
            {
                PreviewErr.SetError(PreviewBox, $"Не удалось конвертировать изображение '{_pr.Filepath}' ");
                image = null;
                return;
            }
            img.Save(imgMem, o);
            image = System.Drawing.Image.FromStream(imgMem);
            PreviewBox.Image = image;
            */
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
        }
#nullable restore
    }
}