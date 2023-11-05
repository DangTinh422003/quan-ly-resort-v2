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

namespace quan_ly_resort_v2.userControl
{
    public partial class UscManageAccount : UserControl
    {
        public UscManageAccount()
        {
            InitializeComponent();
        }

        private void UscManageAccount_Load(object sender, EventArgs e)
        {

        }

        private void cleanForm()
        {
            txtName.Text = "";
            txtDate.Value = DateTime.Now;
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
            txtName.Enabled = true;
            txtDate.Enabled = true;
        }
        private void disableFormInput()
        {
            txtName.Enabled = false;
            txtDate.Enabled = false;
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWorkDay.Enabled = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DataGridView.Rows[e.RowIndex];

                txtName.Text = selectedRow.Cells[1].Value.ToString();
                string birthday = selectedRow.Cells[4].Value.ToString();
                string workday = selectedRow.Cells[8].Value.ToString();

                txtDate.Value = DateTime.Parse(birthday);
                txtWorkDay.Value = DateTime.Parse(workday);

                enableControl();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //UscManageAccountant_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            enableFormInput();
            Label_Title.Text = "Chức năng hiện tại : Thêm voucher";
            txtName.Focus();
            btnSave.Enabled = true;
            txtWorkDay.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //UscManageAccountant_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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
                    //UscManageAccountant_Load(sender, e); // Tải lại danh sách nhân viên sau khi xóa
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
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            txtName.Focus();
        }

        /*private void btnSave_Click(object sender, EventArgs e)
        {
            string tenNV = txtName.Text;
            string sdt = txtPhone.Text;
            string email = txtEmail.Text;
            DateTime ngaySinh = txtDate.Value;
            string diaChi = txtAddress.Text;
            string cccd = txtCCCD.Text;
            DateTime ngayVaoLam = txtWorkDay.Value;
            string username = txtUsername.Text;
            string luongStr = txtSalary.Text;

            string[] requiredFields = { tenNV, sdt, email, diaChi, username };
            if (requiredFields.Any(string.IsNullOrEmpty) || ngaySinh == null || ngayVaoLam == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email
            if (tenNV != tenNV.Trim() || diaChi != diaChi.Trim() || username != username.Trim() || email != email.Trim() || cccd != cccd.Trim())
            {
                MessageBox.Show("Không được chứa khoảng trắng ở đầu hoặc cuối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                MessageBox.Show("Lương không hợp lệ! Lương phải nằm trong khoảng từ 1,000,000 đến 999,999,999.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check type function
            if (btnAdd.Enabled)
            {
                // Kiểm tra thời gian làm việc ít nhất là 1 tháng
                TimeSpan workDuration = ngayVaoLam - DateTime.Now;

                if (workDuration.TotalDays < 0 || workDuration.TotalDays > 10)
                {
                    MessageBox.Show("Ngày vào làm phải trong khoảng từ hôm nay đến 10 ngày sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                //UscManageAccountant_Load(sender, e); // Tải lại danh sách nhân viên sau khi thêm
            }
            else if (btnUpdate.Enabled)
            {
                // Đoạn này giữ nguyên, vì bạn đang cập nhật nhân viên đã tồn tại
                string maNV = txtId.Text;
                Employee employee = new Employee(maNV, tenNV, sdt, email, ngaySinh, diaChi, cccd, luong, username);
                bool isUpdated = EmployeeDAO.UpdateEmployee(employee);

                if (isUpdated)
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Cập nhật thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Có lỗi xảy ra!", "Cập nhật thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //UscManageAccountant_Load(sender, e); // Tải lại danh sách nhân viên sau khi cập nhật
            }
        }*/
    }
}
