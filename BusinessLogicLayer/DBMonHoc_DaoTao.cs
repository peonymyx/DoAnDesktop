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
    public class DBMonHoc_DaoTao
    {
        private DAL db;
        public DBMonHoc_DaoTao()
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

        // Phương thức để lấy danh sách môn học đào tạo
        public DataSet DSMHDT()
        {
            try
            {
                // Thực thi stored procedure NonP_DanhSachMHDT để lấy danh sách môn học đào tạo
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachMHDT()", CommandType.Text);

            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để tìm kiếm môn học đào tạo
        public DataSet TimKiemMHDT(String mamhdt)
        {
            try
            {
                // Thực thi stored procedure RTO_TimKiemMHDT để tìm kiếm môn học đào tạo
                return db.ExecuteQueryDataSetParam($"CALL RTO_TimKiemMHDT('{mamhdt}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }


        // Phương thức để thêm môn học đào tạo
        public bool ThemMHDT(ref string err, string MaMHDT, string MaMH, string MaCTDT, string MaNganh)
        {
            try
            {
                // Tạo mảng các tham số để truyền vào stored procedure Re_ThemMHDT
                MySqlParameter[] parameters = {
            new MySqlParameter("p_MaMHDT", MaMHDT),
            new MySqlParameter("p_MaMH", MaMH),
            new MySqlParameter("p_MaCTDT", MaCTDT),
            new MySqlParameter("p_MaNganh", MaNganh)
        };
                // Thực thi stored procedure Re_ThemMHDT để thêm môn học đào tạo
                return db.MyExecuteNonQuery($"CALL Re_ThemMHDT('{MaMHDT}','{MaMH}','{MaCTDT}','{MaNganh}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để xóa môn học đào tạo
        public bool XoaMHDT(ref string err, string MaMHDT)
        {
            try
            {
                // Tạo mảng các tham số để truyền vào stored procedure Re_XoaMHDT
                MySqlParameter[] parameters = {
            new MySqlParameter("p_MaMHDT", MaMHDT)
        };
                // Thực thi stored procedure Re_XoaMHDT để xóa môn học đào tạo
                return db.MyExecuteNonQuery($"CALL Re_XoaMHDT('{MaMHDT}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

    }
}
