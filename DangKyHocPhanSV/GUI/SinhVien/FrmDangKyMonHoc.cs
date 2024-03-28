﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace DangKyHocPhanSV
{
    public partial class FrmDangKyMonHoc : Form
    {
        private string maso;
        DBSinhVien sv = new DBSinhVien();
        private Panel _panelMonhoc;
        private Form currentFormChild;
        public void OpenChildForm(Form childForm, Panel panel)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmDangKyMonHoc(Panel panelMonhoc)
        {
            InitializeComponent();
            sv.SinhVienConnect();
            _panelMonhoc = panelMonhoc;
        }

        public void loadHocPhan()
        {
            this.dgv_monhoc.DataSource = sv.HocPhanCTDTSV(maso).Tables[0];

            dgv_monhoc.Columns[0].HeaderText = "Mã Môn Học";
            dgv_monhoc.Columns[1].HeaderText = "Tên Môn Học";
            dgv_monhoc.Columns[2].HeaderText = "Số Tín Chỉ";

            dgv_monhoc.Columns[0].Width = 200;
            dgv_monhoc.Columns[1].Width = 400;
            dgv_monhoc.Columns[2].Width = 200;
        }

        private void FrmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            loadHocPhan();
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            _panelMonhoc.Show();
        }

        private void dgv_monhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgv_monhoc.CurrentCell.RowIndex;
                string mamh = dgv_monhoc.Rows[index].Cells[0].Value.ToString();
                FrmDangKy dk = new FrmDangKy(pn_monhoc, maso, mamh);
                OpenChildForm(dk, pn_container);
                pn_monhoc.Hide();
                dk.Show();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}