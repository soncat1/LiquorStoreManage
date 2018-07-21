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
using Excel = Microsoft.Office.Interop.Excel;
namespace QL_BanRuou.View
{
    public partial class ucHoaDonBan : UserControl
    {
        DATABASE db = new DATABASE();
        public ucHoaDonBan()
        {
            InitializeComponent();
        }
        public void HienThiChiTietHDB(DataTable tbl)
        {
            dgvChiTietHDB.Rows.Clear();
            foreach (DataRow row in tbl.Rows)
            {
                String[] rows =
                {
                    row["MAHDB"].ToString(),
                    row["MAH"].ToString(),
                    row["TENH"].ToString(),
                    row["SOLUONG"].ToString(),
                    row["DGBAN"].ToString(),
                    row["GIAMGIA"].ToString(),
                    row["THANHTIEN"].ToString()
                };
                dgvChiTietHDB.Rows.Add(rows);
            }
        }
        private void ucHoaDonBan_Load(object sender, EventArgs e)
        {
            String query = "select MAHDB from HOADONBAN";
            DataTable tbl = db.DocDuLieu(query);
            cboMAHDB.DataSource = tbl;
            cboMAHDB.DisplayMember = "MAHDB";
            cboMAHDB.ValueMember = "MAHDB";
        }

        private void cboMAHDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "select * from HOADONBAN where MAHDB='" + cboMAHDB.SelectedValue.ToString() + "'";
            DataTable tbl = db.DocDuLieu(query);
            foreach (DataRow r in tbl.Rows)
            {
                lblMAHDB.Text = cboMAHDB.SelectedValue.ToString();
                lblNGAYBAN.Text = r["NGAYBAN"].ToString();
                lblMANV.Text = r["MANV"].ToString();
                String queryNV = "select TENNV from NHANVIEN where MANV='" + r["MANV"].ToString() + "'";
                lblTENNV.Text = db.TuyBien(queryNV).ToString();
                String queryKH = "select * from KHACHHANG where MAKH='" + r["MAKH"].ToString() + "'";
                DataTable tblKH = db.DocDuLieu(queryKH);
                foreach (DataRow rowKH in tblKH.Rows)
                {
                    lblMAKH.Text = r["MAKH"].ToString();
                    lblTENKH.Text = rowKH["TENKH"].ToString();
                    lblDIACHI.Text = rowKH["DIACHI"].ToString();
                    lblSDT.Text = rowKH["SDT"].ToString();

                }
            }
            String querySoLuong = "select sum(SOLUONG) from CHITIETHDB where MAHDB='" + cboMAHDB.SelectedValue.ToString() + "'";
            lblTONGSOLUONG.Text = db.TuyBien(querySoLuong).ToString();
            String queryTongTien = "select sum((CHITIETHDB.SOLUONG*DMHANGHOA.DGBAN)*(1-0.01*GIAMGIA)) from CHITIETHDB JOIN DMHANGHOA ON CHITIETHDB.MAH=DMHANGHOA.MAH where MAHDB='" + cboMAHDB.SelectedValue.ToString() + "'";
            lblTONGTIEN.Text = db.TuyBien(queryTongTien).ToString();
            String queryCHITIETHDB = "select MAHDB, CHITIETHDB.MAH, DMHANGHOA.TENH, CHITIETHDB.SOLUONG, DMHANGHOA.DGBAN, GIAMGIA, (CHITIETHDB.SOLUONG*DMHANGHOA.DGBAN*(1-0.01*GIAMGIA)) AS THANHTIEN from CHITIETHDB JOIN DMHANGHOA ON CHITIETHDB.MAH=DMHANGHOA.MAH  where MAHDB='" + cboMAHDB.SelectedValue.ToString() + "'";
            
            DataTable tblCTHDB = db.DocDuLieu(queryCHITIETHDB);
            HienThiChiTietHDB(tblCTHDB);
            /*inner join DMHANGHOA on CHITIETHDB.MAH=DMHANGHOA.MAH*/
        }

