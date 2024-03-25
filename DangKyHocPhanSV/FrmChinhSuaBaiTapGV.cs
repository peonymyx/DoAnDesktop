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
        private Panel _panel;
        private string uploadedFilePath;
        public FrmChinhSuaBaiTapGV(Panel panel)
        {
            InitializeComponent();
            _panel = panel;
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
        }

        private void btn_taobaitap_Click_1(object sender, EventArgs e)
        {

        }
    }
}
