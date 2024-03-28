using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveFD_savefile = new System.Windows.Forms.SaveFileDialog();
            this.openFD_openfile = new System.Windows.Forms.OpenFileDialog();
            this.pn_content = new System.Windows.Forms.Panel();
            this.pn_uploadfile = new System.Windows.Forms.Panel();
            this.tblopn_quanly = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_baitap = new System.Windows.Forms.DataGridView();
            this.txt_chuong = new System.Windows.Forms.TextBox();
            this.dgv_bainop = new System.Windows.Forms.DataGridView();
            this.lbl_qlbainop = new System.Windows.Forms.Label();
            this.lbl_qlbaitap = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_chonbt = new System.Windows.Forms.ComboBox();
            this.lbl_chonbt = new System.Windows.Forms.Label();
            this.tblopn_chitiet = new System.Windows.Forms.TableLayoutPanel();
            this.dtp_hannop = new System.Windows.Forms.DateTimePicker();
            this.lbl_IDBT = new System.Windows.Forms.Label();
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.txt_IDBT = new System.Windows.Forms.TextBox();
            this.txt_tieude = new System.Windows.Forms.TextBox();
            this.lbl_hannop = new System.Windows.Forms.Label();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.tblo_chinsua = new System.Windows.Forms.TableLayoutPanel();
            this.btn_xoabt = new System.Windows.Forms.Button();
            this.btn_taobaitap = new System.Windows.Forms.Button();
            this.btn_capnhatbt = new System.Windows.Forms.Button();
            this.pn_content.SuspendLayout();
            this.pn_uploadfile.SuspendLayout();
            this.tblopn_quanly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bainop)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tblopn_chitiet.SuspendLayout();
            this.tblo_chinsua.SuspendLayout();
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
            this.pn_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_content.Location = new System.Drawing.Point(0, 0);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(993, 625);
            this.pn_content.TabIndex = 12;
            // 
            // pn_uploadfile
            // 
            this.pn_uploadfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_uploadfile.Controls.Add(this.tblopn_quanly);
            this.pn_uploadfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_uploadfile.Location = new System.Drawing.Point(0, 0);
            this.pn_uploadfile.Name = "pn_uploadfile";
            this.pn_uploadfile.Size = new System.Drawing.Size(991, 623);
            this.pn_uploadfile.TabIndex = 1;
            // 
            // tblopn_quanly
            // 
            this.tblopn_quanly.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblopn_quanly.ColumnCount = 2;
            this.tblopn_quanly.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblopn_quanly.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblopn_quanly.Controls.Add(this.dgv_baitap, 0, 2);
            this.tblopn_quanly.Controls.Add(this.txt_chuong, 0, 1);
            this.tblopn_quanly.Controls.Add(this.dgv_bainop, 1, 2);
            this.tblopn_quanly.Controls.Add(this.lbl_qlbainop, 1, 0);
            this.tblopn_quanly.Controls.Add(this.lbl_qlbaitap, 0, 0);
            this.tblopn_quanly.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tblopn_quanly.Controls.Add(this.tblopn_chitiet, 0, 3);
            this.tblopn_quanly.Controls.Add(this.btn_quaylai, 1, 4);
            this.tblopn_quanly.Controls.Add(this.tblo_chinsua, 0, 4);
            this.tblopn_quanly.Location = new System.Drawing.Point(3, 2);
            this.tblopn_quanly.Name = "tblopn_quanly";
            this.tblopn_quanly.RowCount = 5;
            this.tblopn_quanly.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.681818F));
            this.tblopn_quanly.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.577922F));
            this.tblopn_quanly.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.64286F));
            this.tblopn_quanly.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.03247F));
            this.tblopn_quanly.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.06493F));
            this.tblopn_quanly.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblopn_quanly.Size = new System.Drawing.Size(983, 616);
            this.tblopn_quanly.TabIndex = 0;
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
            this.dgv_baitap.Location = new System.Drawing.Point(3, 97);
            this.dgv_baitap.MultiSelect = false;
            this.dgv_baitap.Name = "dgv_baitap";
            this.dgv_baitap.ReadOnly = true;
            this.dgv_baitap.RowHeadersVisible = false;
            this.dgv_baitap.RowHeadersWidth = 51;
            this.dgv_baitap.RowTemplate.Height = 24;
            this.dgv_baitap.Size = new System.Drawing.Size(485, 269);
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
            this.dgv_bainop.Location = new System.Drawing.Point(494, 97);
            this.dgv_bainop.MultiSelect = false;
            this.dgv_bainop.Name = "dgv_bainop";
            this.dgv_bainop.ReadOnly = true;
            this.dgv_bainop.RowHeadersVisible = false;
            this.dgv_bainop.RowHeadersWidth = 51;
            this.dgv_bainop.RowTemplate.Height = 24;
            this.dgv_bainop.Size = new System.Drawing.Size(486, 269);
            this.dgv_bainop.TabIndex = 15;
            this.dgv_bainop.TabStop = false;
            // 
            // lbl_qlbainop
            // 
            this.lbl_qlbainop.AutoSize = true;
            this.lbl_qlbainop.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qlbainop.Location = new System.Drawing.Point(494, 0);
            this.lbl_qlbainop.Name = "lbl_qlbainop";
            this.lbl_qlbainop.Size = new System.Drawing.Size(144, 24);
            this.lbl_qlbainop.TabIndex = 0;
            this.lbl_qlbainop.Text = "Quản lý bài nộp";
            // 
            // lbl_qlbaitap
            // 
            this.lbl_qlbaitap.AutoSize = true;
            this.lbl_qlbaitap.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qlbaitap.Location = new System.Drawing.Point(3, 0);
            this.lbl_qlbaitap.Name = "lbl_qlbaitap";
            this.lbl_qlbaitap.Size = new System.Drawing.Size(139, 24);
            this.lbl_qlbaitap.TabIndex = 1;
            this.lbl_qlbaitap.Text = "Quản lý bài tập";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cb_chonbt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_chonbt, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(494, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(486, 53);
            this.tableLayoutPanel2.TabIndex = 2;
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
            // tblopn_chitiet
            // 
            this.tblopn_chitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblopn_chitiet.BackColor = System.Drawing.Color.Silver;
            this.tblopn_chitiet.ColumnCount = 2;
            this.tblopn_chitiet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblopn_chitiet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblopn_chitiet.Controls.Add(this.dtp_hannop, 1, 2);
            this.tblopn_chitiet.Controls.Add(this.lbl_IDBT, 0, 0);
            this.tblopn_chitiet.Controls.Add(this.lbl_tieude, 0, 1);
            this.tblopn_chitiet.Controls.Add(this.txt_IDBT, 1, 0);
            this.tblopn_chitiet.Controls.Add(this.txt_tieude, 1, 1);
            this.tblopn_chitiet.Controls.Add(this.lbl_hannop, 0, 2);
            this.tblopn_chitiet.Controls.Add(this.txt_link, 1, 3);
            this.tblopn_chitiet.Controls.Add(this.btn_upload, 0, 3);
            this.tblopn_chitiet.Location = new System.Drawing.Point(3, 372);
            this.tblopn_chitiet.Name = "tblopn_chitiet";
            this.tblopn_chitiet.RowCount = 4;
            this.tblopn_chitiet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblopn_chitiet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblopn_chitiet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblopn_chitiet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblopn_chitiet.Size = new System.Drawing.Size(485, 179);
            this.tblopn_chitiet.TabIndex = 16;
            // 
            // dtp_hannop
            // 
            this.dtp_hannop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_hannop.CustomFormat = "yyyy-MM-dd";
            this.dtp_hannop.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_hannop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_hannop.Location = new System.Drawing.Point(245, 93);
            this.dtp_hannop.Name = "dtp_hannop";
            this.dtp_hannop.Size = new System.Drawing.Size(237, 34);
            this.dtp_hannop.TabIndex = 17;
            this.dtp_hannop.Value = new System.DateTime(2024, 3, 26, 0, 0, 0, 0);
            // 
            // lbl_IDBT
            // 
            this.lbl_IDBT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_IDBT.AutoSize = true;
            this.lbl_IDBT.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDBT.Location = new System.Drawing.Point(3, 8);
            this.lbl_IDBT.Name = "lbl_IDBT";
            this.lbl_IDBT.Size = new System.Drawing.Size(102, 27);
            this.lbl_IDBT.TabIndex = 3;
            this.lbl_IDBT.Text = "ID Bài Tập";
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieude.Location = new System.Drawing.Point(3, 52);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(79, 27);
            this.lbl_tieude.TabIndex = 2;
            this.lbl_tieude.Text = "Tiêu đề";
            // 
            // txt_IDBT
            // 
            this.txt_IDBT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_IDBT.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDBT.Location = new System.Drawing.Point(245, 5);
            this.txt_IDBT.Name = "txt_IDBT";
            this.txt_IDBT.Size = new System.Drawing.Size(237, 34);
            this.txt_IDBT.TabIndex = 9;
            // 
            // txt_tieude
            // 
            this.txt_tieude.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_tieude.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tieude.Location = new System.Drawing.Point(245, 49);
            this.txt_tieude.Name = "txt_tieude";
            this.txt_tieude.Size = new System.Drawing.Size(237, 34);
            this.txt_tieude.TabIndex = 10;
            // 
            // lbl_hannop
            // 
            this.lbl_hannop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_hannop.AutoSize = true;
            this.lbl_hannop.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hannop.Location = new System.Drawing.Point(3, 96);
            this.lbl_hannop.Name = "lbl_hannop";
            this.lbl_hannop.Size = new System.Drawing.Size(90, 27);
            this.lbl_hannop.TabIndex = 7;
            this.lbl_hannop.Text = "Hạn nộp";
            // 
            // txt_link
            // 
            this.txt_link.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_link.BackColor = System.Drawing.SystemColors.Control;
            this.txt_link.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_link.Location = new System.Drawing.Point(245, 138);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(237, 34);
            this.txt_link.TabIndex = 1;
            // 
            // btn_upload
            // 
            this.btn_upload.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_upload.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(3, 135);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(208, 41);
            this.btn_upload.TabIndex = 0;
            this.btn_upload.Text = "Upload/Đường dẫn";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_quaylai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(856, 561);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(124, 52);
            this.btn_quaylai.TabIndex = 11;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click_1);
            // 
            // tblo_chinsua
            // 
            this.tblo_chinsua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblo_chinsua.ColumnCount = 3;
            this.tblo_chinsua.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblo_chinsua.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblo_chinsua.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblo_chinsua.Controls.Add(this.btn_xoabt, 2, 0);
            this.tblo_chinsua.Controls.Add(this.btn_taobaitap, 0, 0);
            this.tblo_chinsua.Controls.Add(this.btn_capnhatbt, 1, 0);
            this.tblo_chinsua.Location = new System.Drawing.Point(3, 557);
            this.tblo_chinsua.Name = "tblo_chinsua";
            this.tblo_chinsua.RowCount = 1;
            this.tblo_chinsua.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblo_chinsua.Size = new System.Drawing.Size(485, 56);
            this.tblo_chinsua.TabIndex = 17;
            // 
            // btn_xoabt
            // 
            this.btn_xoabt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xoabt.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.btn_xoabt.Location = new System.Drawing.Point(345, 3);
            this.btn_xoabt.Name = "btn_xoabt";
            this.btn_xoabt.Size = new System.Drawing.Size(117, 38);
            this.btn_xoabt.TabIndex = 16;
            this.btn_xoabt.Text = "Xóa";
            this.btn_xoabt.UseVisualStyleBackColor = true;
            this.btn_xoabt.Click += new System.EventHandler(this.btn_xoabt_Click);
            // 
            // btn_taobaitap
            // 
            this.btn_taobaitap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_taobaitap.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.btn_taobaitap.Location = new System.Drawing.Point(22, 3);
            this.btn_taobaitap.Name = "btn_taobaitap";
            this.btn_taobaitap.Size = new System.Drawing.Size(117, 38);
            this.btn_taobaitap.TabIndex = 14;
            this.btn_taobaitap.Text = "Tạo bài tập";
            this.btn_taobaitap.UseVisualStyleBackColor = true;
            this.btn_taobaitap.Click += new System.EventHandler(this.btn_taobaitap_Click);
            // 
            // btn_capnhatbt
            // 
            this.btn_capnhatbt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_capnhatbt.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.btn_capnhatbt.Location = new System.Drawing.Point(183, 3);
            this.btn_capnhatbt.Name = "btn_capnhatbt";
            this.btn_capnhatbt.Size = new System.Drawing.Size(117, 38);
            this.btn_capnhatbt.TabIndex = 15;
            this.btn_capnhatbt.Text = "Cập nhật";
            this.btn_capnhatbt.UseVisualStyleBackColor = true;
            this.btn_capnhatbt.Click += new System.EventHandler(this.btn_capnhatbt_Click);
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
            this.tblopn_quanly.ResumeLayout(false);
            this.tblopn_quanly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bainop)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tblopn_chitiet.ResumeLayout(false);
            this.tblopn_chitiet.PerformLayout();
            this.tblo_chinsua.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFD_savefile;
        private System.Windows.Forms.OpenFileDialog openFD_openfile;
        private System.Windows.Forms.Panel pn_content;
        private Panel pn_uploadfile;
        private TableLayoutPanel tblopn_quanly;
        private DataGridView dgv_baitap;
        private TextBox txt_chuong;
        private Label lbl_qlbainop;
        private Label lbl_qlbaitap;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cb_chonbt;
        private Label lbl_chonbt;
        private TableLayoutPanel tblopn_chitiet;
        private DateTimePicker dtp_hannop;
        private Label lbl_IDBT;
        private Label lbl_tieude;
        private TextBox txt_IDBT;
        private TextBox txt_tieude;
        private Label lbl_hannop;
        private Button btn_upload;
        private TextBox txt_link;
        private Button btn_quaylai;
        private TableLayoutPanel tblo_chinsua;
        private Button btn_xoabt;
        private Button btn_taobaitap;
        private Button btn_capnhatbt;
        private DataGridView dgv_bainop;
    }
}