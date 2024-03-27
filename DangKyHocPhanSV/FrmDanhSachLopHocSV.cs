using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyHocPhanSV
{
    public partial class FrmDanhSachLopHocSV : Form
    {
        private string maso;
        DBLopHoc lh = new DBLopHoc();
        DBSinhVien sv = new DBSinhVien();
        private string MaLH;
        private Form _parent;
        private Panel _panel;
        private Panel _panel1;
        private int numClass;
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
        public FrmDanhSachLopHocSV(Form parent, Panel panel, Panel panel1)
        {
            InitializeComponent();
            _parent = parent;
            _panel = panel;
            _panel1 = panel1;

        }
        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public void loadChiTiet()
        {
            DataTable dataTable = lh.ChiTietLopHocSV(maso).Tables[0];
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
            ((FrmTrangSinhVien)this.ParentForm).OpenChildForm(new FrmLopHocSV(maso, MaLH, _panel1), _panel);
        }

        private void FrmDanhSachLopHocSV_Load(object sender, EventArgs e)
        {
            loadChiTiet();
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            _panel1.Show();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

        }
    }
}
