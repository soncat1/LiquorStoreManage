﻿namespace QL_BanRuou.View
{
    partial class frmNuocSX
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txttennsx = new System.Windows.Forms.TextBox();
            this.txtmansx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthemnsx = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnsuansx = new DevExpress.XtraBars.BarButtonItem();
            this.btnxoansx = new DevExpress.XtraBars.BarButtonItem();
            this.btnluunsx = new DevExpress.XtraBars.BarButtonItem();
            this.btnhuynsx = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvds = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txttennsx);
            this.panelControl1.Controls.Add(this.txtmansx);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 32);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(459, 137);
            this.panelControl1.TabIndex = 8;
            // 
            // txttennsx
            // 
            this.txttennsx.Enabled = false;
            this.txttennsx.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennsx.Location = new System.Drawing.Point(218, 75);
            this.txttennsx.Name = "txttennsx";
            this.txttennsx.Size = new System.Drawing.Size(153, 21);
            this.txttennsx.TabIndex = 1;
            // 
            // txtmansx
            // 
            this.txtmansx.Enabled = false;
            this.txtmansx.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmansx.Location = new System.Drawing.Point(218, 31);
            this.txtmansx.Name = "txtmansx";
            this.txtmansx.Size = new System.Drawing.Size(153, 21);
            this.txtmansx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Nước SX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nước SX";
            // 
            // btnthemnsx
            // 
            this.btnthemnsx.Caption = "Thêm";
            this.btnthemnsx.Glyph = global::QL_BanRuou.Properties.Resources.Actions_list_add_user_icon;
            this.btnthemnsx.Id = 0;
            this.btnthemnsx.Name = "btnthemnsx";
            this.btnthemnsx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthemnsx_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnthemnsx, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnsuansx, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnxoansx, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnluunsx, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnhuynsx, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnsuansx
            // 
            this.btnsuansx.Caption = "Sửa";
            this.btnsuansx.Glyph = global::QL_BanRuou.Properties.Resources.edit_file_icon;
            this.btnsuansx.Id = 1;
            this.btnsuansx.Name = "btnsuansx";
            this.btnsuansx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsuansx_ItemClick);
            // 
            // btnxoansx
            // 
            this.btnxoansx.Caption = "Xóa";
            this.btnxoansx.Glyph = global::QL_BanRuou.Properties.Resources.Delete_icon1;
            this.btnxoansx.Id = 2;
            this.btnxoansx.Name = "btnxoansx";
            this.btnxoansx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoansx_ItemClick);
            // 
            // btnluunsx
            // 
            this.btnluunsx.Caption = "Lưu";
            this.btnluunsx.Enabled = false;
            this.btnluunsx.Glyph = global::QL_BanRuou.Properties.Resources.Save_icon;
            this.btnluunsx.Id = 3;
            this.btnluunsx.Name = "btnluunsx";
            this.btnluunsx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnluunsx_ItemClick);
            // 
            // btnhuynsx
            // 
            this.btnhuynsx.Caption = "Hủy bỏ";
            this.btnhuynsx.Enabled = false;
            this.btnhuynsx.Glyph = global::QL_BanRuou.Properties.Resources.Actions_dialog_cancel_icon;
            this.btnhuynsx.Id = 4;
            this.btnhuynsx.Name = "btnhuynsx";
            this.btnhuynsx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnhuynsx_ItemClick);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(459, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 406);
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
            this.btnthemnsx,
            this.btnsuansx,
            this.btnxoansx,
            this.btnluunsx,
            this.btnhuynsx});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(459, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 438);
            this.barDockControlBottom.Size = new System.Drawing.Size(459, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 406);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvds);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 169);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(459, 269);
            this.panelControl2.TabIndex = 14;
            // 
            // dgvds
            // 
            this.dgvds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvds.Location = new System.Drawing.Point(2, 2);
            this.dgvds.Name = "dgvds";
            this.dgvds.Size = new System.Drawing.Size(455, 265);
            this.dgvds.TabIndex = 0;
            // 
            // frmNuocSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 438);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNuocSX";
            this.Text = "Quản Lý Nước Sản Xuất";
            this.Load += new System.EventHandler(this.frmNuocSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txttennsx;
        private System.Windows.Forms.TextBox txtmansx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnthemnsx;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnsuansx;
        private DevExpress.XtraBars.BarButtonItem btnxoansx;
        private DevExpress.XtraBars.BarButtonItem btnluunsx;
        private DevExpress.XtraBars.BarButtonItem btnhuynsx;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView dgvds;
    }
}