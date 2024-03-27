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
    public class DBNopBai
    {
        private DAL db;
        public DBNopBai()
        {
            db = new DAL();
        }

        // Phương thức để lấy danh sách sinh viên đã nộp bài cho một bài tập
        public DataSet DSSinhVienNopBai(int BaiTapID)
        {
            try
            {
                // Thực thi stored procedure NonP_DSSinhVienNopBai để lấy danh sách sinh viên đã nộp bài
                return db.ExecuteQueryDataSetParam($"CALL NonP_DSSinhVienNopBai('{BaiTapID}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để lấy thông tin bài nộp của một sinh viên cho một bài tập
        public DataSet LayBaiNopByMSSV(int BaiTapID, string MaSV)
        {
            try
            {
                // Thực thi stored procedure Re_LayBaiNopByMSSV để lấy thông tin bài nộp của một sinh viên cho một bài tập
                return db.ExecuteQueryDataSetParam($"CALL Re_LayBaiNopByMSSV('{BaiTapID}','{MaSV}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để thêm một bài nộp của một sinh viên cho một bài tập
        public bool ThemBaiNop(ref string err, string BaiTapID, string TenTapTin, string DuongDan, string MaSV)
        {
            try
            {
                // Tạo mảng tham số để truyền vào stored procedure Re_ThemBaiNop
                MySqlParameter[] parameters =
                {
            new MySqlParameter("p_BaiTapID", BaiTapID),
            new MySqlParameter("p_TenTapTin", TenTapTin),
            new MySqlParameter("p_DuongDan", DuongDan),
            new MySqlParameter("p_MaSV", MaSV)
        };
                // Thực thi stored procedure Re_ThemBaiNop để thêm một bài nộp của một sinh viên cho một bài tập
                return db.MyExecuteNonQuery($"CALL Re_ThemBaiNop('{BaiTapID}','{TenTapTin}','{DuongDan}','{MaSV}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }
        // Phương thức để cập nhật thông tin bài nộp của một sinh viên
        public bool CapNhatBaiNopBySV(ref string err, int IDBaiNop, string TenTapTin, string DuongDan)
        {
            try
            {
                // Tạo mảng tham số để truyền vào stored procedure Re_CapNhatBaiNopBySV
                MySqlParameter[] parameters =
                {
            new MySqlParameter("p_ID", IDBaiNop),
            new MySqlParameter("p_TenTapTin", TenTapTin),
            new MySqlParameter("p_DuongDan", DuongDan),
        };
                // Thực thi stored procedure Re_CapNhatBaiNopBySV để cập nhật thông tin bài nộp của một sinh viên
                return db.MyExecuteNonQuery($"CALL Re_CapNhatBaiNopBySV('{IDBaiNop}','{TenTapTin}','{DuongDan}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để xóa thông tin bài nộp
        public bool XoaBaiNop(ref string err, int IDBaiNop)
        {
            try
            {
                // Tạo tham số để truyền vào stored procedure Re_XoaBaiNop
                MySqlParameter parameter = new MySqlParameter("p_ID", IDBaiNop);
                // Thực thi stored procedure Re_XoaBaiNop để xóa thông tin bài nộp
                return db.MyExecuteNonQuery($"CALL Re_XoaBaiNop('{IDBaiNop}')", CommandType.Text, ref err, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

    }
}