using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable enable

namespace Sales
{
    /// <summary>
    /// Class for managing exterior data, load data from the database or from a file
    /// (for now it's a stub)
    /// </summary>
    static class DataProvider
    {
        /// <returns>List of 3 lists, first is devices avaliable, second is device vendors avaliable, and last is device models avaliable</returns>
        public static List<List<string>> GetDeviceData()
        {
            return new List<List<string>> { new List<string>{ "Телефон", "Телевизор", "Телепузик"  }, new List<string>{ "Apple", "Pen", "Pineapple" }, new List<string> { "1", "2", "3" } };
        }
        /// <returns>null if such user does not exist, otherwise - the user found</returns>
        public static User? VerifyUser(string code, string password)
        {
            if (password == "Swordfish") return null;
            return new User { Code = code, Name = "Vlat", IsAdmin = true };
        }
        /// <returns>null if such product does not exist, otherwise - the existing product</returns>
        public static Product? SearchProduct(string Device, string Vendor, string Model)
        {
            if (Model == "3") return null;
            return new Product(Device, Vendor, Model, @"D:\ProjectRoot\CSharpProj\Sales\Models\Google\Pixel 3A XL\Vector\3a зад уши Logo.eps");
        }
    }
}
#nullable restore