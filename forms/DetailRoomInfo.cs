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

namespace quan_ly_resort_v2.forms
{
    public partial class DetailRoomInfo : Form
    {

        private string currentRoomId;
        public DetailRoomInfo()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(197, 197, 197), ButtonBorderStyle.Solid);
        }

        public void setRoomID(string roomId)
        {
            currentRoomId = roomId;
        }

        private void DetailRoomInfo_Load(object sender, EventArgs e)
        {
            lb_roomId.Text = currentRoomId;
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_getRoom_Click(object sender, EventArgs e)
        {
            string roomId = currentRoomId;
            Room room = RoomDAO.getRoomByID(roomId);

            if (room.State.ToLower() == "avaiable")
            {
                MessageBox.Show("Thêm khách hàng mới, rồi lưu phòng");
            }
            else if (room.State.ToLower() == "reserved")
            {
                MessageBox.Show("Nhận phòng,Tạo hóa đơn, query bảng đặt phòng + bảng khách hàng để thêm thong tin vào hóa đơn");
            }
            else
            {
                MessageBox.Show("Hiện nút thanh toán, tính tiền");
            }
        }

        private void gunaContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btn_saveInomation_Click(object sender, EventArgs e)
        {

        }
    }
}
