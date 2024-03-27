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

namespace DangKyHocPhanSV
{
    public partial class FrmDangNhap : Form
    {
        // Danh sách đường dẫn của các hình ảnh được sử dụng trong slideshow.
        private List<Image> imagePaths = new List<Image>
{
    Properties.Resources.image1, // Đường dẫn của hình ảnh 1
    Properties.Resources.image2, // Đường dẫn của hình ảnh 2
    Properties.Resources.image3, // Đường dẫn của hình ảnh 3

    // Thêm các đường dẫn hình ảnh khác tại đây
};

        // Chỉ số của hình ảnh hiện tại đang được hiển thị trong slideshow.
        private int currentIndex = 0;

        // Timer được sử dụng để tự động chuyển đổi giữa các hình ảnh.
        private Timer timer;

        // Đối tượng truy cập cơ sở dữ liệu tài khoản.
        DBTaiKhoan tk = new DBTaiKhoan();

        // Constructor của Form FrmDangNhap.
        public FrmDangNhap()
        {
            InitializeComponent();
            InitializeSlideshow(); // Khởi tạo slideshow hình ảnh khi form được khởi tạo.
        }

        // Phương thức để khởi tạo slideshow.
        private void InitializeSlideshow()
        {
            // Khởi tạo Timer với interval là 4000 milliseconds (4 giây).
            timer = new Timer();
            timer.Interval = 4000;
            timer.Tick += timer_slideanh_Tick; // Gắn sự kiện Tick cho timer.

            // Hiển thị hình ảnh đầu tiên khi form được khởi động.
            DisplayCurrentImage();

            // Bắt đầu slideshow.
            timer.Start();
        }

        // Sự kiện Tick của Timer, được gọi mỗi khi timer đếm tới interval được thiết lập.
        private void timer_slideanh_Tick(object sender, EventArgs e)
        {
            // Chuyển đến hình ảnh tiếp theo trong danh sách.
            currentIndex = (currentIndex + 1) % imagePaths.Count;
            DisplayCurrentImage();
        }


        private void DisplayCurrentImage()
        {

            // Load hình ảnh từ đường dẫn
            Image image = imagePaths[currentIndex];

            // Đặt hình ảnh nền của Panel
            panel2.BackgroundImage = image;

            // Đảm bảo hình ảnh nằm vừa trong PictureBox và kích thước bằng với Panel
            pic_slideanh.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_slideanh.Image = image;
        }

        private void rdbtnShowPass_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Sự kiện Click của nút đăng nhập.
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            lblThongBao.ResetText(); // Đặt lại thông báo trước khi thực hiện đăng nhập.

            // Chuỗi thông báo mặc định khi tên người dùng hoặc mật khẩu không đúng.
            string err = "Sai tên người dùng hoặc mật khẩu! Vui lòng nhập lại!";

            // Kiểm tra đăng nhập và trả về kết quả.
            int check = tk.DangNhap(txt_dangnhap.Text.Trim(), txt_matkhau.Text.Trim());

            // Xử lý kết quả đăng nhập.
            if (check == 1) // Nếu là quản trị viên.
            {
                // Hiển thị Form Trang Admin và chuyển thông tin mã số người dùng.
                FrmTrangAdmin ad = new FrmTrangAdmin(this);
                ad.MaSo = txt_dangnhap.Text.Trim();
                ad.Show();
                txt_dangnhap.ResetText(); // Đặt lại trường nhập tên người dùng.
                txt_matkhau.ResetText(); // Đặt lại trường nhập mật khẩu.
                this.Hide(); // Ẩn Form đăng nhập.
            }
            else if (check == 2) // Nếu là sinh viên.
            {
                // Hiển thị Form Trang Sinh Viên và chuyển thông tin mã số người dùng.
                FrmTrangSinhVien usr = new FrmTrangSinhVien(this);
                usr.MaSo = txt_dangnhap.Text.Trim();
                usr.Show();
                txt_dangnhap.ResetText(); // Đặt lại trường nhập tên người dùng.
                txt_matkhau.ResetText(); // Đặt lại trường nhập mật khẩu.
                this.Hide(); // Ẩn Form đăng nhập.
            }
            else if (check == 3) // Nếu là giảng viên.
            {
                // Hiển thị Form Trang Giảng Viên và chuyển thông tin mã số người dùng.
                FrmTrangGiangVien usr = new FrmTrangGiangVien(this);
                usr.MaSo = txt_dangnhap.Text.Trim();
                usr.Show();
                txt_dangnhap.ResetText(); // Đặt lại trường nhập tên người dùng.
                txt_matkhau.ResetText(); // Đặt lại trường nhập mật khẩu.
                this.Hide(); // Ẩn Form đăng nhập.
            }
            else // Nếu không đúng thì xuất ra thông báo lỗi.
            {
                lblThongBao.Text = err; // Hiển thị thông báo lỗi.
                txt_dangnhap.ResetText(); // Đặt lại trường nhập tên người dùng.
                txt_matkhau.ResetText(); // Đặt lại trường nhập mật khẩu.
                txt_dangnhap.Focus(); // Di chuyển con trỏ tới trường nhập tên người dùng.
            }
        }
        // Sự kiện Click của nút thoát.
        private void btn_exit_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận trước khi thoát.
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit(); // Thoát ứng dụng nếu người dùng chọn "Có".
        }

        // Sự kiện CheckedChanged của ô kiểm hiển thị mật khẩu.
        private void chb_showmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_showmatkhau.Checked)
            {
                txt_matkhau.PasswordChar = (char)0; // Hiển thị mật khẩu nếu được chọn.
            }
            else
            {
                txt_matkhau.PasswordChar = '*'; // Ẩn mật khẩu nếu không được chọn.
            }
        }

        // Sự kiện LinkClicked của liên kết "Quên mật khẩu".
        private void linklbl_quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmQuenMatKhau frmQuenMatKhau = new FrmQuenMatKhau();
            frmQuenMatKhau.ShowDialog(); // Hiển thị Form Quên mật khẩu khi người dùng nhấp vào liên kết.
        }

        // Sự kiện KeyDown của trường nhập mật khẩu.
        private void txt_matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dangnhap.PerformClick(); // Thực hiện hành động của nút đăng nhập nếu người dùng nhấn phím Enter.
            }
        }
        // Sự kiện KeyPress của trường nhập tên đăng nhập.
        private void txt_dangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Ngăn chặn ký tự Enter hiển thị trong TextBox.
                txt_matkhau.Focus(); // Di chuyển sự kiện tới trường nhập mật khẩu nếu người dùng nhấn Enter.
            }
        }
    }
}