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
    public class DBDangKy
    {
        DAL db = null;
        public DBDangKy()
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

        public bool DangKyLH(ref string err, string MaLopHoc, string MaSV)
        {
            try
            {
                MySqlParameter[] parameters = {
                    new MySqlParameter("@MaLopHoc", MaLopHoc),
                    new MySqlParameter("@MaSV", MaSV)
                };
                return db.MyExecuteNonQuery($"CALL Re_DangKyLH('{MaLopHoc}','{MaSV}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaDangKyLH(ref string err, string MaLopHoc, string MaSV)
        {
            try
            {
                MySqlParameter[] parameters = {
                    new MySqlParameter("@MaLopHoc", MaLopHoc),
                    new MySqlParameter("@MaSV", MaSV)
                };
                return db.MyExecuteNonQuery($"CALL Re_XoaDangKyLH('{MaLopHoc}','{MaSV}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
