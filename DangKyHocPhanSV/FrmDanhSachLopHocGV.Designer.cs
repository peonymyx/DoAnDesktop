
namespace DangKyHocPhanSV
{
    partial class FrmDanhSachLopHocGV
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
            this.pn_timkiem = new System.Windows.Forms.Panel();
            this.lbl_tongsinhvien = new System.Windows.Forms.Label();
            this.txt_tongsinhvien = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.lbl_timkiem = new System.Windows.Forms.Label();
            this.pn_header = new System.Windows.Forms.Panel();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.lbl_dslophoc = new System.Windows.Forms.Label();
            this.pn_lophoc = new System.Windows.Forms.Panel();
            this.flpn_dslophoc = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_timkiem.SuspendLayout();
            this.pn_header.SuspendLayout();
            this.pn_lophoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_timkiem
            // 
            this.pn_timkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_timkiem.Controls.Add(this.lbl_tongsinhvien);
            this.pn_timkiem.Controls.Add(this.txt_tongsinhvien);
            this.pn_timkiem.Controls.Add(this.btn_timkiem);
            this.pn_timkiem.Controls.Add(this.txt_timkiem);
            this.pn_timkiem.Controls.Add(this.lbl_timkiem);
            this.pn_timkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_timkiem.Location = new System.Drawing.Point(0, 60);
            this.pn_timkiem.Name = "pn_timkiem";
            this.pn_timkiem.Size = new System.Drawing.Size(993, 63);
            this.pn_timkiem.TabIndex = 5;
            // 
            // lbl_tongsinhvien
            // 
            this.lbl_tongsinhvien.AutoSize = true;
            this.lbl_tongsinhvien.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_tongsinhvien.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tongsinhvien.Location = new System.Drawing.Point(721, 21);
            this.lbl_tongsinhvien.Name = "lbl_tongsinhvien";
            this.lbl_tongsinhvien.Size = new System.Drawing.Size(111, 22);
            this.lbl_tongsinhvien.TabIndex = 108;
            this.lbl_tongsinhvien.Text = "Tổng sinh viên";
            // 
            // txt_tongsinhvien
            // 
            this.txt_tongsinhvien.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_tongsinhvien.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongsinhvien.Location = new System.Drawing.Point(838, 16);
            this.txt_tongsinhvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tongsinhvien.Name = "txt_tongsinhvien";
            this.txt_tongsinhvien.ReadOnly = true;
            this.txt_tongsinhvien.Size = new System.Drawing.Size(122, 29);
            this.txt_tongsinhvien.TabIndex = 107;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(522, 11);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(124, 41);
            this.btn_timkiem.TabIndex = 61;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(150, 13);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(343, 36);
            this.txt_timkiem.TabIndex = 60;
            // 
            // lbl_timkiem
            // 
            this.lbl_timkiem.AutoSize = true;
            this.lbl_timkiem.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_timkiem.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timkiem.Location = new System.Drawing.Point(27, 17);
            this.lbl_timkiem.Name = "lbl_timkiem";
            this.lbl_timkiem.Size = new System.Drawing.Size(117, 28);
            this.lbl_timkiem.TabIndex = 59;
            this.lbl_timkiem.Text = "Mã lớp học";
            // 
            // pn_header
            // 
            this.pn_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_header.Controls.Add(this.btn_quaylai);
            this.pn_header.Controls.Add(this.lbl_dslophoc);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(993, 60);
            this.pn_header.TabIndex = 3;
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
            // lbl_dslophoc
            // 
            this.lbl_dslophoc.AutoSize = true;
            this.lbl_dslophoc.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dslophoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dslophoc.Location = new System.Drawing.Point(53, 6);
            this.lbl_dslophoc.Name = "lbl_dslophoc";
            this.lbl_dslophoc.Size = new System.Drawing.Size(269, 40);
            this.lbl_dslophoc.TabIndex = 3;
            this.lbl_dslophoc.Text = "Danh sách lớp học";
            // 
            // pn_lophoc
            // 
            this.pn_lophoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_lophoc.Controls.Add(this.flpn_dslophoc);
            this.pn_lophoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_lophoc.Location = new System.Drawing.Point(0, 123);
            this.pn_lophoc.Name = "pn_lophoc";
            this.pn_lophoc.Size = new System.Drawing.Size(993, 562);
            this.pn_lophoc.TabIndex = 4;
            // 
            // flpn_dslophoc
            // 
            this.flpn_dslophoc.AutoScroll = true;
            this.flpn_dslophoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpn_dslophoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpn_dslophoc.Location = new System.Drawing.Point(0, 0);
            this.flpn_dslophoc.Name = "flpn_dslophoc";
            this.flpn_dslophoc.Size = new System.Drawing.Size(991, 560);
            this.flpn_dslophoc.TabIndex = 7;
            // 
            // FrmDanhSachLopHocGV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(993, 685);
            this.Controls.Add(this.pn_timkiem);
            this.Controls.Add(this.pn_header);
            this.Controls.Add(this.pn_lophoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDanhSachLopHocGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Lớp Học";
            this.Load += new System.EventHandler(this.FrmDanhSachLopHocGV_Load);
            this.pn_timkiem.ResumeLayout(false);
            this.pn_timkiem.PerformLayout();
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.pn_lophoc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_timkiem;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label lbl_timkiem;
        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Label lbl_dslophoc;
        private System.Windows.Forms.Panel pn_lophoc;
        private System.Windows.Forms.Label lbl_tongsinhvien;
        private System.Windows.Forms.TextBox txt_tongsinhvien;
        private System.Windows.Forms.FlowLayoutPanel flpn_dslophoc;
    }
}