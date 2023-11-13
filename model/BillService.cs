using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.model
{
    public class BillService
    {
        private string maHD;
        private string maDichVu;
        private int soLuong;

        public BillService(string maHD, string maDichVu, int soLuong)
        {
            this.maHD = maHD;
            this.maDichVu = maDichVu;
            this.soLuong = soLuong;
        }
        public BillService() { }

        // getter setter
        public string MaHD { get => maHD; set => maHD = value; }
        public string MaDichVu { get => maDichVu; set => maDichVu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

    }
}
