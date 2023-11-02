﻿using System;
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
    internal class BillDAO
    {
        public BillDAO() { }

        public static List<Bill> GetBills()
        {
            List<Bill> bills = new List<Bill>();

            try
            {
                MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString());
                conn.Open();

                string sql = "SELECT * FROM hoadon";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Bill bill = new Bill
                    {
                        MaHoaDon = reader["MaHD"].ToString(),
                        MaKhachHang = reader["MaKH"].ToString(),
                        MaNhanVien = reader["MaNV"].ToString(),
                        DanhSachMaPhong = reader["DSMaPhong"].ToString(),
                        NgayTaoHoaDon = Convert.ToDateTime(reader["NgayTao"]),
                        TongTien = Convert.ToDouble(reader["TongTien"]),
                        NgayCheckIn = Convert.ToDateTime(reader["NgayCheckIn"]),
                        SoNgayThue = Convert.ToInt32(reader["ThoiGianThue"])
                    };

                    bills.Add(bill);
                }

                conn.Close();

                return bills;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static bool UpdateBill(Bill bill)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString());
                conn.Open();

                string updateQuery = "UPDATE hoadon SET MaKH = @MaKhachHang, MaNV = @MaNhanVien, DSMaPhong = @DanhSachMaPhong, NgayTao = @NgayTaoHoaDon, TongTien = @TongTien, NgayCheckIn = @NgayCheckIn, ThoiGianThue = @SoNgayThue WHERE MaHD = @MaHoaDon";

                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", bill.MaHoaDon);
                cmd.Parameters.AddWithValue("@MaKhachHang", bill.MaKhachHang);
                cmd.Parameters.AddWithValue("@MaNhanVien", bill.MaNhanVien);
                cmd.Parameters.AddWithValue("@DanhSachMaPhong", bill.DanhSachMaPhong);
                cmd.Parameters.AddWithValue("@NgayTaoHoaDon", bill.NgayTaoHoaDon);
                cmd.Parameters.AddWithValue("@TongTien", bill.TongTien);
                cmd.Parameters.AddWithValue("@NgayCheckIn", bill.NgayCheckIn);
                cmd.Parameters.AddWithValue("@SoNgayThue", bill.SoNgayThue);

                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                return rowsAffected > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool DeleteBill(string maHoaDon)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString());
                conn.Open();

                string deleteQuery = "DELETE FROM hoadon WHERE MaHD = @MaHoaDon";

                MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                return rowsAffected > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
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

                string sql = "SELECT * FROM hoadon";
                switch (typeValue)
                {
                    case "Mã hóa đơn":
                        sql += " WHERE MaHD LIKE @filterValue";
                        break;
                    case "Mã khách hàng":
                        sql += " WHERE MaKH LIKE @filterValue";
                        break;
                    case "Mã nhân viên":
                        sql += " WHERE MaNV LIKE @filterValue";
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
    }
}