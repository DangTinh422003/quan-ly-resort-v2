using Guna.UI.WinForms;
using Microsoft.Office.Interop.Excel;
using quan_ly_resort_v2.DAO;
using quan_ly_resort_v2.model;
using quan_ly_resort_v2.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using System.Xml.Linq;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quan_ly_resort_v2.userControl
{
    public partial class UscManageVoucher : UserControl
    {
        public UscManageVoucher()
        {
            InitializeComponent();
            getDataVoucher();
            disableControl();
            disableFormInput();
            cleanForm();
        }

        public void getDataVoucher()
        {
            btnAdd.Enabled = true;
            disableControl();
            cleanForm();
            disableFormInput();

            var vouchers = VoucherDAO.GetVouchers();
            lbl_title.Text = "Chức năng hiện tại : Chưa chọn!";

            if (vouchers != null && vouchers.Count > 0)
            {
                voucherTable.DataSource = vouchers;
            }
            else
            {
                voucherTable.DataSource = null;
            }
        }

        private void cleanForm()
        {
            cbb_search.SelectedIndex = 0;
            txtVoucher.Text = "";
            txtCount.Text = "";
            txtGiamgia.Text = "";
            StartDate.Value = DateTime.Now;
            EndDate.Value = DateTime.Now;
        }

        private void disableControl()
        {
            btnSave.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void enableControl()
        {
            btnSave.Enabled = true;
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void enableFormInput()
        {
            txtVoucher.Enabled = true;
            txtCount.Enabled = true;
            txtGiamgia.Enabled = true;
            StartDate.Enabled = true;
            EndDate.Enabled = true;
        }
        private void disableFormInput()
        {
            txtVoucher.Enabled = false;
            txtCount.Enabled = false;
            txtGiamgia.Enabled = false;
            StartDate.Enabled = false;
            EndDate.Enabled = false;
        }

        private void voucherTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtVoucher.ReadOnly = true;

            if (e.RowIndex >= 0)
            {
                enableControl();
                btnAdd.Enabled = false;

                DataGridViewRow selectedRow = voucherTable.Rows[e.RowIndex];

                txtVoucher.Text = selectedRow.Cells[0].Value.ToString();
                txtGiamgia.Text = selectedRow.Cells[1].Value.ToString();
                string startDate = selectedRow.Cells[2].Value.ToString();
                string endDate = selectedRow.Cells[3].Value.ToString();
                txtCount.Text = selectedRow.Cells[4].Value.ToString();
                StartDate.Value = DateTime.Parse(startDate);
                EndDate.Value = DateTime.Parse(endDate);


            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string typeSelectValue = cbb_search.Text.Trim();
            string textSearchValue = textbox_search.Text.Trim();
            if (typeSelectValue == "" || textSearchValue == "")
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm và nhập thông tin tìm kiếm", "Nhập lựa chọn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                voucherTable.DataSource = VoucherDAO.FilterByField(typeSelectValue, textSearchValue);
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            string textSearchValue = textbox_search.Text.Trim();
            if (textSearchValue != "")
                btn_search_Click(sender, e);
        }

        private void textbox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_search_Click(sender, e);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            getDataVoucher();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "Chức năng hiện tại : Thêm voucher";
            enableFormInput();

            txtVoucher.Focus();

            btnAdd.Enabled = true;
            btnSave.Enabled = true;
            btnModify.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanForm();
            btnAdd.Enabled = true;
            disableControl();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maVoucher = txtVoucher.Text;

            if (string.IsNullOrWhiteSpace(maVoucher))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
                return;
            }

            string message = "Bạn có chắc muốn xóa nhân viên có mã: " + maVoucher + " không?";
            string caption = "Xác nhận xóa";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                bool deleted = VoucherDAO.DeleteVoucher(maVoucher);

                if (deleted)
                {
                    MessageBox.Show("Voucher đã được xóa thành công.");
                    getDataVoucher(); // Tải lại danh sách nhân viên sau khi xóa
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa Voucher.");
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "Chức năng hiện tại : Sửa thông tin voucher";
            enableFormInput();
            btnDelete.Enabled = false;
            txtGiamgia.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string maVoucher = txtVoucher.Text.Trim();
            string giamGia = txtGiamgia.Text.Trim();
            string count = txtCount.Text.Trim();
            DateTime startDate = StartDate.Value;
            DateTime endDate = EndDate.Value;
            DateTime now = DateTime.Now;

            float giamgia;
            if (!float.TryParse(giamGia, out giamgia) || giamgia < 100000 || giamgia > 1000000)
            {
                MessageBox.Show("Giảm giá không hợp lệ! Giảm giá phải nằm trong khoảng từ 100,000đ đến 1,000,000đ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int countValue;
            if (!int.TryParse(count, out countValue) || countValue > 100 )
            {
                MessageBox.Show("Số lần còn lại không hợp lệ! Số lần phải nằm trong khoảng từ 100.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] requiredFields = { maVoucher, giamGia, count };

            if (requiredFields.Any(string.IsNullOrEmpty) || startDate == null || endDate == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check type function
            if (btnAdd.Enabled)
            {
        
                if ( startDate < now )
                {
                    MessageBox.Show("Ngày bắt đầu voucher lớn ngày hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if  (endDate < startDate )
                {
                   MessageBox.Show("Ngày kết thúc voucher lớn hơn ngày bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Voucher newVoucher = new Voucher(maVoucher, giamgia, startDate, endDate, countValue);
                bool isAdded = VoucherDAO.addNewVoucher(newVoucher);
                if (isAdded)
                    MessageBox.Show("Thêm voucher thành công!", "Thêm voucher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Có lỗi xãy ra!", "Thêm voucher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getDataVoucher();
            }
            else if (btnModify.Enabled)
            {

                Voucher voucher = new Voucher(maVoucher, giamgia, startDate, endDate, countValue);
                bool isUpdated = VoucherDAO.UpdateVoucher(voucher);

                if (isUpdated)
                    MessageBox.Show("Cập nhật Voucher thành công!", "Cập nhật thông tin Voucher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Có lỗi xảy ra!", "Cập nhật thông tin nhân viên Voucher", MessageBoxButtons.OK, MessageBoxIcon.Error);

                getDataVoucher();
            }
        }
    }
}
