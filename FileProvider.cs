// Made by LenaKotik
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Sales
{
    /// <summary>
    /// Class for managing extern data, loads data to/from files
    /// </summary>
    static class FileProvider
    {
        static List<string> GetDirectories(string path)
        {
            if (Directory.Exists(path))
                return Directory.GetDirectories(path).Select(x => x.Replace(path, "")).ToList();
            return new List<string>();
        }
        public static List<string> GetDeviceData()
            => GetDirectories("Models\\");
        public static List<string> GetVendorData(string device)
            => GetDirectories("Models\\" + device + '\\');
        public static List<string> GetModelData(string device, string vendor)
            => GetDirectories("Models\\" + device + '\\' + vendor + '\\');
        public static List<string> GetTypeData(string device, string vendor, string model)
            => Directory.Exists("Models\\" + device + '\\' + vendor + '\\' + model) ? Directory.GetFiles("Models\\" + device + '\\' + vendor + '\\' + model, "*.eps").Select(x => Path.GetFileNameWithoutExtension(x)).ToList() : new List<string>();
        public static void DeleteProduct(Product pr)
        {
            if (!File.Exists(pr.Filepath)) return;
            File.Delete(pr.Filepath);
            pr.Filepath = pr.Filepath.Remove(pr.Filepath.LastIndexOf('\\'));
            if (Directory.GetFiles(pr.Filepath).Length == 0)
            {
                while (Directory.GetDirectories(pr.Filepath).Length == 0)
                {
                    Directory.Delete(pr.Filepath);
                    pr.Filepath = pr.Filepath.Remove(pr.Filepath.LastIndexOf('\\'));
                }
            }
        }

        /// <returns>null if such product does not exist, otherwise - the existing product</returns>
        public static Product? SearchProduct(string Device, string Vendor, string Model, string Type)
            => new Product(Device, Vendor, Model, Type, "Models\\" + Device + '\\' + Vendor + '\\' + Model + '\\' + Type + ".eps");
    }
}
