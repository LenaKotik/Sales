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
using System.Runtime.InteropServices;
/*
* TODO:
* +1. Statistics
* 2. Loyalty program
* 3. Storage
* +4. User deletion
* +5. History deletion
*/
namespace Sales
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.CenterControl(HistLabel, new Point(0, Screen.GetWorkingArea(this).Height / 2 - HistoryView.Height - 10));
            this.CenterControl(ReloadButton, new Point(-200, Screen.GetWorkingArea(this).Height / 2 - HistoryView.Height - 10));
            this.CenterControl(AddUserButton, new Point(-Screen.GetWorkingArea(this).Width / 2 + 200, -200));
            this.CenterControl(AddProductButton, new Point(-Screen.GetWorkingArea(this).Width / 2 + 200, -100));
            this.CenterControl(DeleteUserButton, new Point(-Screen.GetWorkingArea(this).Width / 2 + 200, 0));
            this.CenterControl(DeleteHistoryButton, new Point(-Screen.GetWorkingArea(this).Width / 2 + 200, 100));
            this.CenterControl(StatisticsView, new Point(0, -100));
            HistoryView.DataSource = DataProvider.GetHistory().Select(x => x.ToString()).ToList();
            StatisticsView.DataSource = GetStatistics();
            ReloadButton.Click += (o, e) => 
            {
                HistoryView.DataSource = DataProvider.GetHistory().Select(x => x.ToString()).ToList();
                StatisticsView.DataSource = GetStatistics();
            };
            GoBackButton.Click += GoBack;
            AddUserButton.Click += (o, e) => new AddUserDialog().ShowDialog();
            AddProductButton.Click += (o, e) => new AddProductDialog().ShowDialog();
            DeleteUserButton.Click += (o,e) => DataProvider.DeleteUser();
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
    struct StatisticsViewModel
    {
        [DisplayName("Пользователь")]
        public string UserCode { set; get; }
        [DisplayName("За День")]
        public int Day { set; get; }
        [DisplayName("За Неделю")]
        public int Week { set; get; }
        [DisplayName("За Месяц")]
        public int Month { set; get; }
    }
}
