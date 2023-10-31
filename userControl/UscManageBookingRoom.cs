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

namespace quan_ly_resort_v2.userControl
{
    public partial class UscManageBookingRoom : UserControl
    {
        public UscManageBookingRoom()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            var bookingForm = new BookingForm();
            bookingForm.ShowDialog();
        }
    }
}
