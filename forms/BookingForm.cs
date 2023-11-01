using Org.BouncyCastle.Asn1.X509;
using quan_ly_resort_v2.DAO;
using quan_ly_resort_v2.model;
using quan_ly_resort_v2.userControl;
using quan_ly_resort_v2.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_resort_v2.forms
{
    public partial class BookingForm : Form
    {
        private string bookingRoomId;

        public BookingForm()
        {
            InitializeComponent();
            renderSelectRoomTable();
        }


        public void setData(BookingRoom bookingRoom)
        {
            bookingRoomId = bookingRoom.Id;
            Customer customer = CustomerDAO.getCustomerById(bookingRoom.MaKhachHang);
            textbox_customerId.Text = customer.Id;
            textbox_customerName.Text = customer.Fullname;
            datePicker_dateOfBirth.Value = customer.DateOfBirth;
            textbox_phoneNumber.Text = customer.PhoneNumber;
            textbox_email.Text = customer.Email;
            textbox_address.Text = customer.Address;
            textbox_peopleCounter.Text = bookingRoom.SoNguoiThue.ToString();

            datetimePicker_Checkint.Value = bookingRoom.NgayCheckInDuKien;
            datetimePicker_checkout.Value = bookingRoom.NgayCheckInDuKien.AddDays(bookingRoom.SoNgayThue);

            btn_save.Text = "Cập nhật";

            string[] listRoomId = bookingRoom.DanhSachMaPhong.Split(',');
            foreach (string roomId in listRoomId)
            {
                Room room = RoomDAO.getRoomByID(roomId);
                this.tableRoomTarget.Rows.Add(room.Id, room.Type, room.BedStyle, room.Price);
            }
        }

        private void renderSelectRoomTable()
        {
            this.tableRoomAvaiable.Rows.Clear();
            List<Room> rooms = RoomDAO.getRoomsByRoomState("avaiable");
            lb_roomAvaialbeCounter.Text = rooms.Count.ToString();
            foreach (Room room in rooms)
            {
                this.tableRoomAvaiable.Rows.Add(room.Id, room.Type, room.BedStyle, room.Price);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void tableRoomAvaiable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableRoomAvaiable.SelectedCells.Count > 0)
            {
                int selectedrowindex = tableRoomAvaiable.SelectedCells[0].RowIndex;
                if (!checkContainsRoomInTable(tableRoomAvaiable.Rows[selectedrowindex].Cells[0].Value.ToString(), tableRoomTarget))
                {
                    this.tableRoomTarget.Rows.Add(
                        tableRoomAvaiable.Rows[selectedrowindex].Cells[0].Value.ToString(),
                        tableRoomAvaiable.Rows[selectedrowindex].Cells[1].Value.ToString(),
                        tableRoomAvaiable.Rows[selectedrowindex].Cells[2].Value.ToString(),
                        tableRoomAvaiable.Rows[selectedrowindex].Cells[3].Value.ToString()
                    );
                    this.tableRoomAvaiable.Rows.RemoveAt(selectedrowindex);
                }
            }
        }

        private void tableRoomTarget_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableRoomTarget.SelectedCells.Count > 0)
            {
                int selectedrowindex = tableRoomTarget.SelectedCells[0].RowIndex;
                this.tableRoomTarget.Rows.RemoveAt(selectedrowindex);
                renderSelectRoomTable();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // value
            string customerId = textbox_customerId.Text.Trim();
            string customerName = textbox_customerName.Text.Trim();
            string customerPhone = textbox_phoneNumber.Text.Trim();
            string customerAddress = textbox_address.Text.Trim();
            string customerEmail = textbox_email.Text.Trim();
            DateTime customerDateOfBirth = datePicker_dateOfBirth.Value;
            string peopleCounter = textbox_peopleCounter.Text;

            DateTime dateCheckin = datetimePicker_Checkint.Value;
            DateTime dateCheckout = datetimePicker_checkout.Value;

            // validate
            if (customerId == "" | customerName == "" |
               customerPhone == "" | customerAddress == "" |
               customerEmail == "")
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check customer id
            if (!Regex.IsMatch(customerId, @"^\d{12}$"))
            {
                MessageBox.Show("CCCD không hợp lệ!, Vui lòng nhập đủ 12 số không bao gồm chữ hoặc kí tự khác!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check customer name
            if (!Regex.IsMatch(customerName, @"^[\p{L}a-zA-Z\s]+$"))
            {
                MessageBox.Show("Tên không hợp lệ! Vui lòng nhập đúng.", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check date of birth
            if (customerDateOfBirth >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if ((int)DateTime.Now.Subtract(customerDateOfBirth).Days / 365 < 18)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ, chưa đủ 18 tuổi!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if ((int)DateTime.Now.Subtract(customerDateOfBirth).Days / 365 >= 100)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ, không được vượt quá " +
                        ((int)DateTime.Now.Subtract(customerDateOfBirth).Days / 365) + " tuổi!",
                        "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // check phone number
            if (!ValidateData.IsPhoneNumber(customerPhone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ, vui lòng kiểm tra lại!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check email
            if (!ValidateData.IsValidEmail(customerEmail))
            {
                MessageBox.Show("Email không hợp lệ, vui lòng kiểm tra lại!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check people counter
            if (!Regex.IsMatch(peopleCounter, @"^\d+$"))
            {
                MessageBox.Show("Số người không hợp lệ, vui lòng kiểm tra lại!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check time checkint
            if (dateCheckin <= DateTime.Now)
            {
                MessageBox.Show("Ngày nhận phòng không hợp lệ, vui lòng kiểm tra lại!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check time checkout
            if (dateCheckout <= dateCheckin)
            {
                MessageBox.Show("Ngày trả phòng không hợp lệ, vui lòng kiểm tra lại!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // check room target
            if (tableRoomTarget.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // check customer id in database
            if (btn_save.Text == "Cập nhật")
            {
                BookingRoomDAO.deleteByID(bookingRoomId);
            }

            CustomerDAO.deleteCustomerById(customerId);
            CustomerDAO.addNewCustomer(new Customer(customerId, customerName, customerDateOfBirth, customerPhone, customerEmail, customerAddress));
            string listRoomId = "";
            foreach (DataGridViewRow row in tableRoomTarget.Rows)
            {
                listRoomId += row.Cells[0].Value.ToString() + ",";
            }
            listRoomId = listRoomId.Substring(0, listRoomId.Length - 1);
            BookingRoomDAO.addNew(new BookingRoom("", DateTime.Now, listRoomId, customerId, dateCheckin, dateCheckout.Subtract(dateCheckin).Days, int.Parse(peopleCounter)));

            // update room state
            foreach (DataGridViewRow row in tableRoomTarget.Rows)
            {
                RoomDAO.updateRoomStateById(row.Cells[0].Value.ToString(), "reserved");
            }
            MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
