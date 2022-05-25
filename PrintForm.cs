// Made by LenaKotik
using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using ImageMagick;

namespace Sales
{
    public partial class PrintForm : Form
    {
#nullable enable
        // растеризованный EPS файл для предпросмотра перед печатью
        Image? previewImage;
        // "сырой" EPS файл для ghostScript печати 
        MemoryStream? image;
#nullable restore
        Product prod_cache;
        string material_cache;
        public PrintForm()
        {
            int sideOffset = 500;
            int topOffset = 100;
            
            InitializeComponent();
            // указать папку GhostScript
            MagickNET.SetGhostscriptDirectory("GhostScript");

            // выровнять элементы
            this.CenterControl(PreviewBox, new Point(0, topOffset));
            this.CenterControl(LeftPanel, new Point(-sideOffset, topOffset));
            this.CenterControl(RightPanel, new Point(sideOffset, topOffset));

            // настроить заголовочный элемент, тот, который отображает имя пользователя и цветной круг
            Head.User = Program.user;

            // обновить данные, как только окно получает фокус
            this.GotFocus += (e, o) => DeviceBox.DataSource = FileProvider.GetDeviceData();
            // вызвать функцию 'print' при нажатии кнопки печати 
            PrintButton.Click += Print;
            // когда узел в иерархии "Тип устройства -> производитель -> модель -> тип" меняется,
            // все его потомки обновляются рекурсивно 
            DeviceBox.SelectedValueChanged += (o, e) => VendorBox.DataSource = FileProvider.GetVendorData(DeviceBox.SelectedValue?.ToString()??"");
            VendorBox.SelectedValueChanged += (o, e) => ModelBox.DataSource = FileProvider.GetModelData(DeviceBox.SelectedValue?.ToString()??"", VendorBox.SelectedValue?.ToString()??"");
            ModelBox.SelectedValueChanged += (o, e) => TypeBox.DataSource = FileProvider.GetTypeData(DeviceBox.SelectedValue?.ToString()??"", VendorBox.SelectedValue?.ToString()??"", ModelBox.SelectedValue?.ToString()??"");
            // вызвать функцию 'search' при нажатии кнопки поиска
            SearchButton.Click += Search;
        }
#nullable enable
        /// <summary>
        /// загружает eps файл, соответствующий переданному продукту, и сохраняет его в память
        /// отдельно от этого, растеризует eps файл и отображает его в picture box для предпросмотра
        /// </summary>
        /// <param name="_pr">проукт, соответствующий картинке</param>
        public void LoadImage(Product _pr)
        {
            // если файл не существует, мы отображаем ошибку на picture box-е, и возвращаемся
            if (!File.Exists(_pr.Filepath))
            {
                PreviewErr.SetError(PreviewBox, $"Изображение по адресу {_pr.Filepath} не найдено");
                previewImage = null;
                return;
            }
            // читаем "сырой" eps файл и сохраняем в поток памяти, чтобы использовать потом
            FileStream fileStr = File.OpenRead(_pr.Filepath);
            image = new MemoryStream(File.ReadAllBytes(_pr.Filepath));

            // настройки растеризатора
            MagickReadSettings settings = new MagickReadSettings()
            { ColorType = ColorType.Grayscale, ColorSpace = ColorSpace.sRGB, Format = MagickFormat.Eps };

            // мы растеризуем eps файл сюда
            MemoryStream imgMem = new MemoryStream();

            // используем библиотеку ImageMagick, чтобы растеризовать eps
            try
            {
                // загрузить картинку из того же файлового потока, что мы использовали ранее, если так подумать, возможно, это была не лучшая идея
                MagickImage img = new MagickImage(fileStr, settings);
                // изменить размер картинки, чтобы она была чуть меньше "пикчер бокса", чтобы она поместилась хорошо
                // !! это теряет пропорции картинки !!
                img.Scale(PreviewBox.Width-5, PreviewBox.Height-5);
                // растеризуем в поток памяти
                img.Write(imgMem, MagickFormat.Png);
            }
            // если что-то пойдет не так и ImageMagick бросит исключение, мы его перехватываем
            catch (MagickException e)
            {
                // отображаем ошибку пользователю и возвращаемся
                MessageBox.Show(e.Message, "Ошибка при чтении файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // закрываем поток, не смотря получили мы ошибку или нет
            finally
            {
                fileStr.Close();
            }
            // сохранить картинку из растеризованного потока
            previewImage = Image.FromStream(imgMem);
            // отобразить её в picture box
            PreviewBox.Image = previewImage;
            // очистить все ошибки, связанные с picture box
            PreviewErr.SetError(PreviewBox, "");
            // сохранить продукт, чтобы использовать позже
            prod_cache = _pr;
        }
        /// <summary>
        /// настраивает всё перед печатью, основываясь на входных данных из drop-box-ов, отображает предпросмотр
        /// </summary>
        private void Search(object sender, EventArgs e)
        {
            // для начала удаляем предыдущую картинку
            previewImage = null;
            PreviewBox.Image = null;
            // потом пробуем загрузить новую

            // собираем всю информацию из drop box-ов
            string Device = DeviceBox.SelectedItem?.ToString() ?? "",
                   Vendor = VendorBox.SelectedItem?.ToString() ?? "",
                     Model = ModelBox.SelectedItem?.ToString() ?? "",
                     Type = TypeBox.SelectedItem?.ToString() ?? "";
            // ищем продукт
            Product? pr = FileProvider.SearchProduct(Device, Vendor, Model, Type);
            // если продукт найден
            if (pr.HasValue)
            {
                // берем строку материала, связанную с нашим продуктом
                material_cache = DataProvider.GetMaterial(pr.Value) ?? "[Нет данных]";
                // вызываем LoadImage, чтобы загрузить eps файл и отобразить его растеризованную версию
                LoadImage(pr.Value);
                // отображаем всю информацию о продукте (в правой части экрана)
                DeviceLabel.Text = "Устройство:\n" + Device;
                VendorLabel.Text = "Производитель:\n" + Vendor;
                ModelLabel.Text = "Модель:\n" + Model;
                TypeLabel.Text = "Тип:\n" + Type;
                MaterialLabel.Text = "Плёнка:\n" + material_cache;
            }
            // если ничего не найдено, отображаем ошибку на левой панели (там, где drop-box-ы)
            else
                PreviewErr.SetError(LeftPanel, "Продукт по указанным данным не найден");
        }
        /// <summary>
        /// проверяет, всё ли готово для печати, если так, делегирует печать ghostScript-у через CLI
        /// </summary>
        private void Print(object sender, EventArgs e)
        {
            // если "сырая" картинка не загружена
            if (image == null)
            {
                // отображаем ошибку и возварщаемся
                MessageBox.Show("Невозможно печатать, изображение не загружено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // генерируем название временного файла с расширением ".eps" 
            string imgFile = Path.ChangeExtension(Path.GetTempFileName(), ".eps");
            // записываем туда "сырой" eps
            File.WriteAllBytes(imgFile, image.ToArray());
            // не помню, чтобы я такое писал, наверное, это для отладки
            //MessageBox.Show(imgFile);
            // понятия не имею, что значит эта команда, но она должна говорить ghostScript-у распечатать наш файл
            string strCmdText = $"-sDEVICE=mswinpr2 -dBATCH -dNOPAUSE -dNOPROMPT -dNoCancel -dPDFFitPage \"{imgFile}\"";
            // запускаем новый спрятанный процесс
            using (Process? proc =
                Process.Start(
                    new ProcessStartInfo()
                    {
                        FileName = "GhostScript\\gswin64c.exe",
                        Arguments = strCmdText,
                        CreateNoWindow = true,
                        // перенаправляет "stdout", чтобы мы могли его потом использовать 
                        RedirectStandardOutput = true,
            })) // syntax moment
            {
                // если не удалось запустить процесс, мы отображаем ошибку и возвращаемся
                if (proc == null)
                {
                    MessageBox.Show("Не удалось запустить ghostScript", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // ждем, пока ghostScript сделает свои дела 
                proc.WaitForExit();
                // если ghostScript напечатал что-то со словом "error" (независимо от регистра), это значит, что что-то пошло не так, поэтому мы тоже отобразим ошибку
                if (proc.StandardOutput.ReadToEnd().ToLower().Contains("error"))
                    MessageBox.Show("Произошла ошибка при печати", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // добавляем запись в историю операций
            DataProvider.PushEntry(prod_cache);
            // удаляем одну единицу материала, использованного на печать
            DataProvider.DecrementAmount(Program.user.Branch, material_cache);
            // добавляем клиента по данным из text box-ов
            DataProvider.AddCostumer(new Costumer()
            {
                Phone = ClientPhoneBox.Text,
                Name = ClientNameBox.Text
            });
        }
#nullable restore
    }
}