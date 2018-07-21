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
    public partial class frmNhaCC : Form
    {
        NCCCtrl nccCtr = new NCCCtrl();
        NCCObj nccObj = new NCCObj();
        NCCMod nccMod = new NCCMod();
        int flagLuu = 0;
        public frmNhaCC()
        {
            InitializeComponent();
        }

        private void btnthemncc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            txtmancc.Enabled = false;
        }

        private void btnsuancc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtmancc.Enabled = false;
        }

        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            DataTable dtNCC = new System.Data.DataTable();
            dtNCC = nccCtr.getData();
            dgvds.DataSource = dtNCC;
            binding();
        }
        private void binding()
        {
            dgvds.Columns[0].HeaderText = "Mã nhà cung cấp";
            txttenncc.DataBindings.Clear();
            txttenncc.DataBindings.Add("Text", dgvds.DataSource, "TENNCC");
            dgvds.Columns[1].HeaderText = "Tên nhà cung cấp";
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dgvds.DataSource, "DIACHI");
            dgvds.Columns[2].HeaderText = "Địa chỉ";
            txtsdt.DataBindings.Clear();
            txtsdt.DataBindings.Add("Text", dgvds.DataSource, "SDT");
            dgvds.Columns[3].HeaderText = "Số điện thoại";
            if (txttenncc.Text == "" && txtdiachi.Text == "" && txtsdt.Text == "")
                return;
            else
            {
                txtmancc.DataBindings.Clear();
                txtmancc.DataBindings.Add("Text", dgvds.DataSource, "MANCC");
            }
        }
        private void clearData()
        {
            txtmancc.Text = nccMod.SinhMaTuDong("NHACC", "MANCC", "NCC00");
            txttenncc.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
        }
        private void clearData1()
        {
            txtmancc.Text = "";
            txttenncc.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
        }
        private void addData(NCCObj ncc)
        {
            ncc.MaNCC = txtmancc.Text.Trim();
            ncc.DiaChi = txtdiachi.Text.Trim();
            ncc.Sdt = txtsdt.Text.Trim();
            ncc.TenNCC = txttenncc.Text.Trim();
        }

        private void DisEnl(bool e)
        {
            btnthemncc.Enabled = !e;
            btnsuancc.Enabled = !e;
            btnxoancc.Enabled = !e;
            btnluuncc.Enabled = e;
            btnhuyncc.Enabled = e;
            txtmancc.Enabled = e;
            txttenncc.Enabled = e;
            txtdiachi.Enabled = e;
            txtsdt.Enabled = e;
            txtmancc.Enabled = e;
        }

        private void btnluuncc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addData(nccObj);
            if (txttenncc.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin yêu cầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (flagLuu == 0)
                {
                    if (nccCtr.addData(nccObj))
                        MessageBox.Show("Thêm thành công thông tin nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không thêm được thông tin nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (nccCtr.updData(nccObj))
                        MessageBox.Show("Sửa thành công thông tin nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không sửa được thông tin nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmNhaCC_Load(sender, e);
                DisEnl(false);
            }
        }

        private void btnhuyncc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmNhaCC_Load(sender, e);
                //clearData1();
                DisEnl(false);
            }
            else
                return;
        }

        private void btnxoancc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin nhà cung cấp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nccCtr.delData(txtmancc.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công thông tin nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData1();
                }
                else
                    MessageBox.Show("Không xóa được thông tin nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhaCC_Load(sender, e);
            DisEnl(false);
        }

        private void frmNhaCC_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
