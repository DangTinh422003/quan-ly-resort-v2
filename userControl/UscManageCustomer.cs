using Guna.UI.WinForms;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_resort_v2.resources
{
    public partial class UscManageCustomer : UserControl
    {
        public UscManageCustomer()
        {
            InitializeComponent();
        }

        private void changeHeaderTableName()
        {
            customerTable.Columns["MaKH"].HeaderText = "Mã khách hàng";
            customerTable.Columns["HoTen"].HeaderText = "Họ và tên";
            customerTable.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            customerTable.Columns["Sdt"].HeaderText = "Số điện thoại";
            customerTable.Columns["DiaChi"].HeaderText = "Địa chỉ";
            customerTable.Columns["username"].HeaderText = "Tên người dùng";
        }

        private void UscManageCustomer_Load(object sender, EventArgs e)
        {
            btn_AddCustomer.Enabled = true;
            customerTable.DataSource = CustomerDAO.getCustomers();
            cleanForm();
            changeHeaderTableName();
            disableControl();

            label_functionName.Text = "Chức năng hiện tại : Chưa chọn!";
        }

        private void cleanForm()
        {
            textbox_id.Text = "";
            textbox_address.Text = "";
            textbox_email.Text = "";
            textbox_name.Text = "";
            textbox_phonenumber.Text = "";
            textbox_username.Text = "";
            dateOfBirthPicker.Value = DateTime.Now;
        }

        private void disableControl()
        {
            btn_SaveCustomer.Enabled = false;
            btn_ModifyCustomer.Enabled = false;
            btn_DeleteCustomer.Enabled = false;
        }

        private void enableControl()
        {
            btn_SaveCustomer.Enabled = true;
            btn_ModifyCustomer.Enabled = true;
            btn_DeleteCustomer.Enabled = true;
        }

        private void enableFormInput()
        {
            textbox_id.Enabled = true;
            textbox_address.Enabled = true;
            textbox_email.Enabled = true;
            textbox_name.Enabled = true;
            textbox_phonenumber.Enabled = true;
            textbox_username.Enabled = true;
            dateOfBirthPicker.Enabled = true;
        }

        private void customerTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customerTable.SelectedCells.Count > 0)
            {
                btn_AddCustomer.Enabled = false;
                btn_ModifyCustomer.Enabled = true;
                btn_DeleteCustomer.Enabled = true;

                int selectedrowindex = customerTable.SelectedCells[0].RowIndex;
                string id = customerTable.Rows[selectedrowindex].Cells[0].Value.ToString();
                string name = customerTable.Rows[selectedrowindex].Cells[1].Value.ToString();
                string birthday = customerTable.Rows[selectedrowindex].Cells[2].Value.ToString();
                string phone = customerTable.Rows[selectedrowindex].Cells[3].Value.ToString();
                string email = customerTable.Rows[selectedrowindex].Cells[4].Value.ToString();
                string address = customerTable.Rows[selectedrowindex].Cells[5].Value.ToString();
                string username = customerTable.Rows[selectedrowindex].Cells[6].Value.ToString();

                textbox_id.Text = id;
                textbox_name.Text = name;
                dateOfBirthPicker.Value = DateTime.Parse(birthday);
                textbox_phonenumber.Text = phone;
                textbox_email.Text = email;
                textbox_address.Text = address;
                textbox_username.Text = username;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string typeSelectValue = cbb_search.Text;
            string textSearchValue = textbox_search.Text;
            if (typeSelectValue == "" || textSearchValue == "")
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm và nhập thông tin tìm kiếm", "Nhập lựa chọn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                customerTable.DataSource = CustomerDAO.filterByField(typeSelectValue, textSearchValue);

        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            string textSearchValue = textbox_search.Text;
            if (textSearchValue != "")
                btn_search_Click(sender, e);
        }

        private void textbox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_search_Click(sender, e);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            UscManageCustomer_Load(sender, e);
        }


        private void textbox_id_TextChanged(object sender, EventArgs e)
        {
            customerTable.DataSource = CustomerDAO.filterByField("MaKH", textbox_id.Text);
            Customer customerDetal = CustomerDAO.getCustomerById(textbox_id.Text);
            if (customerDetal == null)
            {
                textbox_name.Text = "";
                textbox_phonenumber.Text = "";
                textbox_email.Text = "";
                textbox_address.Text = "";
                textbox_username.Text = "";
                dateOfBirthPicker.Value = DateTime.Now;
            }
            else
            {
                textbox_name.Text = customerDetal.Fullname;
                textbox_phonenumber.Text = customerDetal.PhoneNumber;
                textbox_email.Text = customerDetal.Email;
                textbox_address.Text = customerDetal.Address;
                textbox_username.Text = customerDetal.Username;
                dateOfBirthPicker.Value = customerDetal.DateOfBirth;
            }
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            cleanForm();
            textbox_id.Focus();
            label_functionName.Text = "Chức năng hiện tại : Thêm khách hàng";

            btn_AddCustomer.Enabled = true;
            btn_SaveCustomer.Enabled = true;
            enableFormInput();
        }

        private void btn_CancelCustomer_Click(object sender, EventArgs e)
        {
            UscManageCustomer_Load(sender, e);
        }

        private void btn_DeleteCustomer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                bool isDeleted = CustomerDAO.deleteCustomerById(textbox_id.Text);
                if (isDeleted)
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UscManageCustomer_Load(sender, e);
                }
                else
                    MessageBox.Show("Có lỗi xãy ra!", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ModifyCustomer_Click(object sender, EventArgs e)
        {
            label_functionName.Text = "Chức năng hiện tại : Sửa thông tin khách hàng";
            enableFormInput();
            btn_SaveCustomer.Enabled = true;
            textbox_id.Enabled = false;
            textbox_name.Focus();
        }

        private void btn_SaveCustomer_Click(object sender, EventArgs e)
        {
            string id = textbox_id.Text;
            string name = textbox_name.Text;
            DateTime birthday = dateOfBirthPicker.Value;
            string phoneNumber = textbox_phonenumber.Text;
            string email = textbox_email.Text;
            string address = textbox_address.Text;
            string username = textbox_username.Text;

            // validate email
            if (!ValidateData.IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!ValidateData.IsPhoneNumber(phoneNumber)) // validate phone number
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check type function
            if (btn_ModifyCustomer.Enabled)
            {
                bool isUpdated = CustomerDAO.updateCustomer(new Customer(id, name, birthday, phoneNumber, email, address, username));
                if (isUpdated)
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Cập nhật thông tin khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Có lỗi xãy ra!", "Cập nhật thông tin khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                customerTable.DataSource = CustomerDAO.getCustomers();
                return;
            }
            else if (btn_AddCustomer.Enabled)
            {
                Customer newCustomer = new Customer(id, name, birthday, phoneNumber, email, address, username);
                bool isAdded = CustomerDAO.addNewCustomer(newCustomer);
                if (isAdded)
                    MessageBox.Show("Thêm khách hàng thành công!", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Có lỗi xãy ra!", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UscManageCustomer_Load(sender, e);
            }
        }
    }
}
