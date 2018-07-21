using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanRuou.Object;
using QL_BanRuou.Controller;
using QL_BanRuou.Model;

namespace QL_BanRuou.View
{
    public partial class ucKhachHang : UserControl
    {
        KhachHangCtrl khCtrl = new KhachHangCtrl();
        KhachHangObj khObj = new KhachHangObj();
        KhachHangMod khMod = new KhachHangMod();
        int flagLuu = 0;
        public ucKhachHang()
        {
            InitializeComponent();
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            txtmakh.Enabled = false;
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtmakh.Enabled = false;
        }

        private void ucKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtKhachHang = new System.Data.DataTable();
            dtKhachHang = khCtrl.getData();
            dgvds.DataSource = dtKhachHang;
            binding();
        }
        private void binding()
        {
            dgvds.Columns[0].HeaderText = "Mã khách hàng";
            txttenkh.DataBindings.Clear();
            txttenkh.DataBindings.Add("Text", dgvds.DataSource, "TENKH");
            dgvds.Columns[1].HeaderText = "Tên khách hàng";
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dgvds.DataSource, "DIACHI");
            dgvds.Columns[2].HeaderText = "Địa chỉ";
            txtsdt.DataBindings.Clear();
            txtsdt.DataBindings.Add("Text", dgvds.DataSource, "SDT");
            dgvds.Columns[3].HeaderText = "Số điện thoại";
            if (txttenkh.Text == "" && txtdiachi.Text == "" && txtsdt.Text == "")
                return;
            else
            {
                txtmakh.DataBindings.Clear();
                txtmakh.DataBindings.Add("Text", dgvds.DataSource, "MAKH");
                try
                {
                    pbanhkh.Image = Image.FromFile(Model.ConnectToSql.GetFieldValues("SELECT ANH FROM KHACHHANG WHERE MAKH = '" + dgvds.CurrentRow.Cells[0].Value.ToString() + "'"));
                }
                catch
                {
                    pbanhkh.Image = null;
                }
            }
           
        }

        private void clearData()
        {
            txtmakh.Text = khMod.SinhMaTuDong("KHACHHANG", "MAKH", "KH00");
            txttenkh.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            pbanhkh.Image = null;
        }
        private void clearData1()
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            pbanhkh.Image = null;
        }

        private void addData(KhachHangObj kh)
        {
            kh.MaKh = txtmakh.Text.Trim();
            kh.DiaChi = txtdiachi.Text.Trim();
            kh.Sdt = txtsdt.Text.Trim();
            kh.TenKh = txttenkh.Text.Trim();
        }

        private void DisEnl(bool e)
        {
            btnthemkh.Enabled = !e;
            btnsuakh.Enabled = !e;
            btnxoakh.Enabled = !e;
            btnluukh.Enabled = e;
            btnhuykh.Enabled = e;
            txtmakh.Enabled = e;
            txttenkh.Enabled = e;
            txtdiachi.Enabled = e;
            txtsdt.Enabled = e;
            btnchonanhkh.Enabled = e;
            txtmakh.Enabled = e;
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (khCtrl.delData(txtmakh.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData1();
                }
                else
                    MessageBox.Show("Không xóa được thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
            ucKhachHang_Load(sender, e);
            DisEnl(false);
        }

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addData(khObj);
            if (txtmakh.Text == "" || txttenkh.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin yêu cầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (flagLuu == 0)
                {
                    if (khCtrl.addData(khObj))
                        MessageBox.Show("Thêm thành công thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không thêm được thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (khCtrl.updData(khObj))
                        MessageBox.Show("Sửa thành công thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không sửa được thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ucKhachHang_Load(sender, e);
                DisEnl(false);
            }         
        }

        private void btnhuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ucKhachHang_Load(sender, e);
                clearData1();
                DisEnl(false);
            }
            else
                return;
        }

        private void dgvds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static string name_Image = "";
        private void btnchonanhkh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|Jpg(*.jpg)|*.jpg|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "C:\\Users\\HongSon\\Desktop\\NET\\QL_BanRuou\\QL_BanRuou\\AnhKh";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn hình ảnh muốn thay đổi";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                name_Image = dlgOpen.FileName;
                pbanhkh.Image = Image.FromFile(dlgOpen.FileName);
            }
        }

        private void dgvds_Click(object sender, EventArgs e)
        {
            try
            {
                pbanhkh.Image = Image.FromFile(Model.ConnectToSql.GetFieldValues("SELECT ANH FROM KHACHHANG WHERE MAKH = '" + dgvds.CurrentRow.Cells[0].Value.ToString() + "'"));
            }
            catch
            {
                pbanhkh.Image = null;
            }
        }
    }
}
