using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using quan_ly_resort_v2.model;
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
                    account = new Account(accountUsername, accountPassword);
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
                        Role = Convert.ToInt32(reader["Role"]),
                        Email = reader["Email"].ToString(),
                    };

                    accounts.Add(account);
                }
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
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Query data
                string sql = "INSERT INTO `account` (`username`, `password`) VALUES (@username, @password);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", acc.Username);
                cmd.Parameters.AddWithValue("@password", acc.Password);
                MySqlDataReader reader = cmd.ExecuteReader();
                return acc;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
