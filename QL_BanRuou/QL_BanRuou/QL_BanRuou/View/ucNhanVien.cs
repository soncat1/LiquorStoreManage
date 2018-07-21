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
using System.Data.SqlClient;

namespace QL_BanRuou.View
{
    public partial class ucNhanVien : UserControl
    {
        CongViecCtrl cvCtrl = new CongViecCtrl();
        NhanVienCtrl nvCtrl = new NhanVienCtrl();
        NhanVienObj nvObj = new NhanVienObj();
        NhanVienMod nvMod = new NhanVienMod();
        int flagLuu = 0;
        public ucNhanVien()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new System.Data.DataTable();
            dtNhanVien = nvCtrl.getData();
            //dtNhanVien= nvMod.CheckID("NHANVIEN", "MaNV", "NV004");
            dgvds.DataSource = dtNhanVien;
            binding();
        }
        private void binding()
        {
            dgvds.Columns[0].HeaderText = "Mã nhân viên";
            txttennv.DataBindings.Clear();
            txttennv.DataBindings.Add("Text", dgvds.DataSource, "TENNV");
            dgvds.Columns[1].HeaderText = "Tên nhân viên";
            cmbgt.DataBindings.Clear();
            cmbgt.DataBindings.Add("Text", dgvds.DataSource, "GIOITINH");
            dgvds.Columns[2].HeaderText = "Giới tính";
            dtpns.DataBindings.Clear();
            dtpns.DataBindings.Add("Text", dgvds.DataSource, "NGAYSINH");
            dgvds.Columns[3].HeaderText = "Ngày sinh";
            txtsdt.DataBindings.Clear();
            txtsdt.DataBindings.Add("Text", dgvds.DataSource, "SDT");
            dgvds.Columns[4].HeaderText = "Số điện thoại";
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dgvds.DataSource, "DIACHI");
            dgvds.Columns[5].HeaderText = "Địa chỉ";
            cmbmacv.DataBindings.Clear();
            cmbmacv.DataBindings.Add("Text", dgvds.DataSource, "TENCV");
            dgvds.Columns[6].HeaderText = "Tên công việc";
            if (txttennv.Text == "" && txtdiachi.Text == "" && txtsdt.Text == "")
                return;
            else
            {
                txtmanv.DataBindings.Clear();
                txtmanv.DataBindings.Add("Text", dgvds.DataSource, "MANV");
                
            }
            try
            {
                pbanhnv.Image = Image.FromFile(Model.ConnectToSql.GetFieldValues("SELECT ANH FROM NHANVIEN WHERE MANV = '" + dgvds.CurrentRow.Cells[0].Value.ToString() + "'"));
            }
            catch
            {
                pbanhnv.Image = null;
            }
        }
        private void loadCMB()
        {
            cmbgt.Items.Clear();
            cmbgt.Items.Add("Nam");
            cmbgt.Items.Add("Nữ");
        }
        private void clearData()
        {
            
            txtmanv.Text = nvMod.SinhMaTuDong("NHANVIEN","MANV","NV00");
            txttennv.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            dtpns.Value = DateTime.Now.Date;
            pbanhnv.Image = null;
            cmbgt.Text = "Nam";
            loadCMB();          
        }
        private void clearData1()
        {

            txtmanv.Text = "";
            txttennv.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            dtpns.Value = DateTime.Now.Date;
            pbanhnv.Image = null;
        }
        private void addData(NhanVienObj nv)
        {
           
            nv.MaNv = txtmanv.Text.Trim();
            nv.DiaChi = txtdiachi.Text.Trim();
            nv.Sdt = txtsdt.Text.Trim();
            nv.TenNv = txttennv.Text.Trim();
            nv.NgaySinh = dtpns.Text;
            nv.GioiTinh = cmbgt.Text.Trim();
            nv.MaCv = ConnectToSql.GetFieldValues("SELECT MACV FROM CONGVIEC WHERE TENCV = N'" + cmbmacv.Text + "'");

        }

        private void DisEnl(bool e)
        {
            btnthemnv.Enabled = !e;
            btnsuanv.Enabled = !e;
            btnxoanv.Enabled = !e;
            btnluunv.Enabled = e;
            btnhuynv.Enabled = e;
            txtmanv.Enabled = !e;
            txttennv.Enabled = e;
            txtdiachi.Enabled = e;
            txtsdt.Enabled = e;
            cmbmacv.Enabled = e;
            dtpns.Enabled = e;
            cmbgt.Enabled = e;
            btnchonanhnv.Enabled = e;
            txtmanv.Enabled = e;
        }
        private void btnthemnv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            txtmanv.Enabled = false;
            loadCMB();
            dtpns.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnsuanv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtmanv.Enabled = false;
            loadCMB();
        }

        private void btnxoanv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nvCtrl.delData(txtmanv.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData1();
                }
                else
                    MessageBox.Show("Không xóa được thông tin nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ucNhanVien_Load(sender, e);
            DisEnl(false);
        }

        private void btnluunv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addData(nvObj);
            if (txtmanv.Text == "" || txttennv.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin yêu cầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (flagLuu == 0)
                {
                    if (nvCtrl.addData(nvObj))
                        MessageBox.Show("Thêm thành công thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không thêm được thông tin nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (nvCtrl.updData(nvObj))
                        MessageBox.Show("Sửa thành công thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không sửa được thông tin nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ucNhanVien_Load(sender, e);
                DisEnl(false);
            }            
        }

        private void btnhuynv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ucNhanVien_Load(sender, e);
                clearData1();
                DisEnl(false);
            }
            else
                return;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        public static string name_Image = "";
        private void btnchonanhnv_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|Jpg(*.jpg)|*.jpg|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "C:\\Users\\HongSon\\Desktop\\NET\\QL_BanRuou\\QL_BanRuou\\AnhNv";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn hình ảnh muốn thay đổi";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                name_Image = dlgOpen.FileName;
                pbanhnv.Image = Image.FromFile(dlgOpen.FileName);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmCongViec frmCongViec = new frmCongViec();
            frmCongViec.ShowDialog();
        }

        private void cmbmacv_MouseClick(object sender, EventArgs e)
        {

        }

        private void cmbmacv_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dtCv = new DataTable();
            dtCv = cvCtrl.getData();
            cmbmacv.DataSource = dtCv;
            cmbmacv.DisplayMember = "TENCV";
        }

        private void dgvds_Click(object sender, EventArgs e)
        {
            try
            {
                pbanhnv.Image = Image.FromFile(Model.ConnectToSql.GetFieldValues("SELECT ANH FROM NHANVIEN WHERE MANV = '" + dgvds.CurrentRow.Cells[0].Value.ToString() + "'"));
            }
            catch
            {
                pbanhnv.Image = null;
            }
        }
    }
}
