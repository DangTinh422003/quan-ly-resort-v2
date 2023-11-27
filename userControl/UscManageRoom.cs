using Guna.UI2.WinForms;
using quan_ly_resort_v2.DAO;
using quan_ly_resort_v2.model;
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

namespace quan_ly_resort_v2.userControl
{
    public partial class UscManageRoom : UserControl
    {
        private DebounceHandler debounceHandler = new DebounceHandler(100);

        private int currentPageIndex = 1;
        private int roomCounter = RoomDAO.countListRoom();
        private int totalPage = (int)(RoomDAO.countListRoom() / PAGE_LIMIT) + 1;
        private const int PAGE_LIMIT = 12;

        public UscManageRoom()
        {
            InitializeComponent();
            renderListRoom();
        }

        private void renderListRoom()
        {
            lb_currentPage.Text = "Trang 1/" + totalPage;
            flowLayoutPanel_ListRoom.Controls.Clear();
            List<Room> rooms = RoomDAO.GetRoomsLimit(1, PAGE_LIMIT);
            foreach (Room room in rooms)
            {
                RoomItem roomItem = new RoomItem();
                roomItem.SetRoomInfo(room);
                flowLayoutPanel_ListRoom.Controls.Add(roomItem);
            }
        }

        private void btn_Prevpage_Click(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                if (currentPageIndex - 1 < 1)
                    currentPageIndex = totalPage;
                else
                    currentPageIndex--;
                flowLayoutPanel_ListRoom.Controls.Clear();
                List<Room> rooms = RoomDAO.GetRoomsLimit(currentPageIndex, PAGE_LIMIT);
                foreach (Room room in rooms)
                {
                    RoomItem roomItem = new RoomItem();
                    roomItem.SetRoomInfo(room);
                    flowLayoutPanel_ListRoom.Controls.Add(roomItem);
                }
                lb_currentPage.Text = "Trang " + currentPageIndex.ToString() + "/" + totalPage;
            });
        }

        private void btn_Nextpage_Click(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                if (currentPageIndex + 1 > totalPage)
                    currentPageIndex = 1;
                else
                    currentPageIndex++;
                flowLayoutPanel_ListRoom.Controls.Clear();
                List<Room> rooms = RoomDAO.GetRoomsLimit(currentPageIndex, PAGE_LIMIT);
                foreach (Room room in rooms)
                {
                    RoomItem roomItem = new RoomItem();
                    roomItem.SetRoomInfo(room);
                    flowLayoutPanel_ListRoom.Controls.Add(roomItem);
                }
                lb_currentPage.Text = "Trang " + currentPageIndex.ToString() + "/" + totalPage;
            });
        }

        private void textbox_searchRoom_TextChanged(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                if (textbox_searchRoom.Text.Trim() != "")
                {
                    List<Room> rooms = RoomDAO.getRoomsByID(textbox_searchRoom.Text.Trim());
                    flowLayoutPanel_ListRoom.Controls.Clear();
                    foreach (Room room in rooms)
                    {
                        RoomItem roomItem = new RoomItem();
                        roomItem.SetRoomInfo(room);
                        flowLayoutPanel_ListRoom.Controls.Add(roomItem);
                    }
                }
                else
                {
                    renderListRoom();
                }
            });
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            renderListRoom();
        }

        private string getStringValueFilter()
        {
            string roomState = "Tất cả";
            string roomType = "Tất cả";
            string bedType = "Tất cả";

            foreach (Control item in panel_stateFilter.Controls)
            {
                if (item.GetType() == typeof(Guna2RadioButton))
                    if (((Guna2RadioButton)item).Checked)
                        roomState = ((Guna2RadioButton)item).Text;
            }

            foreach (Control item in panel_typeRoomFilter.Controls)
            {
                if (item.GetType() == typeof(Guna2RadioButton))
                    if (((Guna2RadioButton)item).Checked)
                        roomType = ((Guna2RadioButton)item).Text;
            }

            foreach (Control item in panel_typeBedFilter.Controls)
            {
                if (item.GetType() == typeof(Guna2RadioButton))
                    if (((Guna2RadioButton)item).Checked)
                        bedType = ((Guna2RadioButton)item).Text;
            }

            return roomState + "," + roomType + "," + bedType;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            string valueFilterString = getStringValueFilter();
            MessageBox.Show(valueFilterString.ToString());
        }
    }
}
