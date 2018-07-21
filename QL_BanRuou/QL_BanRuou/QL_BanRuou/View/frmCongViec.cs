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
    public partial class frmCongViec : Form
    {
        CongViecCtrl cvCtrl = new CongViecCtrl();
        CongViecObj cvObj = new CongViecObj();
        CongViecMod cvMod = new CongViecMod();
        int flagLuu = 0;
        public frmCongViec()
        {
            InitializeComponent();
        }

        private void frmCongViec_Load(object sender, EventArgs e)
        {
            DataTable dtCv = new System.Data.DataTable();
            dtCv = cvCtrl.getData();
            dgvds.DataSource = dtCv;
            binding();
        }

        private void btnsuacv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtmacv.Enabled = false;
        }
        private void binding()
        {
            dgvds.Columns[0].HeaderText = "Mã công việc";
            txttencv.DataBindings.Clear();
            txttencv.DataBindings.Add("Text", dgvds.DataSource, "TENCV");
            dgvds.Columns[1].HeaderText = "Tên công việc";
            txtmucluong.DataBindings.Clear();
            txtmucluong.DataBindings.Add("Text", dgvds.DataSource, "MUCLUONG");
            dgvds.Columns[2].HeaderText = "Mức lương";
            if (txttencv.Text == "" && txtmucluong.Text=="")
                return;
            else
            {
                txtmacv.DataBindings.Clear();
                txtmacv.DataBindings.Add("Text", dgvds.DataSource, "MACV");
            }
        }
        private void clearData()
        {
            txtmacv.Text = cvMod.SinhMaTuDong("CONGVIEC", "MACV", "CV00");
            txttencv.Text = "";
            txtmucluong.Text = "";
        }
        private void clearData1()
        {
            txtmacv.Text = "";
            txttencv.Text = "";
            txtmucluong.Text = "";
        }
        private void addData(CongViecObj cv)
        {
            cv.MaCv = txtmacv.Text.Trim();
            cv.TenCv = txttencv.Text.Trim();
            cv.MucLuong = int.Parse(txtmucluong.Text);
        }

        private void DisEnl(bool e)
        {
            btnthemcv.Enabled = !e;
            btnsuacv.Enabled = !e;
            btnxoacv.Enabled = !e;
            btnluucv.Enabled = e;
            btnhuycv.Enabled = e;
            txtmacv.Enabled = e;
            txttencv.Enabled = e;
            txtmucluong.Enabled = e;
        }

        private void btnthemcv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            txtmacv.Enabled = false;
        }

        private void btnluucv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addData(cvObj);
            if (txttencv.Text == "" && txtmucluong.Text=="")
                MessageBox.Show("Bạn chưa nhập đủ thông tin yêu cầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (flagLuu == 0)
                {
                    if (cvCtrl.addData(cvObj))
                        MessageBox.Show("Thêm thành công thông tin công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không thêm được thông tin công việc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cvCtrl.updData(cvObj))
                        MessageBox.Show("Sửa thành công thông tin công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không sửa được thông tin công việc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmCongViec_Load(sender, e);
                DisEnl(false);
            }
            
        }

        private void btnhuycv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmCongViec_Load(sender, e);
                //clearData1();
                DisEnl(false);
            }
            else
                return;
        }

        private void btnxoacv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin công việc này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (cvCtrl.delData(txtmacv.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công thông tin công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData1();
                }
                else
                    MessageBox.Show("Không xóa được thông tin công việc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmCongViec_Load(sender, e);
            DisEnl(false);
        }
    }
}
