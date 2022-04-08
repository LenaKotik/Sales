using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text;
using System.IO;
using ImageMagick;

namespace Sales
{
    static class Program
    {
        public static User user { set; get; }
        static string HistoryFile = "History.json";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (File.Exists(HistoryFile))
                History._data = JsonSerializer.Deserialize<Stack<Entry>>(File.ReadAllText(HistoryFile, Encoding.UTF8));

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
            using (FileStream fHist = File.Create(HistoryFile))
            {
                fHist.Write(Encoding.UTF8.GetBytes(JsonSerializer.Serialize<Stack<Entry>>(History._data)));
                fHist.Flush();
            }
        }
    }
}
