namespace DangKyHocPhanSV
{
    partial class FrmQuenMatKhau
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
            this.pn_email = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_tieptheo = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.pn_email.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_email
            // 
            this.pn_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.pn_email.Controls.Add(this.btn_exit);
            this.pn_email.Controls.Add(this.btn_tieptheo);
            this.pn_email.Controls.Add(this.txt_email);
            this.pn_email.Controls.Add(this.lbl_email);
            this.pn_email.Location = new System.Drawing.Point(12, 12);
            this.pn_email.Name = "pn_email";
            this.pn_email.Size = new System.Drawing.Size(491, 167);
            this.pn_email.TabIndex = 14;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(272, 89);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(177, 50);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_tieptheo
            // 
            this.btn_tieptheo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tieptheo.Location = new System.Drawing.Point(50, 89);
            this.btn_tieptheo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tieptheo.Name = "btn_tieptheo";
            this.btn_tieptheo.Size = new System.Drawing.Size(177, 50);
            this.btn_tieptheo.TabIndex = 16;
            this.btn_tieptheo.Text = "Tiếp theo";
            this.btn_tieptheo.UseVisualStyleBackColor = true;
            this.btn_tieptheo.Click += new System.EventHandler(this.btn_tieptheo_Click);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(129, 28);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(323, 32);
            this.txt_email.TabIndex = 15;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_email.Location = new System.Drawing.Point(38, 31);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(62, 24);
            this.lbl_email.TabIndex = 14;
            this.lbl_email.Text = "Email:";
            // 
            // FrmQuenMatKhau
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(515, 191);
            this.Controls.Add(this.pn_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmQuenMatKhau";
            this.pn_email.ResumeLayout(false);
            this.pn_email.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_email;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_tieptheo;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
    }
}