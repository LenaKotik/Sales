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
            HistoryView.DataSource = DataProvider.GetHistory().Select(x => x.ToString()).ToList();
            CostumersView.DataSource = DataProvider.GetCostumers();
            StatisticsView.DataSource = GetStatistics();
            ReloadButton.Click += (o, e) => 
            {
                HistoryView.DataSource = DataProvider.GetHistory().Select(x => x.ToString()).ToList();
                CostumersView.DataSource = DataProvider.GetCostumers();
                StatisticsView.DataSource = GetStatistics();
            };
            GoBackButton.Click += GoBack;
            OpenStorageButt.Click += (o, e) => new StorageManager().ShowDialog();
            AddUserButton.Click += (o, e) => new AddUserDialog().ShowDialog();
            AddProductButton.Click += (o, e) => new AddProductDialog().ShowDialog();
            DeleteUserButton.Click += (o, e) => DataProvider.DeleteUser();
            DeleteCostumersButton.Click += (o, e) => DataProvider.DeleteCostumers();
            DeleteHistoryButton.Click += (o, e) => DataProvider.DeleteHistory();
        }
        private void GoBack(object sender, EventArgs e)
        {
            Form last = this.OwnedForms[0];
            this.RemoveOwnedForm(last);
            last.Show();
            this.Close();
        }
        private List<StatisticsViewModel> GetStatistics()
        {
            List<StatisticsViewModel> res = new();
            List<Entry> history = DataProvider.GetHistory();
            List<string> users = history.Select(x => x.userCode).Distinct().ToList();
            foreach (string u in users)
            {
                StatisticsViewModel s = new() { UserCode = u };
                List<Entry> subset = history.Where(x => x.userCode == u).ToList();
                DateTime now = DateTime.UtcNow.AddHours(3);
                s.Month = subset.Count(x => x.time >= now.AddMonths(-1));
                s.Week = subset.Count(x => x.time >= now.AddDays(-7));
                s.Day = subset.Count(x => x.time >= now.AddDays(-1));
                res.Add(s);
            }
            res = res.OrderByDescending(x => x.Day).ThenByDescending(x => x.Week).ThenByDescending(x => x.Month).ToList();
            return res;
        }
    }
}
