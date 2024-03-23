
namespace DangKyHocPhanSV
{
    partial class FrmThoiKhoaBieuSV
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
            this.pn_xoalop = new System.Windows.Forms.Panel();
            this.btn_xoalop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_thoikhoabieu = new System.Windows.Forms.DataGridView();
            this.pn_header = new System.Windows.Forms.Panel();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.lbl_thoikhoabieu = new System.Windows.Forms.Label();
            this.pn_xoalop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thoikhoabieu)).BeginInit();
            this.pn_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_xoalop
            // 
            this.pn_xoalop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_xoalop.Controls.Add(this.btn_xoalop);
            this.pn_xoalop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_xoalop.Location = new System.Drawing.Point(0, 614);
            this.pn_xoalop.Name = "pn_xoalop";
            this.pn_xoalop.Size = new System.Drawing.Size(993, 71);
            this.pn_xoalop.TabIndex = 0;
            // 
            // btn_xoalop
            // 
            this.btn_xoalop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_xoalop.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoalop.Location = new System.Drawing.Point(795, 10);
            this.btn_xoalop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoalop.Name = "btn_xoalop";
            this.btn_xoalop.Size = new System.Drawing.Size(168, 48);
            this.btn_xoalop.TabIndex = 106;
            this.btn_xoalop.Text = "Xóa Lớp Học";
            this.btn_xoalop.UseVisualStyleBackColor = false;
            this.btn_xoalop.Click += new System.EventHandler(this.btn_xoalop_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pn_header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 614);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_thoikhoabieu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(991, 552);
            this.panel4.TabIndex = 2;
            // 
            // dgv_thoikhoabieu
            // 
            this.dgv_thoikhoabieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thoikhoabieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_thoikhoabieu.Location = new System.Drawing.Point(0, 0);
            this.dgv_thoikhoabieu.Name = "dgv_thoikhoabieu";
            this.dgv_thoikhoabieu.RowHeadersWidth = 51;
            this.dgv_thoikhoabieu.RowTemplate.Height = 24;
            this.dgv_thoikhoabieu.Size = new System.Drawing.Size(991, 552);
            this.dgv_thoikhoabieu.TabIndex = 1;
            this.dgv_thoikhoabieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thoikhoabieu_CellContentClick);
            // 
            // pn_header
            // 
            this.pn_header.Controls.Add(this.btn_quaylai);
            this.pn_header.Controls.Add(this.lbl_thoikhoabieu);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(991, 60);
            this.pn_header.TabIndex = 1;
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(794, 10);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(124, 41);
            this.btn_quaylai.TabIndex = 4;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // lbl_thoikhoabieu
            // 
            this.lbl_thoikhoabieu.AutoSize = true;
            this.lbl_thoikhoabieu.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thoikhoabieu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_thoikhoabieu.Location = new System.Drawing.Point(66, 10);
            this.lbl_thoikhoabieu.Name = "lbl_thoikhoabieu";
            this.lbl_thoikhoabieu.Size = new System.Drawing.Size(223, 40);
            this.lbl_thoikhoabieu.TabIndex = 5;
            this.lbl_thoikhoabieu.Text = "Thời khóa biểu";
            // 
            // FrmThoiKhoaBieuSV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(993, 685);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_xoalop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmThoiKhoaBieuSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thời Khóa Biểu Sinh Viên";
            this.Load += new System.EventHandler(this.FrmThoiKhoaBieuSV_Load);
            this.pn_xoalop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thoikhoabieu)).EndInit();
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_xoalop;
        private System.Windows.Forms.Button btn_xoalop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_thoikhoabieu;
        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Label lbl_thoikhoabieu;
    }
}