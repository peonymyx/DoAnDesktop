using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DBBaiTap
    {
        private DAL db;
        public DBBaiTap()
        {
            db = new DAL();
        }
    }
}
