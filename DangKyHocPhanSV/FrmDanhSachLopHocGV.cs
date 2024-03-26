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
        private int numClass;
        private string MaLH;
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
            DataTable dataTable = lh.ChiTietLopHocGV(maso).Tables[0];
            numClass = dataTable.Rows.Count;
            for (int i = 0; i < numClass; i++)
            {
                Panel panel = new Panel();
                FrmGiaoDienLopHoc frmGiaoDienLopHoc;

                string thu = dataTable.Rows[i].Field<string>("Thu").ToString();
                string tenphong = dataTable.Rows[i].Field<string>("TenPhong").ToString();
                string tietbd = dataTable.Rows[i].Field<int>("TietBatDau").ToString();
                string tietkt = dataTable.Rows[i].Field<int>("TietKetThuc").ToString();
                string malophoc = dataTable.Rows[i].Field<string>("MaLopHoc").ToString();
                string sosinhvien = dataTable.Rows[i].Field<int>("soluong").ToString();
                MaLH = malophoc;
                frmGiaoDienLopHoc = new FrmGiaoDienLopHoc(malophoc, tenphong, thu, tietbd, tietkt, sosinhvien, _panel);

                // Set form's parent to the panel
                frmGiaoDienLopHoc.TopLevel = false;
                panel.Controls.Add(frmGiaoDienLopHoc);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Size = new System.Drawing.Size(224, 290);
                panel.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);

                // Show form
                frmGiaoDienLopHoc.Show();

                flpn_dslophoc.Controls.Add(panel);

                frmGiaoDienLopHoc.GetButton().Click += btn_vaohoc_Click;
            }
        }

        private void btn_vaohoc_Click(object sender, EventArgs e)
        {
            ((FrmTrangGiangVien)this.ParentForm).OpenChildForm(new FrmLopHocGV(MaLH), _panel);
        }

        private void FrmDanhSachLopHocGV_Load(object sender, EventArgs e)
        {
            loadChiTiet();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            txt_tongsinhvien.Text = lh.TongSVLopHoc(txt_timkiem.Text).ToString();
            DataTable dataTable = lh.DanhSachSVLH(txt_timkiem.Text).Tables[0];
            FrmDanhSachSinhVien frmDanhSachSinhVien = new FrmDanhSachSinhVien(dataTable, txt_tongsinhvien.Text);
            OpenChildForm(frmDanhSachSinhVien, pn_lophoc);
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            _panel.Show();

        }
    }
}
