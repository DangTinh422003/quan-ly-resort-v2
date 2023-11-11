using Guna.UI.WinForms;
using quan_ly_resort_v2.resources;
using quan_ly_resort_v2.userControl;
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
    public partial class MainForm : Form
    {
        private DebounceHandler debounceHandler = new DebounceHandler(100);

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            activeBtn(btn_manageCustomer);
            addUserControll(new UscManageCustomer());
            currentUser.Text = LoginForm.accountLogined.Username;
            if (LoginForm.accountLogined.Role == "admin")
                btn_manageAccount.Enabled = true;
            else
                btn_manageAccount.Enabled = false;
        }

        private void mainForm_Load(object sender, EventArgs e) { }

        private void activeBtn(GunaAdvenceButton btn)
        {
            foreach (Control item in sidebar.Controls)
            {
                if (item.GetType() == typeof(GunaAdvenceButton))
                {
                    if (item.Name == btn.Name)
                    {
                        btn.BackColor = Color.FromArgb(100, 88, 255);
                        btn.ForeColor = Color.White;
                    }
                    else
                    {
                        item.BackColor = Color.White;
                        item.ForeColor = Color.FromArgb(12, 140, 233);
                    }
                }
            }
        }

        private void addUserControll(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_manageCustomer_Click(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                activeBtn(btn_manageCustomer);
                addUserControll(new UscManageCustomer());
            });
        }

        private void btn_manageAccountant_Click(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                activeBtn(btn_manageAccountant);
                addUserControll(new UscManageAccountant());
            });
        }

        private void btn_manageStatistic_Click(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                activeBtn(btn_manageStatistic);
                addUserControll(new UscManageStatistic());
            });
        }

        private void btn_manageService_Click(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                activeBtn(btn_manageService);
                addUserControll(new UscManageServices());
            });
        }

        private void btn_manageBill_Click(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                activeBtn(btn_manageBill);
                addUserControll(new UscManageBill());
            });
        }

        private void btn_manageRoom_Click(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                activeBtn(btn_manageRoom);
                addUserControll(new UscManageRoom());
            });
        }

        private void currentUser_Click(object sender, EventArgs e)
        {
            DialogResult dagResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dagResult == DialogResult.Yes)
            {
                var loginForm = new LoginForm();
                Program.myAppCxt.MainForm = loginForm;
                loginForm.Show();
                this.Close();
            }
        }

        private void btn_bookingRoom_Click(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                activeBtn(btn_bookingRoom);
                addUserControll(new UscManageBookingRoom());
            });
        }

        private void btn_manageAccount_Click(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                activeBtn(btn_manageAccount);
                addUserControll(new UscManageAccount());
            });
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                activeBtn(btnVoucher);
                addUserControll(new UscManageVoucher());
            });
        }
    }
}
