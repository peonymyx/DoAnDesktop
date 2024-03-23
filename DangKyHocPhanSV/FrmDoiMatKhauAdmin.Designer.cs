
namespace DangKyHocPhanSV
{
    partial class FrmDoiMatKhauAdmin
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_doimatkhau = new System.Windows.Forms.Button();
            this.txt_mkmoi = new System.Windows.Forms.TextBox();
            this.lbl_mkmoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(280, 106);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(177, 50);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btn_doimatkhau
            // 
            this.btn_doimatkhau.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doimatkhau.Location = new System.Drawing.Point(58, 106);
            this.btn_doimatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.btn_doimatkhau.Name = "btn_doimatkhau";
            this.btn_doimatkhau.Size = new System.Drawing.Size(177, 50);
            this.btn_doimatkhau.TabIndex = 10;
            this.btn_doimatkhau.Text = "Đổi mật khẩu";
            this.btn_doimatkhau.UseVisualStyleBackColor = true;
            this.btn_doimatkhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // txt_mkmoi
            // 
            this.txt_mkmoi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mkmoi.Location = new System.Drawing.Point(262, 39);
            this.txt_mkmoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mkmoi.Name = "txt_mkmoi";
            this.txt_mkmoi.PasswordChar = '*';
            this.txt_mkmoi.Size = new System.Drawing.Size(219, 32);
            this.txt_mkmoi.TabIndex = 9;
            this.txt_mkmoi.TextChanged += new System.EventHandler(this.txtMatKhauMoi_TextChanged);
            // 
            // lbl_mkmoi
            // 
            this.lbl_mkmoi.AutoSize = true;
            this.lbl_mkmoi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mkmoi.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_mkmoi.Location = new System.Drawing.Point(39, 42);
            this.lbl_mkmoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mkmoi.Name = "lbl_mkmoi";
            this.lbl_mkmoi.Size = new System.Drawing.Size(179, 24);
            this.lbl_mkmoi.TabIndex = 8;
            this.lbl_mkmoi.Text = "Nhập mật khẩu mới";
            // 
            // FrmDoiMatKhauAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(515, 191);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_doimatkhau);
            this.Controls.Add(this.txt_mkmoi);
            this.Controls.Add(this.lbl_mkmoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDoiMatKhauAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_doimatkhau;
        private System.Windows.Forms.TextBox txt_mkmoi;
        private System.Windows.Forms.Label lbl_mkmoi;
    }
}