using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DBTKSlSV_Nganh
    {
        DAL db = null;
        public DBTKSlSV_Nganh()
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
        public DataTable GetChartDataSLSV_Nganh()
        {
            return db.GetChartDataSLSV_Nganh();
        }
    }
}
