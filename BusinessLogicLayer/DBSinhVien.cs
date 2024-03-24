using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using MySqlConnector;
using System.Security.Cryptography;


namespace BusinessLogicLayer
{

    public class DBSinhVien
    {
        private DAL db;
        public DBSinhVien()
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

        //Hiển thị thông tin sinh viên
        public DataSet ThongTin(string Mssv)
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTO_ThongTinSV('{Mssv}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet HocPhanCTDTSV(string Mssv)
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTM_HocPhanCTDTSV('{Mssv}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet DSSinhVienDKMH()
        {
            try
            {
                return db.ExecuteQueryDataSet("NonP_DanhSachDKMH", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
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
        public bool ThemSV(ref string err, string TenDangNhap, string MatKhau, string HoTenSV, string GioiTinh, string NgaySinh, string MaLop)
        {
            try
            {
                return db.MyExecuteNonQuery("Re_ThemSinhVien", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@TenDangNhap", TenDangNhap),
                new MySqlParameter("@MatKhau", HashPassword(MatKhau)),
                new MySqlParameter("@HoTenSV", HoTenSV),
                new MySqlParameter("@GioiTinh", GioiTinh),
                new MySqlParameter("@NgaySinh", NgaySinh),
                new MySqlParameter("@MaLop ", MaLop));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaSV(ref string err, string mssv)
        {
            try
            {
                return db.MyExecuteNonQuery("Re_XoaSinhVien", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@mssv", mssv));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CapNhatSV(ref string err, string TenDangNhap, string HoTenSV, string GioiTinh, string NgaySinh, string MaLop, string Tinhtrang)
        {        
            try
            {
                return db.MyExecuteNonQuery("Re_CapNhatSinhVien", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@TenDangNhap", TenDangNhap),
                new MySqlParameter("@HoTenSV", HoTenSV),
                new MySqlParameter("@GioiTinh", GioiTinh),
                new MySqlParameter("@NgaySinh", NgaySinh),
                new MySqlParameter("@MaLop ", MaLop),
                new MySqlParameter("@Tinhtrang", Tinhtrang));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
