namespace DangKyHocPhanSV
{
    partial class FrmDanhSachLopHocSV
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
            this.components = new System.ComponentModel.Container();
            this.pn_timkiem = new System.Windows.Forms.Panel();
            this.pn_header = new System.Windows.Forms.Panel();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.lbl_dslophoc = new System.Windows.Forms.Label();
            this.pn_lophoc = new System.Windows.Forms.Panel();
            this.flpn_dslophoc = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_timeline = new System.Windows.Forms.Label();
            this.timer_timeline = new System.Windows.Forms.Timer(this.components);
            this.pn_timkiem.SuspendLayout();
            this.pn_header.SuspendLayout();
            this.pn_lophoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_timkiem
            // 
            this.pn_timkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_timkiem.Controls.Add(this.lbl_timeline);
            this.pn_timkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_timkiem.Location = new System.Drawing.Point(0, 60);
            this.pn_timkiem.Name = "pn_timkiem";
            this.pn_timkiem.Size = new System.Drawing.Size(993, 87);
            this.pn_timkiem.TabIndex = 8;
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
            this.pn_header.TabIndex = 6;
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_quaylai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(814, 10);
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
            this.pn_lophoc.Location = new System.Drawing.Point(0, 147);
            this.pn_lophoc.Name = "pn_lophoc";
            this.pn_lophoc.Size = new System.Drawing.Size(993, 538);
            this.pn_lophoc.TabIndex = 7;
            // 
            // flpn_dslophoc
            // 
            this.flpn_dslophoc.AutoScroll = true;
            this.flpn_dslophoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpn_dslophoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpn_dslophoc.Location = new System.Drawing.Point(0, 0);
            this.flpn_dslophoc.Name = "flpn_dslophoc";
            this.flpn_dslophoc.Size = new System.Drawing.Size(991, 536);
            this.flpn_dslophoc.TabIndex = 7;
            // 
            // lbl_timeline
            // 
            this.lbl_timeline.AutoSize = true;
            this.lbl_timeline.Font = new System.Drawing.Font("Engravers MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeline.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_timeline.Location = new System.Drawing.Point(422, 9);
            this.lbl_timeline.Name = "lbl_timeline";
            this.lbl_timeline.Size = new System.Drawing.Size(962, 32);
            this.lbl_timeline.TabIndex = 7;
            this.lbl_timeline.Text = "CHÀO MỪNG ĐẾN VỚI TRANG LỚP HỌC     sfdfsdfs";
            // 
            // timer_timeline
            // 
            this.timer_timeline.Enabled = true;
            this.timer_timeline.Interval = 10;
            this.timer_timeline.Tick += new System.EventHandler(this.timer_timeline_Tick);
            // 
            // FrmDanhSachLopHocSV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(993, 685);
            this.Controls.Add(this.pn_timkiem);
            this.Controls.Add(this.pn_header);
            this.Controls.Add(this.pn_lophoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDanhSachLopHocSV";
            this.Text = "FrmDanhSachLopHocSV";
            this.Load += new System.EventHandler(this.FrmDanhSachLopHocSV_Load);
            this.pn_timkiem.ResumeLayout(false);
            this.pn_timkiem.PerformLayout();
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.pn_lophoc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_timkiem;
        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Label lbl_dslophoc;
        private System.Windows.Forms.Panel pn_lophoc;
        private System.Windows.Forms.FlowLayoutPanel flpn_dslophoc;
        private System.Windows.Forms.Label lbl_timeline;
        private System.Windows.Forms.Timer timer_timeline;
    }
}