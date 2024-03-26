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
    public partial class FrmTKSoLgTCSVDK : Form
    {
        private DBTKDK_TinChi businessLogic;
        public FrmTKSoLgTCSVDK()
        {
            InitializeComponent();
            businessLogic = new DBTKDK_TinChi();
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTKSoLgTCSVDK_Load(object sender, EventArgs e)
        {
            DisplayChart();
        }

        private void DisplayChart()
        {
            // Gọi phương thức từ BusinessLogic để lấy dữ liệu và hiển thị trên biểu đồ
            DataTable data = businessLogic.GetChartDataSLTC_DangKy();

            // Xác định loại biểu đồ và các cột dữ liệu
            chartTkTinChi.Series.Clear();
            chartTkTinChi.ChartAreas[0].AxisX.Title = "TenSV";
            chartTkTinChi.ChartAreas[0].AxisY.Title = "TongSoChi";
            chartTkTinChi.ChartAreas[0].AxisX.Interval = 1;

            // Thêm dữ liệu vào biểu đồ
            foreach (DataRow row in data.Rows)
            {
                string tensv = row["TenSV"].ToString();
                decimal tongSoChi = Convert.ToDecimal(row["TongSoChi"]);

                // Thêm dữ liệu vào Series của biểu đồ
                chartTkTinChi.Series.Add(tensv);
                chartTkTinChi.Series[tensv].Points.AddY(tongSoChi);
            }

            // Thiết lập loại biểu đồ
            chartTkTinChi.Series[0].ChartType = SeriesChartType.Column;

            // Ẩn các label trên trục X
            chartTkTinChi.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
        }
    }
}
