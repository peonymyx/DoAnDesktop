using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using MySqlConnector;
using System.Collections;
using System.Security.Cryptography;
using Mysqlx;


namespace BusinessLogicLayer
{
    public class DBTaiKhoan
    {

        private DAL db;
        public DBTaiKhoan()
        {
            db = new DAL();
        }

        // Kết nối đến cơ sở dữ liệu với quyền của sinh viên
        public void SinhVienConnect()
        {
            try
            {
                // Thay đổi chuỗi kết nối để kết nối với tài khoản sinh viên
                db.changeStrConnectToSinhVien();
            }
            catch (Exception ex)
            {
                // In ra thông báo lỗi nếu có lỗi xảy ra
                Console.WriteLine(ex.Message);
            }
        }

        // Kết nối đến cơ sở dữ liệu với quyền của giảng viên
        public void GiangVienConnect()
        {
            try
            {
                // Thay đổi chuỗi kết nối để kết nối với tài khoản giảng viên
                db.changeStrConnectToGiangVien();
            }
            catch (Exception ex)
            {
                // In ra thông báo lỗi nếu có lỗi xảy ra
                Console.WriteLine(ex.Message);
            }
        }
        // Phương thức để mã hóa mật khẩu bằng thuật toán SHA256
        static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Mã hóa mật khẩu thành một mảng byte
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Chuyển đổi mảng byte thành một chuỗi hexa
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString(); // Trả về chuỗi mã hóa
            }
        }

        // Phương thức để thực hiện đăng nhập
        public int DangNhap(string Mssv, string MatKhau)
        {
            try
            {
                // Mã hóa mật khẩu
                string hashedPassword = HashPassword(MatKhau);

                // Thực hiện truy vấn đăng nhập
                DataSet tk = db.ExecuteQueryDataSetParam($"Call RTO_DangNhap('{Mssv}', '{hashedPassword}')", CommandType.Text);

                // Kiểm tra kết quả trả về từ truy vấn
                if (tk.Tables[0].Rows.Count == 0)
                    return 0; // Sai thông tin đăng nhập
                else if (tk.Tables[0].Rows[0].Field<string>("VaiTro") == "QUẢN LÝ")
                    return 1; // Đăng nhập thành công với vai trò quản lý
                else if (tk.Tables[0].Rows[0].Field<string>("VaiTro") == "Sinh Viên")
                    return 2; // Đăng nhập thành công với vai trò sinh viên
                else
                    return 3; // Đăng nhập thành công với vai trò giảng viên
            }
            catch (Exception ex)
            {
                throw ex; // Ném lại exception nếu có lỗi xảy ra
            }
        }

        // Phương thức để thay đổi mật khẩu
        public bool DoiMatKhau(ref string err, string MaSo, string MatKhau)
        {
            try
            {
                // Kiểm tra xem mật khẩu có rỗng hoặc chỉ chứa khoảng trắng không
                if (string.IsNullOrWhiteSpace(MatKhau))
                {
                    throw new Exception("Mật khẩu không được để trống");
                }
                // Kiểm tra độ dài của mật khẩu
                if (MatKhau.Length < 8)
                {
                    throw new Exception("Mật khẩu phải chứa ít nhất 8 ký tự");
                }
                // Kiểm tra xem mật khẩu có chứa ít nhất một ký tự in hoa không
                if (!MatKhau.Any(char.IsUpper))
                {
                    throw new Exception("Mật khẩu phải chứa ít nhất một ký tự in hoa");
                }
                // Kiểm tra xem mật khẩu có chứa ít nhất một chữ số không
                if (!MatKhau.Any(char.IsDigit))
                {
                    throw new Exception("Mật khẩu phải chứa ít nhất một chữ số");
                }
                // Kiểm tra xem mật khẩu có chứa ít nhất một ký tự đặc biệt không
                if (!MatKhau.Any(ch => !char.IsLetterOrDigit(ch)))
                {
                    throw new Exception("Mật khẩu phải chứa ít nhất một ký tự đặc biệt");
                }
                // Mã hóa mật khẩu mới
                string newPassWord = HashPassword(MatKhau);
                MySqlParameter[] parameters = {
                    new MySqlParameter("@MatKhau", newPassWord),
                    new MySqlParameter("@TenDangNhap", MaSo)
                };
                return db.MyExecuteNonQuery($"CALL Re_DoiMatKhau('{newPassWord}','{MaSo}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw; // Ném lại exception nếu có lỗi xảy ra
            }
        }

    }
    
}