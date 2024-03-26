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
    public partial class FrmChinhSuaBaiTapGV : Form
    {
        private MenuStrip m_menuStrip;
        private Panel _panel;
        private string uploadedFilePath;
        DBBaiTap dbBaiTap = new DBBaiTap();
        DBChuong dbChuong = new DBChuong();
        string IDChuong = "";
        string TenChuong = "";
        public FrmChinhSuaBaiTapGV(Panel panel, string idChuong,string tenChuong, MenuStrip menuStrip)
        {
            InitializeComponent();
            _panel = panel;
            IDChuong = idChuong;
            m_menuStrip = menuStrip;
            txt_chuong.Text = tenChuong;
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

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_taobaitap_Click(object sender, EventArgs e)
        {

        }

        private void btn_quaylai_Click_1(object sender, EventArgs e)
        {
            this.Close();
            _panel.Show();
            m_menuStrip.Show();
        }
        private void FrmChinhSuaBaiTapGV_Load(object sender, EventArgs e)
        {
            loadBaiTap();
        }

        public void loadBaiTap()
        {
            dgv_baitap.DataSource = dbBaiTap.DSBaiTapTrongChuong(IDChuong).Tables[0];
            dgv_baitap.Columns[0].HeaderText = "ID";
            dgv_baitap.Columns[1].HeaderText = "Tiêu Đề";
            dgv_baitap.Columns[2].HeaderText = "Nội Dung";
            dgv_baitap.Columns[3].Visible = false;
            dgv_baitap.Columns[2].HeaderText = "Hạn Nộp";
            dgv_baitap.Update();
            //dgv_baitap.Columns[0].Width = 90;
            //dgv_chuong.Columns[1].Width = 300;
            //dgv_chuong.Columns[2].Visible = false;
        }
        private void btn_taobaitap_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_capnhatbt_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoabt_Click(object sender, EventArgs e)
        {

        }
    }
}
