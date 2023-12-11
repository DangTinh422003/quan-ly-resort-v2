using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using quan_ly_resort_v2.model;
using quan_ly_resort_v2.utils;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
                //string sql = "select * from account where account.username = @username";
                //MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAccount";
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();

                Account account = null;
                if (reader.Read())
                {
                    string accountUsername = reader["username"].ToString();
                    string accountPassword = reader["password"].ToString();
                    string email = reader["Email"].ToString();
                    string role = reader["Role"].ToString();
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

                //string sql = "select * from account";
                //MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAccounts";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Account account = new Account
                    {
                        Username = reader["username"].ToString(),
                        Password = reader["password"].ToString(),
                        Create_at = Convert.ToDateTime(reader["create_at"]),
                        Role = reader["Role"].ToString(),
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

        public static Account AddNewAccount(Account acc)
        {
            try
            {
                DateTime dateTime = DateTime.Now;

                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Query data
                //string sql = "INSERT INTO `account` (`username`, `password`, `email`, `create_at`, `Role`) VALUES (@username, @password, @email, @create_at, @role);";
                //MySqlCommand cmd = new MySqlCommand(sql, conn);

                string hassPassword = PasswordUils.HashingPassword(acc.Password);

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddNewAccount";
                cmd.Parameters.AddWithValue("@username", acc.Username);
                cmd.Parameters.AddWithValue("@password", hassPassword);
                cmd.Parameters.AddWithValue("@email", acc.Email);
                cmd.Parameters.AddWithValue("@role", acc.Role);
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

        public static Boolean UpdateAccount(Account acc)
        {
            try
            {
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Query data
                //string sql = "UPDATE `account` SET `Email`=@email,`Role`=@role WHERE username = @username";
                //MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateAccount";
                cmd.Parameters.AddWithValue("@username", acc.Username);
                cmd.Parameters.AddWithValue("@email", acc.Email);
                cmd.Parameters.AddWithValue("@role", acc.Role);
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
                //string sql = "DELETE FROM `account` WHERE username = @username";
                //MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteAccount";
                cmd.Parameters.AddWithValue("@username", username);
                int rowsAffected = cmd.ExecuteNonQuery();

                // Kiểm tra xem có bản ghi nào bị xóa hay không
                if (rowsAffected > 0)
                {
                    var sql = "UPDATE `nhanvien` SET username = @new WHERE username = @username";
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

        public static void ChangePassword(String username, String password)
        {
            try
            {
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string hassPassword = PasswordUils.HashingPassword(password);
                // Query data
                //string sql = "UPDATE `account` SET `password`=@password WHERE username = @username";
                //MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ChangePassword";
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

        public static Account getByEmail(String email)
        {
            try
            {
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Query data
                //string sql = "select * from account where account.Email = @email";
                //MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetByEmail";
                cmd.Parameters.AddWithValue("@email", email);
                MySqlDataReader reader = cmd.ExecuteReader();

                Account account = null;
                if (reader.Read())
                {
                    string accountUsername = reader["username"].ToString();
                    string accountPassword = reader["password"].ToString();
                    string emailAcc = reader["Email"].ToString();
                    string role = reader["Role"].ToString();
                    account = new Account(accountUsername, accountPassword, emailAcc, role);
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

        public static bool changePasswordByEmail(string email, string newPassword)
        {
            try
            {
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Query data
                //string sql = "UPDATE `account` SET `password`=@newPassword WHERE Email = @email";
                //MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ChangePasswordByEmail";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
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

        public static DataTable FilterByField(string typeValue, string filterValue)
        {
            try
            {
                typeValue = typeValue.Trim();
                filterValue = filterValue.Trim();

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "SELECT * FROM account";
                switch (typeValue)
                {
                    case "Username":
                        sql += " WHERE username LIKE @filterValue";
                        break;
                    case "Email":
                        sql += " WHERE Email LIKE @filterValue";
                        break;
                    default:
                        sql += " WHERE " + typeValue + " like @filterValue";
                        break;
                }

                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@filterValue", "%" + filterValue + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                conn.Close();

                return table;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
