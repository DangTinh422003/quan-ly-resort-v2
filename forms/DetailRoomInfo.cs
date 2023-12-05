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
        private string currentBookingRoomId;
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
        public void setBookingRoomID(string bookingRoomId)
        {
            currentBookingRoomId = bookingRoomId;
        }

        private void DetailRoomInfo_Load(object sender, EventArgs e)
        {
            lb_roomId.Text = currentRoomId;
            Room room = RoomDAO.getRoomByID(currentRoomId);
            if (room.State.Trim().ToLower() == "avaiable")
            {
                comboBoxServiceType.Enabled = false;
                lb_roomState.Text = "Phòng trống";
                lb_isConfirmRoom.Text = "Chưa nhận phòng";
                lb_dayCounter.Text = "";
                lb_peopleCounter.Text = "";
            }
            else if (room.State.Trim().ToLower() == "reserved")
            {
                comboBoxServiceType.Enabled = true;

                BookingRoom bookingRoom = BookingRoomDAO.GetBookingRoomByID(currentBookingRoomId);
                Customer customer = CustomerDAO.getCustomerById(bookingRoom.MaKhachHang);
                lb_roomState.Text = customer.Fullname;
                lb_isConfirmRoom.Text = bookingRoom.NgayCheckInDuKien.ToString("dd/MM/yyyy");
                lb_dayCounter.Text = bookingRoom.SoNgayThue.ToString() + " ngày";
                lb_peopleCounter.Text = bookingRoom.SoNguoiThue.ToString() + " người";
                comboBoxSelectRoomState.SelectedIndex = comboBoxSelectRoomState.Items.IndexOf("Phòng đã đặt");
                comboBox_isClean.SelectedIndex = comboBox_isClean.Items.IndexOf(room.IsClean ? "Đã dọn dẹp" : "Chưa dọn dẹp");
            }
            else if (room.State.Trim().ToLower() == "occupied")
            {
                comboBoxServiceType.Enabled = false;
                btn_getRoom.Text = "Thanh toán";
                textbox_voucher.Enabled = true;

                BookingRoom bookingRoom = BookingRoomDAO.GetBookingRoomByID(currentBookingRoomId);
                Customer customer = CustomerDAO.getCustomerById(bookingRoom.MaKhachHang);
                lb_roomState.Text = customer.Fullname;
                lb_isConfirmRoom.Text = bookingRoom.NgayCheckInDuKien.ToString("dd/MM/yyyy");
                lb_dayCounter.Text = bookingRoom.SoNgayThue.ToString() + " ngày";
                lb_peopleCounter.Text = bookingRoom.SoNguoiThue.ToString() + " người";
                comboBoxSelectRoomState.SelectedIndex = comboBoxSelectRoomState.Items.IndexOf("Phòng đang thuê");
                comboBox_isClean.SelectedIndex = comboBox_isClean.Items.IndexOf(room.IsClean ? "Đã dọn dẹp" : "Chưa dọn dẹp");
                // load table service target
            }
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void actionWhenReserved()
        {
            comboBoxSelectRoomState.SelectedIndex = comboBoxSelectRoomState.Items.IndexOf("Phòng đang thuê");
            BookingRoom bookingRoom = BookingRoomDAO.GetBookingRoomByID(currentBookingRoomId);
            Customer customer = CustomerDAO.getCustomerById(bookingRoom.MaKhachHang);
            Employee employee = EmployeeDAO.GetEmployeeByUsername(LoginForm.accountLogined.Username);
            Bill bill = new Bill();
            bill.MaHoaDon = new Random().Next(9999).ToString();
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
            BookingRoomDAO.updateBookingRoomConfirm(currentBookingRoomId, true);

            string billId = BillDAO.getBillByCustomerId(customer.Id).MaHoaDon;
            double newTotalMoney = bill.TongTien;
            foreach (DataGridViewRow row in tableServiceTarget.Rows)
            {
                BillServiceDAO.add(new BillService(
                    billId,
                    row.Cells[0].Value.ToString(),
                    int.Parse(row.Cells[1].Value.ToString())
                ));
                newTotalMoney += int.Parse(row.Cells[1].Value.ToString()) * int.Parse(row.Cells[3].Value.ToString());
            }

            BillDAO.updateMoneyById(billId, newTotalMoney);

            MessageBox.Show("Nhận phòng thành công!");
            this.Close();
        }

        private void actionWhenAvaiable()
        {
            MessageBox.Show("Vui lòng tạo đơn đặt phòng mới rồi mới nhận phòng!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void actionWhenOccupied()
        {
            BookingRoom bookingRoom = BookingRoomDAO.GetBookingRoomByRoomID(currentRoomId);
            Bill bill = BillDAO.getBillByCustomerId(bookingRoom.MaKhachHang);
            if (textbox_voucher.Text != "")
            {
                Voucher voucher = VoucherDAO.getById(textbox_voucher.Text);
                if (voucher == null)
                    MessageBox.Show("Mã voucher không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                else
                {
                    if (voucher.Count <= 0)
                        MessageBox.Show("Mã voucher đã hết lượt sử dụng!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    else
                    {
                        VoucherDAO.UpdateVoucher(new Voucher(voucher.MaVoucher, voucher.GiamGia, voucher.StartDate, voucher.EndDate, voucher.Count - 1 <= 0 ? 0 : voucher.Count - 1));
                        BillDAO.updateMoneyById(bill.MaHoaDon, bill.TongTien - voucher.GiamGia);
                    }
                }
            }
            BillDAO.updateBillState(bill.MaHoaDon, "paid");
            foreach (string roomId in bookingRoom.DanhSachMaPhong.Trim().Split(','))
                RoomDAO.updateRoomStateById(roomId, "avaiable");
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

        private void comboBoxServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxServiceType.Text == "Tất cả")
            {
                tableServiceSelect.Rows.Clear();
                List<Service> servicesAll = ServiceDAO.GetServiceList();
                foreach (Service service in servicesAll)
                {
                    if (!checkContainsRoomInTable(service.MaDV, tableServiceTarget))
                        tableServiceSelect.Rows.Add(service.MaDV, service.TenDV, service.Gia);
                }
            }
            else
            {
                tableServiceSelect.Rows.Clear();
                List<Service> servicesFood = ServiceDAO.GetServicesByType(comboBoxServiceType.Text);
                foreach (Service service in servicesFood)
                {
                    if (!checkContainsRoomInTable(service.MaDV, tableServiceTarget))
                        tableServiceSelect.Rows.Add(service.MaDV, service.TenDV, service.Gia);
                }
            }

        }

        private bool checkContainsRoomInTable(string roomId, DataGridView table)
        {
            foreach (DataGridViewRow row in table.Rows)
            {
                if (row.Cells[0].Value.ToString() == roomId)
                    return true;
            }
            return false;
        }

        private void tableServiceSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableServiceSelect.SelectedCells.Count > 0)
            {
                int selectedrowindex = tableServiceSelect.SelectedCells[0].RowIndex;
                if (!checkContainsRoomInTable(tableServiceSelect.Rows[selectedrowindex].Cells[0].Value.ToString(), tableServiceTarget))
                {
                    this.tableServiceTarget.Rows.Add(
                        tableServiceSelect.Rows[selectedrowindex].Cells[0].Value.ToString(),
                        1, //so luong = 1
                        tableServiceSelect.Rows[selectedrowindex].Cells[1].Value.ToString(),
                        tableServiceSelect.Rows[selectedrowindex].Cells[2].Value.ToString()
                    );
                    this.tableServiceSelect.Rows.RemoveAt(selectedrowindex);
                }
            }
        }

        private void tableServiceTarget_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (tableServiceTarget.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                int selectedrowindex = tableServiceTarget.SelectedCells[0].RowIndex;
                this.tableServiceSelect.Rows.Add(
                    tableServiceTarget.Rows[selectedrowindex].Cells[0].Value.ToString(),
                    tableServiceTarget.Rows[selectedrowindex].Cells[2].Value.ToString(),
                    tableServiceTarget.Rows[selectedrowindex].Cells[3].Value.ToString()
                );
                this.tableServiceTarget.Rows.RemoveAt(selectedrowindex);
                comboBoxServiceType_SelectedIndexChanged(sender, e);
            }
            else if (tableServiceTarget.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                // tang so luong len 1
                tableServiceTarget.Rows[e.RowIndex].Cells[1].Value =
                    int.Parse(tableServiceTarget.Rows[e.RowIndex].Cells[1].Value.ToString()) + 1;
            }
            else if (tableServiceTarget.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                // tang so luong len 1
                if (int.Parse(tableServiceTarget.Rows[e.RowIndex].Cells[1].Value.ToString()) - 1 <= 0)
                {
                    int selectedrowindex = tableServiceTarget.SelectedCells[0].RowIndex;
                    this.tableServiceSelect.Rows.Add(
                        tableServiceTarget.Rows[selectedrowindex].Cells[0].Value.ToString(),
                        tableServiceTarget.Rows[selectedrowindex].Cells[2].Value.ToString(),
                        tableServiceTarget.Rows[selectedrowindex].Cells[3].Value.ToString()
                    );
                    this.tableServiceTarget.Rows.RemoveAt(selectedrowindex);
                    comboBoxServiceType_SelectedIndexChanged(sender, e);
                }
                else
                    tableServiceTarget.Rows[e.RowIndex].Cells[1].Value = int.Parse(tableServiceTarget.Rows[e.RowIndex].Cells[1].Value.ToString()) - 1;
            }
        }
    }
}
