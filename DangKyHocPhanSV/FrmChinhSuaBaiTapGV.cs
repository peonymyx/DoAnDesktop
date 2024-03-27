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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DangKyHocPhanSV
{
    public partial class FrmChinhSuaBaiTapGV : Form
    {
        private string uploadedFilePath;
        DBBaiTap dbBaiTap = new DBBaiTap();
        DBNopBai dbNopBai = new DBNopBai();
        DBChuong dbChuong = new DBChuong();
        string IDChuong = "";
        string TenChuong = "";
        private MenuStrip m_menuStrip;
        public FrmChinhSuaBaiTapGV(string idChuong,string tenChuong, MenuStrip menuStrip)
        {
            InitializeComponent();
            IDChuong = idChuong;
            m_menuStrip = menuStrip;
            txt_chuong.Text = tenChuong;
        }

        private void btn_quaylai_Click_1(object sender, EventArgs e)
        {
            this.Close();
            m_menuStrip.Show();
        }
        private void FrmChinhSuaBaiTapGV_Load(object sender, EventArgs e)
        {
            loadBaiTap();
            loadListBaiTap();
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
        private void btn_taobaitap_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                string timeParse = dtp_hannop.Value.ToString("dd/MM/yyyy");
                kq = dbBaiTap.ThemBaiTap(ref err, txt_tieude.Text, txt_link.Text, int.Parse(IDChuong), timeParse);
                if (kq)
                {
                    loadBaiTap();
                    MessageBox.Show("Đã tạo thành công!");
                    loadListBaiTap();
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
        private void btn_capnhatbt_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            int ok = 0;
            try
            {
                foreach (DataGridViewRow row in dgv_baitap.Rows)
                {
                    if (row.Cells["BaiTapID"].Value != null && row.Cells["BaiTapID"].Value.ToString() == txt_IDBT.Text)
                    {
                        string timeParse = dtp_hannop.Value.ToString("dd/MM/yyyy");
                        kq = dbBaiTap.CapNhatBaiTap(ref err, int.Parse(txt_IDBT.Text), txt_tieude.Text, txt_link.Text, timeParse);
                        if (kq)
                        {
                            loadBaiTap();
                            MessageBox.Show("Đã cập nhật thành công!");
                            ok = 1;
                            loadListBaiTap();
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

        private void btn_xoabt_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = dbBaiTap.XoaBaiTap(ref err, int.Parse(txt_IDBT.Text));
                if (kq)
                {
                    loadBaiTap();
                    MessageBox.Show("Đã xóa thành công!");
                    loadListBaiTap();
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

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Files|*.doc;*.docx|PowerPoint Files|*.ppt;*.pptx|All Files|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadedFilePath = openFileDialog.FileName;
                txt_link.Text = openFileDialog.FileName;
                /*pictureBoxFileIcon.Image = uploadedFilePath.ToLower().EndsWith(".doc") || uploadedFilePath.ToLower().EndsWith(".docx") ?
                Properties.Resources.WordIcon :
                Properties.Resources.PowerPointIcon;*/
            }
        }
        public void loadListBaiTap()
        {
            cb_chonbt.Items.Clear();
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
        public void loadBaiNop()
        {
            dgv_bainop.DataSource = dbNopBai.DSSinhVienNopBai(int.Parse(IDBaiTap)).Tables[0];
            dgv_bainop.Columns[0].HeaderText = "Họ Tên Sinh Viên";
            dgv_bainop.Columns[1].HeaderText = "Tiêu Đề Bài Tập";
            dgv_bainop.Columns[2].HeaderText = "Nội Dung Bài Tập";
            dgv_bainop.Columns[0].Width = 150;
            dgv_bainop.Columns[1].Width = 150;
            dgv_bainop.Columns[2].Width = 100;
            dgv_bainop.Columns[3].Visible = false;
            dgv_bainop.Update();
        }
    }
}
