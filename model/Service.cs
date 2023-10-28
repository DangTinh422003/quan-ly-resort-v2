﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.model
{
    public class Service
    {
        public Service() { }

        public Service(string maDV, string tenDV, string chiTietDichVu, double gia, byte[] picture)
        {
            MaDV = maDV;
            TenDV = tenDV;
            ChiTietDichVu = chiTietDichVu;
            Gia = gia;
            Picture = picture;
        }

        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public string ChiTietDichVu { get; set; }
        public double Gia { get; set; }
        public byte[] Picture { get; set; }
    }
}
