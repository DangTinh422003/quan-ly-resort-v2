using System;
using quan_ly_resort_v2.DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using quan_ly_resort_v2.model;

namespace quan_ly_resort_v2.userControl
{
    public partial class UscManageAccountant : UserControl
    {
        public UscManageAccountant()
        {
            InitializeComponent();
        }

        private void UscManageAccountant_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
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

            txtMaNV.ReadOnly = false;
            txtAddress.Text = "";
            txtCccd.Text = "";
            txtEmail.Text = "";
            txtMaNV.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
            txtWorkday.Value = DateTime.Now;
            txtBirthday.Value = DateTime.Now;

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.ReadOnly = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DataGridView.Rows[e.RowIndex];

                // Trích xuất giá trị "MaNV" từ cột "MaNV" của dòng được chọn
                txtMaNV.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtPhone.Text = selectedRow.Cells[2].Value.ToString();
                txtEmail.Text = selectedRow.Cells[3].Value.ToString();
                txtAddress.Text = selectedRow.Cells[5].Value.ToString();
                txtCccd.Text = selectedRow.Cells[6].Value.ToString();
                txtSalary.Text = selectedRow.Cells[7].Value.ToString();
                //Lay gia Date
                if (selectedRow.Cells[4].Value != null && selectedRow.Cells[4].Value is DateTime)
                {
                    DateTime ngaySinh = Convert.ToDateTime(selectedRow.Cells[4].Value);
                    txtBirthday.Value = ngaySinh;
                }
                if (selectedRow.Cells[8].Value != null && selectedRow.Cells[8].Value is DateTime)
                {
                    DateTime Workday = Convert.ToDateTime(selectedRow.Cells[8].Value);
                    txtWorkday.Value = Workday;
                }


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // thêm nhân viên
            Employee newEmployee = new Employee
            {
                MaNV = txtMaNV.Text,
                TenNV = txtName.Text,
                Sdt = txtPhone.Text,
                Email = txtEmail.Text,
                NgaySinh = Convert.ToDateTime(txtBirthday.Text),
                DiaChi = txtAddress.Text,
                Cccd = Convert.ToInt32(txtCccd.Text),
                Luong = Convert.ToDouble(txtSalary.Text),
                NgayVaoLam = Convert.ToDateTime(txtWorkday.Text)
            };

            bool added = EmployeeDAO.AddEmployee(newEmployee);

            if (added)
            {
                MessageBox.Show("Nhân viên đã được thêm thành công.");
                LoadEmployeeData(); // Cập nhật dữ liệu trên DataGridView
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm nhân viên.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Lấy thông tin nhân viên cần sửa từ các trường nhập liệu
            Employee updatedEmployee = new Employee
            {
                MaNV = txtMaNV.Text,
                TenNV = txtName.Text,
                Sdt = txtPhone.Text,
                Email = txtEmail.Text,
                NgaySinh = txtBirthday.Value,
                DiaChi = txtAddress.Text,
                Cccd = Convert.ToInt32(txtCccd.Text),
                Luong = Convert.ToDouble(txtSalary.Text),
                NgayVaoLam = txtWorkday.Value
            };

            // Gọi phương thức cập nhật nhân viên từ EmployeeDAO
            bool updated = EmployeeDAO.UpdateEmployee(updatedEmployee);

            if (updated)
            {
                MessageBox.Show("Thông tin nhân viên đã được cập nhật thành công.");
                LoadEmployeeData(); // Cập nhật dữ liệu trên DataGridView
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin nhân viên.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;

            // Hiển thị thông báo xác nhận
            string message = "Bạn có chắc muốn xóa Nhân Viên: " + maNV + " không?";
            string caption = "Xác nhận xóa";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                // Người dùng đã xác nhận muốn xóa
                bool deleted = EmployeeDAO.DeleteEmployee(maNV);

                if (deleted)
                {
                    MessageBox.Show("Nhân viên đã được xóa thành công.");
                    LoadEmployeeData(); // Cập nhật dữ liệu trên DataGridView
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên.");
                }
            }
        }

        private void txtRestart_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = false;
            txtAddress.Text = "";
            txtCccd.Text = "";
            txtEmail.Text = "";
            txtMaNV.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
            txtWorkday.Value = DateTime.Now;
            txtBirthday.Value = DateTime.Now;
        }
    }
}
