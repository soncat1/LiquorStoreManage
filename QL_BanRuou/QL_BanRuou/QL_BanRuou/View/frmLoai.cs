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
    public partial class frmLoai : Form
    {
        LoaiCtrl lCtrl=new LoaiCtrl();
        LoaiObj  lObj = new LoaiObj();
        LoaiMod  lMod=new LoaiMod();
        int flagLuu=0;
        public frmLoai()
        {
            InitializeComponent();
        }

        private void frmLoai_Load(object sender, EventArgs e)
        {
            DataTable dtL = new DataTable();
            dtL = lCtrl.getData();
            dgvds.DataSource = dtL;
            binding();
        }

        private void binding()
        {
            dgvds.Columns[0].HeaderText = "Mã loại";
            txttenl.DataBindings.Clear();
            txttenl.DataBindings.Add("Text", dgvds.DataSource, "TENL");
            dgvds.Columns[1].HeaderText = "Tên loại";
            if (txttenl.Text == "")
                return;
            else
            {
                txtmal.DataBindings.Clear();
                txtmal.DataBindings.Add("Text", dgvds.DataSource, "MAL");
            }

        }
        private void cleardata()
        {
            txtmal.Text = lMod.SinhMaTuDong("LOAI", "MAL", "L00");
            txttenl.Text = "";
        }
        private void cleardata1()
        {
            txtmal.Text = "";
            txttenl.Text = "";
        }
        private void addData(LoaiObj l)
        {
            l.MaL = txtmal.Text.Trim();
            l.TenL = txttenl.Text.Trim();
        }
        private void DisEnl(bool e)
        {
            btntheml.Enabled = !e;
            btnsual.Enabled = !e;
            btnluul.Enabled = e;
            btnxoal.Enabled = !e;
            txtmal.Enabled = e;
            txttenl.Enabled = e;
            btnhuyl.Enabled = e;
        }

        private void btntheml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 0;
            cleardata();
            DisEnl(true);
            txtmal.Enabled = false;

        }

        private void btnsual_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtmal.Enabled = false;
        }

        private void btnluul_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addData(lObj);
            if (txttenl.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin yêu cầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if(flagLuu==0)
                {
                    if (lCtrl.addData(lObj))
                        MessageBox.Show("Thêm thành công thông tin loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không thêm được thông tin loại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(lCtrl.updData(lObj))
                        MessageBox.Show("Sửa thành công thông tin loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không sửa được thông tin loại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmLoai_Load(sender, e);
                DisEnl(false);
            }
            
        }

        private void btnxoal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin loại này", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            {
                if (lCtrl.delData(txtmal.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công thông tin loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleardata1();
                }
                else
                    MessageBox.Show("Không xóa được thông tin loại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmLoai_Load(sender, e);
            DisEnl(false);
        }

        private void btnhuycl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmLoai_Load(sender, e);
                //cleardata1();
                DisEnl(false);
            }
            else
                return;
        }
    }
}
