
namespace DangKyHocPhanSV
{
    partial class FrmDangKyMonHoc
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
            this.pn_timkiem = new System.Windows.Forms.Panel();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.pn_container = new System.Windows.Forms.Panel();
            this.lbl_dangkymonhoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc)).BeginInit();
            this.pn_monhoc.SuspendLayout();
            this.pn_timkiem.SuspendLayout();
            this.pn_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_monhoc
            // 
            this.dgv_monhoc.AllowUserToAddRows = false;
            this.dgv_monhoc.AllowUserToDeleteRows = false;
            this.dgv_monhoc.AllowUserToResizeColumns = false;
            this.dgv_monhoc.AllowUserToResizeRows = false;
            this.dgv_monhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_monhoc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_monhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_monhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_monhoc.Location = new System.Drawing.Point(0, 0);
            this.dgv_monhoc.MultiSelect = false;
            this.dgv_monhoc.Name = "dgv_monhoc";
            this.dgv_monhoc.ReadOnly = true;
            this.dgv_monhoc.RowHeadersVisible = false;
            this.dgv_monhoc.RowHeadersWidth = 51;
            this.dgv_monhoc.RowTemplate.Height = 35;
            this.dgv_monhoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_monhoc.Size = new System.Drawing.Size(991, 548);
            this.dgv_monhoc.TabIndex = 0;
            this.dgv_monhoc.TabStop = false;
            this.dgv_monhoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_monhoc_CellClick);
            // 
            // pn_monhoc
            // 
            this.pn_monhoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_monhoc.Controls.Add(this.pn_timkiem);
            this.pn_monhoc.Controls.Add(this.dgv_monhoc);
            this.pn_monhoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_monhoc.Location = new System.Drawing.Point(0, 135);
            this.pn_monhoc.Name = "pn_monhoc";
            this.pn_monhoc.Size = new System.Drawing.Size(993, 550);
            this.pn_monhoc.TabIndex = 6;
            // 
            // pn_timkiem
            // 
            this.pn_timkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_timkiem.Controls.Add(this.btn_quaylai);
            this.pn_timkiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_timkiem.Location = new System.Drawing.Point(0, 490);
            this.pn_timkiem.Name = "pn_timkiem";
            this.pn_timkiem.Size = new System.Drawing.Size(991, 58);
            this.pn_timkiem.TabIndex = 1;
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_quaylai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(855, 6);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(124, 43);
            this.btn_quaylai.TabIndex = 0;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // pn_container
            // 
            this.pn_container.Controls.Add(this.lbl_dangkymonhoc);
            this.pn_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container.Location = new System.Drawing.Point(0, 0);
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(993, 685);
            this.pn_container.TabIndex = 5;
            // 
            // lbl_dangkymonhoc
            // 
            this.lbl_dangkymonhoc.AutoSize = true;
            this.lbl_dangkymonhoc.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dangkymonhoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dangkymonhoc.Location = new System.Drawing.Point(29, 19);
            this.lbl_dangkymonhoc.Name = "lbl_dangkymonhoc";
            this.lbl_dangkymonhoc.Size = new System.Drawing.Size(254, 40);
            this.lbl_dangkymonhoc.TabIndex = 4;
            this.lbl_dangkymonhoc.Text = "Đăng ký môn học";
            // 
            // FrmDangKyMonHoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(993, 685);
            this.Controls.Add(this.pn_monhoc);
            this.Controls.Add(this.pn_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDangKyMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký Môn Học";
            this.Load += new System.EventHandler(this.FrmDangKyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc)).EndInit();
            this.pn_monhoc.ResumeLayout(false);
            this.pn_timkiem.ResumeLayout(false);
            this.pn_container.ResumeLayout(false);
            this.pn_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_monhoc;
        private System.Windows.Forms.Panel pn_monhoc;
        private System.Windows.Forms.Panel pn_container;
        private System.Windows.Forms.Panel pn_timkiem;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Label lbl_dangkymonhoc;
    }
}