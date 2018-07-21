 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanRuou.Controller;
using QL_BanRuou.Model;
using System.Data.SqlClient;
using QL_BanRuou.Object;

namespace QL_BanRuou.View
{
    public partial class ucMatHang : UserControl
    {
        NCCCtrl nccCtrl = new NCCCtrl();
        LoaiCtrl lCtrl = new LoaiCtrl();
        ChatLieuCtrl clCtrl = new ChatLieuCtrl();
        CongDungCtrl cdCtrl = new CongDungCtrl();
        DoRuouCtrl drCtrl = new DoRuouCtrl();
        DungLuongCtrl dlCtrl = new DungLuongCtrl();
        HinhDangCtrl hdCtrl = new HinhDangCtrl();
        MauSacCtrl msCtrl = new MauSacCtrl();
        NuocSXCtrl nsxCtrl = new NuocSXCtrl();
        MatHangCtrl mhCtrl = new MatHangCtrl();
        MatHangMod mhMod = new MatHangMod();
        MatHangObj mhObj = new MatHangObj( );
        
        int flagLuu = 0;
        public ucMatHang()
        {
            InitializeComponent();
        }
        private void nhapso(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) >= '0' && (e.KeyChar) <= '9' || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmNhaCC frNCC = new frmNhaCC();
            frNCC.ShowDialog();
        }

