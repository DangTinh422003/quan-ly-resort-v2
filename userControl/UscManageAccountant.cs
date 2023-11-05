using System;
using System.Text.RegularExpressions;
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

            txtId.Visible = false;
            btnAdd.Enabled = true;
            LoadEmployeeData();
            cleanForm();
            disableControl();
            disableFormInput();
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
                DataGridView.DataSource = null;
            }

            Label_Title.Text = "Chức năng hiện tại : Chưa chọn!";
        }
        private void UscManageAccountant_Load(object sender, EventArgs e)
        {
            txtId.Visible = false;
            btnAdd.Enabled = true;
            LoadEmployeeData();
            cleanForm();
            disableControl();
            disableFormInput();
        }
        private void cleanForm()
        {
            ccbSelect.SelectedIndex = 0;
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
            txtRole.Text = "";
        }
        private void disableControl()
        {
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void enableControl()
        {
            btnAdd.Enabled = false;
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
            txtUsername.Enabled = true;
            txtRole.Enabled = true;
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
            txtRole.Enabled = false;
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Enabled = false;
            txtWorkDay.Enabled = false;

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
                txtRole.Text = selectedRow.Cells[10].Value.ToString();

                txtDate.Value = DateTime.Parse(birthday);
                txtWorkDay.Value = DateTime.Parse(workday);

                enableControl();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string typeSelectValue = ccbSelect.Text.Trim();
            string textSearchValue = txtSearch.Text.Trim();
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
            string textSearchValue = txtSearch.Text.Trim();
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
            txtWorkDay.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UscManageAccountant_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maNV = txtId.Text.Trim();

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
            txtUsername.Enabled = false;
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string tenNV = txtName.Text.Trim();
            string sdt = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            DateTime ngaySinh = txtDate.Value;
            string diaChi = txtAddress.Text.Trim();
            string cccd = txtCCCD.Text.Trim();
            DateTime ngayVaoLam = txtWorkDay.Value;
            string username = txtUsername.Text.Trim();
            string luongStr = txtSalary.Text.Trim();

            int role;

            if (!int.TryParse(txtRole.Text, out role))
            {
                MessageBox.Show("Vai trò không hợp lệ. Vai trò phải là một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (role < 0 || role > 2)
            {
                MessageBox.Show("Vai trò phải là 0, 1 hoặc 2.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] requiredFields = { tenNV, sdt, email, diaChi, username };
            if (requiredFields.Any(string.IsNullOrEmpty) || ngaySinh == null || ngayVaoLam == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email
            /*if (tenNV != tenNV.Trim() || diaChi != diaChi.Trim() || username != username.Trim() || email != email.Trim() || cccd != cccd.Trim())
            {
                MessageBox.Show("Không được chứa khoảng trắng ở đầu hoặc cuối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

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

            double luong;
            if (!double.TryParse(luongStr, out luong) || luong < 1000000 || luong >= 1000000000)
            {
                MessageBox.Show("Lương không hợp lệ! Lương phải nằm trong khoảng từ 1,000,000đ đến 999,999,999đ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnAdd.Enabled)
            {
                // Kiểm tra thời gian làm việc ít nhất là 1 tháng
                TimeSpan workDuration = ngayVaoLam - DateTime.Now;

                if (ngayVaoLam == DateTime.Now || workDuration.TotalDays >= 7)
                {
                    MessageBox.Show("Ngày vào làm phải trong khoảng từ hôm nay đến 7 ngày sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Regex.IsMatch(cccd, @"^\d{12}$"))
                {
                    MessageBox.Show("CCCD không hợp lệ!, Vui lòng nhập đủ 12 số", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int currentYear = DateTime.Now.Year;
                int requiredMinBirthYear = currentYear - 60;
                int requiredMaxBirthYear = currentYear - 18;

                if (ngaySinh.Year > requiredMaxBirthYear || ngaySinh.Year < requiredMinBirthYear)
                {
                    MessageBox.Show("Nhân viên phải từ 18 tuổi đến 70 tuổi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string maNV = EmployeeDAO.GetNextMaNV();
                if (maNV == null)
                {
                    MessageBox.Show("Có lỗi xảy ra khi tạo mã nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Employee newEmployee = new Employee(maNV, tenNV, sdt, email, ngaySinh, diaChi, cccd, luong, ngayVaoLam, username, role);
                bool isAdded = EmployeeDAO.AddEmployee(newEmployee);

                if (isAdded)
                    MessageBox.Show("Thêm nhân viên thành công!", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Có lỗi xảy ra!", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);

                UscManageAccountant_Load(sender, e);
            }
            else if (btnUpdate.Enabled)
            {
                string maNV = txtId.Text.Trim();
                Employee employee = new Employee(maNV, tenNV, sdt, email, ngaySinh, diaChi, cccd, luong, ngayVaoLam, username, role);
                bool isUpdated = EmployeeDAO.UpdateEmployee(employee);

                if (isUpdated)
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Cập nhật thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Có lỗi xảy ra!", "Cập nhật thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);

                UscManageAccountant_Load(sender, e);
            }
        }

    }
}
