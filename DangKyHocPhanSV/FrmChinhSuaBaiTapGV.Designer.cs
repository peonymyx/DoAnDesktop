namespace DangKyHocPhanSV
{
    partial class FrmChinhSuaBaiTapGV
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
            this.saveFD_savefile = new System.Windows.Forms.SaveFileDialog();
            this.openFD_openfile = new System.Windows.Forms.OpenFileDialog();
            this.pn_content = new System.Windows.Forms.Panel();
            this.pn_uploadfile = new System.Windows.Forms.Panel();
            this.grbox_upload = new System.Windows.Forms.GroupBox();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.btn_taobaitap = new System.Windows.Forms.Button();
            this.pic_type = new System.Windows.Forms.PictureBox();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.pn_thongtinchung = new System.Windows.Forms.Panel();
            this.grbox_noidung = new System.Windows.Forms.GroupBox();
            this.pn_setting = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_noidung = new System.Windows.Forms.TextBox();
            this.pn_content.SuspendLayout();
            this.pn_uploadfile.SuspendLayout();
            this.grbox_upload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_type)).BeginInit();
            this.pn_thongtinchung.SuspendLayout();
            this.grbox_noidung.SuspendLayout();
            this.pn_setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFD_openfile
            // 
            this.openFD_openfile.FileName = "openFileDialog1";
            // 
            // pn_content
            // 
            this.pn_content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_content.Controls.Add(this.pn_uploadfile);
            this.pn_content.Controls.Add(this.pn_thongtinchung);
            this.pn_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_content.Location = new System.Drawing.Point(0, 0);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(993, 625);
            this.pn_content.TabIndex = 12;
            // 
            // pn_uploadfile
            // 
            this.pn_uploadfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_uploadfile.Controls.Add(this.grbox_upload);
            this.pn_uploadfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_uploadfile.Location = new System.Drawing.Point(492, 0);
            this.pn_uploadfile.Name = "pn_uploadfile";
            this.pn_uploadfile.Size = new System.Drawing.Size(499, 623);
            this.pn_uploadfile.TabIndex = 1;
            // 
            // grbox_upload
            // 
            this.grbox_upload.Controls.Add(this.btn_quaylai);
            this.grbox_upload.Controls.Add(this.btn_taobaitap);
            this.grbox_upload.Controls.Add(this.pic_type);
            this.grbox_upload.Controls.Add(this.txt_link);
            this.grbox_upload.Controls.Add(this.btn_upload);
            this.grbox_upload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbox_upload.Font = new System.Drawing.Font("Calibri", 12F);
            this.grbox_upload.Location = new System.Drawing.Point(0, 0);
            this.grbox_upload.Name = "grbox_upload";
            this.grbox_upload.Size = new System.Drawing.Size(497, 621);
            this.grbox_upload.TabIndex = 0;
            this.grbox_upload.TabStop = false;
            this.grbox_upload.Text = "Đăng tải tệp tin";
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(176, 536);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(124, 41);
            this.btn_quaylai.TabIndex = 11;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click_1);
            // 
            // btn_taobaitap
            // 
            this.btn_taobaitap.Location = new System.Drawing.Point(323, 532);
            this.btn_taobaitap.Name = "btn_taobaitap";
            this.btn_taobaitap.Size = new System.Drawing.Size(158, 48);
            this.btn_taobaitap.TabIndex = 14;
            this.btn_taobaitap.Text = "Tạo bài tập";
            this.btn_taobaitap.UseVisualStyleBackColor = true;
            this.btn_taobaitap.Click += new System.EventHandler(this.btn_taobaitap_Click_1);
            // 
            // pic_type
            // 
            this.pic_type.Location = new System.Drawing.Point(7, 31);
            this.pic_type.Name = "pic_type";
            this.pic_type.Size = new System.Drawing.Size(35, 32);
            this.pic_type.TabIndex = 13;
            this.pic_type.TabStop = false;
            // 
            // txt_link
            // 
            this.txt_link.BackColor = System.Drawing.SystemColors.Control;
            this.txt_link.Location = new System.Drawing.Point(48, 31);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(433, 32);
            this.txt_link.TabIndex = 1;
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(6, 69);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(109, 37);
            this.btn_upload.TabIndex = 0;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            // 
            // pn_thongtinchung
            // 
            this.pn_thongtinchung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_thongtinchung.Controls.Add(this.grbox_noidung);
            this.pn_thongtinchung.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_thongtinchung.Location = new System.Drawing.Point(0, 0);
            this.pn_thongtinchung.Name = "pn_thongtinchung";
            this.pn_thongtinchung.Size = new System.Drawing.Size(492, 623);
            this.pn_thongtinchung.TabIndex = 0;
            // 
            // grbox_noidung
            // 
            this.grbox_noidung.Controls.Add(this.pn_setting);
            this.grbox_noidung.Controls.Add(this.txt_noidung);
            this.grbox_noidung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbox_noidung.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_noidung.Location = new System.Drawing.Point(0, 0);
            this.grbox_noidung.Name = "grbox_noidung";
            this.grbox_noidung.Size = new System.Drawing.Size(490, 621);
            this.grbox_noidung.TabIndex = 0;
            this.grbox_noidung.TabStop = false;
            this.grbox_noidung.Text = "Tên bài tập";
            // 
            // pn_setting
            // 
            this.pn_setting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_setting.Controls.Add(this.textBox4);
            this.pn_setting.Controls.Add(this.textBox3);
            this.pn_setting.Controls.Add(this.textBox2);
            this.pn_setting.Controls.Add(this.textBox1);
            this.pn_setting.Controls.Add(this.label3);
            this.pn_setting.Controls.Add(this.label4);
            this.pn_setting.Controls.Add(this.label12);
            this.pn_setting.Controls.Add(this.label13);
            this.pn_setting.Location = new System.Drawing.Point(6, 282);
            this.pn_setting.Name = "pn_setting";
            this.pn_setting.Size = new System.Drawing.Size(470, 302);
            this.pn_setting.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(160, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(278, 36);
            this.textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(160, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(278, 36);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(159, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 36);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(160, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 36);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên bài tập:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 28);
            this.label12.TabIndex = 8;
            this.label12.Text = "Thời hạn nộp:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 28);
            this.label13.TabIndex = 7;
            this.label13.Text = "Giảng viên:";
            // 
            // txt_noidung
            // 
            this.txt_noidung.BackColor = System.Drawing.SystemColors.Info;
            this.txt_noidung.Location = new System.Drawing.Point(6, 28);
            this.txt_noidung.Multiline = true;
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.Size = new System.Drawing.Size(470, 250);
            this.txt_noidung.TabIndex = 0;
            // 
            // FrmChinhSuaBaiTapGV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(993, 625);
            this.Controls.Add(this.pn_content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChinhSuaBaiTapGV";
            this.Text = "FrmLopHoc";
            this.pn_content.ResumeLayout(false);
            this.pn_uploadfile.ResumeLayout(false);
            this.grbox_upload.ResumeLayout(false);
            this.grbox_upload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_type)).EndInit();
            this.pn_thongtinchung.ResumeLayout(false);
            this.grbox_noidung.ResumeLayout(false);
            this.grbox_noidung.PerformLayout();
            this.pn_setting.ResumeLayout(false);
            this.pn_setting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFD_savefile;
        private System.Windows.Forms.OpenFileDialog openFD_openfile;
        private System.Windows.Forms.Panel pn_content;
        private System.Windows.Forms.Panel pn_uploadfile;
        private System.Windows.Forms.GroupBox grbox_upload;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Button btn_taobaitap;
        private System.Windows.Forms.PictureBox pic_type;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Panel pn_thongtinchung;
        private System.Windows.Forms.GroupBox grbox_noidung;
        private System.Windows.Forms.Panel pn_setting;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_noidung;
    }
}