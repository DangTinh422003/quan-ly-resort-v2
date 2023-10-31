using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using quan_ly_resort_v2.forms;
using quan_ly_resort_v2.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quan_ly_resort_v2.userControl
{
    public partial class RoomItem : UserControl
    {

        private string currentRoomId;

        public RoomItem()
        {
            InitializeComponent();
        }

        public void SetRoomInfo(Room roomInfo)
        {
            // set room id
            currentRoomId = roomInfo.Id;
            string roomId = roomInfo.Id;
            lb_RoomId.Text = roomId;

            // room state
            if (roomInfo.IsFixed)
                lb_isCleanup.Text = "Đang sửa chữa";
            else
            {
                if (roomInfo.IsClean)
                    lb_isCleanup.Text = "Chưa dọn dẹp";
                else
                    lb_isCleanup.Text = "Đã dọn dẹp";
            }

            switch (roomInfo.State.ToLower())
            {
                case "avaiable":
                    lb_CustomerName.Text = "Phòng Trống";
                    lb_roomState.Text = "Phòng Trống";
                    panel_RoomWrap.BackColor = Color.FromArgb(30, 225, 114);
                    lb_timeToStart.Text = "";
                    lb_TimeToEnd.Text = "";
                    lb_CountTimeStay.Text = "";
                    break;
                case "reserved":
                    lb_roomState.Text = "Phòng đã đặt";
                    lb_CustomerName.Text = "Nguyen Van A";
                    panel_RoomWrap.BackColor = Color.FromArgb(53, 193, 241);
                    break;
                case "occupied":
                    lb_roomState.Text = "Đã cho thuê";
                    panel_RoomWrap.BackColor = Color.FromArgb(110, 110, 110);
                    break;

            }
        }

        private void panel_RoomWrap_Click(object sender, EventArgs e)
        {
            DetailRoomInfo detailRoomInfo = new DetailRoomInfo();
            detailRoomInfo.setRoomID(currentRoomId);
            detailRoomInfo.ShowDialog();
        }

        private void panel_RoomWrap_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
