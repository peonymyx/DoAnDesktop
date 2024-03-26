﻿using DangKyHocPhanSV.DTO;
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
        private IPagedList<SinhVien> list;

        public async Task<IPagedList<SinhVien>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            string connectionString = "server=103.167.89.145;database=QUANLYSV;uid=team06;password=123456;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                MySqlCommand command = connection.CreateCommand();

                // Đếm số lượng bản ghi
                command.CommandText = "SELECT COUNT(*) FROM SINHVIEN";
                int totalRecords = Convert.ToInt32(await command.ExecuteScalarAsync());
                command.Parameters.Clear();
                // Lấy trang dữ liệu
                command.CommandText = "SELECT * FROM SINHVIEN ORDER BY MaSV LIMIT @offset, @pageSize";
                command.Parameters.AddWithValue("@offset", (pageNumber - 1) * pageSize);
                command.Parameters.AddWithValue("@pageSize", pageSize);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

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
                    pageNumber,
                    pageSize,
                    totalRecords
                );

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
