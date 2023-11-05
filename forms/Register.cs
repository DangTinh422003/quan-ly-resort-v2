using Guna.UI2.WinForms;
using quan_ly_resort_v2.DAO;
using quan_ly_resort_v2.model;
using quan_ly_resort_v2.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_resort_v2.forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void handleSubmit()
        {
            string username = userNameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string confirmPassword = confirmPasswordTextbox.Text.Trim();
            string email = textboxEmail.Text.Trim();

            if (ValidateData.validate(username, password))
            {
                if (ValidateData.validatePassword(confirmPassword))
                {
                    if (password != confirmPassword)
                        MessageBox.Show("Mật khẩu không trùng khớp!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (!ValidateData.IsValidEmail(email))
                        {
                            Account currentAccount = AccountDAO.GetAccount(username);
                            if (currentAccount != null) // Đã tồn tại user này -> không cho đăng kí
                                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                string hassPassword = PasswordUils.HashingPassword(passwordTextBox.Text);
                                AccountDAO.AddNewAccount(new Account(userNameTextBox.Text, hassPassword, email, "employee"));
                                MessageBox.Show("Đăng kí thành công!", "Trạng thái đăng ký!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                var loginForm = new LoginForm();
                                Program.myAppCxt.MainForm = loginForm;
                                loginForm.Show();
                                this.Close();
                            }
                        }
                        else
                            MessageBox.Show("Email không hợp lệ!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_backToLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            Program.myAppCxt.MainForm = loginForm;
            loginForm.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            handleSubmit();
        }

        private void userNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                handleSubmit();
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                handleSubmit();
        }

        private void confirmPasswordTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                handleSubmit();
        }

        private void checkBoxShowPassword_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '*';
            confirmPasswordTextbox.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '*';
        }
    }
}
