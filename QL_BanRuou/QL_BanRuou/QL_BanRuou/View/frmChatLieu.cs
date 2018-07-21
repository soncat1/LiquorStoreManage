using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanRuou.Controller;
using QL_BanRuou.Model;
using QL_BanRuou.Object;

namespace QL_BanRuou.View
{
    public partial class frmChatLieu : Form
    {
        ChatLieuCtrl clCtrl=new ChatLieuCtrl();
        ChatLieuObj  clObj = new ChatLieuObj();
        ChatLieuMod  clMod=new ChatLieuMod();
        int flagLuu=0;
        public frmChatLieu()
        {
            InitializeComponent();
        }

        private void frmChatLieu_Load(object sender, EventArgs e)
        {
            DataTable dtCl = new DataTable();
            dtCl = clCtrl.getData();
            dgvds.DataSource = dtCl;
            binding();
        }

        private void binding()
        {
            dgvds.Columns[0].HeaderText = "Mã chất liệu";
            txttencl.DataBindings.Clear();
            txttencl.DataBindings.Add("Text", dgvds.DataSource, "TENCL");
            dgvds.Columns[1].HeaderText = "Tên chất liệu";
            if (txttencl.Text == "")
                return;
            else
            {
                txtmacl.DataBindings.Clear();
                txtmacl.DataBindings.Add("Text", dgvds.DataSource, "MACL");
            }          
        }
        private void cleardata()
        {
            txtmacl.Text = clMod.SinhMaTuDong("CHATLIEU", "MACL", "CL00");
            txttencl.Text = "";
        }
        private void cleardata1()
        {
            txtmacl.Text = "";
            txttencl.Text = "";
        }
        private void addData(ChatLieuObj cl)
        {
            cl.MaCl = txtmacl.Text.Trim();
            cl.TenCl = txttencl.Text.Trim();
        }
        private void DisEnl(bool e)
        {
            btnthemcl.Enabled = !e;
            btnsuacl.Enabled = !e;
            btnluucl.Enabled = e;
            btnxoacl.Enabled = !e;
            txtmacl.Enabled = e;
            txttencl.Enabled = e;
            btnhuycl.Enabled = e;
        }

        private void btnthemcl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 0;
            cleardata();
            DisEnl(true);
            txtmacl.Enabled = false;

        }

        private void btnsuacl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtmacl.Enabled = false;
        }

        private void btnluucl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addData(clObj);
            if (txttencl.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin yêu cầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if(flagLuu==0)
                {
                    if (clCtrl.addData(clObj))
                        MessageBox.Show("Thêm thành công thông tin chất liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không thêm được thông tin chất liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(clCtrl.updData(clObj))
                        MessageBox.Show("Sửa thành công thông tin chất liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không sửa được thông tin chất liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmChatLieu_Load(sender, e);
                DisEnl(false);
            }
            
        }

        private void btnxoacl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin chất liệu này", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            {
                if(clCtrl.delData(txtmacl.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công thông tin chất liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleardata1();
                }
                    
                else
                    MessageBox.Show("Không xóa được thông tin chất liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmChatLieu_Load(sender, e);
            DisEnl(false);
        }

        private void btnhuycl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmChatLieu_Load(sender, e);
                //cleardata1();
                DisEnl(false);
            }
            else
                return;
        }
    }
}
