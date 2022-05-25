// Made by LenaKotik
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Sales
{
    public partial class AdminForm : Form
    {
        /// <summary>
        /// выравнивает элементы 
        /// </summary>
        void RelocateControls()
        {
            this.CenterControl(HistLabel, new Point(0, Screen.GetWorkingArea(this).Height / 2 - HistoryView.Height - 10));
            this.CenterControl(ReloadButton, new Point(-200, Screen.GetWorkingArea(this).Height / 2 - HistoryView.Height - 10));
            this.CenterControl(OpenStorageButt, new Point(-Screen.GetWorkingArea(this).Width / 2 + 200, -200));
            this.CenterControl(AddUserButton, new Point(-Screen.GetWorkingArea(this).Width / 2 + 200, -150));
            this.CenterControl(AddProductButton, new Point(-Screen.GetWorkingArea(this).Width / 2 + 200, -100));
            this.CenterControl(DeleteUserButton, new Point(-Screen.GetWorkingArea(this).Width / 2 + 200, 0));
            this.CenterControl(DeleteHistoryButton, new Point(-Screen.GetWorkingArea(this).Width / 2 + 200, 50));
            this.CenterControl(DeleteCostumersButton, new Point(400, 30));
            this.CenterControl(StatisticsView, new Point(0, -100));
            this.CenterControl(CostumersView, new Point(400, -100));
        }
        public AdminForm()
        {
            InitializeComponent();
            RelocateControls();
            // отображаем историю
            HistoryView.DataSource = DataProvider.GetHistory().Select(x => x.ToString()).ToList();
            // отображаем клиентов
            CostumersView.DataSource = DataProvider.GetCostumers();
            // отображаем статистику
            StatisticsView.DataSource = GetStatistics();
            // обновляем все данные при нажатии кнопки обновления
            ReloadButton.Click += (o, e) => 
            {
                HistoryView.DataSource = DataProvider.GetHistory().Select(x => x.ToString()).ToList();
                CostumersView.DataSource = DataProvider.GetCostumers();
                StatisticsView.DataSource = GetStatistics();
            };
            // вызываем GoBack при нажатии кнопки "назад"
            GoBackButton.Click += GoBack;
            // открываем менеджер скалада при нажатии соответствующей кнопки
            OpenStorageButt.Click += (o, e) => new StorageManager().ShowDialog();
            // открываем окно добавления пользователя/добавления продукта/удаления пользователя при нажатии соответствующих кнопок
            AddUserButton.Click += (o, e) => new AddUserDialog().ShowDialog();
            AddProductButton.Click += (o, e) => new AddProductDialog().ShowDialog();
            DeleteUserButton.Click += (o, e) => DataProvider.DeleteUser();
            // открываем окно очищения истории/базы клиентов при нажатии соотвествующих кнопок
            DeleteCostumersButton.Click += (o, e) => DataProvider.DeleteCostumers();
            DeleteHistoryButton.Click += (o, e) => DataProvider.DeleteHistory();
        }
        // возвращает в предыдущее окно
        private void GoBack(object sender, EventArgs e)
        {
            Form last = this.OwnedForms[0];
            this.RemoveOwnedForm(last);
            last.Show();
            this.Close();
        }
        // запрашивает историю операций из базы данных и формирует из нее статистику продавцов
        private List<StatisticsViewModel> GetStatistics()
        {
            List<StatisticsViewModel> res = new();
            // запрашиваем историю
            List<Entry> history = DataProvider.GetHistory();
            // выбираем оттуда продавцов (берем только уникальные записи)
            List<string> users = history.Select(x => x.userCode).Distinct().ToList();
            // проходимся по всем продавцам
            foreach (string u in users)
            {
                StatisticsViewModel s = new() { UserCode = u };
                // выделяем все операции, совершенные данным продавцом
                List<Entry> subset = history.Where(x => x.userCode == u).ToList();
                // берем время по мск
                DateTime now = DateTime.UtcNow.AddHours(3);
                // считаем операции, совершенные меньше месяца назад
                s.Month = subset.Count(x => x.time >= now.AddMonths(-1));
                // считаем операции, совершенные меньше семи дней назад
                s.Week = subset.Count(x => x.time >= now.AddDays(-7));
                // считаем операции, совершенные меньше дня назад
                s.Day = subset.Count(x => x.time >= now.AddDays(-1));
                res.Add(s);
            }
            // сортируем статистику, сначала по операциям за сегодня, потом по операциям за неделю, потом за месяц
            res = res.OrderByDescending(x => x.Day).ThenByDescending(x => x.Week).ThenByDescending(x => x.Month).ToList();
            return res;
        }
    }
}
