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
    public class DBLop
    {
        private DAL db;
        public DBLop()
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

        public DataSet DSLop()
        {
            try
            {
                return db.ExecuteQueryDataSet("NonP_DanhSachLop", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet DSSinhVienLop(String ms)
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTO_ThongTinSVLop(N'{ms}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemLop(ref string err, string MaLop, string TenLop, string MaNganh, string MaCTDT)
        {       
            try
            {
                return db.MyExecuteNonQuery("Re_ThemLop", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@MaLop", MaLop),
                new MySqlParameter("@TenLop", TenLop),
                new MySqlParameter("@MaNganh", MaNganh),
                new MySqlParameter("@MaCTDT", MaCTDT));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaLop(ref string err, string MaLop)
        {
            try
            {
                return db.MyExecuteNonQuery("Re_XoaLop", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@MaLop", MaLop));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
