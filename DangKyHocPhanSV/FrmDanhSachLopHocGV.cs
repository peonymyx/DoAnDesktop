using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace DangKyHocPhanSV
{
    public partial class FrmDanhSachLopHocGV : Form
    {
        private string maso;
        DBLopHoc lh = new DBLopHoc();
        DBGiangVien gv = new DBGiangVien();
        private Form _parent;
        private Panel _panel;
        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmDanhSachLopHocGV(Form parent, Panel panel)
        {
            InitializeComponent();
            lh.GiangVienConnect();
            gv.GiangVienConnect();
            _parent = parent;
            _panel = panel;
        }

        public void loadChiTiet()
        {
            dgv_lophoc.DataSource = lh.ChiTietLopHocGV(maso).Tables[0];
            dgv_lophoc.Columns[0].HeaderText = "Mã Lớp Học";
            dgv_lophoc.Columns[1].HeaderText = "Tên Môn Học";
            dgv_lophoc.Columns[2].HeaderText = "Tên Phòng";
            dgv_lophoc.Columns[3].HeaderText = "Thứ";
            dgv_lophoc.Columns[4].HeaderText = "Tiết Bắt Đầu";
            dgv_lophoc.Columns[5].HeaderText = "Tiết Kết Thúc";
            dgv_lophoc.Columns[6].HeaderText = "Số Lượng Sinh Viên";

            dgv_lophoc.Columns[1].Width = 150;
            dgv_lophoc.Columns[6].Width = 150;

        }

        private void FrmDanhSachLopHocGV_Load(object sender, EventArgs e)
        {
            loadChiTiet();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            txt_tongsinhvien.Text = lh.TongSVLopHoc(txt_timkiem.Text).ToString();

            dgv_lophoc.DataSource = lh.DanhSachSVLH(txt_timkiem.Text).Tables[0];
            dgv_lophoc.Columns[0].HeaderText = "Mã Sinh Viên";
            dgv_lophoc.Columns[1].HeaderText = "Họ và tên Sinh Viên";
            dgv_lophoc.Columns[2].HeaderText = "Giới Tính";
            dgv_lophoc.Columns[3].HeaderText = "Ngày Sinh";
            dgv_lophoc.Columns[4].HeaderText = "Mã Lớp";

            dgv_lophoc.Columns[1].Width = 150;
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            _panel.Show();

        }
    }
}
