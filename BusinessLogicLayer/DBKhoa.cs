using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using MySqlConnector;
using System.Security.Cryptography;

namespace BusinessLogicLayer
{
    public class DBKhoa
    {
        DAL db = null;
        public DBKhoa()
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

        public int TongSVKhoa(string tenkhoa)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("@khoa", tenkhoa);
                string query = $"SELECT RNO_TongSVKhoa('{tenkhoa}')";
                return db.MyExecuteScalarFunction(query, CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet DanhSachSVKhoa(string khoa)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("@khoa", khoa);
                return db.ExecuteQueryDataSet($"CALL RTM_DSSVKhoa('{khoa}')", CommandType.Text, parameter);
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
                return db.ExecuteQueryDataSetParam($"CALL RTO_DanhSachKhoa()", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet TimKiemKhoa(string khoa)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("@khoa", khoa);
                return db.ExecuteQueryDataSet($"CALL RTO_TimKiemKhoa('{khoa}')", CommandType.Text, parameter);

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
                MySqlParameter[] parameters = 
                {
                    new MySqlParameter("@MaKhoa", MaKhoa),
                    new MySqlParameter("@TenKhoa", TenKhoa)
                };
                return db.MyExecuteNonQuery($"CALL Re_ThemKhoa('{MaKhoa}','{TenKhoa}')", CommandType.Text, ref err, parameters);
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
                MySqlParameter parameter = new MySqlParameter("@MaKhoa", MaKhoa);
                return db.MyExecuteNonQuery($"CALL Re_XoaKhoa('{MaKhoa}')", CommandType.Text, ref err, parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
