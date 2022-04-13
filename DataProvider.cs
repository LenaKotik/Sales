using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if USE_MYSQL
using MySql.Data.MySqlClient;
#else
using System.Data.SqlClient;
#endif
#nullable enable

namespace Sales
{
    /// <summary>
    /// Class for managing exterior data, load data from the database or from a file
    /// (Yay, no longer a stub)
    /// </summary>
    static class DataProvider
    {
        static readonly string connStr = @"workstation id=qqqsales.mssql.somee.com;packet size=4096;user id=swagmav_SQLLogin_1;pwd=m1vbu3gz7c;data source=qqqsales.mssql.somee.com;persist security info=False;initial catalog=qqqsales";
        #region file system stuff
        static List<string> GetDirectories(string path)
        {
            if (Directory.Exists(path))
                return Directory.GetDirectories(path).Select(x => x.Replace(path, "")).ToList();
            return new List<string>();
        }
        public static List<string> GetDeviceData() 
            => GetDirectories(@"D:\ProjectRoot\CSharpProj\Sales\Models\");
        public static List<string> GetVendorData(string device)
            => GetDirectories(@"D:\ProjectRoot\CSharpProj\Sales\Models\" + device + '\\');
        public static List<string> GetModelData(string device, string vendor)
            => GetDirectories(@"D:\ProjectRoot\CSharpProj\Sales\Models\" + device + '\\' + vendor + '\\');
        public static List<string> GetTypeData(string device, string vendor, string model)
            => Directory.Exists(@"D:\ProjectRoot\CSharpProj\Sales\Models\" + device + '\\' + vendor + '\\' + model)? Directory.GetFiles(@"D:\ProjectRoot\CSharpProj\Sales\Models\" + device + '\\' + vendor + '\\' + model, "*.eps").Select(x => Path.GetFileNameWithoutExtension(x)).ToList() : new List<string>();

        /// <returns>null if such product does not exist, otherwise - the existing product</returns>
        public static Product? SearchProduct(string Device, string Vendor, string Model, string Type)
            => new Product(Device, Vendor, Model, Type, @"D:\ProjectRoot\CSharpProj\Sales\Models\"+Device+'\\'+Vendor+'\\'+Model+'\\'+Type + ".eps");
#endregion
#region database stuff
        public static void AddUser(User u)
        {
#if USE_MYSQL
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO Users VALUES('{u.Name}', '{u.Code}', '{u.Password}', {(u.IsAdmin ? 1 : 0)}); ", conn);
                cmd.ExecuteNonQuery();
            }
#else
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO Users VALUES('{u.Name}', '{u.Code}', '{u.Password}', {(u.IsAdmin?1:0)}); ", conn);
                cmd.ExecuteNonQuery();
            }
#endif
        }
        /// <returns>null if such user does not exist, otherwise - the user found</returns>
        public static User? VerifyUser(string code, string password)
        {
#if USE_MYSQL
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Users WHERE code = '{code}' AND password = '{password}'; ", conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                // Deserialize into list
                List<User> u = new List<User>();
                while (rdr.Read())
                    u.Add(new User()
                    {
                        Name = (string)rdr["username"],
                        Code = (string)rdr["code"],
                        Password = (string)rdr["password"],
                        IsAdmin = (bool)rdr["is_admin"],
                    });
                return u.SingleOrDefault();
            }
#else
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE code = '{code}' AND password = '{password}'; ", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                // Deserialize into list
                List<User> u = new List<User>();
                while (rdr.Read())
                    u.Add(new User()
                    {
                        Name = (string)rdr["username"],
                        Code = (string)rdr["code"],
                        Password = (string)rdr["password"],
                        IsAdmin = (bool)rdr["is_admin"],
                    });
                return u.SingleOrDefault();
            }
#endif
        }
#endregion
    }
}
#nullable restore