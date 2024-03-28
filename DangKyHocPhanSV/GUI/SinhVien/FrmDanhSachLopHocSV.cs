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
using DangKyHocPhanSV.DTO;

namespace DangKyHocPhanSV
{
    public partial class FrmDanhSachLopHocSV : Form
    {
        private string maso;
        DBLopHoc lh = new DBLopHoc();
        private Panel _panelContainer;
        private Panel _panelHeader;
        private int numClass;
        public FrmDanhSachLopHocSV(Panel panelContainer, Panel panelHeader)
        {
            InitializeComponent();
            _panelContainer = panelContainer;
            _panelHeader = panelHeader;

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
                string ten = dataTable.Rows[i].Field<string>("TenMH").ToString();
                frmGiaoDienLopHoc = new FrmGiaoDienLopHoc(ten, malophoc, tenphong, thu, tietbd, tietkt, sosinhvien, _panelContainer);
                frmGiaoDienLopHoc.GetButton().Tag = new LopHoc
                {
                    Ten = ten,
                    MaLopHoc = malophoc,
                    TenPhong = tenphong,
                    Thu = thu,
                    TietBatDau = tietbd,
                    TietKetThuc = tietkt,
                    SoLuongSinhVien = sosinhvien
                };
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
            Button btn = (Button)sender;
            LopHoc lophoc = (LopHoc)btn.Tag;
            ((FrmTrangSinhVien)this.ParentForm).OpenChildForm(new FrmLopHocSV(maso, lophoc.MaLopHoc, _panelHeader, _panelContainer), _panelContainer);
        }

        private void FrmDanhSachLopHocSV_Load(object sender, EventArgs e)
        {
            loadChiTiet();
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            _panelHeader.Show();
        }

        int x;
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