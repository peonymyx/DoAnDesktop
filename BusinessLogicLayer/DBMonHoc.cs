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
    public class DBMonHoc
    {
        private DAL db;
        public DBMonHoc()
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

        public DataSet DSMonHoc()
        { 
            try
            {
                return db.ExecuteQueryDataSet("NonP_DanhSachMonHoc", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet TimKiemMH(String mamh)
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTO_TimKiemMonHoc(N'{mamh}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemMonHoc(ref string err, string MaMH, string TenMH, int SoTinChi)
        {
            try
            {
                return db.MyExecuteNonQuery("Re_ThemMonHoc", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@MaMH", MaMH),
                new MySqlParameter("@TenMH", TenMH),
                new MySqlParameter("@SoTinChi", SoTinChi));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaMonHoc(ref string err, string MaMH)
        {
            try
            {
                return db.MyExecuteNonQuery("Re_XoaMonHoc", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@MaMH", MaMH));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
