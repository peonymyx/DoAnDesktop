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
    public partial class FrmDanhSachBaiTapSinhVien : Form
    {
        private Form _parent;
        private Panel _panel;
        public FrmDanhSachBaiTapSinhVien(Form parent, Panel panel)
        {
            InitializeComponent();
            _parent = parent;
            _panel = panel;
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
