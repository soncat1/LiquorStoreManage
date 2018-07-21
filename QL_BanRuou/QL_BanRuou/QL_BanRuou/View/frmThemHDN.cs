using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanRuou.Model;
namespace QL_BanRuou.View
{
    public partial class frmThemHDN : Form
    {
        DATABASE db = new DATABASE();
        SinhMaTD td = new SinhMaTD();
        public frmThemHDN()
        {
            InitializeComponent();
        }

        private void frmThemHDN_Load(object sender, EventArgs e)
        {
            String queryNV = "select TENNV from NHANVIEN";
            DataTable tblNV = db.DocDuLieu(queryNV);
            AutoCompleteStringCollection autoNV = new AutoCompleteStringCollection();
            foreach (DataRow row in tblNV.Rows)
            {
                autoNV.Add(row["TENNV"].ToString());
            }
            txtnv.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtnv.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtnv.AutoCompleteCustomSource = autoNV;
            nmrsoluong.Enabled = false;
            nmrgiamgia.Enabled = false;
            DataTable tblLuu = db.DocDuLieu("Select * from HOADONNHAP");
            string str = "HDN" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            txtmahdn.Text = td.SinhMaTuDong("HOADONNHAP", str, "MAHDN");
        }

        private void cboncc_SelectedValueChanged(object sender, EventArgs e)
        {
            String query = "select *from NHACC where MANCC='" + cboncc.SelectedValue.ToString() + "'";
            DataTable tblNCC = db.DocDuLieu(query);
            foreach (DataRow row in tblNCC.Rows)
            {
                txtdc.Text = row["DIACHI"].ToString();
                txtdt.Text = row["SDT"].ToString();
            }
        }

        private void cboncc_Click(object sender, EventArgs e)
        {
            String queryNCC = "select MANCC, TENNCC from NHACC";
            DataTable tblNCC = db.DocDuLieu(queryNCC);
            cboncc.DataSource = tblNCC;
            cboncc.DisplayMember = "TENNCC";
            cboncc.ValueMember = "MANCC";
        }

        private void cbotenh_Click(object sender, EventArgs e)
        {
            String queryHang = "select MAH, TENH from DMHANGHOA";
            DataTable tblHang = db.DocDuLieu(queryHang);
            cbotenh.DataSource = tblHang;
            cbotenh.DisplayMember = "TENH";
            cbotenh.ValueMember = "MAH";
        }

        private void cbotenh_SelectedValueChanged(object sender, EventArgs e)
        {
            String query = "select *from DMHANGHOA where MAH='" + cbotenh.SelectedValue.ToString() + "'";
            DataTable tblHang = db.DocDuLieu(query);
            foreach (DataRow row in tblHang.Rows)
            {
                txtdongia.Text = row["DGNHAP"].ToString();
            }
            nmrsoluong.Enabled = true;
            nmrgiamgia.Enabled = true;
            nmrsoluong.Value = 0;
            nmrgiamgia.Value = 0;
        }

        private void nmrsoluong_Click(object sender, EventArgs e)
        {
            int GiamGia = int.Parse(nmrgiamgia.Value.ToString());
            int SoLuong = int.Parse(nmrsoluong.Value.ToString());
            Decimal DonGia = Decimal.Parse(txtdongia.Text);
            txtthanhtien.Text = Convert.ToString((SoLuong * DonGia) - (SoLuong * DonGia * GiamGia / 100));
        }

