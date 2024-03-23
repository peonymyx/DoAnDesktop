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
            db.changeStrConnectToSinhVien();
        }

        public void GiangVienConnect()
        {
            db.changeStrConnectToGiangVien();
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
            string newPassWord = HashPassword(MatKhau);
            DataSet tk = db.ExecuteQueryDataSet($"Call RTO_DangNhap('{Mssv}', '{newPassWord}')", CommandType.Text);
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

        //Đổi mật khẩu
        public bool DoiMatKhau(ref string err, string Mssv, string MatKhau)
        {
            string newPassWord = HashPassword(MatKhau);
            return db.MyExecuteNonQuery("Re_DoiMatKhau", CommandType.StoredProcedure,
                ref err, new MySqlParameter("p_MatKhau", newPassWord),
                new MySqlParameter("p_TenDangNhap", Mssv));
        }

    }
}
