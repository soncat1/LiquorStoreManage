namespace QL_BanRuou.View
{
    partial class ucHoaDonBan
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
            this.components = new System.ComponentModel.Container();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cboMAHDB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChiTietHDB = new System.Windows.Forms.DataGridView();
            this.colMaHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMAH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDGBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGIAMGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTHANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lblMAHDB = new System.Windows.Forms.Label();
            this.lblNGAYBAN = new System.Windows.Forms.Label();
            this.lblTONGSOLUONG = new System.Windows.Forms.Label();
            this.lblTONGTIEN = new System.Windows.Forms.Label();
            this.lblMANV = new System.Windows.Forms.Label();
            this.lblTENNV = new System.Windows.Forms.Label();
            this.lblMAKH = new System.Windows.Forms.Label();
            this.lblTENKH = new System.Windows.Forms.Label();
            this.lblDIACHI = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemThêm = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemIn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItemSua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLưu = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemThoat = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cboMAHDB);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.dgvChiTietHDB);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 238);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1007, 170);
            this.panelControl2.TabIndex = 10;
            // 
            // cboMAHDB
            // 
            this.cboMAHDB.FormattingEnabled = true;
            this.cboMAHDB.Location = new System.Drawing.Point(104, 5);
            this.cboMAHDB.Name = "cboMAHDB";
            this.cboMAHDB.Size = new System.Drawing.Size(121, 21);
            this.cboMAHDB.TabIndex = 120;
            this.cboMAHDB.SelectedIndexChanged += new System.EventHandler(this.cboMAHDB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 119;
            this.label1.Text = "Tìm kiếm ";
            // 
            // dgvChiTietHDB
            // 
            this.dgvChiTietHDB.AllowUserToAddRows = false;
            this.dgvChiTietHDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHDB.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHDB,
            this.colMAH,
            this.colTENH,
            this.colSOLUONG,
            this.colDGBAN,
            this.colGIAMGIA,
            this.colTHANHTIEN});
            this.dgvChiTietHDB.GridColor = System.Drawing.Color.White;
            this.dgvChiTietHDB.Location = new System.Drawing.Point(5, 32);
            this.dgvChiTietHDB.MultiSelect = false;
            this.dgvChiTietHDB.Name = "dgvChiTietHDB";
            this.dgvChiTietHDB.ReadOnly = true;
            this.dgvChiTietHDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHDB.Size = new System.Drawing.Size(1002, 133);
            this.dgvChiTietHDB.TabIndex = 118;
            // 
            // colMaHDB
            // 
            this.colMaHDB.HeaderText = "Mã hoá đơn";
            this.colMaHDB.Name = "colMaHDB";
            this.colMaHDB.ReadOnly = true;
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
            // colDGBAN
            // 
            this.colDGBAN.HeaderText = "Đơn giá bán";
            this.colDGBAN.Name = "colDGBAN";
            this.colDGBAN.ReadOnly = true;
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
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(33, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(83, 19);
            this.lbl1.TabIndex = 115;
            this.lbl1.Text = "Mã hoá đơn";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(33, 64);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(68, 19);
            this.lbl2.TabIndex = 116;
            this.lbl2.Text = "Ngày bán";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(333, 19);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(90, 19);
            this.lbl5.TabIndex = 117;
            this.lbl5.Text = "Mã nhân viên";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(333, 64);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(92, 19);
            this.lbl6.TabIndex = 118;
            this.lbl6.Text = "Tên nhân viên";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(33, 106);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(96, 19);
            this.lbl3.TabIndex = 119;
            this.lbl3.Text = "Tổng số lượng";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(33, 151);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(65, 19);
            this.lbl4.TabIndex = 120;
            this.lbl4.Text = "Tổng tiền";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.Location = new System.Drawing.Point(616, 151);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(70, 19);
            this.lbl10.TabIndex = 122;
            this.lbl10.Text = "Điện thoại";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(616, 19);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(102, 19);
            this.lbl7.TabIndex = 124;
            this.lbl7.Text = "Mã khách hàng";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(616, 64);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(104, 19);
            this.lbl8.TabIndex = 125;
            this.lbl8.Text = "Tên khách hàng";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.Location = new System.Drawing.Point(616, 106);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(51, 19);
            this.lbl9.TabIndex = 126;
            this.lbl9.Text = "Địa chỉ";
            // 
            // lblMAHDB
            // 
            this.lblMAHDB.AutoSize = true;
            this.lblMAHDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAHDB.Location = new System.Drawing.Point(151, 19);
            this.lblMAHDB.Name = "lblMAHDB";
            this.lblMAHDB.Size = new System.Drawing.Size(65, 19);
            this.lblMAHDB.TabIndex = 127;
            this.lblMAHDB.Text = "Thông tin";
            // 
            // lblNGAYBAN
            // 
            this.lblNGAYBAN.AutoSize = true;
            this.lblNGAYBAN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNGAYBAN.Location = new System.Drawing.Point(151, 64);
            this.lblNGAYBAN.Name = "lblNGAYBAN";
            this.lblNGAYBAN.Size = new System.Drawing.Size(65, 19);
            this.lblNGAYBAN.TabIndex = 128;
            this.lblNGAYBAN.Text = "Thông tin";
            // 
            // lblTONGSOLUONG
            // 
            this.lblTONGSOLUONG.AutoSize = true;
            this.lblTONGSOLUONG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTONGSOLUONG.Location = new System.Drawing.Point(151, 106);
            this.lblTONGSOLUONG.Name = "lblTONGSOLUONG";
            this.lblTONGSOLUONG.Size = new System.Drawing.Size(65, 19);
            this.lblTONGSOLUONG.TabIndex = 129;
            this.lblTONGSOLUONG.Text = "Thông tin";
            // 
            // lblTONGTIEN
            // 
            this.lblTONGTIEN.AutoSize = true;
            this.lblTONGTIEN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTONGTIEN.Location = new System.Drawing.Point(151, 151);
            this.lblTONGTIEN.Name = "lblTONGTIEN";
            this.lblTONGTIEN.Size = new System.Drawing.Size(65, 19);
            this.lblTONGTIEN.TabIndex = 130;
            this.lblTONGTIEN.Text = "Thông tin";
            // 
            // lblMANV
            // 
            this.lblMANV.AutoSize = true;
            this.lblMANV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMANV.Location = new System.Drawing.Point(442, 19);
            this.lblMANV.Name = "lblMANV";
            this.lblMANV.Size = new System.Drawing.Size(65, 19);
            this.lblMANV.TabIndex = 131;
            this.lblMANV.Text = "Thông tin";
            // 
            // lblTENNV
            // 
            this.lblTENNV.AutoSize = true;
            this.lblTENNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTENNV.Location = new System.Drawing.Point(442, 64);
            this.lblTENNV.Name = "lblTENNV";
            this.lblTENNV.Size = new System.Drawing.Size(65, 19);
            this.lblTENNV.TabIndex = 132;
            this.lblTENNV.Text = "Thông tin";
            // 
            // lblMAKH
            // 
            this.lblMAKH.AutoSize = true;
            this.lblMAKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAKH.Location = new System.Drawing.Point(734, 19);
            this.lblMAKH.Name = "lblMAKH";
            this.lblMAKH.Size = new System.Drawing.Size(65, 19);
            this.lblMAKH.TabIndex = 133;
            this.lblMAKH.Text = "Thông tin";
            // 
            // lblTENKH
            // 
            this.lblTENKH.AutoSize = true;
            this.lblTENKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTENKH.Location = new System.Drawing.Point(734, 64);
            this.lblTENKH.Name = "lblTENKH";
            this.lblTENKH.Size = new System.Drawing.Size(65, 19);
            this.lblTENKH.TabIndex = 134;
            this.lblTENKH.Text = "Thông tin";
            // 
            // lblDIACHI
            // 
            this.lblDIACHI.AutoSize = true;
            this.lblDIACHI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDIACHI.Location = new System.Drawing.Point(734, 106);
            this.lblDIACHI.Name = "lblDIACHI";
            this.lblDIACHI.Size = new System.Drawing.Size(65, 19);
            this.lblDIACHI.TabIndex = 135;
            this.lblDIACHI.Text = "Thông tin";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(734, 151);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(65, 19);
            this.lblSDT.TabIndex = 136;
            this.lblSDT.Text = "Thông tin";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblSDT);
            this.panelControl1.Controls.Add(this.lblDIACHI);
            this.panelControl1.Controls.Add(this.lblTENKH);
            this.panelControl1.Controls.Add(this.lblMAKH);
            this.panelControl1.Controls.Add(this.lblTENNV);
            this.panelControl1.Controls.Add(this.lblMANV);
            this.panelControl1.Controls.Add(this.lblTONGTIEN);
            this.panelControl1.Controls.Add(this.lblTONGSOLUONG);
            this.panelControl1.Controls.Add(this.lblNGAYBAN);
            this.panelControl1.Controls.Add(this.lblMAHDB);
            this.panelControl1.Controls.Add(this.lbl9);
            this.panelControl1.Controls.Add(this.lbl8);
            this.panelControl1.Controls.Add(this.lbl7);
            this.panelControl1.Controls.Add(this.lbl10);
            this.panelControl1.Controls.Add(this.lbl4);
            this.panelControl1.Controls.Add(this.lbl3);
            this.panelControl1.Controls.Add(this.lbl6);
            this.panelControl1.Controls.Add(this.lbl5);
            this.panelControl1.Controls.Add(this.lbl2);
            this.panelControl1.Controls.Add(this.lbl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 39);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1007, 199);
            this.panelControl1.TabIndex = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemThêm,
            this.barButtonItemSua,
            this.barButtonItemXoa,
            this.barButtonItemLưu,
            this.barButtonItemThoat,
            this.barButtonItemIn});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(150, 104);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemThêm, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 13;
            this.bar1.Text = "Tools";
            // 
            // barButtonItemThêm
            // 
            this.barButtonItemThêm.Caption = "Thêm";
            this.barButtonItemThêm.Glyph = global::QL_BanRuou.Properties.Resources.Actions_list_add_user_icon;
            this.barButtonItemThêm.Id = 0;
            this.barButtonItemThêm.Name = "barButtonItemThêm";
            this.barButtonItemThêm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemThêm_ItemClick);
            // 
            // barButtonItemXoa
            // 
            this.barButtonItemXoa.Caption = "Xoá";
            this.barButtonItemXoa.Glyph = global::QL_BanRuou.Properties.Resources.Delete_icon;
            this.barButtonItemXoa.Id = 2;
            this.barButtonItemXoa.Name = "barButtonItemXoa";
            this.barButtonItemXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemXoa_ItemClick);
            // 
            // barButtonItemIn
            // 
            this.barButtonItemIn.Caption = "In file Excel";
            this.barButtonItemIn.Glyph = global::QL_BanRuou.Properties.Resources.printer_icon;
            this.barButtonItemIn.Id = 5;
            this.barButtonItemIn.Name = "barButtonItemIn";
            this.barButtonItemIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemIn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1007, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Size = new System.Drawing.Size(1007, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 369);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1007, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 369);
            // 
            // barButtonItemSua
            // 
            this.barButtonItemSua.Caption = "Sửa";
            this.barButtonItemSua.Glyph = global::QL_BanRuou.Properties.Resources.edit_file_icon;
            this.barButtonItemSua.Id = 1;
            this.barButtonItemSua.Name = "barButtonItemSua";
            // 
            // barButtonItemLưu
            // 
            this.barButtonItemLưu.Caption = "Lưu";
            this.barButtonItemLưu.Glyph = global::QL_BanRuou.Properties.Resources.Save_icon;
            this.barButtonItemLưu.Id = 3;
            this.barButtonItemLưu.Name = "barButtonItemLưu";
            // 
            // barButtonItemThoat
            // 
            this.barButtonItemThoat.Caption = "Thoát";
            this.barButtonItemThoat.Glyph = global::QL_BanRuou.Properties.Resources.Actions_dialog_cancel_icon;
            this.barButtonItemThoat.Id = 4;
            this.barButtonItemThoat.Name = "barButtonItemThoat";
            // 
            // ucHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucHoaDonBan";
            this.Size = new System.Drawing.Size(1007, 408);
            this.Load += new System.EventHandler(this.ucHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTietHDB;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lblMAHDB;
        private System.Windows.Forms.Label lblNGAYBAN;
        private System.Windows.Forms.Label lblTONGSOLUONG;
        private System.Windows.Forms.Label lblTONGTIEN;
        private System.Windows.Forms.Label lblMANV;
        private System.Windows.Forms.Label lblTENNV;
        private System.Windows.Forms.Label lblMAKH;
        private System.Windows.Forms.Label lblTENKH;
        private System.Windows.Forms.Label lblDIACHI;
        private System.Windows.Forms.Label lblSDT;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemThêm;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSua;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemXoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLưu;
        private DevExpress.XtraBars.BarButtonItem barButtonItemThoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItemIn;
        public DevExpress.XtraEditors.PanelControl panelControl2;
        public DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cboMAHDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMAH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDGBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGIAMGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTHANHTIEN;

    }
}
