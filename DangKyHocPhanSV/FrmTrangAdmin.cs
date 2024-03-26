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
    public partial class FrmTrangAdmin : Form
    {
        private Form _parent;
        private string maso;
        DBSinhVien sv = new DBSinhVien();
        DBQuanLy ql = new DBQuanLy();
        private Form currentFormChild;
        private void OpenChildForm(Form childForm, Panel panel)
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
        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmTrangAdmin(Form parent)
        {
            InitializeComponent();
            _parent = parent;

        }

        private void FrmTrangAdmin_Load(object sender, EventArgs e)
        {
            this.txt_ten.Text = ql.ThongTin(maso).Tables[0].Rows[0].Field<string>("TenNQL");
            this.dgv_dssinhvien.DataSource = sv.DSSinhVienDKMH().Tables[0];

            dgv_dssinhvien.Columns[0].HeaderText = "Mã Sinh Viên";
            dgv_dssinhvien.Columns[1].HeaderText = "Tên Sinh Viên";
            dgv_dssinhvien.Columns[2].HeaderText = "Tên Ngành";
            dgv_dssinhvien.Columns[0].Width = 150;
            dgv_dssinhvien.Columns[1].Width = 200;
            dgv_dssinhvien.Columns[2].Width = 200;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhauAdmin dmk = new FrmDoiMatKhauAdmin();
            dmk.MaSo = maso;
            dmk.ShowDialog();
        }

        private void btn_monhoc_Click(object sender, EventArgs e)
        {
            FrmQuanLyMonHoc mh = new FrmQuanLyMonHoc(this, pn_header);
            OpenChildForm(mh, pn_container);
            pn_header.Hide();
        }

        private void btn_phonghoc_Click(object sender, EventArgs e)
        {
            FrmQuanLyPhongHoc ph = new FrmQuanLyPhongHoc(this, pn_header);
            OpenChildForm(ph, pn_container);
            pn_header.Hide();
        }

        private void btn_khoa_Click(object sender, EventArgs e)
        {
            FrmQuanLyKhoaNganh khng = new FrmQuanLyKhoaNganh(this, pn_header);
            OpenChildForm(khng, pn_container);
            pn_header.Hide();
        }

        private void btn_quanlygiangvien_Click(object sender, EventArgs e)
        {
            FrmGiangVien gv = new FrmGiangVien(this, pn_header);
            OpenChildForm(gv, pn_container);
            pn_header.Hide();
        }

        private void btn_quanlysinhvien_Click(object sender, EventArgs e)
        {
            FrmQuanLySinhVien qlsv = new FrmQuanLySinhVien(this, pn_header);
            OpenChildForm(qlsv, pn_container);
            pn_header.Hide();
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            FrmThongKe tk = new FrmThongKe(this, pn_header);
            tk.ShowDialog();
        }
    }
}
