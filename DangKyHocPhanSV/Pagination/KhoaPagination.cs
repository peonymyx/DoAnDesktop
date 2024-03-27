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
    public class KhoaPagination
    {
        // Số trang hiện tại, mặc định là trang đầu tiên
        private int pageNumber = 1;
        // Danh sách phân trang của các đối tượng MonHoc
        private IPagedList<Khoa> list;
        // Đối tượng quản lý dữ liệu về môn học
        DBKhoa dsKhoa = new DBKhoa();

        // Phương thức GetPagedListAsync: Lấy danh sách môn học được phân trang
        public async Task<IPagedList<Khoa>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = "server=103.167.89.145;database=QUANLYSV;uid=team06;password=123456;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();

                // Lấy dữ liệu từ nguồn dữ liệu dsKhoa.DanhSachKhoa()
                DataTable dataTable = dsKhoa.DanhSachKhoa().Tables[0];

                // Tính tổng số bản ghi trong danh sách
                int totalRecords = dataTable.Rows.Count;

                // Phân trang dữ liệu từ danh sách dữ liệu
                List<DataRow> rows = dataTable.AsEnumerable()
                                              .Skip((pageNumber - 1) * pageSize)
                                              .Take(pageSize)
                                              .ToList();

                // Tạo danh sách môn học từ dữ liệu đã phân trang
                List<Khoa> khoa = rows.Select(row => new Khoa
                {
                    MaKhoa = row["MaKhoa"].ToString(),
                    TenKhoa = row["TenKhoa"].ToString()
                }).ToList();

                // Tạo đối tượng IPagedList từ danh sách đã tạo
                list = new StaticPagedList<Khoa>(
                    khoa, pageNumber, pageSize, totalRecords);

                return list;
            }
        }

        // Phương thức LoadDataAsync: Tải dữ liệu vào DataGridView và cập nhật trang hiện tại
        public async Task LoadDataAsync(DataGridView dataGridView, Label lblPageNumber, LinkLabel linklblPrevious, LinkLabel linklblNext)
        {
            // Lấy danh sách môn học từ phương thức GetPagedListAsync
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
            // Gán dữ liệu từ danh sách môn học vào DataGridView
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
