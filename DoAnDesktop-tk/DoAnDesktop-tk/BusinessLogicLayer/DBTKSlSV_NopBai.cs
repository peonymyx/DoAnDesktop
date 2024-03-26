using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DBTKSlSV_NopBai
    {
        DAL db = null;
        public DBTKSlSV_NopBai()
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
        public DataTable GetChartDataSLSV_NopBai()
        {
            return db.GetChartDataSLSV_NopBai();
        }
    }
}
