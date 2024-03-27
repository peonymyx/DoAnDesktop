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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_chuong = new System.Windows.Forms.DataGridView();
            this.lbl_chonchuong = new System.Windows.Forms.Label();
            this.llb_IDBG = new System.Windows.Forms.Label();
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.cb_chonchuong = new System.Windows.Forms.ComboBox();
            this.txt_IDBG = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_tieude = new System.Windows.Forms.TextBox();
            this.dgv_listbaihoc = new System.Windows.Forms.DataGridView();
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
            this.pn_header = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuong)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listbaihoc)).BeginInit();
            this.menuS_chinhsuabaihoc.SuspendLayout();
            this.pn_lophoc.SuspendLayout();
            this.tblopn_lophoc.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.pn_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_chuong
            // 
            this.dgv_chuong.AllowUserToAddRows = false;
            this.dgv_chuong.AllowUserToDeleteRows = false;
            this.dgv_chuong.AllowUserToResizeColumns = false;
            this.dgv_chuong.AllowUserToResizeRows = false;
            this.dgv_chuong.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_chuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_chuong.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_chuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_chuong.Location = new System.Drawing.Point(3, 3);
            this.dgv_chuong.MultiSelect = false;
            this.dgv_chuong.Name = "dgv_chuong";
            this.dgv_chuong.ReadOnly = true;
            this.dgv_chuong.RowHeadersVisible = false;
            this.dgv_chuong.RowHeadersWidth = 51;
            this.dgv_chuong.RowTemplate.Height = 30;
            this.dgv_chuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_chuong.Size = new System.Drawing.Size(416, 333);
            this.dgv_chuong.TabIndex = 1;
            this.dgv_chuong.TabStop = false;
            // 
            // lbl_chonchuong
            // 
            this.lbl_chonchuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_chonchuong.AutoSize = true;
            this.lbl_chonchuong.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chonchuong.Location = new System.Drawing.Point(3, 31);
            this.lbl_chonchuong.Name = "lbl_chonchuong";
            this.lbl_chonchuong.Size = new System.Drawing.Size(137, 28);
            this.lbl_chonchuong.TabIndex = 10;
            this.lbl_chonchuong.Text = "Chọn chương";
            // 
            // llb_IDBG
            // 
            this.llb_IDBG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llb_IDBG.AutoSize = true;
            this.llb_IDBG.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_IDBG.Location = new System.Drawing.Point(236, 31);
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
            this.lbl_tieude.Location = new System.Drawing.Point(3, 133);
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
            this.cb_chonchuong.Location = new System.Drawing.Point(3, 70);
            this.cb_chonchuong.Name = "cb_chonchuong";
            this.cb_chonchuong.Size = new System.Drawing.Size(227, 36);
            this.cb_chonchuong.TabIndex = 9;
            this.cb_chonchuong.SelectedIndexChanged += new System.EventHandler(this.cb_chonchuong_SelectedIndexChanged_1);
            // 
            // txt_IDBG
            // 
            this.txt_IDBG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_IDBG.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDBG.Location = new System.Drawing.Point(236, 70);
            this.txt_IDBG.Name = "txt_IDBG";
            this.txt_IDBG.Size = new System.Drawing.Size(89, 36);
            this.txt_IDBG.TabIndex = 8;
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
            this.tableLayoutPanel1.Controls.Add(this.lbl_chonchuong, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.llb_IDBG, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tieude, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_chonchuong, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_IDBG, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_tieude, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(425, 342);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 238);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txt_tieude
            // 
            this.txt_tieude.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_tieude.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tieude.Location = new System.Drawing.Point(236, 129);
            this.txt_tieude.Name = "txt_tieude";
            this.txt_tieude.Size = new System.Drawing.Size(236, 36);
            this.txt_tieude.TabIndex = 8;
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
            this.dgv_listbaihoc.Size = new System.Drawing.Size(562, 333);
            this.dgv_listbaihoc.TabIndex = 0;
            this.dgv_listbaihoc.TabStop = false;
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
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click_1);
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
            this.chỉnhSửaBàiTậpToolStripMenuItem.Size = new System.Drawing.Size(128, 32);
            this.chỉnhSửaBàiTậpToolStripMenuItem.Text = "Làm bài tập";
            this.chỉnhSửaBàiTậpToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaBàiTậpToolStripMenuItem_Click);
            // 
            // pn_lophoc
            // 
            this.pn_lophoc.Controls.Add(this.tblopn_lophoc);
            this.pn_lophoc.Controls.Add(this.menuS_chinhsuabaihoc);
            this.pn_lophoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_lophoc.Location = new System.Drawing.Point(0, 60);
            this.pn_lophoc.Name = "pn_lophoc";
            this.pn_lophoc.Size = new System.Drawing.Size(993, 625);
            this.pn_lophoc.TabIndex = 7;
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
            this.tblopn_lophoc.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tblopn_lophoc.Controls.Add(this.dgv_chuong, 0, 0);
            this.tblopn_lophoc.Controls.Add(this.dgv_listbaihoc, 1, 0);
            this.tblopn_lophoc.Location = new System.Drawing.Point(0, 39);
            this.tblopn_lophoc.Name = "tblopn_lophoc";
            this.tblopn_lophoc.RowCount = 2;
            this.tblopn_lophoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.31776F));
            this.tblopn_lophoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.68224F));
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 342);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(416, 238);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // txt_themchuong
            // 
            this.txt_themchuong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_themchuong.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_themchuong.Location = new System.Drawing.Point(3, 189);
            this.txt_themchuong.Name = "txt_themchuong";
            this.txt_themchuong.Size = new System.Drawing.Size(358, 36);
            this.txt_themchuong.TabIndex = 1;
            // 
            // lbl_noidungCH
            // 
            this.lbl_noidungCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_noidungCH.AutoSize = true;
            this.lbl_noidungCH.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noidungCH.Location = new System.Drawing.Point(3, 149);
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
            this.lbl_maCH.Location = new System.Drawing.Point(3, 31);
            this.lbl_maCH.Name = "lbl_maCH";
            this.lbl_maCH.Size = new System.Drawing.Size(159, 28);
            this.lbl_maCH.TabIndex = 5;
            this.lbl_maCH.Text = "Mã chương học";
            // 
            // txt_maCH
            // 
            this.txt_maCH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_maCH.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maCH.Location = new System.Drawing.Point(3, 70);
            this.txt_maCH.Name = "txt_maCH";
            this.txt_maCH.Size = new System.Drawing.Size(173, 36);
            this.txt_maCH.TabIndex = 4;
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
            this.pn_header.TabIndex = 6;
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
            this.Load += new System.EventHandler(this.FrmLopHocSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuong)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listbaihoc)).EndInit();
            this.menuS_chinhsuabaihoc.ResumeLayout(false);
            this.menuS_chinhsuabaihoc.PerformLayout();
            this.pn_lophoc.ResumeLayout(false);
            this.pn_lophoc.PerformLayout();
            this.tblopn_lophoc.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_chuong;
        private System.Windows.Forms.Label lbl_chonchuong;
        private System.Windows.Forms.Label llb_IDBG;
        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.ComboBox cb_chonchuong;
        private System.Windows.Forms.TextBox txt_IDBG;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_tieude;
        private System.Windows.Forms.DataGridView dgv_listbaihoc;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Label lbl_tracuumonhoc;
        private System.Windows.Forms.OpenFileDialog openFD_listbaihoc;
        private System.Windows.Forms.MenuStrip menuS_chinhsuabaihoc;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaBàiTậpToolStripMenuItem;
        private System.Windows.Forms.Panel pn_lophoc;
        private System.Windows.Forms.TableLayoutPanel tblopn_lophoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txt_themchuong;
        private System.Windows.Forms.Label lbl_noidungCH;
        private System.Windows.Forms.Label lbl_maCH;
        private System.Windows.Forms.TextBox txt_maCH;
        private System.Windows.Forms.Panel pn_header;
    }
}