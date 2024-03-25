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
        public FrmLopHocSV()
        {
            InitializeComponent();
        }

        private void menustrip_xemdsbt_Click(object sender, EventArgs e)
        {
            FrmDanhSachBaiTapSinhVien frmDanhSachBaiTapSinhVien = new FrmDanhSachBaiTapSinhVien(this, pn_lophoc);
        }
    }
}
