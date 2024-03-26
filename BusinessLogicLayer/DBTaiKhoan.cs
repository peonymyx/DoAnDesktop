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

        public void SinhVienConnect()
        {
            try
            {
                db.changeStrConnectToSinhVien();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GiangVienConnect()
        {
            try
            {
                db.changeStrConnectToGiangVien();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
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
                return builder.ToString();
            }
        }
        //Thực hiện đăng nhập
        public int DangNhap(string Mssv, string MatKhau)
        {
            try
            {
                string newPassWord = HashPassword(MatKhau);
                DataSet tk = db.ExecuteQueryDataSetParam($"Call RTO_DangNhap('{Mssv}', '{newPassWord}')", CommandType.Text);
                if (tk.Tables[0].Rows.Count == 0)
                    return 0; // Sai
                else if (tk.Tables[0].Rows[0].Field<string>("VaiTro") == "QUẢN LÝ")
                    return 1; // Trả về quản lý
                else if (tk.Tables[0].Rows[0].Field<string>("VaiTro") == "Sinh Viên")
                {
                    return 2; // Trả về sinh viên
                }
                else
                    return 3; // Trả về giảng viên
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Đổi mật khẩu
        public bool DoiMatKhau(ref string err, string Mssv, string MatKhau)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(MatKhau))
                {
                    throw new Exception("Mật khẩu không được để trống");
                }
                // Kiểm tra độ dài mật khẩu
                if (MatKhau.Length < 8)
                {
                    throw new Exception("Mật khẩu phải chứa ít nhất 8 ký tự");
                }
                // Kiểm tra có ít nhất một ký tự in hoa
                if (!MatKhau.Any(char.IsUpper))
                {
                    throw new Exception("Mật khẩu phải chứa ít nhất một ký tự in hoa");
                }
                // Kiểm tra có ít nhất một chữ số
                if (!MatKhau.Any(char.IsDigit))
                {
                    throw new Exception("Mật khẩu phải chứa ít nhất một chữ số");
                }
                // Kiểm tra có ít nhất một ký tự đặc biệt
                if (!MatKhau.Any(ch => !char.IsLetterOrDigit(ch)))
                {
                    throw new Exception("Mật khẩu phải chứa ít nhất một ký tự đặc biệt");
                }
                string newPassWord = HashPassword(MatKhau);
                return db.MyExecuteNonQuery("Re_DoiMatKhau", CommandType.StoredProcedure,
                    ref err, new MySqlParameter("p_MatKhau", newPassWord),
                    new MySqlParameter("p_TenDangNhap", Mssv));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
