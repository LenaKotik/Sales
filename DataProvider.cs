using System;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
#nullable enable

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
    /// <summary>
    /// Class for managing exterior data, load data from the database or from a file
    /// (Yay, no longer a stub)
    /// </summary>
    static class DataProvider
    {
        #region file system stuff
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
            => Directory.Exists("Models\\" + device + '\\' + vendor + '\\' + model)? Directory.GetFiles("Models\\" + device + '\\' + vendor + '\\' + model, "*.eps").Select(x => Path.GetFileNameWithoutExtension(x)).ToList() : new List<string>();

        /// <returns>null if such product does not exist, otherwise - the existing product</returns>
        public static Product? SearchProduct(string Device, string Vendor, string Model, string Type)
            => new Product(Device, Vendor, Model, Type, "Models\\"+Device+'\\'+Vendor+'\\'+Model+'\\'+Type + ".eps");
        #endregion
        #region database stuff
        static readonly string connStr = @"workstation id=qqqsales.mssql.somee.com;packet size=4096;user id=swagmav_SQLLogin_1;pwd=m1vbu3gz7c;data source=qqqsales.mssql.somee.com;persist security info=False;initial catalog=qqqsales";
        #region Users
        public static void AddUser(User u)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new($"INSERT INTO Users VALUES('{u.Name}', '{u.Code}', '{u.Password}', {(u.IsAdmin?1:0)}); ", conn);
                cmd.ExecuteNonQuery();
            }
        }
        /// <returns>null if such user does not exist, otherwise - the user found</returns>
        public static User? VerifyUser(string code, string password)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new($"SELECT * FROM Users WHERE code = '{code}' AND password = '{password}'; ", conn);
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
        }
        public static void DeleteUser()
        {

        }
        #endregion
        #region History
        public static List<Entry> GetHistory()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new("SELECT * FROM History ORDER BY time_ DESC", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                List<Entry> e = new List<Entry>();
                while (rdr.Read())
                    e.Add(new Entry()
                    {
                        time = ((DateTime)rdr["time_"]).AddHours(3),
                        userCode = (string)rdr["user_"],
                        product = (string)rdr["product"]
                    });
                return e;
            }
        }
        public static void PushEntry(Product pr)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new($"INSERT INTO History VALUES (SYSUTCDATETIME(), '{Program.user.Code}', N'{pr}');", conn);
                cmd.ExecuteNonQuery();
            }
        }
        public static void DeleteHistory()
        {

        }
        #endregion
        #region Materials
        public static string? GetMaterial(Product pr)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new($"SELECT material_name FROM Materials WHERE product = N'{pr}'", conn);
                return cmd.ExecuteScalar()?.ToString();
            }
        }
        /// <param name="exists">if true, updates an existing entry, otherwise - creates a new one</param>
        public static void SetMaterial(Product pr, string mat, bool exists)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new(exists? $"UPDATE Materials SET material_name = N'{mat}' WHERE product = N'{pr}'" : $"INSERT INTO Materials VALUES (N'{pr}', N'{mat}'); ", conn);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #endregion
    }
}
#nullable restore