﻿namespace QL_BanRuou.View
{
    partial class frmThemHDN
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
            this.nmrgiamgia = new System.Windows.Forms.NumericUpDown();
            this.nmrsoluong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtimengaynhap = new System.Windows.Forms.DateTimePicker();
            this.cbotenh = new System.Windows.Forms.ComboBox();
            this.cboncc = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvChiTietHDN = new System.Windows.Forms.DataGridView();
            this.colMAH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDGNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGIAMGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTHANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtnv = new System.Windows.Forms.TextBox();
            this.txtmahdn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrgiamgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrsoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nmrgiamgia
            // 
            this.nmrgiamgia.Location = new System.Drawing.Point(516, 251);
            this.nmrgiamgia.Name = "nmrgiamgia";
            this.nmrgiamgia.Size = new System.Drawing.Size(120, 21);
            this.nmrgiamgia.TabIndex = 139;
            this.nmrgiamgia.Click += new System.EventHandler(this.nmrgiamgia_Click);
            // 
            // nmrsoluong
            // 
            this.nmrsoluong.Location = new System.Drawing.Point(130, 247);
            this.nmrsoluong.Name = "nmrsoluong";
            this.nmrsoluong.Size = new System.Drawing.Size(120, 21);
            this.nmrsoluong.TabIndex = 138;
            this.nmrsoluong.Click += new System.EventHandler(this.nmrsoluong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Image = global::QL_BanRuou.Properties.Resources.Actions_view_calendar_list_icon;
            this.btnThem.Location = new System.Drawing.Point(849, 77);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 55);
            this.btnThem.TabIndex = 137;
            this.btnThem.Text = "Thêm Vào Hoá Đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtimengaynhap
            // 
            this.dtimengaynhap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimengaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimengaynhap.Location = new System.Drawing.Point(147, 92);
            this.dtimengaynhap.Name = "dtimengaynhap";
            this.dtimengaynhap.Size = new System.Drawing.Size(141, 21);
            this.dtimengaynhap.TabIndex = 136;
            // 
            // cbotenh
            // 
            this.cbotenh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotenh.FormattingEnabled = true;
            this.cbotenh.Location = new System.Drawing.Point(130, 186);
            this.cbotenh.Name = "cbotenh";
            this.cbotenh.Size = new System.Drawing.Size(254, 23);
            this.cbotenh.TabIndex = 135;
            this.cbotenh.SelectedValueChanged += new System.EventHandler(this.cbotenh_SelectedValueChanged);
            this.cbotenh.Click += new System.EventHandler(this.cbotenh_Click);
            // 
            // cboncc
            // 
            this.cboncc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboncc.FormattingEnabled = true;
            this.cboncc.Location = new System.Drawing.Point(649, 56);
            this.cboncc.Name = "cboncc";
            this.cboncc.Size = new System.Drawing.Size(141, 23);
            this.cboncc.TabIndex = 134;
            this.cboncc.SelectedValueChanged += new System.EventHandler(this.cboncc_SelectedValueChanged);
            this.cboncc.Click += new System.EventHandler(this.cboncc_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Red;
            this.btnLuu.Location = new System.Drawing.Point(39, 165);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(276, 52);
            this.btnLuu.TabIndex = 120;
            this.btnLuu.Text = "Lưu Hoá Đơn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvChiTietHDN
            // 
            this.dgvChiTietHDN.AllowUserToAddRows = false;
            this.dgvChiTietHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHDN.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMAH,
            this.colTENH,
            this.colSOLUONG,
            this.colDGNHAP,
            this.colGIAMGIA,
            this.colTHANHTIEN});
            this.dgvChiTietHDN.GridColor = System.Drawing.Color.White;
            this.dgvChiTietHDN.Location = new System.Drawing.Point(0, 15);
            this.dgvChiTietHDN.MultiSelect = false;
            this.dgvChiTietHDN.Name = "dgvChiTietHDN";
            this.dgvChiTietHDN.ReadOnly = true;
            this.dgvChiTietHDN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHDN.Size = new System.Drawing.Size(1003, 144);
            this.dgvChiTietHDN.TabIndex = 119;
            this.dgvChiTietHDN.DoubleClick += new System.EventHandler(this.dgvChiTietHDN_DoubleClick);
            // 
            // colMAH
            // 
            this.colMAH.HeaderText = "Mã hàng";
            this.colMAH.Name = "colMAH";
            this.colMAH.ReadOnly = true;
            // 
            // colTENH
            // 
            this.colTENH.HeaderText = "Tên hàng";
            this.colTENH.Name = "colTENH";
            this.colTENH.ReadOnly = true;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.HeaderText = "Số lượng";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.ReadOnly = true;
            // 
            // colDGNHAP
            // 
            this.colDGNHAP.HeaderText = "Đơn giá nhập";
            this.colDGNHAP.Name = "colDGNHAP";
            this.colDGNHAP.ReadOnly = true;
            // 
            // colGIAMGIA
            // 
            this.colGIAMGIA.HeaderText = "Giảm giá";
            this.colGIAMGIA.Name = "colGIAMGIA";
            this.colGIAMGIA.ReadOnly = true;
            // 
            // colTHANHTIEN
            // 
            this.colTHANHTIEN.HeaderText = "Thành tiền";
            this.colTHANHTIEN.Name = "colTHANHTIEN";
            this.colTHANHTIEN.ReadOnly = true;
            // 
            // txtdongia
            // 
            this.txtdongia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdongia.Location = new System.Drawing.Point(516, 186);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(141, 21);
            this.txtdongia.TabIndex = 132;
            // 
            // txtdt
            // 
            this.txtdt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdt.Location = new System.Drawing.Point(649, 130);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(141, 21);
            this.txtdt.TabIndex = 131;
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthanhtien.Location = new System.Drawing.Point(783, 186);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(141, 21);
            this.txtthanhtien.TabIndex = 129;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QL_BanRuou.Properties.Resources.Actions_dialog_cancel_icon;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThoat.Location = new System.Drawing.Point(763, 165);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 52);
            this.btnThoat.TabIndex = 139;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtdc
            // 
            this.txtdc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdc.Location = new System.Drawing.Point(649, 94);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(141, 21);
            this.txtdc.TabIndex = 130;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnHuy);
            this.panelControl2.Controls.Add(this.btnThoat);
            this.panelControl2.Controls.Add(this.btnLuu);
            this.panelControl2.Controls.Add(this.dgvChiTietHDN);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 329);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1005, 237);
            this.panelControl2.TabIndex = 4;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::QL_BanRuou.Properties.Resources.Delete_icon;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHuy.Location = new System.Drawing.Point(626, 165);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 52);
            this.btnHuy.TabIndex = 140;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtnv
            // 
            this.txtnv.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnv.Location = new System.Drawing.Point(147, 128);
            this.txtnv.Name = "txtnv";
            this.txtnv.Size = new System.Drawing.Size(141, 21);
            this.txtnv.TabIndex = 128;
            // 
            // txtmahdn
            // 
            this.txtmahdn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahdn.Location = new System.Drawing.Point(147, 54);
            this.txtmahdn.Name = "txtmahdn";
            this.txtmahdn.Size = new System.Drawing.Size(141, 21);
            this.txtmahdn.TabIndex = 127;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(436, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 126;
            this.label11.Text = "Giảm giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(693, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 125;
            this.label10.Text = "Thành tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(436, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 124;
            this.label9.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 123;
            this.label8.Text = "Tên hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 122;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 121;
            this.label6.Text = "Ngày nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 120;
            this.label5.Text = "NV bán hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 119;
            this.label4.Text = "Tên nhà CC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 118;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 117;
            this.label2.Text = "Số ĐT";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.nmrgiamgia);
            this.panelControl1.Controls.Add(this.nmrsoluong);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.dtimengaynhap);
            this.panelControl1.Controls.Add(this.cbotenh);
            this.panelControl1.Controls.Add(this.cboncc);
            this.panelControl1.Controls.Add(this.txtdongia);
            this.panelControl1.Controls.Add(this.txtdt);
            this.panelControl1.Controls.Add(this.txtdc);
            this.panelControl1.Controls.Add(this.txtthanhtien);
            this.panelControl1.Controls.Add(this.txtnv);
            this.panelControl1.Controls.Add(this.txtmahdn);
            this.panelControl1.Controls.Add(this.label11);
            this.panelControl1.Controls.Add(this.label10);
            this.panelControl1.Controls.Add(this.label9);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.lbl1);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1005, 329);
            this.panelControl1.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(44, 56);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(83, 19);
            this.lbl1.TabIndex = 116;
            this.lbl1.Text = "Mã hoá đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM HOÁ ĐƠN NHẬP";
            // 
            // frmThemHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 566);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmThemHDN";
            this.Text = "ThemHDN";
            this.Load += new System.EventHandler(this.frmThemHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrgiamgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrsoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrgiamgia;
        private System.Windows.Forms.NumericUpDown nmrsoluong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtimengaynhap;
        private System.Windows.Forms.ComboBox cbotenh;
        private System.Windows.Forms.ComboBox cboncc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvChiTietHDN;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtdc;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtnv;
        private System.Windows.Forms.TextBox txtmahdn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMAH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDGNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGIAMGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTHANHTIEN;
    }
}