using Guna.UI.WinForms;
using quan_ly_resort_v2.DAO;
using quan_ly_resort_v2.model;
using quan_ly_resort_v2.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace quan_ly_resort_v2.userControl
{
    public partial class UscManageStatistic : UserControl
    {
        public UscManageStatistic()
        {
            InitializeComponent();
        }

        private void UscManageStatistic_Load(object sender, EventArgs e)
        {
            lb_TongLuotDatPhong.Text = BookingRoomDAO.getBookingRooms().Count.ToString();
            lb_TongSoKhachHang.Text = CustomerDAO.countCustomer().ToString();
            lb_TongDoanhThu.Text = FormatCurrency.FormatMoney(BillDAO.totalMoney());
            lb_TongTienDichVu.Text = FormatCurrency.FormatMoney(BillServiceDAO.totalMoney());

            int count = 0;
            foreach (BookingRoom item in BookingRoomDAO.getBookingRooms())
            {
                if (item.IsConfirm != "Đã xử lý")
                    count++;
            }
            lb_TiLeNhanPhong.Text = (100 - (((double)count / (double)BookingRoomDAO.getBookingRooms().Count) * 100)) + "%";


            cTienDichVu.DataPoints.Add("Tháng 1", 250000);
            cTienDichVu.DataPoints.Add("Tháng 2", 335000);
            cTienDichVu.DataPoints.Add("Tháng 3", 401000);
            cTienDichVu.DataPoints.Add("Tháng 4", 397500);
            cTienDichVu.DataPoints.Add("Tháng 5", 380000);
            cTienDichVu.DataPoints.Add("Tháng 6", 401000);
            cTienDichVu.DataPoints.Add("Tháng 7", 325000);
            cTienDichVu.DataPoints.Add("Tháng 8", 430000);
            cTienDichVu.DataPoints.Add("Tháng 9", 447500);
            cTienDichVu.DataPoints.Add("Tháng 10", 510100);
            cTienDichVu.DataPoints.Add("Tháng 11", 450000);
            cTienDichVu.DataPoints.Add("Tháng 12", 448300);

            cTongKhachHang.DataPoints.Add("Tháng 1", 10);
            cTongKhachHang.DataPoints.Add("Tháng 2", 15);
            cTongKhachHang.DataPoints.Add("Tháng 3", 20);
            cTongKhachHang.DataPoints.Add("Tháng 4", 25);
            cTongKhachHang.DataPoints.Add("Tháng 5", 30);
            cTongKhachHang.DataPoints.Add("Tháng 6", 35);
            cTongKhachHang.DataPoints.Add("Tháng 7", 40);
            cTongKhachHang.DataPoints.Add("Tháng 8", 45);
            cTongKhachHang.DataPoints.Add("Tháng 9", 50);
            cTongKhachHang.DataPoints.Add("Tháng 10", 55);
            cTongKhachHang.DataPoints.Add("Tháng 11", 60);
            cTongKhachHang.DataPoints.Add("Tháng 12", 67);

            cTienPhong.DataPoints.Add("Tháng 1", 3640000);
            cTienPhong.DataPoints.Add("Tháng 2", 4450000);
            cTienPhong.DataPoints.Add("Tháng 3", 4880000);
            cTienPhong.DataPoints.Add("Tháng 4", 5225000);
            cTienPhong.DataPoints.Add("Tháng 5", 3940000);
            cTienPhong.DataPoints.Add("Tháng 6", 3840000);
            cTienPhong.DataPoints.Add("Tháng 7", 4300000);
            cTienPhong.DataPoints.Add("Tháng 8", 445000);
            cTienPhong.DataPoints.Add("Tháng 9", 5040000);
            cTienPhong.DataPoints.Add("Tháng 10", 6250000);
            cTienPhong.DataPoints.Add("Tháng 11", 6330000);
            cTienPhong.DataPoints.Add("Tháng 12", 7450000);
        }
    }
}
