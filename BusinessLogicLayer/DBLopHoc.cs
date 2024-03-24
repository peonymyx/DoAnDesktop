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

        public DataSet DSLopHoc()
        {    
            try
            {
                return db.ExecuteQueryDataSet("NonP_DanhSachLopHoc", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet TimLopHoc(string malh)
        {
            try
            {
                return db.ExecuteQueryDataSetParam($"HasP_TimKiemLop", CommandType.StoredProcedure, new MySqlParameter("@malop", malh));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemLopHoc(ref string err, string MaLopHoc, string MaMHDT, string MaGV, int GioiHan, string Phong, string Thu, int TietBatDau, int TietKetThuc, string ThoiGianBatDau, string ThoiGianKetThuc, string HocKy, int Nam)
        {
            try
            {
                return db.MyExecuteNonQuery("Re_ThemLopHoc", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@MaLopHoc", MaLopHoc),
                new MySqlParameter("@MaMHDT", MaMHDT),
                new MySqlParameter("@MaGV", MaGV),
                new MySqlParameter("@GioiHan", GioiHan),
                new MySqlParameter("@Phong", Phong),
                new MySqlParameter("@Thu", Thu),
                new MySqlParameter("@TietBatDau", TietBatDau),
                new MySqlParameter("@TietKetThuc", TietKetThuc),
                new MySqlParameter("@ThoiGianBatDau", ThoiGianBatDau),
                new MySqlParameter("@ThoiGianKetThuc", ThoiGianKetThuc),
                new MySqlParameter("@HocKy", HocKy),
                new MySqlParameter("@Nam", Nam));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaLopHoc(ref string err, string malh)
        {
            try
            {
                return db.MyExecuteNonQuery("Re_XoaLopHoc", CommandType.StoredProcedure,
               ref err, new MySqlParameter("@MaLopHoc", malh));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet TimKiemLopHocTheoMH(String mamh)
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTM_TimKiemLopHocTheoMon(N'{mamh}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ThoiKhoaBieuSV(String masv)
        {           
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTM_XemTKB(N'{masv}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ThoiKhoaBieuGV(String magv)
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTM_XemTKBGV(N'{magv}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ChiTietLopHocGV(String magv)
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTM_ChiTietLHGV(N'{magv}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet DanhSachSVLH(String malh)
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTO_DanhSachSVLopHoc(N'{malh}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int TongSVLopHoc(String malh)
        {
            try
            {
                return db.MyExecuteScalarFunction($"SELECT RNO_TongSVLopHoc(N'{malh}')");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet DanhSachLH(String malh, String masv)
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTM_TimKiemLHDK(N'{malh}', N'{masv}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
