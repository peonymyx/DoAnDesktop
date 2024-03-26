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
            this.pn_header = new System.Windows.Forms.Panel();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.lbl_tracuumonhoc = new System.Windows.Forms.Label();
            this.openFD_listbaihoc = new System.Windows.Forms.OpenFileDialog();
            this.menuS_chinhsuabaihoc = new System.Windows.Forms.MenuStrip();
            this.chỉnhSửaBàiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_chitietbaihoc = new System.Windows.Forms.Panel();
            this.pn_setup = new System.Windows.Forms.Panel();
            this.btn_upload = new System.Windows.Forms.Button();
            this.txt_tieude = new System.Windows.Forms.TextBox();
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.lbl_chonchuong = new System.Windows.Forms.Label();
            this.cb_chonchuong = new System.Windows.Forms.ComboBox();
            this.txt_IDBG = new System.Windows.Forms.TextBox();
            this.llb_IDBG = new System.Windows.Forms.Label();
            this.btn_themBG = new System.Windows.Forms.Button();
            this.btn_capnhatBG = new System.Windows.Forms.Button();
            this.btn_xoaBG = new System.Windows.Forms.Button();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.pn_list = new System.Windows.Forms.Panel();
            this.dgv_listbaihoc = new System.Windows.Forms.DataGridView();
            this.pn_lophoc = new System.Windows.Forms.Panel();
            this.pn_listtuan = new System.Windows.Forms.Panel();
            this.pn_chinhsuachuong = new System.Windows.Forms.Panel();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.lbl_noidungCH = new System.Windows.Forms.Label();
            this.lbl_maCH = new System.Windows.Forms.Label();
            this.txt_maCH = new System.Windows.Forms.TextBox();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_themchuong = new System.Windows.Forms.TextBox();
            this.pn_chuong = new System.Windows.Forms.Panel();
            this.dgv_chuong = new System.Windows.Forms.DataGridView();
            this.treev_baihoc = new System.Windows.Forms.TreeView();
            this.pn_header.SuspendLayout();
            this.menuS_chinhsuabaihoc.SuspendLayout();
            this.pn_chitietbaihoc.SuspendLayout();
            this.pn_setup.SuspendLayout();
            this.pn_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listbaihoc)).BeginInit();
            this.pn_lophoc.SuspendLayout();
            this.pn_listtuan.SuspendLayout();
            this.pn_chinhsuachuong.SuspendLayout();
            this.pn_chuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuong)).BeginInit();
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
            this.menuS_chinhsuabaihoc.Size = new System.Drawing.Size(993, 28);
            this.menuS_chinhsuabaihoc.TabIndex = 7;
            this.menuS_chinhsuabaihoc.Text = "menuStrip1";
            // 
            // chỉnhSửaBàiTậpToolStripMenuItem
            // 
            this.chỉnhSửaBàiTậpToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.chỉnhSửaBàiTậpToolStripMenuItem.Name = "chỉnhSửaBàiTậpToolStripMenuItem";
            this.chỉnhSửaBàiTậpToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.chỉnhSửaBàiTậpToolStripMenuItem.Text = "Chỉnh sửa bài tập";
            this.chỉnhSửaBàiTậpToolStripMenuItem.Click += new System.EventHandler(this.chinhSuaBaiTapToolStripMenuItem_Click);
            // 
            // pn_chitietbaihoc
            // 
            this.pn_chitietbaihoc.Controls.Add(this.pn_setup);
            this.pn_chitietbaihoc.Controls.Add(this.pn_list);
            this.pn_chitietbaihoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_chitietbaihoc.Location = new System.Drawing.Point(408, 28);
            this.pn_chitietbaihoc.Name = "pn_chitietbaihoc";
            this.pn_chitietbaihoc.Size = new System.Drawing.Size(585, 597);
            this.pn_chitietbaihoc.TabIndex = 6;
            // 
            // pn_setup
            // 
            this.pn_setup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_setup.Controls.Add(this.btn_upload);
            this.pn_setup.Controls.Add(this.txt_tieude);
            this.pn_setup.Controls.Add(this.lbl_tieude);
            this.pn_setup.Controls.Add(this.lbl_chonchuong);
            this.pn_setup.Controls.Add(this.cb_chonchuong);
            this.pn_setup.Controls.Add(this.txt_IDBG);
            this.pn_setup.Controls.Add(this.llb_IDBG);
            this.pn_setup.Controls.Add(this.btn_themBG);
            this.pn_setup.Controls.Add(this.btn_capnhatBG);
            this.pn_setup.Controls.Add(this.btn_xoaBG);
            this.pn_setup.Controls.Add(this.txt_file);
            this.pn_setup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_setup.Location = new System.Drawing.Point(0, 324);
            this.pn_setup.Name = "pn_setup";
            this.pn_setup.Size = new System.Drawing.Size(585, 273);
            this.pn_setup.TabIndex = 1;
            // 
            // btn_upload
            // 
            this.btn_upload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(39, 158);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(134, 36);
            this.btn_upload.TabIndex = 11;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // txt_tieude
            // 
            this.txt_tieude.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tieude.Location = new System.Drawing.Point(208, 105);
            this.txt_tieude.Name = "txt_tieude";
            this.txt_tieude.Size = new System.Drawing.Size(313, 36);
            this.txt_tieude.TabIndex = 8;
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieude.Location = new System.Drawing.Point(34, 107);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(162, 28);
            this.lbl_tieude.TabIndex = 8;
            this.lbl_tieude.Text = "Tiêu đề bài giảng";
            // 
            // lbl_chonchuong
            // 
            this.lbl_chonchuong.AutoSize = true;
            this.lbl_chonchuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chonchuong.Location = new System.Drawing.Point(34, 19);
            this.lbl_chonchuong.Name = "lbl_chonchuong";
            this.lbl_chonchuong.Size = new System.Drawing.Size(130, 28);
            this.lbl_chonchuong.TabIndex = 10;
            this.lbl_chonchuong.Text = "Chọn chương";
            // 
            // cb_chonchuong
            // 
            this.cb_chonchuong.DropDownWidth = 300;
            this.cb_chonchuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chonchuong.FormattingEnabled = true;
            this.cb_chonchuong.Location = new System.Drawing.Point(39, 54);
            this.cb_chonchuong.Name = "cb_chonchuong";
            this.cb_chonchuong.Size = new System.Drawing.Size(222, 36);
            this.cb_chonchuong.TabIndex = 9;
            this.cb_chonchuong.SelectedIndexChanged += new System.EventHandler(this.cb_chonchuong_SelectedIndexChanged);
            // 
            // txt_IDBG
            // 
            this.txt_IDBG.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDBG.Location = new System.Drawing.Point(348, 54);
            this.txt_IDBG.Name = "txt_IDBG";
            this.txt_IDBG.Size = new System.Drawing.Size(173, 36);
            this.txt_IDBG.TabIndex = 8;
            // 
            // llb_IDBG
            // 
            this.llb_IDBG.AutoSize = true;
            this.llb_IDBG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_IDBG.Location = new System.Drawing.Point(343, 19);
            this.llb_IDBG.Name = "llb_IDBG";
            this.llb_IDBG.Size = new System.Drawing.Size(127, 28);
            this.llb_IDBG.TabIndex = 5;
            this.llb_IDBG.Text = "Mã bài giảng";
            // 
            // btn_themBG
            // 
            this.btn_themBG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themBG.Location = new System.Drawing.Point(39, 210);
            this.btn_themBG.Name = "btn_themBG";
            this.btn_themBG.Size = new System.Drawing.Size(113, 40);
            this.btn_themBG.TabIndex = 4;
            this.btn_themBG.Text = "Thêm";
            this.btn_themBG.UseVisualStyleBackColor = true;
            this.btn_themBG.Click += new System.EventHandler(this.btn_themBG_Click);
            // 
            // btn_capnhatBG
            // 
            this.btn_capnhatBG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhatBG.Location = new System.Drawing.Point(234, 210);
            this.btn_capnhatBG.Name = "btn_capnhatBG";
            this.btn_capnhatBG.Size = new System.Drawing.Size(113, 40);
            this.btn_capnhatBG.TabIndex = 3;
            this.btn_capnhatBG.Text = "Cập Nhật";
            this.btn_capnhatBG.UseVisualStyleBackColor = true;
            this.btn_capnhatBG.Click += new System.EventHandler(this.btn_capnhatBG_Click);
            // 
            // btn_xoaBG
            // 
            this.btn_xoaBG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaBG.Location = new System.Drawing.Point(423, 210);
            this.btn_xoaBG.Name = "btn_xoaBG";
            this.btn_xoaBG.Size = new System.Drawing.Size(113, 40);
            this.btn_xoaBG.TabIndex = 2;
            this.btn_xoaBG.Text = "Xóa";
            this.btn_xoaBG.UseVisualStyleBackColor = true;
            this.btn_xoaBG.Click += new System.EventHandler(this.btn_xoaBG_Click);
            // 
            // txt_file
            // 
            this.txt_file.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_file.Location = new System.Drawing.Point(208, 158);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(313, 36);
            this.txt_file.TabIndex = 0;
            // 
            // pn_list
            // 
            this.pn_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_list.Controls.Add(this.dgv_listbaihoc);
            this.pn_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_list.Location = new System.Drawing.Point(0, 0);
            this.pn_list.Name = "pn_list";
            this.pn_list.Size = new System.Drawing.Size(585, 324);
            this.pn_list.TabIndex = 0;
            // 
            // dgv_listbaihoc
            // 
            this.dgv_listbaihoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listbaihoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_listbaihoc.Location = new System.Drawing.Point(0, 0);
            this.dgv_listbaihoc.Name = "dgv_listbaihoc";
            this.dgv_listbaihoc.RowHeadersWidth = 51;
            this.dgv_listbaihoc.RowTemplate.Height = 24;
            this.dgv_listbaihoc.Size = new System.Drawing.Size(583, 322);
            this.dgv_listbaihoc.TabIndex = 0;
            // 
            // pn_lophoc
            // 
            this.pn_lophoc.Controls.Add(this.pn_chitietbaihoc);
            this.pn_lophoc.Controls.Add(this.pn_listtuan);
            this.pn_lophoc.Controls.Add(this.menuS_chinhsuabaihoc);
            this.pn_lophoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_lophoc.Location = new System.Drawing.Point(0, 60);
            this.pn_lophoc.Name = "pn_lophoc";
            this.pn_lophoc.Size = new System.Drawing.Size(993, 625);
            this.pn_lophoc.TabIndex = 5;
            // 
            // pn_listtuan
            // 
            this.pn_listtuan.Controls.Add(this.pn_chinhsuachuong);
            this.pn_listtuan.Controls.Add(this.pn_chuong);
            this.pn_listtuan.Controls.Add(this.treev_baihoc);
            this.pn_listtuan.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_listtuan.Location = new System.Drawing.Point(0, 28);
            this.pn_listtuan.Name = "pn_listtuan";
            this.pn_listtuan.Size = new System.Drawing.Size(408, 597);
            this.pn_listtuan.TabIndex = 5;
            // 
            // pn_chinhsuachuong
            // 
            this.pn_chinhsuachuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_chinhsuachuong.Controls.Add(this.btn_xoa);
            this.pn_chinhsuachuong.Controls.Add(this.lbl_noidungCH);
            this.pn_chinhsuachuong.Controls.Add(this.lbl_maCH);
            this.pn_chinhsuachuong.Controls.Add(this.txt_maCH);
            this.pn_chinhsuachuong.Controls.Add(this.btn_capnhat);
            this.pn_chinhsuachuong.Controls.Add(this.btn_them);
            this.pn_chinhsuachuong.Controls.Add(this.txt_themchuong);
            this.pn_chinhsuachuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_chinhsuachuong.Location = new System.Drawing.Point(0, 324);
            this.pn_chinhsuachuong.Name = "pn_chinhsuachuong";
            this.pn_chinhsuachuong.Size = new System.Drawing.Size(408, 273);
            this.pn_chinhsuachuong.TabIndex = 2;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(282, 210);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(106, 36);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // lbl_noidungCH
            // 
            this.lbl_noidungCH.AutoSize = true;
            this.lbl_noidungCH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noidungCH.Location = new System.Drawing.Point(25, 92);
            this.lbl_noidungCH.Name = "lbl_noidungCH";
            this.lbl_noidungCH.Size = new System.Drawing.Size(204, 28);
            this.lbl_noidungCH.TabIndex = 6;
            this.lbl_noidungCH.Text = "Nội dung chương học";
            // 
            // lbl_maCH
            // 
            this.lbl_maCH.AutoSize = true;
            this.lbl_maCH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maCH.Location = new System.Drawing.Point(25, 33);
            this.lbl_maCH.Name = "lbl_maCH";
            this.lbl_maCH.Size = new System.Drawing.Size(149, 28);
            this.lbl_maCH.TabIndex = 5;
            this.lbl_maCH.Text = "Mã chương học";
            // 
            // txt_maCH
            // 
            this.txt_maCH.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maCH.Location = new System.Drawing.Point(215, 31);
            this.txt_maCH.Name = "txt_maCH";
            this.txt_maCH.Size = new System.Drawing.Size(173, 36);
            this.txt_maCH.TabIndex = 4;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.Location = new System.Drawing.Point(143, 210);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(106, 36);
            this.btn_capnhat.TabIndex = 3;
            this.btn_capnhat.Text = "Cập Nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(27, 210);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(82, 36);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_themchuong
            // 
            this.txt_themchuong.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_themchuong.Location = new System.Drawing.Point(27, 140);
            this.txt_themchuong.Name = "txt_themchuong";
            this.txt_themchuong.Size = new System.Drawing.Size(358, 36);
            this.txt_themchuong.TabIndex = 1;
            // 
            // pn_chuong
            // 
            this.pn_chuong.Controls.Add(this.dgv_chuong);
            this.pn_chuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_chuong.Location = new System.Drawing.Point(0, 0);
            this.pn_chuong.Name = "pn_chuong";
            this.pn_chuong.Size = new System.Drawing.Size(408, 324);
            this.pn_chuong.TabIndex = 1;
            // 
            // dgv_chuong
            // 
            this.dgv_chuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_chuong.Location = new System.Drawing.Point(0, 0);
            this.dgv_chuong.Name = "dgv_chuong";
            this.dgv_chuong.RowHeadersWidth = 51;
            this.dgv_chuong.RowTemplate.Height = 24;
            this.dgv_chuong.Size = new System.Drawing.Size(408, 324);
            this.dgv_chuong.TabIndex = 0;
            // 
            // treev_baihoc
            // 
            this.treev_baihoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treev_baihoc.Location = new System.Drawing.Point(0, 0);
            this.treev_baihoc.Name = "treev_baihoc";
            this.treev_baihoc.Size = new System.Drawing.Size(408, 597);
            this.treev_baihoc.TabIndex = 0;
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
            this.pn_chitietbaihoc.ResumeLayout(false);
            this.pn_setup.ResumeLayout(false);
            this.pn_setup.PerformLayout();
            this.pn_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listbaihoc)).EndInit();
            this.pn_lophoc.ResumeLayout(false);
            this.pn_lophoc.PerformLayout();
            this.pn_listtuan.ResumeLayout(false);
            this.pn_chinhsuachuong.ResumeLayout(false);
            this.pn_chinhsuachuong.PerformLayout();
            this.pn_chuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Label lbl_tracuumonhoc;
        private System.Windows.Forms.OpenFileDialog openFD_listbaihoc;
        private System.Windows.Forms.MenuStrip menuS_chinhsuabaihoc;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaBàiTậpToolStripMenuItem;
        private System.Windows.Forms.Panel pn_chitietbaihoc;
        private System.Windows.Forms.Panel pn_setup;
        private System.Windows.Forms.Button btn_xoaBG;
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.Panel pn_list;
        private System.Windows.Forms.DataGridView dgv_listbaihoc;
        private System.Windows.Forms.Panel pn_lophoc;
        private System.Windows.Forms.Panel pn_listtuan;
        private System.Windows.Forms.TreeView treev_baihoc;
        private System.Windows.Forms.Panel pn_chinhsuachuong;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_themchuong;
        private System.Windows.Forms.Panel pn_chuong;
        private System.Windows.Forms.DataGridView dgv_chuong;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Label lbl_noidungCH;
        private System.Windows.Forms.Label lbl_maCH;
        private System.Windows.Forms.TextBox txt_maCH;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhatBG;
        private System.Windows.Forms.Label llb_IDBG;
        private System.Windows.Forms.TextBox txt_IDBG;
        private System.Windows.Forms.ComboBox cb_chonchuong;
        private System.Windows.Forms.Label lbl_chonchuong;
        private System.Windows.Forms.TextBox txt_tieude;
        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_themBG;
    }
}