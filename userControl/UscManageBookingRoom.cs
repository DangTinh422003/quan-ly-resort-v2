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
            // click cell and delete
            if (table_BookingRoomList.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                if (table_BookingRoomList.CurrentCell != null && table_BookingRoomList.CurrentCell.Value != null)
                {
                    string roomId = table_BookingRoomList.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DialogResult isConfirmDelete = MessageBox.Show("Bạn có chắc muốn xóa lượt đặt phòng " + roomId + " ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (isConfirmDelete == DialogResult.Yes)
                    {
                        BookingRoomDAO.deleteByID(roomId);
                        string listRoomID = table_BookingRoomList.Rows[e.RowIndex].Cells[2].Value.ToString();
                        string[] listRoomIDArr = listRoomID.Split(',');
                        foreach (string roomID in listRoomIDArr)
                        {
                            RoomDAO.updateRoomStateById(roomID, "avaiable");
                        }
                        UscManageBookingRoom_Load(sender, e);
                    }
                }
            }
            else if (table_BookingRoomList.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                if (table_BookingRoomList.CurrentCell != null && table_BookingRoomList.CurrentCell.Value != null)
                {
                    BookingForm bookingForm = new BookingForm();
                    string bookingRoomId = table_BookingRoomList.Rows[e.RowIndex].Cells[0].Value.ToString();
                    bookingForm.setData(BookingRoomDAO.GetBookingRoomByID(bookingRoomId));
                    bookingForm.ShowDialog();
                }
            }
        }

        private void textbox_seatchCustomerId_TextChanged(object sender, EventArgs e)
        {
            string customerId = textbox_seatchCustomerId.Text.Trim();
            table_BookingRoomList.Rows.Clear();
            List<BookingRoom> rooms = BookingRoomDAO.getBookingRoomByCustomerId(customerId);
            foreach (BookingRoom room in rooms)
            {
                table_BookingRoomList.Rows.Add(room.Id, room.NgayDat.ToString("dd-MM-yyyy"), room.DanhSachMaPhong, room.MaKhachHang, room.NgayCheckInDuKien, room.SoNgayThue, room.SoNguoiThue);
            }
        }
    }
}
