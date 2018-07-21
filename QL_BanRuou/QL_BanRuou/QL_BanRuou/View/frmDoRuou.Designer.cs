namespace QL_BanRuou.View
{
    partial class frmDoRuou
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
            this.components = new System.ComponentModel.Container();
            this.btnthemdr = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnsuadr = new DevExpress.XtraBars.BarButtonItem();
            this.btnxoadr = new DevExpress.XtraBars.BarButtonItem();
            this.btnluudr = new DevExpress.XtraBars.BarButtonItem();
            this.btnhuydr = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txttendr = new System.Windows.Forms.TextBox();
            this.txtmadr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvds = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthemdr
            // 
            this.btnthemdr.Caption = "Thêm";
            this.btnthemdr.Glyph = global::QL_BanRuou.Properties.Resources.Actions_list_add_user_icon;
            this.btnthemdr.Id = 0;
            this.btnthemdr.Name = "btnthemdr";
            this.btnthemdr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthemdr_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnthemdr, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnsuadr, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnxoadr, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnluudr, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnhuydr, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnsuadr
            // 
            this.btnsuadr.Caption = "Sửa";
            this.btnsuadr.Glyph = global::QL_BanRuou.Properties.Resources.edit_file_icon;
            this.btnsuadr.Id = 1;
            this.btnsuadr.Name = "btnsuadr";
            this.btnsuadr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsuadr_ItemClick);
            // 
            // btnxoadr
            // 
            this.btnxoadr.Caption = "Xóa";
            this.btnxoadr.Glyph = global::QL_BanRuou.Properties.Resources.Delete_icon1;
            this.btnxoadr.Id = 2;
            this.btnxoadr.Name = "btnxoadr";
            this.btnxoadr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoadr_ItemClick);
            // 
            // btnluudr
            // 
            this.btnluudr.Caption = "Lưu";
            this.btnluudr.Enabled = false;
            this.btnluudr.Glyph = global::QL_BanRuou.Properties.Resources.Save_icon;
            this.btnluudr.Id = 3;
            this.btnluudr.Name = "btnluudr";
            this.btnluudr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnluudr_ItemClick);
            // 
            // btnhuydr
            // 
            this.btnhuydr.Caption = "Hủy bỏ";
            this.btnhuydr.Enabled = false;
            this.btnhuydr.Glyph = global::QL_BanRuou.Properties.Resources.Actions_dialog_cancel_icon;
            this.btnhuydr.Id = 4;
            this.btnhuydr.Name = "btnhuydr";
            this.btnhuydr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnhuydr_ItemClick);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(486, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 422);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnthemdr,
            this.btnsuadr,
            this.btnxoadr,
            this.btnluudr,
            this.btnhuydr});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(486, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 454);
            this.barDockControlBottom.Size = new System.Drawing.Size(486, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 422);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txttendr);
            this.panelControl1.Controls.Add(this.txtmadr);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 32);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(486, 160);
            this.panelControl1.TabIndex = 14;
            // 
            // txttendr
            // 
            this.txttendr.Enabled = false;
            this.txttendr.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttendr.Location = new System.Drawing.Point(230, 88);
            this.txttendr.Name = "txttendr";
            this.txttendr.Size = new System.Drawing.Size(153, 21);
            this.txttendr.TabIndex = 4;
            // 
            // txtmadr
            // 
            this.txtmadr.Enabled = false;
            this.txtmadr.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmadr.Location = new System.Drawing.Point(230, 44);
            this.txtmadr.Name = "txtmadr";
            this.txtmadr.Size = new System.Drawing.Size(153, 21);
            this.txtmadr.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Độ Rượu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Độ Rượu";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvds);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 192);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(486, 262);
            this.panelControl2.TabIndex = 15;
            // 
            // dgvds
            // 
            this.dgvds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvds.Location = new System.Drawing.Point(2, 2);
            this.dgvds.Name = "dgvds";
            this.dgvds.Size = new System.Drawing.Size(482, 258);
            this.dgvds.TabIndex = 0;
            // 
            // frmDoRuou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 454);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDoRuou";
            this.Text = "Quản Lý Nồng Độ Rượu";
            this.Load += new System.EventHandler(this.frmDoRuou_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem btnthemdr;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnsuadr;
        private DevExpress.XtraBars.BarButtonItem btnxoadr;
        private DevExpress.XtraBars.BarButtonItem btnluudr;
        private DevExpress.XtraBars.BarButtonItem btnhuydr;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txttendr;
        private System.Windows.Forms.TextBox txtmadr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView dgvds;
    }
}