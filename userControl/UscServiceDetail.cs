using Guna.UI.WinForms;
using quan_ly_resort_v2.DAO;
using quan_ly_resort_v2.model;
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

namespace quan_ly_resort_v2.userControl
{
    public partial class UscServiceDetail : UserControl
    {
        public string MaDVValue { get; set; }

        public event EventHandler BackButtonClicked;
        public UscServiceDetail()
        {
            InitializeComponent();
        }

        private void UscServiceDetail_Load(object sender, EventArgs e)
        {
            string maDV = MaDVValue;

            Service service = ServiceDAO.GetServiceByMaDV(maDV);

            if (service != null)
            {
                txtLoai.Text = service.LoaiDV;
                txtName.Text = service.TenDV;
                txtDetail.Text = service.ChiTietDichVu;
                txtPrice.Text = service.Gia.ToString();
                
            }
        }

        private void txtBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
