using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using MySqlConnector;


namespace BusinessLogicLayer
{

    public class DBSinhVien
    {
        DAL db = null;
        public DBSinhVien()
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
        public DataSet ThongTin(string Mssv)
        {
            try
            {
                return db.ExecuteQueryDataSetParam($"CALL RTO_ThongTinSV('{Mssv}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataSet HocPhanCTDTSV(string Mssv)
        {
            try
            {
                return db.ExecuteQueryDataSetParam($"CALL RTM_HocPhanCTDTSV('{Mssv}')", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }


        public DataSet DSSinhVienDKMH()
        {
            try
            {
                return db.ExecuteQueryDataSetParam($"CALL NonP_DanhSachDKMH()", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool ThemSV(ref string err, string TenDangNhap, string MatKhau, string HoTenSV, string GioiTinh, string NgaySinh, string MaLop)
        {
            try
            {
                MySqlParameter[] parameters = {
                    new MySqlParameter("@TenDangNhap", TenDangNhap),
                    new MySqlParameter("@MatKhau", MatKhau),
                    new MySqlParameter("@HoTenSV", HoTenSV),
                    new MySqlParameter("@GioiTinh", GioiTinh),
                    new MySqlParameter("@NgaySinh", NgaySinh),
                    new MySqlParameter("@MaLop", MaLop)
                };
                return db.MyExecuteNonQuery($"CALL Re_ThemSinhVien('{TenDangNhap}','{MatKhau}','{HoTenSV}','{GioiTinh}','{NgaySinh}','{MaLop}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaSV(ref string err, string mssv)
        {
            try
            {
                MySqlParameter[] parameters = {
                    new MySqlParameter("@mssv", mssv)
                };
                return db.MyExecuteNonQuery($"CALL Re_XoaSinhVien('{mssv}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool CapNhatSV(ref string err, string TenDangNhap, string HoTenSV, string GioiTinh, string NgaySinh, string MaLop, string Tinhtrang)
        {
            try
            {
                MySqlParameter[] parameters = {
                    new MySqlParameter("@TenDangNhap", TenDangNhap),
                    new MySqlParameter("@HoTenSV", HoTenSV),
                    new MySqlParameter("@GioiTinh", GioiTinh),
                    new MySqlParameter("@NgaySinh", NgaySinh),
                    new MySqlParameter("@MaLop", MaLop),
                    new MySqlParameter("@Tinhtrang", Tinhtrang)
                };
                return db.MyExecuteNonQuery($"CALL Re_CapNhatSinhVien('{TenDangNhap}','{HoTenSV}','{GioiTinh}','{NgaySinh}','{MaLop}','{Tinhtrang}')", CommandType.Text, ref err, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
