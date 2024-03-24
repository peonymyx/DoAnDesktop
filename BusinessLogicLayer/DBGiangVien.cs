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
        DAL db = null;
        public DBGiangVien()
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

        public DataSet DSGiangVien()
        {
            return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachGV()", CommandType.Text);

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


        public bool ThemGV(ref string err, string TenDangNhap, string MatKhau, string HoTenGV, string MaKhoa)
        {
            try
            {
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("@TenDangNhap", TenDangNhap),
                    new MySqlParameter("@MatKhau", MatKhau),
                    new MySqlParameter("@HoTenGV", HoTenGV),
                    new MySqlParameter("@MaKhoa", MaKhoa)
                };
                return db.MyExecuteNonQuery($"CALL Re_ThemGiangVien('{TenDangNhap}','{MatKhau}','{HoTenGV}','{MaKhoa}')", CommandType.Text, ref err, parameters);
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
                MySqlParameter parameter = new MySqlParameter("@magv", magv);
                return db.MyExecuteNonQuery($"CALL Re_XoaGiangVien('{magv}')", CommandType.Text, ref err, parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
