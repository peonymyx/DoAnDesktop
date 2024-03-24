using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using MySqlConnector;

namespace BusinessLogicLayer
{
    public class DBLopHoc
    {
        DAL db = null;
        public DBLopHoc()
        {
            db = new DAL();
        }

        public void SinhVienConnect()
        {
            db.changeStrConnectToSinhVien();
        }

        public void GiangVienConnect()
        {
            db.changeStrConnectToGiangVien();
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
                    new MySqlParameter("@MaLopHoc", MaLopHoc),
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
                    new MySqlParameter("@Nam", Nam)
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
                    new MySqlParameter("@MaLopHoc", malh)
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
                MySqlParameter parameters = new MySqlParameter("@mamh", mamh);
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
                MySqlParameter parameter = new MySqlParameter("@masv", masv);
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
                MySqlParameter parameter = new MySqlParameter("@magv", magv);
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
                MySqlParameter parameter = new MySqlParameter("@magv", magv);
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
                MySqlParameter parameter = new MySqlParameter("@malh", malh);
                return db.ExecuteQueryDataSet($"CALL RTO_DanhSachSVLopHoc('{malh}')", CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int TongSVLopHoc(string malh)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("@malh", malh);
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
                    new MySqlParameter("@malh", malh),
                    new MySqlParameter("@masv", masv)
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
