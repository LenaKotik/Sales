using System;
using System.IO;
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
        static List<string> GetDirectories(string path)
        {
            return Directory.GetDirectories(path).Select(x => x.Replace(path, "")).ToList();
        }
        public static List<string> GetDeviceData()
        {
            return new List<string> { "Телевизор", "Холодильник", "Чайник" };
        }
        public static List<string> GetVendorData(string device)
        {
            return GetDirectories(@"D:\ProjectRoot\CSharpProj\Sales\Models\");
        }
        public static List<string> GetModelData(string device, string vendor)
        {
            return GetDirectories(@"D:\ProjectRoot\CSharpProj\Sales\Models\" + vendor + '\\');
        }
        public static List<string> GetTypeData(string device, string vendor, string model)
        {
            return Directory.GetFiles(@"D:\ProjectRoot\CSharpProj\Sales\Models\" + vendor + '\\' + model, "*.eps").Select(x => Path.GetFileNameWithoutExtension(x)).ToList();
        }
        public static void AddUser(User u)
        {

        }
        /// <returns>null if such user does not exist, otherwise - the user found</returns>
        public static User? VerifyUser(string code, string password)
        {
            if (password == "Swordfish") return null;
            return new User { Code = code, Name = "Vlat", IsAdmin = true };
        }
        /// <returns>null if such product does not exist, otherwise - the existing product</returns>
        public static Product? SearchProduct(string Device, string Vendor, string Model, string Type)
        {
            return new Product(Device, Vendor, Model, Type, @"D:\ProjectRoot\CSharpProj\Sales\Models\"+Vendor+'\\'+Model+'\\'+Type + ".eps");
        }
    }
}
#nullable restore