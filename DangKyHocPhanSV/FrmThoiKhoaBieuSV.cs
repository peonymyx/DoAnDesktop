using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using System.Data.SqlClient;

namespace DangKyHocPhanSV
{
    public partial class FrmThoiKhoaBieuSV : Form
    {
        private string maso;
        DBLopHoc lh = new DBLopHoc();
        DBDangKy dk = new DBDangKy();
        private Panel _panel;
        private Form _parent;
        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmThoiKhoaBieuSV(Form parent, Panel panel)
        {
            InitializeComponent();
            lh.SinhVienConnect();
            _parent = parent;
            _panel = panel;
        }

        public void loadTKB()
        {
            this.dgv_thoikhoabieu.DataSource = lh.ThoiKhoaBieuSV(maso).Tables[0];
            dgv_thoikhoabieu.Columns[0].HeaderText = "Mã lớp học";
            dgv_thoikhoabieu.Columns[1].HeaderText = "Thứ";
            dgv_thoikhoabieu.Columns[2].HeaderText = "Tiết Bắt Đầu";
            dgv_thoikhoabieu.Columns[3].HeaderText = "Tiết Kết Thúc";
            dgv_thoikhoabieu.Columns[4].HeaderText = "Tên Phòng";
            dgv_thoikhoabieu.Columns[5].HeaderText = "Tên Môn Học";
            dgv_thoikhoabieu.Columns[6].HeaderText = "Tên Giảng Viên";

            dgv_thoikhoabieu.Columns[4].Width = 150;
            dgv_thoikhoabieu.Columns[5].Width = 150;
        }

        private void FrmThoiKhoaBieuSV_Load(object sender, EventArgs e)
        {
            loadTKB();
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            _panel.Show();
        }

        private void btn_xoalop_Click(object sender, EventArgs e)
        {
            int index = dgv_thoikhoabieu.CurrentCell.RowIndex;
            string malh = dgv_thoikhoabieu.Rows[index].Cells[0].Value.ToString();
            bool kq = false;
            string err = "";
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa lớp {malh}?", "Xóa lớp học", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    kq = dk.XoaDangKyLH(ref err, malh, maso);
                    if (kq)
                    {
                        MessageBox.Show("Đã xóa đăng ký thành công!");
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
            }
        }

        private void dgv_thoikhoabieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
