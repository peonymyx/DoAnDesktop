namespace DangKyHocPhanSV
{
    partial class FrmThongKe
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.btn_pre = new System.Windows.Forms.Button();
            this.cmb_tk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_header
            // 
            this.pn_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.pn_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_header.Controls.Add(this.lbl_header);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(674, 63);
            this.pn_header.TabIndex = 3;
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_header.Location = new System.Drawing.Point(221, 8);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(265, 40);
            this.lbl_header.TabIndex = 3;
            this.lbl_header.Text = "TRANG THỐNG KÊ";
            // 
            // btn_pre
            // 
            this.btn_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pre.Location = new System.Drawing.Point(541, 524);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(116, 49);
            this.btn_pre.TabIndex = 10;
            this.btn_pre.Text = "Quay về";
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // cmb_tk
            // 
            this.cmb_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tk.FormattingEnabled = true;
            this.cmb_tk.Location = new System.Drawing.Point(22, 144);
            this.cmb_tk.Name = "cmb_tk";
            this.cmb_tk.Size = new System.Drawing.Size(572, 37);
            this.cmb_tk.TabIndex = 9;
            this.cmb_tk.Text = "                             Chọn thống kê";
            this.cmb_tk.SelectedIndexChanged += new System.EventHandler(this.cmb_tk_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn thống kê cần tìm: ";
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 600);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.cmb_tk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pn_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThongKe";
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.ComboBox cmb_tk;
        private System.Windows.Forms.Label label1;
    }
}