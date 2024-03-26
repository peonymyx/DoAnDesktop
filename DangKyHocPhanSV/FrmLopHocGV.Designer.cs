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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.pn_list = new System.Windows.Forms.Panel();
            this.dgv_listbaihoc = new System.Windows.Forms.DataGridView();
            this.pn_lophoc = new System.Windows.Forms.Panel();
            this.pn_listtuan = new System.Windows.Forms.Panel();
            this.pn_chinhsuachuong = new System.Windows.Forms.Panel();
            this.lbl_noidungCH = new System.Windows.Forms.Label();
            this.lbl_maCH = new System.Windows.Forms.Label();
            this.txt_maCH = new System.Windows.Forms.TextBox();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_themchuong = new System.Windows.Forms.TextBox();
            this.pn_chuong = new System.Windows.Forms.Panel();
            this.dgv_chuong = new System.Windows.Forms.DataGridView();
            this.treev_baihoc = new System.Windows.Forms.TreeView();
            this.btn_xoa = new System.Windows.Forms.Button();
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
            this.chỉnhSửaBàiTậpToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaBàiTậpToolStripMenuItem_Click);
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
            this.pn_setup.Controls.Add(this.btn_delete);
            this.pn_setup.Controls.Add(this.btn_upload);
            this.pn_setup.Controls.Add(this.txt_file);
            this.pn_setup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_setup.Location = new System.Drawing.Point(0, 469);
            this.pn_setup.Name = "pn_setup";
            this.pn_setup.Size = new System.Drawing.Size(585, 128);
            this.pn_setup.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.btn_delete.Location = new System.Drawing.Point(408, 69);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(113, 40);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_upload
            // 
            this.btn_upload.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.btn_upload.Location = new System.Drawing.Point(71, 69);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(113, 40);
            this.btn_upload.TabIndex = 1;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // txt_file
            // 
            this.txt_file.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_file.Location = new System.Drawing.Point(71, 14);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(450, 36);
            this.txt_file.TabIndex = 0;
            // 
            // pn_list
            // 
            this.pn_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_list.Controls.Add(this.dgv_listbaihoc);
            this.pn_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_list.Location = new System.Drawing.Point(0, 0);
            this.pn_list.Name = "pn_list";
            this.pn_list.Size = new System.Drawing.Size(585, 469);
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
            this.dgv_listbaihoc.Size = new System.Drawing.Size(583, 467);
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
            this.pn_chinhsuachuong.Location = new System.Drawing.Point(0, 469);
            this.pn_chinhsuachuong.Name = "pn_chinhsuachuong";
            this.pn_chinhsuachuong.Size = new System.Drawing.Size(408, 128);
            this.pn_chinhsuachuong.TabIndex = 2;
            // 
            // lbl_noidungCH
            // 
            this.lbl_noidungCH.AutoSize = true;
            this.lbl_noidungCH.Location = new System.Drawing.Point(166, 19);
            this.lbl_noidungCH.Name = "lbl_noidungCH";
            this.lbl_noidungCH.Size = new System.Drawing.Size(83, 16);
            this.lbl_noidungCH.TabIndex = 6;
            this.lbl_noidungCH.Text = "Nội dung CH";
            // 
            // lbl_maCH
            // 
            this.lbl_maCH.AutoSize = true;
            this.lbl_maCH.Location = new System.Drawing.Point(50, 16);
            this.lbl_maCH.Name = "lbl_maCH";
            this.lbl_maCH.Size = new System.Drawing.Size(48, 16);
            this.lbl_maCH.TabIndex = 5;
            this.lbl_maCH.Text = "Mã CH";
            // 
            // txt_maCH
            // 
            this.txt_maCH.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maCH.Location = new System.Drawing.Point(51, 52);
            this.txt_maCH.Name = "txt_maCH";
            this.txt_maCH.Size = new System.Drawing.Size(71, 36);
            this.txt_maCH.TabIndex = 4;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.btn_capnhat.Location = new System.Drawing.Point(266, 94);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(95, 29);
            this.btn_capnhat.TabIndex = 3;
            this.btn_capnhat.Text = "Cập Nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.btn_them.Location = new System.Drawing.Point(37, 94);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(85, 29);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_themchuong
            // 
            this.txt_themchuong.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_themchuong.Location = new System.Drawing.Point(159, 52);
            this.txt_themchuong.Name = "txt_themchuong";
            this.txt_themchuong.Size = new System.Drawing.Size(242, 36);
            this.txt_themchuong.TabIndex = 1;
            // 
            // pn_chuong
            // 
            this.pn_chuong.Controls.Add(this.dgv_chuong);
            this.pn_chuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_chuong.Location = new System.Drawing.Point(0, 0);
            this.pn_chuong.Name = "pn_chuong";
            this.pn_chuong.Size = new System.Drawing.Size(408, 469);
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
            this.dgv_chuong.Size = new System.Drawing.Size(408, 469);
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
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(161, 99);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(87, 27);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
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
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_upload;
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
    }
}