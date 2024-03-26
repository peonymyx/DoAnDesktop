using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DBChuongTrinhDT
    {
        private DAL db;
        public DBChuongTrinhDT()
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

        public DataSet DanhSachCTDT()
        {
            try
            {
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachCTDT()", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
