
namespace DangKyHocPhanSV
{
    partial class FrmTrangGiangVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_header = new System.Windows.Forms.Label();
            this.pn_content = new System.Windows.Forms.Panel();
            this.dgv_thoikhoabieu = new System.Windows.Forms.DataGridView();
            this.pn_container = new System.Windows.Forms.Panel();
            this.pn_header = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pn_exit = new System.Windows.Forms.Panel();
            this.btn_doimk = new System.Windows.Forms.Button();
            this.lbl_infogiangvien = new System.Windows.Forms.Label();
            this.lbl_giangvien = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.pn_dslophoc = new System.Windows.Forms.Panel();
            this.btn_dslophoc = new System.Windows.Forms.Button();
            this.pn_infogiangvien = new System.Windows.Forms.Panel();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.pic_menu = new System.Windows.Forms.PictureBox();
            this.pn_menu = new System.Windows.Forms.Panel();
            this.pn_mainmenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thoikhoabieu)).BeginInit();
            this.pn_container.SuspendLayout();
            this.pn_header.SuspendLayout();
            this.pn_exit.SuspendLayout();
            this.pn_dslophoc.SuspendLayout();
            this.pn_infogiangvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).BeginInit();
            this.pn_menu.SuspendLayout();
            this.pn_mainmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_header.Location = new System.Drawing.Point(246, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(486, 40);
            this.lbl_header.TabIndex = 2;
            this.lbl_header.Text = "THỜI KHÓA BIỂU CỦA GIẢNG VIÊN";
            // 
            // pn_content
            // 
            this.pn_content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_content.Controls.Add(this.dgv_thoikhoabieu);
            this.pn_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_content.Location = new System.Drawing.Point(0, 63);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(993, 622);
            this.pn_content.TabIndex = 1;
            // 
            // dgv_thoikhoabieu
            // 
            this.dgv_thoikhoabieu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_thoikhoabieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_thoikhoabieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_thoikhoabieu.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_thoikhoabieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_thoikhoabieu.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_thoikhoabieu.Location = new System.Drawing.Point(0, 0);
            this.dgv_thoikhoabieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_thoikhoabieu.Name = "dgv_thoikhoabieu";
            this.dgv_thoikhoabieu.ReadOnly = true;
            this.dgv_thoikhoabieu.RowHeadersVisible = false;
            this.dgv_thoikhoabieu.RowHeadersWidth = 51;
            this.dgv_thoikhoabieu.RowTemplate.Height = 24;
            this.dgv_thoikhoabieu.Size = new System.Drawing.Size(991, 620);
            this.dgv_thoikhoabieu.TabIndex = 22;
            // 
            // pn_container
            // 
            this.pn_container.Controls.Add(this.pn_content);
            this.pn_container.Controls.Add(this.pn_header);
            this.pn_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container.Location = new System.Drawing.Point(287, 0);
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(993, 685);
            this.pn_container.TabIndex = 5;
            // 
            // pn_header
            // 
            this.pn_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.pn_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_header.Controls.Add(this.lbl_header);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(993, 63);
            this.pn_header.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Image = global::DangKyHocPhanSV.Properties.Resources.exit;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(-5, -14);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_exit.Size = new System.Drawing.Size(315, 100);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "               Thoát";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pn_exit
            // 
            this.pn_exit.Controls.Add(this.btn_exit);
            this.pn_exit.Location = new System.Drawing.Point(3, 332);
            this.pn_exit.Name = "pn_exit";
            this.pn_exit.Size = new System.Drawing.Size(284, 71);
            this.pn_exit.TabIndex = 8;
            // 
            // btn_doimk
            // 
            this.btn_doimk.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doimk.Location = new System.Drawing.Point(59, 129);
            this.btn_doimk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_doimk.Name = "btn_doimk";
            this.btn_doimk.Size = new System.Drawing.Size(156, 44);
            this.btn_doimk.TabIndex = 12;
            this.btn_doimk.Text = "Đổi mật khẩu";
            this.btn_doimk.UseVisualStyleBackColor = true;
            this.btn_doimk.Click += new System.EventHandler(this.btn_doimk_Click);
            // 
            // lbl_infogiangvien
            // 
            this.lbl_infogiangvien.AutoSize = true;
            this.lbl_infogiangvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_infogiangvien.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infogiangvien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_infogiangvien.Location = new System.Drawing.Point(9, 6);
            this.lbl_infogiangvien.Name = "lbl_infogiangvien";
            this.lbl_infogiangvien.Size = new System.Drawing.Size(202, 28);
            this.lbl_infogiangvien.TabIndex = 1;
            this.lbl_infogiangvien.Text = "Thông tin giảng viên";
            // 
            // lbl_giangvien
            // 
            this.lbl_giangvien.AutoSize = true;
            this.lbl_giangvien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giangvien.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_giangvien.Location = new System.Drawing.Point(10, 45);
            this.lbl_giangvien.Name = "lbl_giangvien";
            this.lbl_giangvien.Size = new System.Drawing.Size(104, 24);
            this.lbl_giangvien.TabIndex = 8;
            this.lbl_giangvien.Text = "Giảng viên:";
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_ten.Location = new System.Drawing.Point(8, 78);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ten.Multiline = true;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.ReadOnly = true;
            this.txt_ten.Size = new System.Drawing.Size(269, 33);
            this.txt_ten.TabIndex = 10;
            // 
            // pn_dslophoc
            // 
            this.pn_dslophoc.Controls.Add(this.btn_dslophoc);
            this.pn_dslophoc.Location = new System.Drawing.Point(3, 255);
            this.pn_dslophoc.Name = "pn_dslophoc";
            this.pn_dslophoc.Size = new System.Drawing.Size(284, 71);
            this.pn_dslophoc.TabIndex = 2;
            // 
            // btn_dslophoc
            // 
            this.btn_dslophoc.BackColor = System.Drawing.Color.Transparent;
            this.btn_dslophoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dslophoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_dslophoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_dslophoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dslophoc.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dslophoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dslophoc.Image = global::DangKyHocPhanSV.Properties.Resources.dangky_1_;
            this.btn_dslophoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dslophoc.Location = new System.Drawing.Point(-10, -14);
            this.btn_dslophoc.Name = "btn_dslophoc";
            this.btn_dslophoc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_dslophoc.Size = new System.Drawing.Size(315, 100);
            this.btn_dslophoc.TabIndex = 0;
            this.btn_dslophoc.Text = "               Danh sách lớp học";
            this.btn_dslophoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dslophoc.UseVisualStyleBackColor = false;
            this.btn_dslophoc.Click += new System.EventHandler(this.btn_dslophoc_Click);
            // 
            // pn_infogiangvien
            // 
            this.pn_infogiangvien.BackColor = System.Drawing.Color.Gray;
            this.pn_infogiangvien.Controls.Add(this.btn_doimk);
            this.pn_infogiangvien.Controls.Add(this.lbl_infogiangvien);
            this.pn_infogiangvien.Controls.Add(this.lbl_giangvien);
            this.pn_infogiangvien.Controls.Add(this.txt_ten);
            this.pn_infogiangvien.Location = new System.Drawing.Point(3, 63);
            this.pn_infogiangvien.MaximumSize = new System.Drawing.Size(284, 186);
            this.pn_infogiangvien.MinimumSize = new System.Drawing.Size(284, 46);
            this.pn_infogiangvien.Name = "pn_infogiangvien";
            this.pn_infogiangvien.Size = new System.Drawing.Size(284, 186);
            this.pn_infogiangvien.TabIndex = 1;
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_menu.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_menu.Location = new System.Drawing.Point(85, 15);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(68, 28);
            this.lbl_menu.TabIndex = 2;
            this.lbl_menu.Text = "Menu";
            // 
            // pic_menu
            // 
            this.pic_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_menu.Image = global::DangKyHocPhanSV.Properties.Resources.menu;
            this.pic_menu.Location = new System.Drawing.Point(0, 9);
            this.pic_menu.Name = "pic_menu";
            this.pic_menu.Size = new System.Drawing.Size(73, 39);
            this.pic_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_menu.TabIndex = 0;
            this.pic_menu.TabStop = false;
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.pn_menu.Controls.Add(this.lbl_menu);
            this.pn_menu.Controls.Add(this.pic_menu);
            this.pn_menu.Location = new System.Drawing.Point(3, 3);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(284, 54);
            this.pn_menu.TabIndex = 5;
            // 
            // pn_mainmenu
            // 
            this.pn_mainmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.pn_mainmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_mainmenu.Controls.Add(this.pn_menu);
            this.pn_mainmenu.Controls.Add(this.pn_infogiangvien);
            this.pn_mainmenu.Controls.Add(this.pn_dslophoc);
            this.pn_mainmenu.Controls.Add(this.pn_exit);
            this.pn_mainmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_mainmenu.Location = new System.Drawing.Point(0, 0);
            this.pn_mainmenu.MaximumSize = new System.Drawing.Size(287, 685);
            this.pn_mainmenu.MinimumSize = new System.Drawing.Size(78, 685);
            this.pn_mainmenu.Name = "pn_mainmenu";
            this.pn_mainmenu.Size = new System.Drawing.Size(287, 685);
            this.pn_mainmenu.TabIndex = 4;
            // 
            // FrmTrangGiangVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 685);
            this.Controls.Add(this.pn_container);
            this.Controls.Add(this.pn_mainmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTrangGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTrangGiangVien";
            this.Load += new System.EventHandler(this.FrmTrangGiangVien_Load);
            this.pn_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thoikhoabieu)).EndInit();
            this.pn_container.ResumeLayout(false);
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.pn_exit.ResumeLayout(false);
            this.pn_dslophoc.ResumeLayout(false);
            this.pn_infogiangvien.ResumeLayout(false);
            this.pn_infogiangvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).EndInit();
            this.pn_menu.ResumeLayout(false);
            this.pn_menu.PerformLayout();
            this.pn_mainmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Panel pn_content;
        private System.Windows.Forms.Panel pn_container;
        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel pn_exit;
        private System.Windows.Forms.Button btn_doimk;
        private System.Windows.Forms.Label lbl_infogiangvien;
        private System.Windows.Forms.Label lbl_giangvien;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Panel pn_dslophoc;
        private System.Windows.Forms.Button btn_dslophoc;
        private System.Windows.Forms.Panel pn_infogiangvien;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.PictureBox pic_menu;
        private System.Windows.Forms.Panel pn_menu;
        private System.Windows.Forms.FlowLayoutPanel pn_mainmenu;
        private System.Windows.Forms.DataGridView dgv_thoikhoabieu;
    }
}