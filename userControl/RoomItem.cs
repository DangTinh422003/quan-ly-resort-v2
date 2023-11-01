using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using quan_ly_resort_v2.DAO;
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
        public RoomItem()
        {
            InitializeComponent();
        }

        public void SetRoomInfo(Room roomInfo)
        {
            // set room id
            lb_RoomId.Text = roomInfo.Id;

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
                    lb_timeToStart.Text = "";
                    lb_TimeToEnd.Text = "";
                    lb_CountTimeStay.Text = "";
                    break;
                case "reserved":
                    lb_roomState.Text = "Phòng đã đặt";
                    break;
                case "occupied":
                    lb_roomState.Text = "Đã cho thuê";
                    break;
            }
        }

        private void panel_RoomWrap_Click(object sender, EventArgs e)
        {
            DetailRoomInfo detailRoomInfo = new DetailRoomInfo();
            detailRoomInfo.setRoomID(lb_RoomId.Text);
            detailRoomInfo.ShowDialog();
        }
    }
}
