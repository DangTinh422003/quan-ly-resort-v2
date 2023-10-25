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
            btn_Booking.ForeColor = Color.FromArgb(255, 0, 0);
            username_label.Text = LoginForm.accountLogined.Username;
            UserControl_Booking userControl = new UserControl_Booking();
            addUserControll(userControl);
        }

        private void changeColorStyle(GunaAdvenceButton btn)
        {
            foreach (Control item in sidebar.Controls)
            {
                Console.WriteLine("\n");
                if (item.GetType() == typeof(GunaAdvenceButton))
                {
                    if (item.Name == btn.Name)
                    {
                        item.ForeColor = Color.FromArgb(255, 0, 0);
                    }
                    else
                    {
                        item.ForeColor = Color.FromArgb(0, 0, 0);
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

        private void btn_Booking_Click(object sender, EventArgs e)
        {
            UserControl_Booking userControl = new UserControl_Booking();
            addUserControll(userControl);
            changeColorStyle(btn_Booking);
        }

        private void btn_Manager_Click(object sender, EventArgs e)
        {
            UserControl_Manager userControl = new UserControl_Manager();
            addUserControll(userControl);
            changeColorStyle(btn_Manager);

        }

        private void btn_Accountant_Click(object sender, EventArgs e)
        {
            UserControl_Accountant userControl = new UserControl_Accountant();
            addUserControll(userControl);
            changeColorStyle(btn_Accountant);
        }

        private void btn_Room_Click(object sender, EventArgs e)
        {
            UserControl_Room userControl = new UserControl_Room();
            addUserControll(userControl);
            changeColorStyle(btn_Room);
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            UserControl_Customer userControl = new UserControl_Customer();
            addUserControll(userControl);
            changeColorStyle(btn_Customer);
        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }
    }
}
