using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using quan_ly_resort_v2.DAO;
using quan_ly_resort_v2.forms;
using quan_ly_resort_v2.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quan_ly_resort_v2.userControl
{
    public partial class RoomItem : UserControl
    {
        private string IdOfBookingRoom;

        public RoomItem()
        {
            InitializeComponent();
        }

        public void SetRoomInfo(Room roomInfo)
        {
            lb_RoomId.Text = roomInfo.Id;
            lb_isCleanup.Text = roomInfo.IsClean ? "Đã dọn dẹp" : "Chưa dọn dẹp";
            if (roomInfo.IsFixed)
                lb_isCleanup.Text = "Đang sửa chữa";

            switch (roomInfo.State.ToLower())
            {
                case "avaiable":
                    lb_CustomerName.Text = "Phòng Trống";
                    lb_roomState.Text = "Phòng Trống";
                    lb_timeToStart.Text = "";
                    lb_TimeToEnd.Text = "";
                    lb_CountTimeStay.Text = "";
                    break;
                case "reserved":
                    lb_roomState.Text = "Phòng đã đặt";
                    panel_RoomWrap.BackColor = Color.FromArgb(24, 119, 242);
                    //BookingRoom bookingRoom = BookingRoomDAO.GetBookingRoomByRoomID(roomInfo.Id);
                    BookingRoom bookingRoom = BookingRoomDAO.GetBookingRoomNotHandleByRoomID(roomInfo.Id);
                    IdOfBookingRoom = bookingRoom.Id;
                    Customer customer = CustomerDAO.getCustomerById(bookingRoom.MaKhachHang);
                    lb_CustomerName.Text = customer.Fullname;
                    lb_timeToStart.Text = bookingRoom.NgayCheckInDuKien.ToString("dd/MM/yyyy");
                    lb_TimeToEnd.Text = bookingRoom.NgayCheckInDuKien.AddDays(bookingRoom.SoNgayThue).ToString("dd/MM/yyyy");
                    lb_CountTimeStay.Text = bookingRoom.SoNgayThue.ToString() + " ngày";
                    break;
                case "occupied":
                    lb_roomState.Text = "Đã cho thuê";
                    panel_RoomWrap.BackColor = Color.Gray;
                    BookingRoom bookingRoom2 = BookingRoomDAO.GetBookingRoomByRoomID(roomInfo.Id);
                    IdOfBookingRoom = bookingRoom2.Id;
                    Customer customer2 = CustomerDAO.getCustomerById(bookingRoom2.MaKhachHang);
                    lb_CustomerName.Text = customer2.Fullname;
                    lb_timeToStart.Text = bookingRoom2.NgayCheckInDuKien.ToString("dd/MM/yyyy");
                    lb_TimeToEnd.Text = bookingRoom2.NgayCheckInDuKien.AddDays(bookingRoom2.SoNgayThue).ToString("dd/MM/yyyy");
                    lb_CountTimeStay.Text = bookingRoom2.SoNgayThue.ToString() + " ngày";
                    break;
            }
        }

        private void panel_RoomWrap_Click(object sender, EventArgs e)
        {
            DetailRoomInfo detailRoomInfo = new DetailRoomInfo();
            detailRoomInfo.setRoomID(lb_RoomId.Text);
            detailRoomInfo.setBookingRoomID(IdOfBookingRoom);
            detailRoomInfo.ShowDialog();
        }
    }
}
