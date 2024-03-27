using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DBTKSlSV_Nganh
    {
        DAL db = null;
        public DBTKSlSV_Nganh()
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
        // Phương thức để lấy dữ liệu biểu đồ số lượng sinh viên theo ngành
        public DataTable GetChartDataSLSV_Nganh()
        {
            // Trả về dữ liệu từ cơ sở dữ liệu cho biểu đồ số lượng sinh viên theo ngành
            return db.GetChartDataSLSV_Nganh();
        }

    }
}
