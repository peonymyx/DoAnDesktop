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
        // Phương thức để lấy thông tin sinh viên bằng Mã số sinh viên (Mssv)
        public DataSet ThongTin(string Mssv)
        {
            try
            {
                // Thực thi stored procedure RTO_ThongTinSV để lấy thông tin sinh viên bằng Mã số sinh viên
                return db.ExecuteQueryDataSetParam($"CALL RTO_ThongTinSV('{Mssv}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để lấy danh sách học phần của sinh viên theo chương trình đào tạo (CTDT) bằng Mã số sinh viên (Mssv)
        public DataSet HocPhanCTDTSV(string Mssv)
        {
            try
            {
                // Thực thi stored procedure RTM_HocPhanCTDTSV để lấy danh sách học phần của sinh viên theo chương trình đào tạo (CTDT) bằng Mã số sinh viên
                return db.ExecuteQueryDataSetParam($"CALL RTM_HocPhanCTDTSV('{Mssv}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để lấy danh sách sinh viên đã đăng ký môn học
        public DataSet DSSinhVienDKMH()
        {
            try
            {
                // Thực thi stored procedure NonP_DanhSachDKMH để lấy danh sách sinh viên đã đăng ký môn học
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachDKMH()", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để mã hóa mật khẩu bằng thuật toán SHA256
        static string HashPassword(string password)
        {
            // Sử dụng đối tượng SHA256 để tạo mã băm
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

        // Phương thức để thêm sinh viên vào cơ sở dữ liệu
        public bool ThemSV(ref string err, string TenDangNhap, string MatKhau, string HoTenSV, string GioiTinh, string NgaySinh, string MaLop)
        {
            try
            {
                // Mã hóa mật khẩu trước khi thêm vào cơ sở dữ liệu
                string hashedPassword = HashPassword(MatKhau);

                // Tạo mảng các tham số
                MySqlParameter[] parameters = {
            new MySqlParameter("p_TenDangNhap", TenDangNhap),
            new MySqlParameter("p_MatKhau", hashedPassword), // Sử dụng mật khẩu đã được mã hóa
            new MySqlParameter("p_HoTenSV", HoTenSV),
            new MySqlParameter("p_GioiTinh", GioiTinh),
            new MySqlParameter("p_NgaySinh", NgaySinh),
            new MySqlParameter("p_MaLop", MaLop)
        };

                // Thực thi stored procedure Re_ThemSinhVien để thêm sinh viên vào cơ sở dữ liệu
                return db.MyExecuteNonQuery($"CALL Re_ThemSinhVien('{TenDangNhap}','{hashedPassword}','{HoTenSV}','{GioiTinh}','{NgaySinh}','{MaLop}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }
        // Phương thức để xóa sinh viên khỏi cơ sở dữ liệu
        public bool XoaSV(ref string err, string mssv)
        {
            try
            {
                // Tạo mảng các tham số
                MySqlParameter[] parameters = {
            new MySqlParameter("p_mssv", mssv)
        };

                // Thực thi stored procedure Re_XoaSinhVien để xóa sinh viên khỏi cơ sở dữ liệu
                return db.MyExecuteNonQuery($"CALL Re_XoaSinhVien('{mssv}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để cập nhật thông tin của sinh viên trong cơ sở dữ liệu
        public bool CapNhatSV(ref string err, string TenDangNhap, string HoTenSV, string GioiTinh, string NgaySinh, string MaLop, string Tinhtrang)
        {
            try
            {
                // Tạo mảng các tham số
                MySqlParameter[] parameters = {
            new MySqlParameter("p_TenDangNhap", TenDangNhap),
            new MySqlParameter("p_HoTenSV", HoTenSV),
            new MySqlParameter("p_GioiTinh", GioiTinh),
            new MySqlParameter("p_NgaySinh", NgaySinh),
            new MySqlParameter("p_MaLop", MaLop),
            new MySqlParameter("p_Tinhtrang", Tinhtrang)
        };

                // Thực thi stored procedure Re_CapNhatSinhVien để cập nhật thông tin của sinh viên trong cơ sở dữ liệu
                return db.MyExecuteNonQuery($"CALL Re_CapNhatSinhVien('{TenDangNhap}','{HoTenSV}','{GioiTinh}','{NgaySinh}','{MaLop}','{Tinhtrang}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

    }
}
