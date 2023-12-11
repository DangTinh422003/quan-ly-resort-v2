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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quan_ly_resort_v2.resources
{
    public partial class UscManageCustomer : UserControl
    {
        public UscManageCustomer()
        {
            InitializeComponent();
            renderFomr();
        }

        private void renderFomr()
        {
            btn_AddCustomer.Enabled = true;
            customerTable.DataSource = CustomerDAO.getCustomers();
            cleanForm();
            changeHeaderTableName();
            disableControl();

            label_functionName.Text = "Chức năng hiện tại : Chưa chọn!";
        }

        private void changeHeaderTableName()
        {
            customerTable.Columns["Cccd"].HeaderText = "Căn cước công dân";
            customerTable.Columns["HoTen"].HeaderText = "Họ và tên";
            customerTable.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            customerTable.Columns["Sdt"].HeaderText = "Số điện thoại";
            customerTable.Columns["DiaChi"].HeaderText = "Địa chỉ";
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
            cbb_search.SelectedIndex = 0;
            textbox_id.Text = "";
            textbox_address.Text = "";
            textbox_email.Text = "";
            textbox_name.Text = "";
            textbox_phonenumber.Text = "";
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

                textbox_id.Text = id;
                textbox_name.Text = name;
                dateOfBirthPicker.Value = DateTime.Parse(birthday);
                textbox_phonenumber.Text = phone;
                textbox_email.Text = email;
                textbox_address.Text = address;
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
                customerTable.DataSource = CustomerDAO.filterByField(typeSelectValue, textSearchValue);

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

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            //UscManageCustomer_Load(sender, e);
            renderFomr();
        }


        private void textbox_id_TextChanged(object sender, EventArgs e)
        {
            customerTable.DataSource = CustomerDAO.filterByField("Cccd", textbox_id.Text);
            Customer customerDetal = CustomerDAO.getCustomerById(textbox_id.Text);
            if (customerDetal == null)
            {
                textbox_name.Text = "";
                textbox_phonenumber.Text = "";
                textbox_email.Text = "";
                textbox_address.Text = "";
                dateOfBirthPicker.Value = DateTime.Now;
            }
            else
            {
                textbox_name.Text = customerDetal.Fullname;
                textbox_phonenumber.Text = customerDetal.PhoneNumber;
                textbox_email.Text = customerDetal.Email;
                textbox_address.Text = customerDetal.Address;
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
            //UscManageCustomer_Load(sender, e);
            renderFomr();
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
                    //UscManageCustomer_Load(sender, e);
                    renderFomr();
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
            string id = textbox_id.Text.Trim();
            string name = textbox_name.Text.Trim();
            DateTime birthday = dateOfBirthPicker.Value;
            string phoneNumber = textbox_phonenumber.Text.Trim();
            string email = textbox_email.Text.Trim();
            string address = textbox_address.Text.Trim();

            string[] requiredFields = { id, name, email, phoneNumber, address };
            if (requiredFields.Any(string.IsNullOrEmpty) || birthday == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateData.IsValidFullName(name))
            {
                MessageBox.Show("Tên khách hàng không hợp lệ!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool hasNumbers = ValidateData.ContainsNumber(name);
            if (hasNumbers)
            {
                MessageBox.Show("Tên khách hàng không được chứa số!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int currentYear = DateTime.Now.Year;
            int requiredMinBirthYear = currentYear - 60;
            int requiredMaxBirthYear = currentYear - 18;

            if (birthday.Year > requiredMaxBirthYear || birthday.Year < requiredMinBirthYear)
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi đến 70 tuổi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            if (!Regex.IsMatch(id, @"^\d{12}$"))
            {
                MessageBox.Show("CCCD không hợp lệ!, Vui lòng nhập đủ 12 số", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check type function
            if (btn_ModifyCustomer.Enabled)
            {
                bool isUpdated = CustomerDAO.updateCustomer(new Customer(id, name, birthday, phoneNumber, email, address));
                if (isUpdated)
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Cập nhật thông tin khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Có lỗi xãy ra!", "Cập nhật thông tin khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                customerTable.DataSource = CustomerDAO.getCustomers();
                return;
            }
            else if (btn_AddCustomer.Enabled)
            {
                Customer newCustomer = new Customer(id, name, birthday, phoneNumber, email, address);
                bool isAdded = CustomerDAO.addNewCustomer(newCustomer);
                if (isAdded)
                    MessageBox.Show("Thêm khách hàng thành công!", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Có lỗi xãy ra!", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //UscManageCustomer_Load(sender, e);
                renderFomr();
            }
        }

        private void ExportExcelFile(DataTable dataGridTable, string sheetname, string title)
        {
            // Tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Worksheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            // Tạo mới một Excel WorkBook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = (Microsoft.Office.Interop.Excel.Worksheets)oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;

            // Tạo phần tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã khách hàng";
            cl1.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Họ và tên";
            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Ngày sinh";
            cl3.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Số điện thoại";
            cl4.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Email";
            cl5.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Địa chỉ";
            cl5.ColumnWidth = 40.0;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Tên người dùng";
            cl7.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");
            rowHead.Font.Bold = true;
            rowHead.Font.Name = "Times New Roman";
            rowHead.Font.Size = "13";
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;


            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            object[,] arr = new object[dataGridTable.Rows.Count, dataGridTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < dataGridTable.Rows.Count; r++)
            {
                DataRow dr = dataGridTable.Rows[r];
                for (int c = 0; c < dataGridTable.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dataGridTable.Rows.Count - 2;
            int columnEnd = dataGridTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;

            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbb_search_SelectedValueChanged(object sender, EventArgs e)
        {
            textbox_search.Text = "";
            textbox_search.Focus();
        }
    }
}
