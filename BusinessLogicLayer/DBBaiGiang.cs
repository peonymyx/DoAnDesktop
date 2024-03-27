using DataAccessLayer;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DBBaiGiang
    {
        private DAL db;
        public DBBaiGiang()
        {
            db = new DAL();
        }
        // Lấy danh sách bài giảng trong một chương theo mã chương
        public DataSet DanhSachBaiGiangTrongChuong(int MaChuong)
        {
            try
            {
                // Thực thi stored procedure NonP_DanhSachBaiGiangTrongChuong với tham số MaChuong
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachBaiGiangTrongChuong('{MaChuong}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Thêm một bài giảng vào cơ sở dữ liệu
        public bool ThemBaiGiang(ref string err, string TieuDe, string NoiDung, int MaChuong)
        {
            try
            {
                // Tạo một mảng các tham số MySQL
                MySqlParameter[] parameters =
                {
            new MySqlParameter("p_TieuDe", TieuDe),
            new MySqlParameter("p_NoiDung", NoiDung),
            new MySqlParameter("p_MaChuong", MaChuong)
        };
                // Thực thi stored procedure Re_ThemBaiGiang với các tham số tương ứng
                return db.MyExecuteNonQuery($"CALL Re_ThemBaiGiang('{TieuDe}','{NoiDung}','{MaChuong}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Cập nhật thông tin của một bài giảng
        public bool CapNhatBaiGiang(ref string err, int ID, string TieuDe, string NoiDung)
        {
            try
            {
                // Tạo một mảng các tham số MySQL
                MySqlParameter[] parameters =
                {
            new MySqlParameter("p_ID", ID),
            new MySqlParameter("p_TieuDe", TieuDe),
            new MySqlParameter("p_NoiDung", NoiDung),
        };
                // Thực thi stored procedure Re_CapNhatBaiGiang với các tham số tương ứng
                return db.MyExecuteNonQuery($"CALL Re_CapNhatBaiGiang('{ID}','{TieuDe}','{NoiDung}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Xóa một bài giảng khỏi cơ sở dữ liệu
        public bool XoaBaiGiang(ref string err, int ID)
        {
            try
            {
                // Tạo một tham số MySQL
                MySqlParameter parameter = new MySqlParameter("p_ID", ID);
                // Thực thi stored procedure Re_XoaBaiGiang với tham số tương ứng
                return db.MyExecuteNonQuery($"CALL Re_XoaBaiGiang('{ID}')", CommandType.Text, ref err, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }
    }
}
