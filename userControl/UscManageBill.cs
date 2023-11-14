using System;
using quan_ly_resort_v2.DAO;
using quan_ly_resort_v2.model;
using Excel = Microsoft.Office.Interop.Excel;
using quan_ly_resort_v2.utils;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Web.Security;
using System.IO;
using quan_ly_resort_v2.forms;

namespace quan_ly_resort_v2.userControl
{
    public partial class UscManageBill : UserControl
    {
        private string selectedBillId;

        public UscManageBill()
        {
            InitializeComponent();
            LoadBillData();
            cleanForm();
            disableControl();
            disableFormInput();
        }

        private void LoadBillData()
        {
            // Gọi BillDAO để lấy danh sách nhân viên
            var bill = BillDAO.GetBills();

            // Kiểm tra xem danh sách có dữ liệu hay không
            if (bill != null && bill.Count > 0)
            {

                // Gán danh sách nhân viên cho DataGridView
                DataGridView.DataSource = bill;

            }
            else
            {
                DataGridView.DataSource = null;
            }

            Label_Title.Text = "Chức năng hiện tại : Chưa chọn!";
        }

        private void UscManageBill_Load(object sender, EventArgs e)
        {
            LoadBillData();
            cleanForm();
            disableControl();
            disableFormInput();
        }

        private void cleanForm()
        {
            cbb_search.SelectedIndex = 0;
            txtIdBill.Text = "";
            txtIdKH.Text = "";
            txtIdNV.Text = "";
            txtListRoom.Text = "";
            txtNgayThue.Text = "";
            txtTong.Text = "";
            txtDateCheckIn.Value = DateTime.Now;
            txtDateCrea.Value = DateTime.Now;
        }

        private void disableControl()
        {
            btnDelete.Enabled = false;
            btnDetailBill.Enabled = false;
            /*btnUpdate.Enabled = false;*/
        }

        private void enableControl()
        {
            /*btnSave.Enabled = false;*/
            btnDelete.Enabled = true;
            /*btnUpdate.Enabled = true;*/
        }

        private void enableFormInput()
        {
            txtIdBill.Enabled = true;
            txtIdKH.Enabled = true;
            txtIdNV.Enabled = true;
            txtListRoom.Enabled = true;
            txtNgayThue.Enabled = true;
            txtTong.Enabled = true;
            txtDateCheckIn.Enabled = true;
            txtDateCrea.Enabled = true;
        }

        private void disableFormInput()
        {   
            txtIdBill.Enabled = false;
            txtIdKH.Enabled = false;
            txtIdNV.Enabled = false;
            txtListRoom.Enabled = false;
            txtNgayThue.Enabled = false;
            txtTong.Enabled = false;
            txtDateCheckIn.Enabled = false;
            txtDateCrea.Enabled = false;
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DataGridView.Rows[e.RowIndex];

                txtIdBill.Text = selectedRow.Cells[0].Value.ToString();
                txtIdKH.Text = selectedRow.Cells[1].Value.ToString();
                txtIdNV.Text = selectedRow.Cells[2].Value.ToString();
                txtListRoom.Text = selectedRow.Cells[3].Value.ToString();
                txtNgayThue.Text = selectedRow.Cells[7].Value.ToString();
                txtTong.Text = selectedRow.Cells[5].Value.ToString();

                string NgayTao = selectedRow.Cells[4].Value.ToString();
                txtDateCrea.Value = DateTime.Parse(NgayTao);
                string CheckIn = selectedRow.Cells[6].Value.ToString();
                txtDateCheckIn.Value = DateTime.Parse(CheckIn);

                selectedBillId = txtIdBill.Text;

                btnDetailBill.Enabled = true;

                enableControl();
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
                DataGridView.DataSource = BillDAO.FilterByField(typeSelectValue, textSearchValue);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UscManageBill_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maHD = txtIdBill.Text;

            if (string.IsNullOrWhiteSpace(maHD))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
                return;
            }

            string message = "Bạn có chắc muốn xóa nhân viên có mã: " + maHD + " không?";
            string caption = "Xác nhận xóa";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                bool deleted = BillDAO.DeleteBill(maHD);

                if (deleted)
                {
                    MessageBox.Show("Hóa đơn đã được xóa thành công.");
                    UscManageBill_Load(sender, e); // Tải lại danh sách nhân viên sau khi xóa
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa hóa đơn.");
                }
            }
        }

