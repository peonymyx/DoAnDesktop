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
    public partial class FrmQuanLyKhoaNganh : Form
    {
        private Panel _panel;
        private Form _parent;
        DBKhoa khoa = new DBKhoa();
        DBNganh nganh = new DBNganh();
        
        public FrmQuanLyKhoaNganh(Form parent, Panel panel)
        {
            InitializeComponent();
            _parent = parent;
            _panel = panel;
        }
        public void loadDSKhoa()
        {
            cbb_makhoa.DataSource = khoa.DanhSachKhoa().Tables[0];
            cbb_makhoa.DisplayMember = "TenKhoa";
            cbb_makhoa.ValueMember = "MaKhoa";
        }
        public void loadDSNganh()
        {
            dgv_khoanganh.DataSource = nganh.DanhSachNganh().Tables[0];
            dgv_khoanganh.Columns[0].HeaderText = "Mã Ngành";
            dgv_khoanganh.Columns[1].HeaderText = "Tên Ngành";
            dgv_khoanganh.Columns[2].HeaderText = "Tên Khoa";

        }

        public void showDSKhoa()
        {
            dgv_khoanganh.DataSource = khoa.DanhSachKhoa().Tables[0];
            dgv_khoanganh.Columns[0].HeaderText = "Mã Khoa";
            dgv_khoanganh.Columns[1].HeaderText = "Tên Khoa";
        }
        private void FrmQuanLyKhoaNganh_Load(object sender, EventArgs e)
        {
            loadDSKhoa();
        }

        private void btn_timkiemkhoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_makhoa.Text == "")
                {
                    showDSKhoa();
                }
                else
                {
                    dgv_khoanganh.DataSource = khoa.TimKiemKhoa(txt_makhoa.Text).Tables[0];
                    dgv_khoanganh.Columns[0].HeaderText = "Mã Khoa";
                    dgv_khoanganh.Columns[1].HeaderText = "Tên Khoa";
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoakhoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = khoa.XoaKhoa(ref err, txt_makhoa.Text);
                if (kq)
                {
                    showDSKhoa();
                    loadDSKhoa();
                    MessageBox.Show("Đã xóa thành công!");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_themkhoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = khoa.ThemKhoa(ref err, txt_themmakhoa.Text, txt_themtenkhoa.Text);
                if (kq)
                {
                    showDSKhoa();
                    loadDSKhoa();
                    MessageBox.Show("Đã thêm thành công!");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_timkiemmanganh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_manganh.Text == "")
                {
                    loadDSNganh();
                }
                else
                {
                    dgv_khoanganh.DataSource = nganh.TimKiemNganh(txt_manganh.Text).Tables[0];
                    dgv_khoanganh.Columns[0].HeaderText = "Mã Ngành";
                    dgv_khoanganh.Columns[1].HeaderText = "Tên Ngành";
                    dgv_khoanganh.Columns[2].HeaderText = "Tên Khoa";

                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_themnganh_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = nganh.ThemNganh(ref err, txt_themmanganh.Text, txt_themmanganh.Text, cbb_makhoa.SelectedValue.ToString());
                if (kq)
                {
                    loadDSNganh();
                    MessageBox.Show("Đã thêm thành công!");
                }
                else
                {
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoamanganh_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = nganh.XoaNganh(ref err, txt_manganh.Text);
                if (kq)
                {
                    loadDSNganh();
                    MessageBox.Show("Đã xóa thành công!");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            _panel.Show();
        }
    }
}
