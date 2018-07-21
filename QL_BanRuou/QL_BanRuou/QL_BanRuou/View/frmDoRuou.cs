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
    public partial class frmDoRuou : Form
    {
        DoRuouCtrl drCtrl = new DoRuouCtrl();
        DoRuouObj drObj = new DoRuouObj();
        DoRuouMod drMod = new DoRuouMod();
        int flagLuu = 0;
        public frmDoRuou()
        {
            InitializeComponent();
        }

        private void frmDoRuou_Load(object sender, EventArgs e)
        {
            DataTable dtDr = new System.Data.DataTable();
            dtDr = drCtrl.getData();
            dgvds.DataSource = dtDr;
            binding();
        }

        private void btnsuadr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtmadr.Enabled = false;
        }
        private void binding()
        {
            dgvds.Columns[0].HeaderText = "Mã nồng độ";
            txttendr.DataBindings.Clear();
            txttendr.DataBindings.Add("Text", dgvds.DataSource, "TENDO");
            dgvds.Columns[1].HeaderText = "Tên nồng độ";
            if (txttendr.Text == "")
                return;
            else
            {
                txtmadr.DataBindings.Clear();
                txtmadr.DataBindings.Add("Text", dgvds.DataSource, "MADO");
            }
        }
        private void clearData()
        {
            txtmadr.Text = drMod.SinhMaTuDong("DORUOU", "MADO", "DO00");
            txttendr.Text = "";
        }
        private void clearData1()
        {
            txtmadr.Text = "";
            txttendr.Text = "";
        }
        private void addData(DoRuouObj dr)
        {
            dr.MaDo = txtmadr.Text.Trim();
            dr.TenDo = txttendr.Text.Trim();
        }

        private void DisEnl(bool e)
        {
            btnthemdr.Enabled = !e;
            btnsuadr.Enabled = !e;
            btnxoadr.Enabled = !e;
            btnluudr.Enabled = e;
            btnhuydr.Enabled = e;
            txtmadr.Enabled = e;
            txttendr.Enabled = e;
        }

        private void btnthemdr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            txtmadr.Enabled = false;
        }

        private void btnluudr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addData(drObj);
            if (txttendr.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin yêu cầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (flagLuu == 0)
                {
                    if (drCtrl.addData(drObj))
                        MessageBox.Show("Thêm thành công thông tin độ rượu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không thêm được thông tin độ rượu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (drCtrl.updData(drObj))
                        MessageBox.Show("Sửa thành công thông tin độ rượu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không sửa được thông tin độ rượu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmDoRuou_Load(sender, e);
                DisEnl(false);
            }
            
        }

        private void btnhuydr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmDoRuou_Load(sender, e);
                //clearData1();
                DisEnl(false);
            }
            else
                return;
        }

        private void btnxoadr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin độ rượu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (drCtrl.delData(txtmadr.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công thông tin độ rượu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData1();
                }
                else
                    MessageBox.Show("Không xóa được thông tin độ rượu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmDoRuou_Load(sender, e);
            DisEnl(false);
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
