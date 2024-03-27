using DangKyHocPhanSV.DTO;
using MySqlConnector;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyHocPhanSV.Pagination
{
    public class SinhVienPagination
    {
        // Biến pageNumber dùng để theo dõi trang hiện tại của dữ liệu phân trang.
        private int pageNumber = 1;

        // Đối tượng IPagedList<SinhVien> list để lưu trữ dữ liệu được phân trang.
        private IPagedList<SinhVien> list;

        // Phương thức GetPagedListAsync dùng để lấy dữ liệu được phân trang từ bảng SINHVIEN.
        public async Task<IPagedList<SinhVien>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu MySQL.
            string connectionString = "server=103.167.89.145;database=QUANLYSV;uid=team06;password=123456;";

            // Tạo kết nối mới đến cơ sở dữ liệu.
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Mở kết nối đến cơ sở dữ liệu bất đồng bộ.
                await connection.OpenAsync();

                // Tạo đối tượng command để thực hiện các câu lệnh SQL.
                MySqlCommand command = connection.CreateCommand();

                // Đếm số lượng bản ghi trong bảng SINHVIEN.
                command.CommandText = "SELECT COUNT(*) FROM SINHVIEN";
                int totalRecords = Convert.ToInt32(await command.ExecuteScalarAsync());
                command.Parameters.Clear();

                // Lấy trang dữ liệu từ bảng SINHVIEN, sắp xếp theo MaSV và giới hạn số lượng bản ghi trên mỗi trang.
                command.CommandText = "SELECT * FROM SINHVIEN ORDER BY MaSV LIMIT @offset, @pageSize";
                command.Parameters.AddWithValue("@offset", (pageNumber - 1) * pageSize);
                command.Parameters.AddWithValue("@pageSize", pageSize);

                // Sử dụng adapter để lấy dữ liệu từ command và đổ vào DataTable.
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Tạo danh sách SinhVien từ dữ liệu đã phân trang.
                list = new StaticPagedList<SinhVien>(
                    dataTable.AsEnumerable().Select(row => new SinhVien
                    {
                        MaSV = row["MaSV"].ToString(),
                        HoTenSV = row["HoTenSV"].ToString(),
                        GioiTinh = row["GioiTinh"].ToString(),
                        NgaySinh = (DateTime)row["NgaySinh"],
                        Email = row["Email"].ToString(),
                        MaLop = row["MaLop"].ToString(),
                        // Các trường dữ liệu khác
                    }),
                    pageNumber, // Số trang hiện tại
                    pageSize,   // Số bản ghi trên mỗi trang
                    totalRecords // Tổng số bản ghi
                );

                return list; // Trả về danh sách được phân trang.
            }
        }
        // Phương thức LoadDataAsync dùng để tải dữ liệu vào DataGridView và cập nhật các điều khiển trang.
        public async Task LoadDataAsync(DataGridView dataGridView, Label lblPageNumber, LinkLabel linklblPrevious, LinkLabel linklblNext)
        {
            // Gọi phương thức GetPagedListAsync để lấy danh sách dữ liệu được phân trang.
            list = await GetPagedListAsync(pageNumber);

            // Cập nhật DataGridView và các điều khiển trang.
            UpdateDataGridView(dataGridView, lblPageNumber, linklblPrevious, linklblNext);
        }

        // Phương thức UpdateDataGridView dùng để cập nhật DataGridView và các điều khiển trang.
        private void UpdateDataGridView(DataGridView dataGridView, Label lblPageNumber, LinkLabel linklblPrevious, LinkLabel linklblNext)
        {
            // Cập nhật trạng thái của các nút Previous và Next dựa trên việc có trang trước đó hoặc trang tiếp theo.
            linklblPrevious.Enabled = list.HasPreviousPage;
            linklblNext.Enabled = list.HasNextPage;

            // Đặt dữ liệu của DataGridView bằng danh sách dữ liệu được phân trang.
            dataGridView.DataSource = list.ToList();

            // Hiển thị thông tin về trang hiện tại và tổng số trang.
            lblPageNumber.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
        }

        // Phương thức PreviousPageAsync dùng để chuyển đến trang trước đó khi nhấn nút Previous.
        public async Task PreviousPageAsync(DataGridView dataGridView, Label lblPageNumber, LinkLabel linklblPrevious, LinkLabel linklblNext)
        {
            // Kiểm tra xem có trang trước đó không.
            if (list.HasPreviousPage)
            {
                // Giảm số trang hiện tại đi một đơn vị.
                pageNumber--;

                // Tải lại dữ liệu cho trang mới.
                await LoadDataAsync(dataGridView, lblPageNumber, linklblPrevious, linklblNext);
            }
        }

        // Phương thức NextPageAsync dùng để chuyển đến trang tiếp theo khi nhấn nút Next.
        public async Task NextPageAsync(DataGridView dataGridView, Label lblPageNumber, LinkLabel linklblPrevious, LinkLabel linklblNext)
        {
            // Kiểm tra xem có trang tiếp theo không.
            if (list.HasNextPage)
            {
                // Tăng số trang hiện tại lên một đơn vị.
                pageNumber++;

                // Tải lại dữ liệu cho trang mới.
                await LoadDataAsync(dataGridView, lblPageNumber, linklblPrevious, linklblNext);
            }
        }

    }
}
