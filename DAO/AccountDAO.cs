using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using quan_ly_resort_v2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.DAO
{
    internal class AccountDAO
    {
        public AccountDAO() { }
        public static Account GetAccount(string username)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "select * from account where account.username = @username";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();

                Account account = null;
                if (reader.Read())
                {
                    // Lấy dữ liệu từ cột trong database và gán cho account
                    // account = new Account(...);
                    string accountUsername = reader["username"].ToString();
                    string accountPassword = reader["password"].ToString();
                    account = new Account(accountUsername, accountPassword);
                }

                conn.Close();

                // Trả về account đã được tìm thấy, hoặc null nếu không tìm thấy.
                return account;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

    }
}
