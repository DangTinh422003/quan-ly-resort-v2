using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace quan_ly_resort_v2.model
{
    public class BookingRoomDAO
    {
        public static bool addNew(BookingRoom bkRoom)
        {
            try
            {
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "insert into datphong (NgayDat,DSMaPhong,MaKH,NgayCheckInDuKien,SoNgayThue,SoNguoiThue) values(@Ngaydat,@dsMaPhong,@MaKH,@ngayCheckin,@soNgayThue,@soNguoiThue)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ngaydat", bkRoom.NgayDat);
                cmd.Parameters.AddWithValue("@dsMaPhong", bkRoom.DanhSachMaPhong);
                cmd.Parameters.AddWithValue("@MaKH", bkRoom.MaKhachHang);
                cmd.Parameters.AddWithValue("@ngayCheckin", bkRoom.NgayCheckInDuKien);
                cmd.Parameters.AddWithValue("@soNgayThue", bkRoom.SoNgayThue);
                cmd.Parameters.AddWithValue("@soNguoiThue", bkRoom.SoNguoiThue);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine("add new booking room error: " + err.Message);
                return false;
            }
        }

        public static List<BookingRoom> getBookingRooms()
        {
            List<BookingRoom> bookingRooms = new List<BookingRoom>();
            try
            {
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Query data
                string sql = "select * from datphong";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    BookingRoom bookingRoom = new BookingRoom(
                                               reader["Id"].ToString(),
                                               DateTime.Parse(reader["NgayDat"].ToString()),
                                               reader["DSMaPhong"].ToString(), reader["MaKH"].ToString(),
                                               DateTime.Parse(reader["NgayCheckInDuKien"].ToString()),
                                               int.Parse(reader["SoNgayThue"].ToString()),
                                               int.Parse(reader["SoNguoiThue"].ToString()));
                    bookingRooms.Add(bookingRoom);
                }
                return bookingRooms;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

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
