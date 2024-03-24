using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using MySqlConnector;
using System.Security.Cryptography;

namespace BusinessLogicLayer
{
    public class DBNganh
    {
        DAL db = null;
        public DBNganh()
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

        public int TongSVNganh(string nganh)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("@nganh", nganh);
                string query = $"SELECT RNO_TongSVNganh('{nganh}')";
                return db.MyExecuteScalarFunction(query, CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet DanhSachSVNganh(string nganh)
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


        public DataSet TimKiemNganh(string nganh)
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
                    new MySqlParameter("@MaNganh", MaNganh),
                    new MySqlParameter("@TenNganh", TenNganh),
                    new MySqlParameter("@MaKhoa",MaKhoa)
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
                    new MySqlParameter("@MaNganh", MaNganh)
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
