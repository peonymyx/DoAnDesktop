using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;


namespace DataAccessLayer
{
    public class DAL
    {
        MySqlConnection cnn = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter adp = null;

        string strConnect = "server=103.167.89.145;database=QUANLYSV;uid=team06;password=123456;";

        public void changeStrConnectToSinhVien()
        {
            strConnect = "server=103.167.89.145;database=QUANLYSV;uid=sinhvien;password=123456;";
            cnn = new MySqlConnection(strConnect);
            cmd = cnn.CreateCommand();
        }

        public void changeStrConnectToGiangVien()
        {
            strConnect = "server=103.167.89.145;database=QUANLYSV;uid=giangvien;password=123456;";
            cnn = new MySqlConnection(strConnect);
            cmd = cnn.CreateCommand();
        }

        public DAL()
        {
            cnn = new MySqlConnection(strConnect);
            cmd = cnn.CreateCommand();
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, MySqlParameter parameter)
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            cmd.Parameters.Clear();
            adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public DataSet ExecuteQueryDataSetParam(string strSQL, CommandType ct, params MySqlParameter[] param)
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (MySqlParameter p in param)
                cmd.Parameters.Add(p);
            adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params MySqlParameter[] param)
        {
            bool f = false;
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (MySqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (MySqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return f;
        }
        //đã sửa
        public int MyExecuteScalarFunction(string strSQL, CommandType storedProcedure, MySqlParameter parameter)
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();

            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = CommandType.Text;

            int result = 0;

            int? count = cmd.ExecuteScalar() as int?;
            if (count != null)
                result = count.Value;

            return result;
        }

        public string ExecuteQueryXML(string strSQL, CommandType ct, params MySqlParameter[] p)
        {
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds.GetXml();
        }
        public DataTable GetChartDataSLSV_Khoa()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM View_SoLuongSVMoiKhoa;";
            cmd = new MySqlCommand(query, cnn);
            adp = new MySqlDataAdapter(cmd);
            adp.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetChartDataSLSV_Lop()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM View_SoLuongSVLop;";
            cmd = new MySqlCommand(query, cnn);
            adp = new MySqlDataAdapter(cmd);
            adp.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetChartDataSLSV_Nganh()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM View_SoLuongSVMoiNganh;";
            cmd = new MySqlCommand(query, cnn);
            adp = new MySqlDataAdapter(cmd);
            adp.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetChartDataSLSV_NopBai()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM View_ThongKeBaiTapCuaCacSV;";
            cmd = new MySqlCommand(query, cnn);
            adp = new MySqlDataAdapter(cmd);
            adp.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetChartDataSLTC_DangKy()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM View_TongSoChi;";
            cmd = new MySqlCommand(query, cnn);
            adp = new MySqlDataAdapter(cmd);
            adp.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetChartDataSLGVday_Lop()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM View_SoLuongLopGVDaNhan;";
            cmd = new MySqlCommand(query, cnn);
            adp = new MySqlDataAdapter(cmd);
            adp.Fill(dataTable);
            return dataTable;
        }
    }
}
