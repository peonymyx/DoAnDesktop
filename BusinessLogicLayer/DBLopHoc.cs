using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using MySqlConnector;
using System.Net.NetworkInformation;

namespace BusinessLogicLayer
{
    public class DBLopHoc
    {
        private DAL db;
        public DBLopHoc()
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

        // Lấy danh sách các lớp học từ cơ sở dữ liệu
        public DataSet DSLopHoc()
        {
            try
            {
                // Thực thi stored procedure NonP_DanhSachLopHoc để lấy danh sách các lớp học
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachLopHoc()", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Tìm kiếm thông tin của một lớp học dựa trên mã lớp học
        public DataSet TimLopHoc(string malh)
        {
            try
            {
                // Thực thi stored procedure HasP_TimKiemLop để tìm kiếm thông tin của một lớp học dựa trên mã lớp học
                return db.ExecuteQueryDataSetParam($"CALL HasP_TimKiemLop('{malh}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }


        // Phương thức để thêm một lớp học mới vào cơ sở dữ liệu
        public bool ThemLopHoc(ref string err, string MaLopHoc, string tenlop, string MaMHDT, string MaGV, int GioiHan, string TenPhong, string Thu, int TietBatDau, int TietKetThuc, string ThoiGianBatDau, string ThoiGianKetThuc, string HocKy, int Nam)
        {
            try
            {
                // Tạo mảng các tham số cho stored procedure Re_ThemLopHoc
                MySqlParameter[] parameters = {
                new MySqlParameter("p_MaLopHoc", MaLopHoc),
                new MySqlParameter("p_TenLop", tenlop),
                new MySqlParameter("p_MaMHDT", MaMHDT),
                new MySqlParameter("p_MaGV", MaGV),
                new MySqlParameter("p_GioiHan", GioiHan),
                new MySqlParameter("p_TenPhong", TenPhong),
                new MySqlParameter("p_Thu", Thu),
                new MySqlParameter("p_TietBatDau", TietBatDau),
                new MySqlParameter("p_TietKetThuc", TietKetThuc),
                new MySqlParameter("p_ThoiGianBatDau", ThoiGianBatDau),
                new MySqlParameter("p_ThoiGianKetThuc", ThoiGianKetThuc),
                new MySqlParameter("p_HocKy", HocKy),
                new MySqlParameter("p_Nam", Nam)
            };

                // Thực thi stored procedure Re_ThemLopHoc để thêm một lớp học mới vào cơ sở dữ liệu
                return db.MyExecuteNonQuery($"CALL Re_ThemLopHoc('{MaLopHoc}',('{tenlop}'),('{MaMHDT}'),('{MaGV}'),('{GioiHan}'),('{TenPhong}'),('{Thu}'),('{TietBatDau}'),('{TietKetThuc}'),('{ThoiGianBatDau}'),('{ThoiGianKetThuc}'),('{HocKy}'),('{Nam}'))", CommandType.Text, ref err, parameters);

            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để xóa một lớp học khỏi cơ sở dữ liệu
        public bool XoaLopHoc(ref string err, string malh)
        {
            try
            {
                // Tạo mảng tham số cho stored procedure Re_XoaLopHoc
                MySqlParameter[] parameters = {
            new MySqlParameter("p_MaLopHoc", malh)
        };

                // Thực thi stored procedure Re_XoaLopHoc để xóa một lớp học khỏi cơ sở dữ liệu
                return db.MyExecuteNonQuery($"CALL Re_XoaLopHoc('{malh}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }


        // Phương thức để tìm kiếm lớp học theo mã môn học
        public DataSet TimKiemLopHocTheoMH(string MaMH)
        {
            try
            {
                // Tạo tham số cho mã môn học
                MySqlParameter parameter = new MySqlParameter("p_MaMH", MaMH);

                // Thực thi stored procedure RTM_TimKiemLopHocTheoMon để tìm kiếm lớp học theo mã môn học
                return db.ExecuteQueryDataSetParam($"CALL RTM_TimKiemLopHocTheoMon('{MaMH}')", CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để xem thời khóa biểu của sinh viên
        public DataSet ThoiKhoaBieuSV(string masv)
        {
            try
            {
                // Tạo tham số cho mã sinh viên
                MySqlParameter parameter = new MySqlParameter("p_masv", masv);

                // Thực thi stored procedure RTM_XemTKB để xem thời khóa biểu của sinh viên
                return db.ExecuteQueryDataSet($"CALL RTM_XemTKB('{masv}')", CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để xem thời khóa biểu của giáo viên
        public DataSet ThoiKhoaBieuGV(string magv)
        {
            try
            {
                // Tạo tham số cho mã giáo viên
                MySqlParameter parameter = new MySqlParameter("p_magv", magv);

                // Thực thi stored procedure RTM_XemTKBGV để xem thời khóa biểu của giáo viên
                return db.ExecuteQueryDataSet($"CALL RTM_XemTKBGV('{magv}')", CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }


        // Phương thức để lấy chi tiết lớp học của giáo viên
        public DataSet ChiTietLopHocGV(string magv)
        {
            try
            {
                // Tạo tham số cho mã giáo viên
                MySqlParameter parameter = new MySqlParameter("p_magv", magv);

                // Thực thi stored procedure RTM_ChiTietLHGV để lấy chi tiết lớp học của giáo viên
                return db.ExecuteQueryDataSet($"CALL RTM_ChiTietLHGV('{magv}')", CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để lấy chi tiết lớp học của sinh viên
        public DataSet ChiTietLopHocSV(string masv)
        {
            try
            {
                // Tạo tham số cho mã sinh viên
                MySqlParameter parameter = new MySqlParameter("p_masv", masv);

                // Thực thi stored procedure RTM_ChiTietLHSV để lấy chi tiết lớp học của sinh viên
                return db.ExecuteQueryDataSet($"CALL RTM_ChiTietLHSV('{masv}')", CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để lấy danh sách sinh viên trong lớp học
        public DataSet DanhSachSVLH(string malh)
        {
            try
            {
                // Tạo tham số cho mã lớp học
                MySqlParameter parameter = new MySqlParameter("p_malh", malh);

                // Thực thi stored procedure RTO_DanhSachSVLopHoc để lấy danh sách sinh viên trong lớp học
                return db.ExecuteQueryDataSet($"CALL RTO_DanhSachSVLopHoc('{malh}')", CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để tính tổng số sinh viên trong lớp học
        public int TongSVLopHoc(String malh)
        {
            try
            {
                // Tạo tham số cho mã lớp học
                MySqlParameter parameter = new MySqlParameter("p_malh", malh);

                // Tạo câu truy vấn để gọi hàm scalar RNO_TongSVLopHoc để tính tổng số sinh viên trong lớp học
                string query = $"SELECT RNO_TongSVLopHoc('{malh}')";

                // Thực thi câu truy vấn và trả về kết quả
                return db.MyExecuteScalarFunction(query, CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

        // Phương thức để lấy danh sách lớp học dựa trên mã lớp học và mã sinh viên
        public DataSet DanhSachLH(string malh, string masv)
        {
            try
            {
                // Tạo mảng tham số cho mã lớp học và mã sinh viên
                MySqlParameter[] parameters = {
            new MySqlParameter("p_malh", malh),
            new MySqlParameter("p_masv", masv)
        };

                // Thực thi stored procedure RTM_TimKiemLHDK để lấy danh sách lớp học dựa trên mã lớp học và mã sinh viên
                return db.ExecuteQueryDataSetParam($"CALL RTM_TimKiemLHDK('{malh}','{masv}')", CommandType.Text, parameters);
            }
            catch (Exception ex)
            {
                // Ném lại exception nếu có lỗi xảy ra
                throw ex;
            }
        }

    }
}