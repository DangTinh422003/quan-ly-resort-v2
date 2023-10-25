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

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextbox.Text;
            if (confirmPassword != password)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thành công!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userNameTextBox.Text = "";
                passwordTextBox.Text = "";
                confirmPasswordTextbox.Text = "";
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

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
    }
}
