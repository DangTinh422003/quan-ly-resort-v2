using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.model
{
    public class BillDetails
    {
        public BillDetails()
        {
        }

        public BillDetails(string maHoaDon, string maKhachHang, string maNhanVien, string danhSachMaPhong, DateTime ngayTaoHoaDon, double tongTien, DateTime ngayCheckIn, int soNgayThue, string state, string tenKhachHang, string tenNhanVien, string tenPhong)
        {
            this.MaHoaDon = maHoaDon;
            this.MaKhachHang = maKhachHang;
            this.MaNhanVien = maNhanVien;
            this.DanhSachMaPhong = danhSachMaPhong;
            this.NgayTaoHoaDon = ngayTaoHoaDon;
            this.TongTien = tongTien;
            this.NgayCheckIn = ngayCheckIn;
            this.SoNgayThue = soNgayThue;
            this.State = state;
            this.TenKhachHang = tenKhachHang;
            this.TenNhanVien = tenNhanVien;
            this.TenPhong = tenPhong;
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
    }
}
