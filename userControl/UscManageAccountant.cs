﻿using System;
using quan_ly_resort_v2.DAO;
using quan_ly_resort_v2.forms;
using quan_ly_resort_v2.model;
using quan_ly_resort_v2.utils;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;


namespace quan_ly_resort_v2.userControl
{
    public partial class UscManageAccountant : UserControl
    {
        public UscManageAccountant()
        {
            InitializeComponent();
        }

        private void LoadEmployeeData()
        {
            // Gọi EmployeeDAO để lấy danh sách nhân viên
            var employees = EmployeeDAO.GetEmployees();

            // Kiểm tra xem danh sách có dữ liệu hay không
            if (employees != null && employees.Count > 0)
            {

                // Gán danh sách nhân viên cho DataGridView
                DataGridView.DataSource = employees;

            }
            else
            {
                MessageBox.Show("Không có dữ liệu nhân viên để hiển thị.");
            }

            Label_Title.Text = "Chức năng hiện tại : Chưa chọn!";
        }
        private void UscManageAccountant_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            LoadEmployeeData();
            cleanForm();
            disableControl();
            disableFormInput();
        }
        private void cleanForm()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtDate.Value = DateTime.Now;
            txtCCCD.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtSalary.Text = "";
            txtWorkDay.Value = DateTime.Now;
            txtUsername.Text = "";
        }
        private void disableControl()
        {
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void enableControl()
        {   btnAdd.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }
        private void enableFormInput()
        {
            txtId.Enabled = true;
            txtName.Enabled = true;
            txtDate.Enabled = true;
            txtCCCD.Enabled = true;
            txtPhone.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtSalary.Enabled = true;
            txtWorkDay.Enabled = true;
            txtUsername.Enabled = true;
        }
        private void disableFormInput()
        {
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtDate.Enabled = false;
            txtCCCD.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtSalary.Enabled = false;
            txtWorkDay.Enabled = false;
            txtUsername.Enabled = false;
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Enabled = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DataGridView.Rows[e.RowIndex];

                txtId.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                string birthday = selectedRow.Cells[4].Value.ToString();
                txtCCCD.Text = selectedRow.Cells[6].Value.ToString();
                txtPhone.Text = selectedRow.Cells[2].Value.ToString();
                txtAddress.Text = selectedRow.Cells[5].Value.ToString();
                txtEmail.Text = selectedRow.Cells[3].Value.ToString();
                txtSalary.Text = selectedRow.Cells[7].Value.ToString();
                string workday = selectedRow.Cells[8].Value.ToString();
                txtUsername.Text = selectedRow.Cells[9].Value.ToString();

                txtDate.Value = DateTime.Parse(birthday);
                txtWorkDay.Value = DateTime.Parse(workday);

                enableControl();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string typeSelectValue = ccbSelect.Text;
            string textSearchValue = txtSearch.Text;
            if (typeSelectValue == "" || textSearchValue == "")
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm và nhập thông tin tìm kiếm", "Nhập lựa chọn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                DataGridView.DataSource = EmployeeDAO.FilterByField(typeSelectValue, textSearchValue);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string textSearchValue = txtSearch.Text;
            if (textSearchValue != "")
                btnSearch_Click(sender, e);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            UscManageAccountant_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            enableFormInput();
            Label_Title.Text = "Chức năng hiện tại : Thêm nhân viên!";
            txtName.Focus();
            btnSave.Enabled = true;
            txtId.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UscManageAccountant_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maNV = txtId.Text;

            if (string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
                return;
            }

            string message = "Bạn có chắc muốn xóa nhân viên có mã: " + maNV + " không?";
            string caption = "Xác nhận xóa";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                bool deleted = EmployeeDAO.DeleteEmployee(maNV);

                if (deleted)
                {
                    MessageBox.Show("Nhân viên đã được xóa thành công.");
                    UscManageAccountant_Load(sender, e); // Tải lại danh sách nhân viên sau khi xóa
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên.");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Label_Title.Text = "Chức năng hiện tại : Sửa thông tin nhân viên";
            enableFormInput();
            txtId.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string tenNV = txtName.Text;
            string sdt = txtPhone.Text;
            string email = txtEmail.Text;
            DateTime ngaySinh = txtDate.Value;
            string diaChi = txtAddress.Text;
            int cccd;
            DateTime ngayVaoLam = txtWorkDay.Value;
            string username = txtUsername.Text;

            string[] requiredFields = { tenNV, sdt, email, diaChi, username };
            if (requiredFields.Any(string.IsNullOrEmpty) || ngaySinh == null || ngayVaoLam == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email
            if (!ValidateData.IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!ValidateData.IsPhoneNumber(sdt)) // Validate phone number
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!ValidateData.validateUsername(username))
            {
                return;
            }

            if (!int.TryParse(txtCCCD.Text, out cccd))
            {
                MessageBox.Show("CCCD không hợp lệ!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double luong;

            if (!double.TryParse(txtSalary.Text, out luong))
            {
                MessageBox.Show("Lương không hợp lệ!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check type function
            if (btnAdd.Enabled)
            {
                string maNV = EmployeeDAO.GetNextMaNV(); // Lấy mã nhân viên tự động
                if (maNV == null)
                {
                    MessageBox.Show("Có lỗi xảy ra khi tạo mã nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Employee newEmployee = new Employee(maNV, tenNV, sdt, email, ngaySinh, diaChi, cccd, luong, ngayVaoLam, username);
                bool isAdded = EmployeeDAO.AddEmployee(newEmployee);

                if (isAdded)
                    MessageBox.Show("Thêm nhân viên thành công!", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Có lỗi xảy ra!", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);

                UscManageAccountant_Load(sender, e); // Tải lại danh sách nhân viên sau khi thêm
            }
            else if (btnUpdate.Enabled)
            {
                // Đoạn này giữ nguyên, vì bạn đang cập nhật nhân viên đã tồn tại
                string maNV = txtId.Text;
                Employee employee = new Employee(maNV, tenNV, sdt, email, ngaySinh, diaChi, cccd, luong, ngayVaoLam, username);
                bool isUpdated = EmployeeDAO.UpdateEmployee(employee);

                if (isUpdated)
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Cập nhật thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Có lỗi xảy ra!", "Cập nhật thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);

                UscManageAccountant_Load(sender, e); // Tải lại danh sách nhân viên sau khi cập nhật
            }
        }



    }
}