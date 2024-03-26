namespace DangKyHocPhanSV
{
    partial class FrmTKSoLgTCSVDK
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
            this.chartTkTinChi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pn_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTkTinChi)).BeginInit();
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
            this.pn_header.Size = new System.Drawing.Size(1096, 63);
            this.pn_header.TabIndex = 8;
            // 
            // btn_pre
            // 
            this.btn_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_pre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_pre.Location = new System.Drawing.Point(903, 14);
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
            this.lbl_header.Size = new System.Drawing.Size(681, 40);
            this.lbl_header.TabIndex = 3;
            this.lbl_header.Text = "THỐNG KÊ TỔNG SỐ TÍN CHỈ SINH VIÊN ĐĂNG KÝ";
            // 
            // chartTkTinChi
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTkTinChi.ChartAreas.Add(chartArea2);
            this.chartTkTinChi.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartTkTinChi.Legends.Add(legend2);
            this.chartTkTinChi.Location = new System.Drawing.Point(0, 63);
            this.chartTkTinChi.Name = "chartTkTinChi";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTkTinChi.Series.Add(series2);
            this.chartTkTinChi.Size = new System.Drawing.Size(1096, 668);
            this.chartTkTinChi.TabIndex = 9;
            this.chartTkTinChi.Text = "chart1";
            // 
            // FrmTKSoLgTCSVDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 731);
            this.Controls.Add(this.chartTkTinChi);
            this.Controls.Add(this.pn_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTKSoLgTCSVDK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTKSoLgTCSVDK";
            this.Load += new System.EventHandler(this.FrmTKSoLgTCSVDK_Load);
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTkTinChi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTkTinChi;
    }
}