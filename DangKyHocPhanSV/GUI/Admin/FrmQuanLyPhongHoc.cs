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
    public partial class FrmQuanLyPhongHoc : Form
    {
        DBLopHoc lh = new DBLopHoc();
        private Panel _panel;
        private PhongHocPagination phongHocPagination;
        public FrmQuanLyPhongHoc(Panel panel)
        {
            InitializeComponent();
            _panel = panel;
            phongHocPagination = new PhongHocPagination();
        }

        public void loadDSLopHoc()
        {
            dgv_phonghoc.DataSource = lh.DSLopHoc().Tables[0];
            dgv_phonghoc.Columns[0].HeaderText = "Mã lớp học";
            dgv_phonghoc.Columns[1].HeaderText = "Tên lớp học";
            dgv_phonghoc.Columns[2].HeaderText = "Mã MHDT";
            dgv_phonghoc.Columns[3].HeaderText = "Mã giảng viên";
            dgv_phonghoc.Columns[4].HeaderText = "Giới Hạn";
            dgv_phonghoc.Columns[5].HeaderText = "Tên Phòng";
            dgv_phonghoc.Columns[6].HeaderText = "Thứ";
            dgv_phonghoc.Columns[7].HeaderText = "Tiết Bắt Đầu";
            dgv_phonghoc.Columns[8].HeaderText = "Tiết Kết Thúc";
            dgv_phonghoc.Columns[9].HeaderText = "Thời Gian Bắt Đầu";
            dgv_phonghoc.Columns[10].HeaderText = "Thời gian Kết Thúc";
            dgv_phonghoc.Columns[11].HeaderText = "Học kỳ";
            dgv_phonghoc.Columns[12].HeaderText = "Năm";

            dgv_phonghoc.Columns[0].Width = 400;
        }


        private async void FrmQuanLyPhongHoc_Load(object sender, EventArgs e)
        {
            //loadDSLopHoc();
            await phongHocPagination.LoadDataAsync(dgv_phonghoc, lblPageNumber, linklbl_back, linklbl_next);
        }
        private async void FrmQuanLyPhongHoc_Load()
        {
            //();
            await phongHocPagination.LoadDataAsync(dgv_phonghoc, lblPageNumber, linklbl_back, linklbl_next);
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            _panel.Show();
        }

        private void btn_timkiemma_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_malophoc.Text == "")
                {
                    FrmQuanLyPhongHoc_Load();
                }
                else
                {
                    dgv_phonghoc.DataSource = lh.TimKiemLopHocTheoMH(txt_malophoc.Text).Tables[0];
                    dgv_phonghoc.Columns[0].HeaderText = "Mã Môn Học";
                    dgv_phonghoc.Columns[1].HeaderText = "Mã Lớp Học";
                    dgv_phonghoc.Columns[2].HeaderText = "Tên Giảng Viên";
                    dgv_phonghoc.Columns[3].HeaderText = "Giới Hạn";
                    dgv_phonghoc.Columns[4].HeaderText = "Tên Phòng";
                    dgv_phonghoc.Columns[5].HeaderText = "Thứ";
                    dgv_phonghoc.Columns[6].HeaderText = "Tiết Bắt Đầu";
                    dgv_phonghoc.Columns[7].HeaderText = "Tiết Kết Thúc";
                    dgv_phonghoc.Columns[8].HeaderText = "Thời Gian Bắt Đầu";
                    dgv_phonghoc.Columns[9].HeaderText = "Thời gian Kết Thúc";

                    dgv_phonghoc.Columns[0].Width = 400;

                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                if (dtp_batdau.Value < DateTime.Today || dtp_ketthuc.Value < DateTime.Today)
                {
                    MessageBox.Show("Ngày đã chọn nhỏ hơn ngày hiện tại.");
                }
                else
                {
                    string thoigianbatdau = dtp_batdau.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    string thoigianketthuc = dtp_ketthuc.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    if (string.IsNullOrWhiteSpace(txt_themmalophoc.Text) ||
                        string.IsNullOrWhiteSpace(txt_themtenlophoc.Text) ||
                        string.IsNullOrWhiteSpace(txt_themmaMHDT.Text) ||
                        string.IsNullOrWhiteSpace(txt_themgioihan.Text) ||
                        string.IsNullOrWhiteSpace(txt_themmagiaovien.Text) ||
                        string.IsNullOrWhiteSpace(txt_themphong.Text) ||
                        string.IsNullOrWhiteSpace(txt_themtietbandau.Text) ||
                        string.IsNullOrWhiteSpace(txt_themtietketthuc.Text) ||
                        string.IsNullOrWhiteSpace(txt_themhocky.Text) ||
                        string.IsNullOrWhiteSpace(txt_themnam.Text) ||
                        string.IsNullOrWhiteSpace(txt_themthu.Text)
                        )
                    {
                        MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        kq = lh.ThemLopHoc(ref err, txt_themmalophoc.Text, txt_themtenlophoc.Text, txt_themmaMHDT.Text, txt_themmagiaovien.Text, int.Parse(txt_themgioihan.Text), txt_themphong.Text,
                            txt_themthu.Text, int.Parse(txt_themtietbandau.Text), int.Parse(txt_themtietketthuc.Text), thoigianbatdau,
                            thoigianketthuc, txt_themhocky.Text, int.Parse(txt_themnam.Text));
                        if (kq)
                        {
                            txt_themmalophoc.Clear();
                            txt_themmaMHDT.Clear();
                            txt_themmagiaovien.Clear();
                            txt_themgioihan.Clear();
                            txt_themphong.Clear();
                            txt_themthu.Clear();
                            txt_themtietbandau.Clear();
                            txt_themtietketthuc.Clear();
                            txt_themhocky.Clear();
                            txt_themnam.Clear();

                            loadDSLopHoc();
                            MessageBox.Show("Đã thêm thành công!");
                        }
                        else
                        {
                            MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                err = "Không thể thêm!";
                MessageBox.Show(err);
            }
        }

        private void btn_xoamalop_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                if (txt_malophoc.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã lớp học cần xóa");
                }
                else
                {
                    kq = lh.XoaLopHoc(ref err, txt_malophoc.Text);
                    if (kq)
                    {
                        loadDSLopHoc();
                        MessageBox.Show("Đã xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (SqlException)
            {
                err = "Không thể thêm!";
                MessageBox.Show(err);
            }
        }

        private async void linklbl_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await phongHocPagination.PreviousPageAsync(dgv_phonghoc, lblPageNumber, linklbl_back, linklbl_next);
        }

        private async void linklbl_next_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await phongHocPagination.NextPageAsync(dgv_phonghoc, lblPageNumber, linklbl_back, linklbl_next);
        }
    }
}
