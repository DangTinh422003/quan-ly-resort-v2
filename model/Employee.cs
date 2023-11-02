using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace quan_ly_resort_v2.model
{
    public class Employee
    {

        public Employee() { }
        public Employee(string maNV, string tenNV, string sdt, string email, DateTime ngaySinh, string diaChi, string cccd, double luong, DateTime ngayVaoLam, string username, int role)
        {
            MaNV = maNV;
            TenNV = tenNV;
            Sdt = sdt;
            Email = email;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            Cccd = cccd;
            Luong = luong;
            NgayVaoLam = ngayVaoLam;
            Username = username;
            Role = role;
        }

        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Cccd { get; set; }
        public double Luong { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public string Username { get; set; }
        public int Role { get; set; }

    }
}
