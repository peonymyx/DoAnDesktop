using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLogicLayer;

namespace DangKyHocPhanSV
{
    public partial class FrmLopSV : Form
    {
        MenuStrip menuStrip;
        DBLop lop = new DBLop();
        DBSinhVien sv = new DBSinhVien();
        DBChuongTrinhDT ctdt = new DBChuongTrinhDT();
        public FrmLopSV(MenuStrip menuStrip)
        {
            InitializeComponent();
            this.menuStrip = menuStrip;
        }

        public void LoadComboBoxCTDT()
        {
            /*this.cbbCTDT.DataSource = ctdt.DanhSachCTDT().Tables[0];
            this.cbbCTDT.DisplayMember = "MaCTDT";
            this.cbbCTDT.ValueMember = "MaCTDT";*/
        }
        public void LoadLop()
        {
            /*this.dgvLop.DataSource = lop.DSLop().Tables[0];

            dgvLop.Columns[0].HeaderText = "Mã Lớp";
            dgvLop.Columns[1].HeaderText = "Tên lớp";
            dgvLop.Columns[2].HeaderText = "Tên Ngành";
            dgvLop.Columns[3].HeaderText = "Chương trình đào tạo";
            dgvLop.Columns[0].Width = 150;
            dgvLop.Columns[1].Width = 200;
            dgvLop.Columns[2].Width = 200;
            dgvLop.Columns[3].Width = 150;*/
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmLopSV_Load(object sender, EventArgs e)
        {
            LoadComboBoxCTDT();
            LoadLop();
            

        }

        private void txtTimKiemSV_Click(object sender, EventArgs e)
        {
            /*txtMaLop.Clear();
            txtHoTen.Clear();
            txt_themgioitinh.Clear();
            txtNhapMaLop.Clear();
            txtNhapMaNganh.Clear();
            txt_themmk.Clear();
            txt_themtendangnhap.Clear();
            txt_themngaysinh.Clear();
            txtNhapTenLop.Clear();
            try
            {
                dgvLop.DataSource = sv.ThongTin(txtMaSV.Text).Tables[0];
                dgvLop.Columns[0].HeaderText = "Mã Sinh Viên";
                dgvLop.Columns[1].HeaderText = "Họ tên Sinh Viên";
                dgvLop.Columns[2].HeaderText = "Giới Tính";
                dgvLop.Columns[3].HeaderText = "Ngày Sinh";
                dgvLop.Columns[0].Width = 150;
                dgvLop.Columns[1].Width = 200;
                dgvLop.Columns[2].Width = 200;
                dgvLop.Columns[3].Width = 150;
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            /*bool kq = false;
            string err = "";
            try
            {
                kq = lop.XoaLop(ref err, txtMaLop.Text);
                if (kq)
                {
                    MessageBox.Show("Đã xóa thành công!");
                }
                else
                {
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (SqlException)
            {
                err = "Không thể xóa!";
                MessageBox.Show(err);
            }*/
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            /*bool kq = false;
            string err = "";
            try
            {
                kq = sv.ThemSV(ref err, txt_themtendangnhap.Text, txt_themmk.Text, txtHoTen.Text, txt_themgioitinh.Text, Convert.ToDateTime(txt_themngaysinh.Text).ToString("yyyy-MM-dd"), txt_themmalophoc.Text);
                if (kq)
                {
                    MessageBox.Show("Đã thêm thành công!");
                }
                else
                {
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    

            }
            catch (SqlException)
            {
                err = "Không thể thêm!";
                MessageBox.Show(err);
            }*/
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            /*bool kq = false;
            string err = "";
            try
            {
                kq = sv.XoaSV(ref err, txtMaSV.Text);
                if (kq)
                {
                    MessageBox.Show("Đã xóa thành công!");
                }
                else
                {
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (SqlException)
            {
                err = "Không thể xóa!";
                MessageBox.Show(err);
            }*/
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            /*bool kq = false;
            string ht, gt, ns, lop, tr;
            if (txtHoTen.Text == "")
            {
                ht= null;
            }
            else { ht = txtHoTen.Text; }
            if (txt_themgioitinh.Text == "")
            {
                gt = null;
            }
            else { gt = txt_themgioitinh.Text; }
            if (txt_themngaysinh.Text == "")
            {
                ns = null;
            }
            else { ns = txt_themngaysinh.Text; }
            if (txt_themmalophoc.Text == "")
            {
                lop = null;
            }
            else { lop = txt_themmalophoc.Text; }
            if (txt_themtinhtrang.Text == "")
            {
                tr = null;
            }
            else { tr = txt_themtinhtrang.Text; }

            string err = "";
            try
            {
                kq = sv.CapNhatSV(ref err, txt_themtendangnhap.Text, ht, gt, ns, lop, tr);
                if (kq)
                {
                    MessageBox.Show("Đã cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (SqlException)
            {
                err = "Không thể cập nhật!";
                MessageBox.Show(err);
            }*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNhapGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_themquanlylop_Click(object sender, EventArgs e)
        {
           /* bool kq = false;
            string err = "";
            try
            {
                kq = lop.ThemLop(ref err, txtNhapMaLop.Text, txtNhapTenLop.Text, txtNhapMaNganh.Text, cbbCTDT.SelectedValue.ToString());
                if (kq)
                {
                    LoadLop();
                    MessageBox.Show("Đã thêm thành công!");
                }
                else
                {
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (SqlException)
            {
                err = "Không thể thêm!";
                MessageBox.Show(err);
            }*/
        }

        private void btn_timkiemlop_Click(object sender, EventArgs e)
        {
            txt_masv.Clear();
            txt_themhoten.Clear();
            txt_themgioitinh.Clear();
            txt_themmalop.Clear();
            txt_themtennganh.Clear();
            txt_themmk.Clear();
            txt_themtendangnhap.Clear();
            txt_themngaysinh.Clear();
            txt_themtenlop.Clear();
            dgv_danhsach.DataSource = lop.DSSinhVienLop(txt_themtenlop.Text).Tables[0];
            dgv_danhsach.Columns[0].HeaderText = "Mã Sinh Viên";
            dgv_danhsach.Columns[1].HeaderText = "Họ tên Sinh Viên";
            dgv_danhsach.Columns[2].HeaderText = "Giới Tính";
            dgv_danhsach.Columns[3].HeaderText = "Ngày Sinh";
            dgv_danhsach.Columns[0].Width = 150;
            dgv_danhsach.Columns[1].Width = 200;
            dgv_danhsach.Columns[2].Width = 200;
            dgv_danhsach.Columns[3].Width = 150;
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            this.menuStrip.Show();
        }
    }
}
