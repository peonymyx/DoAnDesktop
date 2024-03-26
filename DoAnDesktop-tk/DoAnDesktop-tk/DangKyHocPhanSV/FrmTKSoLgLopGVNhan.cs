using BusinessLogicLayer;
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

namespace DangKyHocPhanSV
{
    public partial class FrmTKSoLgLopGVNhan : Form
    {
        private DBTKSlLopGV_Nhan businessLogic;
        public FrmTKSoLgLopGVNhan()
        {
            InitializeComponent();
            businessLogic = new DBTKSlLopGV_Nhan();
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTKSoLgLopGVNhan_Load(object sender, EventArgs e)
        {
            DisplayChart();
        }

        private void DisplayChart()
        {
            // Gọi phương thức từ BusinessLogic để lấy dữ liệu và hiển thị trên biểu đồ
            DataTable data = businessLogic.GetChartDataSLGVday_Lop();

            // Xác định loại biểu đồ và các cột dữ liệu
            chartTkGVNhan.Series.Clear();
            chartTkGVNhan.ChartAreas[0].AxisX.Title = "HoTenGV";
            chartTkGVNhan.ChartAreas[0].AxisY.Title = "TongSoLopNhanDuoc";
            chartTkGVNhan.ChartAreas[0].AxisX.Interval = 1;

            // Thêm dữ liệu vào biểu đồ
            foreach (DataRow row in data.Rows)
            {
                string hotengv = row["HoTenGV"].ToString();
                decimal tongsolop = Convert.ToDecimal(row["TongSoLopNhanDuoc"]);

                // Thêm dữ liệu vào Series của biểu đồ
                chartTkGVNhan.Series.Add(hotengv);
                chartTkGVNhan.Series[hotengv].Points.AddY(tongsolop);
            }

            // Thiết lập loại biểu đồ
            chartTkGVNhan.Series[0].ChartType = SeriesChartType.Column;

            // Ẩn các label trên trục X
            chartTkGVNhan.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
        }
    }
}
