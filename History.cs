using System;
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
    }
    static class History
    {
        static Stack<Entry> _data;
        public static void Add(Product pr) => _data.Push(new Entry() // syntax moment
        {
            time = DateTime.Now,
            userCode = Program.user.Code,
            product = pr.ToString()
        });
        static public Stack<Entry> GetData() => _data;
    }
}
