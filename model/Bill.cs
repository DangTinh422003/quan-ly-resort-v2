using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.model
{
    public class Bill
    {
        private string maHoaDon;
        private string maKhachHang;
        private string maNhanVien;
        private string danhSachMaPhong;
        private DateTime ngayTaoHoaDon;
        private double tongTien;
        private DateTime ngayCheckIn;
        private int soNgayThue;

        public Bill() { }

        public Bill(string maHoaDon, string maKhachHang, string maNhanVien, string danhSachMaPhong, DateTime ngayTaoHoaDon, double tongTien, DateTime ngayCheckIn, int soNgayThue)
        {
            this.MaHoaDon = maHoaDon;
            this.MaKhachHang = maKhachHang;
            this.maNhanVien = maNhanVien;
            this.DanhSachMaPhong = danhSachMaPhong;
            this.NgayTaoHoaDon = ngayTaoHoaDon;
            this.TongTien = tongTien;
            this.NgayCheckIn = ngayCheckIn;
            this.SoNgayThue = soNgayThue;
        }

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string DanhSachMaPhong { get => danhSachMaPhong; set => danhSachMaPhong = value; }
        public DateTime NgayTaoHoaDon { get => ngayTaoHoaDon; set => ngayTaoHoaDon = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayCheckIn { get => ngayCheckIn; set => ngayCheckIn = value; }
        public int SoNgayThue { get => soNgayThue; set => soNgayThue = value; }
    }
}
