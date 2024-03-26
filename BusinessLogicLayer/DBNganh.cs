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
                MySqlParameter parameter = new MySqlParameter("p_nganh", nganh);
                string query = $"SELECT RNO_TongSVNganh('{nganh}')";
                return db.MyExecuteScalarFunction(query, CommandType.Text, parameter);
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
                return db.ExecuteQueryDataSetParam($"CALL RTM_DSSVNganh('{nganh}')", CommandType.Text);
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
                return db.ExecuteQueryDataSetParam($"CALL RTO_TimKiemNganh('{nganh}')", CommandType.Text);
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
                return db.ExecuteQueryDataSetParam($"CALL RTO_DanhSachNganh()", CommandType.Text);
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
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("p_MaNganh", MaNganh),
                    new MySqlParameter("p_TenNganh", TenNganh),
                    new MySqlParameter("p_MaKhoa",MaKhoa)
                };
                return db.MyExecuteNonQuery($"CALL Re_ThemNganh('{MaNganh}','{TenNganh}','{MaKhoa}')", CommandType.Text, ref err, parameters);
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
                MySqlParameter[] parameters = {
                    new MySqlParameter("p_MaNganh", MaNganh)
                };
                return db.MyExecuteNonQuery($"CALL Re_XoaNganh('{MaNganh}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
