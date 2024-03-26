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
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachMHDT()", CommandType.Text);

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
                return db.ExecuteQueryDataSetParam($"CALL RTO_TimKiemMHDT('{mamhdt}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemMHDT(ref string err, string MaMHDT, string MaMH, string MaCTDT, string MaNganh)
        {
            try
            {
                MySqlParameter[] parameters = {
                    new MySqlParameter("p_MaMHDT", MaMHDT),
                    new MySqlParameter("p_MaMH", MaMH),
                    new MySqlParameter("p_MaCTDT", MaCTDT),
                    new MySqlParameter("p_MaNganh", MaNganh)
                };
                return db.MyExecuteNonQuery($"CALL Re_ThemMHDT('{MaMHDT}','{MaMH}','{MaCTDT}','{MaNganh}')", CommandType.Text, ref err, parameters);
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
                MySqlParameter[] parameters = {
                    new MySqlParameter("p_MaMHDT", MaMHDT)
                };
                return db.MyExecuteNonQuery($"CALL Re_XoaMHDT('{MaMHDT}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
