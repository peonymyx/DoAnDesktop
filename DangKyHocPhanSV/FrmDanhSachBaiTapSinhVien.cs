using BusinessLogicLayer;
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

namespace DangKyHocPhanSV
{
    public partial class FrmDanhSachBaiTapSinhVien : Form
    {
        private string _mssv;
        private MenuStrip m_menuStrip;
        DBBaiTap dbBaiTap = new DBBaiTap();
        DBNopBai dbNopBai = new DBNopBai();
        string IDChuong = "";
        string TenChuong = "";
        public FrmDanhSachBaiTapSinhVien(string mssv, string idChuong, string tenChuong, MenuStrip menuStrip)
        {
            InitializeComponent();
            m_menuStrip = menuStrip;
            IDChuong = idChuong;
            txt_chuong.Text = tenChuong;
            _mssv = mssv;
        }

        public void loadBaiTap()
        {
            dgv_baitap.DataSource = dbBaiTap.DSBaiTapTrongChuong(int.Parse(IDChuong)).Tables[0];
            dgv_baitap.Columns[0].HeaderText = "ID";
            dgv_baitap.Columns[1].HeaderText = "Tiêu Đề";
            dgv_baitap.Columns[2].HeaderText = "Nội Dung";
            dgv_baitap.Columns[3].Visible = false;
            dgv_baitap.Columns[4].HeaderText = "Hạn Nộp";
            dgv_baitap.Columns[0].Width = 50;
            dgv_baitap.Update();
            //dgv_chuong.Columns[1].Width = 300;
            //dgv_chuong.Columns[2].Visible = false;
        }

        public void loadListBaiTap()
        {
            dgv_baitap.DataSource = dbBaiTap.DSBaiTapTrongChuong(int.Parse(IDChuong)).Tables[0];
            List<string> baitap = new List<string>();
            foreach (DataGridViewRow row in dgv_baitap.Rows)
            {
                if (!row.IsNewRow)
                {
                    string value = row.Cells[1].Value as string;
                    if (!string.IsNullOrEmpty(value))
                    {
                        baitap.Add(value);
                    }
                }
            }
            cb_chonbt.Items.AddRange(baitap.ToArray());
        }
        string IDBaiTap = "";
        private void cb_chonbt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string GiaTriBaiTap = cb_chonbt.SelectedItem.ToString();
            dgv_baitap.DataSource = dbBaiTap.DSBaiTapTrongChuong(int.Parse(IDChuong)).Tables[0];
            foreach (DataGridViewRow row in dgv_baitap.Rows)
            {
                string giatri = row.Cells[1].Value as string;
                if (giatri == GiaTriBaiTap)
                {
                    IDBaiTap = row.Cells[0].Value.ToString();
                    loadBaiNop();
                    break;
                }
            }
        }

        private void btn_quaylai_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_quaylai_Click_2(object sender, EventArgs e)
        {
            this.Close();
            m_menuStrip.Show();
        }

        private void FrmDanhSachBaiTapSinhVien_Load(object sender, EventArgs e)
        {
            loadBaiTap();
            loadListBaiTap();
        }
        public void loadBaiNop()
        {
            dgv_bainop.DataSource = dbNopBai.LayBaiNopByMSSV(int.Parse(IDBaiTap),_mssv).Tables[0];
            dgv_bainop.Columns[0].HeaderText = "Mã Bài Nộp";
            dgv_bainop.Columns[1].HeaderText = "Mã Bài Tập";
            dgv_bainop.Columns[2].HeaderText = "Tên Bài Nộp";
            dgv_bainop.Columns[3].HeaderText = "Nội Dung Bài Nộp";
            dgv_bainop.Columns[4].Visible = false;
            dgv_bainop.Columns[5].HeaderText = "Thời Gian Nộp Bài";
            dgv_bainop.Columns[0].Width = 50;
            dgv_bainop.Columns[1].Width = 50;
            dgv_bainop.Columns[2].Width = 200;
            dgv_bainop.Update();
        }
        private void btn_nopbai_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                //id-tieude-link-masv
                kq = dbNopBai.ThemBaiNop(ref err, IDBaiTap, txt_ten.Text, txt_duongdan.Text, _mssv);
                if (kq)
                {
                    loadBaiNop();
                    MessageBox.Show("Đã tạo thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể tạo!");
                }

            }
            catch (SqlException)
            {
                err = "Không thể tạo!";
                MessageBox.Show(err);
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            int ok = 0;
            try
            {
                foreach (DataGridViewRow row in dgv_bainop.Rows)
                {
                    if (row.Cells["ID"].Value != null && row.Cells["ID"].Value.ToString() == txt_idbainop.Text)
                    {
                        kq = dbNopBai.CapNhatBaiNopBySV(ref err, int.Parse(txt_idbainop.Text), txt_ten.Text, txt_duongdan.Text);
                        if (kq)
                        {
                            loadBaiNop();
                            MessageBox.Show("Đã cập nhật thành công!");
                            ok = 1;
                        }
                    }
                }
                if (ok == 0) MessageBox.Show("Không thể cập nhật!");
            }
            catch (SqlException)
            {
                err = "Không thể tạo!";
                MessageBox.Show(err);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = dbNopBai.XoaBaiNop(ref err, int.Parse(txt_idbainop.Text));
                if (kq)
                {
                    loadBaiNop();
                    MessageBox.Show("Đã xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể xóa!");
                }
            }
            catch (SqlException)
            {
                err = "Không thể xóa!";
                MessageBox.Show(err);
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            m_menuStrip.Show();
        }
    }
}
