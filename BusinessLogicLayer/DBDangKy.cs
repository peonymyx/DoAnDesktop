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
        private DAL db;
        public DBDangKy()
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
        //kiểm tra email tính năng quên mật khẩu
        public DataSet KiemTraEmail(string Email)
        {
            try
            {
                return db.ExecuteQueryDataSet($"CALL RTO_ThongTinSV('{Email}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DangKyLH(ref string err, string MaLopHoc, string MaSV)
        {
            try
            {
                return db.MyExecuteNonQuery("Re_DangKyLH", CommandType.StoredProcedure,
                ref err, new MySqlParameter("p_MaLopHoc", MaLopHoc),
                new MySqlParameter("p_MaSV", MaSV));
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
                return db.MyExecuteNonQuery("Re_XoaDangKyLH", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@MaLopHoc", MaLopHoc),
                new MySqlParameter("@MaSV", MaSV));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
