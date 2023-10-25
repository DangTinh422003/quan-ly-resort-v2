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
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            if (ValidateData.validate(username, password))
            {
                Account currentAccoutn = AccountDAO.GetAccount(username);
                if (currentAccoutn == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var mainForm = new MainForm();
                    mainForm.Location = this.Location;
                    mainForm.StartPosition = FormStartPosition.Manual;
                    mainForm.FormClosing += delegate { this.Show(); };
                    mainForm.ShowDialog();
                    this.Close();
                }
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
