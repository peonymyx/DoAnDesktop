using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using MySqlConnector;

namespace BusinessLogicLayer
{
    public class DBKhoa
    {
        private DAL db;
        public DBKhoa()
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

        public int TongSVKhoa(String khoa)
        {
            try
            {
                return db.MyExecuteScalarFunction($"CALL RNO_TongSVKhoa(N'{khoa}')");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet DanhSachSVKhoa(String khoa)
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTM_DSSVKhoa(N'{khoa}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet DanhSachKhoa()
        {  
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTO_DanhSachKhoa()", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet TimKiemKhoa(String khoa)
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTO_TimKiemKhoa(N'{khoa}')",CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemKhoa(ref string err, string MaKhoa, string TenKhoa)
        {
            try
            {
                return db.MyExecuteNonQuery("Re_ThemKhoa", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@MaKhoa", MaKhoa),
                new MySqlParameter("@TenKhoa", TenKhoa));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaKhoa(ref string err, string MaKhoa)
        {
            try
            {
                return db.MyExecuteNonQuery("Re_XoaKhoa", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@MaKhoa", MaKhoa));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
