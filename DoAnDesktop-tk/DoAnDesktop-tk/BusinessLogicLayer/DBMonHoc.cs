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
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachMonHoc()", CommandType.Text);
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
                //MySqlParameter parameter = new MySqlParameter("@MaMH", mamh);
                return db.ExecuteQueryDataSetParam($"CALL RTO_TimKiemMonHoc('{mamh}')", CommandType.Text);

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
                MySqlParameter[] parameters = {
                    new MySqlParameter("p_MaMH", MaMH),
                    new MySqlParameter("p_TenMH", TenMH),
                    new MySqlParameter("p_SoTinChi", SoTinChi)
                };
                return db.MyExecuteNonQuery($"CALL Re_ThemMonHoc('{MaMH}','{TenMH}','{SoTinChi}')", CommandType.Text, ref err, parameters);

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
                MySqlParameter[] parameters = {
                    new MySqlParameter("p_MaMH", MaMH)
                };
                return db.MyExecuteNonQuery($"CALL Re_XoaMonHoc('{MaMH}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
