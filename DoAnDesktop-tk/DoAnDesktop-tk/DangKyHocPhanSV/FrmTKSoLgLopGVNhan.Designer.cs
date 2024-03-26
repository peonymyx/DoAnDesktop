namespace DangKyHocPhanSV
{
    partial class FrmTKSoLgLopGVNhan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pn_header = new System.Windows.Forms.Panel();
            this.btn_pre = new System.Windows.Forms.Button();
            this.lbl_header = new System.Windows.Forms.Label();
            this.chartTkGVNhan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pn_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTkGVNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_header
            // 
            this.pn_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.pn_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_header.Controls.Add(this.btn_pre);
            this.pn_header.Controls.Add(this.lbl_header);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(1136, 63);
            this.pn_header.TabIndex = 9;
            // 
            // btn_pre
            // 
            this.btn_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_pre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_pre.Location = new System.Drawing.Point(957, 10);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(128, 44);
            this.btn_pre.TabIndex = 4;
            this.btn_pre.Text = "Quay về";
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_header.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_header.Location = new System.Drawing.Point(147, 14);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(701, 40);
            this.lbl_header.TabIndex = 3;
            this.lbl_header.Text = "THỐNG KÊ SỐ LƯỢNG LỚP GIẢNG VIÊN ĐANG DẠY";
            // 
            // chartTkGVNhan
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTkGVNhan.ChartAreas.Add(chartArea2);
            this.chartTkGVNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartTkGVNhan.Legends.Add(legend2);
            this.chartTkGVNhan.Location = new System.Drawing.Point(0, 63);
            this.chartTkGVNhan.Name = "chartTkGVNhan";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTkGVNhan.Series.Add(series2);
            this.chartTkGVNhan.Size = new System.Drawing.Size(1136, 595);
            this.chartTkGVNhan.TabIndex = 10;
            this.chartTkGVNhan.Text = "chart1";
            // 
            // FrmTKSoLgLopGVNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 658);
            this.Controls.Add(this.chartTkGVNhan);
            this.Controls.Add(this.pn_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTKSoLgLopGVNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTKSoLgLopGVNhan";
            this.Load += new System.EventHandler(this.FrmTKSoLgLopGVNhan_Load);
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTkGVNhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTkGVNhan;
    }
}