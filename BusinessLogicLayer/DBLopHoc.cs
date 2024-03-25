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
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachLopHoc()", CommandType.Text);
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
                return db.ExecuteQueryDataSetParam($"CALL HasP_TimKiemLop('{malh}')", CommandType.Text);
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
                MySqlParameter[] parameters = {
                    new MySqlParameter("p_MaLopHoc", MaLopHoc),
                    new MySqlParameter("p_MaMHDT", MaMHDT),
                    new MySqlParameter("p_MaGV", MaGV),
                    new MySqlParameter("p_GioiHan", GioiHan),
                    new MySqlParameter("p_Phong", Phong),
                    new MySqlParameter("p_Thu", Thu),
                    new MySqlParameter("p_TietBatDau", TietBatDau),
                    new MySqlParameter("p_TietKetThuc", TietKetThuc),
                    new MySqlParameter("p_ThoiGianBatDau", ThoiGianBatDau),
                    new MySqlParameter("p_ThoiGianKetThuc", ThoiGianKetThuc),
                    new MySqlParameter("p_HocKy", HocKy),
                    new MySqlParameter("p_Nam", Nam)
                };
                return db.MyExecuteNonQuery($"CALL Re_ThemLopHoc('{MaLopHoc}',('{MaMHDT}'),('{MaGV}'),('{GioiHan}'),('{Phong}'),('{Thu}'),('{TietBatDau}'),('{TietKetThuc}'),('{ThoiGianBatDau}'),('{ThoiGianKetThuc}'),('{HocKy}'),('{Nam}'))", CommandType.Text, ref err, parameters);

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
                MySqlParameter[] parameters = {
                    new MySqlParameter("p_MaLopHoc", malh)
                };
                return db.MyExecuteNonQuery($"CALL Re_XoaLopHoc('{malh}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet TimKiemLopHocTheoMH(string mamh)
        {
            try
            {
                MySqlParameter parameters = new MySqlParameter("p_mamh", mamh);
                return db.ExecuteQueryDataSetParam($"CALL RTM_TimKiemLopHocTheoMon('{mamh}')", CommandType.Text);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ThoiKhoaBieuSV(string masv)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("p_masv", masv);
                return db.ExecuteQueryDataSet($"CALL RTM_XemTKB('{masv}')", CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ThoiKhoaBieuGV(string magv)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("p_magv", magv);
                return db.ExecuteQueryDataSet($"CALL RTM_XemTKBGV('{magv}')", CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ChiTietLopHocGV(string magv)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("p_magv", magv);
                return db.ExecuteQueryDataSet($"CALL RTM_ChiTietLHGV('{magv}')", CommandType.Text, parameter);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet DanhSachSVLH(string malh)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("p_malh", malh);
                return db.ExecuteQueryDataSet($"CALL RTO_DanhSachSVLopHoc('{malh}')", CommandType.Text, parameter);
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
                MySqlParameter parameter = new MySqlParameter("p_malh", malh);
                string query = $"SELECT RNO_TongSVLopHoc('{malh}')";
                return db.MyExecuteScalarFunction(query, CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet DanhSachLH(string malh, string masv)
        {
            try
            {
                MySqlParameter[] parameters = {
                    new MySqlParameter("p_malh", malh),
                    new MySqlParameter("p_masv", masv)
                };
                return db.ExecuteQueryDataSetParam($"CALL RTM_TimKiemLHDK('{malh}','{masv}')", CommandType.Text, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
