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
            this.pn_lophoc = new System.Windows.Forms.Panel();
            this.pn_chitietbaihoc = new System.Windows.Forms.Panel();
            this.pn_listtuan = new System.Windows.Forms.Panel();
            this.treev_baihoc = new System.Windows.Forms.TreeView();
            this.menuS_chinhsuabaihoc = new System.Windows.Forms.MenuStrip();
            this.chỉnhSửaBàiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_setup = new System.Windows.Forms.Panel();
            this.pn_list = new System.Windows.Forms.Panel();
            this.dgv_listbaihoc = new System.Windows.Forms.DataGridView();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.openFD_listbaihoc = new System.Windows.Forms.OpenFileDialog();
            this.pn_header.SuspendLayout();
            this.pn_lophoc.SuspendLayout();
            this.pn_chitietbaihoc.SuspendLayout();
            this.pn_listtuan.SuspendLayout();
            this.menuS_chinhsuabaihoc.SuspendLayout();
            this.pn_setup.SuspendLayout();
            this.pn_list.SuspendLayout();
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
            this.btn_quaylai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(781, 10);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(124, 41);
            this.btn_quaylai.TabIndex = 0;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
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
            // pn_chitietbaihoc
            // 
            this.pn_chitietbaihoc.Controls.Add(this.pn_setup);
            this.pn_chitietbaihoc.Controls.Add(this.pn_list);
            this.pn_chitietbaihoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_chitietbaihoc.Location = new System.Drawing.Point(319, 28);
            this.pn_chitietbaihoc.Name = "pn_chitietbaihoc";
            this.pn_chitietbaihoc.Size = new System.Drawing.Size(674, 597);
            this.pn_chitietbaihoc.TabIndex = 6;
            // 
            // pn_listtuan
            // 
            this.pn_listtuan.Controls.Add(this.treev_baihoc);
            this.pn_listtuan.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_listtuan.Location = new System.Drawing.Point(0, 28);
            this.pn_listtuan.Name = "pn_listtuan";
            this.pn_listtuan.Size = new System.Drawing.Size(319, 597);
            this.pn_listtuan.TabIndex = 5;
            // 
            // treev_baihoc
            // 
            this.treev_baihoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treev_baihoc.Location = new System.Drawing.Point(0, 0);
            this.treev_baihoc.Name = "treev_baihoc";
            this.treev_baihoc.Size = new System.Drawing.Size(319, 597);
            this.treev_baihoc.TabIndex = 0;
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
            this.chỉnhSửaBàiTậpToolStripMenuItem.Name = "chỉnhSửaBàiTậpToolStripMenuItem";
            this.chỉnhSửaBàiTậpToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.chỉnhSửaBàiTậpToolStripMenuItem.Text = "Chỉnh sửa bài tập";
            this.chỉnhSửaBàiTậpToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaBàiTậpToolStripMenuItem_Click);
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
            this.pn_setup.Size = new System.Drawing.Size(674, 128);
            this.pn_setup.TabIndex = 1;
            // 
            // pn_list
            // 
            this.pn_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_list.Controls.Add(this.dgv_listbaihoc);
            this.pn_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_list.Location = new System.Drawing.Point(0, 0);
            this.pn_list.Name = "pn_list";
            this.pn_list.Size = new System.Drawing.Size(674, 469);
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
            this.dgv_listbaihoc.Size = new System.Drawing.Size(672, 467);
            this.dgv_listbaihoc.TabIndex = 0;
            // 
            // txt_file
            // 
            this.txt_file.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_file.Location = new System.Drawing.Point(71, 14);
            this.txt_file.Name = "txt_file";
            this.txt_file.ReadOnly = true;
            this.txt_file.Size = new System.Drawing.Size(546, 36);
            this.txt_file.TabIndex = 0;
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
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.btn_delete.Location = new System.Drawing.Point(201, 69);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(113, 40);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // openFD_listbaihoc
            // 
            this.openFD_listbaihoc.FileName = "openFileDialog1";
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
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.pn_lophoc.ResumeLayout(false);
            this.pn_lophoc.PerformLayout();
            this.pn_chitietbaihoc.ResumeLayout(false);
            this.pn_listtuan.ResumeLayout(false);
            this.menuS_chinhsuabaihoc.ResumeLayout(false);
            this.menuS_chinhsuabaihoc.PerformLayout();
            this.pn_setup.ResumeLayout(false);
            this.pn_setup.PerformLayout();
            this.pn_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listbaihoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Label lbl_tracuumonhoc;
        private System.Windows.Forms.Panel pn_lophoc;
        private System.Windows.Forms.Panel pn_chitietbaihoc;
        private System.Windows.Forms.Panel pn_setup;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.Panel pn_list;
        private System.Windows.Forms.DataGridView dgv_listbaihoc;
        private System.Windows.Forms.Panel pn_listtuan;
        private System.Windows.Forms.TreeView treev_baihoc;
        private System.Windows.Forms.MenuStrip menuS_chinhsuabaihoc;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaBàiTậpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFD_listbaihoc;
    }
}