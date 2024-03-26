
namespace DangKyHocPhanSV
{
    partial class FrmGiangVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_header = new System.Windows.Forms.Panel();
            this.lbl_quanlysinhvien = new System.Windows.Forms.Label();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.pn_timkiemxoa = new System.Windows.Forms.Panel();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_magv = new System.Windows.Forms.TextBox();
            this.lbl_magv = new System.Windows.Forms.Label();
            this.pn_themgiangvien = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.cbb_khoa = new System.Windows.Forms.ComboBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.lbl_khoa = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.lbl_tendangnhap = new System.Windows.Forms.Label();
            this.pn_giangvien = new System.Windows.Forms.Panel();
            this.linklbl_next = new System.Windows.Forms.LinkLabel();
            this.linklbl_back = new System.Windows.Forms.LinkLabel();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.dgv_giangvien = new System.Windows.Forms.DataGridView();
            this.pn_header.SuspendLayout();
            this.pn_timkiemxoa.SuspendLayout();
            this.pn_themgiangvien.SuspendLayout();
            this.pn_giangvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_giangvien)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_header
            // 
            this.pn_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_header.Controls.Add(this.lbl_quanlysinhvien);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(993, 60);
            this.pn_header.TabIndex = 0;
            // 
            // lbl_quanlysinhvien
            // 
            this.lbl_quanlysinhvien.AutoSize = true;
            this.lbl_quanlysinhvien.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quanlysinhvien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_quanlysinhvien.Location = new System.Drawing.Point(68, 6);
            this.lbl_quanlysinhvien.Name = "lbl_quanlysinhvien";
            this.lbl_quanlysinhvien.Size = new System.Drawing.Size(270, 40);
            this.lbl_quanlysinhvien.TabIndex = 5;
            this.lbl_quanlysinhvien.Text = "Quản lý giảng viên";
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(821, 376);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(124, 41);
            this.btn_quaylai.TabIndex = 4;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // pn_timkiemxoa
            // 
            this.pn_timkiemxoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_timkiemxoa.Controls.Add(this.btn_xoa);
            this.pn_timkiemxoa.Controls.Add(this.btn_timkiem);
            this.pn_timkiemxoa.Controls.Add(this.txt_magv);
            this.pn_timkiemxoa.Controls.Add(this.lbl_magv);
            this.pn_timkiemxoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_timkiemxoa.Location = new System.Drawing.Point(0, 60);
            this.pn_timkiemxoa.Name = "pn_timkiemxoa";
            this.pn_timkiemxoa.Size = new System.Drawing.Size(993, 64);
            this.pn_timkiemxoa.TabIndex = 1;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_xoa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(753, 11);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(190, 43);
            this.btn_xoa.TabIndex = 74;
            this.btn_xoa.Text = "Xóa tài khoản";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_timkiem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(536, 11);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(190, 43);
            this.btn_timkiem.TabIndex = 73;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_magv
            // 
            this.txt_magv.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_magv.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_magv.Location = new System.Drawing.Point(195, 8);
            this.txt_magv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_magv.Name = "txt_magv";
            this.txt_magv.Size = new System.Drawing.Size(241, 48);
            this.txt_magv.TabIndex = 72;
            // 
            // lbl_magv
            // 
            this.lbl_magv.AutoSize = true;
            this.lbl_magv.BackColor = System.Drawing.Color.SeaShell;
            this.lbl_magv.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_magv.Location = new System.Drawing.Point(26, 17);
            this.lbl_magv.Name = "lbl_magv";
            this.lbl_magv.Size = new System.Drawing.Size(156, 31);
            this.lbl_magv.TabIndex = 71;
            this.lbl_magv.Text = "Mã giảng viên";
            // 
            // pn_themgiangvien
            // 
            this.pn_themgiangvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_themgiangvien.Controls.Add(this.txt_email);
            this.pn_themgiangvien.Controls.Add(this.lbl_email);
            this.pn_themgiangvien.Controls.Add(this.cbb_khoa);
            this.pn_themgiangvien.Controls.Add(this.btn_them);
            this.pn_themgiangvien.Controls.Add(this.lbl_khoa);
            this.pn_themgiangvien.Controls.Add(this.txt_hoten);
            this.pn_themgiangvien.Controls.Add(this.lbl_hoten);
            this.pn_themgiangvien.Controls.Add(this.txt_matkhau);
            this.pn_themgiangvien.Controls.Add(this.txt_tendangnhap);
            this.pn_themgiangvien.Controls.Add(this.lbl_matkhau);
            this.pn_themgiangvien.Controls.Add(this.lbl_tendangnhap);
            this.pn_themgiangvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_themgiangvien.Location = new System.Drawing.Point(0, 124);
            this.pn_themgiangvien.Name = "pn_themgiangvien";
            this.pn_themgiangvien.Size = new System.Drawing.Size(993, 138);
            this.pn_themgiangvien.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_email.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(235, 95);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(241, 28);
            this.txt_email.TabIndex = 117;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(68, 97);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(61, 24);
            this.lbl_email.TabIndex = 116;
            this.lbl_email.Text = "Email:";
            // 
            // cbb_khoa
            // 
            this.cbb_khoa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_khoa.FormattingEnabled = true;
            this.cbb_khoa.Location = new System.Drawing.Point(675, 50);
            this.cbb_khoa.Name = "cbb_khoa";
            this.cbb_khoa.Size = new System.Drawing.Size(241, 29);
            this.cbb_khoa.TabIndex = 115;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_them.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(726, 84);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(190, 43);
            this.btn_them.TabIndex = 109;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lbl_khoa
            // 
            this.lbl_khoa.AutoSize = true;
            this.lbl_khoa.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_khoa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_khoa.Location = new System.Drawing.Point(547, 52);
            this.lbl_khoa.Name = "lbl_khoa";
            this.lbl_khoa.Size = new System.Drawing.Size(57, 24);
            this.lbl_khoa.TabIndex = 114;
            this.lbl_khoa.Text = "Khoa:";
            // 
            // txt_hoten
            // 
            this.txt_hoten.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_hoten.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoten.Location = new System.Drawing.Point(235, 50);
            this.txt_hoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(241, 28);
            this.txt_hoten.TabIndex = 113;
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_hoten.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoten.Location = new System.Drawing.Point(68, 52);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(71, 24);
            this.lbl_hoten.TabIndex = 112;
            this.lbl_hoten.Text = "Họ tên:";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_matkhau.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Location = new System.Drawing.Point(675, 10);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(241, 28);
            this.txt_matkhau.TabIndex = 111;
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_tendangnhap.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendangnhap.Location = new System.Drawing.Point(235, 10);
            this.txt_tendangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(241, 28);
            this.txt_tendangnhap.TabIndex = 108;
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_matkhau.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matkhau.Location = new System.Drawing.Point(547, 12);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(95, 24);
            this.lbl_matkhau.TabIndex = 110;
            this.lbl_matkhau.Text = "Mật khẩu:";
            // 
            // lbl_tendangnhap
            // 
            this.lbl_tendangnhap.AutoSize = true;
            this.lbl_tendangnhap.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_tendangnhap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tendangnhap.Location = new System.Drawing.Point(66, 12);
            this.lbl_tendangnhap.Name = "lbl_tendangnhap";
            this.lbl_tendangnhap.Size = new System.Drawing.Size(138, 24);
            this.lbl_tendangnhap.TabIndex = 107;
            this.lbl_tendangnhap.Text = "Tên đăng nhập:";
            // 
            // pn_giangvien
            // 
            this.pn_giangvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_giangvien.Controls.Add(this.dgv_giangvien);
            this.pn_giangvien.Controls.Add(this.btn_quaylai);
            this.pn_giangvien.Controls.Add(this.linklbl_next);
            this.pn_giangvien.Controls.Add(this.linklbl_back);
            this.pn_giangvien.Controls.Add(this.lblPageNumber);
            this.pn_giangvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_giangvien.Location = new System.Drawing.Point(0, 262);
            this.pn_giangvien.Name = "pn_giangvien";
            this.pn_giangvien.Size = new System.Drawing.Size(993, 423);
            this.pn_giangvien.TabIndex = 3;
            // 
            // linklbl_next
            // 
            this.linklbl_next.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linklbl_next.AutoSize = true;
            this.linklbl_next.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_next.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linklbl_next.LinkColor = System.Drawing.Color.Black;
            this.linklbl_next.Location = new System.Drawing.Point(164, 382);
            this.linklbl_next.Name = "linklbl_next";
            this.linklbl_next.Size = new System.Drawing.Size(23, 28);
            this.linklbl_next.TabIndex = 5;
            this.linklbl_next.TabStop = true;
            this.linklbl_next.Text = ">";
            this.linklbl_next.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_next_LinkClicked);
            // 
            // linklbl_back
            // 
            this.linklbl_back.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linklbl_back.AutoSize = true;
            this.linklbl_back.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_back.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linklbl_back.LinkColor = System.Drawing.Color.Black;
            this.linklbl_back.Location = new System.Drawing.Point(41, 382);
            this.linklbl_back.Name = "linklbl_back";
            this.linklbl_back.Size = new System.Drawing.Size(23, 28);
            this.linklbl_back.TabIndex = 4;
            this.linklbl_back.TabStop = true;
            this.linklbl_back.Text = "<";
            this.linklbl_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_back_LinkClicked);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.Location = new System.Drawing.Point(85, 385);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(44, 21);
            this.lblPageNumber.TabIndex = 3;
            this.lblPageNumber.Text = "page";
            // 
            // dgv_giangvien
            // 
            this.dgv_giangvien.AllowUserToAddRows = false;
            this.dgv_giangvien.AllowUserToDeleteRows = false;
            this.dgv_giangvien.AllowUserToResizeColumns = false;
            this.dgv_giangvien.AllowUserToResizeRows = false;
            this.dgv_giangvien.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_giangvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_giangvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_giangvien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_giangvien.Location = new System.Drawing.Point(0, 5);
            this.dgv_giangvien.MultiSelect = false;
            this.dgv_giangvien.Name = "dgv_giangvien";
            this.dgv_giangvien.ReadOnly = true;
            this.dgv_giangvien.RowHeadersVisible = false;
            this.dgv_giangvien.RowHeadersWidth = 51;
            this.dgv_giangvien.RowTemplate.Height = 35;
            this.dgv_giangvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_giangvien.Size = new System.Drawing.Size(991, 365);
            this.dgv_giangvien.TabIndex = 71;
            this.dgv_giangvien.TabStop = false;
            // 
            // FrmGiangVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(993, 685);
            this.Controls.Add(this.pn_giangvien);
            this.Controls.Add(this.pn_themgiangvien);
            this.Controls.Add(this.pn_timkiemxoa);
            this.Controls.Add(this.pn_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giảng viên";
            this.Load += new System.EventHandler(this.FrmGiangVien_Load);
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.pn_timkiemxoa.ResumeLayout(false);
            this.pn_timkiemxoa.PerformLayout();
            this.pn_themgiangvien.ResumeLayout(false);
            this.pn_themgiangvien.PerformLayout();
            this.pn_giangvien.ResumeLayout(false);
            this.pn_giangvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_giangvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Panel pn_timkiemxoa;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_magv;
        private System.Windows.Forms.Label lbl_magv;
        private System.Windows.Forms.Panel pn_themgiangvien;
        private System.Windows.Forms.ComboBox cbb_khoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lbl_khoa;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_tendangnhap;
        private System.Windows.Forms.Label lbl_matkhau;
        private System.Windows.Forms.Label lbl_tendangnhap;
        private System.Windows.Forms.Panel pn_giangvien;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Label lbl_quanlysinhvien;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.LinkLabel linklbl_next;
        private System.Windows.Forms.LinkLabel linklbl_back;
        private System.Windows.Forms.DataGridView dgv_giangvien;
    }
}