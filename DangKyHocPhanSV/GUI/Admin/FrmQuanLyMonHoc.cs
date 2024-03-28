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
using DangKyHocPhanSV.Pagination;


namespace DangKyHocPhanSV
{
    public partial class FrmQuanLyMonHoc : Form
    {
        DBMonHoc_DaoTao mhdt = new DBMonHoc_DaoTao();
        DBMonHoc mh = new DBMonHoc();
        DBNganh nganh = new DBNganh();
        DBChuongTrinhDT ctdt = new DBChuongTrinhDT();
        private Panel _panel;
        private MonHocPagination monHocPagination;
        public FrmQuanLyMonHoc(Panel panel)
        {
            InitializeComponent();
            _panel = panel;
            monHocPagination = new MonHocPagination();
        }
        private async void FrmQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            await monHocPagination.LoadDataAsync(dgv_monhoc, lblPageNumber, linklbl_back, linklbl_next);
            loadMHDT();
            loadcbbMonHoc();
            loadcbbNganh();
            loadcbbCTDT();
        }
        
        public void loadMHDT()
        {
            dgv_monhoc.DataSource = mhdt.DSMHDT().Tables[0];
            dgv_monhoc.Columns[0].HeaderText = "Mã MHDT";
            dgv_monhoc.Columns[1].HeaderText = "Tên Môn Học";
            dgv_monhoc.Columns[2].HeaderText = "Số tín chỉ";
            dgv_monhoc.Columns[3].HeaderText = "Tên Chương Trình Đào Tạo";
            dgv_monhoc.Columns[4].HeaderText = "Ngôn Ngữ Đào Tạo";
            dgv_monhoc.Columns[5].HeaderText = "Tên Ngành";

            dgv_monhoc.Columns[0].Width = 100;
            dgv_monhoc.Columns[1].Width = 200;
            dgv_monhoc.Columns[5].Width = 200;

        }
        public void loadMonHoc()
        {
            dgv_monhoc.DataSource = mh.DSMonHoc().Tables[0];
            dgv_monhoc.Columns[0].HeaderText = "Mã Môn Học";
            dgv_monhoc.Columns[1].HeaderText = "Tên Môn Học";
            dgv_monhoc.Columns[2].HeaderText = "Số tín chỉ";
        }
        public void loadcbbMonHoc()
        {
            cbb_themmonhoc.DataSource = mh.DSMonHoc().Tables[0];
            cbb_themmonhoc.DisplayMember = "TenMH";
            cbb_themmonhoc.ValueMember = "MaMH";
        }
        public void loadcbbNganh()
        {
            cbb_themnganh.DataSource = nganh.DanhSachNganh().Tables[0];
            cbb_themnganh.DisplayMember = "TenNganh";
            cbb_themnganh.ValueMember = "MaNganh";
        }
        public void loadcbbCTDT()
        {
            cbb_themCTDT.DataSource = ctdt.DanhSachCTDT().Tables[0];
            cbb_themCTDT.DisplayMember = "MaCTDT";
            cbb_themCTDT.ValueMember = "MaCTDT";
        }
        private void btn_timkiemmonhoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_mamonhoc.Text == "")
                {
                    loadMonHoc();
                    dgv_monhoc.Refresh();
                }
                else
                {
                    dgv_monhoc.DataSource = mh.TimKiemMH(txt_mamonhoc.Text).Tables[0];
                    dgv_monhoc.Columns[0].HeaderText = "Mã Môn Học";
                    dgv_monhoc.Columns[1].HeaderText = "Tên Môn Học";
                    dgv_monhoc.Columns[2].HeaderText = "Số tín chỉ";
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoamonhoc_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                if (txt_mamonhoc.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã môn học cần xóa");
                }
                else
                {
                    kq = mh.XoaMonHoc(ref err, txt_mamonhoc.Text);
                    if (kq)
                    {
                        loadMonHoc();
                        dgv_monhoc.Refresh();
                        MessageBox.Show("Đã xóa thành công!");
                    }
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_themquanlymonhoc_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                if (string.IsNullOrWhiteSpace(txt_mamonhoc.Text) || string.IsNullOrWhiteSpace(txt_themtenmh.Text) || string.IsNullOrWhiteSpace(txt_themsotinchi.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    kq = mh.ThemMonHoc(ref err, txt_themmamh.Text, txt_themtenmh.Text, int.Parse(txt_themsotinchi.Text));
                    if (kq)
                    {
                        loadMonHoc();
                        dgv_monhoc.Refresh();
                        MessageBox.Show("Đã thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_timkiemMHDT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_maMHDT.Text == "")
                {
                    loadMHDT();
                    dgv_monhoc.Refresh();
                }
                else
                {
                    dgv_monhoc.DataSource = mhdt.TimKiemMHDT(txt_maMHDT.Text).Tables[0];
                    dgv_monhoc.Columns[0].HeaderText = "Mã MHDT";
                    dgv_monhoc.Columns[1].HeaderText = "Tên Môn Học";
                    dgv_monhoc.Columns[2].HeaderText = "Số tín chỉ";
                    dgv_monhoc.Columns[3].HeaderText = "Tên Chương Trình Đào Tạo";
                    dgv_monhoc.Columns[4].HeaderText = "Ngôn Ngữ Đào Tạo";
                    dgv_monhoc.Columns[5].HeaderText = "Tên Ngành";

                    dgv_monhoc.Columns[0].Width = 100;
                    dgv_monhoc.Columns[1].Width = 200;
                    dgv_monhoc.Columns[5].Width = 200;
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_themMHDT_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                if (string.IsNullOrWhiteSpace(txt_maMHDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    kq = mhdt.ThemMHDT(ref err, txt_themMaMHDT.Text, cbb_themmonhoc.SelectedValue.ToString(), cbb_themCTDT.SelectedValue.ToString(), cbb_themnganh.SelectedValue.ToString());
                    if (kq)
                    {
                        loadMHDT();
                        dgv_monhoc.Refresh();

                        MessageBox.Show("Đã thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoaQLMHDT_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                if (txt_maMHDT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã môn học đào tạo cần xóa");
                }
                else
                {
                    kq = mhdt.XoaMHDT(ref err, txt_maMHDT.Text);
                    if (kq)
                    {
                        loadMHDT();
                        dgv_monhoc.Refresh();
                        MessageBox.Show("Đã xóa thành công!");
                    }
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

        private async void linklbl_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await monHocPagination.PreviousPageAsync(dgv_monhoc, lblPageNumber, linklbl_back, linklbl_next);
        }

        private async void linklbl_next_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await monHocPagination.NextPageAsync(dgv_monhoc, lblPageNumber, linklbl_back, linklbl_next);
        }
    }
}
