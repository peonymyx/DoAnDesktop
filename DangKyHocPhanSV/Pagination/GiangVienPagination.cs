using BusinessLogicLayer;
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
    public class GiangVienPagination
    {
        // Khai báo biến pageNumber mặc định là 1 và biến list
        private int pageNumber = 1;
        private IPagedList<GiangVien> list;

        // Phương thức để lấy danh sách Giảng viên theo trang
        public async Task<IPagedList<GiangVien>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = "server=103.167.89.145;database=QUANLYSV;uid=team06;password=123456;";
            // Mở kết nối đến cơ sở dữ liệu
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                MySqlCommand command = connection.CreateCommand();

                // Đếm số lượng bản ghi trong bảng GIANGVIEN
                command.CommandText = "SELECT COUNT(*) FROM GIANGVIEN";
                int totalRecords = Convert.ToInt32(await command.ExecuteScalarAsync());
                command.Parameters.Clear();

                // Lấy dữ liệu theo trang từ bảng GIANGVIEN
                command.CommandText = "SELECT * FROM GIANGVIEN ORDER BY MaGV LIMIT @offset, @pageSize";
                command.Parameters.AddWithValue("@offset", (pageNumber - 1) * pageSize);
                command.Parameters.AddWithValue("@pageSize", pageSize);

                // Tạo adapter để lấy dữ liệu từ cơ sở dữ liệu
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Tạo danh sách giảng viên dùng cho phân trang
                list = new StaticPagedList<GiangVien>(
                    // Chuyển đổi dữ liệu từ DataTable thành danh sách các đối tượng GiangVien
                    dataTable.AsEnumerable().Select(row => new GiangVien
                    {
                        MaGV = row["MaGV"].ToString(),
                        HoTenGV = row["HoTenGV"].ToString(),
                        Email = row["Email"].ToString(),
                        MaKhoa = row["MaKhoa"].ToString(),
                        // Các trường dữ liệu khác
                    }),
                    pageNumber, // Số trang hiện tại
                    pageSize,   // Số lượng bản ghi trên mỗi trang
                    totalRecords   // Tổng số bản ghi
                );

                return list; // Trả về danh sách giảng viên phân trang
            }
        }
        // Phương thức LoadDataAsync: Tải dữ liệu vào DataGridView và cập nhật trang hiện tại
        public async Task LoadDataAsync(DataGridView dataGridView, Label lblPageNumber, LinkLabel linklblPrevious, LinkLabel linklblNext)
        {
            // Lấy danh sách giảng viên từ phương thức GetPagedListAsync
            list = await GetPagedListAsync(pageNumber);
            // Cập nhật DataGridView và thông tin trang
            UpdateDataGridView(dataGridView, lblPageNumber, linklblPrevious, linklblNext);
        }

        // Phương thức UpdateDataGridView: Cập nhật DataGridView và thông tin trang
        private void UpdateDataGridView(DataGridView dataGridView, Label lblPageNumber, LinkLabel linklblPrevious, LinkLabel linklblNext)
        {
            // Cập nhật trạng thái của các nút điều hướng trang
            linklblPrevious.Enabled = list.HasPreviousPage;
            linklblNext.Enabled = list.HasNextPage;
            // Gán dữ liệu từ danh sách giảng viên vào DataGridView
            dataGridView.DataSource = list.ToList();
            // Hiển thị thông tin về trang hiện tại
            lblPageNumber.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
        }

        // Phương thức PreviousPageAsync: Chuyển đến trang trước đó
        public async Task PreviousPageAsync(DataGridView dataGridView, Label lblPageNumber, LinkLabel linklblPrevious, LinkLabel linklblNext)
        {
            // Kiểm tra nếu danh sách có trang trước đó
            if (list.HasPreviousPage)
            {
                pageNumber--; // Giảm số trang
                              // Tải lại dữ liệu cho trang mới
                await LoadDataAsync(dataGridView, lblPageNumber, linklblPrevious, linklblNext);
            }
        }

        // Phương thức NextPageAsync: Chuyển đến trang tiếp theo
        public async Task NextPageAsync(DataGridView dataGridView, Label lblPageNumber, LinkLabel linklblPrevious, LinkLabel linklblNext)
        {
            // Kiểm tra nếu danh sách có trang tiếp theo
            if (list.HasNextPage)
            {
                pageNumber++; // Tăng số trang
                              // Tải lại dữ liệu cho trang mới
                await LoadDataAsync(dataGridView, lblPageNumber, linklblPrevious, linklblNext);
            }
        }

    }
}
