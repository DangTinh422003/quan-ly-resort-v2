using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Media.Animation;

namespace quan_ly_resort_v2.model
{
    public class BookingRoomDAO
    {
        public static bool deleteByID(string id)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "delete from datphong where Id = @id";
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

        public static List<BookingRoom> getBookingRoomByCustomerId(string customerId)
        {
            try
            {
                List<BookingRoom> bookingRooms = new List<BookingRoom>();
                using (MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString()))
                {
                    conn.Open();

                    string sql = "SELECT * FROM datphong where MaKH like @customerID";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@customerID", "%" + customerId + "%");
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BookingRoom bookingRoom = new BookingRoom(
                                reader["Id"].ToString(),
                                DateTime.Parse(reader["NgayDat"].ToString()),
                                reader["DSMaPhong"].ToString(),
                                reader["MaKH"].ToString(),
                                DateTime.Parse(reader["NgayCheckInDuKien"].ToString()),
                                int.Parse(reader["SoNgayThue"].ToString()),
                                int.Parse(reader["SoNguoiThue"].ToString()));
                            bookingRooms.Add(bookingRoom);
                        }
                    }
                }
                return bookingRooms;
            }
            catch (Exception err)
            {
                Console.WriteLine("Error in GetRooms: " + err.Message);
                return null;
            }
        }

        public static BookingRoom GetBookingRoomByRoomID(string roomId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString()))
                {
                    conn.Open();
                    string sql = "SELECT * FROM datphong WHERE DSMaPhong LIKE @Id";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@Id", "%" + roomId + "%");
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        BookingRoom bookingRoom = new BookingRoom(reader["Id"].ToString(),
                                DateTime.Parse(reader["NgayDat"].ToString()),
                                reader["DSMaPhong"].ToString(),
                                reader["MaKH"].ToString(),
                                DateTime.Parse(reader["NgayCheckInDuKien"].ToString()),
                                int.Parse(reader["SoNgayThue"].ToString()),
                                int.Parse(reader["SoNguoiThue"].ToString()));
                        return bookingRoom;
                    }
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in getRoomByID: " + e.Message);
                return null;
            }
        }

        public static BookingRoom GetBookingRoomByID(string bookingRoomID)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString()))
                {
                    conn.Open();
                    string sql = "SELECT * FROM datphong WHERE Id = @Id";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@Id", bookingRoomID);
                    MySqlDataReader reader = command.ExecuteReader();
                    BookingRoom bookingRoom = null;
                    if (reader.Read())
                    {
                        bookingRoom = new BookingRoom(
                            reader["Id"].ToString(),
                            DateTime.Parse(reader["NgayDat"].ToString()),
                            reader["DSMaPhong"].ToString(), reader["MaKH"].ToString(),
                            DateTime.Parse(reader["NgayCheckInDuKien"].ToString()),
                            int.Parse(reader["SoNgayThue"].ToString()),
                            int.Parse(reader["SoNguoiThue"].ToString()));
                    }
                    return bookingRoom;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in getRoomByID: " + e.Message);
                return null;
            }
        }
    }
}
