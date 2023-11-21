using System;
using System.Collections.Generic;

namespace quan_ly_resort_v2.model
{
    public class BillDetails
    {
        public BillDetails()
        {
            GiaPhong = new List<double>();
            DanhSachMaDichVu = new List<string>();
            SoLuongDichVu = new List<int>();
            GiaDichVu = new List<double>();
            TenDichVu = new List<string>();
        }

        public BillDetails(string maHoaDon, string maKhachHang, string maNhanVien, string danhSachMaPhong, DateTime ngayTaoHoaDon, double tongTien, DateTime ngayCheckIn, int soNgayThue, string state, string tenKhachHang, string tenNhanVien, string tenPhong, List<double> giaPhong, List<string> danhSachMaDichVu, List<int> soLuongDichVu, List<double> giaDichVu, List<string> tenDichVu)
        {
            MaHoaDon = maHoaDon;
            MaKhachHang = maKhachHang;
            MaNhanVien = maNhanVien;
            DanhSachMaPhong = danhSachMaPhong;
            NgayTaoHoaDon = ngayTaoHoaDon;
            TongTien = tongTien;
            NgayCheckIn = ngayCheckIn;
            SoNgayThue = soNgayThue;
            State = state;
            TenKhachHang = tenKhachHang;
            TenNhanVien = tenNhanVien;
            TenPhong = tenPhong;
            GiaPhong = giaPhong ?? new List<double>();
            DanhSachMaDichVu = danhSachMaDichVu ?? new List<string>();
            SoLuongDichVu = soLuongDichVu ?? new List<int>();
            GiaDichVu = giaDichVu ?? new List<double>();
            TenDichVu = tenDichVu ?? new List<string>();
        }

        public string MaHoaDon { get; set; }
        public string MaKhachHang { get; set; }
        public string MaNhanVien { get; set; }
        public string DanhSachMaPhong { get; set; }
        public DateTime NgayTaoHoaDon { get; set; }
        public double TongTien { get; set; }
        public DateTime NgayCheckIn { get; set; }
        public int SoNgayThue { get; set; }
        public string State { get; set; }
        public string TenKhachHang { get; set; }
        public string TenNhanVien { get; set; }
        public string TenPhong { get; set; }
        public List<double> GiaPhong { get; set; }
        public List<string> DanhSachMaDichVu { get; set; }
        public List<int> SoLuongDichVu { get; set; }
        public List<double> GiaDichVu { get; set; }
        public List<string> TenDichVu { get; set; }
    }

}
