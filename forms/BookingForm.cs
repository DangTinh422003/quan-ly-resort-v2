using Org.BouncyCastle.Asn1.X509;
using quan_ly_resort_v2.DAO;
using quan_ly_resort_v2.model;
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
        public BookingForm()
        {
            InitializeComponent();
            renderSelectRoomTable();
        }

        private void renderSelectRoomTable()
        {
            List<Room> rooms = RoomDAO.getRoomsByRoomState("available");
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

        private bool checkContainsRoomInTable(string roomId)
        {
            foreach (DataGridViewRow row in tableRoomTarget.Rows)
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
                if (!checkContainsRoomInTable(tableRoomAvaiable.Rows[selectedrowindex].Cells[0].Value.ToString()))
                    this.tableRoomTarget.Rows.Add(
                        tableRoomAvaiable.Rows[selectedrowindex].Cells[0].Value.ToString(),
                        tableRoomAvaiable.Rows[selectedrowindex].Cells[1].Value.ToString(),
                        tableRoomAvaiable.Rows[selectedrowindex].Cells[2].Value.ToString(),
                        tableRoomAvaiable.Rows[selectedrowindex].Cells[3].Value.ToString()
                    );
                else MessageBox.Show("Phòng đã được chọn", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tableRoomTarget_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

            //
            if (!ValidateData.IsValidEmail(customerEmail))
            {
                MessageBox.Show("Email không hợp lệ, vui lòng kiểm tra lại!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Thông tin khách hàng hợp lệ");
        }
    }
}
