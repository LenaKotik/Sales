// Made by LenaKotik
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;
#nullable enable

namespace Sales
{
    /// <summary>
    /// Class for managing extern data, loads data to/from the database
    /// </summary>
    static class DataProvider
    {  
        static readonly string connStr = @"workstation id=qqqsales.mssql.somee.com;packet size=4096;user id=swagmav_SQLLogin_1;pwd=m1vbu3gz7c;data source=qqqsales.mssql.somee.com;persist security info=False;initial catalog=qqqsales";
        #region Users
        public static void AddUser(User u)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new($"INSERT INTO Users VALUES('{u.Name}','{u.Code}','{u.Password}',{u.Branch},{(u.IsAdmin?1:0)}); ", conn);
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
            if (new PasswordConfirmationDialog().ShowDialog() != DialogResult.OK) return;
            UserDeletionDialog dialog = new();
            if (dialog.ShowDialog() != DialogResult.OK) return;
            string code = dialog.Code;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new($"DELETE FROM Users WHERE code = '{code}'; ", conn);
                if (cmd.ExecuteNonQuery() != 1)
                    MessageBox.Show("Указанный пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            if (new PasswordConfirmationDialog().ShowDialog() != DialogResult.OK) return;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new("DELETE FROM History;", conn);
                cmd.ExecuteNonQuery();
            }
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
        #region Costumers
        public static void AddCostumer(Costumer c)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new($"INSERT INTO Costumers VALUES ('{c.Phone}', N'{c.Name}')", conn);
                cmd.ExecuteNonQuery();
            }
        }
        public static void DeleteCostumers()
        {
            if (new PasswordConfirmationDialog().ShowDialog() != DialogResult.OK) return;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new("DELETE FROM Costumers", conn);
                cmd.ExecuteNonQuery();
            }
        }
        public static List<Costumer> GetCostumers()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new("SELECT phone, name FROM Costumers", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                List<Costumer> res = new();
                while (rdr.Read())
                    res.Add(new Costumer()
                    {
                        Phone = (string)rdr["phone"],
                        Name = (string)rdr["name"]
                    });
                return res;
            }
        }
        #endregion
        #region Storage
        public static List<StorageItem> GetStorageItems(byte branch)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new($"SELECT material_name, amount FROM Storage WHERE branch = {branch}", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                List<StorageItem> res = new List<StorageItem>();
                while (rdr.Read())
                    res.Add(new StorageItem()
                    {
                        Material = (string)rdr["material_name"],
                        Amount = (short)rdr["amount"]
                    });
                return res;
            }
        }
        public static void DecrementAmount(byte branch, string material)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new($"UPDATE Storage SET amount = amount-1 WHERE branch = {branch} AND material_name = N'{material}'; ", conn);
                cmd.ExecuteNonQuery();
            }
        }
        public static void UpdateStorage(byte branch, List<StorageItem> items)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new($"DELETE FROM Storage WHERE branch = {branch}; INSERT INTO Storage VALUES\n", conn);
                foreach (StorageItem item in items)
                    cmd.CommandText += $"({branch}, N'{item.Material}', {item.Amount}),";
                cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 1) + ';';
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
    }
}
#nullable restore