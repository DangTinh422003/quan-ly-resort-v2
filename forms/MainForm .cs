using Guna.UI.WinForms;
using quan_ly_resort_v2.userControl;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            username_label.Text = LoginForm.accountLogined.Username;
            UserControl_Booking userControl = new UserControl_Booking();
            addUserControll(userControl);
        }

        private void addUserControll(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_Booking_Click(object sender, EventArgs e)
        {
            UserControl_Booking userControl = new UserControl_Booking();
            addUserControll(userControl);
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            UserControl_Customer userControl = new UserControl_Customer();
            addUserControll(userControl);
        }

        private void btn_Manager_Click(object sender, EventArgs e)
        {
            UserControl_Manager userControl = new UserControl_Manager();
            addUserControll(userControl);
        }

        private void btn_Accountant_Click(object sender, EventArgs e)
        {
            UserControl_Accountant userControl = new UserControl_Accountant();
            addUserControll(userControl);
        }

        private void btn_Room_Click(object sender, EventArgs e)
        {
            UserControl_Room userControl = new UserControl_Room();
            addUserControll(userControl);
        }
    }
}
