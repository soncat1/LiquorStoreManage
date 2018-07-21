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
    public partial class frmThemHDB : Form
    {
        DATABASE db = new DATABASE();
        SinhMaTD td = new SinhMaTD();
        public frmThemHDB()
        {
            InitializeComponent();
        }

        private void frmThemHDB_Load(object sender, EventArgs e)
        {
            String queryNV = "select TENNV from NHANVIEN";
            DataTable tblNV = db.DocDuLieu(queryNV);
            AutoCompleteStringCollection autoNV = new AutoCompleteStringCollection();
            foreach(DataRow row in tblNV.Rows)
            {
                autoNV.Add(row["TENNV"].ToString());
            }
            txtnv.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtnv.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtnv.AutoCompleteCustomSource = autoNV;
            nmrsoluong.Enabled = false;
            nmrgiamgia.Enabled = false;
            DataTable tblLuu = db.DocDuLieu("Select * from HOADONBAN");
            string str = "HDB" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            txtmahdb.Text = td.SinhMaTuDong("HOADONBAN", str, "MAHDB");
        }

        private void cbokh_SelectedValueChanged(object sender, EventArgs e)
        {
            String query = "select *from KHACHHANG where MAKH='" + cbokh.SelectedValue.ToString() + "'";
            DataTable tblKH = db.DocDuLieu(query);
            foreach(DataRow row in tblKH.Rows)
            {
                txtdc.Text = row["DIACHI"].ToString();
                txtdt.Text = row["SDT"].ToString();
            }
        }

        private void cbokh_Click(object sender, EventArgs e)
        {
            String queryKH = "select MAKH, TENKH from KHACHHANG";
            DataTable tblKH = db.DocDuLieu(queryKH);
            cbokh.DataSource = tblKH;
            cbokh.DisplayMember = "TENKH";
            cbokh.ValueMember = "MAKH";
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
                txtdongia.Text = row["DGBAN"].ToString();
            }
            nmrsoluong.Enabled = true;
            nmrgiamgia.Enabled = true;
            nmrsoluong.Value = 0;
            nmrgiamgia.Value = 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nmrsoluong.Value == 0)
            {
                MessageBox.Show("Bạn chưa chọn số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            String querySoLuongKho = "select SOLUONG from DMHANGHOA where MAH='" + cbotenh.SelectedValue.ToString() + "'";
            DataTable tblHang = db.DocDuLieu(querySoLuongKho);
            int SoLuongKho = int.Parse(db.TuyBien("select SOLUONG from DMHANGHOA where MAH='" + cbotenh.SelectedValue.ToString() + "'").ToString());
            if (SoLuongKho < nmrsoluong.Value)
            {
                MessageBox.Show("Số lượng không đủ, chỉ còn " + tblHang.Rows[0]["SOLUONG"].ToString());
            }
            else
            {
                int kt = -1;
                for (int i = 0; i < dgvChiTietHDB.Rows.Count; i++)
                {
                    if (cbotenh.SelectedValue.ToString().ToLower() == dgvChiTietHDB.Rows[i].Cells[0].Value.ToString().ToLower())
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
                    dgvChiTietHDB.Rows.Add(rows);
                }
                else
                {
                    dgvChiTietHDB.Rows[kt].Cells[2].Value = (int.Parse(dgvChiTietHDB.Rows[kt].Cells[2].Value.ToString()) + nmrsoluong.Value).ToString();
                    dgvChiTietHDB.Rows[kt].Cells[5].Value = (Decimal.Parse(txtthanhtien.Text) + Decimal.Parse(dgvChiTietHDB.Rows[kt].Cells[5].Value.ToString())).ToString();
                }
                int SoLuongConLai = int.Parse(db.TuyBien("select SOLUONG from DMHANGHOA where MAH='" + cbotenh.SelectedValue.ToString() + "'").ToString()) - int.Parse(nmrsoluong.Value.ToString());
                String querySoLuong = "Update DMHANGHOA set SOLUONG='" + SoLuongConLai + "'where MAH='" + cbotenh.SelectedValue.ToString() + "'";
                int dong = db.CapNhatDuLieu(querySoLuong);
            }
                cbotenh.Text = "";
                txtdongia.Text = "";
                txtthanhtien.Text = "";
                nmrsoluong.Value = 0;
                nmrgiamgia.Value = 0;
                nmrsoluong.Enabled = false;
                nmrgiamgia.Enabled = false;
        }

        private void dgvChiTietHDB_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn huỷ sản phẩm" + dgvChiTietHDB.CurrentRow.Cells[1].Value.ToString() + " không?", "Xác nhận huỷ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                int SoLuongCapNhat = int.Parse(db.TuyBien("select SOLUONG from DMHANGHOA where MAH='" + dgvChiTietHDB.CurrentRow.Cells[0].Value.ToString() + "'").ToString()) + int.Parse(dgvChiTietHDB.CurrentRow.Cells[2].Value.ToString());
                String querySoLuong = "Update DMHANGHOA set SOLUONG='" + SoLuongCapNhat + "'where MAH='" + dgvChiTietHDB.CurrentRow.Cells[0].Value.ToString() + "'";
                int dong = db.CapNhatDuLieu(querySoLuong);
                dgvChiTietHDB.Rows.Remove(dgvChiTietHDB.CurrentRow);
            }
        }
        private void nmrsoluong_Click_1(object sender, EventArgs e)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dgvChiTietHDB.Rows.Count > 0)
                {
                    int SoLuongCapNhat = int.Parse(db.TuyBien("select SOLUONG from DMHANGHOA where MAH='" + dgvChiTietHDB.CurrentRow.Cells[0].Value.ToString() + "'").ToString()) + int.Parse(dgvChiTietHDB.CurrentRow.Cells[2].Value.ToString());
                    String querySoLuong = "Update DMHANGHOA set SOLUONG='" + SoLuongCapNhat + "'where MAH='" + dgvChiTietHDB.CurrentRow.Cells[0].Value.ToString() + "'";
                    int dong = db.CapNhatDuLieu(querySoLuong);
                    dgvChiTietHDB.Rows.Remove(dgvChiTietHDB.CurrentRow);
                }
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtnv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int SoLuongCapNhat = int.Parse(db.TuyBien("select SOLUONG from DMHANGHOA where MAH='" + dgvChiTietHDB.CurrentRow.Cells[0].Value.ToString() + "'").ToString()) + int.Parse(dgvChiTietHDB.CurrentRow.Cells[2].Value.ToString());
                String querySoLuong = "Update DMHANGHOA set SOLUONG='" + SoLuongCapNhat + "'where MAH='" + dgvChiTietHDB.CurrentRow.Cells[0].Value.ToString() + "'";
                int dong = db.CapNhatDuLieu(querySoLuong);
                return;
            }
            if(cbokh.ValueMember=="")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int SoLuongCapNhat = int.Parse(db.TuyBien("select SOLUONG from DMHANGHOA where MAH='" + dgvChiTietHDB.CurrentRow.Cells[0].Value.ToString() + "'").ToString()) + int.Parse(dgvChiTietHDB.CurrentRow.Cells[2].Value.ToString());
                String querySoLuong = "Update DMHANGHOA set SOLUONG='" + SoLuongCapNhat + "'where MAH='" + dgvChiTietHDB.CurrentRow.Cells[0].Value.ToString() + "'";
                int dong = db.CapNhatDuLieu(querySoLuong);
                return;
            }
            String queryMANV = "select MANV from NHANVIEN where TENNV='" + txtnv.Text + "'";
            DataTable MANV = db.DocDuLieu(queryMANV);
            int tongtien = 0;
            for(int i = 0; i < dgvChiTietHDB.Rows.Count; i++)
            {
                tongtien += int.Parse(dgvChiTietHDB.Rows[i].Cells[5].Value.ToString());
            }
            //insert Bảng HOADONBAN
            String insertHoaDonBan = String.Format("insert into HOADONBAN(MAHDB, MANV, NGAYBAN, MAKH, TONGTIEN) values ('{0}', '{1}', '{2}', '{3}', {4});", txtmahdb.Text, MANV.Rows[0][0].ToString(), dtimengayban.Value, cbokh.SelectedValue, tongtien.ToString());
            //insert Bảng CHITIETHDB
            if (dgvChiTietHDB.Rows.Count > 0)
            {
                //Tạo ra chuỗi thêm chi tiết hoá đơn bán
                insertHoaDonBan += @"insert into CHITIETHDB(MAHDB, MAH, SOLUONG, GIAMGIA, THANHTIEN) values";
                String row = "";
                int count = dgvChiTietHDB.Rows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    row += String.Format("('{0}', '{1}', {2}, {3}, {4}),", txtmahdb.Text, dgvChiTietHDB.Rows[i].Cells[0].Value, dgvChiTietHDB.Rows[i].Cells[2].Value, dgvChiTietHDB.Rows[i].Cells[4].Value, dgvChiTietHDB.Rows[i].Cells[5].Value);
                }
                row += String.Format("('{0}', '{1}', {2}, {3}, {4});", txtmahdb.Text, dgvChiTietHDB.Rows[count - 1].Cells[0].Value, dgvChiTietHDB.Rows[count - 1].Cells[2].Value, dgvChiTietHDB.Rows[count - 1].Cells[4].Value, dgvChiTietHDB.Rows[count - 1].Cells[5].Value);
                insertHoaDonBan += row;
            }
            int dongAH = db.CapNhatDuLieu(insertHoaDonBan);
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
                if (dgvChiTietHDB.Rows.Count > 0)
                {
                    int SoLuongCapNhat = int.Parse(db.TuyBien("select SOLUONG from DMHANGHOA where MAH='" + dgvChiTietHDB.CurrentRow.Cells[0].Value.ToString() + "'").ToString()) + int.Parse(dgvChiTietHDB.CurrentRow.Cells[2].Value.ToString());
                    String querySoLuong = "Update DMHANGHOA set SOLUONG='" + SoLuongCapNhat + "'where MAH='" + dgvChiTietHDB.CurrentRow.Cells[0].Value.ToString() + "'";
                    int dong = db.CapNhatDuLieu(querySoLuong);
                    dgvChiTietHDB.Rows.Remove(dgvChiTietHDB.CurrentRow);
                }
                MessageBox.Show("Xoá dữ liệu thành công!!");
                frmThemHDB_Load(sender, e);
                txtdongia.Text = "";
                txtdc.Text = "";
                txtdt.Text = "";
                txtnv.Text = "";
                txtthanhtien.Text = "";
                cbokh.Text = "";
                dgvChiTietHDB.Rows.Clear();
            }
        }
    }
}
