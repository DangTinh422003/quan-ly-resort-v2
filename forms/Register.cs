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


        private void gunaButton1_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Location = this.Location;
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.FormClosing += delegate { this.Show(); };
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Đăng kí thành công!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userNameTextBox.Text = "";
                        passwordTextBox.Text = "";
                        confirmPasswordTextbox.Text = "";
                    }
                }
            }
        }
    }
}
