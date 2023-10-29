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
            lb_RoomId.Text = roomInfo.Id;
            switch (roomInfo.State)
            {
                case "avaiable":
                    panel_RoomWrap.BackColor = Color.FromArgb(112, 214, 146);
                    break;
                case "unavaiable":
                    panel_RoomWrap.BackColor = Color.FromArgb(125, 125, 125);
                    break;
            }
        }
    }
}
