using quan_ly_resort_v2.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_resort_v2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void handleSubmit()
        {
            if (userNameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                // clear form
                userNameTextBox.Focus();
                userNameTextBox.Text = "";
                passwordTextBox.Text = "";

                var mainForm = new MainForm();
                mainForm.Location = this.Location;
                mainForm.StartPosition = FormStartPosition.Manual;
                mainForm.FormClosing += delegate { this.Show(); };
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác, vui lòng kiểm tra lại!", "Có lỗi xãy ra!", MessageBoxButtons.OK);
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            handleSubmit();
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                handleSubmit();
        }

        private void userNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                handleSubmit();
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Location = this.Location;
            registerForm.StartPosition = FormStartPosition.Manual;
            registerForm.FormClosing += delegate { this.Show(); };
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
