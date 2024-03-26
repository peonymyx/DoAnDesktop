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
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachLop()", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet DSSinhVienLop(string malop)
        {
            try
            {
                return db.ExecuteQueryDataSetParam($"CALL RTO_ThongTinSVLop('{malop}')", CommandType.Text);
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
                MySqlParameter[] parameters = {
                    new MySqlParameter("p_MaLop", MaLop),
                    new MySqlParameter("p_TenLop", TenLop),
                    new MySqlParameter("p_MaNganh", MaNganh),
                    new MySqlParameter("p_MaCTDT", MaCTDT)
                };
                return db.MyExecuteNonQuery($"CALL Re_ThemLop('{MaLop}','{TenLop}','{MaNganh}','{MaCTDT}')", CommandType.Text, ref err, parameters);

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
                MySqlParameter[] parameters = {
                    new MySqlParameter("p_MaLop", MaLop)
                };
                return db.MyExecuteNonQuery($"CALL Re_XoaLop('{MaLop}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
