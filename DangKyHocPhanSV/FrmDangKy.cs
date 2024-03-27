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
using Mysqlx;

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

        // Constructor của form đăng ký, nhận vào một panel cùng với mã sinh viên và mã môn học.
        public FrmDangKy(Panel panel, string maso, string mamh)
        {
            InitializeComponent();
            sv.SinhVienConnect(); // Kết nối với cơ sở dữ liệu của sinh viên
            lh.SinhVienConnect(); // Kết nối với cơ sở dữ liệu của lớp học
            dk.SinhVienConnect(); // Kết nối với cơ sở dữ liệu của đăng ký
            _panel = panel; // Gán panel nhận được từ tham số cho biến panel của form
            this.maso = maso; // Gán mã sinh viên từ tham số cho biến maso của form
            this.mamh = mamh; // Gán mã môn học từ tham số cho biến mamh của form
        }

        // Phương thức load dữ liệu của lớp học lên DataGridView
        public void loadLopHoc()
        {
            // Lấy danh sách lớp học dựa trên mã môn học và mã sinh viên, sau đó hiển thị lên DataGridView
            this.dgv_dangkymonhoc.DataSource = lh.DanhSachLH(this.mamh, this.maso).Tables[0];
            // Đặt tiêu đề cho các cột trong DataGridView
            dgv_dangkymonhoc.Columns[0].HeaderText = "Mã Lớp Học";
            dgv_dangkymonhoc.Columns[1].HeaderText = "Tên Giảng Viên";
            dgv_dangkymonhoc.Columns[2].HeaderText = "Giới Hạn";
            dgv_dangkymonhoc.Columns[3].HeaderText = "Tên Phòng";
            dgv_dangkymonhoc.Columns[4].HeaderText = "Thứ";
            dgv_dangkymonhoc.Columns[5].HeaderText = "Tiết Bắt Đầu";
            dgv_dangkymonhoc.Columns[6].HeaderText = "Tiết Kết Thúc";
            dgv_dangkymonhoc.Columns[7].HeaderText = "Thời Gian Bắt Đầu";
            dgv_dangkymonhoc.Columns[8].HeaderText = "Thời gian Kết Thúc";

            dgv_dangkymonhoc.Columns[1].Width = 150; // Đặt độ rộng cho cột "Tên Giảng Viên"
        }

        // Sự kiện Load của form, gọi phương thức loadLopHoc() để hiển thị danh sách lớp học khi form được load
        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            loadLopHoc();
        }

        // Sự kiện Click của nút "Quay lại", đóng form đăng ký và hiển thị lại panel chính
        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form đăng ký
            _panel.Show(); // Hiển thị lại panel chính
        }
        // Sự kiện Click của nút "Đăng ký"
        private void btn_dangky_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgv_dangkymonhoc.CurrentCell != null)
                {
                    // Lấy chỉ số dòng hiện tại của DataGridView
                    int index = dgv_dangkymonhoc.CurrentCell.RowIndex;
                    // Lấy mã lớp học từ ô tại cột 0 của dòng hiện tại
                    string malh = dgv_dangkymonhoc.Rows[index].Cells[0].Value.ToString();
                    bool kq = false; // Biến kiểm tra kết quả đăng ký
                    string err = ""; // Chuỗi thông báo lỗi
                    // Thực hiện đăng ký lớp học, truyền vào tham chiếu của chuỗi lỗi, mã lớp học và mã sinh viên
                    kq = dk.DangKyLH(ref err, malh, maso);

                    // Nếu đăng ký thành công, hiển thị thông báo
                    if (kq)
                    {
                        MessageBox.Show("Đã đăng ký thành công!");
                    }
                    else
                    {
                        // Nếu đăng ký không thành công, hiển thị thông báo lỗi
                        MessageBox.Show("Bạn đã đăng ký lớp học này rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show("Không có lớp học để đăng ký", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception error)
            {
                // Nếu xảy ra lỗi khi thao tác với cơ sở dữ liệu, hiển thị thông báo lỗi
                MessageBox.Show(error.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
