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
    public class DBLop
    {
        private DAL db;
        public DBLop()
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

        // Lấy danh sách các lớp từ cơ sở dữ liệu
        public DataSet DSLop()
        {
            try
            {
                // Thực thi stored procedure NonP_DanhSachLop để lấy danh sách các lớp
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachLop()", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Lấy danh sách sinh viên của một lớp dựa trên mã lớp
        public DataSet DSSinhVienLop(string malop)
        {
            try
            {
                // Thực thi stored procedure RTO_ThongTinSVLop để lấy danh sách sinh viên của một lớp dựa trên mã lớp
                return db.ExecuteQueryDataSetParam($"CALL RTO_ThongTinSVLop('{malop}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Thêm một lớp mới vào cơ sở dữ liệu
        public bool ThemLop(ref string err, string MaLop, string TenLop, string MaNganh, string MaCTDT)
        {
            try
            {
                // Tạo một mảng các tham số MySQL
                MySqlParameter[] parameters = {
            new MySqlParameter("p_MaLop", MaLop),
            new MySqlParameter("p_TenLop", TenLop),
            new MySqlParameter("p_MaNganh", MaNganh),
            new MySqlParameter("p_MaCTDT", MaCTDT)
        };
                // Thực thi stored procedure Re_ThemLop để thêm một lớp mới
                return db.MyExecuteNonQuery($"CALL Re_ThemLop('{MaLop}','{TenLop}','{MaNganh}','{MaCTDT}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Xóa một lớp khỏi cơ sở dữ liệu dựa trên mã lớp
        public bool XoaLop(ref string err, string MaLop)
        {
            try
            {
                // Tạo một mảng các tham số MySQL
                MySqlParameter[] parameters = {
            new MySqlParameter("p_MaLop", MaLop)
        };
                // Thực thi stored procedure Re_XoaLop để xóa một lớp
                return db.MyExecuteNonQuery($"CALL Re_XoaLop('{MaLop}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }
    }
}