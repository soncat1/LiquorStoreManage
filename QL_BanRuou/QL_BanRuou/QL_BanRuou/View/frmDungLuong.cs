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
using QL_BanRuou.Controller;
using QL_BanRuou.Object;

namespace QL_BanRuou.View
{
    public partial class frmDungLuong : Form
    {
        DungLuongCtrl dlCtrl = new DungLuongCtrl();
        DungLuongObj dlObj = new DungLuongObj();
        DungLuongMod dlMod = new DungLuongMod();
        int flagLuu = 0;
        public frmDungLuong()
        {
            InitializeComponent();
        }

        private void frmDungLuong_Load(object sender, EventArgs e)
        {
            DataTable dtDl = new System.Data.DataTable();
            dtDl = dlCtrl.getData();
            dgvds.DataSource = dtDl;
            binding();
        }

        private void btnsuadl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtmadl.Enabled = false;
        }
        private void binding()
        {
            dgvds.Columns[0].HeaderText = "Mã dung lượng";
            txttendl.DataBindings.Clear();
            txttendl.DataBindings.Add("Text", dgvds.DataSource, "TENDL");
            dgvds.Columns[1].HeaderText = "Tên dung lượng";
            if (txttendl.Text == "")
                return;
            else
            {
                txtmadl.DataBindings.Clear();
                txtmadl.DataBindings.Add("Text", dgvds.DataSource, "MADL");
            }
        }
        private void clearData()
        {
            txtmadl.Text = dlMod.SinhMaTuDong("DUNGLUONG", "MADL", "DL00");
            txttendl.Text = "";
        }
        private void clearData1()
        {
            txtmadl.Text = "";
            txttendl.Text = "";
        }
        private void addData(DungLuongObj dl)
        {
            dl.MaDl = txtmadl.Text.Trim();
            dl.TenDl = txttendl.Text.Trim();
        }

        private void DisEnl(bool e)
        {
            btnthemdl.Enabled = !e;
            btnsuadl.Enabled = !e;
            btnxoadl.Enabled = !e;
            btnluudl.Enabled = e;
            btnhuydl.Enabled = e;
            txtmadl.Enabled = e;
            txttendl.Enabled = e;
        }

        private void btnthemdl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            txtmadl.Enabled = false;
        }

        private void btnluudl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addData(dlObj);
            if (txttendl.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin yêu cầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (flagLuu == 0)
                {
                    if (dlCtrl.addData(dlObj))
                        MessageBox.Show("Thêm thành công thông tin dung lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không thêm được thông tin dung lượng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (dlCtrl.updData(dlObj))
                        MessageBox.Show("Sửa thành công thông tin dung lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không sửa được thông tin dung lượng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmDungLuong_Load(sender, e);
                DisEnl(false);
            }
            
        }

        private void btnhuydl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmDungLuong_Load(sender, e);
                //clearData1();
                DisEnl(false);
            }
            else
                return;
        }

        private void btnxoadl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin dung lượng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (dlCtrl.delData(txtmadl.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công thông tin dung lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData1();
                }
                else
                    MessageBox.Show("Không xóa được thông tin dung lượng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmDungLuong_Load(sender, e);
            DisEnl(false);
        }
    }
}
