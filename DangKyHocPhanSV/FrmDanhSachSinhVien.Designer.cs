namespace DangKyHocPhanSV
{
    partial class FrmDanhSachSinhVien
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
            this.pn_tenlophoc = new System.Windows.Forms.Panel();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.lbl_tenlophoc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_danhsachsinhvien = new System.Windows.Forms.DataGridView();
            this.pn_tenlophoc.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachsinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_tenlophoc
            // 
            this.pn_tenlophoc.Controls.Add(this.btn_quaylai);
            this.pn_tenlophoc.Controls.Add(this.lbl_tenlophoc);
            this.pn_tenlophoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_tenlophoc.Location = new System.Drawing.Point(0, 0);
            this.pn_tenlophoc.Name = "pn_tenlophoc";
            this.pn_tenlophoc.Size = new System.Drawing.Size(993, 77);
            this.pn_tenlophoc.TabIndex = 0;
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(815, 22);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(124, 41);
            this.btn_quaylai.TabIndex = 9;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // lbl_tenlophoc
            // 
            this.lbl_tenlophoc.AutoSize = true;
            this.lbl_tenlophoc.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenlophoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tenlophoc.Location = new System.Drawing.Point(47, 18);
            this.lbl_tenlophoc.Name = "lbl_tenlophoc";
            this.lbl_tenlophoc.Size = new System.Drawing.Size(176, 40);
            this.lbl_tenlophoc.TabIndex = 8;
            this.lbl_tenlophoc.Text = "Tên lớp học";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_danhsachsinhvien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 485);
            this.panel2.TabIndex = 1;
            // 
            // dgv_danhsachsinhvien
            // 
            this.dgv_danhsachsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachsinhvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_danhsachsinhvien.Location = new System.Drawing.Point(0, 0);
            this.dgv_danhsachsinhvien.Name = "dgv_danhsachsinhvien";
            this.dgv_danhsachsinhvien.RowHeadersWidth = 51;
            this.dgv_danhsachsinhvien.RowTemplate.Height = 24;
            this.dgv_danhsachsinhvien.Size = new System.Drawing.Size(993, 485);
            this.dgv_danhsachsinhvien.TabIndex = 0;
            // 
            // FrmDanhSachSinhVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(993, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_tenlophoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDanhSachSinhVien";
            this.Text = "FrmDanhSachSinhVien";
            this.pn_tenlophoc.ResumeLayout(false);
            this.pn_tenlophoc.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachsinhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_tenlophoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_tenlophoc;
        private System.Windows.Forms.DataGridView dgv_danhsachsinhvien;
        private System.Windows.Forms.Button btn_quaylai;
    }
}