using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using quan_ly_resort_v2.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quan_ly_resort_v2.DAO
{
    public class CustomerDAO
    {
        public static int countCustomer()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "select count(*) from khachhang";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                int count = 0;
                if (reader.Read())
                {
                    count = int.Parse(reader[0].ToString());
                }
                conn.Close();
                return count;
            }
            catch (Exception e)
            {
                Console.WriteLine("countCustomer: " + e.Message);
                return 0;
            }
        }


        public static DataTable getCustomers()
        {
            try
            {
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Query data
                string sql = "select * from khachhang";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception e)
            {
                Console.WriteLine(" getCustomerById :" + e.Message);
                return null;
            }
        }

        public static bool deleteCustomerById(string id)
        {
            try
            {
                // check exist in database
                Customer customer = getCustomerById(id);
                if (customer == null)
                {
                    return false;
                }

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "delete from khachhang where Cccd = @id";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = command.ExecuteReader();
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return false;
            }
        }

        public static Customer getCustomerById(string id)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "select * from khachhang where Cccd = @id";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = command.ExecuteReader();

                Customer customer = null;
                if (reader.Read())
                {
                    customer = new Customer(
                        reader["Cccd"].ToString(),
                        reader["HoTen"].ToString(),
                        DateTime.Parse(reader["NgaySinh"].ToString()),
                        reader["Sdt"].ToString(),
                        reader["Email"].ToString(),
                        reader["DiaChi"].ToString()
                        );
                }
                else
                {
                    return null;
                }
                conn.Close();
                return customer;
            }
            catch (Exception e)
            {
                Console.WriteLine(" getCustomerById :" + e.Message);
                return null;
            }
        }

        public static bool addNewCustomer(Customer ctm)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "insert into khachhang values(@id,@name,@dateOfBirth,@phoneNumber,@email,@address)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@id", ctm.Id);
                command.Parameters.AddWithValue("@name", ctm.Fullname);
                command.Parameters.AddWithValue("@dateOfBirth", ctm.DateOfBirth.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@phoneNumber", ctm.PhoneNumber);
                command.Parameters.AddWithValue("@address", ctm.Address);
                command.Parameters.AddWithValue("@email", ctm.Email);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return false;
            }
        }
        public static DataTable filterByField(string typeValue, string filterValue)
        {
            try
            {
                typeValue = typeValue.Trim();
                filterValue = filterValue.Trim();

                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Query data
                string sql = "select * from khachhang";
                switch (typeValue)
                {
                    case "Căn cước công dân":
                        sql += " where Cccd like @filterValue";
                        break;
                    case "Họ và tên":
                        sql += " where HoTen like @filterValue";
                        break;
                    case "Số điện thoại":
                        sql += " where Sdt like @filterValue";
                        break;
                    case "Địa chỉ":
                        sql += " where DiaChi like @filterValue";
                        break;
                    case "Email":
                        sql += " where email like @filterValue";
                        break;
                    default:
                        sql += " where " + typeValue + " like @filterValue";
                        break;
                }
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@filterValue", "%" + filterValue.ToString() + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static bool updateCustomer(Customer ctm)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "update khachhang set HoTen = @name, NgaySinh = @dateOfBirth, Sdt = @phoneNumber, Email = @email, DiaChi = @address where Cccd = @id";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@id", ctm.Id);
                command.Parameters.AddWithValue("@name", ctm.Fullname);
                command.Parameters.AddWithValue("@dateOfBirth", ctm.DateOfBirth);
                command.Parameters.AddWithValue("@phoneNumber", ctm.PhoneNumber);
                command.Parameters.AddWithValue("@address", ctm.Address);
                command.Parameters.AddWithValue("@email", ctm.Email);
                MySqlDataReader reader = command.ExecuteReader();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("updateCustomer: " + e.Message);
                return false;
            }
        }
    }
}
