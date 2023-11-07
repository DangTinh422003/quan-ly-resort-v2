using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using quan_ly_resort_v2.model;
using quan_ly_resort_v2.utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quan_ly_resort_v2.DAO
{
    internal class AccountDAO
    {
        public AccountDAO() { }
        public static Account GetAccount(string username)
        {
            try
            {
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Query data
                string sql = "select * from account where account.username = @username";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();

                Account account = null;
                if (reader.Read())
                {
                    string accountUsername = reader["username"].ToString();
                    string accountPassword = reader["password"].ToString();
                    string email = reader["Email"].ToString();
                    string role = getRoleName(Convert.ToInt32(reader["Role"]));
                    account = new Account(accountUsername, accountPassword, email, role);
                }
                conn.Close();
                return account;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();

            try
            {
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "select * from account";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Account account = new Account
                    {
                        Username = reader["username"].ToString(),
                        Password = reader["password"].ToString(),
                        Create_at = Convert.ToDateTime(reader["create_at"]),
                        Role = getRoleName(Convert.ToInt32(reader["Role"])),
                        Email = reader["Email"].ToString(),
                    };

                    accounts.Add(account);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            

            return accounts;
        }

        public static String getRoleName(int role)
        {
            switch(role)
            {
                case 0: return "admin";
                case 1: return "accountant";
                default: return "employee";
            }
        }

        public static int getRoleIndex(string role)
        {
            switch (role)
            {
                case "admin": return 0;
                case "accountant": return 1;
                default: return 2;
            }
        }

        public static Account AddNewAccount(Account acc)
        {
            try
            {
                DateTime dateTime = DateTime.Now;

                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();
                string hassPassword = PasswordUils.HashingPassword(acc.Password);

                // Query data
                string sql = "INSERT INTO `account` (`username`, `password`, `email`, `create_at`, `Role`) VALUES (@username, @password, @email, @create_at, @role);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", acc.Username);
                cmd.Parameters.AddWithValue("@password", hassPassword);
                cmd.Parameters.AddWithValue("@email", acc.Email);
                cmd.Parameters.AddWithValue("@role", getRoleIndex(acc.Role));
                cmd.Parameters.AddWithValue("@create_at", dateTime.ToString("yyyy-MM-dd H:mm:ss"));
                MySqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                return acc;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static Boolean UpdateAccount(Account acc) {
            try
            {
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Query data
                string sql = "UPDATE `account` SET `Email`=@email,`Role`='@role' WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", acc.Email);
                cmd.Parameters.AddWithValue("@role", getRoleIndex(acc.Role));
                cmd.Parameters.AddWithValue("@username", acc.Username);
                MySqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static Boolean DeleteAccount(String username)
        {
            try
            {
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Query data
                string sql = "DELETE FROM `account` WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                int rowsAffected = cmd.ExecuteNonQuery(); 

                // Kiểm tra xem có bản ghi nào bị xóa hay không
                if(rowsAffected > 0)
                {
                    sql = "UPDATE `nhanvien` SET username = @new WHERE username = @username";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@new", "");
                    rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static void ChangePassword(String username,  String password)
        {
            try
            {
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string hassPassword = PasswordUils.HashingPassword(password);
                // Query data
                string sql = "UPDATE `account` SET `password`=@password WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hassPassword);
                MySqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
