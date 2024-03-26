using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DBTKDK_TinChi
    {
        DAL db = null;
        public DBTKDK_TinChi()
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
        public DataTable GetChartDataSLTC_DangKy()
        {
            return db.GetChartDataSLTC_DangKy();
        }
    }
}
