using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.model
{
    public class Service
    {
        public Service() { }

        public Service(string maDV, string tenDV, string loaiDV, double gia)
        {
            MaDV = maDV;
            TenDV = tenDV;
            LoaiDV = loaiDV;
            Gia = gia;
        }

        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public string LoaiDV { get; set; }
        public double Gia { get; set; }
    }
}
