﻿using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using quan_ly_resort_v2.model;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.DAO
{
    internal class RoomDAO
    {
        public static int countListRoom()
        {
            List<Room> rooms = new List<Room>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString()))
                {
                    conn.Open();

                    string sql = "SELECT * FROM phong ";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room room = new Room(
                                reader["id"].ToString(),
                                reader["LoaiPhong"].ToString(),
                                reader["KieuGiuong"].ToString(),
                                reader["TinhTrang"].ToString(),
                                Convert.ToDouble(reader["Gia"]),
                                Convert.ToBoolean(reader["DonDep"]),
                                Convert.ToBoolean(reader["SuaChua"])
                            );
                            rooms.Add(room);
                        }
                    }
                }
                return rooms.Count;
            }
            catch (Exception err)
            {
                Console.WriteLine("Error in GetRooms: " + err.Message);
            }
            return -1;
        }

        public static List<Room> listRoom()
        {
            List<Room> rooms = new List<Room>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString()))
                {
                    conn.Open();

                    string sql = "SELECT * FROM phong ";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room room = new Room(
                                reader["id"].ToString(),
                                reader["LoaiPhong"].ToString(),
                                reader["KieuGiuong"].ToString(),
                                reader["TinhTrang"].ToString(),
                                Convert.ToDouble(reader["Gia"]),
                                (bool)reader["DonDep"],
                                (bool)reader["SuaChua"]
                            );
                            rooms.Add(room);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error in GetRooms: " + err.Message);
                return null;
            }
            return rooms;
        }

        public static List<Room> GetRoomsLimit(int currentPageIndex = 1, int pageSize = 12)
        {
            List<Room> rooms = new List<Room>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString()))
                {
                    conn.Open();

                    string sql = "SELECT * FROM phong ORDER BY Id LIMIT @PageSize OFFSET @Offset";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@PageSize", pageSize);
                    command.Parameters.AddWithValue("@Offset", (currentPageIndex - 1) * pageSize);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room room = new Room(
                                reader["id"].ToString(),
                                reader["LoaiPhong"].ToString(),
                                reader["KieuGiuong"].ToString(),
                                reader["TinhTrang"].ToString(),
                                Convert.ToDouble(reader["Gia"]),
                                (bool)reader["DonDep"],
                                (bool)reader["SuaChua"]
                            );
                            rooms.Add(room);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error in GetRooms: " + err.Message);
                return null;
            }
            return rooms;
        }

        public static Room getRoomByID(string id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString()))
                {
                    conn.Open();
                    string sql = "SELECT * FROM phong WHERE Id = @Id";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@Id", id);
                    MySqlDataReader reader = command.ExecuteReader();
                    Room room = null;
                    if (reader.Read())
                    {
                        room = new Room(
                                reader["id"].ToString(),
                                reader["LoaiPhong"].ToString(),
                                reader["KieuGiuong"].ToString(),
                                reader["TinhTrang"].ToString(),
                                Convert.ToDouble(reader["Gia"]),
                                (bool)reader["DonDep"],
                                (bool)reader["SuaChua"]);
                    }
                    return room;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in getRoomByID: " + e.Message);
                return null;
            }
        }

        public static List<Room> getRoomsByID(string roomId)
        {
            List<Room> rooms = new List<Room>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString()))
                {
                    conn.Open();

                    string sql = "SELECT * FROM phong where Id LIKE @roomID";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@roomID", "%" + roomId + "%");
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room room = new Room(
                                reader["id"].ToString(),
                                reader["LoaiPhong"].ToString(),
                                reader["KieuGiuong"].ToString(),
                                reader["TinhTrang"].ToString(),
                                Convert.ToDouble(reader["Gia"]),
                                (bool)reader["DonDep"],
                                (bool)reader["SuaChua"]
                            );
                            rooms.Add(room);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error in getRoomsByRoomType: " + err.Message);
                return null;
            }
            return rooms;
        }

        public static List<Room> getRoomsByRoomState(string roomState)
        {
            List<Room> rooms = new List<Room>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString()))
                {
                    conn.Open();

                    string sql = "SELECT * FROM phong where TinhTrang = @TinhTrang";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@TinhTrang", roomState);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room room = new Room(
                                reader["id"].ToString(),
                                reader["LoaiPhong"].ToString(),
                                reader["KieuGiuong"].ToString(),
                                reader["TinhTrang"].ToString(),
                                Convert.ToDouble(reader["Gia"]),
                                (bool)reader["DonDep"],
                                (bool)reader["SuaChua"]
                            );
                            rooms.Add(room);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error in getRoomsByRoomType: " + err.Message);
                return null;
            }
            return rooms;
        }

        public static bool updateRoomStateById(string roomId, string state)
        {
            try
            {
                // Tạo connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                // Query data
                string sql = "update phong set TinhTrang = @state where Id = @roomId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@state", state);
                cmd.Parameters.AddWithValue("@roomId", roomId);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine("Error in updateRoomStateById: " + err.Message);
                return false;
            }
        }

        public static List<Room> filterRoom(string loaiPhong, string kieuGiuong, string tinhTrang)
        {
            List<Room> rooms = new List<Room>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString()))
                {
                    conn.Open();

                    string sql = "SELECT * FROM phong where LoaiPhong like @LoaiPhong and " +
                                                           "KieuGiuong like @KieuGiuong and " +
                                                           "TinhTrang like @TinhTrang";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@LoaiPhong", "%" + loaiPhong + "%");
                    command.Parameters.AddWithValue("@KieuGiuong", "%" + kieuGiuong + "%");
                    command.Parameters.AddWithValue("@TinhTrang", "%" + tinhTrang + "%");
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room room = new Room(
                                reader["id"].ToString(),
                                reader["LoaiPhong"].ToString(),
                                reader["KieuGiuong"].ToString(),
                                reader["TinhTrang"].ToString(),
                                Convert.ToDouble(reader["Gia"]),
                                (bool)reader["DonDep"],
                                (bool)reader["SuaChua"]
                            );
                            rooms.Add(room);
                        }
                    }
                }
                return rooms;
            }
            catch (Exception err)
            {
                Console.WriteLine("Error in GetRooms: " + err.Message);
                return null;
            }
        }
    }
}
