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
using System.Data.SqlClient;

namespace DangKyHocPhanSV
{
    public partial class FrmGiangVien : Form
    {
        DBKhoa khoa = new DBKhoa();
        DBGiangVien gv = new DBGiangVien();
        private Form _parent;
        private Panel _panel;

        public FrmGiangVien(Form parent, Panel panel)
        {
            InitializeComponent();
            _parent = parent;
            _panel = panel;
        }

        public void loadGiangVien()
        {
            dgv_giangvien.DataSource =  gv.DSGiangVien().Tables[0];
            dgv_giangvien.Columns[0].HeaderText = "Mã giảng viên";
            dgv_giangvien.Columns[1].HeaderText = "Họ và tên giảng viên";
            dgv_giangvien.Columns[2].HeaderText = "Khoa";

            dgv_giangvien.Columns[0].Width = 50;
            dgv_giangvien.Columns[1].Width = 70;
            dgv_giangvien.Columns[2].Width = 250;
        }

        public void loadDSKhoa()
        {
            cbb_khoa.DataSource = khoa.DanhSachKhoa().Tables[0];
            cbb_khoa.DisplayMember = "TenKhoa";
            cbb_khoa.ValueMember = "MaKhoa";
        }
        private void FrmGiangVien_Load(object sender, EventArgs e)
        {
            loadGiangVien();
            loadDSKhoa();
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            _panel.Show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = gv.XoaGV(ref err, txt_magv.Text);
                if (kq)
                {
                    loadGiangVien();
                    MessageBox.Show("Đã xóa thành công!");
                }

            }
            catch (SqlException)
            {
                err = "Không thể xóa!";
                MessageBox.Show(err);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = gv.ThemGV(ref err, txt_tendangnhap.Text, txt_matkhau.Text, txt_hoten.Text, cbb_khoa.SelectedValue.ToString());
                if (kq)
                {
                    loadGiangVien();
                    MessageBox.Show("Đã thêm thành công!");
                }

            }
            catch (SqlException)
            {
                err = "Không thể thêm!";
                MessageBox.Show(err);
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            dgv_giangvien.DataSource = gv.ThongTinGV(txt_magv.Text).Tables[0];
            dgv_giangvien.Columns[0].HeaderText = "Mã giảng viên";
            dgv_giangvien.Columns[1].HeaderText = "Họ và tên giảng viên";
            dgv_giangvien.Columns[2].HeaderText = "Khoa";

            dgv_giangvien.Columns[0].Width = 50;
            dgv_giangvien.Columns[1].Width = 70;
            dgv_giangvien.Columns[2].Width = 250;
        }
    }
}
