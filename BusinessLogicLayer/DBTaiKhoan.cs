using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using MySqlConnector;


namespace BusinessLogicLayer
{

    public class DBTaiKhoan
    {
        DAL db = null;
        public DBTaiKhoan()
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

        //Thực hiện đăng nhập 
        public int DangNhap(string Mssv, string MatKhau)
        {
            DataSet tk = db.ExecuteQueryDataSetParam($"Call RTO_DangNhap('{Mssv}', '{MatKhau}')", CommandType.Text);
            if (tk.Tables[0].Rows.Count == 0)
                return 0; // Sai
            else if (tk.Tables[0].Rows[0].Field<string>("VaiTro") == "QUẢN LÝ")
                return 1; // Trả về quản lý
            else if (tk.Tables[0].Rows[0].Field<string>("VaiTro") == "Sinh Viên")
            {
                return 2; // Trả về sinh viên
            }
            else
                return 3; // Trả về giảng viên
        }

        //Đổi mật khẩu
        public bool DoiMatKhau(ref string err, string Mssv, string MatKhau)
        {
            try
            {
                MySqlParameter[] parameters = {
                    new MySqlParameter("@MatKhau", MatKhau),
                    new MySqlParameter("@TenDangNhap", Mssv)
                };
                return db.MyExecuteNonQuery($"CALL Re_DoiMatKhau('{MatKhau}','{Mssv}')", CommandType.Text, ref err, parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
