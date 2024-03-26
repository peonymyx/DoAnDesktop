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
        private List<Image> imagePaths = new List<Image>
        {
            Properties.Resources.image1,
            Properties.Resources.image2,
            Properties.Resources.image3,

            // Thêm các đường dẫn hình ảnh khác tại đây
        };
        private int currentIndex = 0;
        private Timer timer;
        DBTaiKhoan tk = new DBTaiKhoan();
        public FrmDangNhap()
        {
            InitializeComponent();
            InitializeSlideshow();
        }

        private void InitializeSlideshow()
        {
            // Khởi tạo Timer với interval là 2000 milliseconds (2 giây)
            timer = new Timer();
            timer.Interval = 4000;
            timer.Tick += timer_slideanh_Tick;

            // Hiển thị hình ảnh đầu tiên khi form khởi động
            DisplayCurrentImage();

            // Bắt đầu slideshow
            timer.Start();
        }
        private void timer_slideanh_Tick(object sender, EventArgs e)
        {
            // Chuyển đổi đến hình ảnh tiếp theo
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

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            lblThongBao.ResetText();
            string err = "Sai tên người dùng hoặc mật khẩu! Vui lòng nhập lại!";
            int check = tk.DangNhap(txt_dangnhap.Text.Trim(), txt_matkhau.Text.Trim());
            if (check == 1)
            {
                FrmTrangAdmin ad = new FrmTrangAdmin(this);
                ad.MaSo = txt_dangnhap.Text.Trim();
                ad.Show();
                txt_dangnhap.ResetText();
                txt_matkhau.ResetText();
                this.Hide();
            }
            else if (check == 2)
            {
                FrmTrangSinhVien usr = new FrmTrangSinhVien(this);
                usr.MaSo = txt_dangnhap.Text.Trim();
                usr.Show();
                txt_dangnhap.ResetText();
                txt_matkhau.ResetText();
                this.Hide();
            }
            else if (check == 3)
            {
                FrmTrangGiangVien usr = new FrmTrangGiangVien(this);
                usr.MaSo = txt_dangnhap.Text.Trim();
                usr.Show();
                txt_dangnhap.ResetText();
                txt_matkhau.ResetText();
                this.Hide();
            }
            else // không đúng thì xuất ra thông báo!
            {
                lblThongBao.Text = err;
                txt_dangnhap.ResetText();
                txt_matkhau.ResetText();
                txt_dangnhap.Focus();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void chb_showmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_showmatkhau.Checked)
            {
                txt_matkhau.PasswordChar = (char)0;
            }
            else
            {
                txt_matkhau.PasswordChar = '*';
            }
        }

        private void linklbl_quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmQuenMatKhau frmQuenMatKhau = new FrmQuenMatKhau();
            frmQuenMatKhau.ShowDialog();
        }
    }
}
