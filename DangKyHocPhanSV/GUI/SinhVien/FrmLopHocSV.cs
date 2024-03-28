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
    public partial class FrmLopHocSV : Form
    {
        private Panel _panelContainer;
        private Panel _panelHeader;
        private string _mssv;
        private string MaLH;
        DBChuong dbChuong = new DBChuong();
        DBBaiGiang dbBaiGiang = new DBBaiGiang();
        private Form currentFormChild;
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
        public FrmLopHocSV(string mssv, string malh, Panel panelHeader, Panel panelContainer)
        {
            InitializeComponent();
            _panelHeader = panelHeader;
            _panelContainer = panelContainer;
            MaLH = malh;
            _mssv = mssv;
        }

        public void loadDSC()
        {
            dgv_chuong.DataSource = dbChuong.DSChuong(MaLH).Tables[0];
            dgv_chuong.Columns[0].HeaderText = "Mã Chương Học";
            dgv_chuong.Columns[1].HeaderText = "Tiêu Đề Chương";
            dgv_chuong.Columns[0].Width = 55;
            dgv_chuong.Columns[1].Width = 383;
            dgv_chuong.Columns[2].Visible = false;
        }

        public void loadChuong()
        {
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

        private void btn_quaylai_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FrmDanhSachLopHocSV ds = new FrmDanhSachLopHocSV(_panelContainer, _panelHeader);
            ds.MaSo = _mssv;
            OpenChildForm(ds, _panelContainer);
        }

        private void chỉnhSửaBàiTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_chonchuong.SelectedItem != null)
                {
                    string tenChuong = tenChuong = cb_chonchuong.SelectedItem.ToString(); FrmDanhSachBaiTapSinhVien frmChinhSuaBaiTapGV = new FrmDanhSachBaiTapSinhVien(_mssv, IDChuong, tenChuong, menuS_chinhsuabaihoc);
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

        private void FrmLopHocSV_Load(object sender, EventArgs e)
        {
            loadDSC();
            loadChuong();
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

        private void cb_chonchuong_SelectedIndexChanged_1(object sender, EventArgs e)
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
    }
}
