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
    public class SinhVienPagination
    {
        private int pageNumber = 1;
        private IPagedList<GiangVien> list;

        public async Task<IPagedList<GiangVien>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            string connectionString = "server=103.167.89.145;database=QUANLYSV;uid=team06;password=123456;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                MySqlCommand command = connection.CreateCommand();

                // Đếm số lượng bản ghi
                command.CommandText = "SELECT COUNT(*) FROM GIANGVIEN";
                int totalRecords = Convert.ToInt32(await command.ExecuteScalarAsync());
                command.Parameters.Clear();
                // Lấy trang dữ liệu
                command.CommandText = "SELECT * FROM GIANGVIEN ORDER BY MaGV LIMIT @offset, @pageSize";
                command.Parameters.AddWithValue("@offset", (pageNumber - 1) * pageSize);
                command.Parameters.AddWithValue("@pageSize", pageSize);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                list = new StaticPagedList<GiangVien>(
                    dataTable.AsEnumerable().Select(row => new GiangVien
                    {
                        MaGV = row["MaGV"].ToString(),
                        HoTenGV = row["HoTenGV"].ToString(),
                        Email = row["Email"].ToString(),
                        MaKhoa = row["MaKhoa"].ToString(),
                        // Các trường dữ liệu khác
                    }),
                    pageNumber,
                    pageSize,
                    totalRecords
                );

                return list;
            }
        }

        public async Task LoadDataAsync(DataGridView dataGridView, Label lblPageNumber, Button btnPrevious, Button btnNext)
        {
            list = await GetPagedListAsync(pageNumber);
            UpdateDataGridView(dataGridView, lblPageNumber, btnPrevious, btnNext);
        }

        private void UpdateDataGridView(DataGridView dataGridView, Label lblPageNumber, Button btnPrevious, Button btnNext)
        {
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            dataGridView.DataSource = list.ToList();
            lblPageNumber.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
        }

        public async Task PreviousPageAsync(DataGridView dataGridView, Label lblPageNumber, Button btnPrevious, Button btnNext)
        {
            if (list.HasPreviousPage)
            {
                pageNumber--;
                await LoadDataAsync(dataGridView, lblPageNumber, btnPrevious, btnNext);
            }
        }

        public async Task NextPageAsync(DataGridView dataGridView, Label lblPageNumber, Button btnPrevious, Button btnNext)
        {
            if (list.HasNextPage)
            {
                pageNumber++;
                await LoadDataAsync(dataGridView, lblPageNumber, btnPrevious, btnNext);
            }
        }
    }
}
