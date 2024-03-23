using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLogicLayer;

namespace DangKyHocPhanSV
{
    public partial class FrmDoiMatKhauSV : Form
    {
        private string maso;
        DBTaiKhoan tk = new DBTaiKhoan();

        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmDoiMatKhauSV()
        {
            InitializeComponent();
            tk.SinhVienConnect();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string matKhauMoi = txt_mkmoi.Text;
            string err = "";
            try
            {
                kq = tk.DoiMatKhau(ref err, maso, matKhauMoi);
                if (kq)
                {
                    MessageBox.Show("Đã đổi mật khẩu thành công!");
                }
                else
                {
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_mkmoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_mkmoi_Click(object sender, EventArgs e)
        {

        }
    }
}