        private void nmrgiamgia_Click(object sender, EventArgs e)
        {
            int GiamGia = int.Parse(nmrgiamgia.Value.ToString());
            int SoLuong = int.Parse(nmrsoluong.Value.ToString());
            Decimal DonGia = Decimal.Parse(txtdongia.Text);
            txtthanhtien.Text = Convert.ToString((SoLuong * DonGia) - (SoLuong * DonGia * GiamGia / 100));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nmrsoluong.Value == 0)
            {
                MessageBox.Show("Bạn chưa chọn số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                int kt = -1;
                for (int i = 0; i < dgvChiTietHDN.Rows.Count; i++)
                {
                    if (cbotenh.SelectedValue.ToString().ToLower() == dgvChiTietHDN.Rows[i].Cells[0].Value.ToString().ToLower())
                    {
                        kt = i;
                    }
                }
                if (kt < 0)
                {
                    String[] rows =
            {
                cbotenh.SelectedValue.ToString(),
                cbotenh.Text,
                nmrsoluong.Value.ToString(),
                txtdongia.Text,
                nmrgiamgia.Value.ToString(),
                txtthanhtien.Text,
            };
                    dgvChiTietHDN.Rows.Add(rows);
                }
                else
                {
                    dgvChiTietHDN.Rows[kt].Cells[2].Value = (int.Parse(dgvChiTietHDN.Rows[kt].Cells[2].Value.ToString()) + nmrsoluong.Value).ToString();
                    dgvChiTietHDN.Rows[kt].Cells[5].Value = (Decimal.Parse(txtthanhtien.Text) + Decimal.Parse(dgvChiTietHDN.Rows[kt].Cells[5].Value.ToString())).ToString();
                }
                int SoLuongThem = int.Parse(db.TuyBien("select SOLUONG from DMHANGHOA where MAH='" + cbotenh.SelectedValue.ToString() + "'").ToString()) + int.Parse(nmrsoluong.Value.ToString());
                String querySoLuong = "Update DMHANGHOA set SOLUONG='" + SoLuongThem + "'where MAH='" + cbotenh.SelectedValue.ToString() + "'";
                int dong = db.CapNhatDuLieu(querySoLuong);
            cbotenh.Text = "";
            txtdongia.Text = "";
            txtthanhtien.Text = "";
            nmrsoluong.Value = 0;
            nmrgiamgia.Value = 0;
            nmrsoluong.Enabled = false;
            nmrgiamgia.Enabled = false;
        }

        private void dgvChiTietHDN_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn huỷ sản phẩm" + dgvChiTietHDN.CurrentRow.Cells[1].Value.ToString() + " không?", "Xác nhận huỷ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int SoLuongCapNhat = int.Parse(db.TuyBien("select SOLUONG from DMHANGHOA where MAH='" + dgvChiTietHDN.CurrentRow.Cells[0].Value.ToString() + "'").ToString()) - int.Parse(dgvChiTietHDN.CurrentRow.Cells[2].Value.ToString());
                String querySoLuong = "Update DMHANGHOA set SOLUONG='" + SoLuongCapNhat + "'where MAH='" + dgvChiTietHDN.CurrentRow.Cells[0].Value.ToString() + "'";
                int dong = db.CapNhatDuLieu(querySoLuong);
                dgvChiTietHDN.Rows.Remove(dgvChiTietHDN.CurrentRow);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtnv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int SoLuongCapNhat = int.Parse(db.TuyBien("select SOLUONG from DMHANGHOA where MAH='" + dgvChiTietHDN.CurrentRow.Cells[0].Value.ToString() + "'").ToString()) - int.Parse(dgvChiTietHDN.CurrentRow.Cells[2].Value.ToString());
                String querySoLuong = "Update DMHANGHOA set SOLUONG='" + SoLuongCapNhat + "'where MAH='" + dgvChiTietHDN.CurrentRow.Cells[0].Value.ToString() + "'";
                int dong = db.CapNhatDuLieu(querySoLuong);
                return;
            }
            if (cboncc.ValueMember == "")
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int SoLuongCapNhat = int.Parse(db.TuyBien("select SOLUONG from DMHANGHOA where MAH='" + dgvChiTietHDN.CurrentRow.Cells[0].Value.ToString() + "'").ToString()) - int.Parse(dgvChiTietHDN.CurrentRow.Cells[2].Value.ToString());
                String querySoLuong = "Update DMHANGHOA set SOLUONG='" + SoLuongCapNhat + "'where MAH='" + dgvChiTietHDN.CurrentRow.Cells[0].Value.ToString() + "'";
                int dong = db.CapNhatDuLieu(querySoLuong);
                return;
            }
            String queryMANV = "select MANV from NHANVIEN where TENNV='" + txtnv.Text + "'";
            DataTable MANV = db.DocDuLieu(queryMANV);
            int tongtien = 0;
            for (int i = 0; i < dgvChiTietHDN.Rows.Count; i++)
            {
                tongtien += int.Parse(dgvChiTietHDN.Rows[i].Cells[5].Value.ToString());
            }
            //insert Bảng HOADONNHAP
            String insertHoaDonNhap = String.Format("insert into HOADONNHAP(MAHDN, MANV, NGAYNHAP, MANCC, TONGTIEN) values ('{0}', '{1}', '{2}', '{3}', {4});", txtmahdn.Text, MANV.Rows[0][0].ToString(), dtimengaynhap.Value, cboncc.SelectedValue, tongtien.ToString());
            MessageBox.Show(insertHoaDonNhap);
            //insert Bảng CHITIETHDN
            if (dgvChiTietHDN.Rows.Count > 0)
            {
                //Tạo ra chuỗi thêm chi tiết hoá đơn nhập
                insertHoaDonNhap += @"insert into CHITIETHDN(MAHDN, MAH, SOLUONG, DONGIA, GIAMGIA, THANHTIEN) values";
                String row = "";
                int count = dgvChiTietHDN.Rows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    row += String.Format("('{0}', '{1}', {2}, {3}, {4}, {5}),", txtmahdn.Text, dgvChiTietHDN.Rows[i].Cells[0].Value, dgvChiTietHDN.Rows[i].Cells[2].Value, dgvChiTietHDN.Rows[i].Cells[3].Value, dgvChiTietHDN.Rows[i].Cells[4].Value, dgvChiTietHDN.Rows[i].Cells[5].Value);
                }
                row += String.Format("('{0}', '{1}', {2}, {3}, {4}, {5});", txtmahdn.Text, dgvChiTietHDN.Rows[count - 1].Cells[0].Value, dgvChiTietHDN.Rows[count - 1].Cells[2].Value, dgvChiTietHDN.Rows[count - 1].Cells[3].Value, dgvChiTietHDN.Rows[count - 1].Cells[4].Value, dgvChiTietHDN.Rows[count - 1].Cells[5].Value);
                insertHoaDonNhap += row;
            }
            int dongAH = db.CapNhatDuLieu(insertHoaDonNhap);
            if (dongAH > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá hết dữ liệu đã nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dgvChiTietHDN.Rows.Count > 0)
                {
                    int SoLuongCapNhat = int.Parse(db.TuyBien("select SOLUONG from DMHANGHOA where MAH='" + dgvChiTietHDN.CurrentRow.Cells[0].Value.ToString() + "'").ToString()) - int.Parse(dgvChiTietHDN.CurrentRow.Cells[2].Value.ToString());
                    String querySoLuong = "Update DMHANGHOA set SOLUONG='" + SoLuongCapNhat + "'where MAH='" + dgvChiTietHDN.CurrentRow.Cells[0].Value.ToString() + "'";
                    int dong = db.CapNhatDuLieu(querySoLuong);
                    dgvChiTietHDN.Rows.Remove(dgvChiTietHDN.CurrentRow);
                }
                MessageBox.Show("Xoá dữ liệu thành công!!");
                frmThemHDN_Load(sender, e);
                txtdongia.Text = "";
                txtdc.Text = "";
                txtdt.Text = "";
                txtnv.Text = "";
                txtthanhtien.Text = "";
                cboncc.Text = "";
                dgvChiTietHDN.Rows.Clear();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dgvChiTietHDN.Rows.Count > 0)
                {
                    int SoLuongCapNhat = int.Parse(db.TuyBien("select SOLUONG from DMHANGHOA where MAH='" + dgvChiTietHDN.CurrentRow.Cells[0].Value.ToString() + "'").ToString()) - int.Parse(dgvChiTietHDN.CurrentRow.Cells[2].Value.ToString());
                    String querySoLuong = "Update DMHANGHOA set SOLUONG='" + SoLuongCapNhat + "'where MAH='" + dgvChiTietHDN.CurrentRow.Cells[0].Value.ToString() + "'";
                    int dong = db.CapNhatDuLieu(querySoLuong);
                    dgvChiTietHDN.Rows.Remove(dgvChiTietHDN.CurrentRow);
                }
                this.Close();
            }
        }
    }
}
