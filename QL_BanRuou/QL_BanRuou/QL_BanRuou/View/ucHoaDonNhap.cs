using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanRuou.Model;
namespace QL_BanRuou.View
{
    public partial class ucHoaDonNhap : UserControl
    {
        DATABASE db = new DATABASE();
        public ucHoaDonNhap()
        {
            InitializeComponent();
        }
        public void HienThiChiTietHDN(DataTable tbl)
        {
            dgvChiTietHDN.Rows.Clear();
            foreach (DataRow row in tbl.Rows)
            {
                String[] rows =
                {
                    row["MAHDN"].ToString(),
                    row["MAH"].ToString(),
                    row["SOLUONG"].ToString(),
                    row["DONGIA"].ToString(),
                    row["GIAMGIA"].ToString(),
                    row["THANHTIEN"].ToString()
                };
                dgvChiTietHDN.Rows.Add(rows);
            }
        }

        private void ucHoaDonNhap_Load(object sender, EventArgs e)
        {
            String query = "select MAHDN from HOADONNHAP";
            DataTable tbl = db.DocDuLieu(query);
            cboMAHDN.DataSource = tbl;
            cboMAHDN.DisplayMember = "MAHDN";
            cboMAHDN.ValueMember = "MAHDN";
        }

        private void cboMAHDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "select * from HOADONNHAP where MAHDN='" + cboMAHDN.SelectedValue.ToString() + "'";
            DataTable tbl = db.DocDuLieu(query);
            foreach (DataRow r in tbl.Rows)
            {
                lblMAHDN.Text = cboMAHDN.SelectedValue.ToString();
                lblNGAYNHAP.Text = r["NGAYNHAP"].ToString();
                lblMANV.Text = r["MANV"].ToString();
                String queryNV = "select TENNV from NHANVIEN where MANV='" + r["MANV"].ToString() + "'";
                lblTENNV.Text = db.TuyBien(queryNV).ToString();
                String queryNCC = "select * from NHACC where MANCC='" + r["MANCC"].ToString() + "'";
                DataTable tblNCC = db.DocDuLieu(queryNCC);
                foreach (DataRow rowNCC in tblNCC.Rows)
                {
                    lblMANCC.Text = r["MANCC"].ToString();
                    lblTENNCC.Text = rowNCC["TENNCC"].ToString();
                    lblDIACHI.Text = rowNCC["DIACHI"].ToString();
                    lblSDT.Text = rowNCC["SDT"].ToString();
                }
            }
            String querySoLuong = "select sum(SOLUONG) from CHITIETHDN where MAHDN='" + cboMAHDN.SelectedValue.ToString() + "'";
            lblTONGSOLUONG.Text = db.TuyBien(querySoLuong).ToString();
            String queryTongTien = "select sum((SOLUONG*DONGIA)*(1-0.01*GIAMGIA)) from CHITIETHDN where MAHDN='" + cboMAHDN.SelectedValue.ToString() + "'";
            lblTONGTIEN.Text = db.TuyBien(queryTongTien).ToString();
            String queryCHITIETHDN = "select MAHDN, MAH, SOLUONG, DONGIA, GIAMGIA, (SOLUONG*DONGIA*(1-0.01*GIAMGIA)) AS THANHTIEN from CHITIETHDN  where MAHDN='" + cboMAHDN.SelectedValue.ToString() + "'";
            DataTable tblCTHDN = db.DocDuLieu(queryCHITIETHDN);
            HienThiChiTietHDN(tblCTHDN);
        }

        private void barButtonItemThêm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemHDN frmThemHDN = new frmThemHDN();
            frmThemHDN.ShowDialog();
        }

        private void barButtonItemXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn này", "Hủy hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // xóa trong dòng hóa đơn thì sẽ tự động xóa trong chi tiết hóa đơn
                String deleteHoaDon = @"delete HOADONNHAP where MAHDN = '" + lblMAHDN.Text + "'";
                int dongAH = db.CapNhatDuLieu(deleteHoaDon);
                if (dongAH > 0)
                {
                    MessageBox.Show("Hủy hóa đơn thành công!!");
                    int SoLuongCapNhat = int.Parse(db.TuyBien("select SOLUONG from DMHANGHOA where MAH='" + dgvChiTietHDN.CurrentRow.Cells[1].Value.ToString() + "'").ToString()) - int.Parse(dgvChiTietHDN.CurrentRow.Cells[3].Value.ToString());
                    String querySoLuong = "Update DMHANGHOA set SOLUONG='" + SoLuongCapNhat + "'where MAH='" + dgvChiTietHDN.CurrentRow.Cells[1].Value.ToString() + "'";
                    int dong = db.CapNhatDuLieu(querySoLuong);
                }
                else
                    MessageBox.Show("Hủy hóa đơn thất bại!!");
                cboMAHDN.ValueMember = "";
                ucHoaDonNhap_Load(sender, e);
            }
        }
    }
}
