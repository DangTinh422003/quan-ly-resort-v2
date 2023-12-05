using System;
using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using quan_ly_resort_v2.model;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.DAO
{
    internal class BillDetailDAO
    {
        public BillDetailDAO() { }

        public static BillDetails GetBillDetailsByMaHD(string maHD)
        {
            try
            {
                BillDetails billDetails = GetRoomDetails(maHD);

                if (billDetails != null)
                {
                    GetServiceDetails(billDetails);
                }

                return billDetails;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        private static BillDetails GetRoomDetails(string maHD)
        {
            using (MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString()))
            {
                conn.Open();

                string sql = @"
            SELECT 
                h.MaHD,
                h.MaKH,
                h.MaNV,
                h.DSMaPhong,
                h.NgayTao,
                h.TongTien,
                h.NgayCheckIn,
                h.ThoiGianThue,
                h.state,
                k.HoTen,
                n.TenNV,
                GROUP_CONCAT(p.Id) AS DanhSachMaPhong,
                GROUP_CONCAT(p.Gia) AS GiaPhong
            FROM hoadon h
            LEFT JOIN khachhang k ON h.MaKH = k.Cccd
            LEFT JOIN nhanvien n ON h.MaNV = n.MaNV
            LEFT JOIN phong p ON FIND_IN_SET(p.Id, h.DSMaPhong)
            WHERE h.MaHD = @MaHD
            GROUP BY h.MaHD";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", maHD);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            BillDetails billDetails = new BillDetails
                            {
                                MaHoaDon = reader["MaHD"].ToString(),
                                MaKhachHang = reader["MaKH"].ToString(),
                                MaNhanVien = reader["MaNV"].ToString(),
                                DanhSachMaPhong = reader["DanhSachMaPhong"].ToString(),
                                GiaPhong = reader["GiaPhong"].ToString().Split(',').Select(Double.Parse).ToList(),
                                NgayTaoHoaDon = Convert.ToDateTime(reader["NgayTao"]),
                                TongTien = Convert.ToDouble(reader["TongTien"]),
                                NgayCheckIn = Convert.ToDateTime(reader["NgayCheckIn"]),
                                SoNgayThue = Convert.ToInt32(reader["ThoiGianThue"]),
                                State = reader["state"].ToString(),
                                TenKhachHang = reader["HoTen"].ToString(),
                                TenNhanVien = reader["TenNV"].ToString(),
                            };

                            return billDetails;
                        }
                    }
                }
            }

            return null;
        }

        private static void GetServiceDetails(BillDetails billDetails)
        {
            using (MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString()))
            {
                conn.Open();

                string sql = @"
            SELECT 
                hdv.MaDichVu,
                hdv.SoLuong,
                dv.Gia,
                dv.TenDV
            FROM hoadondichvu hdv
            LEFT JOIN dichvu dv ON hdv.MaDichVu = dv.MaDV
            WHERE hdv.MaHD = @MaHD";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", billDetails.MaHoaDon);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            billDetails.DanhSachMaDichVu.Add(reader["MaDichVu"].ToString());
                            billDetails.SoLuongDichVu.Add(Convert.ToInt32(reader["SoLuong"]));
                            billDetails.GiaDichVu.Add(Convert.ToDouble(reader["Gia"]));
                            billDetails.TenDichVu.Add(reader["TenDV"].ToString());
                        }
                    }
                }
            }
        }




    }
}
