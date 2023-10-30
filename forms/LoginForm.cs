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
        public static Account accountLogined = new Account("", "");

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
            
            if(username != username.Trim() || password != password.Trim())
            {
                MessageBox.Show("Username hoặc Password chứa khoảng trắng ở đầu hoặc cuối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                    if (!PasswordUils.ComparePassword(password, currentAccoutn.Password))
                    {
                        MessageBox.Show("Mật khẩu không chính xác!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        accountLogined = new Account(currentAccoutn);
                        var mainForm = new MainForm();
                        Program.myAppCxt.MainForm = mainForm;
                        mainForm.Show();
                        this.Close();
                    }
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
            RegisterForm registerForm = new RegisterForm();
            Program.myAppCxt.MainForm = registerForm;
            registerForm.Show();
            this.Close();
        }

        private void checkBoxShowPassword_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '*';
        }
    }
}
