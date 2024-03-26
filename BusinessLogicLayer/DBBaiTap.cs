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
    public class DBBaiTap
    {
        private DAL db;
        public DBBaiTap()
        {
            db = new DAL();
        }
        public DataSet DSBaiTapTrongChuong(string MaChuong)
        {
            try
            {
                return db.ExecuteQueryDataSetParam($"CALL NonP_DSBaiTapTrongChuong('{MaChuong}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ThemBaiTap(ref string err, string TieuDeBaiTap, string NoiDungBaiTap, int MaChuongHoc, DateTime HanNop)
        {
            try
            {
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("p_TieuDeBaiTap", TieuDeBaiTap),
                    new MySqlParameter("p_NoiDungBaiTap", NoiDungBaiTap),
                    new MySqlParameter("p_MaChuongHoc", MaChuongHoc),
                    new MySqlParameter("p_HanNop", HanNop)
                };
                return db.MyExecuteNonQuery($"CALL Re_ThemBaiTap('{TieuDeBaiTap}','{NoiDungBaiTap}','{MaChuongHoc}','{HanNop}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CapNhatBaiTap(ref string err, int BaiTapID, string TieuDeBaiTap, string NoiDungBaiTap, DateTime HanNop)
        {
            try
            {
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("p_BaiTapID", BaiTapID),
                    new MySqlParameter("p_TieuDeBaiTap", TieuDeBaiTap),
                    new MySqlParameter("p_NoiDungBaiTap", NoiDungBaiTap),
                    new MySqlParameter("p_HanNop", HanNop)
                };
                return db.MyExecuteNonQuery($"CALL Re_CapNhatBaiTap('{BaiTapID}','{TieuDeBaiTap}','{NoiDungBaiTap}','{HanNop}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaBaiTap(ref string err, int BaiTapID)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("p_BaiTapID", BaiTapID);
                return db.MyExecuteNonQuery($"CALL Re_XoaBaiTap('{BaiTapID}')", CommandType.Text, ref err, parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
