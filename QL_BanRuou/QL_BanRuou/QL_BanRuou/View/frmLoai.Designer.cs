namespace QL_BanRuou.View
{
    partial class frmLoai
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
            this.txttenl = new System.Windows.Forms.TextBox();
            this.txtmal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btntheml = new DevExpress.XtraBars.BarButtonItem();
            this.btnsual = new DevExpress.XtraBars.BarButtonItem();
            this.btnxoal = new DevExpress.XtraBars.BarButtonItem();
            this.btnluul = new DevExpress.XtraBars.BarButtonItem();
            this.btnhuyl = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
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
            this.panelControl1.Controls.Add(this.txttenl);
            this.panelControl1.Controls.Add(this.txtmal);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 32);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(445, 122);
            this.panelControl1.TabIndex = 0;
            // 
            // txttenl
            // 
            this.txttenl.Enabled = false;
            this.txttenl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenl.Location = new System.Drawing.Point(189, 65);
            this.txttenl.Name = "txttenl";
            this.txttenl.Size = new System.Drawing.Size(153, 21);
            this.txttenl.TabIndex = 1;
            // 
            // txtmal
            // 
            this.txtmal.Enabled = false;
            this.txtmal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmal.Location = new System.Drawing.Point(189, 22);
            this.txtmal.Name = "txtmal";
            this.txtmal.Size = new System.Drawing.Size(153, 21);
            this.txtmal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại";
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
            this.btntheml,
            this.btnsual,
            this.btnxoal,
            this.btnluul,
            this.btnhuyl});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btntheml, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnsual, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnxoal, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnluul, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnhuyl, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btntheml
            // 
            this.btntheml.Caption = "Thêm";
            this.btntheml.Glyph = global::QL_BanRuou.Properties.Resources.Actions_list_add_user_icon;
            this.btntheml.Id = 0;
            this.btntheml.Name = "btntheml";
            this.btntheml.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btntheml_ItemClick);
            // 
            // btnsual
            // 
            this.btnsual.Caption = "Sửa";
            this.btnsual.Glyph = global::QL_BanRuou.Properties.Resources.edit_file_icon;
            this.btnsual.Id = 1;
            this.btnsual.Name = "btnsual";
            this.btnsual.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsual_ItemClick);
            // 
            // btnxoal
            // 
            this.btnxoal.Caption = "Xóa";
            this.btnxoal.Glyph = global::QL_BanRuou.Properties.Resources.Delete_icon1;
            this.btnxoal.Id = 2;
            this.btnxoal.Name = "btnxoal";
            this.btnxoal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoal_ItemClick);
            // 
            // btnluul
            // 
            this.btnluul.Caption = "Lưu";
            this.btnluul.Enabled = false;
            this.btnluul.Glyph = global::QL_BanRuou.Properties.Resources.Save_icon;
            this.btnluul.Id = 3;
            this.btnluul.Name = "btnluul";
            this.btnluul.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnluul_ItemClick);
            // 
            // btnhuyl
            // 
            this.btnhuyl.Caption = "Hủy bỏ";
            this.btnhuyl.Enabled = false;
            this.btnhuyl.Glyph = global::QL_BanRuou.Properties.Resources.Actions_dialog_cancel_icon;
            this.btnhuyl.Id = 4;
            this.btnhuyl.Name = "btnhuyl";
            this.btnhuyl.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnhuycl_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(445, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 436);
            this.barDockControlBottom.Size = new System.Drawing.Size(445, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 404);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(445, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 404);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvds);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 154);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(445, 282);
            this.panelControl2.TabIndex = 5;
            // 
            // dgvds
            // 
            this.dgvds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvds.Location = new System.Drawing.Point(2, 2);
            this.dgvds.Name = "dgvds";
            this.dgvds.Size = new System.Drawing.Size(441, 278);
            this.dgvds.TabIndex = 0;
            // 
            // frmLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 436);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmLoai";
            this.Text = "Quản Lý Loại ";
            this.Load += new System.EventHandler(this.frmLoai_Load);
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
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btntheml;
        private DevExpress.XtraBars.BarButtonItem btnsual;
        private DevExpress.XtraBars.BarButtonItem btnxoal;
        private DevExpress.XtraBars.BarButtonItem btnluul;
        private DevExpress.XtraBars.BarButtonItem btnhuyl;
        private System.Windows.Forms.TextBox txttenl;
        private System.Windows.Forms.TextBox txtmal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView dgvds;
    }
}