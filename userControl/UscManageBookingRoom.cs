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

namespace quan_ly_resort_v2.userControl
{
    public partial class UscManageBookingRoom : UserControl
    {
        public UscManageBookingRoom()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            var bookingForm = new BookingForm();
            bookingForm.ShowDialog();
        }

        private void UscManageBookingRoom_Load(object sender, EventArgs e)
        {
            table_BookingRoomList.Rows.Clear();
            List<BookingRoom> rooms = BookingRoomDAO.getBookingRooms();
            foreach (BookingRoom room in rooms)
            {
                table_BookingRoomList.Rows.Add(room.Id, room.NgayDat.ToString("dd-MM-yyyy"), room.DanhSachMaPhong, room.MaKhachHang, room.NgayCheckInDuKien, room.SoNgayThue, room.SoNguoiThue);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            UscManageBookingRoom_Load(sender, e);
        }

        private void table_BookingRoomList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
