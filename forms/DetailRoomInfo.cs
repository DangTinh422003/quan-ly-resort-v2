using Org.BouncyCastle.Asn1.BC;
using quan_ly_resort_v2.DAO;
using quan_ly_resort_v2.model;
using quan_ly_resort_v2.userControl;
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
                comboBoxSelectRoomState.SelectedIndex = comboBoxSelectRoomState.Items.IndexOf("Phòng đã đặt");
                comboBox_isClean.SelectedIndex = comboBox_isClean.Items.IndexOf(room.IsClean ? "Đã dọn dẹp" : "Chưa dọn dẹp");
            }
            else
            {
                btn_getRoom.Text = "Thanh toán";
            }
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void actionWhenReserved()
        {
            // taọ hóa đơn mới giá tiền bằng 0
            // => cập nhật lại trạng thái của phòng
            // => cập nhật lại trạng thái của đơn đặt phòng
            BookingRoom bookingRoom = BookingRoomDAO.GetBookingRoomByRoomID(currentRoomId);
            Customer customer = CustomerDAO.getCustomerById(bookingRoom.MaKhachHang);
            Employee employee = EmployeeDAO.GetEmployeeByUsername(LoginForm.accountLogined.Username);
            Bill bill = new Bill();
            bill.MaHoaDon = new Random().Next(10000).ToString();
            bill.MaKhachHang = customer.Id;
            bill.MaNhanVien = employee.MaNV;
            bill.DanhSachMaPhong = bookingRoom.DanhSachMaPhong;
            bill.NgayTaoHoaDon = DateTime.Now;
            bill.NgayCheckIn = bookingRoom.NgayCheckInDuKien;
            bill.SoNgayThue = bookingRoom.SoNgayThue;

            foreach (string roomId in bookingRoom.DanhSachMaPhong.Trim().Split(','))
            {
                RoomDAO.updateRoomStateById(roomId, "occupied");
                Room room = RoomDAO.getRoomByID(roomId);
                bill.TongTien += room.Price * bookingRoom.SoNgayThue;
            }
            BillDAO.addNewBill(bill);
            BookingRoomDAO.updateBookingRoomConfirm(bookingRoom.Id, true);
            MessageBox.Show("Nhận phòng thành công!");
            this.Close();
        }

        private void actionWhenAvaiable()
        {
            MessageBox.Show("Vui lòng tạo đơn đặt phòng mới rồi mới nhận phòng!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void actionWhenOccupied()
        {
            // => cập nhật lại trạng thái của hóa đơn
            // => cập nhật lại trạng thái của phòng
            // => cập nhật lại trạng thái của đơn đặt phòng
            BookingRoom bookingRoom = BookingRoomDAO.GetBookingRoomByRoomID(currentRoomId);
            Bill bill = BillDAO.getBillByCustomerId(bookingRoom.MaKhachHang);
            BillDAO.upBillState(bill.MaHoaDon, "paid");
            foreach (string roomId in bookingRoom.DanhSachMaPhong.Trim().Split(','))
                RoomDAO.updateRoomStateById(roomId, "avaiable");
            BookingRoomDAO.updateBookingRoomConfirm(bookingRoom.Id, true);
            MessageBox.Show("Thanh toán thành công!");
            this.Close();
        }

        private void btn_getRoom_Click(object sender, EventArgs e)
        {
            Room room = RoomDAO.getRoomByID(currentRoomId);
            if (room.State.ToLower() == "avaiable")
                actionWhenAvaiable();
            else if (room.State.ToLower() == "reserved")
                actionWhenReserved();
            else if (room.State.ToLower() == "occupied")
                actionWhenOccupied();
        }



        private void gunaContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btn_saveInomation_Click(object sender, EventArgs e)
        {

        }
    }
}
