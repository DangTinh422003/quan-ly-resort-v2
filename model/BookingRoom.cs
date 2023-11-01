using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.model
{
    public class BookingRoom
    {
        private string id;
        private DateTime ngayDat;
        private string danhSachMaPhong;
        private string maKhachHang;
        private DateTime ngayCheckInDuKien;
        private int soNgayThue;
        private int soNguoiThue;

        public BookingRoom() { }
        public BookingRoom(string id, DateTime ngayDat, string danhSachMaPhong, string maKhachHang, DateTime ngayCheckInDuKien, int soNgayThue, int soNguoiThue)
        {
            this.Id = id;
            this.NgayDat = ngayDat;
            this.DanhSachMaPhong = danhSachMaPhong;
            this.MaKhachHang = maKhachHang;
            this.NgayCheckInDuKien = ngayCheckInDuKien;
            this.SoNgayThue = soNgayThue;
            this.SoNguoiThue = soNguoiThue;
        }

        public string Id { get => id; set => id = value; }
        public DateTime NgayDat { get => ngayDat; set => ngayDat = value; }
        public string DanhSachMaPhong { get => danhSachMaPhong; set => danhSachMaPhong = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public DateTime NgayCheckInDuKien { get => ngayCheckInDuKien; set => ngayCheckInDuKien = value; }
        public int SoNgayThue { get => soNgayThue; set => soNgayThue = value; }
        public int SoNguoiThue { get => soNguoiThue; set => soNguoiThue = value; }
    }
}
