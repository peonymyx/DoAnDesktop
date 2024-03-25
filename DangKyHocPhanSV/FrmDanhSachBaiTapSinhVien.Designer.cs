namespace DangKyHocPhanSV
{
    partial class FrmDanhSachBaiTapSinhVien
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
            this.pn_container = new System.Windows.Forms.Panel();
            this.lbl_dsbt = new System.Windows.Forms.Label();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pn_header.SuspendLayout();
            this.pn_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_header
            // 
            this.pn_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_header.Controls.Add(this.btn_quaylai);
            this.pn_header.Controls.Add(this.lbl_dsbt);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(993, 65);
            this.pn_header.TabIndex = 0;
            // 
            // pn_container
            // 
            this.pn_container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_container.Controls.Add(this.dataGridView1);
            this.pn_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container.Location = new System.Drawing.Point(0, 65);
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(993, 560);
            this.pn_container.TabIndex = 1;
            // 
            // lbl_dsbt
            // 
            this.lbl_dsbt.AutoSize = true;
            this.lbl_dsbt.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dsbt.Location = new System.Drawing.Point(41, 14);
            this.lbl_dsbt.Name = "lbl_dsbt";
            this.lbl_dsbt.Size = new System.Drawing.Size(215, 35);
            this.lbl_dsbt.TabIndex = 0;
            this.lbl_dsbt.Text = "Danh sách bài tập";
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(793, 11);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(124, 41);
            this.btn_quaylai.TabIndex = 1;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(991, 558);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmDanhSachBaiTapSinhVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(993, 625);
            this.Controls.Add(this.pn_container);
            this.Controls.Add(this.pn_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDanhSachBaiTapSinhVien";
            this.Text = "FrmDanhSachBaiTapSinhVien";
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.pn_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Label lbl_dsbt;
        private System.Windows.Forms.Panel pn_container;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}