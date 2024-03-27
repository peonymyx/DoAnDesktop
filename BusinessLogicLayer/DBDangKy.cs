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
    public class DBDangKy
    {
        private DAL db;
        public DBDangKy()
        {
            db = new DAL();
        }

        // Kết nối đến cơ sở dữ liệu với quyền của sinh viên
        public void SinhVienConnect()
        {
            try
            {
                db.changeStrConnectToSinhVien();
            }
            catch (Exception ex)
            {
                // In ra thông báo lỗi nếu có lỗi xảy ra
                Console.WriteLine(ex.Message); // In ra thông báo lỗi nếu có lỗi xảy ra
            }
        }

        // Kết nối đến cơ sở dữ liệu với quyền của giảng viên
        public void GiangVienConnect()
        {
            try
            {
                db.changeStrConnectToGiangVien();
            }
            catch (Exception ex)
            {
                // In ra thông báo lỗi nếu có lỗi xảy ra
                Console.WriteLine(ex.Message); 
            }
        }

        // Kiểm tra thông tin bằng email
        public DataSet KiemTraEmail(string Email)
        {
            try
            {
                // Thực thi stored procedure Re_ThongTinByEmail để kiểm tra thông tin bằng email
                return db.ExecuteQueryDataSetParam($"CALL Re_ThongTinByEmail('{Email}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Đăng ký lớp học cho sinh viên
        public bool DangKyLH(ref string err, string MaLopHoc, string MaSV)
        {
            try
            {
                // Tạo một mảng các tham số MySQL
                MySqlParameter[] parameters = {
            new MySqlParameter("p_MaLopHoc", MaLopHoc),
            new MySqlParameter("p_MaSV", MaSV)
        };
                // Thực thi stored procedure Re_DangKyLH để đăng ký lớp học cho sinh viên
                return db.MyExecuteNonQuery($"CALL Re_DangKyLH('{MaLopHoc}','{MaSV}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Xóa đăng ký lớp học của sinh viên
        public bool XoaDangKyLH(ref string err, string MaLopHoc, string MaSV)
        {
            try
            {
                // Tạo một mảng các tham số MySQL
                MySqlParameter[] parameters = {
            new MySqlParameter("p_MaLopHoc", MaLopHoc),
            new MySqlParameter("p_MaSV", MaSV)
        };
                // Thực thi stored procedure Re_XoaDangKyLH để xóa đăng ký lớp học của sinh viên
                return db.MyExecuteNonQuery($"CALL Re_XoaDangKyLH('{MaLopHoc}','{MaSV}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }
    }
}
