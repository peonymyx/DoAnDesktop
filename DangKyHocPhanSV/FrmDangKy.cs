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
    public partial class FrmDangKy : Form
    {
        private Panel _panel;
        private string maso;
        private string mamh;
        DBSinhVien sv = new DBSinhVien();
        DBLopHoc lh = new DBLopHoc();
        DBDangKy dk = new DBDangKy();

        // Thuộc tính MaSo dùng để lấy hoặc thiết lập mã số.
        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }

        // Thuộc tính Mamh dùng để lấy hoặc thiết lập mã môn học.
        public string Mamh
        {
            get { return mamh; }
            set { mamh = value; }
        }

        // Constructor FrmDangKy nhận một panel làm tham số và khởi tạo các thành phần trong form.
        public FrmDangKy(Panel panel)
        {
            InitializeComponent();

            // Kết nối với cơ sở dữ liệu của sinh viên, lớp học và đăng ký.
            sv.SinhVienConnect();
            lh.SinhVienConnect();
            dk.SinhVienConnect();

            // Gán panel được truyền vào cho biến _panel.
            _panel = panel;
        }

        // Phương thức loadLopHoc dùng để tải danh sách lớp học lên DataGridView.
        public void loadLopHoc()
        {
            // Lấy danh sách lớp học từ cơ sở dữ liệu và đặt nó làm nguồn dữ liệu cho DataGridView dgv_monhoc.
            this.dgv_monhoc.DataSource = lh.DanhSachLH(mamh, maso).Tables[0];

            // Đặt tiêu đề cho các cột trong DataGridView.
            dgv_monhoc.Columns[0].HeaderText = "Mã Lớp Học";
            dgv_monhoc.Columns[1].HeaderText = "Tên Giảng Viên";
            dgv_monhoc.Columns[2].HeaderText = "Giới Hạn";
            dgv_monhoc.Columns[3].HeaderText = "Tên Phòng";
            dgv_monhoc.Columns[4].HeaderText = "Thứ";
            dgv_monhoc.Columns[5].HeaderText = "Tiết Bắt Đầu";
            dgv_monhoc.Columns[6].HeaderText = "Tiết Kết Thúc";
            dgv_monhoc.Columns[7].HeaderText = "Thời Gian Bắt Đầu";
            dgv_monhoc.Columns[8].HeaderText = "Thời gian Kết Thúc";

            // Đặt kích thước cho cột Tên Giảng Viên.
            dgv_monhoc.Columns[1].Width = 150;
        }
        // Sự kiện Load của Form FrmDangKy được gọi khi form được load.
        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            // Gọi phương thức loadLopHoc để tải danh sách lớp học lên DataGridView khi form được load.
            loadLopHoc();
        }

        // Sự kiện Click của nút quay lại (btn_quaylai).
        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại và hiển thị lại panel trước đó.
            this.Close();
            _panel.Show();
        }

        // Sự kiện Click của nút đăng ký (btn_dangky).
        private void btn_dangky_Click(object sender, EventArgs e)
        {
            // Lấy chỉ số hàng hiện tại trong DataGridView.
            int index = dgv_monhoc.CurrentCell.RowIndex;
            // Lấy mã lớp học từ ô tại cột 0 và hàng được chọn.
            string malh = dgv_monhoc.Rows[index].Cells[0].Value.ToString();
            bool kq = false;
            string err = "";
            try
            {
                // Thực hiện đăng ký lớp học cho sinh viên.
                kq = dk.DangKyLH(ref err, malh, maso);
                if (kq)
                {
                    // Hiển thị thông báo khi đăng ký thành công.
                    MessageBox.Show("Đã đăng ký thành công!");
                }
                else
                {
                    // Hiển thị thông báo lỗi nếu có lỗi khi đăng ký.
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException error)
            {
                // Hiển thị thông báo lỗi nếu có lỗi SQL khi thực hiện đăng ký.
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
