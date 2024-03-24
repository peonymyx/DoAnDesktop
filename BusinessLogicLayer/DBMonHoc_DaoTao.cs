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
    public class DBMonHoc_DaoTao
    {
        private DAL db;
        public DBMonHoc_DaoTao()
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

        public DataSet DSMHDT()
        {
            try
            {
                return db.ExecuteQueryDataSet("NonP_DanhSachMHDT", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet TimKiemMHDT(String mamhdt)
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTO_TimKiemMHDT(N'{mamhdt}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemMHDT(ref string err, string MaMHDT , string MaMH, string MaCTDT, string MaNganh )
        {
            try
            {
                return db.MyExecuteNonQuery("Re_ThemMHDT", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@MaMHDT", MaMHDT),
                new MySqlParameter("@MaMH", MaMH),
                new MySqlParameter("@MaCTDT", MaCTDT),
                new MySqlParameter("@MaNganh", MaNganh));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaMHDT(ref string err, string MaMHDT)
        {
            try
            {
                return db.MyExecuteNonQuery("Re_XoaMHDT", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@MaMHDT", MaMHDT));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
