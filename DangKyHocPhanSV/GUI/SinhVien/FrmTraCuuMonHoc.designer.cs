namespace DangKyHocPhanSV
{
    partial class FrmTraCuuMonHoc
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
            this.pn_monhoc = new System.Windows.Forms.Panel();
            this.dgv_monhoc = new System.Windows.Forms.DataGridView();
            this.pn_timkiem = new System.Windows.Forms.Panel();
            this.tblopn_timkiem = new System.Windows.Forms.TableLayoutPanel();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.lbl_timkiem = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.pn_header.SuspendLayout();
            this.pn_monhoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc)).BeginInit();
            this.pn_timkiem.SuspendLayout();
            this.tblopn_timkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_header
            // 
            this.pn_header.Controls.Add(this.btn_quaylai);
            this.pn_header.Controls.Add(this.lbl_tracuumonhoc);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(993, 60);
            this.pn_header.TabIndex = 0;
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
            this.lbl_tracuumonhoc.Location = new System.Drawing.Point(53, 6);
            this.lbl_tracuumonhoc.Name = "lbl_tracuumonhoc";
            this.lbl_tracuumonhoc.Size = new System.Drawing.Size(245, 40);
            this.lbl_tracuumonhoc.TabIndex = 3;
            this.lbl_tracuumonhoc.Text = "Tra cứu môn học";
            // 
            // pn_monhoc
            // 
            this.pn_monhoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_monhoc.Controls.Add(this.dgv_monhoc);
            this.pn_monhoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_monhoc.Location = new System.Drawing.Point(0, 189);
            this.pn_monhoc.Name = "pn_monhoc";
            this.pn_monhoc.Size = new System.Drawing.Size(993, 496);
            this.pn_monhoc.TabIndex = 1;
            // 
            // dgv_monhoc
            // 
            this.dgv_monhoc.AllowUserToAddRows = false;
            this.dgv_monhoc.AllowUserToDeleteRows = false;
            this.dgv_monhoc.AllowUserToResizeColumns = false;
            this.dgv_monhoc.AllowUserToResizeRows = false;
            this.dgv_monhoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_monhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_monhoc.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_monhoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_monhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_monhoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_monhoc.Location = new System.Drawing.Point(0, 0);
            this.dgv_monhoc.MultiSelect = false;
            this.dgv_monhoc.Name = "dgv_monhoc";
            this.dgv_monhoc.ReadOnly = true;
            this.dgv_monhoc.RowHeadersVisible = false;
            this.dgv_monhoc.RowHeadersWidth = 51;
            this.dgv_monhoc.RowTemplate.Height = 24;
            this.dgv_monhoc.Size = new System.Drawing.Size(991, 494);
            this.dgv_monhoc.TabIndex = 0;
            this.dgv_monhoc.TabStop = false;
            // 
            // pn_timkiem
            // 
            this.pn_timkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_timkiem.Controls.Add(this.tblopn_timkiem);
            this.pn_timkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_timkiem.Location = new System.Drawing.Point(0, 60);
            this.pn_timkiem.Name = "pn_timkiem";
            this.pn_timkiem.Size = new System.Drawing.Size(993, 129);
            this.pn_timkiem.TabIndex = 2;
            // 
            // tblopn_timkiem
            // 
            this.tblopn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblopn_timkiem.ColumnCount = 3;
            this.tblopn_timkiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblopn_timkiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblopn_timkiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblopn_timkiem.Controls.Add(this.btn_timkiem, 2, 0);
            this.tblopn_timkiem.Controls.Add(this.lbl_timkiem, 0, 0);
            this.tblopn_timkiem.Controls.Add(this.txt_timkiem, 1, 0);
            this.tblopn_timkiem.Location = new System.Drawing.Point(3, 6);
            this.tblopn_timkiem.Name = "tblopn_timkiem";
            this.tblopn_timkiem.RowCount = 1;
            this.tblopn_timkiem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblopn_timkiem.Size = new System.Drawing.Size(986, 116);
            this.tblopn_timkiem.TabIndex = 1;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_timkiem.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(659, 35);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(124, 45);
            this.btn_timkiem.TabIndex = 61;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // lbl_timkiem
            // 
            this.lbl_timkiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_timkiem.AutoSize = true;
            this.lbl_timkiem.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_timkiem.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timkiem.Location = new System.Drawing.Point(104, 44);
            this.lbl_timkiem.Name = "lbl_timkiem";
            this.lbl_timkiem.Size = new System.Drawing.Size(221, 28);
            this.lbl_timkiem.TabIndex = 59;
            this.lbl_timkiem.Text = "Mã hoặc tên môn học:";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_timkiem.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(331, 40);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(322, 36);
            this.txt_timkiem.TabIndex = 60;
            // 
            // FrmTraCuuMonHoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(993, 685);
            this.Controls.Add(this.pn_timkiem);
            this.Controls.Add(this.pn_monhoc);
            this.Controls.Add(this.pn_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTraCuuMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu môn học";
            this.Load += new System.EventHandler(this.FrmTraCuuMonHoc_Load);
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.pn_monhoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc)).EndInit();
            this.pn_timkiem.ResumeLayout(false);
            this.tblopn_timkiem.ResumeLayout(false);
            this.tblopn_timkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Panel pn_monhoc;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Label lbl_tracuumonhoc;
        private System.Windows.Forms.Panel pn_timkiem;
        private System.Windows.Forms.DataGridView dgv_monhoc;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label lbl_timkiem;
        private System.Windows.Forms.TableLayoutPanel tblopn_timkiem;
    }
}