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

        // Chuỗi kết nối cơ sở dữ liệu MySQL ban đầu
        string strConnect = "server=103.167.89.145;database=QUANLYSV;uid=team06;password=123456;";

        // Phương thức để thay đổi chuỗi kết nối để kết nối với tài khoản sinh viên
        public void changeStrConnectToSinhVien()
        {
            // Thiết lập chuỗi kết nối mới để kết nối với tài khoản sinh viên
            strConnect = "server=103.167.89.145;database=QUANLYSV;uid=sinhvien;password=123456;";
            // Tạo mới một kết nối MySQL sử dụng chuỗi kết nối mới
            cnn = new MySqlConnection(strConnect);
            // Tạo mới một lệnh SQL từ kết nối
            cmd = cnn.CreateCommand();
        }

        // Phương thức để thay đổi chuỗi kết nối để kết nối với tài khoản giảng viên
        public void changeStrConnectToGiangVien()
        {
            // Thiết lập chuỗi kết nối mới để kết nối với tài khoản giảng viên
            strConnect = "server=103.167.89.145;database=QUANLYSV;uid=giangvien;password=123456;";
            // Tạo mới một kết nối MySQL sử dụng chuỗi kết nối mới
            cnn = new MySqlConnection(strConnect);
            // Tạo mới một lệnh SQL từ kết nối
            cmd = cnn.CreateCommand();
        }

        // Constructor của lớp DAL, khởi tạo một kết nối và một lệnh SQL sử dụng chuỗi kết nối ban đầu
        public DAL()
        {
            // Khởi tạo một kết nối MySQL sử dụng chuỗi kết nối ban đầu
            cnn = new MySqlConnection(strConnect);
            // Tạo mới một lệnh SQL từ kết nối
            cmd = cnn.CreateCommand();
        }

        // Thực thi một truy vấn SQL và trả về một DataSet
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, MySqlParameter parameter)
        {
            // Kiểm tra trạng thái kết nối, đóng kết nối nếu đang mở
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            // Mở kết nối
            cnn.Open();
            // Thiết lập lệnh SQL và loại lệnh
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            // Xóa các tham số của lệnh trước khi thêm mới
            cmd.Parameters.Clear();
            // Tạo một SqlDataAdapter và DataSet mới
            adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            // Đổ dữ liệu từ SqlDataAdapter vào DataSet
            adp.Fill(ds);
            // Trả về DataSet
            return ds;
        }

        // Thực thi một truy vấn SQL với tham số và trả về một DataSet
        public DataSet ExecuteQueryDataSetParam(string strSQL, CommandType ct, params MySqlParameter[] param)
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            // Thêm các tham số vào lệnh
            foreach (MySqlParameter p in param)
                cmd.Parameters.Add(p);
            adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        // Thực thi một truy vấn không trả về dữ liệu (như INSERT, UPDATE, DELETE)
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params MySqlParameter[] param)
        {
            bool f = false;
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            // Thêm các tham số vào lệnh
            foreach (MySqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                // Thực thi truy vấn
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (MySqlException ex)
            {
                // Nếu có lỗi, ghi lại thông báo lỗi
                error = ex.Message;
            }
            finally
            {
                // Luôn đóng kết nối sau khi thực thi xong
                cnn.Close();
            }
            // Trả về kết quả thực thi (true nếu thành công, false nếu có lỗi)
            return f;
        }

        // Thực thi một stored procedure và trả về một giá trị scalar (kết quả)
        public int MyExecuteScalarFunction(string strSQL, CommandType storedProcedure, MySqlParameter parameter)
        {
            // Kiểm tra trạng thái kết nối, đóng kết nối nếu đang mở
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            // Mở kết nối
            cnn.Open();

            // Xóa các tham số của lệnh trước khi thêm mới
            cmd.Parameters.Clear();
            // Thiết lập lệnh SQL và loại lệnh
            cmd.CommandText = strSQL;
            cmd.CommandType = CommandType.Text;

            // Khởi tạo biến kết quả
            int result = 0;

            // Thực thi lệnh và lấy kết quả scalar
            int? count = cmd.ExecuteScalar() as int?;
            if (count != null)
                result = count.Value;

            // Trả về kết quả
            return result;
        }

        // Thực thi một truy vấn SQL và trả về kết quả dưới dạng chuỗi XML
        public string ExecuteQueryXML(string strSQL, CommandType ct, params MySqlParameter[] p)
        {
            // Thiết lập lệnh SQL và loại lệnh
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            // Tạo một SqlDataAdapter và DataSet mới
            adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            // Đổ dữ liệu từ SqlDataAdapter vào DataSet
            adp.Fill(ds);
            // Trả về dữ liệu dưới dạng chuỗi XML
            return ds.GetXml();
        }

        // Lấy dữ liệu cho biểu đồ từ cơ sở dữ liệu
        public DataTable GetChartDataSLSV_Khoa()
        {
            // Khởi tạo một DataTable mới
            DataTable dataTable = new DataTable();
            // Câu truy vấn SQL
            string query = "SELECT * FROM View_SoLuongSVMoiKhoa;";
            // Thiết lập lệnh SQL và kết nối
            cmd = new MySqlCommand(query, cnn);
            // Tạo một SqlDataAdapter
            adp = new MySqlDataAdapter(cmd);
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            adp.Fill(dataTable);
            // Trả về DataTable
            return dataTable;
        }
        public DataTable GetChartDataSLSV_Lop()
        {
            // Khởi tạo một DataTable mới
            DataTable dataTable = new DataTable();
            // Câu truy vấn SQL
            string query = "SELECT * FROM View_SoLuongSVLop;";
            // Thiết lập lệnh SQL và kết nối
            cmd = new MySqlCommand(query, cnn);
            // Tạo một SqlDataAdapter
            adp = new MySqlDataAdapter(cmd);
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            adp.Fill(dataTable);
            // Trả về DataTable
            return dataTable;
        }

        // Lấy dữ liệu cho biểu đồ số lượng sinh viên theo ngành
        public DataTable GetChartDataSLSV_Nganh()
        {
            // Khởi tạo một DataTable mới
            DataTable dataTable = new DataTable();
            // Câu truy vấn SQL
            string query = "SELECT * FROM View_SoLuongSVMoiNganh;";
            // Thiết lập lệnh SQL và kết nối
            cmd = new MySqlCommand(query, cnn);
            // Tạo một SqlDataAdapter
            adp = new MySqlDataAdapter(cmd);
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            adp.Fill(dataTable);
            // Trả về DataTable
            return dataTable;
        }

        // Lấy dữ liệu cho biểu đồ số lượng sinh viên nộp bài
        public DataTable GetChartDataSLSV_NopBai()
        {
            // Khởi tạo một DataTable mới
            DataTable dataTable = new DataTable();
            // Câu truy vấn SQL
            string query = "SELECT * FROM View_ThongKeBaiTapCuaCacSV;";
            // Thiết lập lệnh SQL và kết nối
            cmd = new MySqlCommand(query, cnn);
            // Tạo một SqlDataAdapter
            adp = new MySqlDataAdapter(cmd);
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            adp.Fill(dataTable);
            // Trả về DataTable
            return dataTable;
        }
        // Lấy dữ liệu cho biểu đồ số lượng sinh viên đăng ký
        public DataTable GetChartDataSLTC_DangKy()
        {
            // Khởi tạo một DataTable mới
            DataTable dataTable = new DataTable();
            // Câu truy vấn SQL
            string query = "SELECT * FROM View_TongSoChi;";
            // Thiết lập lệnh SQL và kết nối
            cmd = new MySqlCommand(query, cnn);
            // Tạo một SqlDataAdapter
            adp = new MySqlDataAdapter(cmd);
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            adp.Fill(dataTable);
            // Trả về DataTable
            return dataTable;
        }

        // Lấy dữ liệu cho biểu đồ số lượng giáo viên dạy theo lớp
        public DataTable GetChartDataSLGVday_Lop()
        {
            // Khởi tạo một DataTable mới
            DataTable dataTable = new DataTable();
            // Câu truy vấn SQL
            string query = "SELECT * FROM View_SoLuongLopGVDaNhan;";
            // Thiết lập lệnh SQL và kết nối
            cmd = new MySqlCommand(query, cnn);
            // Tạo một SqlDataAdapter
            adp = new MySqlDataAdapter(cmd);
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            adp.Fill(dataTable);
            // Trả về DataTable
            return dataTable;
        }
    }
}
