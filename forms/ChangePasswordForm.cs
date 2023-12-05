using quan_ly_resort_v2.DAO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace quan_ly_resort_v2.forms
{
    public partial class ChangePasswordForm : Form
    {
        private String username;
        public ChangePasswordForm(string username)
        {
            InitializeComponent();
            this.username = username;
            label1.Text = "Enter the password you want to change for: " + username;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            String password = input_pwd.Text;
            String cPassword = input_rpwd.Text;
            String message = "";

            if (!ValidateData.validatePassword(password))
            {
                
            }else if(!password.Equals(cPassword))
            {
                message = "Mật khẩu không trùng khớp!";
                MessageBox.Show(message, "error");
            }
            else
            {
                string hassPassword = PasswordUils.HashingPassword(password);
                AccountDAO.ChangePassword(username, hassPassword);
                MessageBox.Show("Đã đổi mật khẩu cho tài khoản " + username);
                this.Close();
                return;
            }
            
        }
    }
}
