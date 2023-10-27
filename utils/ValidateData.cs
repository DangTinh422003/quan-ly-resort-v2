using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace quan_ly_resort_v2.utils
{
    internal class ValidateData
    {

        public static bool validateUsername(string username)
        {
            if (username.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập Tên Đăng Nhập!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (username.Length < 5 || username.Length >= 20)
            {
                MessageBox.Show("Tên đăng nhập tối thiểu 5 kí tự, và tối đa 20 kí tự!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (username.Contains(" "))
            {
                MessageBox.Show("Tên đăng nhập không bao gồm khoảng trắng!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool validatePassword(string password)
        {
            if (password.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập Mật Khẩu!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (password.Length < 5 || password.Length >= 20)
            {
                MessageBox.Show("Mật khẩu tối thiểu 5 kí tự, và tối đa 20 kí tự!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (password.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không bao gồm khoảng trắng!", "Có lỗi xãy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool validate(string username, string password)
        {
            if (validateUsername(username) && validatePassword(password))
                return true;
            else
            {
                return false;
            }

        }
    }
}
