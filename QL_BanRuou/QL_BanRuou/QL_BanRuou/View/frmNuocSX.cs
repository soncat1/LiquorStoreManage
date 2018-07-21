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
    public partial class frmNuocSX : Form
    {
        NuocSXCtrl nsxCtrl=new NuocSXCtrl();
        NuocSXObj  nsxObj = new NuocSXObj();
        NuocSXMod  nsxMod=new NuocSXMod();
        int flagLuu=0;
        public frmNuocSX()
        {
            InitializeComponent();
        }

        private void frmNuocSX_Load(object sender, EventArgs e)
        {
            DataTable dtNsx = new DataTable();
            dtNsx = nsxCtrl.getData();
            dgvds.DataSource = dtNsx;
            binding();
        }

        private void binding()
        {
            dgvds.Columns[0].HeaderText = "Mã nước sản xuất";
            txttennsx.DataBindings.Clear();
            txttennsx.DataBindings.Add("Text", dgvds.DataSource, "TENNSX");
            dgvds.Columns[1].HeaderText = "Tên nước sản xuất";
            if (txttennsx.Text == "")
                return;
            else
            {
                txtmansx.DataBindings.Clear();
                txtmansx.DataBindings.Add("Text", dgvds.DataSource, "MANSX");
            }

        }
        private void cleardata()
        {
            txtmansx.Text = nsxMod.SinhMaTuDong("NUOCSX", "MANSX", "NSX00");
            txttennsx.Text = "";
        }
        private void cleardata1()
        {
            txtmansx.Text = "";
            txttennsx.Text = "";
        }
        private void addData(NuocSXObj nsx)
        {
            nsx.MaNsx = txtmansx.Text.Trim();
            nsx.TenNsx = txttennsx.Text.Trim();
        }
        private void DisEnl(bool e)
        {
            btnthemnsx.Enabled = !e;
            btnsuansx.Enabled = !e;
            btnluunsx.Enabled = e;
            btnxoansx.Enabled = !e;
            txtmansx.Enabled = e;
            txttennsx.Enabled = e;
            btnhuynsx.Enabled = e;
        }

        private void btnthemnsx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 0;
            cleardata();
            DisEnl(true);
            txtmansx.Enabled = false;
        }

        private void btnsuansx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtmansx.Enabled = false;
        }

        private void btnluunsx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addData(nsxObj);
            if (txttennsx.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin yêu cầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if(flagLuu==0)
                {
                    if (nsxCtrl.addData(nsxObj))
                        MessageBox.Show("Thêm thành công thông tin nước sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không thêm được thông tin nước sản xuất!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(nsxCtrl.updData(nsxObj))
                        MessageBox.Show("Sửa thành công thông tin nước sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không sửa được thông tin nước sản xuất!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmNuocSX_Load(sender, e);
                DisEnl(false);
            }
            
        }

        private void btnxoansx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin nước sản xuất này", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            {
                if (nsxCtrl.delData(txtmansx.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công thông tin nước sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleardata1();
                }
                else
                    MessageBox.Show("Không xóa được thông tin nước sản xuất!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNuocSX_Load(sender, e);
            DisEnl(false);
        }

        private void btnhuynsx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmNuocSX_Load(sender, e);
                //cleardata1();
                DisEnl(false);
            }
            else
                return;
        }
    }
}