        private void ucMatHang_Load(object sender, EventArgs e)
        {
            DataTable dtMh = new System.Data.DataTable();
            dtMh = mhCtrl.getData();
            dgvds.DataSource = dtMh;
            binding();
        }
        private void clearData()
        {
            txtmamh.Text = mhMod.SinhMaTuDong("DMHANGHOA", "MAH", "MH00");
            txttenmh.Text = "";
            txtsl.Text = "";
            txtgc.Text = "";
            txtdgn.Text = "";
            txtdgb.Text = "";
            txttgbh.Text = "";
            cmbcd.Text = "";
            cmbcl.Text = "";
            cmbdl.Text = "";
            cmbhd.Text = "";
            cmbloai.Text = "";
            cmbmau.Text = "";
            cmbncc.Text = "";
            cmbnd.Text = "";
            cmbnsx.Text = "";
            pbanhmh.Image = null;
        }
        private void addData(MatHangObj mh)
        {
            mh.MaMh = txtmamh.Text.Trim();
            mh.TenMh = txttenmh.Text.Trim();
            mh.Cd = ConnectToSql.GetFieldValues("SELECT MACD FROM CONGDUNG WHERE TENCD= N'" + cmbcd.Text + "'");
            mh.Cl = ConnectToSql.GetFieldValues("SELECT MACL FROM CHATLIEU WHERE TENCL= N'" + cmbcl.Text + "'");
            mh.Dgb = txtdgb.Text.Trim();
            mh.Dgn = txtdgn.Text.Trim();
            mh.Dl = ConnectToSql.GetFieldValues("SELECT MADL FROM DUNGLUONG WHERE TENDL= N'" + cmbdl.Text + "'");
            mh.GhiChu = txtgc.Text.Trim();
            mh.Hd = ConnectToSql.GetFieldValues("SELECT MAHD FROM HINHDANG WHERE TENHD= N'" + cmbhd.Text + "'");
            mh.Loai = ConnectToSql.GetFieldValues("SELECT MAL FROM LOAI WHERE TENL= N'" + cmbloai.Text + "'");
            mh.Mau = ConnectToSql.GetFieldValues("SELECT MAM FROM MAUSAC WHERE TENM= N'" + cmbmau.Text + "'");
            mh.Ncc = ConnectToSql.GetFieldValues("SELECT MANCC FROM NHACC WHERE TENNCC= N'" + cmbncc.Text + "'");
            mh.Nd = ConnectToSql.GetFieldValues("SELECT MADO FROM DORUOU WHERE TENDO= N'" + cmbnd.Text + "'");
            mh.Nsx = ConnectToSql.GetFieldValues("SELECT MANSX FROM NUOCSX WHERE TENNSX= N'" + cmbnsx.Text + "'");
            mh.Tgbh = txttgbh.Text.Trim();
            mh.Sl = txtsl.Text.Trim();
            
        }
        
        
        private void DisEnl(bool e)
        {
            btnthemmh.Enabled = !e;
            btnsuamh.Enabled = !e;
            btnxoamh.Enabled = !e;
            btnluumh.Enabled = e;
            btnhuymh.Enabled = e;
            txtmamh.Enabled = !e;
            txttenmh.Enabled = e;
            txtsl.Enabled = e;
            txtgc.Enabled = e;
            txtdgn.Enabled = e;
            txtdgb.Enabled = e;
            txttgbh.Enabled = e;
            cmbcd.Enabled = e;
            cmbcl.Enabled = e;
            cmbdl.Enabled = e;
            cmbhd.Enabled = e;
            cmbloai.Enabled = e;
            cmbmau.Enabled = e;
            cmbncc.Enabled = e;
            cmbnd.Enabled = e;
            cmbnsx.Enabled = e;
            btnchonanhmh.Enabled = e;

        }
        private void binding()
        {
            txtmamh.DataBindings.Clear();
            txtmamh.DataBindings.Add("Text", dgvds.DataSource,"MAH");
            dgvds.Columns[0].HeaderText = "Mã rượu";
            txttenmh.DataBindings.Clear();
            txttenmh.DataBindings.Add("Text", dgvds.DataSource, "TENH");
            dgvds.Columns[1].HeaderText = "Tên rượu";
            cmbloai.DataBindings.Clear();
            cmbloai.DataBindings.Add("Text", dgvds.DataSource, "TENL");
            dgvds.Columns[2].HeaderText = "Loại";
            cmbdl.DataBindings.Clear();
            cmbdl.DataBindings.Add("Text", dgvds.DataSource, "TENDL");
            dgvds.Columns[3].HeaderText = "Dung lượng";
            cmbcd.DataBindings.Clear();
            cmbcd.DataBindings.Add("Text", dgvds.DataSource, "TENCD");
            dgvds.Columns[4].HeaderText = "Công dụng";
            cmbcl.DataBindings.Clear();
            cmbcl.DataBindings.Add("Text", dgvds.DataSource, "TENCL");
            dgvds.Columns[5].HeaderText = "Chất liệu";
            cmbhd.DataBindings.Clear();
            cmbhd.DataBindings.Add("Text", dgvds.DataSource, "TENHD");
            dgvds.Columns[6].HeaderText = "Hình dạng";
            cmbnd.DataBindings.Clear();
            cmbnd.DataBindings.Add("Text", dgvds.DataSource, "TENDO");
            dgvds.Columns[7].HeaderText = "Nồng độ";
            cmbmau.DataBindings.Clear();
            cmbmau.DataBindings.Add("Text", dgvds.DataSource, "TENM");
            dgvds.Columns[8].HeaderText = "Màu sắc";
            cmbnsx.DataBindings.Clear();
            cmbnsx.DataBindings.Add("Text", dgvds.DataSource, "TENNSX");
            dgvds.Columns[9].HeaderText = "Nước sản xuất";
            txtsl.DataBindings.Clear();
            txtsl.DataBindings.Add("Text", dgvds.DataSource, "SOLUONG");
            dgvds.Columns[10].HeaderText = "Số lượng";
            txtdgn.DataBindings.Clear();
            txtdgn.DataBindings.Add("Text", dgvds.DataSource, "DGNHAP");
            dgvds.Columns[11].HeaderText = "Đơn giá nhập";
            txtdgb.DataBindings.Clear();
            txtdgb.DataBindings.Add("Text", dgvds.DataSource, "DGBAN");
            dgvds.Columns[12].HeaderText = "Đơn giá bán";
            txttgbh.DataBindings.Clear();
            txttgbh.DataBindings.Add("Text", dgvds.DataSource, "THOIGIANBH");
            dgvds.Columns[13].HeaderText = "Thời gian bảo hành";
            txtgc.DataBindings.Clear();
            txtgc.DataBindings.Add("Text", dgvds.DataSource, "GHICHU");
            dgvds.Columns[14].HeaderText = "Ghi chú";
            cmbncc.DataBindings.Clear();
            cmbncc.DataBindings.Add("Text", dgvds.DataSource, "TENNCC");
            dgvds.Columns[15].HeaderText = "Nhà cung cấp";
            try
            {
                pbanhmh.Image = Image.FromFile(Model.ConnectToSql.GetFieldValues("SELECT ANH FROM DMHANGHOA WHERE MAH = '" + dgvds.CurrentRow.Cells[0].Value.ToString() + "'"));
            }
            catch
            {
                pbanhmh.Image = null;
            }
            
        }
        public static string name_Image = "";
        private void btnchonanhmh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|Jpg(*.jpg)|*.jpg|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "C:\\Users\\HongSon\\Desktop\\NET\\QL_BanRuou\\QL_BanRuou\\AnhMh";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                name_Image = dlgOpen.FileName;
                pbanhmh.Image = Image.FromFile(dlgOpen.FileName);
            }
        }

       

        private void cmbtenncc_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dtNCC = new System.Data.DataTable();
            dtNCC = nccCtrl.getData();
            cmbncc.DataSource = dtNCC;
            cmbncc.DisplayMember = "TENNCC";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmDungLuong frDL = new frmDungLuong();
            frDL.ShowDialog();
        }



        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmChatLieu frmChatLieu = new frmChatLieu();
            frmChatLieu.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frmCongDung frmCongDung = new frmCongDung();
            frmCongDung.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            frmDoRuou frmDoRuou = new frmDoRuou();
            frmDoRuou.ShowDialog();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            frmHinhDang frmHinhDang = new frmHinhDang();
            frmHinhDang.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmLoai frmLoai = new frmLoai();
            frmLoai.Show();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            frmMauSac frmMauSac = new frmMauSac();
            frmMauSac.ShowDialog();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            frmNuocSX frmNuocSX = new frmNuocSX();
            frmNuocSX.ShowDialog();
        }

        private void btnthemmh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            txtmamh.Enabled = false;
        }

        private void btnsuamh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtmamh.Enabled = false;
        }

        private void btnluumh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addData(mhObj);
            if (txttenmh.Text == ""||txtdgb.Text == "" || txtdgn.Text == "" || txtgc.Text == "" || txttgbh.Text == "" || txtsl.Text == "" || cmbcd.Text == "" || cmbcl.Text == "" || cmbdl.Text == "" || cmbhd.Text == "" && cmbloai.Text == "" || cmbmau.Text == "" || cmbncc.Text == "" || cmbnd.Text == "" || cmbnsx.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin yêu cầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (flagLuu == 0)
                {
                    if (mhCtrl.addData(mhObj))
                        MessageBox.Show("Thêm thành công thông tin mặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không thêm được thông tin mặt hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (mhCtrl.updData(mhObj))
                        MessageBox.Show("Sửa thành công thông tin mặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không sửa được thông tin mặt hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ucMatHang_Load(sender, e);
                DisEnl(false);
                txtmamh.Enabled = false;
            }
        }

        

        private void btnxoamh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin mặt hàng này", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (mhCtrl.delData(txtmamh.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công thông tin mặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                }

                else
                    MessageBox.Show("Không xóa được thông tin mặt hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ucMatHang_Load(sender, e);
            DisEnl(false);
        }

        private void btnhuymh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ucMatHang_Load(sender, e);
                //clearData();
                DisEnl(false);
                txtmamh.Enabled = false;
            }
            else
                return;
        }

        private void cmbloai_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dtLoai = new DataTable();
            dtLoai = lCtrl.getData();
            cmbloai.DataSource = dtLoai;
            cmbloai.DisplayMember = "TENL";
        }

        private void cmbdl_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dtDl = new DataTable();
            dtDl = dlCtrl.getData();
            cmbdl.DataSource = dtDl;
            cmbdl.DisplayMember = "TENDL";
        }

        private void cmbcd_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dtCd = new DataTable();
            dtCd = cdCtrl.getData();
            cmbcd.DataSource = dtCd;
            cmbcd.DisplayMember = "TENCD";
        }

        private void cmbcl_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dtCl = new DataTable();
            dtCl = clCtrl.getData();
            cmbcl.DataSource = dtCl;
            cmbcl.DisplayMember = "TENCL";
        }

        private void cmbhd_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dtHd = new DataTable();
            dtHd = hdCtrl.getData();
            cmbhd.DataSource = dtHd;
            cmbhd.DisplayMember = "TENHD";
        }

        private void cmbnd_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dtDr = new DataTable();
            dtDr = drCtrl.getData();
            cmbnd.DataSource = dtDr;
            cmbnd.DisplayMember = "TENDO";
        }

        private void cmbmau_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dtMau = new DataTable();
            dtMau = msCtrl.getData();
            cmbmau.DataSource = dtMau;
            cmbmau.DisplayMember = "TENM";
        }

        private void cmbnsx_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dtNsx = new DataTable();
            dtNsx = nsxCtrl.getData();
            cmbnsx.DataSource = dtNsx;
            cmbnsx.DisplayMember = "TENNSX";
        }

        private void dgvds_Click(object sender, EventArgs e)
        {
            try
            {
                pbanhmh.Image = Image.FromFile(Model.ConnectToSql.GetFieldValues("SELECT ANH FROM DMHANGHOA WHERE MAH = '" + dgvds.CurrentRow.Cells[0].Value.ToString() + "'"));
            }
            catch
            {
                pbanhmh.Image = null;
            }
        }
    }
}
