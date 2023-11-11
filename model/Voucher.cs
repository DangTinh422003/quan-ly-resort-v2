using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.model
{
    public class Voucher
    {
        public string MaVoucher { get; set; }
        public float GiamGia { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Count {  get; set; }
        public int State { get; set; }
        public Voucher() { }

        public Voucher(string maVoucher, float giamGia, DateTime startDate, DateTime endDate, int count, int state)
        {
            MaVoucher = maVoucher;
            GiamGia = giamGia;
            StartDate = startDate;
            EndDate = endDate;
            Count = count;
            State = state;
        }
    }
}
