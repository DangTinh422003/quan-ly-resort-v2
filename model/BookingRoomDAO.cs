using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.model
{
    public class BookingRoomDAO
    {
        public static BookingRoom getBookingRoomByCustomerId(string customerId)
        {
            try
            {
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Query data
                string sql = "select * from datphong where MaKH LIKE @customerId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    BookingRoom bookingRoom = new BookingRoom(
                       reader["Id"].ToString(),
                       DateTime.Parse(reader["NgayDat"].ToString()),
                       reader["DanhSachMaPhong"].ToString(),
                       reader["MaKH"].ToString(),
                       DateTime.Parse(reader["NgayCheckInDuKien"].ToString()),
                       int.Parse(reader["SoNgayThue"].ToString()),
                       int.Parse(reader["SoNguoiThue"].ToString())
                        );
                    return bookingRoom;
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
