using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BusinessLogicLayer;
using System.Data.SqlClient;

namespace DangKyHocPhanSV
{
    public partial class FrmTraCuuMonHoc : Form
    {
        private Form _parent;
        private Panel _panel;
        DBLopHoc lh = new DBLopHoc();
        public FrmTraCuuMonHoc(Form parent, Panel panel)
        {
            InitializeComponent();
            lh.SinhVienConnect();
            _parent = parent;
            _panel = panel;
        }

        public void loadDSLopHoc()
        {
            this.dgv_monhoc.DataSource = lh.TimKiemLopHocTheoMH(txt_timkiem.Text).Tables[0];
            dgv_monhoc.Columns[0].HeaderText = "Mã Môn Học";
            dgv_monhoc.Columns[1].HeaderText = "Mã Lớp Học";
            dgv_monhoc.Columns[2].HeaderText = "Tên Giảng Viên";
            dgv_monhoc.Columns[3].HeaderText = "Giới Hạn";
            dgv_monhoc.Columns[4].HeaderText = "Tên Phòng";
            dgv_monhoc.Columns[5].HeaderText = "Thứ";
            dgv_monhoc.Columns[6].HeaderText = "Tiết Bắt Đầu";
            dgv_monhoc.Columns[7].HeaderText = "Tiết Kết Thúc";
            dgv_monhoc.Columns[8].HeaderText = "Thời Gian Bắt Đầu";
            dgv_monhoc.Columns[9].HeaderText = "Thời gian Kết Thúc";
        }

        private void FrmTraCuuMonHoc_Load(object sender, EventArgs e)
        {
            loadDSLopHoc();
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            _panel.Show();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            this.dgv_monhoc.DataSource = lh.TimKiemLopHocTheoMH(txt_timkiem.Text).Tables[0];
            dgv_monhoc.Columns[0].HeaderText = "Mã Môn Học";
            dgv_monhoc.Columns[1].HeaderText = "Mã Lớp Học";
            dgv_monhoc.Columns[2].HeaderText = "Tên Giảng Viên";
            dgv_monhoc.Columns[3].HeaderText = "Giới Hạn";
            dgv_monhoc.Columns[4].HeaderText = "Tên Phòng";
            dgv_monhoc.Columns[5].HeaderText = "Thứ";
            dgv_monhoc.Columns[6].HeaderText = "Tiết Bắt Đầu";
            dgv_monhoc.Columns[7].HeaderText = "Tiết Kết Thúc";
            dgv_monhoc.Columns[8].HeaderText = "Thời Gian Bắt Đầu";
            dgv_monhoc.Columns[9].HeaderText = "Thời gian Kết Thúc";
        }
    }
}
