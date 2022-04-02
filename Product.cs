using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    public struct Product
    {
        public string Device { set; get; }
        public string Vendor { set; get; }
        public string Model { set; get; }
        public string Filepath { set; get; }
        public Product(string D, string V, string M, string F)
        {
            Device = D;
            Vendor = V;
            Model = M;
            Filepath = F;
        }
    }
}
