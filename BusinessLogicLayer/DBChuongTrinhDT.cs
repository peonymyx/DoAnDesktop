using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DBChuongTrinhDT
    {
        private DAL db;
        public DBChuongTrinhDT()
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
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
            }
        }

        // Lấy danh sách chương trình đào tạo từ cơ sở dữ liệu
        public DataSet DanhSachCTDT()
        {
            try
            {
                // Thực thi stored procedure NonP_DanhSachCTDT để lấy danh sách chương trình đào tạo
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachCTDT()", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }
    }
}