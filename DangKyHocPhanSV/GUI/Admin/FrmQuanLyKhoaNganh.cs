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
    public partial class FrmQuanLyKhoaNganh : Form
    {
        private Panel _panel;
        DBKhoa khoa = new DBKhoa();
        DBNganh nganh = new DBNganh();
        private KhoaPagination khoaPagination;
        private NganhPagination nganhPagination;
        
        public FrmQuanLyKhoaNganh(Panel panel)
        {
            InitializeComponent();
            _panel = panel;
            khoaPagination = new KhoaPagination();
            nganhPagination = new NganhPagination();
        }
        public void loadDSKhoa()
        {
            cbb_makhoa.DataSource = khoa.DanhSachKhoa().Tables[0];
            cbb_makhoa.DisplayMember = "TenKhoa";
            cbb_makhoa.ValueMember = "MaKhoa";
        }
        public void loadDSNganh()
        {
            dgv_nganh.DataSource = nganh.DanhSachNganh().Tables[0];
            dgv_nganh.Columns[0].HeaderText = "Mã Ngành";
            dgv_nganh.Columns[1].HeaderText = "Tên Ngành";
            dgv_nganh.Columns[2].HeaderText = "Tên Khoa";

        }
        public void showDSKhoa()
        {
            dgv_khoa.DataSource = khoa.DanhSachKhoa().Tables[0];
            dgv_khoa.Columns[0].HeaderText = "Mã Khoa";
            dgv_khoa.Columns[1].HeaderText = "Tên Khoa";
        }
        private async void FrmQuanLyKhoaNganh_Load()
        {
            loadDSKhoa();
            await khoaPagination.LoadDataAsync(dgv_khoa, lblPageNumberkhoa, linklbl_backkhoa, linklbl_nextkhoa);
            await nganhPagination.LoadDataAsync(dgv_nganh, lblPageNumbernganh, linklbl_backnganh, linklbl_nextnganh);
        }
        private async void FrmQuanLyKhoaNganh_Load(object sender, EventArgs e)
        {
            loadDSKhoa();
            await khoaPagination.LoadDataAsync(dgv_khoa, lblPageNumberkhoa, linklbl_backkhoa, linklbl_nextkhoa);
            await nganhPagination.LoadDataAsync(dgv_nganh, lblPageNumbernganh, linklbl_backnganh, linklbl_nextnganh);
        }

        private void btn_timkiemkhoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_makhoa.Text == "")
                {
                    FrmQuanLyKhoaNganh_Load();
                }
                else
                {
                    dgv_khoa.DataSource = khoa.TimKiemKhoa(txt_makhoa.Text).Tables[0];
                    dgv_khoa.Columns[0].HeaderText = "Mã Khoa";
                    dgv_khoa.Columns[1].HeaderText = "Tên Khoa";
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
                if (txt_makhoa.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã khoa cần xóa");
                }
                else
                {
                    kq = khoa.XoaKhoa(ref err, txt_makhoa.Text);
                    if (kq)
                    {
                        showDSKhoa();
                        loadDSKhoa();
                        MessageBox.Show("Đã xóa thành công!");
                    }
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
                if (string.IsNullOrWhiteSpace(txt_themmakhoa.Text) || string.IsNullOrWhiteSpace(txt_themtenkhoa.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    kq = khoa.ThemKhoa(ref err, txt_themmakhoa.Text, txt_themtenkhoa.Text);
                    if (kq)
                    {
                        showDSKhoa();
                        loadDSKhoa();
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

        private void btn_timkiemmanganh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_manganh.Text == "")
                {
                    FrmQuanLyKhoaNganh_Load();
                }
                else
                {
                    dgv_nganh.DataSource = nganh.TimKiemNganh(txt_manganh.Text).Tables[0];
                    dgv_nganh.Columns[0].HeaderText = "Mã Ngành";
                    dgv_nganh.Columns[1].HeaderText = "Tên Ngành";
                    dgv_nganh.Columns[2].HeaderText = "Tên Khoa";

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
                if (string.IsNullOrWhiteSpace(txt_themmanganh.Text) || string.IsNullOrWhiteSpace(txt_themtenganh.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    kq = nganh.ThemNganh(ref err, txt_themmanganh.Text, txt_themtenganh.Text, cbb_makhoa.SelectedValue.ToString());
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
                if (txt_manganh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã ngành cần xóa");
                }
                else
                {
                    kq = nganh.XoaNganh(ref err, txt_manganh.Text);
                    if (kq)
                    {
                        loadDSNganh();
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

        private async void linklbl_backkhoa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await khoaPagination.PreviousPageAsync(dgv_khoa, lblPageNumberkhoa, linklbl_backkhoa, linklbl_nextkhoa);        
        }

        private async void linklbl_nextkhoa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await khoaPagination.NextPageAsync(dgv_khoa, lblPageNumberkhoa, linklbl_backkhoa, linklbl_nextkhoa);         
        }

        private async void linklbl_backnganh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {      
            await nganhPagination.PreviousPageAsync(dgv_nganh, lblPageNumbernganh, linklbl_backnganh, linklbl_nextnganh);
        }

        private async void linklbl_nextnganh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await nganhPagination.NextPageAsync(dgv_nganh, lblPageNumbernganh, linklbl_backnganh, linklbl_nextnganh);
        }

        private void btn_capnhatkhoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                if (string.IsNullOrWhiteSpace(txt_themmakhoa.Text) || string.IsNullOrWhiteSpace(txt_themtenkhoa.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    kq = khoa.CapNhatKhoa(ref err, txt_themmakhoa.Text, txt_themtenkhoa.Text);
                    if (kq)
                    {
                        showDSKhoa();
                        loadDSKhoa();
                        MessageBox.Show("Đã cập nhật thành công!");
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

        private void btn_capnhatnganh_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                if (string.IsNullOrWhiteSpace(txt_themmanganh.Text) || string.IsNullOrWhiteSpace(txt_themtenganh.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    kq = nganh.CapNhatNganh(ref err, txt_themmanganh.Text, txt_themtenganh.Text, cbb_makhoa.SelectedValue.ToString());
                    if (kq)
                    {
                        loadDSNganh();
                        MessageBox.Show("Đã cập nhật thành công!");
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
    }
}
