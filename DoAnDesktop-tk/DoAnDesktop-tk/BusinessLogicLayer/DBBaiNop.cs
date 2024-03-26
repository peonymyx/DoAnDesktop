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
    public class DBNopBai
    {
        private DAL db;
        public DBNopBai()
        {
            db = new DAL();
        }
        //phân quyền giangvien
        public DataSet DSSinhVienNopBai(int IDChuong, string MaSV)
        {
            try
            {
                return db.ExecuteQueryDataSetParam($"CALL NonP_DSSinhVienNopBai('{IDChuong},{MaSV}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ThemBaiNop(ref string err, string BaiTapID, string TenTapTin, string DuongDan, int MaSV)
        {
            try
            {
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("p_BaiTapID", BaiTapID),
                    new MySqlParameter("p_TenTapTin", TenTapTin),
                    new MySqlParameter("p_DuongDan", DuongDan),
                    new MySqlParameter("p_MaSV", MaSV)
                };
                return db.MyExecuteNonQuery($"CALL Re_ThemBaiNop('{BaiTapID}','{TenTapTin}','{DuongDan}','{MaSV}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CapNhatBaiNopBySV(ref string err, int BaiTapID, string TenTapTin, string DuongDan)
        {
            try
            {
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("p_BaiTapID", BaiTapID),
                    new MySqlParameter("p_DuongDan", TenTapTin),
                    new MySqlParameter("p_NoiDung", DuongDan),
                };
                return db.MyExecuteNonQuery($"CALL Re_CapNhatBaiNopBySV('{BaiTapID}','{TenTapTin}','{DuongDan}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaBaiNop(ref string err, int ID)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter("p_ID", ID);
                return db.MyExecuteNonQuery($"CALL Re_XoaBaiNop('{ID}')", CommandType.Text, ref err, parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
