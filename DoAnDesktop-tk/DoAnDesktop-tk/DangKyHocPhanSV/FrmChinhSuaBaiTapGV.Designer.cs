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
            this.cb_chonbt = new System.Windows.Forms.ComboBox();
            this.lbl_chonbt = new System.Windows.Forms.Label();
            this.dgv_bainop = new System.Windows.Forms.DataGridView();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.pn_thongtinchung = new System.Windows.Forms.Panel();
            this.grbox_noidung = new System.Windows.Forms.GroupBox();
            this.txt_chuong = new System.Windows.Forms.TextBox();
            this.dgv_baitap = new System.Windows.Forms.DataGridView();
            this.pn_setting = new System.Windows.Forms.Panel();
            this.btn_xoabt = new System.Windows.Forms.Button();
            this.btn_capnhatbt = new System.Windows.Forms.Button();
            this.btn_taobaitap = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.pic_type = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.lbl_IDBT = new System.Windows.Forms.Label();
            this.lbl_hannop = new System.Windows.Forms.Label();
            this.pn_content.SuspendLayout();
            this.pn_uploadfile.SuspendLayout();
            this.grbox_upload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bainop)).BeginInit();
            this.pn_thongtinchung.SuspendLayout();
            this.grbox_noidung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baitap)).BeginInit();
            this.pn_setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_type)).BeginInit();
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
            this.grbox_upload.Controls.Add(this.cb_chonbt);
            this.grbox_upload.Controls.Add(this.lbl_chonbt);
            this.grbox_upload.Controls.Add(this.dgv_bainop);
            this.grbox_upload.Controls.Add(this.btn_quaylai);
            this.grbox_upload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbox_upload.Font = new System.Drawing.Font("Calibri", 12F);
            this.grbox_upload.Location = new System.Drawing.Point(0, 0);
            this.grbox_upload.Name = "grbox_upload";
            this.grbox_upload.Size = new System.Drawing.Size(497, 621);
            this.grbox_upload.TabIndex = 0;
            this.grbox_upload.TabStop = false;
            this.grbox_upload.Text = "Quản Lý Bài Nộp";
            // 
            // cb_chonbt
            // 
            this.cb_chonbt.FormattingEnabled = true;
            this.cb_chonbt.Location = new System.Drawing.Point(181, 38);
            this.cb_chonbt.Name = "cb_chonbt";
            this.cb_chonbt.Size = new System.Drawing.Size(274, 32);
            this.cb_chonbt.TabIndex = 17;
            // 
            // lbl_chonbt
            // 
            this.lbl_chonbt.AutoSize = true;
            this.lbl_chonbt.Location = new System.Drawing.Point(34, 41);
            this.lbl_chonbt.Name = "lbl_chonbt";
            this.lbl_chonbt.Size = new System.Drawing.Size(118, 24);
            this.lbl_chonbt.TabIndex = 16;
            this.lbl_chonbt.Text = "Chọn bài tập";
            // 
            // dgv_bainop
            // 
            this.dgv_bainop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bainop.Location = new System.Drawing.Point(38, 88);
            this.dgv_bainop.Name = "dgv_bainop";
            this.dgv_bainop.RowHeadersWidth = 51;
            this.dgv_bainop.RowTemplate.Height = 24;
            this.dgv_bainop.Size = new System.Drawing.Size(418, 451);
            this.dgv_bainop.TabIndex = 15;
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(332, 560);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(124, 41);
            this.btn_quaylai.TabIndex = 11;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click_1);
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
            this.grbox_noidung.Controls.Add(this.txt_chuong);
            this.grbox_noidung.Controls.Add(this.dgv_baitap);
            this.grbox_noidung.Controls.Add(this.pn_setting);
            this.grbox_noidung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbox_noidung.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_noidung.Location = new System.Drawing.Point(0, 0);
            this.grbox_noidung.Name = "grbox_noidung";
            this.grbox_noidung.Size = new System.Drawing.Size(490, 621);
            this.grbox_noidung.TabIndex = 0;
            this.grbox_noidung.TabStop = false;
            this.grbox_noidung.Text = "Quản Lý Bài Tập";
            // 
            // txt_chuong
            // 
            this.txt_chuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chuong.Location = new System.Drawing.Point(10, 31);
            this.txt_chuong.Name = "txt_chuong";
            this.txt_chuong.Size = new System.Drawing.Size(465, 32);
            this.txt_chuong.TabIndex = 15;
            // 
            // dgv_baitap
            // 
            this.dgv_baitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_baitap.Location = new System.Drawing.Point(9, 88);
            this.dgv_baitap.Name = "dgv_baitap";
            this.dgv_baitap.RowHeadersWidth = 51;
            this.dgv_baitap.RowTemplate.Height = 24;
            this.dgv_baitap.Size = new System.Drawing.Size(466, 180);
            this.dgv_baitap.TabIndex = 13;
            // 
            // pn_setting
            // 
            this.pn_setting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_setting.Controls.Add(this.btn_xoabt);
            this.pn_setting.Controls.Add(this.btn_capnhatbt);
            this.pn_setting.Controls.Add(this.btn_taobaitap);
            this.pn_setting.Controls.Add(this.textBox3);
            this.pn_setting.Controls.Add(this.btn_upload);
            this.pn_setting.Controls.Add(this.textBox2);
            this.pn_setting.Controls.Add(this.txt_link);
            this.pn_setting.Controls.Add(this.pic_type);
            this.pn_setting.Controls.Add(this.textBox1);
            this.pn_setting.Controls.Add(this.lbl_tieude);
            this.pn_setting.Controls.Add(this.lbl_IDBT);
            this.pn_setting.Controls.Add(this.lbl_hannop);
            this.pn_setting.Location = new System.Drawing.Point(6, 282);
            this.pn_setting.Name = "pn_setting";
            this.pn_setting.Size = new System.Drawing.Size(470, 319);
            this.pn_setting.TabIndex = 12;
            // 
            // btn_xoabt
            // 
            this.btn_xoabt.Location = new System.Drawing.Point(337, 244);
            this.btn_xoabt.Name = "btn_xoabt";
            this.btn_xoabt.Size = new System.Drawing.Size(101, 42);
            this.btn_xoabt.TabIndex = 16;
            this.btn_xoabt.Text = "Xóa";
            this.btn_xoabt.UseVisualStyleBackColor = true;
            this.btn_xoabt.Click += new System.EventHandler(this.btn_xoabt_Click);
            // 
            // btn_capnhatbt
            // 
            this.btn_capnhatbt.Location = new System.Drawing.Point(191, 244);
            this.btn_capnhatbt.Name = "btn_capnhatbt";
            this.btn_capnhatbt.Size = new System.Drawing.Size(101, 42);
            this.btn_capnhatbt.TabIndex = 15;
            this.btn_capnhatbt.Text = "Cập nhật";
            this.btn_capnhatbt.UseVisualStyleBackColor = true;
            this.btn_capnhatbt.Click += new System.EventHandler(this.btn_capnhatbt_Click);
            // 
            // btn_taobaitap
            // 
            this.btn_taobaitap.Location = new System.Drawing.Point(22, 244);
            this.btn_taobaitap.Name = "btn_taobaitap";
            this.btn_taobaitap.Size = new System.Drawing.Size(128, 42);
            this.btn_taobaitap.TabIndex = 14;
            this.btn_taobaitap.Text = "Tạo bài tập";
            this.btn_taobaitap.UseVisualStyleBackColor = true;
            this.btn_taobaitap.Click += new System.EventHandler(this.btn_taobaitap_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(160, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(278, 36);
            this.textBox3.TabIndex = 11;
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(22, 186);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(100, 33);
            this.btn_upload.TabIndex = 0;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(159, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 36);
            this.textBox2.TabIndex = 10;
            // 
            // txt_link
            // 
            this.txt_link.BackColor = System.Drawing.SystemColors.Control;
            this.txt_link.Location = new System.Drawing.Point(216, 187);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(219, 32);
            this.txt_link.TabIndex = 1;
            // 
            // pic_type
            // 
            this.pic_type.Location = new System.Drawing.Point(157, 187);
            this.pic_type.Name = "pic_type";
            this.pic_type.Size = new System.Drawing.Size(35, 32);
            this.pic_type.TabIndex = 13;
            this.pic_type.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(160, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 36);
            this.textBox1.TabIndex = 9;
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieude.Location = new System.Drawing.Point(18, 81);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(72, 24);
            this.lbl_tieude.TabIndex = 2;
            this.lbl_tieude.Text = "Tiêu đề";
            // 
            // lbl_IDBT
            // 
            this.lbl_IDBT.AutoSize = true;
            this.lbl_IDBT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDBT.Location = new System.Drawing.Point(20, 34);
            this.lbl_IDBT.Name = "lbl_IDBT";
            this.lbl_IDBT.Size = new System.Drawing.Size(92, 24);
            this.lbl_IDBT.TabIndex = 3;
            this.lbl_IDBT.Text = "ID Bài Tập";
            // 
            // lbl_hannop
            // 
            this.lbl_hannop.AutoSize = true;
            this.lbl_hannop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hannop.Location = new System.Drawing.Point(20, 130);
            this.lbl_hannop.Name = "lbl_hannop";
            this.lbl_hannop.Size = new System.Drawing.Size(81, 24);
            this.lbl_hannop.TabIndex = 7;
            this.lbl_hannop.Text = "Hạn nộp";
            // 
            // FrmChinhSuaBaiTapGV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(993, 625);
            this.Controls.Add(this.pn_content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChinhSuaBaiTapGV";
            this.Text = "FrmLopHoc";
            this.Load += new System.EventHandler(this.FrmChinhSuaBaiTapGV_Load);
            this.pn_content.ResumeLayout(false);
            this.pn_uploadfile.ResumeLayout(false);
            this.grbox_upload.ResumeLayout(false);
            this.grbox_upload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bainop)).EndInit();
            this.pn_thongtinchung.ResumeLayout(false);
            this.grbox_noidung.ResumeLayout(false);
            this.grbox_noidung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baitap)).EndInit();
            this.pn_setting.ResumeLayout(false);
            this.pn_setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_type)).EndInit();
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.Label lbl_IDBT;
        private System.Windows.Forms.Label lbl_hannop;
        private System.Windows.Forms.DataGridView dgv_bainop;
        private System.Windows.Forms.DataGridView dgv_baitap;
        private System.Windows.Forms.Button btn_capnhatbt;
        private System.Windows.Forms.Button btn_xoabt;
        private System.Windows.Forms.TextBox txt_chuong;
        private System.Windows.Forms.ComboBox cb_chonbt;
        private System.Windows.Forms.Label lbl_chonbt;
    }
}