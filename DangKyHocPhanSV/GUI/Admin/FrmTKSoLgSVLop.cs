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
    public partial class FrmTKSoLgSVLop : Form
    {
        private DBTKSlSV_Lop businessLogic;
        public FrmTKSoLgSVLop()
        {
            InitializeComponent();
            businessLogic = new DBTKSlSV_Lop();
        }

        private void FrmTKSoLgSVLop_Load(object sender, EventArgs e)
        {
            DisplayChart();
        }

        private void DisplayChart()
        {
            // Gọi phương thức từ BusinessLogic để lấy dữ liệu và hiển thị trên biểu đồ
            DataTable data = businessLogic.GetChartDataSLSV_Lop();

            // Xác định loại biểu đồ và các cột dữ liệu
            chartTkLop.Series.Clear();
            chartTkLop.ChartAreas[0].AxisX.Title = "MaLopHoc";
            chartTkLop.ChartAreas[0].AxisY.Title = "SoLuong";
            chartTkLop.ChartAreas[0].AxisX.Interval = 1;

            // Thêm dữ liệu vào biểu đồ
            foreach (DataRow row in data.Rows)
            {
                string malophoc = row["MaLopHoc"].ToString();
                int soluong = Convert.ToInt32(row["SoLuong"]);

                // Thêm dữ liệu vào Series của biểu đồ
                chartTkLop.Series.Add(malophoc);
                chartTkLop.Series[malophoc].Points.AddY(soluong);
            }

            // Thiết lập loại biểu đồ
            chartTkLop.Series[0].ChartType = SeriesChartType.Column;

            // Ẩn các label trên trục X
            chartTkLop.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
