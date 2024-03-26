namespace DangKyHocPhanSV
{
    partial class FrmLopHocSV
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
            this.treev_baihoc = new System.Windows.Forms.TreeView();
            this.pn_listtuan = new System.Windows.Forms.Panel();
            this.pn_lophoc = new System.Windows.Forms.Panel();
            this.pn_chitietbaihoc = new System.Windows.Forms.Panel();
            this.menuS_chinhsuabaihoc = new System.Windows.Forms.MenuStrip();
            this.menustrip_xemdsbt = new System.Windows.Forms.ToolStripMenuItem();
            this.openFD_listbaihoc = new System.Windows.Forms.OpenFileDialog();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.lbl_lophoc = new System.Windows.Forms.Label();
            this.pn_header = new System.Windows.Forms.Panel();
            this.dgv_chuong = new System.Windows.Forms.DataGridView();
            this.dgv_listbaihoc = new System.Windows.Forms.DataGridView();
            this.pn_listtuan.SuspendLayout();
            this.pn_lophoc.SuspendLayout();
            this.pn_chitietbaihoc.SuspendLayout();
            this.menuS_chinhsuabaihoc.SuspendLayout();
            this.pn_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listbaihoc)).BeginInit();
            this.SuspendLayout();
            // 
            // treev_baihoc
            // 
            this.treev_baihoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treev_baihoc.Location = new System.Drawing.Point(0, 0);
            this.treev_baihoc.Name = "treev_baihoc";
            this.treev_baihoc.Size = new System.Drawing.Size(408, 597);
            this.treev_baihoc.TabIndex = 0;
            // 
            // pn_listtuan
            // 
            this.pn_listtuan.Controls.Add(this.dgv_chuong);
            this.pn_listtuan.Controls.Add(this.treev_baihoc);
            this.pn_listtuan.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_listtuan.Location = new System.Drawing.Point(0, 28);
            this.pn_listtuan.Name = "pn_listtuan";
            this.pn_listtuan.Size = new System.Drawing.Size(408, 597);
            this.pn_listtuan.TabIndex = 5;
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
            this.pn_lophoc.TabIndex = 7;
            // 
            // pn_chitietbaihoc
            // 
            this.pn_chitietbaihoc.Controls.Add(this.dgv_listbaihoc);
            this.pn_chitietbaihoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_chitietbaihoc.Location = new System.Drawing.Point(408, 28);
            this.pn_chitietbaihoc.Name = "pn_chitietbaihoc";
            this.pn_chitietbaihoc.Size = new System.Drawing.Size(585, 597);
            this.pn_chitietbaihoc.TabIndex = 6;
            // 
            // menuS_chinhsuabaihoc
            // 
            this.menuS_chinhsuabaihoc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuS_chinhsuabaihoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustrip_xemdsbt});
            this.menuS_chinhsuabaihoc.Location = new System.Drawing.Point(0, 0);
            this.menuS_chinhsuabaihoc.Name = "menuS_chinhsuabaihoc";
            this.menuS_chinhsuabaihoc.Size = new System.Drawing.Size(993, 28);
            this.menuS_chinhsuabaihoc.TabIndex = 7;
            this.menuS_chinhsuabaihoc.Text = "menuStrip1";
            // 
            // menustrip_xemdsbt
            // 
            this.menustrip_xemdsbt.BackColor = System.Drawing.Color.Silver;
            this.menustrip_xemdsbt.Name = "menustrip_xemdsbt";
            this.menustrip_xemdsbt.Size = new System.Drawing.Size(174, 24);
            this.menustrip_xemdsbt.Text = "Xem danh sách bài tập";
            this.menustrip_xemdsbt.Click += new System.EventHandler(this.menustrip_xemdsbt_Click);
            // 
            // openFD_listbaihoc
            // 
            this.openFD_listbaihoc.FileName = "openFileDialog1";
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
            // lbl_lophoc
            // 
            this.lbl_lophoc.AutoSize = true;
            this.lbl_lophoc.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lophoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_lophoc.Location = new System.Drawing.Point(76, 6);
            this.lbl_lophoc.Name = "lbl_lophoc";
            this.lbl_lophoc.Size = new System.Drawing.Size(127, 40);
            this.lbl_lophoc.TabIndex = 3;
            this.lbl_lophoc.Text = "Lớp học";
            // 
            // pn_header
            // 
            this.pn_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_header.Controls.Add(this.btn_quaylai);
            this.pn_header.Controls.Add(this.lbl_lophoc);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(993, 60);
            this.pn_header.TabIndex = 6;
            // 
            // dgv_chuong
            // 
            this.dgv_chuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_chuong.Location = new System.Drawing.Point(0, 0);
            this.dgv_chuong.Name = "dgv_chuong";
            this.dgv_chuong.RowHeadersWidth = 51;
            this.dgv_chuong.RowTemplate.Height = 24;
            this.dgv_chuong.Size = new System.Drawing.Size(408, 597);
            this.dgv_chuong.TabIndex = 1;
            // 
            // dgv_listbaihoc
            // 
            this.dgv_listbaihoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listbaihoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_listbaihoc.Location = new System.Drawing.Point(0, 0);
            this.dgv_listbaihoc.Name = "dgv_listbaihoc";
            this.dgv_listbaihoc.RowHeadersWidth = 51;
            this.dgv_listbaihoc.RowTemplate.Height = 24;
            this.dgv_listbaihoc.Size = new System.Drawing.Size(585, 597);
            this.dgv_listbaihoc.TabIndex = 1;
            // 
            // FrmLopHocSV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(993, 685);
            this.Controls.Add(this.pn_lophoc);
            this.Controls.Add(this.pn_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLopHocSV";
            this.Text = "FrmLopHocSV";
            this.pn_listtuan.ResumeLayout(false);
            this.pn_lophoc.ResumeLayout(false);
            this.pn_lophoc.PerformLayout();
            this.pn_chitietbaihoc.ResumeLayout(false);
            this.menuS_chinhsuabaihoc.ResumeLayout(false);
            this.menuS_chinhsuabaihoc.PerformLayout();
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listbaihoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treev_baihoc;
        private System.Windows.Forms.Panel pn_listtuan;
        private System.Windows.Forms.DataGridView dgv_chuong;
        private System.Windows.Forms.Panel pn_lophoc;
        private System.Windows.Forms.Panel pn_chitietbaihoc;
        private System.Windows.Forms.DataGridView dgv_listbaihoc;
        private System.Windows.Forms.MenuStrip menuS_chinhsuabaihoc;
        private System.Windows.Forms.ToolStripMenuItem menustrip_xemdsbt;
        private System.Windows.Forms.OpenFileDialog openFD_listbaihoc;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Label lbl_lophoc;
        private System.Windows.Forms.Panel pn_header;
    }
}