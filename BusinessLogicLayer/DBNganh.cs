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
    public class DBNganh
    {
        private DAL db;
        public DBNganh()
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

        public int TongSVNganh(String nganh)
        {
            try
            {
                return db.MyExecuteScalarFunction($"CALL dbo.RNO_TongSVNganh(N'{nganh}')");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet DanhSachSVNganh(String nganh)
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTM_DSSVNganh(N'{nganh}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet TimKiemNganh(String nganh)
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTO_TimKiemNganh(N'{nganh}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet DanhSachNganh()
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTO_DanhSachNganh()", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemNganh(ref string err, string MaNganh, string TenNganh, string MaKhoa)
        {
            try
            {
                return db.MyExecuteNonQuery("Re_ThemNganh", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@MaNganh", MaNganh),
                new MySqlParameter("@TenNganh", TenNganh),
                new MySqlParameter("@MaKhoa", MaKhoa));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaNganh(ref string err, string MaNganh)
        {   
            try
            {
                return db.MyExecuteNonQuery("Re_XoaNganh", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@MaNganh", MaNganh));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
