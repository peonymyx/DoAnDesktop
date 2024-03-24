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
        DAL db = null;
        public DBMonHoc_DaoTao()
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
        public DataSet TimKiemMHDT(string mamhdt)
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
                    new MySqlParameter("@MaMHDT", MaMHDT),
                    new MySqlParameter("@MaMH", MaMH),
                    new MySqlParameter("@MaCTDT", MaCTDT),
                    new MySqlParameter("@MaNganh", MaNganh)
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
                    new MySqlParameter("@MaMHDT", MaMHDT)
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
