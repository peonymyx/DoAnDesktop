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
    public partial class FrmTKSoLgSVNganh : Form
    {
        private DBTKSlSV_Nganh businessLogic;
        public FrmTKSoLgSVNganh()
        {
            InitializeComponent();
            businessLogic = new DBTKSlSV_Nganh();
        }

        private void FrmTKSoLgSVNganh_Load(object sender, EventArgs e)
        {
            DisplayChart();
        }

        private void DisplayChart()
        {
            // Gọi phương thức từ BusinessLogic để lấy dữ liệu và hiển thị trên biểu đồ
            DataTable data = businessLogic.GetChartDataSLSV_Nganh();

            // Xác định loại biểu đồ và các cột dữ liệu
            chartTkNganh.Series.Clear();
            chartTkNganh.ChartAreas[0].AxisX.Title = "TenNganh";
            chartTkNganh.ChartAreas[0].AxisY.Title = "TotalStudents";
            chartTkNganh.ChartAreas[0].AxisX.Interval = 1;

            // Thêm dữ liệu vào biểu đồ
            foreach (DataRow row in data.Rows)
            {
                string nganh = row["TenNganh"].ToString();
                int soLuongSV = Convert.ToInt32(row["TotalStudents"]);

                // Thêm dữ liệu vào Series của biểu đồ
                chartTkNganh.Series.Add(nganh);
                chartTkNganh.Series[nganh].Points.AddY(soLuongSV);
            }

            // Thiết lập loại biểu đồ
            chartTkNganh.Series[0].ChartType = SeriesChartType.Column;

            // Ẩn các label trên trục X
            chartTkNganh.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
