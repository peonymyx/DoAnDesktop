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
    public partial class FrmTKSoLgBTNop : Form
    {
        private DBTKSlSV_NopBai businessLogic;
        public FrmTKSoLgBTNop()
        {
            InitializeComponent();
            businessLogic = new DBTKSlSV_NopBai();
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTKSoLgBTNop_Load(object sender, EventArgs e)
        {
            DisplayChart();
        }

        private void DisplayChart()
        {
            // Gọi phương thức từ BusinessLogic để lấy dữ liệu và hiển thị trên biểu đồ
            DataTable data = businessLogic.GetChartDataSLSV_NopBai();

            // Xác định loại biểu đồ và các cột dữ liệu
            chartTkBaiNop.Series.Clear();
            chartTkBaiNop.ChartAreas[0].AxisX.Title = "HoTenSV";
            chartTkBaiNop.ChartAreas[0].AxisY.Title = "TongSoBaiTapNhanDuoc";
            chartTkBaiNop.ChartAreas[0].AxisX.Interval = 1;

            // Thêm dữ liệu vào biểu đồ
            foreach (DataRow row in data.Rows)
            {
                string hotensv = row["HoTenSV"].ToString();
                //int tongsobaitapnhanduoc = Convert.ToInt32(row["TongSoBaiTapNhanDuoc"]);
                int tongsobaitapdalam = Convert.ToInt32(row["TongSoBaiTapDaLam"]);

                // Thêm dữ liệu vào Series của biểu đồ
                chartTkBaiNop.Series.Add(hotensv);
                //chartTkBaiNop.Series[hotensv].Points.AddXY("Tổng số bài tập nhận được", tongsobaitapnhanduoc);
                chartTkBaiNop.Series[hotensv].Points.AddXY("Tổng số bài tập đã làm", tongsobaitapdalam);
            }

            // Thiết lập loại biểu đồ
            chartTkBaiNop.Series[0].ChartType = SeriesChartType.Column;

            // Ẩn các label trên trục X
            chartTkBaiNop.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
        }
    }
}
