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
    public partial class FrmTrangSinhVien : Form
    {
        private Form _parent;
        private string maso;
        DBSinhVien sv = new DBSinhVien();
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

        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmTrangSinhVien(Form parent)
        {
            InitializeComponent();
            _parent = parent;

        }
        private void FrmTrangSinhVien_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        void LoadThongTin()
        {
            this.txt_ten.Text = sv.ThongTin(maso).Tables[0].Rows[0].Field<string>("HoTenSV");
            this.txt_msv.Text = sv.ThongTin(maso).Tables[0].Rows[0].Field<string>("MaSV");
            this.dgv_dshocphan.DataSource = sv.HocPhanCTDTSV(maso).Tables[0];

            dgv_dshocphan.Columns[0].HeaderText = "Mã Môn Học";
            dgv_dshocphan.Columns[1].HeaderText = "Tên Môn Học";
            dgv_dshocphan.Columns[2].HeaderText = "Số Tín Chỉ";

            dgv_dshocphan.Columns[0].Width = 170;
            dgv_dshocphan.Columns[1].Width = 400;
            dgv_dshocphan.Columns[2].Width = 100;
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhauSV dmk = new FrmDoiMatKhauSV();
            dmk.MaSo = maso;
            dmk.ShowDialog();
        }

        private void btn_dkhocphan_Click(object sender, EventArgs e)
        {
            FrmDangKyMonHoc dk = new FrmDangKyMonHoc(this, pn_header);
            dk.MaSo = maso;
            OpenChildForm(dk, pn_container);
        }

        private void btn_thoikhoabieu_Click(object sender, EventArgs e)
        {
            FrmThoiKhoaBieuSV tkb = new FrmThoiKhoaBieuSV(this, pn_header);
            tkb.MaSo = maso;
            OpenChildForm(tkb, pn_container);

        }

        private void btn_tracuuhocphan_Click(object sender, EventArgs e)
        {
            FrmTraCuuMonHoc tcmh = new FrmTraCuuMonHoc(this, pn_header);
            OpenChildForm(tcmh, pn_container);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_lophoc_Click(object sender, EventArgs e)
        {
            FrmDanhSachLopHocSV ds = new FrmDanhSachLopHocSV(this, pn_header);
            OpenChildForm(ds, pn_container);
        }
    }
}
