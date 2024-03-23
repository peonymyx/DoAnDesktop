
namespace DangKyHocPhanSV
{
    partial class FrmDangKy
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
            this.dgv_monhoc = new System.Windows.Forms.DataGridView();
            this.pn_monhoc = new System.Windows.Forms.Panel();
            this.pn_dangky = new System.Windows.Forms.Panel();
            this.btn_dangky = new System.Windows.Forms.Button();
            this.lbl_dangkymonhoc = new System.Windows.Forms.Label();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.pn_header = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc)).BeginInit();
            this.pn_monhoc.SuspendLayout();
            this.pn_dangky.SuspendLayout();
            this.pn_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_monhoc
            // 
            this.dgv_monhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_monhoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_monhoc.Location = new System.Drawing.Point(0, 0);
            this.dgv_monhoc.Name = "dgv_monhoc";
            this.dgv_monhoc.RowHeadersWidth = 51;
            this.dgv_monhoc.RowTemplate.Height = 24;
            this.dgv_monhoc.Size = new System.Drawing.Size(991, 571);
            this.dgv_monhoc.TabIndex = 0;
            // 
            // pn_monhoc
            // 
            this.pn_monhoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_monhoc.Controls.Add(this.pn_dangky);
            this.pn_monhoc.Controls.Add(this.dgv_monhoc);
            this.pn_monhoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_monhoc.Location = new System.Drawing.Point(0, 57);
            this.pn_monhoc.Name = "pn_monhoc";
            this.pn_monhoc.Size = new System.Drawing.Size(993, 628);
            this.pn_monhoc.TabIndex = 4;
            // 
            // pn_dangky
            // 
            this.pn_dangky.Controls.Add(this.btn_dangky);
            this.pn_dangky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_dangky.Location = new System.Drawing.Point(0, 571);
            this.pn_dangky.Name = "pn_dangky";
            this.pn_dangky.Size = new System.Drawing.Size(991, 55);
            this.pn_dangky.TabIndex = 1;
            // 
            // btn_dangky
            // 
            this.btn_dangky.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_dangky.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangky.Location = new System.Drawing.Point(754, 6);
            this.btn_dangky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(189, 43);
            this.btn_dangky.TabIndex = 64;
            this.btn_dangky.Text = "Đăng ký";
            this.btn_dangky.UseVisualStyleBackColor = false;
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // lbl_dangkymonhoc
            // 
            this.lbl_dangkymonhoc.AutoSize = true;
            this.lbl_dangkymonhoc.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dangkymonhoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dangkymonhoc.Location = new System.Drawing.Point(53, 6);
            this.lbl_dangkymonhoc.Name = "lbl_dangkymonhoc";
            this.lbl_dangkymonhoc.Size = new System.Drawing.Size(254, 40);
            this.lbl_dangkymonhoc.TabIndex = 3;
            this.lbl_dangkymonhoc.Text = "Đăng ký môn học";
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
            // pn_header
            // 
            this.pn_header.Controls.Add(this.btn_quaylai);
            this.pn_header.Controls.Add(this.lbl_dangkymonhoc);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(993, 57);
            this.pn_header.TabIndex = 3;
            // 
            // FrmDangKy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(993, 685);
            this.Controls.Add(this.pn_header);
            this.Controls.Add(this.pn_monhoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDangKy";
            this.Load += new System.EventHandler(this.FrmDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc)).EndInit();
            this.pn_monhoc.ResumeLayout(false);
            this.pn_dangky.ResumeLayout(false);
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_monhoc;
        private System.Windows.Forms.Panel pn_monhoc;
        private System.Windows.Forms.Panel pn_dangky;
        private System.Windows.Forms.Label lbl_dangkymonhoc;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Button btn_dangky;
    }
}