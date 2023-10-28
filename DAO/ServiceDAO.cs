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
                        ChiTietDichVu = reader["ChiTietDichVu"].ToString(),
                        Gia = Convert.ToDouble(reader["Gia"]),
                        Picture = (byte[])reader["Image"] // Trích xuất dữ liệu hình ảnh
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


        public static bool AddService(Service service)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Trước tiên, kiểm tra xem MaDV đã tồn tại chưa
                string checkMaDVQuery = "SELECT COUNT(*) FROM dichvu WHERE MaDV = @MaDV";
                MySqlCommand checkMaDVCmd = new MySqlCommand(checkMaDVQuery, conn);
                checkMaDVCmd.Parameters.AddWithValue("@MaDV", service.MaDV);

                int count = Convert.ToInt32(checkMaDVCmd.ExecuteScalar());

                if (count > 0)
                {
                    // MaDV đã tồn tại, bạn có thể xử lý logic ở đây nếu cần thiết
                    conn.Close();
                    return false;
                }

                // Nếu MaDV chưa tồn tại, thêm dịch vụ mới
                string insertQuery = "INSERT INTO dichvu (MaDV, TenDV, ChiTietDichVu, Gia, Image) VALUES (@MaDV, @TenDV, @ChiTietDichVu, @Gia, @Image)";
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@MaDV", service.MaDV);
                cmd.Parameters.AddWithValue("@TenDV", service.TenDV);
                cmd.Parameters.AddWithValue("@ChiTietDichVu", service.ChiTietDichVu);
                cmd.Parameters.AddWithValue("@Gia", service.Gia);
                cmd.Parameters.AddWithValue("@Image", service.Picture); // Gán dữ liệu hình ảnh cho tham số @Image

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

                string updateQuery = "UPDATE dichvu SET TenDV = @TenDV, ChiTietDichVu = @ChiTietDichVu, Gia = @Gia, Image = @Image WHERE MaDV = @MaDV";

                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@MaDV", service.MaDV);
                cmd.Parameters.AddWithValue("@TenDV", service.TenDV);
                cmd.Parameters.AddWithValue("@ChiTietDichVu", service.ChiTietDichVu);
                cmd.Parameters.AddWithValue("@Gia", service.Gia);
                cmd.Parameters.AddWithValue("@Image", service.Picture); // Gán dữ liệu hình ảnh cho tham số @Image

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
                        ChiTietDichVu = reader["ChiTietDichVu"].ToString(),
                        Gia = Convert.ToDouble(reader["Gia"]),
                        Picture = (byte[])reader["Image"] // Lấy dữ liệu hình ảnh từ trường "Image" trong cơ sở dữ liệu
                    };

                    conn.Close();
                    return service;
                }
                else
                {
                    conn.Close();
                    return null; // Trả về null nếu không tìm thấy dịch vụ với MaDV tương ứng
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
                    case "Thông tin dịch vụ":
                        sql += " WHERE ChiTietDichVu LIKE @filterValue";
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
