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
    public class DBChuong
    {
        private DAL db;
        public DBChuong()
        {
            db = new DAL();
        }
        public DataSet DSChuong(string maLH)
        {
            try
            {
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachChuongTrongLopHoc('{maLH}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ThemChuong(ref string err, string TieuDeChuong, string MaLopHoc)
        {
            try
            {
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("p_TieuDeChuong", TieuDeChuong),
                    new MySqlParameter("p_MaLopHoc", MaLopHoc)
                };
                return db.MyExecuteNonQuery($"CALL Re_ThemChuong('{TieuDeChuong}','{MaLopHoc}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool CapNhatChuong(ref string err, int MaChuongHoc, string TieuDeChuong)
        {
            try
            {
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("p_MaChuongHoc", MaChuongHoc),
                    new MySqlParameter("p_TieuDeChuong", TieuDeChuong)
                };
                return db.MyExecuteNonQuery($"CALL Re_CapNhatChuong('{MaChuongHoc}','{TieuDeChuong}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaChuong(ref string err, string MaChuongHoc)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("p_MaChuongHoc", MaChuongHoc);
                return db.MyExecuteNonQuery($"CALL Re_XoaChuong('{MaChuongHoc}')", CommandType.Text, ref err, parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
