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
    public partial class FrmTrangGiangVien : Form
    {
        private Form _parent;
        private string maso;
        DBLopHoc lh = new DBLopHoc();
        DBGiangVien gv = new DBGiangVien();
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
        public FrmTrangGiangVien(Form parent)
        {
            InitializeComponent();
            gv.GiangVienConnect();
            _parent = parent;

        }

        private void FrmTrangGiangVien_Load(object sender, EventArgs e)
        {
            this.txt_ten.Text = gv.ThongTinGV(maso).Tables[0].Rows[0].Field<string>("HoTenGV");

            this.dgv_thoikhoabieu.DataSource = lh.ThoiKhoaBieuGV(maso).Tables[0];
            dgv_thoikhoabieu.Columns[0].HeaderText = "Thứ";
            dgv_thoikhoabieu.Columns[1].HeaderText = "Tiết Bắt Đầu";
            dgv_thoikhoabieu.Columns[2].HeaderText = "Tiết Kết Thúc";
            dgv_thoikhoabieu.Columns[3].HeaderText = "Tên Phòng";
            dgv_thoikhoabieu.Columns[4].HeaderText = "Tên Môn Học";

            dgv_thoikhoabieu.Columns[4].Width = 270;
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhauGV dmk = new FrmDoiMatKhauGV();
            dmk.MaSo = maso;
            dmk.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        private void btn_dslophoc_Click(object sender, EventArgs e)
        {
            FrmDanhSachLopHocGV ds = new FrmDanhSachLopHocGV(this, pn_container);
            ds.MaSo = maso;
            OpenChildForm(ds, pn_container);
            pn_header.Hide();
        }
    }
}
