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
    public partial class FrmDanhSachSinhVien : Form
    {
        public FrmDanhSachSinhVien(DataTable dataTable, string tenLop)
        {
            InitializeComponent();
            lbl_tenlophoc.Text = tenLop;
            dgv_danhsachsinhvien.DataSource = dataTable;
            dgv_danhsachsinhvien.Columns[0].HeaderText = "Mã Sinh Viên";
            dgv_danhsachsinhvien.Columns[1].HeaderText = "Họ và tên Sinh Viên";
            dgv_danhsachsinhvien.Columns[2].HeaderText = "Giới Tính";
            dgv_danhsachsinhvien.Columns[3].HeaderText = "Ngày Sinh";
            dgv_danhsachsinhvien.Columns[4].HeaderText = "Mã Lớp";

            dgv_danhsachsinhvien.Columns[1].Width = 150;
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
