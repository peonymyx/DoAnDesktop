using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DBQuanLy
    {
        private DAL db;
        public DBQuanLy()
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