        private void barButtonItemThêm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemHDB frmThemHDB = new frmThemHDB();
            frmThemHDB.ShowDialog();
        }

        private void barButtonItemXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá hóa đơn này", "Xoá hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // xóa trong dòng hóa đơn thì sẽ tự động xóa trong chi tiết hóa đơn
                    String deleteHoaDon = @"delete HOADONBAN where MAHDB = '" + lblMAHDB.Text + "'";
                    int dongAH = db.CapNhatDuLieu(deleteHoaDon);
                    if (dongAH > 0)
                    {
                        MessageBox.Show("Xoá hóa đơn thành công!!");
                        int SoLuongCapNhat = int.Parse(db.TuyBien("select SOLUONG from DMHANGHOA where MAH='" + dgvChiTietHDB.CurrentRow.Cells[1].Value.ToString() + "'").ToString()) + int.Parse(dgvChiTietHDB.CurrentRow.Cells[3].Value.ToString());
                        String querySoLuong = "Update DMHANGHOA set SOLUONG='" + SoLuongCapNhat + "'where MAH='" + dgvChiTietHDB.CurrentRow.Cells[1].Value.ToString() + "'";
                        int dong = db.CapNhatDuLieu(querySoLuong);
                    }
                    else
                        MessageBox.Show("Hủy hóa đơn thất bại!!");
                    cboMAHDB.ValueMember = "";
                    ucHoaDonBan_Load(sender, e);
            }

        }

        private void barButtonItemIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lblMAHDB.Text == "Thông tin")
            {
                MessageBox.Show("Bạn chưa chọn hoá đơn để in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                // Khởi động chương trình Excel
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook;//Trong 1 chương trình Excel có nhiều Workbook
                Excel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
                Excel.Range exRange;
                String sql;
                int hang = 0, cot = 0;
                DataTable tblThongtinHD, tblThongtinHang;
                exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                exSheet = exBook.Worksheets[1];
                // Định dạng chung
                exRange = exSheet.Cells[1, 1];
                exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
                exRange.Range["A1:B3"].Font.Size = 12;
                exRange.Range["A1:B3"].Font.Bold = true;
                exRange.Range["A1:B3"].Font.Color= Color.Blue;
                exRange.Range["A1:A1"].ColumnWidth = 10;
                exRange.Range["B1:B1"].ColumnWidth = 20;
                exRange.Range["A1:B1"].MergeCells = true;
                exRange.Range["A1:B1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["A1:B1"].Value = "Cửa Hàng Rượu CHIVAS 25";
                exRange.Range["A2:B2"].MergeCells = true;
                exRange.Range["A2:B2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:B2"].Value = "Địa chỉ: Xuân Diệu - Hà Nội";
                exRange.Range["A3:B3"].MergeCells = true;
                exRange.Range["A3:B3"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["A3:B3"].Value = "Điện thoại: 0964895108";
                exRange.Range["C2:E2"].Font.Size = 16;
                exRange.Range["C2:E2"].Font.Bold = true;
                exRange.Range["C2:E2"].Font.Color = Color.Red;
                exRange.Range["C2:E2"].MergeCells = true;
                exRange.Range["C2:E2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN HÀNG";
                // Biểu diễn thông tin chung của hóa đơn bán
                sql = "SELECT a.MAHDB, a.NGAYBAN, a.TONGTIEN, b.TENKH, b.DIACHI, b.SDT, c.TENNV FROM HOADONBAN AS a, KHACHHANG AS b, NHANVIEN AS c WHERE a.MAHDB = N'" + lblMAHDB.Text + "' AND a.MAKH= b.MAKH AND a.MANV = c.MANV";
                tblThongtinHD = db.DocDuLieu(sql);
                exRange.Range["B6:C9"].Font.Size = 12;
                exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
                exRange.Range["C6:E6"].MergeCells = true;
                exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
                exRange.Range["B7:B7"].Value = "Khách hàng:";
                exRange.Range["C7:E7"].MergeCells = true;
                exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
                exRange.Range["B8:B8"].Value = "Địa chỉ:";
                exRange.Range["C8:E8"].MergeCells = true;
                exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
                exRange.Range["B9:B9"].Value = "Điện thoại:";
                exRange.Range["C9:E9"].MergeCells = true;
                exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
                //Lấy thông tin các mặt hàng
                sql = "SELECT b.TENH, a.SOLUONG, b.DGBAN, a.GIAMGIA, a.THANHTIEN " +
                      "FROM CHITIETHDB AS a , DMHANGHOA AS b WHERE a.MAHDB = N'" +
                      lblMAHDB.Text + "' AND a.MAH = b.MAH";
                tblThongtinHang = db.DocDuLieu(sql);
                //Tạo dòng tiêu đề bảng
                exRange.Range["A11:F11"].Font.Bold = true;
                exRange.Range["A11:F11"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["C11:F11"].ColumnWidth = 12;
                exRange.Range["A11:A11"].Value = "STT";
                exRange.Range["B11:B11"].Value = "Tên hàng";
                exRange.Range["C11:C11"].Value = "Số lượng";
                exRange.Range["D11:D11"].Value = "Đơn giá";
                exRange.Range["E11:E11"].Value = "Giảm giá";
                exRange.Range["F11:F11"].Value = "Thành tiền";
                for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
                {
                    //Điền số thứ tự vào cột 1 từ dòng 12
                    exSheet.Cells[1][hang + 12] = hang + 1;
                    for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    {
                        exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                        if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                    }
                }
                exRange = exSheet.Cells[cot][hang + 14];
                exRange.Font.Bold = true;
                exRange.Value = "Tổng tiền:";
                exRange = exSheet.Cells[cot + 1][hang + 14];
                exRange.Font.Bold = true;
                exRange.Value = tblThongtinHD.Rows[0][2].ToString();
                exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
                exRange.Range["A1:C1"].MergeCells = true;
                exRange.Range["A1:C1"].Font.Italic = true;
                exRange.Range["A1:C1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
                exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
                exRange.Range["A2:C2"].MergeCells = true;
                exRange.Range["A2:C2"].Font.Italic = true;
                exRange.Range["A2:C2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
                exRange.Range["A6:C6"].MergeCells = true;
                exRange.Range["A6:C6"].Font.Italic = true;
                exRange.Range["A6:C6"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
                exSheet.Name = "Hóa đơn bán";
                exApp.Visible = true;
            }
        }
    }
}
