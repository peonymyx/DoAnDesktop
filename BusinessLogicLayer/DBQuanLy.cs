using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DBQuanLy
    {
        private DAL db;
        public DBQuanLy()
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
        // Phương thức để lấy thông tin quản lý bằng mã số
        public DataSet ThongTin(string maso)
        {
            try
            {
                // Thực thi stored procedure RTO_ThongTinQL để lấy thông tin quản lý bằng mã số
                return db.ExecuteQueryDataSetParam($"CALL RTO_ThongTinQL('{maso}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để tất cả số lượng record
        public DataTable GetTongSoLuong()
        {
            try
            {
                // Thực thi stored procedure RTO_ThongTinQL để lấy thông tin quản lý bằng mã số
                return db.GetTongSoLuongBanGhi();
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }
    }
}