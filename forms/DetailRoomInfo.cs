using quan_ly_resort_v2.DAO;
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

namespace quan_ly_resort_v2.forms
{
    public partial class DetailRoomInfo : Form
    {

        private string currentRoomId;
        public DetailRoomInfo()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(197, 197, 197), ButtonBorderStyle.Solid);
        }

        public void setRoomID(string roomId)
        {
            currentRoomId = roomId;
        }

        private void DetailRoomInfo_Load(object sender, EventArgs e)
        {
            lb_roomId.Text = currentRoomId;
            Room room = RoomDAO.getRoomByID(currentRoomId);
            if (room.State.Trim().ToLower() == "avaiable")
            {
                lb_roomState.Text = "Phòng trống";
                lb_isConfirmRoom.Text = "Chưa nhận phòng";
                lb_dayCounter.Text = "";
                lb_peopleCounter.Text = "";
            }
            else if (room.State.Trim().ToLower() == "reserved")
            {
                BookingRoom bookingRoom = BookingRoomDAO.GetBookingRoomByRoomID(currentRoomId);
                Customer customer = CustomerDAO.getCustomerById(bookingRoom.MaKhachHang);
                lb_roomState.Text = customer.Fullname;
                lb_isConfirmRoom.Text = bookingRoom.NgayCheckInDuKien.ToString("dd/MM/yyyy");
                lb_dayCounter.Text = bookingRoom.SoNgayThue.ToString() + " ngày";
                lb_peopleCounter.Text = bookingRoom.SoNguoiThue.ToString() + " người";
            }
            else
            {

            }
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_getRoom_Click(object sender, EventArgs e)
        {
            string roomId = currentRoomId;
            Room room = RoomDAO.getRoomByID(roomId);

            if (btn_getRoom.Text == "Thanh toán")
            {
                MessageBox.Show("Thanh toán thành công");
                return;
            }
            if (room.State.ToLower() == "avaiable")
            {
                MessageBox.Show("Vui lòng tạo đơn đặt phòng mới rồi mới nhận phòng, bạn có muốn tạo đơn đặt phòng mới?", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            else if (room.State.ToLower() == "reserved")
            {
                //MessageBox.Show("Nhận phòng,Tạo hóa đơn, query bảng đặt phòng + bảng khách hàng để thêm thong tin vào hóa đơn");
                //MaKH,MaNV,DSMaPhong,NgayTao,TongTien,NgayCheckIn,ThoiGianThue
                BookingRoom bookingRoom = BookingRoomDAO.GetBookingRoomByRoomID(roomId);
                Employee employee = EmployeeDAO.GetEmployeeByUsername(LoginForm.accountLogined.Username);
                double totalPrice = 0;
                foreach (string id in bookingRoom.DanhSachMaPhong.Trim().Split(','))
                    totalPrice += RoomDAO.getRoomByID(id).Price;

                Bill newBill = new Bill("", bookingRoom.MaKhachHang, employee.MaNV, bookingRoom.DanhSachMaPhong, DateTime.Now, totalPrice, bookingRoom.NgayCheckInDuKien, bookingRoom.SoNgayThue);
                BillDAO.addNewBill(newBill);
                btn_getRoom.Text = "Thanh toán";
                return;
            }
            else
            {
                MessageBox.Show("Hiện nút thanh toán, tính tiền");
            }
        }

        private void gunaContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btn_saveInomation_Click(object sender, EventArgs e)
        {

        }
    }
}
