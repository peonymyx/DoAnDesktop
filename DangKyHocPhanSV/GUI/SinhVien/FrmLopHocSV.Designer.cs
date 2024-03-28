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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_chuong = new System.Windows.Forms.DataGridView();
            this.lbl_chonchuong = new System.Windows.Forms.Label();
            this.cb_chonchuong = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.TableLayoutPanel();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.dgv_listbaihoc = new System.Windows.Forms.DataGridView();
            this.openFD_listbaihoc = new System.Windows.Forms.OpenFileDialog();
            this.menuS_chinhsuabaihoc = new System.Windows.Forms.MenuStrip();
            this.menuS_lambaitap = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_lophoc = new System.Windows.Forms.Panel();
            this.tblopn_lophoc = new System.Windows.Forms.TableLayoutPanel();
            this.tblopn_chonchuong = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuong)).BeginInit();
            this.back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listbaihoc)).BeginInit();
            this.menuS_chinhsuabaihoc.SuspendLayout();
            this.pn_lophoc.SuspendLayout();
            this.tblopn_lophoc.SuspendLayout();
            this.tblopn_chonchuong.SuspendLayout();
            this.SuspendLayout();
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
            this.dgv_chuong.Size = new System.Drawing.Size(416, 416);
            this.dgv_chuong.TabIndex = 1;
            this.dgv_chuong.TabStop = false;
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
            this.cb_chonchuong.SelectedIndexChanged += new System.EventHandler(this.cb_chonchuong_SelectedIndexChanged_1);
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back.BackColor = System.Drawing.Color.Silver;
            this.back.ColumnCount = 2;
            this.back.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.55844F));
            this.back.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.44156F));
            this.back.Controls.Add(this.btn_quaylai, 1, 3);
            this.back.Location = new System.Drawing.Point(425, 425);
            this.back.Name = "back";
            this.back.RowCount = 4;
            this.back.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.back.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.back.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.back.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.back.Size = new System.Drawing.Size(562, 215);
            this.back.TabIndex = 2;
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_quaylai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(435, 162);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(124, 41);
            this.btn_quaylai.TabIndex = 0;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click_1);
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
            this.dgv_listbaihoc.Size = new System.Drawing.Size(562, 416);
            this.dgv_listbaihoc.TabIndex = 0;
            this.dgv_listbaihoc.TabStop = false;
            // 
            // openFD_listbaihoc
            // 
            this.openFD_listbaihoc.FileName = "openFileDialog1";
            // 
            // menuS_chinhsuabaihoc
            // 
            this.menuS_chinhsuabaihoc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuS_chinhsuabaihoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuS_lambaitap});
            this.menuS_chinhsuabaihoc.Location = new System.Drawing.Point(0, 0);
            this.menuS_chinhsuabaihoc.Name = "menuS_chinhsuabaihoc";
            this.menuS_chinhsuabaihoc.Size = new System.Drawing.Size(993, 36);
            this.menuS_chinhsuabaihoc.TabIndex = 7;
            this.menuS_chinhsuabaihoc.Text = "menuStrip1";
            // 
            // menuS_lambaitap
            // 
            this.menuS_lambaitap.BackColor = System.Drawing.Color.Silver;
            this.menuS_lambaitap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuS_lambaitap.Name = "menuS_lambaitap";
            this.menuS_lambaitap.Size = new System.Drawing.Size(128, 32);
            this.menuS_lambaitap.Text = "Làm bài tập";
            this.menuS_lambaitap.Click += new System.EventHandler(this.chỉnhSửaBàiTậpToolStripMenuItem_Click);
            // 
            // pn_lophoc
            // 
            this.pn_lophoc.Controls.Add(this.tblopn_lophoc);
            this.pn_lophoc.Controls.Add(this.menuS_chinhsuabaihoc);
            this.pn_lophoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_lophoc.Location = new System.Drawing.Point(0, 0);
            this.pn_lophoc.Name = "pn_lophoc";
            this.pn_lophoc.Size = new System.Drawing.Size(993, 685);
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
            this.tblopn_lophoc.Controls.Add(this.tblopn_chonchuong, 0, 1);
            this.tblopn_lophoc.Controls.Add(this.back, 1, 1);
            this.tblopn_lophoc.Controls.Add(this.dgv_chuong, 0, 0);
            this.tblopn_lophoc.Controls.Add(this.dgv_listbaihoc, 1, 0);
            this.tblopn_lophoc.Location = new System.Drawing.Point(0, 39);
            this.tblopn_lophoc.Name = "tblopn_lophoc";
            this.tblopn_lophoc.RowCount = 2;
            this.tblopn_lophoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.78538F));
            this.tblopn_lophoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.21462F));
            this.tblopn_lophoc.Size = new System.Drawing.Size(990, 643);
            this.tblopn_lophoc.TabIndex = 1;
            // 
            // tblopn_chonchuong
            // 
            this.tblopn_chonchuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblopn_chonchuong.BackColor = System.Drawing.Color.Silver;
            this.tblopn_chonchuong.ColumnCount = 1;
            this.tblopn_chonchuong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblopn_chonchuong.Controls.Add(this.cb_chonchuong, 0, 1);
            this.tblopn_chonchuong.Controls.Add(this.lbl_chonchuong, 0, 0);
            this.tblopn_chonchuong.Location = new System.Drawing.Point(3, 425);
            this.tblopn_chonchuong.Name = "tblopn_chonchuong";
            this.tblopn_chonchuong.RowCount = 4;
            this.tblopn_chonchuong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblopn_chonchuong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblopn_chonchuong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblopn_chonchuong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblopn_chonchuong.Size = new System.Drawing.Size(416, 215);
            this.tblopn_chonchuong.TabIndex = 3;
            // 
            // FrmLopHocSV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(993, 685);
            this.Controls.Add(this.pn_lophoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLopHocSV";
            this.Text = "FrmLopHocSV";
            this.Load += new System.EventHandler(this.FrmLopHocSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuong)).EndInit();
            this.back.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listbaihoc)).EndInit();
            this.menuS_chinhsuabaihoc.ResumeLayout(false);
            this.menuS_chinhsuabaihoc.PerformLayout();
            this.pn_lophoc.ResumeLayout(false);
            this.pn_lophoc.PerformLayout();
            this.tblopn_lophoc.ResumeLayout(false);
            this.tblopn_chonchuong.ResumeLayout(false);
            this.tblopn_chonchuong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_chuong;
        private System.Windows.Forms.Label lbl_chonchuong;
        private System.Windows.Forms.ComboBox cb_chonchuong;
        private System.Windows.Forms.TableLayoutPanel back;
        private System.Windows.Forms.DataGridView dgv_listbaihoc;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.OpenFileDialog openFD_listbaihoc;
        private System.Windows.Forms.MenuStrip menuS_chinhsuabaihoc;
        private System.Windows.Forms.ToolStripMenuItem menuS_lambaitap;
        private System.Windows.Forms.Panel pn_lophoc;
        private System.Windows.Forms.TableLayoutPanel tblopn_lophoc;
        private System.Windows.Forms.TableLayoutPanel tblopn_chonchuong;
    }
}