using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using MySqlConnector;

namespace BusinessLogicLayer
{
    public class DBGiangVien
    {
        private DAL db;
        public DBGiangVien()
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

        // Lấy danh sách giảng viên từ cơ sở dữ liệu
        public DataSet DSGiangVien()
        {
            try
            {
                // Thực thi stored procedure NonP_DanhSachGV để lấy danh sách giảng viên
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachGV()", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Lấy thông tin của một giảng viên dựa trên mã giảng viên
        public DataSet ThongTinGV(string magv)
        {
            try
            {
                // Thực thi stored procedure RTO_ThongTinGV để lấy thông tin của một giảng viên
                return db.ExecuteQueryDataSetParam($"CALL RTO_ThongTinGV('{magv}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Thêm một giảng viên mới vào cơ sở dữ liệu
        public bool ThemGV(ref string err, string TenDangNhap, string MatKhau, string HoTenGV, string MaKhoa, string Email)
        {
            try
            {
                // Tạo một mảng các tham số MySQL
                MySqlParameter[] parameters =
                {
            new MySqlParameter("p_TenDangNhap", TenDangNhap),
            new MySqlParameter("p_MatKhau", MatKhau),
            new MySqlParameter("p_HoTenGV", HoTenGV),
            new MySqlParameter("p_MaKhoa", MaKhoa),
            new MySqlParameter("p_Email", Email)
        };
                // Thực thi stored procedure Re_ThemGiangVien để thêm một giảng viên mới
                return db.MyExecuteNonQuery($"CALL Re_ThemGiangVien('{TenDangNhap}','{MatKhau}','{HoTenGV}','{MaKhoa}','{Email}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Xóa một giảng viên khỏi cơ sở dữ liệu dựa trên mã giảng viên
        public bool XoaGV(ref string err, string magv)
        {
            try
            {
                // Tạo một tham số MySQL
                MySqlParameter parameter = new MySqlParameter("p_MaGV", magv);
                // Thực thi stored procedure Re_XoaGiangVien để xóa một giảng viên
                return db.MyExecuteNonQuery($"CALL Re_XoaGiangVien('{magv}')", CommandType.Text, ref err, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }
    }
}