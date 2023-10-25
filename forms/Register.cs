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
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextbox.Text;

            if (ValidateData.validate(username, password))
            {
                if (ValidateData.validatePassword(confirmPassword))
                {
                    if (password != confirmPassword)
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Account currentAccount = AccountDAO.GetAccount(username);
                        if (currentAccount != null) // Đã tồn tại user này -> không cho đăng kí
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            AccountDAO.AddNewAccount(new Account(userNameTextBox.Text, passwordTextBox.Text));
                            MessageBox.Show("Đăng kí thành công!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            userNameTextBox.Focus();
                            userNameTextBox.Text = "";
                            passwordTextBox.Text = "";
                            confirmPasswordTextbox.Text = "";
                        }
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
