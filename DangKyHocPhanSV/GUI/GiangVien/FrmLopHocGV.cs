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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DangKyHocPhanSV
{
    public partial class FrmLopHocGV : Form
    {
        private string maso;

        private Panel _panelContainer;
        private Panel _panelHeader;
        private Form currentFormChild;
        private string MaLH;
        DBChuong dbChuong = new DBChuong();
        DBBaiGiang dbBaiGiang = new DBBaiGiang();
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
        private string uploadedFilePath;
        public FrmLopHocGV(string maLH, Panel panelContainer, Panel panelHeader, string maso)
        {
            InitializeComponent();
            MaLH = maLH;
            _panelContainer = panelContainer;
            _panelHeader = panelHeader;
            this.maso = maso;
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
                txt_file.Text = openFileDialog.FileName;
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDanhSachLopHocGV ds = new FrmDanhSachLopHocGV(_panelContainer, _panelHeader);
            ds.MaSo = maso;
            OpenChildForm(ds, _panelContainer);
        }
        private void FrmLopHocGV_Load(object sender, EventArgs e)
        {
            loadDSC();
            loadChuong();
;       }
        public void loadDSC()
        {
            dgv_chuong.DataSource = dbChuong.DSChuong(MaLH).Tables[0];
            dgv_chuong.Columns[0].HeaderText = "Mã Chương Học";
            dgv_chuong.Columns[1].HeaderText = "Tiêu Đề Chương";
            dgv_chuong.Columns[0].Width = 55;
            dgv_chuong.Columns[1].Width = 383;
            dgv_chuong.Columns[2].Visible = false;
        }
        

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                if (string.IsNullOrWhiteSpace(txt_themchuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    kq = dbChuong.ThemChuong(ref err, txt_themchuong.Text, MaLH);
                    if (kq)
                    {
                        loadDSC();
                        MessageBox.Show("Đã thêm thành công!");
                        loadChuong();
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
            int ok = 0;
            try
            {
                if (string.IsNullOrWhiteSpace(txt_themchuong.Text) || string.IsNullOrWhiteSpace(txt_maCH.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (DataGridViewRow row in dgv_chuong.Rows)
                    {
                        if (row.Cells["MaChuongHoc"].Value != null && row.Cells["MaChuongHoc"].Value.ToString() == txt_maCH.Text)
                        {

                            kq = dbChuong.CapNhatChuong(ref err, int.Parse(txt_maCH.Text), txt_themchuong.Text);
                            if (kq)
                            {
                                loadDSC();
                                MessageBox.Show("Đã cập nhật thành công!");
                                ok = 1;
                                loadChuong();
                            }
                        }
                    }
                }
                if (ok == 0) MessageBox.Show("Không thể cập nhật!");
            }
            catch (SqlException)
            {
                err = "Không thể cập nhật!";
                MessageBox.Show(err);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                if (string.IsNullOrWhiteSpace(txt_maCH.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    kq = dbChuong.XoaChuong(ref err, txt_maCH.Text);
                    if (kq)
                    {
                        loadDSC();
                        MessageBox.Show("Đã xóa thành công!");
                        loadChuong();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa!");
                    }
                }
            }
            catch (SqlException)
            {
                err = "Không thể xóa!";
                MessageBox.Show(err);
            }
        }
        public void loadChuong()
        {
            cb_chonchuong.Items.Clear();
            dgv_chuong.DataSource = dbChuong.DSChuong(MaLH).Tables[0];
            List<string> chuong = new List<string>();
            foreach (DataGridViewRow row in dgv_chuong.Rows)
            {
                if (!row.IsNewRow)
                {
                    string value = row.Cells[1].Value as string;
                    if (!string.IsNullOrEmpty(value))
                    {
                        chuong.Add(value);
                    }
                }
            }
            cb_chonchuong.Items.AddRange(chuong.ToArray());
        }
        string IDChuong = "";
        private void cb_chonchuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string GiaTriChuong = cb_chonchuong.SelectedItem.ToString();
            dgv_chuong.DataSource = dbChuong.DSChuong(MaLH).Tables[0];
            foreach (DataGridViewRow row in dgv_chuong.Rows)
            {
                string giatri = row.Cells[1].Value as string;
                if (giatri == GiaTriChuong)
                {
                    IDChuong = row.Cells[0].Value.ToString();
                    loadBaiGiang();
                    break;// Thoát khỏi vòng lặp khi đã tìm thấy
                }
            }
        }
        public void loadBaiGiang()
        {
            dgv_listbaihoc.DataSource = dbBaiGiang.DanhSachBaiGiangTrongChuong(int.Parse(IDChuong)).Tables[0];
            dgv_listbaihoc.Columns[0].HeaderText = "ID Bài Giảng";
            dgv_listbaihoc.Columns[1].HeaderText = "Tiêu Đề Bài Giảng";
            dgv_listbaihoc.Columns[2].HeaderText = "Nội Dung Chương";
            dgv_listbaihoc.Columns[0].Width = 60;
            dgv_listbaihoc.Columns[1].Width = 300;
            dgv_listbaihoc.Columns[2].Width = 200;
            dgv_listbaihoc.Columns[3].Visible = false;
            dgv_listbaihoc.Update();
        }

        private void btn_themBG_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                if (string.IsNullOrWhiteSpace(txt_tieude.Text) || string.IsNullOrWhiteSpace(txt_file.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cb_chonchuong.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn chương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    kq = dbBaiGiang.ThemBaiGiang(ref err, txt_tieude.Text, txt_file.Text, int.Parse(IDChuong));
                    if (kq)
                    {
                        loadBaiGiang();
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

        private void btn_capnhatBG_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            int ok = 0;
            try
            {
                if (string.IsNullOrWhiteSpace(txt_IDBG.Text)  || string.IsNullOrWhiteSpace(txt_tieude.Text) || string.IsNullOrWhiteSpace(txt_file.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(cb_chonchuong.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn chương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (DataGridViewRow row in dgv_listbaihoc.Rows)
                    {
                        if (row.Cells["ID"].Value != null && row.Cells["ID"].Value.ToString() == txt_IDBG.Text)
                        {

                            kq = dbBaiGiang.CapNhatBaiGiang(ref err, int.Parse(txt_IDBG.Text), txt_tieude.Text, txt_file.Text);
                            if (kq)
                            {
                                loadBaiGiang();
                                MessageBox.Show("Đã cập nhật thành công!");
                                ok = 1;
                            }
                        }
                    }
                }
                if (ok == 0) MessageBox.Show("Không thể cập nhật!");
            }
            catch (SqlException)
            {
                err = "Không thể cập nhật!";
                MessageBox.Show(err);
            }
        }

        private void btn_xoaBG_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                if (string.IsNullOrWhiteSpace(txt_IDBG.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cb_chonchuong.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn chương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    kq = dbBaiGiang.XoaBaiGiang(ref err, int.Parse(txt_IDBG.Text));
                    if (kq)
                    {
                        loadBaiGiang();
                        MessageBox.Show("Đã xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa!");
                    }
                }
            }
            catch (SqlException)
            {
                err = "Không thể xóa!";
                MessageBox.Show(err);
            }
        }
        private void chinhSuaBaiTapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_chonchuong.SelectedItem != null)
                {
                    string tenChuong = tenChuong = cb_chonchuong.SelectedItem.ToString(); FrmChinhSuaBaiTapGV frmChinhSuaBaiTapGV = new FrmChinhSuaBaiTapGV(IDChuong, tenChuong, menuS_chinhsuabaihoc);
                    OpenChildForm(frmChinhSuaBaiTapGV, pn_lophoc);
                    menuS_chinhsuabaihoc.Hide();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn chương!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn chương!");
            }
        }
    }
}
