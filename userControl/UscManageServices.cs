using System;
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
using quan_ly_resort_v2.model;

namespace quan_ly_resort_v2.userControl
{
    public partial class UscManageServices : UserControl
    {
        public UscManageServices()
        {
            InitializeComponent();
        }

        private void LoadServiceData()
        {
            var services = ServiceDAO.GetServiceList();

            if (services != null && services.Count > 0)
            {
                DataGridView.DataSource = services;
                DataGridView.Columns[4].Visible = false;
            }
            txtMaDV.ReadOnly = false;
            txtMaDV.Text = "";
            txtName.Text = "";
            txtDetail.Text = "";
            txtPrice.Text = "";
            PictureBox.Image = null; // Xóa hình ảnh từ PictureBox
        }

        private void UscManageServices_Load(object sender, EventArgs e)
        {
            LoadServiceData();

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnDetail.Enabled = false;

            txtMaDV.ReadOnly = false;
            txtMaDV.Text = "";
            txtName.Text = "";
            txtDetail.Text = "";
            txtPrice.Text = "";
            PictureBox.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDV.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDetail.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin dịch vụ.");
                return;
            }

            // Kiểm tra hình ảnh đã được tải vào PictureBox
            if (PictureBox.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh dịch vụ.");
                return;
            }

            // Kiểm tra xem txtPrice.Text có thể được chuyển đổi thành một giá trị số thực hay không
            if (!double.TryParse(txtPrice.Text, out double gia))
            {
                MessageBox.Show("Giá dịch vụ không hợp lệ. Vui lòng nhập một số.");
                return;
            }


            // Chuyển hình ảnh từ PictureBox thành mảng byte
            byte[] imageBytes = ImageHelper.ImageToByteArray(PictureBox.Image);

            Service newService = new Service
            {
                MaDV = txtMaDV.Text,
                TenDV = txtName.Text,
                ChiTietDichVu = txtDetail.Text,
                Gia = Convert.ToDouble(txtPrice.Text),
                Picture = imageBytes,
            };

            bool added = ServiceDAO.AddService(newService);

            if (added)
            {
                MessageBox.Show("Dịch vụ đã được thêm thành công.");
                LoadServiceData();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm dịch vụ.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDV.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDetail.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin dịch vụ.");
                return;
            }

            // Kiểm tra hình ảnh đã được tải vào PictureBox
            if (PictureBox.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh dịch vụ.");
                return;
            }

            byte[] imageBytes = ImageHelper.ImageToByteArray(PictureBox.Image);

            Service updatedService = new Service
            {
                MaDV = txtMaDV.Text,
                TenDV = txtName.Text,
                ChiTietDichVu = txtDetail.Text,
                Gia = Convert.ToDouble(txtPrice.Text),
                Picture = imageBytes,
            };

            bool updated = ServiceDAO.UpdateService(updatedService);

            if (updated)
            {
                MessageBox.Show("Dịch vụ đã được cập nhật thành công.");
                LoadServiceData();
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật dịch vụ.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maDV = txtMaDV.Text;

            if (string.IsNullOrWhiteSpace(maDV))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ để xóa.");
                return;
            }

            string message = "Bạn có chắc muốn xóa dịch vụ: " + maDV + " không?";
            string caption = "Xác nhận xóa";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                bool deleted = ServiceDAO.DeleteService(maDV);

                if (deleted)
                {
                    MessageBox.Show("Dịch vụ đã được xóa thành công.");
                    LoadServiceData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa dịch vụ.");
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnDetail.Enabled = false;

            txtMaDV.ReadOnly = false;
            txtMaDV.Text = "";
            txtName.Text = "";
            txtDetail.Text = "";
            txtPrice.Text = "";
            PictureBox.Image = null; // Xóa hình ảnh từ PictureBox
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            txtMaDV.ReadOnly = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnDetail.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DataGridView.Rows[e.RowIndex];

                txtMaDV.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtDetail.Text = selectedRow.Cells[2].Value.ToString();
                txtPrice.Text = selectedRow.Cells[3].Value.ToString();
                byte[] imageBytes = (byte[])selectedRow.Cells[4].Value;
                PictureBox.Image = ImageHelper.ByteArrayToImage(imageBytes);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Chọn hình ảnh dịch vụ";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị hình ảnh được chọn trong PictureBox
                PictureBox.Image = new Bitmap(openFileDialog.FileName);
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

    }
}
