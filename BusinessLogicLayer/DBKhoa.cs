using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using MySqlConnector;

namespace BusinessLogicLayer
{
    public class DBKhoa
    {
        private DAL db;
        public DBKhoa()
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

        public int TongSVKhoa(string tenkhoa)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("p_khoa", tenkhoa);
                string query = $"SELECT RNO_TongSVKhoa('{tenkhoa}')";
                return db.MyExecuteScalarFunction(query, CommandType.Text, parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataSet DanhSachSVKhoa(String khoa)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("p_khoa", khoa);
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

        public DataSet TimKiemKhoa(String khoa)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("p_khoa", khoa);
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
                    new MySqlParameter("p_MaKhoa", MaKhoa),
                    new MySqlParameter("p_TenKhoa", TenKhoa)
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
                MySqlParameter parameter = new MySqlParameter("p_MaKhoa", MaKhoa);
                return db.MyExecuteNonQuery($"CALL Re_XoaKhoa('{MaKhoa}')", CommandType.Text, ref err, parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
