using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using System.Data.SqlClient;
using MySqlConnector;

namespace BusinessLogicLayer
{
    public class DBQuanLy
    {
        DAL db = null;
        public DBQuanLy()
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

        //Hiển thị thông tin sinh viên
        public DataSet ThongTin(string maso)
        {
            try
            {
                return db.ExecuteQueryDataSetParam($"CALL RTO_ThongTinQL('{maso}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
