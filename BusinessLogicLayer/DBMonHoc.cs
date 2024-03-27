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
    public class DBMonHoc
    {
        private DAL db;
        public DBMonHoc()
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

        // Phương thức để lấy danh sách môn học
        public DataSet DSMonHoc()
        {
            try
            {
                // Thực thi stored procedure NonP_DanhSachMonHoc để lấy danh sách môn học
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachMonHoc()", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để tìm kiếm môn học dựa trên mã môn học
        public DataSet TimKiemMH(String mamh)
        {
            try
            {
                // Thực thi stored procedure RTO_TimKiemMonHoc để tìm kiếm môn học dựa trên mã môn học
                return db.ExecuteQueryDataSetParam($"CALL RTO_TimKiemMonHoc('{mamh}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để thêm môn học mới
        public bool ThemMonHoc(ref string err, string MaMH, string TenMH, int SoTinChi)
        {
            try
            {
                // Tạo mảng các tham số MySqlParameter để truyền vào stored procedure
                MySqlParameter[] parameters = {
            new MySqlParameter("p_MaMH", MaMH),
            new MySqlParameter("p_TenMH", TenMH),
            new MySqlParameter("p_SoTinChi", SoTinChi)
        };
                // Thực thi stored procedure Re_ThemMonHoc để thêm môn học mới
                return db.MyExecuteNonQuery($"CALL Re_ThemMonHoc('{MaMH}','{TenMH}','{SoTinChi}')", CommandType.Text, ref err, parameters);

            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để xóa môn học
        public bool XoaMonHoc(ref string err, string MaMH)
        {
            try
            {
                // Tạo mảng các tham số MySqlParameter để truyền vào stored procedure
                MySqlParameter[] parameters = {
            new MySqlParameter("p_MaMH", MaMH)
        };
                // Thực thi stored procedure Re_XoaMonHoc để xóa môn học
                return db.MyExecuteNonQuery($"CALL Re_XoaMonHoc('{MaMH}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

    }
}
