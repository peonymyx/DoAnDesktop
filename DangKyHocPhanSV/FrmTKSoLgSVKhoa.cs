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
    public partial class FrmTKSoLgSVKhoa : Form
    {
        private DBTKSlSV_Khoa businessLogic;
        public FrmTKSoLgSVKhoa()
        {
            InitializeComponent();
            businessLogic = new DBTKSlSV_Khoa();
        }

        private void FrmTKSoLgSVKhoa_Load(object sender, EventArgs e)
        {
            DisplayChart();
        }

        private void DisplayChart()
        {
            // Gọi phương thức từ BusinessLogic để lấy dữ liệu và hiển thị trên biểu đồ
            DataTable data = businessLogic.GetChartDataSLSV_Khoa();

            // Xác định loại biểu đồ và các cột dữ liệu
            chartTkKhoa.Series.Clear();
            chartTkKhoa.ChartAreas[0].AxisX.Title = "TenKhoa";
            chartTkKhoa.ChartAreas[0].AxisY.Title = "TotalStudents";
            chartTkKhoa.ChartAreas[0].AxisX.Interval = 1;

            // Thêm dữ liệu vào biểu đồ
            foreach (DataRow row in data.Rows)
            {
                string khoa = row["TenKhoa"].ToString();
                int soLuongSV = Convert.ToInt32(row["TotalStudents"]);

                // Thêm dữ liệu vào Series của biểu đồ
                chartTkKhoa.Series.Add(khoa);
                chartTkKhoa.Series[khoa].Points.AddY(soLuongSV);
            }

            // Thiết lập loại biểu đồ
            chartTkKhoa.Series[0].ChartType = SeriesChartType.Column;

            // Ẩn các label trên trục X
            chartTkKhoa.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
