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
    public partial class FrmQuenMatKhau : Form
    {
        DBDangKy dk = new DBDangKy();
        public FrmQuenMatKhau()
        {
            InitializeComponent();
        }
        private void btn_tieptheo_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = dk.KiemTraEmail(txt_email.Text);
                string Ma = "";
                if (ds != null && ds.Tables[0].Rows.Count != 0)
                {
                    Ma = ds.Tables[0].Rows[0]["Ma"].ToString();
                    FrmDoiMatKhauSV frmDoiMatKhauSV = new FrmDoiMatKhauSV(Ma);
                    frmDoiMatKhauSV.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //this.Hide();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
