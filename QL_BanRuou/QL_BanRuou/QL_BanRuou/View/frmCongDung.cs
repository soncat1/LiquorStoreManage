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
    public partial class frmCongDung : Form
    {
        CongDungCtrl cdCtrl = new CongDungCtrl();
        CongDungObj cdObj = new CongDungObj();
        CongDungMod cdMod = new CongDungMod();
        int flagLuu = 0;
        public frmCongDung()
        {
            InitializeComponent();
        }

        private void frmCongDung_Load(object sender, EventArgs e)
        {
            DataTable dtCd = new System.Data.DataTable();
            dtCd = cdCtrl.getData();
            dgvds.DataSource = dtCd;
            binding();
        }

        private void btnsuacd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtmacd.Enabled = false;
        }
        private void binding()
        {
            dgvds.Columns[0].HeaderText = "Mã công dụng";
            txttencd.DataBindings.Clear();
            txttencd.DataBindings.Add("Text", dgvds.DataSource, "TENCD");
            dgvds.Columns[1].HeaderText = "Tên công dụng";
            if (txttencd.Text == "")
                return;
            else
            {
                txtmacd.DataBindings.Clear();
                txtmacd.DataBindings.Add("Text", dgvds.DataSource, "MACD");
            }
        }
        private void clearData()
        {
            txtmacd.Text = cdMod.SinhMaTuDong("CONGDUNG", "MACD", "CD00");
            txttencd.Text = "";
        }
        private void clearData1()
        {
            txtmacd.Text = "";
            txttencd.Text = "";
        }
        private void addData(CongDungObj cd)
        {
            cd.MaCd = txtmacd.Text.Trim();
            cd.TenCd = txttencd.Text.Trim();
        }

        private void DisEnl(bool e)
        {
            btnthemcd.Enabled = !e;
            btnsuacd.Enabled = !e;
            btnxoacd.Enabled = !e;
            btnluucd.Enabled = e;
            btnhuycd.Enabled = e;
            txtmacd.Enabled = e;
            txttencd.Enabled = e;
        }

        private void btnthemcd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            txtmacd.Enabled = false;
        }

        private void btnluucd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addData(cdObj);
            if (txttencd.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin yêu cầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (flagLuu == 0)
                {
                    if (cdCtrl.addData(cdObj))
                        MessageBox.Show("Thêm thành công thông tin công dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không thêm được thông tin công dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cdCtrl.updData(cdObj))
                        MessageBox.Show("Sửa thành công thông tin công dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không sửa được thông tin công dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmCongDung_Load(sender, e);
                DisEnl(false);
            }
            
        }

        private void btnhuycd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmCongDung_Load(sender, e);
                //clearData1();
                DisEnl(false);
            }
            else
                return;
        }

        private void btnxoacd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin công dụng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (cdCtrl.delData(txtmacd.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công thông tin công dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData1();
                }
                else
                    MessageBox.Show("Không xóa được thông tin công dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmCongDung_Load(sender, e);
            DisEnl(false);
        }
    }
}
