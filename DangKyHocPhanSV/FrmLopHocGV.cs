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
    public partial class FrmLopHocGV : Form
    {
        private Form currentFormChild;
        private string MaLH;
        DBChuong dbChuong = new DBChuong();
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
        public FrmLopHocGV(string maLH)
        {
            InitializeComponent();
            MaLH = maLH;
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

        private void chỉnhSửaBàiTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChinhSuaBaiTapGV frmChinhSuaBaiTapGV = new FrmChinhSuaBaiTapGV(pn_listtuan);
            OpenChildForm(frmChinhSuaBaiTapGV, pn_lophoc);
            pn_listtuan.Hide();
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmLopHocGV_Load(object sender, EventArgs e)
        {
            loadDSC();        
        }
        public void loadDSC()
        {
            dgv_chuong.DataSource =dbChuong.DSChuong(MaLH).Tables[0];
            dgv_chuong.Columns[0].HeaderText = "Mã Chương Học";
            dgv_chuong.Columns[1].HeaderText = "Tiêu Đề Chương";
            dgv_chuong.Columns[0].Width = 70;
            dgv_chuong.Columns[1].Width = 300;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = dbChuong.ThemChuong(ref err, txt_themchuong.Text, MaLH);
                if (kq)
                {
                    loadDSC();
                    MessageBox.Show("Đã thêm thành công!");
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
                        }
                    }
                }
                if(ok==0) MessageBox.Show("Không thể cập nhật!");
            }
            catch (SqlException)
            {
                err = "Không thể cập nhật!";
                MessageBox.Show(err);
            }
        }
    }
}
