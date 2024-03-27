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
    public class DBBaiTap
    {
        private DAL db;
        public DBBaiTap()
        {
            db = new DAL();
        }
        // Lấy danh sách bài tập trong một chương theo mã chương
        public DataSet DSBaiTapTrongChuong(int MaChuong)
        {
            try
            {
                // Thực thi stored procedure NonP_DSBaiTapTrongChuong với tham số MaChuong
                return db.ExecuteQueryDataSetParam($"CALL NonP_DSBaiTapTrongChuong('{MaChuong}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Thêm một bài tập vào cơ sở dữ liệu
        public bool ThemBaiTap(ref string err, string TieuDeBaiTap, string NoiDungBaiTap, int MaChuongHoc, string HanNop)
        {
            try
            {
                // Tạo một mảng các tham số MySQL
                MySqlParameter[] parameters =
                {
            new MySqlParameter("p_TieuDeBaiTap", TieuDeBaiTap),
            new MySqlParameter("p_NoiDungBaiTap", NoiDungBaiTap),
            new MySqlParameter("p_MaChuongHoc", MaChuongHoc),
            new MySqlParameter("p_HanNop", HanNop)
        };
                // Thực thi stored procedure Re_ThemBaiTap với các tham số tương ứng
                return db.MyExecuteNonQuery($"CALL Re_ThemBaiTap('{TieuDeBaiTap}','{NoiDungBaiTap}','{MaChuongHoc}','{HanNop}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Cập nhật thông tin của một bài tập
        public bool CapNhatBaiTap(ref string err, int BaiTapID, string TieuDeBaiTap, string NoiDungBaiTap, string HanNop)
        {
            try
            {
                // Tạo một mảng các tham số MySQL
                MySqlParameter[] parameters =
                {
            new MySqlParameter("p_BaiTapID", BaiTapID),
            new MySqlParameter("p_TieuDeBaiTap", TieuDeBaiTap),
            new MySqlParameter("p_NoiDungBaiTap", NoiDungBaiTap),
            new MySqlParameter("p_HanNop", HanNop)
        };
                // Thực thi stored procedure Re_CapNhatBaiTapByGV với các tham số tương ứng
                return db.MyExecuteNonQuery($"CALL Re_CapNhatBaiTapByGV('{BaiTapID}','{TieuDeBaiTap}','{NoiDungBaiTap}','{HanNop}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Xóa một bài tập khỏi cơ sở dữ liệu
        public bool XoaBaiTap(ref string err, int BaiTapID)
        {
            try
            {
                // Tạo một tham số MySQL
                MySqlParameter parameter = new MySqlParameter("p_BaiTapID", BaiTapID);
                // Thực thi stored procedure Re_XoaBaiTap với tham số tương ứng
                return db.MyExecuteNonQuery($"CALL Re_XoaBaiTap('{BaiTapID}')", CommandType.Text, ref err, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }
    }
}
