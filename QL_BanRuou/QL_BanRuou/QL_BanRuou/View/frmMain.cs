using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QL_BanRuou.View;
using QL_BanRuou.Object;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using QL_BanRuou.Properties;

namespace QL_BanRuou.View
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            //SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1);
            //UserLookAndFeel.Default.SkinName = Settings.Default["Pumpkin"].ToString();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
        
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pcnen.Controls.Clear();
            ucBackground bg = new ucBackground();
            bg.Dock = DockStyle.Fill;
            pcnen.Controls.Add(bg);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMain_Load(sender, e);
        }

        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
            else
                return;
        }
        private void navBarControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void nvbnv_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
         
        }

        private void nvb_Click(object sender, EventArgs e)
        {

        }

        private void nvbnv_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pcnen.Controls.Clear();
            ucNhanVien ucNv = new ucNhanVien();
            ucNv.Dock = DockStyle.Fill;
            pcnen.Controls.Add(ucNv);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucKhachHang ucKh = new ucKhachHang();
            ucKh.Dock = DockStyle.Fill;
            pcnen.Controls.Clear();
            pcnen.Controls.Add(ucKh);
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void pcnen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMain_Load(sender, e);
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void nvb_Click_1(object sender, EventArgs e)
        {
            pcnen.Controls.Clear();
            ucMatHang ucMh = new ucMatHang();
            ucMh.Dock = DockStyle.Fill;
            pcnen.Controls.Add(ucMh);
        }

        private void skinRibbonGalleryBarItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Settings.Default["Pumpkin"] = UserLookAndFeel.Default.SkinName;
            //Settings.Default.Save();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucDoanhThu ucDt = new ucDoanhThu();
            ucDt.Dock = DockStyle.Fill;
            pcnen.Controls.Clear();
            pcnen.Controls.Add(ucDt);
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucChart ucCh = new ucChart();
            ucCh.Dock = DockStyle.Fill;
            pcnen.Controls.Clear();
            pcnen.Controls.Add(ucCh);
        }

        private void navBarItem3_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucHoaDonNhap ucHdn = new ucHoaDonNhap();
            ucHdn.Dock = DockStyle.Fill;
            pcnen.Controls.Clear();
            pcnen.Controls.Add(ucHdn);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucHoaDonBan ucHdb = new ucHoaDonBan();
            ucHdb.Dock = DockStyle.Fill;
            pcnen.Controls.Clear();
            pcnen.Controls.Add(ucHdb);
        }

    }
}