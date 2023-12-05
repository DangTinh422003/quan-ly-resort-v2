using MySqlX.XDevAPI;
using quan_ly_resort_v2.DAO;
using quan_ly_resort_v2.model;
using quan_ly_resort_v2.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Interop;

namespace quan_ly_resort_v2.forms
{
    public partial class ForgetPasswordForm : Form
    {
        private string randomCode;
        public static string to;


        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_getcode_Click(object sender, EventArgs e)
        {
            if (textbox_email.Text == "")
                MessageBox.Show("Email không được  để trống!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!ValidateData.IsValidEmail(textbox_email.Text))
                MessageBox.Show("Email không đúng định dạng!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string from, password;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage mail = new MailMessage();
                from = "caodangtinh04022003@gmail.com";
                password = "awatwdomibtfoztr";

                mail.From = new MailAddress(from);
                mail.To.Add(textbox_email.Text);
                Console.WriteLine(textbox_email.Text);
                mail.Subject = "Đoàn Gia Resort - Mã xác nhận thay đổi mật khẩu!";
                mail.Body = "Mã xác nhận của bạn là : " + randomCode;

                using (SmtpClient client = new SmtpClient())
                {
                    try
                    {
                        Account account = AccountDAO.getByEmail(textbox_email.Text);
                        if (account == null)
                            MessageBox.Show("Không tìm thấy email đã đăng kí, vui lòng kiểm tra lại!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            client.EnableSsl = true;
                            client.UseDefaultCredentials = false;
                            client.Credentials = new NetworkCredential(from, password);
                            client.Host = "smtp.gmail.com";
                            client.Port = 587;
                            client.DeliveryMethod = SmtpDeliveryMethod.Network;
                            client.Send(mail);
                            MessageBox.Show("Mã xác nhận đã được gửi đến email của bạn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textbox_code.Enabled = true;
                            textbox_password.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            if (textbox_email.Text == "" || textbox_code.Text == "" || textbox_password.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!ValidateData.IsValidEmail(textbox_email.Text))
                MessageBox.Show("Email không đúng định dạng!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textbox_password.Text.Length < 6)
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textbox_code.Text != randomCode)
                MessageBox.Show("Mã xác nhận không đúng!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (textbox_password.Text.Trim().Contains(" "))
                    MessageBox.Show("Mật khẩu không bao gồm khoảng trắng!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Account account = AccountDAO.getByEmail(textbox_email.Text);
                    if (account == null)
                        MessageBox.Show("Không tìm thấy email đã đăng kí, vui lòng kiểm tra lại!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (randomCode != textbox_code.Text.Trim())
                            MessageBox.Show("Mã xác nhận không chính xác!", "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            string newPassword = textbox_password.Text.Trim();
                            string hashPassword = PasswordUils.HashingPassword(newPassword);
                            string email = textbox_email.Text.Trim();

                            if (AccountDAO.changePasswordByEmail(email, hashPassword))
                            {
                                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Có lỗi xảy ra!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
