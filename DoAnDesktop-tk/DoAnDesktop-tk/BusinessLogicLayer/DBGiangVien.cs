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
    public class DBGiangVien
    {
        private DAL db;
        public DBGiangVien()
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

        public DataSet DSGiangVien()
        {
            try
            {
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachGV()", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ThongTinGV(string magv)
        {
            try
            {
                return db.ExecuteQueryDataSetParam($"CALL RTO_ThongTinGV('{magv}')", CommandType.Text);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool ThemGV(ref string err, string TenDangNhap, string MatKhau, string HoTenGV, string MaKhoa, string Email)
        {
            try
            {
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("p_TenDangNhap", TenDangNhap),
                    new MySqlParameter("p_MatKhau", MatKhau),
                    new MySqlParameter("p_HoTenGV", HoTenGV),
                    new MySqlParameter("p_MaKhoa", MaKhoa),
                    new MySqlParameter("p_Email", Email)
                };
                return db.MyExecuteNonQuery($"CALL Re_ThemGiangVien('{TenDangNhap}','{MatKhau}','{HoTenGV}','{MaKhoa}','{Email}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaGV(ref string err, string magv)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("p_MaGV", magv);
                return db.MyExecuteNonQuery($"CALL Re_XoaGiangVien('{magv}')", CommandType.Text, ref err, parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
