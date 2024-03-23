using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class DBGiangVien
    {
        DAL db = null;
        public DBGiangVien()
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

        public DataSet DSGiangVien()
        {
            return db.ExecuteQueryDataSet("NonP_DanhSachGV", CommandType.StoredProcedure);
        }

        public DataSet ThongTinGV(string magv)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM dbo.RTO_ThongTinGV('{magv}')", CommandType.Text);
        }

        public bool ThemGV(ref string err, string TenDangNhap, string MatKhau, string HoTenGV, string MaKhoa)
        {
            return db.MyExecuteNonQuery("Re_ThemGiangVien", CommandType.StoredProcedure,
                ref err, new SqlParameter("@TenDangNhap", TenDangNhap),
                new SqlParameter("@MatKhau", MatKhau),
                new SqlParameter("@HoTenGV", HoTenGV),
                new SqlParameter("@MaKhoa", MaKhoa));
        }

        public bool XoaGV(ref string err, string magv)
        {
            return db.MyExecuteNonQuery("Re_XoaGiangVien", CommandType.StoredProcedure,
                ref err, new SqlParameter("@magv", magv));
        }
    }
}
