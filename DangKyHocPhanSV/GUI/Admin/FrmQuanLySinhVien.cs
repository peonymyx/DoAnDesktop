using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DangKyHocPhanSV.Pagination;

namespace DangKyHocPhanSV
{
    public partial class FrmQuanLySinhVien : Form
    {
        DBKhoa khoa = new DBKhoa();
        DBNganh nganh = new DBNganh();
        DBLop lop = new DBLop();
        DBSinhVien sv = new DBSinhVien();
        private Panel _panel;
        private Form currentFormChild;
        private SinhVienPagination sinhVienPagination;
         
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
        public FrmQuanLySinhVien(Panel panel)
        {
            InitializeComponent();
            _panel = panel;
            sinhVienPagination = new SinhVienPagination();
        }
        

        private async void FrmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            txt_tongsinhvien.Enabled = false;
            loadMaLop();
            await sinhVienPagination.LoadDataAsync(dgv_sinhvien, lblPageNumber, linklbl_back, linklbl_next);
        }

        private async void FrmQuanLySinhVien_Load()
        {
            txt_tongsinhvien.Enabled = false;
            loadMaLop();
            await sinhVienPagination.LoadDataAsync(dgv_sinhvien, lblPageNumber, linklbl_back, linklbl_next);
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            _panel.Show();
        }

        private void btn_timkiemmanganh_Click(object sender, EventArgs e)
        {
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

        private void btn_timkiemmakhoa_Click(object sender, EventArgs e)
        {
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


        private void tooltripmenu_quanlylopsinhvien_Click(object sender, EventArgs e)
        {
            FrmLopSV lopsv = new FrmLopSV(menustrip_quanlylopsinhvien);
            OpenChildForm(lopsv, pn_container);
            menustrip_quanlylopsinhvien.Hide();
        }

        private async void linklbl_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await sinhVienPagination.PreviousPageAsync(dgv_sinhvien, lblPageNumber, linklbl_back, linklbl_next);
        }

        private async void linklbl_next_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await sinhVienPagination.NextPageAsync(dgv_sinhvien, lblPageNumber, linklbl_back, linklbl_next);
        }
        string GioiTinhSelected = "";
        string TenLopSelected = "";
        private void cbb_malop_SelectedIndexChanged(object sender, EventArgs e)
        {
            object TenLopItem = cbb_malop.SelectedItem;
            if (TenLopItem != null)
            {
                TenLopSelected = TenLopItem.ToString();
            }
        }

        private void cbb_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            object GioiTinhItem = cbb_gioitinh.SelectedItem;
            if (GioiTinhItem != null)
            {
                GioiTinhSelected = GioiTinhItem.ToString();
            }
        }
        private void loadMaLop()
        {
            DataSet ds = lop.DSLop();
            cbb_malop.Items.Clear();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string tenLop = row[1].ToString();
                cbb_malop.Items.Add(tenLop);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            string ngaysinh = dtp_ngaysinh.Value.ToString("yyyy-MM-dd");
            try
            {
                if (string.IsNullOrWhiteSpace(txt_matkhau.Text) ||
                    string.IsNullOrWhiteSpace(txt_hoten.Text) ||
                    string.IsNullOrWhiteSpace(txt_email.Text) ||
                    string.IsNullOrWhiteSpace(txt_tendangnhap.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (GioiTinhSelected == null)
                {
                    MessageBox.Show("Vui lòng chọn mã lớp!");
                }
                else if (TenLopSelected == null)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!");
                }
                else
                {
                    string maLop = "";
                    foreach (DataRow row in lop.DSLop().Tables[0].Rows)
                    {
                        string tenLop = row[1].ToString();
                        if (tenLop == TenLopSelected)
                        {
                            maLop = row[0].ToString();
                        }
                    }
                    kq = sv.ThemSV(ref err, txt_tendangnhap.Text,
                        txt_matkhau.Text, txt_hoten.Text,
                        GioiTinhSelected,
                        txt_email.Text, ngaysinh, maLop);
                    if (kq)
                    {
                        FrmQuanLySinhVien_Load();
                        MessageBox.Show("Đã thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm!");
                    }
                }
            }
            catch (SqlException)
            {
                err = "Không thể thêm!";
                MessageBox.Show(err);
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            string ngaysinh = dtp_ngaysinh.Value.ToString("yyyy-MM-dd");
            try
            {
                if (string.IsNullOrWhiteSpace(txt_matkhau.Text) ||
                    string.IsNullOrWhiteSpace(txt_hoten.Text) ||
                    string.IsNullOrWhiteSpace(txt_tendangnhap.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (GioiTinhSelected == null)
                {
                    MessageBox.Show("Vui lòng chọn mã lớp!");
                }
                else if (TenLopSelected == null)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!");
                }
                else
                {
                    kq = sv.CapNhatSV(ref err, txt_tendangnhap.Text,
                         txt_hoten.Text, GioiTinhSelected,
                        ngaysinh);
                    if (kq)
                    {
                        FrmQuanLySinhVien_Load();
                        MessageBox.Show("Đã cập nhật thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật!");
                    }
                }
            }
            catch (SqlException)
            {
                err = "Không thể cập nhật!";
                MessageBox.Show(err);
            }
        }
    }
}
