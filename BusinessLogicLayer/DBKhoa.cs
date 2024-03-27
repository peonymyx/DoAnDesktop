using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using MySqlConnector;

namespace BusinessLogicLayer
{
    public class DBKhoa
    {
        private DAL db;
        public DBKhoa()
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

        // Tính tổng số sinh viên của một khoa
        public int TongSVKhoa(string tenkhoa)
        {
            try
            {
                // Tạo một tham số MySQL
                MySqlParameter parameter = new MySqlParameter("p_khoa", tenkhoa);
                // Tạo câu truy vấn để lấy tổng số sinh viên của một khoa
                string query = $"SELECT RNO_TongSVKhoa('{tenkhoa}')";
                // Thực thi hàm scalar và trả về kết quả
                return db.MyExecuteScalarFunction(query, CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Lấy danh sách sinh viên của một khoa
        public DataSet DanhSachSVKhoa(String khoa)
        {
            try
            {
                // Tạo một tham số MySQL
                MySqlParameter parameter = new MySqlParameter("p_khoa", khoa);
                // Thực thi stored procedure RTM_DSSVKhoa để lấy danh sách sinh viên của một khoa
                return db.ExecuteQueryDataSet($"CALL RTM_DSSVKhoa('{khoa}')", CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Lấy danh sách các khoa từ cơ sở dữ liệu
        public DataSet DanhSachKhoa()
        {
            try
            {
                // Thực thi stored procedure RTO_DanhSachKhoa để lấy danh sách các khoa
                return db.ExecuteQueryDataSetParam($"CALL RTO_DanhSachKhoa()", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Tìm kiếm thông tin khoa dựa trên tên khoa
        public DataSet TimKiemKhoa(String khoa)
        {
            try
            {
                // Tạo một tham số MySQL
                MySqlParameter parameter = new MySqlParameter("p_khoa", khoa);
                // Thực thi stored procedure RTO_TimKiemKhoa để tìm kiếm thông tin khoa dựa trên tên khoa
                return db.ExecuteQueryDataSet($"CALL RTO_TimKiemKhoa('{khoa}')", CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Thêm một khoa mới vào cơ sở dữ liệu
        public bool ThemKhoa(ref string err, string MaKhoa, string TenKhoa)
        {
            try
            {
                // Tạo một mảng các tham số MySQL
                MySqlParameter[] parameters =
                {
            new MySqlParameter("p_MaKhoa", MaKhoa),
            new MySqlParameter("p_TenKhoa", TenKhoa)
        };
                // Thực thi stored procedure Re_ThemKhoa để thêm một khoa mới
                return db.MyExecuteNonQuery($"CALL Re_ThemKhoa('{MaKhoa}','{TenKhoa}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Xóa một khoa khỏi cơ sở dữ liệu dựa trên mã khoa
        public bool XoaKhoa(ref string err, string MaKhoa)
        {
            try
            {
                // Tạo một tham số MySQL
                MySqlParameter parameter = new MySqlParameter("p_MaKhoa", MaKhoa);
                // Thực thi stored procedure Re_XoaKhoa để xóa một khoa
                return db.MyExecuteNonQuery($"CALL Re_XoaKhoa('{MaKhoa}')", CommandType.Text, ref err, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }
    }
}
