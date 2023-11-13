using quan_ly_resort_v2.DAO;
using quan_ly_resort_v2.forms;
using quan_ly_resort_v2.model;
using quan_ly_resort_v2.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_resort_v2.userControl
{
    public partial class UscManageAccount : UserControl
    {
        private Boolean isAddMode = false;
        public UscManageAccount()
        {
            InitializeComponent();
        }

        private void UscManageAccount_Load(object sender, EventArgs e)
        {
            LoadAccountData();
            cleanForm();
            disableControl();
        }

        private void LoadAccountData()
        {
            btnAdd.Enabled = true;
            var accounts = AccountDAO.GetAccounts();
            Label_Title.Text = "Chức năng hiện tại : Chưa chọn!";

            if (accounts != null && accounts.Count > 0)
            {
                DataGridView.DataSource = accounts;
            }
            else
            {
                DataGridView.DataSource = null;
            }
        }

        private void cleanForm()
        {
            txt_username.Text = string.Empty;
            txt_gmail.Text = string.Empty;
            date_create.Value = DateTime.Now;
            //hello
        }
        private void disableControl()
        {
            btnDelete.Enabled = false;
        }
        private void enableControl()
        {
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
        }

        public void enableSaveButton()
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            isAddMode = false;
            txt_username.Enabled = false;
            Label_Title.Text = "Chức năng hiện tại : Sửa thông tin";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DataGridView.Rows[e.RowIndex];

                txt_username.Text = selectedRow.Cells[0].Value.ToString();
                txt_gmail.Text = selectedRow.Cells[3].Value.ToString();
                combo_role.SelectedText = selectedRow.Cells[4].Value.ToString();
                string create_date = selectedRow.Cells[2].Value.ToString();
                try
                {
                    date_create.Value = DateTime.Parse(create_date);
                }catch(Exception err)
                {
                   Console.WriteLine(err.Message);
                    date_create.Value = DateTime.Now;
                }

            }
            enableControl();
        }
        

        private void btnAll_Click(object sender, EventArgs e)
        {
            //UscManageAccountant_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cleanForm();
            Label_Title.Text = "Chức năng hiện tại : Thêm tài khoản";
            txt_username.Focus();
            txt_username.Enabled = true;
            isAddMode = true;
            enableSaveButton();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isAddMode = false;
            UscManageAccount_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
                return;
            }

            string message = "Bạn có chắc muốn xóa tài khoản: " + username + " không?";
            string caption = "Xác nhận xóa";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                bool deleted = AccountDAO.DeleteAccount(username);

                if (deleted)
                {
                    MessageBox.Show("Tài khoản đã được xóa thành công.");
                    //UscManageAccountant_Load(sender, e); // Tải lại danh sách nhân viên sau khi xóa
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa tài khoản.");
                }
            }

            LoadAccountData();
            cleanForm();
            disableControl();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           String username = txt_username.Text;
            if (!username.Equals(String.Empty))
            {
               ChangePasswordForm changePasswordForm = new ChangePasswordForm(username);
               changePasswordForm.ShowDialog();
                LoadAccountData();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tài khoản!");
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String username = txt_username.Text.Trim();
            String email = txt_gmail.Text.Trim();
            string role = combo_role.SelectedItem.ToString();
            string[] requiredFields = { username, email };

            if (requiredFields.Any(string.IsNullOrEmpty))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateData.IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Account account = new Account
            {
                Username = username,
                Email = email,
                Role = role
            };

            if (isAddMode) {
                account.Password = username;

                Account result = AccountDAO.AddNewAccount(account);
                if(result != null) MessageBox.Show("Thêm tài khoản thành công, mật khẩu mặc định sẽ là tên tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Có lỗi xảy ra khi thêm tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                Boolean result = AccountDAO.UpdateAccount(account);
                if (result) MessageBox.Show("Chỉnh sửa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Có lỗi xảy ra khi sửa thông tin tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadAccountData();
        }
    }
}
