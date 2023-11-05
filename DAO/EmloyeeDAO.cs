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
                        Cccd = reader["Cccd"].ToString(),
                        Luong = Convert.ToDouble(reader["Luong"]),
                        NgayVaoLam = (DateTime)reader["NgayVaoLam"],
                        Username = reader["username"].ToString(),
                        Role = Convert.ToInt32(reader["Role"].ToString())
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

        public static string GetNextMaNV()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Thực hiện truy vấn để lấy mã nhân viên cuối cùng
                string getLastMaNVQuery = "SELECT MaNV FROM nhanvien ORDER BY MaNV DESC LIMIT 1";

                MySqlCommand getLastMaNVCmd = new MySqlCommand(getLastMaNVQuery, conn);
                string lastMaNV = getLastMaNVCmd.ExecuteScalar() as string;

                // Kiểm tra nếu không có bất kỳ MaNV nào trong cơ sở dữ liệu
                if (string.IsNullOrEmpty(lastMaNV))
                {
                    return "NV1";
                }

                // Rút trích số id từ MaNV cuối cùng
                string[] parts = lastMaNV.Split(new string[] { "NV" }, StringSplitOptions.None);
                if (parts.Length == 2 && int.TryParse(parts[1], out int lastId))
                {
                    // Tạo MaNV mới bằng cách tăng id lên 1 và kết hợp với "NV"
                    string newMaNV = "NV" + (lastId + 1);
                    return newMaNV;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }


        public static bool AddEmployee(Employee newEmployee)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Lấy mã nhân viên tiếp theo
                string nextMaNV = GetNextMaNV();

                if (nextMaNV == null)
                {
                    conn.Close();
                    return false;
                }

                // Kiểm tra xem username đã tồn tại hay chưa
                string checkUsernameQuery = "SELECT username FROM nhanvien WHERE username = @Username";
                MySqlCommand checkUsernameCmd = new MySqlCommand(checkUsernameQuery, conn);
                checkUsernameCmd.Parameters.AddWithValue("@Username", newEmployee.Username);
                object usernameResult = checkUsernameCmd.ExecuteScalar();

                // Nếu username đã tồn tại, không thêm mới
                if (usernameResult != null)
                {
                    conn.Close();
                    return false;
                }

                // Xây dựng truy vấn INSERT nếu cả MaNV và username chưa tồn tại
                string insertQuery = "INSERT INTO nhanvien (MaNV, TenNV, Sdt, Email, NgaySinh, DiaChi, Cccd, Luong, NgayVaoLam, username) " +
                                    "VALUES (@MaNV, @TenNV, @Sdt, @Email, @NgaySinh, @DiaChi, @Cccd, @Luong, @NgayVaoLam, @Username)";

                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@MaNV", nextMaNV);
                cmd.Parameters.AddWithValue("@TenNV", newEmployee.TenNV);
                cmd.Parameters.AddWithValue("@Sdt", newEmployee.Sdt);
                cmd.Parameters.AddWithValue("@Email", newEmployee.Email);
                cmd.Parameters.AddWithValue("@NgaySinh", newEmployee.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", newEmployee.DiaChi);
                cmd.Parameters.AddWithValue("@Cccd", newEmployee.Cccd);
                cmd.Parameters.AddWithValue("@Luong", newEmployee.Luong);
                cmd.Parameters.AddWithValue("@NgayVaoLam", newEmployee.NgayVaoLam);
                cmd.Parameters.AddWithValue("@Username", newEmployee.Username);

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
                string updateQuery = "UPDATE nhanvien SET TenNV = @TenNV, Sdt = @Sdt, Email = @Email, NgaySinh = @NgaySinh, DiaChi = @DiaChi, Cccd = @Cccd, Luong = @Luong, username = @Username WHERE MaNV = @MaNV";

                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@MaNV", employee.MaNV);
                cmd.Parameters.AddWithValue("@TenNV", employee.TenNV);
                cmd.Parameters.AddWithValue("@Sdt", employee.Sdt);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@NgaySinh", employee.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", employee.DiaChi);
                cmd.Parameters.AddWithValue("@Cccd", employee.Cccd);
                cmd.Parameters.AddWithValue("@Luong", employee.Luong);
                cmd.Parameters.AddWithValue("@Username", employee.Username); // Bổ sung trường username

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

        public static DataTable FilterByField(string typeValue, string filterValue)
        {
            try
            {
                typeValue = typeValue.Trim();
                filterValue = filterValue.Trim();

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "SELECT * FROM nhanvien";
                switch (typeValue)
                {
                    case "Mã nhân viên":
                        sql += " WHERE MaNV LIKE @filterValue";
                        break;
                    case "Họ và tên":
                        sql += " WHERE TenNV LIKE @filterValue";
                        break;
                    case "Số điện thoại":
                        sql += " WHERE Sdt LIKE @filterValue";
                        break;
                    case "Tên người dùng":
                        sql += " WHERE Username LIKE @filterValue";
                        break;
                    case "Email":
                        sql += " WHERE Email LIKE @filterValue";
                        break;
                    case "CCCD":
                        sql += " WHERE Cccd LIKE @filterValue";
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
        public static Employee GetEmployeeById(string id)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "select * from nhanvien where MaNV = @id";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = command.ExecuteReader();

                Employee employee = null;
                if (reader.Read())
                {
                    employee = new Employee(
                        reader["MaNV"].ToString(),
                        reader["TenNV"].ToString(),
                        reader["Sdt"].ToString(),
                        reader["Email"].ToString(),
                        DateTime.Parse(reader["NgaySinh"].ToString()),
                        reader["DiaChi"].ToString(),
                        reader["Cccd"].ToString(), // Thêm Cccd ở đây
                        double.Parse(reader["Luong"].ToString()), // Đảm bảo Luong là kiểu số
                        DateTime.Parse(reader["NgayVaoLam"].ToString()),
                        reader["username"].ToString(),
                        Convert.ToInt32(reader["Role"])
                    );
                }
                else
                {
                    return null;
                }
                conn.Close();
                return employee;
            }
            catch (Exception e)
            {
                Console.WriteLine("GetEmployeeById: " + e.Message);
                return null;
            }
        }


        public static Employee GetEmployeeByUsername(string username)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "select * from nhanvien where username = @username";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = command.ExecuteReader();

                Employee employee = null;
                if (reader.Read())
                {
                    employee = new Employee(
                        reader["MaNV"].ToString(),
                        reader["TenNV"].ToString(),
                        reader["Sdt"].ToString(),
                        reader["Email"].ToString(),
                        DateTime.Parse(reader["NgaySinh"].ToString()),
                        reader["DiaChi"].ToString(),
                        reader["Cccd"].ToString(), // Thêm Cccd ở đây
                        double.Parse(reader["Luong"].ToString()), // Đảm bảo Luong là kiểu số
                        DateTime.Parse(reader["NgayVaoLam"].ToString()),
                        reader["username"].ToString(),
                        Convert.ToInt32(reader["Role"])
                    );
                    return employee;
                }
                conn.Close();
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("GetEmployeeById: " + e.Message);
                return null;
            }
        }
    }
}
