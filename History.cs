using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    struct Entry
    {
        [DisplayName("Время")]
        public DateTime time { set; get; }
        [DisplayName("Пользователь")]
        public string userCode { set; get; }
        [DisplayName("Модель")]
        public string product { set; get; }
        public override string ToString() => 
            $"Пользователь [{userCode}] распечатал \'{product}\' в {time} по МСК";
    }
    static class History
    {
        public static Stack<Entry> _data = new Stack<Entry>();
        public static void Add(Product pr) => _data.Push(new Entry() // syntax moment
        {
            time = DateTime.UtcNow.AddHours(3), // МСК = UTC + 3
            userCode = Program.user.Code,
            product = pr.ToString()
        });
    }
}
