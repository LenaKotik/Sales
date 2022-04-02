using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sales
{
    public class User
    {
        public string Name { set; get; }
        public string Code { set; get; }
        public bool IsAdmin { set; get; }
        /// <summary>
        /// index of the color do draw the profile with, calculated from user's code
        /// </summary>
        public int ProfileColorID { set; get; }
    }
}
