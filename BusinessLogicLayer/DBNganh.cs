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
    public class DBNganh
    {
        private DAL db;
        public DBNganh()
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

        // Phương thức để tính tổng số sinh viên của một ngành
        public int TongSVNganh(string nganh)
        {
            try
            {
                // Tạo tham số để truyền vào stored procedure RNO_TongSVNganh
                MySqlParameter parameter = new MySqlParameter("p_nganh", nganh);
                // Tạo câu lệnh SQL để gọi hàm trong MySQL và trả về tổng số sinh viên của một ngành
                string query = $"SELECT RNO_TongSVNganh('{nganh}')";
                // Thực thi hàm và trả về kết quả
                return db.MyExecuteScalarFunction(query, CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để lấy danh sách sinh viên của một ngành
        public DataSet DanhSachSVNganh(string nganh)
        {
            try
            {
                // Thực thi stored procedure RTM_DSSVNganh để lấy danh sách sinh viên của một ngành
                return db.ExecuteQueryDataSetParam($"CALL RTM_DSSVNganh('{nganh}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để tìm kiếm ngành
        public DataSet TimKiemNganh(string nganh)
        {
            try
            {
                // Thực thi stored procedure RTO_TimKiemNganh để tìm kiếm ngành
                return db.ExecuteQueryDataSetParam($"CALL RTO_TimKiemNganhTheoTen('{nganh}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }
        // Phương thức để lấy danh sách các ngành
        public DataSet DanhSachNganh()
        {
            try
            {
                // Thực thi stored procedure RTO_DanhSachNganh để lấy danh sách các ngành
                return db.ExecuteQueryDataSetParam($"CALL RTO_DanhSachNganh()", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để thêm một ngành mới
        public bool ThemNganh(ref string err, string MaNganh, string TenNganh, string MaKhoa)
        {
            try
            {
                // Tạo mảng các tham số để truyền vào stored procedure Re_ThemNganh
                MySqlParameter[] parameters =
                {
            new MySqlParameter("p_MaNganh", MaNganh),
            new MySqlParameter("p_TenNganh", TenNganh),
            new MySqlParameter("p_MaKhoa", MaKhoa)
        };
                // Thực thi stored procedure Re_ThemNganh để thêm một ngành mới
                return db.MyExecuteNonQuery($"CALL Re_ThemNganh('{MaNganh}','{TenNganh}','{MaKhoa}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để xóa một ngành
        public bool XoaNganh(ref string err, string MaNganh)
        {
            try
            {
                // Tạo mảng tham số để truyền vào stored procedure Re_XoaNganh
                MySqlParameter[] parameters = {
            new MySqlParameter("p_MaNganh", MaNganh)
        };
                // Thực thi stored procedure Re_XoaNganh để xóa một ngành
                return db.MyExecuteNonQuery($"CALL Re_XoaNganh('{MaNganh}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        
        public bool CapNhatNganh(ref string err, string MaNganh, string TenNganh, string MaKhoa)
        {
            try
            {
                // Tạo mảng các tham số để truyền vào stored procedure Re_ThemNganh
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("p_MaNganh", MaNganh),
                    new MySqlParameter("p_TenNganh", TenNganh),
                    new MySqlParameter("p_MaKhoa", MaKhoa)
                };
                // Thực thi stored procedure Re_CapNhatNganh để thêm một ngành mới
                return db.MyExecuteNonQuery($"CALL Re_CapNhatNganh('{MaNganh}','{TenNganh}','{MaKhoa}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }
    }
}