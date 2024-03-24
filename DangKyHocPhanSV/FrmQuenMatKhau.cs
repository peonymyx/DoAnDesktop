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
    public partial class FrmQuenMatKhau : Form
    {
        public FrmQuenMatKhau()
        {
            InitializeComponent();
        }


        private void btn_tieptheo_Click_1(object sender, EventArgs e)
        {
            if (true)
            {
                if (true)
                {
                    FrmDoiMatKhauSV frmDoiMatKhauSV = new FrmDoiMatKhauSV();
                    frmDoiMatKhauSV.ShowDialog();
                }
                else
                {
                    FrmDoiMatKhauGV frmDoiMatKhauGV = new FrmDoiMatKhauGV();
                    frmDoiMatKhauGV.ShowDialog();
                }
            }
            else
            {

            }
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
