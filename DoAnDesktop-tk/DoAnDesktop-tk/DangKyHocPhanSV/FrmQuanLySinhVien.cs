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
    public partial class FrmQuanLySinhVien : Form
    {
        DBKhoa khoa = new DBKhoa();
        DBNganh nganh = new DBNganh();
        private Panel _panel;
        private Form _parent;
        private Form currentFormChild;
        public void OpenChildForm(Form childForm, Panel panel)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public FrmQuanLySinhVien(Form parent, Panel panel)
        {
            InitializeComponent();
            _parent = parent;
            _panel = panel;
        }


        private void FrmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            txt_tongsinhvien.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            _panel.Show();
        }

        private void btn_timkiemmanganh_Click(object sender, EventArgs e)
        {
            txt_manganh.Clear();
            int n = khoa.TongSVKhoa(txt_makhoa.Text);
            txt_tongsinhvien.Text = n.ToString();

            dgv_sinhvien.DataSource = khoa.DanhSachSVKhoa(txt_makhoa.Text).Tables[0];
            dgv_sinhvien.Columns[0].HeaderText = "Mã số sinh viên";
            dgv_sinhvien.Columns[1].HeaderText = "Họ và tên";
            dgv_sinhvien.Columns[2].HeaderText = "Giới tính";
            dgv_sinhvien.Columns[3].HeaderText = "Ngày Sinh";
            dgv_sinhvien.Columns[4].HeaderText = "Mã Lớp";

            dgv_sinhvien.Columns[0].Width = 150;
            dgv_sinhvien.Columns[1].Width = 200;
            dgv_sinhvien.Columns[2].Width = 100;
            dgv_sinhvien.Columns[3].Width = 100;
            dgv_sinhvien.Columns[4].Width = 100;
        }

        private void btn_timkiemmakhoa_Click(object sender, EventArgs e)
        {
            txt_makhoa.Clear();
            int n = nganh.TongSVNganh(txt_manganh.Text);
            txt_tongsinhvien.Text = n.ToString();

            dgv_sinhvien.DataSource = nganh.DanhSachSVNganh(txt_manganh.Text).Tables[0];
            dgv_sinhvien.Columns[0].HeaderText = "Mã số sinh viên";
            dgv_sinhvien.Columns[1].HeaderText = "Họ và tên";
            dgv_sinhvien.Columns[2].HeaderText = "Giới tính";
            dgv_sinhvien.Columns[3].HeaderText = "Ngày Sinh";
            dgv_sinhvien.Columns[4].HeaderText = "Mã Lớp";
            dgv_sinhvien.Columns[0].Width = 150;
            dgv_sinhvien.Columns[1].Width = 200;
            dgv_sinhvien.Columns[2].Width = 100;
            dgv_sinhvien.Columns[3].Width = 100;
            dgv_sinhvien.Columns[4].Width = 100;
        }

        private void dgv_sinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tooltripmenu_quanlylopsinhvien_Click(object sender, EventArgs e)
        {
            FrmLopSV lopsv = new FrmLopSV(menustrip_quanlylopsinhvien);
            OpenChildForm(lopsv, pn_container);
            menustrip_quanlylopsinhvien.Hide();
        }
    }
}
