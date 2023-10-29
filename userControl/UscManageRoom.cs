using quan_ly_resort_v2.DAO;
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
    public partial class UscManageRoom : UserControl
    {
        private int currentPageIndex = 1;
        private int roomCounter = RoomDAO.countListRoom();
        private int totalPage = (int)(RoomDAO.countListRoom() / PAGE_LIMIT) + 1;
        private const int PAGE_LIMIT = 12;

        public UscManageRoom()
        {
            InitializeComponent();
        }

        private void UscManageRoom_Load(object sender, EventArgs e)
        {
            flowLayoutPanel_ListRoom.Controls.Clear();
            List<Room> rooms = RoomDAO.GetRooms(1, PAGE_LIMIT);
            foreach (Room room in rooms)
            {
                RoomItem roomItem = new RoomItem();
                roomItem.SetRoomInfo(room);
                flowLayoutPanel_ListRoom.Controls.Add(roomItem);
            }
        }

        private void flowLayoutPanel_ListRoom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Prevpage_Click(object sender, EventArgs e)
        {
            if (currentPageIndex - 1 < 1)
                currentPageIndex = totalPage;
            else
                currentPageIndex--;
            flowLayoutPanel_ListRoom.Controls.Clear();
            List<Room> rooms = RoomDAO.GetRooms(currentPageIndex, PAGE_LIMIT);
            foreach (Room room in rooms)
            {
                RoomItem roomItem = new RoomItem();
                roomItem.SetRoomInfo(room);
                flowLayoutPanel_ListRoom.Controls.Add(roomItem);
            }
            lb_currentPage.Text = "Trang " + currentPageIndex.ToString() + "/" + totalPage;
        }

        private void btn_Nextpage_Click(object sender, EventArgs e)
        {

        }
    }
}
