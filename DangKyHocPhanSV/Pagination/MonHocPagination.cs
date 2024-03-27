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
    public class MonHocPagination
    {
        private int pageNumber = 1;
        private IPagedList<MonHoc> list;
        DBMonHoc_DaoTao mhdt = new DBMonHoc_DaoTao();
        public async Task<IPagedList<MonHoc>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            string connectionString = "server=103.167.89.145;database=QUANLYSV;uid=team06;password=123456;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();

                // Lấy dữ liệu từ dgv_monhoc.DataSource
                DataTable dataTable = mhdt.DSMHDT().Tables[0];

                int totalRecords = dataTable.Rows.Count;

                // Phân trang dữ liệu
                List<DataRow> rows = dataTable.AsEnumerable()
                                              .Skip((pageNumber - 1) * pageSize)
                                              .Take(pageSize)
                                              .ToList();

                // Tạo danh sách GiangVien từ dữ liệu đã phân trang
                List<MonHoc> monhoc = rows.Select(row => new MonHoc
                {
                    MaMHDT = row["MaMHDT"].ToString(),
                    TenMH = row["TenMH"].ToString(),
                    SoTinChi = (int)row["SoTinChi"],
                    TenCTDT = row["TenCTDT"].ToString(),
                    TenNganh = row["TenNganh"].ToString(),
                    // Các trường dữ liệu khác
                }).ToList();

                // Tạo đối tượng IPagedList từ danh sách đã tạo
                list = new StaticPagedList<MonHoc>(
                    monhoc, pageNumber, pageSize, totalRecords);

                return list;
            }
        }
        public async Task LoadDataAsync(DataGridView dataGridView, Label lblPageNumber, LinkLabel linklblPrevious, LinkLabel linklblNext)
        {
            list = await GetPagedListAsync(pageNumber);
            UpdateDataGridView(dataGridView, lblPageNumber, linklblPrevious, linklblNext);
        }

        private void UpdateDataGridView(DataGridView dataGridView, Label lblPageNumber, LinkLabel linklblPrevious, LinkLabel linklblNext)
        {
            linklblPrevious.Enabled = list.HasPreviousPage;
            linklblNext.Enabled = list.HasNextPage;
            dataGridView.DataSource = list.ToList();
            lblPageNumber.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
        }

        public async Task PreviousPageAsync(DataGridView dataGridView, Label lblPageNumber, LinkLabel linklblPrevious, LinkLabel linklblNext)
        {
            if (list.HasPreviousPage)
            {
                pageNumber--;
                await LoadDataAsync(dataGridView, lblPageNumber, linklblPrevious, linklblNext);
            }
        }

        public async Task NextPageAsync(DataGridView dataGridView, Label lblPageNumber, LinkLabel linklblPrevious, LinkLabel linklblNext)
        {
            if (list.HasNextPage)
            {
                pageNumber++;
                await LoadDataAsync(dataGridView, lblPageNumber, linklblPrevious, linklblNext);
            }
        }
    }
}
