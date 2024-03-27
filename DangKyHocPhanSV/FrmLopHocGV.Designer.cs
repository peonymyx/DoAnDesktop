namespace DangKyHocPhanSV
{
    partial class FrmLopHocGV
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
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.lbl_tracuumonhoc = new System.Windows.Forms.Label();
            this.openFD_listbaihoc = new System.Windows.Forms.OpenFileDialog();
            this.menuS_chinhsuabaihoc = new System.Windows.Forms.MenuStrip();
            this.chỉnhSửaBàiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_lophoc = new System.Windows.Forms.Panel();
            this.tblopn_lophoc = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_themchuong = new System.Windows.Forms.TextBox();
            this.lbl_noidungCH = new System.Windows.Forms.Label();
            this.lbl_maCH = new System.Windows.Forms.Label();
            this.txt_maCH = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.tbolpn_chinhsuabainop = new System.Windows.Forms.TableLayoutPanel();
            this.btn_themBG = new System.Windows.Forms.Button();
            this.btn_xoaBG = new System.Windows.Forms.Button();
            this.btn_capnhatBG = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_upload = new System.Windows.Forms.Button();
            this.lbl_chonchuong = new System.Windows.Forms.Label();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.llb_IDBG = new System.Windows.Forms.Label();
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.cb_chonchuong = new System.Windows.Forms.ComboBox();
            this.txt_IDBG = new System.Windows.Forms.TextBox();
            this.txt_tieude = new System.Windows.Forms.TextBox();
            this.dgv_chuong = new System.Windows.Forms.DataGridView();
            this.dgv_listbaihoc = new System.Windows.Forms.DataGridView();
            this.pn_header.SuspendLayout();
            this.menuS_chinhsuabaihoc.SuspendLayout();
            this.pn_lophoc.SuspendLayout();
            this.tblopn_lophoc.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tbolpn_chinhsuabainop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listbaihoc)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_header
            // 
            this.pn_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_header.Controls.Add(this.btn_quaylai);
            this.pn_header.Controls.Add(this.lbl_tracuumonhoc);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(993, 60);
            this.pn_header.TabIndex = 1;
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_quaylai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(781, 10);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(124, 41);
            this.btn_quaylai.TabIndex = 0;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // lbl_tracuumonhoc
            // 
            this.lbl_tracuumonhoc.AutoSize = true;
            this.lbl_tracuumonhoc.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tracuumonhoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tracuumonhoc.Location = new System.Drawing.Point(76, 6);
            this.lbl_tracuumonhoc.Name = "lbl_tracuumonhoc";
            this.lbl_tracuumonhoc.Size = new System.Drawing.Size(127, 40);
            this.lbl_tracuumonhoc.TabIndex = 3;
            this.lbl_tracuumonhoc.Text = "Lớp học";
            // 
            // openFD_listbaihoc
            // 
            this.openFD_listbaihoc.FileName = "openFileDialog1";
            // 
            // menuS_chinhsuabaihoc
            // 
            this.menuS_chinhsuabaihoc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuS_chinhsuabaihoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaBàiTậpToolStripMenuItem});
            this.menuS_chinhsuabaihoc.Location = new System.Drawing.Point(0, 0);
            this.menuS_chinhsuabaihoc.Name = "menuS_chinhsuabaihoc";
            this.menuS_chinhsuabaihoc.Size = new System.Drawing.Size(993, 36);
            this.menuS_chinhsuabaihoc.TabIndex = 7;
            this.menuS_chinhsuabaihoc.Text = "menuStrip1";
            // 
            // chỉnhSửaBàiTậpToolStripMenuItem
            // 
            this.chỉnhSửaBàiTậpToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.chỉnhSửaBàiTậpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chỉnhSửaBàiTậpToolStripMenuItem.Name = "chỉnhSửaBàiTậpToolStripMenuItem";
            this.chỉnhSửaBàiTậpToolStripMenuItem.Size = new System.Drawing.Size(177, 32);
            this.chỉnhSửaBàiTậpToolStripMenuItem.Text = "Chỉnh sửa bài tập";
            this.chỉnhSửaBàiTậpToolStripMenuItem.Click += new System.EventHandler(this.chinhSuaBaiTapToolStripMenuItem_Click);
            // 
            // pn_lophoc
            // 
            this.pn_lophoc.Controls.Add(this.tblopn_lophoc);
            this.pn_lophoc.Controls.Add(this.menuS_chinhsuabaihoc);
            this.pn_lophoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_lophoc.Location = new System.Drawing.Point(0, 60);
            this.pn_lophoc.Name = "pn_lophoc";
            this.pn_lophoc.Size = new System.Drawing.Size(993, 625);
            this.pn_lophoc.TabIndex = 5;
            // 
            // tblopn_lophoc
            // 
            this.tblopn_lophoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblopn_lophoc.ColumnCount = 2;
            this.tblopn_lophoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.72727F));
            this.tblopn_lophoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.27273F));
            this.tblopn_lophoc.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tblopn_lophoc.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tblopn_lophoc.Controls.Add(this.tbolpn_chinhsuabainop, 1, 2);
            this.tblopn_lophoc.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tblopn_lophoc.Controls.Add(this.dgv_chuong, 0, 0);
            this.tblopn_lophoc.Controls.Add(this.dgv_listbaihoc, 1, 0);
            this.tblopn_lophoc.Location = new System.Drawing.Point(0, 39);
            this.tblopn_lophoc.Name = "tblopn_lophoc";
            this.tblopn_lophoc.RowCount = 3;
            this.tblopn_lophoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.31776F));
            this.tblopn_lophoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.68224F));
            this.tblopn_lophoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblopn_lophoc.Size = new System.Drawing.Size(990, 583);
            this.tblopn_lophoc.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txt_themchuong, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.lbl_noidungCH, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_maCH, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_maCH, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 310);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(416, 214);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // txt_themchuong
            // 
            this.txt_themchuong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_themchuong.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_themchuong.Location = new System.Drawing.Point(3, 168);
            this.txt_themchuong.Name = "txt_themchuong";
            this.txt_themchuong.Size = new System.Drawing.Size(358, 36);
            this.txt_themchuong.TabIndex = 1;
            // 
            // lbl_noidungCH
            // 
            this.lbl_noidungCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_noidungCH.AutoSize = true;
            this.lbl_noidungCH.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noidungCH.Location = new System.Drawing.Point(3, 131);
            this.lbl_noidungCH.Name = "lbl_noidungCH";
            this.lbl_noidungCH.Size = new System.Drawing.Size(212, 28);
            this.lbl_noidungCH.TabIndex = 6;
            this.lbl_noidungCH.Text = "Nội dung chương học";
            // 
            // lbl_maCH
            // 
            this.lbl_maCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_maCH.AutoSize = true;
            this.lbl_maCH.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maCH.Location = new System.Drawing.Point(3, 25);
            this.lbl_maCH.Name = "lbl_maCH";
            this.lbl_maCH.Size = new System.Drawing.Size(159, 28);
            this.lbl_maCH.TabIndex = 5;
            this.lbl_maCH.Text = "Mã chương học";
            // 
            // txt_maCH
            // 
            this.txt_maCH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_maCH.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maCH.Location = new System.Drawing.Point(3, 61);
            this.txt_maCH.Name = "txt_maCH";
            this.txt_maCH.Size = new System.Drawing.Size(173, 36);
            this.txt_maCH.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.2211F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.44557F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btn_xoa, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_them, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_capnhat, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 530);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(416, 50);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xoa.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(282, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(128, 40);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_them.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(5, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(128, 40);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_capnhat.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.Location = new System.Drawing.Point(143, 3);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(128, 40);
            this.btn_capnhat.TabIndex = 3;
            this.btn_capnhat.Text = "Cập Nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // tbolpn_chinhsuabainop
            // 
            this.tbolpn_chinhsuabainop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbolpn_chinhsuabainop.BackColor = System.Drawing.SystemColors.Control;
            this.tbolpn_chinhsuabainop.ColumnCount = 3;
            this.tbolpn_chinhsuabainop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbolpn_chinhsuabainop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbolpn_chinhsuabainop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbolpn_chinhsuabainop.Controls.Add(this.btn_themBG, 0, 0);
            this.tbolpn_chinhsuabainop.Controls.Add(this.btn_xoaBG, 2, 0);
            this.tbolpn_chinhsuabainop.Controls.Add(this.btn_capnhatBG, 1, 0);
            this.tbolpn_chinhsuabainop.Location = new System.Drawing.Point(425, 530);
            this.tbolpn_chinhsuabainop.Name = "tbolpn_chinhsuabainop";
            this.tbolpn_chinhsuabainop.RowCount = 1;
            this.tbolpn_chinhsuabainop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbolpn_chinhsuabainop.Size = new System.Drawing.Size(562, 50);
            this.tbolpn_chinhsuabainop.TabIndex = 5;
            // 
            // btn_themBG
            // 
            this.btn_themBG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_themBG.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themBG.Location = new System.Drawing.Point(29, 3);
            this.btn_themBG.Name = "btn_themBG";
            this.btn_themBG.Size = new System.Drawing.Size(128, 40);
            this.btn_themBG.TabIndex = 4;
            this.btn_themBG.Text = "Thêm";
            this.btn_themBG.UseVisualStyleBackColor = true;
            this.btn_themBG.Click += new System.EventHandler(this.btn_themBG_Click);
            // 
            // btn_xoaBG
            // 
            this.btn_xoaBG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xoaBG.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaBG.Location = new System.Drawing.Point(404, 3);
            this.btn_xoaBG.Name = "btn_xoaBG";
            this.btn_xoaBG.Size = new System.Drawing.Size(128, 40);
            this.btn_xoaBG.TabIndex = 2;
            this.btn_xoaBG.Text = "Xóa";
            this.btn_xoaBG.UseVisualStyleBackColor = true;
            this.btn_xoaBG.Click += new System.EventHandler(this.btn_xoaBG_Click);
            // 
            // btn_capnhatBG
            // 
            this.btn_capnhatBG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_capnhatBG.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhatBG.Location = new System.Drawing.Point(216, 3);
            this.btn_capnhatBG.Name = "btn_capnhatBG";
            this.btn_capnhatBG.Size = new System.Drawing.Size(128, 40);
            this.btn_capnhatBG.TabIndex = 3;
            this.btn_capnhatBG.Text = "Cập Nhật";
            this.btn_capnhatBG.UseVisualStyleBackColor = true;
            this.btn_capnhatBG.Click += new System.EventHandler(this.btn_capnhatBG_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.55844F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.44156F));
            this.tableLayoutPanel1.Controls.Add(this.btn_upload, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_chonchuong, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_file, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.llb_IDBG, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tieude, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_chonchuong, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_IDBG, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_tieude, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(425, 310);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 214);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_upload
            // 
            this.btn_upload.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_upload.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(3, 168);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(208, 36);
            this.btn_upload.TabIndex = 11;
            this.btn_upload.Text = "Upload/Đường dẫn";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // lbl_chonchuong
            // 
            this.lbl_chonchuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_chonchuong.AutoSize = true;
            this.lbl_chonchuong.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chonchuong.Location = new System.Drawing.Point(3, 25);
            this.lbl_chonchuong.Name = "lbl_chonchuong";
            this.lbl_chonchuong.Size = new System.Drawing.Size(137, 28);
            this.lbl_chonchuong.TabIndex = 10;
            this.lbl_chonchuong.Text = "Chọn chương";
            // 
            // txt_file
            // 
            this.txt_file.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_file.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_file.Location = new System.Drawing.Point(236, 168);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(236, 36);
            this.txt_file.TabIndex = 0;
            // 
            // llb_IDBG
            // 
            this.llb_IDBG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llb_IDBG.AutoSize = true;
            this.llb_IDBG.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_IDBG.Location = new System.Drawing.Point(236, 25);
            this.llb_IDBG.Name = "llb_IDBG";
            this.llb_IDBG.Size = new System.Drawing.Size(131, 28);
            this.llb_IDBG.TabIndex = 5;
            this.llb_IDBG.Text = "Mã bài giảng";
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieude.Location = new System.Drawing.Point(3, 118);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(168, 28);
            this.lbl_tieude.TabIndex = 8;
            this.lbl_tieude.Text = "Tiêu đề bài giảng";
            // 
            // cb_chonchuong
            // 
            this.cb_chonchuong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_chonchuong.DropDownWidth = 300;
            this.cb_chonchuong.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chonchuong.FormattingEnabled = true;
            this.cb_chonchuong.Location = new System.Drawing.Point(3, 61);
            this.cb_chonchuong.Name = "cb_chonchuong";
            this.cb_chonchuong.Size = new System.Drawing.Size(227, 36);
            this.cb_chonchuong.TabIndex = 9;
            this.cb_chonchuong.SelectedIndexChanged += new System.EventHandler(this.cb_chonchuong_SelectedIndexChanged);
            // 
            // txt_IDBG
            // 
            this.txt_IDBG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_IDBG.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDBG.Location = new System.Drawing.Point(236, 61);
            this.txt_IDBG.Name = "txt_IDBG";
            this.txt_IDBG.Size = new System.Drawing.Size(89, 36);
            this.txt_IDBG.TabIndex = 8;
            // 
            // txt_tieude
            // 
            this.txt_tieude.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_tieude.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tieude.Location = new System.Drawing.Point(236, 114);
            this.txt_tieude.Name = "txt_tieude";
            this.txt_tieude.Size = new System.Drawing.Size(236, 36);
            this.txt_tieude.TabIndex = 8;
            // 
            // dgv_chuong
            // 
            this.dgv_chuong.AllowUserToAddRows = false;
            this.dgv_chuong.AllowUserToDeleteRows = false;
            this.dgv_chuong.AllowUserToResizeColumns = false;
            this.dgv_chuong.AllowUserToResizeRows = false;
            this.dgv_chuong.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_chuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_chuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_chuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_chuong.Location = new System.Drawing.Point(3, 3);
            this.dgv_chuong.MultiSelect = false;
            this.dgv_chuong.Name = "dgv_chuong";
            this.dgv_chuong.ReadOnly = true;
            this.dgv_chuong.RowHeadersVisible = false;
            this.dgv_chuong.RowHeadersWidth = 51;
            this.dgv_chuong.RowTemplate.Height = 30;
            this.dgv_chuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_chuong.Size = new System.Drawing.Size(416, 301);
            this.dgv_chuong.TabIndex = 1;
            this.dgv_chuong.TabStop = false;
            // 
            // dgv_listbaihoc
            // 
            this.dgv_listbaihoc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_listbaihoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listbaihoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_listbaihoc.Location = new System.Drawing.Point(425, 3);
            this.dgv_listbaihoc.Name = "dgv_listbaihoc";
            this.dgv_listbaihoc.RowHeadersWidth = 51;
            this.dgv_listbaihoc.RowTemplate.Height = 24;
            this.dgv_listbaihoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listbaihoc.Size = new System.Drawing.Size(562, 301);
            this.dgv_listbaihoc.TabIndex = 0;
            this.dgv_listbaihoc.TabStop = false;
            // 
            // FrmLopHocGV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(993, 685);
            this.Controls.Add(this.pn_lophoc);
            this.Controls.Add(this.pn_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLopHocGV";
            this.Text = "FrmLopHocGV";
            this.Load += new System.EventHandler(this.FrmLopHocGV_Load);
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.menuS_chinhsuabaihoc.ResumeLayout(false);
            this.menuS_chinhsuabaihoc.PerformLayout();
            this.pn_lophoc.ResumeLayout(false);
            this.pn_lophoc.PerformLayout();
            this.tblopn_lophoc.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tbolpn_chinhsuabainop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listbaihoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Label lbl_tracuumonhoc;
        private System.Windows.Forms.OpenFileDialog openFD_listbaihoc;
        private System.Windows.Forms.MenuStrip menuS_chinhsuabaihoc;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaBàiTậpToolStripMenuItem;
        private System.Windows.Forms.Panel pn_lophoc;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_themchuong;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Label lbl_noidungCH;
        private System.Windows.Forms.Label lbl_maCH;
        private System.Windows.Forms.TextBox txt_maCH;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TableLayoutPanel tblopn_lophoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tbolpn_chinhsuabainop;
        private System.Windows.Forms.Button btn_themBG;
        private System.Windows.Forms.Button btn_xoaBG;
        private System.Windows.Forms.Button btn_capnhatBG;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label lbl_chonchuong;
        private System.Windows.Forms.TextBox txt_tieude;
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.Label llb_IDBG;
        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.ComboBox cb_chonchuong;
        private System.Windows.Forms.TextBox txt_IDBG;
        private System.Windows.Forms.DataGridView dgv_chuong;
        private System.Windows.Forms.DataGridView dgv_listbaihoc;
    }
}