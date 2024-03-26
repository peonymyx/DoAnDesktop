using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DBTKSlLopGV_Nhan
    {
        DAL db = null;
        public DBTKSlLopGV_Nhan()
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
        public DataTable GetChartDataSLGVday_Lop()
        {
            return db.GetChartDataSLGVday_Lop();
        }
    }
}
