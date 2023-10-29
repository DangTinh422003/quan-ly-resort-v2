﻿using System;
using quan_ly_resort_v2.userControl;
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
using quan_ly_resort_v2.resources;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace quan_ly_resort_v2.userControl
{
    public partial class UscManageServices : UserControl
    {
        public UscManageServices()
        {
            InitializeComponent();
        }
        private void UscManageServices_Load(object sender, EventArgs e)
        {
            txtMaDV.Visible = false;
            GroupBox3.Visible = false;
            LoadServiceData();
            cleanForm();
            disableControl();
            disableFormInput();


        }
        private void LoadServiceData()
        {
            btnAdd.Enabled = true;
            var services = ServiceDAO.GetServiceList();
            LabelTitle.Text = "Chức năng hiện tại : Chưa chọn!";

            if (services != null && services.Count > 0)
            {
                DataGridView.DataSource = services;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu dịch vụ để hiển thị.");
            }
        }

        private void cleanForm()
        {
            txtMaDV.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtDetail.Text = "";
            ccbSelectService.SelectedIndex = 0;
        }

        private void disableControl()
        {   
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnDetail.Enabled = false;
        }
        private void enableControl()
        {
            btnAdd.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }
        private void disableFormInput()
        {
            txtMaDV.Enabled = false;
            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtDetail.Enabled = false;
        }
        private void enableFormInput()
        {
            txtMaDV.Enabled = true;
            txtName.Enabled = true;
            txtPrice.Enabled = true;
            txtDetail.Enabled = true;
        }


        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            txtMaDV.ReadOnly = true;
            btnDetail.Enabled = true;

            if (e.RowIndex >= 0)
            {
                enableControl();
                DataGridViewRow selectedRow = DataGridView.Rows[e.RowIndex];

                txtMaDV.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtDetail.Text = selectedRow.Cells[3].Value.ToString();
                txtPrice.Text = selectedRow.Cells[4].Value.ToString();

                string selectedService = selectedRow.Cells[2].Value.ToString();
                ccbSelectService.Text = selectedService;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string typeSelectValue = cbb_search.Text;
            string textSearchValue = txtSearch.Text;
            if (typeSelectValue == "" || textSearchValue == "")
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm và nhập thông tin tìm kiếm", "Nhập lựa chọn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                DataGridView.DataSource = ServiceDAO.FilterByField(typeSelectValue, textSearchValue);
                DataGridView.Columns[4].Visible = false;
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
            UscManageServices_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            enableFormInput();
            LabelTitle.Text = "Chức năng hiện tại : Thêm dịch vụ!";
            txtName.Focus();
            txtMaDV.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            UscManageServices_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {   
            if (string.IsNullOrEmpty(txtMaDV.Text))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ để xóa.", "Xóa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                string maDV = txtMaDV.Text;
                bool isDeleted = ServiceDAO.DeleteService(maDV);

                if (isDeleted)
                {
                    MessageBox.Show("Dịch vụ đã được xóa thành công.", "Xóa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UscManageServices_Load(sender, e); // Tải lại dữ liệu sau khi xóa
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa dịch vụ.", "Xóa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LabelTitle.Text = "Chức năng hiện tại : Sửa thông tin dịch vụ";
            enableFormInput();
            txtMaDV.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các trường dữ liệu
            string tenDV = txtName.Text;
            string chiTietDichVu = txtDetail.Text;
            double gia;

            if (string.IsNullOrEmpty(tenDV) || !double.TryParse(txtPrice.Text, out gia))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và kiểm tra giá dịch vụ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string loaiDV = ccbSelectService.Text; // Lấy giá trị từ ComboBox

            Service service = new Service
            {
                TenDV = tenDV,
                LoaiDV = loaiDV,
                ChiTietDichVu = chiTietDichVu,
                Gia = gia
            };

            if (btnAdd.Enabled)
            {
                bool isAdded = ServiceDAO.AddService(service);
                if (isAdded)
                {
                    MessageBox.Show("Thêm dịch vụ thành công!", "Thêm dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UscManageServices_Load(sender, e); // Tải lại danh sách dịch vụ sau khi thêm
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm dịch vụ.", "Thêm dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnUpdate.Enabled)
            {   

                service.MaDV = txtMaDV.Text; // Lấy giá trị MaDV từ trường ẩn
                bool isUpdated = ServiceDAO.UpdateService(service);
                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật thông tin dịch vụ thành công!", "Cập nhật thông tin dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UscManageServices_Load(sender, e); // Tải lại danh sách dịch vụ sau khi cập nhật
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi cập nhật dịch vụ.", "Cập nhật thông tin dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addUserControll(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            GroupBox3.Controls.Clear();
            GroupBox3.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            GroupBox3.Visible = true;
            UscServiceDetail detailControl = new UscServiceDetail();
            detailControl.MaDVValue = txtMaDV.Text;
            detailControl.BackButtonClicked += (s, args) => {
                // Xử lý khi người dùng ấn nút "back" ở UscServiceDetail
                ShowUscManageServices(); // Đây là phương thức bạn tự định nghĩa để hiển thị lại trang UscManageServices
            };
            addUserControll(detailControl);
        }

        private void ShowUscManageServices()
        {
            // Xóa bất kỳ điều khiển nào đang hiển thị trong gunaGroupBox2
            GroupBox3.Controls.Clear();

            // Hiển thị lại trang UscManageServices
            UscManageServices manageServicesControl = new UscManageServices();
            manageServicesControl.Dock = DockStyle.Fill;
            GroupBox3.Controls.Add(manageServicesControl);
            manageServicesControl.BringToFront();
        }
    }
}
