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
    public class DBChuong
    {
        private DAL db;
        public DBChuong()
        {
            db = new DAL();
        }
        // Lấy danh sách các chương trong một lớp học dựa trên mã lớp học
        public DataSet DSChuong(string maLH)
        {
            try
            {
                // Thực thi stored procedure NonP_DanhSachChuongTrongLopHoc với tham số maLH
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachChuongTrongLopHoc('{maLH}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Thêm một chương mới vào cơ sở dữ liệu
        public bool ThemChuong(ref string err, string TieuDeChuong, string MaLopHoc)
        {
            try
            {
                // Tạo một mảng các tham số MySQL
                MySqlParameter[] parameters =
                {
            new MySqlParameter("p_TieuDeChuong", TieuDeChuong),
            new MySqlParameter("p_MaLopHoc", MaLopHoc)
        };
                // Thực thi stored procedure Re_ThemChuong với các tham số tương ứng
                return db.MyExecuteNonQuery($"CALL Re_ThemChuong('{TieuDeChuong}','{MaLopHoc}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }
        // Cập nhật thông tin của một chương học
        public bool CapNhatChuong(ref string err, int MaChuongHoc, string TieuDeChuong)
        {
            try
            {
                // Tạo một mảng các tham số MySQL
                MySqlParameter[] parameters =
                {
            new MySqlParameter("p_MaChuongHoc", MaChuongHoc),
            new MySqlParameter("p_TieuDeChuong", TieuDeChuong)
        };
                // Thực thi stored procedure Re_CapNhatChuong với các tham số tương ứng
                return db.MyExecuteNonQuery($"CALL Re_CapNhatChuong('{MaChuongHoc}','{TieuDeChuong}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Xóa một chương học khỏi cơ sở dữ liệu
        public bool XoaChuong(ref string err, string MaChuongHoc)
        {
            try
            {
                // Tạo một tham số MySQL
                MySqlParameter parameter = new MySqlParameter("p_MaChuongHoc", MaChuongHoc);
                // Thực thi stored procedure Re_XoaChuong với tham số tương ứng
                return db.MyExecuteNonQuery($"CALL Re_XoaChuong('{MaChuongHoc}')", CommandType.Text, ref err, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }
    }
}