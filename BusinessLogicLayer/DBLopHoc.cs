﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using MySqlConnector;

namespace BusinessLogicLayer
{
    public class DBLopHoc
    {
        DAL db = null;
        public DBLopHoc()
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

        public DataSet DSLopHoc()
        {
            return db.ExecuteQueryDataSet("NonP_DanhSachLopHoc", CommandType.StoredProcedure);
        }

        public DataSet TimLopHoc(string malh)
        {
            return db.ExecuteQueryDataSetParam($"HasP_TimKiemLop", CommandType.StoredProcedure, new MySqlParameter("@malop", malh));
        }

        public bool ThemLopHoc(ref string err, string MaLopHoc, string MaMHDT, string MaGV, int GioiHan, string Phong, string Thu, int TietBatDau, int TietKetThuc, string ThoiGianBatDau, string ThoiGianKetThuc, string HocKy, int Nam)
        {
            return db.MyExecuteNonQuery("Re_ThemLopHoc", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@MaLopHoc", MaLopHoc),
                new MySqlParameter("@MaMHDT", MaMHDT),
                new MySqlParameter("@MaGV", MaGV),
                new MySqlParameter("@GioiHan", GioiHan),
                new MySqlParameter("@Phong", Phong),
                new MySqlParameter("@Thu", Thu),
                new MySqlParameter("@TietBatDau", TietBatDau),
                new MySqlParameter("@TietKetThuc", TietKetThuc),
                new MySqlParameter("@ThoiGianBatDau", ThoiGianBatDau),
                new MySqlParameter("@ThoiGianKetThuc", ThoiGianKetThuc),
                new MySqlParameter("@HocKy", HocKy),
                new MySqlParameter("@Nam", Nam));
        }

        public bool XoaLopHoc(ref string err, string malh)
        {
            return db.MyExecuteNonQuery("Re_XoaLopHoc", CommandType.StoredProcedure,
                ref err, new MySqlParameter("@MaLopHoc", malh));
        }

        public DataSet TimKiemLopHocTheoMH(String mamh)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM dbo.RTM_TimKiemLopHocTheoMon(N'{mamh}')", CommandType.Text);
        }

        public DataSet ThoiKhoaBieuSV(String masv)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM dbo.RTM_XemTKB(N'{masv}')", CommandType.Text);
        }

        public DataSet ThoiKhoaBieuGV(String magv)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM dbo.RTM_XemTKBGV(N'{magv}')", CommandType.Text);
        }

        public DataSet ChiTietLopHocGV(String magv)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM dbo.RTM_ChiTietLHGV(N'{magv}')", CommandType.Text);
        }

        public DataSet DanhSachSVLH(String malh)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM dbo.RTO_DanhSachSVLopHoc(N'{malh}')", CommandType.Text);
        }

        public int TongSVLopHoc(String malh)
        {
            return db.MyExecuteScalarFunction($"SELECT dbo.RNO_TongSVLopHoc(N'{malh}')");
        }

        public DataSet DanhSachLH(String malh, String masv)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM dbo.RTM_TimKiemLHDK(N'{malh}', N'{masv}')", CommandType.Text);
        }
    }
}
