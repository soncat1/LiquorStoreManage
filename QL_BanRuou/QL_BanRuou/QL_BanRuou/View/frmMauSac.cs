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
    public partial class frmMauSac : Form
    {
        MauSacCtrl msCtrl=new  MauSacCtrl();
        MauSacObj  msObj = new MauSacObj();
        MauSacMod  msMod=new MauSacMod();
        int flagLuu=0;
        public frmMauSac()
        {
            InitializeComponent();
        }

        private void frmMauSac_Load(object sender, EventArgs e)
        {
            DataTable dtMs = new DataTable();
            dtMs = msCtrl.getData();
            dgvds.DataSource = dtMs;
            binding();
        }

        private void binding()
        {
            dgvds.Columns[0].HeaderText = "Mã màu";
            txttenm.DataBindings.Clear();
            txttenm.DataBindings.Add("Text", dgvds.DataSource, "TENM");
            dgvds.Columns[1].HeaderText = "Tên màu";
            if (txttenm.Text == "")
                return;
            else
            {
                txtmam.DataBindings.Clear();
                txtmam.DataBindings.Add("Text", dgvds.DataSource, "MAM");
            }
        }
        private void cleardata()
        {
            txtmam.Text = msMod.SinhMaTuDong("MAUSAC", "MAM", "M00");
            txttenm.Text = "";
        }
        private void cleardata1()
        {
            txtmam.Text = "";
            txttenm.Text = "";
        }
        private void addData(MauSacObj ms)
        {
            ms.MaM = txtmam.Text.Trim();
            ms.TenM= txttenm.Text.Trim();
        }
        private void DisEnl(bool e)
        {
            btnthemm.Enabled = !e;
            btnsuam.Enabled = !e;
            btnluum.Enabled = e;
            btnxoam.Enabled = !e;
            btnhuym.Enabled = e;
            txtmam.Enabled = e;
            txttenm.Enabled = e;
        }

        private void btnthemm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 0;
            cleardata();
            DisEnl(true);
            txtmam.Enabled = false;

        }

        private void btnsuam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtmam.Enabled = false;
        }

        private void btnluum_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addData(msObj);
            if (txttenm.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin yêu cầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if(flagLuu==0)
                {
                    if (msCtrl.addData(msObj))
                        MessageBox.Show("Thêm thành công thông tin màu sắc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không thêm được thông tin màu sắc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(msCtrl.updData(msObj))
                        MessageBox.Show("Sửa thành công thông tin màu sắc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không sửa được thông tin màu sắc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmMauSac_Load(sender, e);
                DisEnl(false);
            }
            
        }

        private void btnxoam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin màu sắc này", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            {
                if (msCtrl.delData(txtmam.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công thông tin màu sắc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleardata1();
                }
                else
                    MessageBox.Show("Không xóa được thông tin màu sắc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmMauSac_Load(sender, e);
            DisEnl(false);
        }

        private void btnhuym_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMauSac_Load(sender, e);
                //cleardata1();
                DisEnl(false);
            }
            else
                return;
        }
    }
}
