namespace DangKyHocPhanSV
{
    partial class FrmTKSoLgSVNganh
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pn_header = new System.Windows.Forms.Panel();
            this.btn_pre = new System.Windows.Forms.Button();
            this.lbl_header = new System.Windows.Forms.Label();
            this.chartTkNganh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pn_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTkNganh)).BeginInit();
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
            this.pn_header.Size = new System.Drawing.Size(1099, 63);
            this.pn_header.TabIndex = 6;
            // 
            // btn_pre
            // 
            this.btn_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_pre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_pre.Location = new System.Drawing.Point(917, 14);
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
            this.lbl_header.Location = new System.Drawing.Point(188, 8);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(644, 40);
            this.lbl_header.TabIndex = 3;
            this.lbl_header.Text = "THỐNG KÊ SỐ LƯỢNG SINH VIÊN MỖI NGÀNH";
            // 
            // chartTkNganh
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTkNganh.ChartAreas.Add(chartArea1);
            this.chartTkNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartTkNganh.Legends.Add(legend1);
            this.chartTkNganh.Location = new System.Drawing.Point(0, 63);
            this.chartTkNganh.Name = "chartTkNganh";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTkNganh.Series.Add(series1);
            this.chartTkNganh.Size = new System.Drawing.Size(1099, 611);
            this.chartTkNganh.TabIndex = 7;
            this.chartTkNganh.Text = "chart1";
            // 
            // FrmTKSoLgSVNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 674);
            this.Controls.Add(this.chartTkNganh);
            this.Controls.Add(this.pn_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTKSoLgSVNganh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTKSoLgSVNganh";
            this.Load += new System.EventHandler(this.FrmTKSoLgSVNganh_Load);
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTkNganh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTkNganh;
    }
}