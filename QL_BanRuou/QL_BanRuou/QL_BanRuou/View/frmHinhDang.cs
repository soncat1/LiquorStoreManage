using QL_BanRuou.Controller;
using QL_BanRuou.Model;
using QL_BanRuou.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanRuou.View
{
       public partial class frmHinhDang : Form
    {
        HinhDangCtrl hdCtrl = new HinhDangCtrl();
        HinhDangObj hdObj = new HinhDangObj();
        HinhDangMod hdMod = new HinhDangMod();
        int flagLuu = 0;
        public frmHinhDang()
        {
            InitializeComponent();
        }

        private void frmHinhDang_Load(object sender, EventArgs e)
        {
            DataTable dtHd = new System.Data.DataTable();
            dtHd = hdCtrl.getData();
            dgvds.DataSource = dtHd;
            binding();
        }

        private void btnsuahd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtmahd.Enabled = false;
        }
        private void binding()
        {
            dgvds.Columns[0].HeaderText = "Mã hình dạng";
            txttenhd.DataBindings.Clear();
            txttenhd.DataBindings.Add("Text", dgvds.DataSource, "TENHD");
            dgvds.Columns[1].HeaderText = "Tên hình dạng";
            if (txttenhd.Text == "")
                return;
            else
            {
                txtmahd.DataBindings.Clear();
                txtmahd.DataBindings.Add("Text", dgvds.DataSource, "MAHD");
            }
        }
        private void clearData()
        {
            txtmahd.Text = hdMod.SinhMaTuDong("HINHDANG", "MAHD", "HD00");
            txttenhd.Text = "";
        }
        private void clearData1()
        {
            txtmahd.Text = "";
            txttenhd.Text = "";
        }
        private void addData(HinhDangObj hd)
        {
            hd.MaHd = txtmahd.Text.Trim();
            hd.TenHd = txttenhd.Text.Trim();
        }

        private void DisEnl(bool e)
        {
            btnthemhd.Enabled = !e;
            btnsuahd.Enabled = !e;
            btnxoahd.Enabled = !e;
            btnluuhd.Enabled = e;
            btnhuyhd.Enabled = e;
            txtmahd.Enabled = e;
            txttenhd.Enabled = e;
        }

        private void btnthemhd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            txtmahd.Enabled = false;
        }

        private void btnluuhd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addData(hdObj);
            if (txttenhd.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin yêu cầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (flagLuu == 0)
                {
                    if (hdCtrl.addData(hdObj))
                        MessageBox.Show("Thêm thành công thông tin hình dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không thêm được thông tin hình dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (hdCtrl.updData(hdObj))
                        MessageBox.Show("Sửa thành công thông tin hình dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không sửa được thông tin hình dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmHinhDang_Load(sender, e);
                DisEnl(false);
            }
            
        }

        private void btnhuyhd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmHinhDang_Load(sender, e);
                //clearData1();
                DisEnl(false);
            }
            else
                return;
        }

        private void btnxoahd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin hình dạng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hdCtrl.delData(txtmahd.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công thông tin hình dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData1();
                }
                else
                    MessageBox.Show("Không xóa được thông tin hình dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmHinhDang_Load(sender, e);
            DisEnl(false);
        }
    }
}
