using quan_ly_resort_v2.DAO;
using quan_ly_resort_v2.model;
using quan_ly_resort_v2.utils;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing.Printing;
using System.Globalization;

namespace quan_ly_resort_v2.forms
{
    public partial class BillDetailForm : Form
    {
        private string selectedBillId;

        public BillDetailForm(string selectedBillId)
        {
            InitializeComponent();
            this.selectedBillId = selectedBillId;
            ShowBillDetails();
        }

        private void ShowBillDetails()
        {
            // Gọi DAO để lấy thông tin chi tiết hóa đơn dựa trên selectedBillId
            BillDetails billDetails = BillDetailDAO.GetBillDetailsByMaHD(selectedBillId);

            if (billDetails != null)
            {
                txtMaHD.Text = billDetails.MaHoaDon;
                txtKH.Text = billDetails.TenKhachHang;
                txtNV.Text = billDetails.TenNhanVien;

                // Display room information
                List<string> phongWithGia = new List<string>();
                string[] maPhongArray = billDetails.DanhSachMaPhong.Split(',');

                for (int i = 0; i < maPhongArray.Length; i++)
                {
                    string maPhong = maPhongArray[i].Trim();
                    double giaPhong = 0.0;

                    if (billDetails.GiaPhong.Count > i)
                    {
                        giaPhong = billDetails.GiaPhong[i];
                    }
                    else
                    {
                        // Add debugging information
                        Console.WriteLine($"No price found for room: {maPhong}");
                    }

                    phongWithGia.Add($"{maPhong} - {giaPhong.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"))} VNĐ");
                }

                string phongText = string.Join("\n", phongWithGia);
                txtThanhtoan.Text = phongText;

                // Display additional service information
                List<string> dichVuWithGia = new List<string>();
                for (int i = 0; i < billDetails.DanhSachMaDichVu.Count; i++)
                {
                    string tenDichVu = billDetails.TenDichVu[i].Trim();
                    int soLuong = billDetails.SoLuongDichVu[i];
                    double giaDichVu = billDetails.GiaDichVu.Count > i ? billDetails.GiaDichVu[i] : 0.0;

                    dichVuWithGia.Add($"{tenDichVu} x{soLuong} - {giaDichVu.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"))} VNĐ");
                }

                string dichVuText = string.Join("\n", dichVuWithGia);
                txtDichvu.Text = dichVuText;

                // Display other information
                txtCheckIn.Text = billDetails.NgayCheckIn.ToString("dd/MM/yyyy");
                txtNgayO.Text = billDetails.SoNgayThue.ToString() + " ngày";
                txtPay.Text = billDetails.State;
                txtTien.Text = billDetails.TongTien.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
            }
            else
            {
                // Xử lý khi không tìm thấy hóa đơn
                MessageBox.Show("Không tìm thấy hóa đơn với Mã hóa đơn " + selectedBillId);
                this.Close();
            }
        }





        private void btn_ExportPDF_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save as PDF";
            saveFileDialog.FileName = "BillDetail.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = "Bill Detail";

                    PdfPage pdfPage = pdf.AddPage();
                    XGraphics graph = XGraphics.FromPdfPage(pdfPage);

                    // Lấy nội dung của PanelHD và đưa nó vào tài liệu PDF
                    using (MemoryStream ms = new MemoryStream())
                    {
                        // Lấy nội dung của PanelHD
                        Bitmap bmp = new Bitmap(PanelHD.Width, PanelHD.Height);
                        PanelHD.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, PanelHD.Width, PanelHD.Height));

                        // Chuyển đổi hình ảnh từ System.Drawing.Image sang dạng byte[]
                        byte[] imageBytes;
                        using (MemoryStream imageStream = new MemoryStream())
                        {
                            bmp.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);
                            imageBytes = imageStream.ToArray();
                        }

                        XImage panelImage = XImage.FromStream(new MemoryStream(imageBytes));

                        // Tính toán vị trí canh giữa trên trang PDF không quan tâm đến rotation
                        double x = (pdfPage.Width - panelImage.PixelWidth) / 2;
                        double y = (pdfPage.Height - panelImage.PixelHeight) / 2;

                        // Vẽ hình ảnh vào tài liệu PDF với vị trí canh giữa
                        graph.DrawImage(panelImage, x, y);
                    }

                    pdf.Save(filePath);

                    // Thông báo khi hoàn thành xuất PDF
                    MessageBox.Show("Xuất PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi khi xuất PDF
                    MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            // Thiết lập PrintDocument để vẽ nội dung từ PanelHD
            printDocument.PrintPage += (s, args) =>
            {
                Bitmap bmp = new Bitmap(PanelHD.Width, PanelHD.Height);
                PanelHD.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, PanelHD.Width, PanelHD.Height));
                args.Graphics.DrawImage(bmp, 0, 0);
            };

            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BillDetailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
