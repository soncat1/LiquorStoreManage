namespace QL_BanRuou.View
{
    partial class ucChart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rdoQuy = new System.Windows.Forms.RadioButton();
            this.rdoThang = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbquy = new System.Windows.Forms.ComboBox();
            this.cmbthang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbnam = new System.Windows.Forms.ComboBox();
            this.btnLamLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 193);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "doanh thu hàng";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(909, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // rdoQuy
            // 
            this.rdoQuy.AutoSize = true;
            this.rdoQuy.Location = new System.Drawing.Point(30, 96);
            this.rdoQuy.Name = "rdoQuy";
            this.rdoQuy.Size = new System.Drawing.Size(44, 17);
            this.rdoQuy.TabIndex = 1;
            this.rdoQuy.TabStop = true;
            this.rdoQuy.Text = "Quý";
            this.rdoQuy.UseVisualStyleBackColor = true;
            this.rdoQuy.Click += new System.EventHandler(this.rdoQuy_Click);
            // 
            // rdoThang
            // 
            this.rdoThang.AutoSize = true;
            this.rdoThang.Location = new System.Drawing.Point(342, 99);
            this.rdoThang.Name = "rdoThang";
            this.rdoThang.Size = new System.Drawing.Size(56, 17);
            this.rdoThang.TabIndex = 1;
            this.rdoThang.TabStop = true;
            this.rdoThang.Text = "Tháng";
            this.rdoThang.UseVisualStyleBackColor = true;
            this.rdoThang.Click += new System.EventHandler(this.rdoThang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(280, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Biểu Đồ Tăng Trưởng";
            // 
            // cmbquy
            // 
            this.cmbquy.FormattingEnabled = true;
            this.cmbquy.Location = new System.Drawing.Point(144, 95);
            this.cmbquy.Name = "cmbquy";
            this.cmbquy.Size = new System.Drawing.Size(121, 21);
            this.cmbquy.TabIndex = 3;
            this.cmbquy.SelectedIndexChanged += new System.EventHandler(this.cmbquy_SelectedIndexChanged);
            // 
            // cmbthang
            // 
            this.cmbthang.FormattingEnabled = true;
            this.cmbthang.Location = new System.Drawing.Point(454, 96);
            this.cmbthang.Name = "cmbthang";
            this.cmbthang.Size = new System.Drawing.Size(121, 21);
            this.cmbthang.TabIndex = 4;
            this.cmbthang.SelectedIndexChanged += new System.EventHandler(this.cmbthang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm";
            // 
            // cmbnam
            // 
            this.cmbnam.FormattingEnabled = true;
            this.cmbnam.Location = new System.Drawing.Point(674, 95);
            this.cmbnam.Name = "cmbnam";
            this.cmbnam.Size = new System.Drawing.Size(121, 21);
            this.cmbnam.TabIndex = 6;
            this.cmbnam.SelectedIndexChanged += new System.EventHandler(this.cmbnam_SelectedIndexChanged);
            this.cmbnam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbnam_MouseClick);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(218, 145);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 7;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(472, 145);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ucChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.cmbnam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbthang);
            this.Controls.Add(this.cmbquy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoThang);
            this.Controls.Add(this.rdoQuy);
            this.Controls.Add(this.chart1);
            this.Name = "ucChart";
            this.Size = new System.Drawing.Size(909, 493);
            this.Load += new System.EventHandler(this.ucChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton rdoQuy;
        private System.Windows.Forms.RadioButton rdoThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbquy;
        private System.Windows.Forms.ComboBox cmbthang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbnam;
        private DevExpress.XtraEditors.SimpleButton btnLamLai;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}
