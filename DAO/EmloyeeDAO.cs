using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using quan_ly_resort_v2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace quan_ly_resort_v2.DAO
{
    internal class EmployeeDAO
    {
        public EmployeeDAO() { }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Query data
                string sql = "SELECT * FROM nhanvien";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Đọc dữ liệu và thêm vào danh sách employees
                while (reader.Read())
                {
                    Employee employee = new Employee
                    {
                        MaNV = reader["MaNV"].ToString(),
                        TenNV = reader["TenNV"].ToString(),
                        Sdt = reader["Sdt"].ToString(),
                        Email = reader["Email"].ToString(),
                        NgaySinh = (DateTime)reader["NgaySinh"],
                        DiaChi = reader["DiaChi"].ToString(),
                        Cccd = Convert.ToInt32(reader["Cccd"]),
                        Luong = Convert.ToDouble(reader["Luong"]),
                        NgayVaoLam = (DateTime)reader["NgayVaoLam"],    
                    };

                    employees.Add(employee);
                }

                conn.Close();

                return employees;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static bool AddEmployee(Employee newEmployee)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Xây dựng truy vấn INSERT
                string insertQuery = "INSERT INTO nhanvien (MaNV, TenNV, Sdt, Email, NgaySinh, DiaChi, Cccd, Luong, NgayVaoLam) " +
                                    "VALUES (@MaNV, @TenNV, @Sdt, @Email, @NgaySinh, @DiaChi, @Cccd, @Luong, @NgayVaoLam)";

                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@MaNV", newEmployee.MaNV);
                cmd.Parameters.AddWithValue("@TenNV", newEmployee.TenNV);
                cmd.Parameters.AddWithValue("@Sdt", newEmployee.Sdt);
                cmd.Parameters.AddWithValue("@Email", newEmployee.Email);
                cmd.Parameters.AddWithValue("@NgaySinh", newEmployee.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", newEmployee.DiaChi);
                cmd.Parameters.AddWithValue("@Cccd", newEmployee.Cccd);
                cmd.Parameters.AddWithValue("@Luong", newEmployee.Luong);
                cmd.Parameters.AddWithValue("@NgayVaoLam", newEmployee.NgayVaoLam);

                // Thực hiện truy vấn INSERT
                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                // Kiểm tra xem có bản ghi nào được thêm hay không
                return rowsAffected > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false; // Xử lý lỗi và trả về false nếu có lỗi
            }
        }

        public static bool UpdateEmployee(Employee employee)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Xây dựng truy vấn UPDATE
                string updateQuery = "UPDATE nhanvien SET TenNV = @TenNV, Sdt = @Sdt, Email = @Email, NgaySinh = @NgaySinh, DiaChi = @DiaChi, Cccd = @Cccd, Luong = @Luong, NgayVaoLam = @NgayVaoLam WHERE MaNV = @MaNV";

                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@MaNV", employee.MaNV);
                cmd.Parameters.AddWithValue("@TenNV", employee.TenNV);
                cmd.Parameters.AddWithValue("@Sdt", employee.Sdt);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@NgaySinh", employee.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", employee.DiaChi);
                cmd.Parameters.AddWithValue("@Cccd", employee.Cccd);
                cmd.Parameters.AddWithValue("@Luong", employee.Luong);
                cmd.Parameters.AddWithValue("@NgayVaoLam", employee.NgayVaoLam);

                // Thực hiện truy vấn UPDATE
                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                // Kiểm tra xem có bản ghi nào được cập nhật hay không
                return rowsAffected > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false; // Xử lý lỗi và trả về false nếu có lỗi
            }
        }

        public static bool DeleteEmployee(string maNV)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Xây dựng truy vấn DELETE
                string deleteQuery = "DELETE FROM nhanvien WHERE MaNV = @MaNV";

                MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);

                // Thực hiện truy vấn DELETE
                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                // Kiểm tra xem có bản ghi nào bị xóa hay không
                return rowsAffected > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false; // Xử lý lỗi và trả về false nếu có lỗi
            }
        }

    }
}
