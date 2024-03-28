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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_chonbt = new System.Windows.Forms.Label();
            this.dgv_baitap = new System.Windows.Forms.DataGridView();
            this.txt_chuong = new System.Windows.Forms.TextBox();
            this.dgv_bainop = new System.Windows.Forms.DataGridView();
            this.lbl_nopbai = new System.Windows.Forms.Label();
            this.lbl_dsbaitap = new System.Windows.Forms.Label();
            this.tblopn_chonbaitap = new System.Windows.Forms.TableLayoutPanel();
            this.cb_chonbt = new System.Windows.Forms.ComboBox();
            this.tblopn_baitap = new System.Windows.Forms.TableLayoutPanel();
            this.tblopn_nopbai = new System.Windows.Forms.TableLayoutPanel();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.btn_nopbai = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.tblopn_info = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_idbainop = new System.Windows.Forms.Label();
            this.txt_duongdan = new System.Windows.Forms.TextBox();
            this.lbl_tentaptin = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.lbl_duongdan = new System.Windows.Forms.Label();
            this.txt_idbainop = new System.Windows.Forms.TextBox();
            this.pn_uploadfile = new System.Windows.Forms.Panel();
            this.pn_content = new System.Windows.Forms.Panel();
            this.openFD_openfile = new System.Windows.Forms.OpenFileDialog();
            this.saveFD_savefile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bainop)).BeginInit();
            this.tblopn_chonbaitap.SuspendLayout();
            this.tblopn_baitap.SuspendLayout();
            this.tblopn_nopbai.SuspendLayout();
            this.tblopn_info.SuspendLayout();
            this.pn_uploadfile.SuspendLayout();
            this.pn_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_chonbt
            // 
            this.lbl_chonbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_chonbt.AutoSize = true;
            this.lbl_chonbt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chonbt.Location = new System.Drawing.Point(122, 0);
            this.lbl_chonbt.Name = "lbl_chonbt";
            this.lbl_chonbt.Size = new System.Drawing.Size(118, 24);
            this.lbl_chonbt.TabIndex = 16;
            this.lbl_chonbt.Text = "Chọn bài tập";
            // 
            // dgv_baitap
            // 
            this.dgv_baitap.AllowUserToAddRows = false;
            this.dgv_baitap.AllowUserToDeleteRows = false;
            this.dgv_baitap.AllowUserToResizeColumns = false;
            this.dgv_baitap.AllowUserToResizeRows = false;
            this.dgv_baitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_baitap.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_baitap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_baitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_baitap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_baitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_baitap.Location = new System.Drawing.Point(3, 93);
            this.dgv_baitap.MultiSelect = false;
            this.dgv_baitap.Name = "dgv_baitap";
            this.dgv_baitap.ReadOnly = true;
            this.dgv_baitap.RowHeadersVisible = false;
            this.dgv_baitap.RowHeadersWidth = 51;
            this.dgv_baitap.RowTemplate.Height = 24;
            this.dgv_baitap.Size = new System.Drawing.Size(485, 334);
            this.dgv_baitap.TabIndex = 13;
            this.dgv_baitap.TabStop = false;
            // 
            // txt_chuong
            // 
            this.txt_chuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_chuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chuong.Location = new System.Drawing.Point(43, 38);
            this.txt_chuong.Name = "txt_chuong";
            this.txt_chuong.Size = new System.Drawing.Size(405, 32);
            this.txt_chuong.TabIndex = 15;
            // 
            // dgv_bainop
            // 
            this.dgv_bainop.AllowUserToAddRows = false;
            this.dgv_bainop.AllowUserToDeleteRows = false;
            this.dgv_bainop.AllowUserToResizeColumns = false;
            this.dgv_bainop.AllowUserToResizeRows = false;
            this.dgv_bainop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bainop.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_bainop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bainop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bainop.Location = new System.Drawing.Point(494, 93);
            this.dgv_bainop.MultiSelect = false;
            this.dgv_bainop.Name = "dgv_bainop";
            this.dgv_bainop.ReadOnly = true;
            this.dgv_bainop.RowHeadersVisible = false;
            this.dgv_bainop.RowHeadersWidth = 51;
            this.dgv_bainop.RowTemplate.Height = 24;
            this.dgv_bainop.Size = new System.Drawing.Size(486, 334);
            this.dgv_bainop.TabIndex = 15;
            this.dgv_bainop.TabStop = false;
            // 
            // lbl_nopbai
            // 
            this.lbl_nopbai.AutoSize = true;
            this.lbl_nopbai.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nopbai.Location = new System.Drawing.Point(494, 0);
            this.lbl_nopbai.Name = "lbl_nopbai";
            this.lbl_nopbai.Size = new System.Drawing.Size(76, 24);
            this.lbl_nopbai.TabIndex = 0;
            this.lbl_nopbai.Text = "Nộp bài";
            // 
            // lbl_dsbaitap
            // 
            this.lbl_dsbaitap.AutoSize = true;
            this.lbl_dsbaitap.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dsbaitap.Location = new System.Drawing.Point(3, 0);
            this.lbl_dsbaitap.Name = "lbl_dsbaitap";
            this.lbl_dsbaitap.Size = new System.Drawing.Size(161, 24);
            this.lbl_dsbaitap.TabIndex = 1;
            this.lbl_dsbaitap.Text = "Danh sách bài tập";
            // 
            // tblopn_chonbaitap
            // 
            this.tblopn_chonbaitap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblopn_chonbaitap.ColumnCount = 2;
            this.tblopn_chonbaitap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblopn_chonbaitap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblopn_chonbaitap.Controls.Add(this.cb_chonbt, 1, 0);
            this.tblopn_chonbaitap.Controls.Add(this.lbl_chonbt, 0, 0);
            this.tblopn_chonbaitap.Location = new System.Drawing.Point(494, 38);
            this.tblopn_chonbaitap.Name = "tblopn_chonbaitap";
            this.tblopn_chonbaitap.RowCount = 1;
            this.tblopn_chonbaitap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblopn_chonbaitap.Size = new System.Drawing.Size(486, 49);
            this.tblopn_chonbaitap.TabIndex = 2;
            // 
            // cb_chonbt
            // 
            this.cb_chonbt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chonbt.FormattingEnabled = true;
            this.cb_chonbt.Location = new System.Drawing.Point(246, 3);
            this.cb_chonbt.Name = "cb_chonbt";
            this.cb_chonbt.Size = new System.Drawing.Size(237, 32);
            this.cb_chonbt.TabIndex = 17;
            this.cb_chonbt.SelectedIndexChanged += new System.EventHandler(this.cb_chonbt_SelectedIndexChanged);
            // 
            // tblopn_baitap
            // 
            this.tblopn_baitap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblopn_baitap.ColumnCount = 2;
            this.tblopn_baitap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblopn_baitap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblopn_baitap.Controls.Add(this.tblopn_nopbai, 0, 3);
            this.tblopn_baitap.Controls.Add(this.dgv_baitap, 0, 2);
            this.tblopn_baitap.Controls.Add(this.txt_chuong, 0, 1);
            this.tblopn_baitap.Controls.Add(this.dgv_bainop, 1, 2);
            this.tblopn_baitap.Controls.Add(this.lbl_nopbai, 1, 0);
            this.tblopn_baitap.Controls.Add(this.lbl_dsbaitap, 0, 0);
            this.tblopn_baitap.Controls.Add(this.tblopn_chonbaitap, 1, 1);
            this.tblopn_baitap.Controls.Add(this.tblopn_info, 0, 3);
            this.tblopn_baitap.Location = new System.Drawing.Point(3, 2);
            this.tblopn_baitap.Name = "tblopn_baitap";
            this.tblopn_baitap.RowCount = 4;
            this.tblopn_baitap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.681818F));
            this.tblopn_baitap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.928572F));
            this.tblopn_baitap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.19481F));
            this.tblopn_baitap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.03247F));
            this.tblopn_baitap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblopn_baitap.Size = new System.Drawing.Size(983, 616);
            this.tblopn_baitap.TabIndex = 0;
            // 
            // tblopn_nopbai
            // 
            this.tblopn_nopbai.BackColor = System.Drawing.Color.Silver;
            this.tblopn_nopbai.ColumnCount = 3;
            this.tblopn_nopbai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblopn_nopbai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblopn_nopbai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblopn_nopbai.Controls.Add(this.btn_quaylai, 2, 3);
            this.tblopn_nopbai.Controls.Add(this.btn_nopbai, 0, 2);
            this.tblopn_nopbai.Controls.Add(this.btn_xoa, 2, 2);
            this.tblopn_nopbai.Controls.Add(this.btn_capnhat, 1, 2);
            this.tblopn_nopbai.Location = new System.Drawing.Point(494, 433);
            this.tblopn_nopbai.Name = "tblopn_nopbai";
            this.tblopn_nopbai.RowCount = 4;
            this.tblopn_nopbai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblopn_nopbai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblopn_nopbai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblopn_nopbai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblopn_nopbai.Size = new System.Drawing.Size(482, 180);
            this.tblopn_nopbai.TabIndex = 18;
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_quaylai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(323, 130);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(154, 47);
            this.btn_quaylai.TabIndex = 12;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // btn_nopbai
            // 
            this.btn_nopbai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_nopbai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nopbai.Location = new System.Drawing.Point(3, 71);
            this.btn_nopbai.Name = "btn_nopbai";
            this.btn_nopbai.Size = new System.Drawing.Size(154, 52);
            this.btn_nopbai.TabIndex = 13;
            this.btn_nopbai.Text = "Nộp bài";
            this.btn_nopbai.UseVisualStyleBackColor = true;
            this.btn_nopbai.Click += new System.EventHandler(this.btn_nopbai_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_xoa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(323, 71);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(154, 52);
            this.btn_xoa.TabIndex = 14;
            this.btn_xoa.Text = "Xóa bài nộp";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_capnhat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.Location = new System.Drawing.Point(163, 71);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(154, 52);
            this.btn_capnhat.TabIndex = 21;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // tblopn_info
            // 
            this.tblopn_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblopn_info.BackColor = System.Drawing.Color.Silver;
            this.tblopn_info.ColumnCount = 2;
            this.tblopn_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.63918F));
            this.tblopn_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.36082F));
            this.tblopn_info.Controls.Add(this.lbl_idbainop, 0, 0);
            this.tblopn_info.Controls.Add(this.txt_duongdan, 1, 2);
            this.tblopn_info.Controls.Add(this.lbl_tentaptin, 0, 1);
            this.tblopn_info.Controls.Add(this.txt_ten, 1, 1);
            this.tblopn_info.Controls.Add(this.lbl_duongdan, 0, 2);
            this.tblopn_info.Controls.Add(this.txt_idbainop, 1, 0);
            this.tblopn_info.Location = new System.Drawing.Point(3, 433);
            this.tblopn_info.Name = "tblopn_info";
            this.tblopn_info.RowCount = 4;
            this.tblopn_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblopn_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblopn_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblopn_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblopn_info.Size = new System.Drawing.Size(485, 180);
            this.tblopn_info.TabIndex = 16;
            // 
            // lbl_idbainop
            // 
            this.lbl_idbainop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_idbainop.AutoSize = true;
            this.lbl_idbainop.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_idbainop.Location = new System.Drawing.Point(3, 10);
            this.lbl_idbainop.Name = "lbl_idbainop";
            this.lbl_idbainop.Size = new System.Drawing.Size(106, 24);
            this.lbl_idbainop.TabIndex = 15;
            this.lbl_idbainop.Text = "Mã bài nộp";
            // 
            // txt_duongdan
            // 
            this.txt_duongdan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_duongdan.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_duongdan.Location = new System.Drawing.Point(171, 96);
            this.txt_duongdan.Name = "txt_duongdan";
            this.txt_duongdan.Size = new System.Drawing.Size(311, 32);
            this.txt_duongdan.TabIndex = 20;
            // 
            // lbl_tentaptin
            // 
            this.lbl_tentaptin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_tentaptin.AutoSize = true;
            this.lbl_tentaptin.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_tentaptin.Location = new System.Drawing.Point(3, 55);
            this.lbl_tentaptin.Name = "lbl_tentaptin";
            this.lbl_tentaptin.Size = new System.Drawing.Size(39, 24);
            this.lbl_tentaptin.TabIndex = 16;
            this.lbl_tentaptin.Text = "Tên";
            // 
            // txt_ten
            // 
            this.txt_ten.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_ten.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_ten.Location = new System.Drawing.Point(171, 51);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(311, 32);
            this.txt_ten.TabIndex = 19;
            // 
            // lbl_duongdan
            // 
            this.lbl_duongdan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_duongdan.AutoSize = true;
            this.lbl_duongdan.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_duongdan.Location = new System.Drawing.Point(3, 100);
            this.lbl_duongdan.Name = "lbl_duongdan";
            this.lbl_duongdan.Size = new System.Drawing.Size(103, 24);
            this.lbl_duongdan.TabIndex = 17;
            this.lbl_duongdan.Text = "Đường dẫn";
            // 
            // txt_idbainop
            // 
            this.txt_idbainop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_idbainop.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_idbainop.Location = new System.Drawing.Point(171, 6);
            this.txt_idbainop.Name = "txt_idbainop";
            this.txt_idbainop.Size = new System.Drawing.Size(311, 32);
            this.txt_idbainop.TabIndex = 18;
            // 
            // pn_uploadfile
            // 
            this.pn_uploadfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_uploadfile.Controls.Add(this.tblopn_baitap);
            this.pn_uploadfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_uploadfile.Location = new System.Drawing.Point(0, 0);
            this.pn_uploadfile.Name = "pn_uploadfile";
            this.pn_uploadfile.Size = new System.Drawing.Size(991, 623);
            this.pn_uploadfile.TabIndex = 1;
            // 
            // pn_content
            // 
            this.pn_content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_content.Controls.Add(this.pn_uploadfile);
            this.pn_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_content.Location = new System.Drawing.Point(0, 0);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(993, 625);
            this.pn_content.TabIndex = 13;
            // 
            // openFD_openfile
            // 
            this.openFD_openfile.FileName = "openFileDialog1";
            // 
            // FrmDanhSachBaiTapSinhVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(993, 625);
            this.Controls.Add(this.pn_content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDanhSachBaiTapSinhVien";
            this.Text = "FrmDanhSachBaiTapSinhVien";
            this.Load += new System.EventHandler(this.FrmDanhSachBaiTapSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bainop)).EndInit();
            this.tblopn_chonbaitap.ResumeLayout(false);
            this.tblopn_chonbaitap.PerformLayout();
            this.tblopn_baitap.ResumeLayout(false);
            this.tblopn_baitap.PerformLayout();
            this.tblopn_nopbai.ResumeLayout(false);
            this.tblopn_info.ResumeLayout(false);
            this.tblopn_info.PerformLayout();
            this.pn_uploadfile.ResumeLayout(false);
            this.pn_content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_chonbt;
        private System.Windows.Forms.DataGridView dgv_baitap;
        private System.Windows.Forms.TextBox txt_chuong;
        private System.Windows.Forms.DataGridView dgv_bainop;
        private System.Windows.Forms.Label lbl_nopbai;
        private System.Windows.Forms.Label lbl_dsbaitap;
        private System.Windows.Forms.TableLayoutPanel tblopn_chonbaitap;
        private System.Windows.Forms.ComboBox cb_chonbt;
        private System.Windows.Forms.TableLayoutPanel tblopn_baitap;
        private System.Windows.Forms.TableLayoutPanel tblopn_info;
        private System.Windows.Forms.Panel pn_uploadfile;
        private System.Windows.Forms.Panel pn_content;
        private System.Windows.Forms.OpenFileDialog openFD_openfile;
        private System.Windows.Forms.SaveFileDialog saveFD_savefile;
        private System.Windows.Forms.TableLayoutPanel tblopn_nopbai;
        private System.Windows.Forms.TextBox txt_duongdan;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label lbl_duongdan;
        private System.Windows.Forms.Label lbl_tentaptin;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Button btn_nopbai;
        private System.Windows.Forms.Label lbl_idbainop;
        private System.Windows.Forms.TextBox txt_idbainop;
        private System.Windows.Forms.Button btn_capnhat;
    }
}