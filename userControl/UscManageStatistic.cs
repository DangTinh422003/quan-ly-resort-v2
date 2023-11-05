using quan_ly_resort_v2.DAO;
using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace quan_ly_resort_v2.userControl
{
    public partial class UscManageStatistic : UserControl
    {
        public UscManageStatistic()
        {
            InitializeComponent();

            TextBox.Enabled = false;
            TextBox1.Enabled = false;
            // Xác định tháng hiện tại
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;


            // Thiết lập ccbSelectMonth để chọn tháng hiện tại
            ccbSelectMonth.SelectedItem = "Tháng " + currentMonth;
            cbbYears.SelectedItem = "Năm " + currentYear;

            labelTotalRevenue.Text = string.Empty;

            // Gọi phương thức để hiển thị dữ liệu của tháng hiện tại
            LoadDataForSelectedOption();
        }

        private void LoadDataForSelectedOption()
        {
            string selectedOption = ccbSelectMonth.SelectedItem.ToString();
            string selectedYear = cbbYears.SelectedItem.ToString().Substring(4);

            // Đặt tên trục Y cho biểu đồ
            chartStatistic.ChartAreas[0].AxisY.Title = "Tổng thu";
            chartStatistic.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartStatistic.ChartAreas[0].AxisY.LabelStyle.Format = "N0";// "C0" định dạng giá trị tiền tệ với 0 chữ số sau dấu thập phân


            // Đặt tên trục X cho biểu đồ
            if (selectedOption.StartsWith("Tháng"))
            {
                chartStatistic.ChartAreas[0].AxisX.Title = "Tuần";
                chartStatistic.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);

                int month = int.Parse(selectedOption.Split(' ')[1]);
                DataTable filteredData = BillDAO.FilterByFieldStatistic("Tháng " + month, selectedYear);

                if (filteredData != null)
                {
                    chartStatistic.Series[0].Points.Clear();

                    Dictionary<int, double> weeklyRevenues = new Dictionary<int, double>();
                    double weeklyRevenue = 0;
                    int currentWeek = 1;
                    DateTime weekStartDate = DateTime.MinValue;

                    for (int day = 1; day <= DateTime.DaysInMonth(int.Parse(selectedYear), month); day++)
                    {
                        DateTime date = new DateTime(int.Parse(selectedYear), month, day);

                        double revenue = GetDailyRevenue(filteredData, date);
                        weeklyRevenue += revenue;

                        // Nếu đã qua 7 ngày hoặc đã qua ngày cuối cùng của tháng, thêm tổng thu của tuần vào biểu đồ và chuyển sang tuần tiếp theo
                        if (day % 7 == 0 || day == DateTime.DaysInMonth(int.Parse(selectedYear), month))
                        {
                            DateTime weekEndDate = date; // Ngày hiện tại là ngày kết thúc tuần

                            chartStatistic.Series[0].Points.AddXY($"Tuần {currentWeek}\n({weekStartDate:dd/MM} - {weekEndDate:dd/MM})", weeklyRevenue);
                            weeklyRevenue = 0;
                            currentWeek++;
                            weekStartDate = date.AddDays(1); // Bắt đầu một tuần mới sau tuần hiện tại
                        }
                    }
                }

            }
            else if (selectedOption.StartsWith("Quý"))
            {
                chartStatistic.ChartAreas[0].AxisX.Title = "Theo tháng";
                chartStatistic.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);

                // Lọc dữ liệu cho quý đã chọn
                int quarter = int.Parse(selectedOption.Split(' ')[1]);
                DataTable filteredData = BillDAO.FilterByFieldStatistic("Quý " + quarter, selectedYear);

                if (filteredData != null)
                {
                    chartStatistic.Series[0].Points.Clear();
                    Dictionary<int, double> monthlyRevenues = new Dictionary<int, double>();

                    // Khởi tạo dữ liệu tháng trong quý
                    for (int i = (quarter - 1) * 3 + 1; i <= quarter * 3; i++)
                    {
                        monthlyRevenues[i] = 0;
                    }

                    foreach (DataRow row in filteredData.Rows)
                    {
                        DateTime date = Convert.ToDateTime(row["NgayTao"]);
                        int month = date.Month;
                        double revenue = Convert.ToDouble(row["TongTien"]);
                        monthlyRevenues[month] += revenue;
                    }

                    foreach (var pair in monthlyRevenues)
                    {
                        // Thêm cột vào biểu đồ
                        chartStatistic.Series[0].Points.AddXY("Tháng " + pair.Key, pair.Value);
                    }
                }
            }
        }


        private double GetDailyRevenue(DataTable data, DateTime date)
        {
            double revenue = 0;

            foreach (DataRow row in data.Rows)
            {
                DateTime rowDate = Convert.ToDateTime(row["NgayTao"]);
                if (rowDate.Date == date.Date)
                {
                    revenue += Convert.ToDouble(row["TongTien"]);
                }
            }

            return revenue;
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadDataForSelectedOption();
        }

        private void chartStatistic_MouseMove(object sender, MouseEventArgs e)
        {
            Chart chart = (Chart)sender;

            // Lấy tọa độ chuột trong hệ toạ độ của biểu đồ
            Point mousePoint = e.Location;

            // Xác định vị trí con trỏ chuột trên biểu đồ
            HitTestResult result = chart.HitTest(mousePoint.X, mousePoint.Y);

            if (result.PointIndex >= 0 && result.Series != null)
            {
                int pointIndex = result.PointIndex;
                double revenue = chart.Series[0].Points[pointIndex].YValues[0];

                // Hiển thị thông tin tổng tiền trong một Label hoặc TextBox
                labelTotalRevenue.Text = "Tổng tiền: " + revenue.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));// Định dạng tiền tệ
            }
            else
            {
                // Nếu không nằm trên cột nào, ẩn thông tin tổng tiền
                labelTotalRevenue.Text = string.Empty;
            }
        }

    }
}
