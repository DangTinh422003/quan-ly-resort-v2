using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using quan_ly_resort_v2.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace quan_ly_resort_v2.DAO
{
    internal class ServiceDAO
    {
        public ServiceDAO() { }

        public static List<Service> GetServiceList()
        {
            List<Service> services = new List<Service>();

            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "SELECT * FROM dichvu";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Service service = new Service
                    {
                        MaDV = reader["MaDV"].ToString(),
                        TenDV = reader["TenDV"].ToString(),
                        LoaiDV = reader["LoaiDV"].ToString(),
                        ChiTietDichVu = reader["ChiTietDichVu"].ToString(),
                        Gia = Convert.ToDouble(reader["Gia"])
                    };

                    services.Add(service);
                }
                conn.Close();
                return services;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static string GetNextMaDV()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Truy vấn MaDV cuối cùng
                string query = "SELECT MaDV FROM dichvu ORDER BY MaDV DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                string lastMaDV = cmd.ExecuteScalar() as string;

                // Kiểm tra nếu không có bất kỳ MaDV nào trong cơ sở dữ liệu
                if (string.IsNullOrEmpty(lastMaDV))
                {
                    return "DV1";
                }

                // Rút trích số id từ MaDV cuối cùng
                string[] parts = lastMaDV.Split(new string[] { "DV" }, StringSplitOptions.None);
                if (parts.Length == 2 && int.TryParse(parts[1], out int lastId))
                {
                    // Tạo MaDV mới bằng cách tăng id lên 1 và kết hợp với "DV"
                    string newMaDV = "DV" + (lastId + 1);
                    return newMaDV;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public static bool AddService(Service service)
        {
            try
            {
                string newMaDV = GetNextMaDV();
                if (string.IsNullOrEmpty(newMaDV))
                {
                    return false;
                }

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Thêm dịch vụ mới với MaDV mới
                string insertQuery = "INSERT INTO dichvu (MaDV, TenDV, LoaiDV, ChiTietDichVu, Gia) " +
                    "VALUES (@MaDV, @TenDV, @LoaiDV, @ChiTietDichVu, @Gia)";
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@MaDV", newMaDV);
                cmd.Parameters.AddWithValue("@TenDV", service.TenDV);
                cmd.Parameters.AddWithValue("@LoaiDV", service.LoaiDV);
                cmd.Parameters.AddWithValue("@ChiTietDichVu", service.ChiTietDichVu);
                cmd.Parameters.AddWithValue("@Gia", service.Gia);

                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool UpdateService(Service service)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string updateQuery = "UPDATE dichvu " +
                    "SET TenDV = @TenDV, LoaiDV = @LoaiDV, ChiTietDichVu = @ChiTietDichVu, Gia = @Gia " +
                    "WHERE MaDV = @MaDV";

                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@MaDV", service.MaDV);
                cmd.Parameters.AddWithValue("@TenDV", service.TenDV);
                cmd.Parameters.AddWithValue("@LoaiDV", service.LoaiDV);
                cmd.Parameters.AddWithValue("@ChiTietDichVu", service.ChiTietDichVu);
                cmd.Parameters.AddWithValue("@Gia", service.Gia);

                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool DeleteService(string maDV)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string deleteQuery = "DELETE FROM dichvu WHERE MaDV = @MaDV";

                MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@MaDV", maDV);

                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static Service GetServiceByMaDV(string maDV)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string selectQuery = "SELECT * FROM dichvu WHERE MaDV = @MaDV";

                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                cmd.Parameters.AddWithValue("@MaDV", maDV);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Service service = new Service
                    {
                        MaDV = reader["MaDV"].ToString(),
                        TenDV = reader["TenDV"].ToString(),
                        LoaiDV = reader["LoaiDV"].ToString(),
                        ChiTietDichVu = reader["ChiTietDichVu"].ToString(),
                        Gia = Convert.ToDouble(reader["Gia"])
                    };

                    conn.Close();
                    return service;
                }
                else
                {
                    conn.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
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

                string sql = "SELECT * FROM dichvu";
                switch (typeValue)
                {
                    case "Mã dịch vụ":
                        sql += " WHERE MaDV LIKE @filterValue";
                        break;
                    case "Tên dịch vụ":
                        sql += " WHERE TenDV LIKE @filterValue";
                        break;
                    case "Loại dịch vụ":
                        sql += " WHERE LoaiDV LIKE @filterValue";
                        break;
                    case "Giá dịch vụ":
                        sql += " WHERE Gia LIKE @filterValue";
                        break;
                    default:
                        sql += " WHERE " + typeValue + " LIKE @filterValue";
                        break;
                }

                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@filterValue", "%" + filterValue + "%");
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
    }
}