/*        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Label_Title.Text = "Chức năng hiện tại : Sửa thông tin hóa đơn";
            disableFormInput();
            txtNgayThue.Enabled = true;
            txtTong.Enabled = true;
            btnSave.Enabled = true;
            txtListRoom.Enabled = true;
            btnDelete.Enabled = false;
            txtListRoom.Focus();
        }*/


        /*private void btnSave_Click(object sender, EventArgs e)
        {
            string idBill = txtIdBill.Text;
            string idKH = txtIdKH.Text;
            string idNV = txtIdNV.Text;
            string listRoom = txtListRoom.Text;
            DateTime ngayTao = txtDateCrea.Value;
            DateTime ngayCheckIn = txtDateCheckIn.Value;
            string tongTienStr = txtTong.Text;

            int thoiThue;

            if (!int.TryParse(txtNgayThue.Text, out thoiThue))
            {
                MessageBox.Show("Vai trò không hợp lệ. Vai trò phải là một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double tongTien;
            if (!double.TryParse(tongTienStr, out tongTien) || tongTien < 100000 || tongTien >= 1000000000)
            {
                MessageBox.Show("Lương không hợp lệ! Lương phải nằm trong khoảng từ 100,000đ đến 999,999,999đ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            
            if (btnUpdate.Enabled)
            {
                string maHD = txtIdBill.Text;
                Bill bill = new Bill(maHD, idKH, idNV, listRoom, ngayTao, tongTien, ngayCheckIn, thoiThue);
                bool isUpdated = BillDAO.UpdateBill(bill);

                if (isUpdated)
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Cập nhật thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Có lỗi xảy ra!", "Cập nhật thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);

                UscManageBill_Load(sender, e);
            }
        }*/

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Chọn nơi lưu tệp Excel";

                // Đặt tên mặc định cho tệp xuất
                saveFileDialog.FileName = "Export_Bill.xlsx"; // Đặt tên mặc định ở đây

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Workbooks.Add();
                    Excel.Worksheet worksheet = (Excel.Worksheet)excelApp.ActiveSheet;

                    // Đặt header in đậm và in hoa
                    Excel.Range headerRange = worksheet.get_Range("A1", "I1");
                    headerRange.Merge(); // Gộp ô từ A1 đến F1
                    headerRange.Font.Bold = true;
                    headerRange.Font.Size = 16;
                    headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // Căn giữa
                    headerRange.Value = "DANH SÁCH HÓA ĐƠN"; // Nội dung header

                    // Đặt header cho các cột và in đậm
                    for (int i = 1; i <= DataGridView.Columns.Count; i++)
                    {
                        worksheet.Cells[2, i] = DataGridView.Columns[i - 1].HeaderText;

                        // Đặt định dạng font in đậm cho header
                        Excel.Range headerCell = (Excel.Range)worksheet.Cells[2, i];
                        headerCell.Font.Bold = true;
                    }

                    // Sao chép dữ liệu từ DataGridView vào Excel
                    for (int i = 0; i < DataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < DataGridView.Columns.Count; j++)
                        {
                            // Kiểm tra nếu cột là cột Mã khách hàng
                            if (DataGridView.Columns[j].Name == "MaKH")
                            {
                                // Ép kiểu dữ liệu thành chuỗi và gán cho ô Excel
                                string maKH = DataGridView.Rows[i].Cells[j].Value.ToString();
                                worksheet.Cells[i + 3, j + 1] = maKH;

                                // Đặt định dạng kiểu văn bản (text) cho cột Mã khách hàng
                                Excel.Range cell = (Excel.Range)worksheet.Cells[i + 3, j + 1];
                                cell.NumberFormat = "@";
                            }
                            else
                            {
                                // Xử lý các cột khác
                                worksheet.Cells[i + 3, j + 1] = DataGridView.Rows[i].Cells[j].Value;
                            }
                        }
                    }

                    // Tự động đặt chiều rộng cột bằng với dữ liệu
                    for (int i = 0; i < DataGridView.Columns.Count; i++)
                    {
                        Excel.Range columnRange = (Excel.Range)worksheet.Cells[2, i + 1];
                        columnRange = columnRange.EntireColumn;
                        columnRange.AutoFit();
                    }

                    // Lưu tệp Excel và đóng ứng dụng Excel
                    worksheet.SaveAs(filePath);
                    excelApp.Quit();

                    MessageBox.Show("Dữ liệu đã được xuất thành công vào tệp Excel.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAll_Click(object sender, EventArgs e)
        {
            UscManageBill_Load(sender, e);
        }

        private void btnDetailBill_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedBillId))
            {
                var BillDetailForm = new BillDetailForm(selectedBillId);
                BillDetailForm.ShowDialog();
                UscManageBill_Load(sender, e);
            }
        }
    }
}
