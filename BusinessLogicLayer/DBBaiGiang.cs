using DataAccessLayer;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DBBaiGiang
    {
        private DAL db;
        public DBBaiGiang()
        {
            db = new DAL();
        }
        public DataSet DanhSachBaiGiangTrongChuong(int MaChuong)
        {
            try
            {
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachBaiGiangTrongChuong('{MaChuong}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ThemBaiGiang(ref string err, string TieuDe, string NoiDung, int MaChuong)
        {
            try
            {
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("p_TieuDe", TieuDe),
                    new MySqlParameter("p_NoiDung", NoiDung),
                    new MySqlParameter("p_MaChuong", MaChuong)
                };
                return db.MyExecuteNonQuery($"CALL Re_ThemBaiGiang('{TieuDe}','{NoiDung}','{MaChuong}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CapNhatBaiGiang(ref string err, int ID, string TieuDe, string NoiDung)
        {
            try
            {
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("p_ID", ID),
                    new MySqlParameter("p_TieuDe", TieuDe),
                    new MySqlParameter("p_NoiDung", NoiDung),
                };
                return db.MyExecuteNonQuery($"CALL Re_CapNhatBaiGiang('{ID}','{TieuDe}','{NoiDung}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaBaiGiang(ref string err, int ID)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("p_ID", ID);
                return db.MyExecuteNonQuery($"CALL Re_XoaBaiGiang('{ID}')", CommandType.Text, ref err, parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
