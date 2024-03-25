using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DBNopBai
    {
        private DAL db;
        public DBNopBai()
        {
            db = new DAL();
        }
    }
}
