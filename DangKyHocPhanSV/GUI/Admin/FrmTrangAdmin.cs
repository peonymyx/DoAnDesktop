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
            DataTable data = ql.GetTongSoLuong();
            lbl_numsv.Text = data.Rows[0]["RecordCount"].ToString();
            lbl_numgv.Text = data.Rows[1]["RecordCount"].ToString();
            lbl_numnganh.Text = data.Rows[2]["RecordCount"].ToString();
            lbl_numkhoa.Text = data.Rows[3]["RecordCount"].ToString();
            lbl_nummh.Text = data.Rows[4]["RecordCount"].ToString();

        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhauSV dmk = new FrmDoiMatKhauSV();
            dmk.MaSo = maso;
            dmk.ShowDialog();
        }

        private void btn_monhoc_Click(object sender, EventArgs e)
        {
            FrmQuanLyMonHoc mh = new FrmQuanLyMonHoc(pn_header);
            OpenChildForm(mh, pn_container);
            pn_header.Hide();
        }

        private void btn_phonghoc_Click(object sender, EventArgs e)
        {
            FrmQuanLyPhongHoc ph = new FrmQuanLyPhongHoc(pn_header);
            OpenChildForm(ph, pn_container);
            pn_header.Hide();
        }

        private void btn_khoa_Click(object sender, EventArgs e)
        {
            FrmQuanLyKhoaNganh khng = new FrmQuanLyKhoaNganh(pn_header);
            OpenChildForm(khng, pn_container);
            pn_header.Hide();
        }

        private void btn_quanlygiangvien_Click(object sender, EventArgs e)
        {
            FrmGiangVien gv = new FrmGiangVien(pn_header);
            OpenChildForm(gv, pn_container);
            pn_header.Hide();
        }

        private void btn_quanlysinhvien_Click(object sender, EventArgs e)
        {
            FrmQuanLySinhVien qlsv = new FrmQuanLySinhVien(pn_header);
            OpenChildForm(qlsv, pn_container);
            pn_header.Hide();
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            FrmThongKe tk = new FrmThongKe(this, pn_header);
            tk.ShowDialog();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        int x; // tạo mới một biến x

        private void timer_timeline_Tick(object sender, EventArgs e)
        {
            // lấy tọa độ của label
            x = lbl_timeline.Location.X;
            x--;
            lbl_timeline.Location = new Point(x, lbl_timeline.Location.Y);
            if (x == 0 - lbl_timeline.Width)
            {
                x = 993;
                lbl_timeline.Location = new Point(993, lbl_timeline.Location.Y);
            }    
        }
    }
}
