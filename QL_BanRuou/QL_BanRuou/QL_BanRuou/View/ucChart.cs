using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanRuou.Model;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
namespace QL_BanRuou.View
{
    public partial class ucChart : UserControl
    {
        public ucChart()
        {
            InitializeComponent();
        }
        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();

        private void ucChart_Load(object sender, EventArgs e)
        {
            cmbquy.Enabled = false;
            cmbthang.Enabled = false;
            cmbthang.Items.Add("1");
            cmbthang.Items.Add("2");
            cmbthang.Items.Add("3");
            cmbthang.Items.Add("4");
            cmbthang.Items.Add("5");
            cmbthang.Items.Add("6");
            cmbthang.Items.Add("7");
            cmbthang.Items.Add("8");
            cmbthang.Items.Add("9");
            cmbthang.Items.Add("10");
            cmbthang.Items.Add("11");
            cmbthang.Items.Add("12");
            cmbquy.Items.Add("1");
            cmbquy.Items.Add("2");
            cmbquy.Items.Add("3");
            cmbquy.Items.Add("4");
        }
        public DataTable getNam()
        {

            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT year(ngayban) as ngayban from HOADONBAN group by year(ngayban)";
            //cmd = new SqlCommand(cmd.CommandText, con.Connection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //da.Dispose();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public DataTable LoadThang()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT CHITIETHDB.MAH,TENH,CHITIETHDB.SOLUONG,SUM(THANHTIEN) as 'TONGTIEN',SUM((DMHANGHOA.DGBAN - DMHANGHOA.DGNHAP)*CHITIETHDB.SOLUONG) as 'LÃI'  FROM CHITIETHDB JOIN DMHANGHOA ON CHITIETHDB.MAH = DMHANGHOA.MAH WHERE MAHDB IN(SELECT MAHDB FROM HOADONBAN WHERE YEAR(NGAYBAN) = '" + cmbnam.Text + "' AND MONTH(NGAYBAN) = '" + cmbthang.Text + "') GROUP BY CHITIETHDB.MAH,TENH,CHITIETHDB.SOLUONG ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public DataTable LoadQuy()
        {
            int x1, x2, x3, quy;
            quy = Convert.ToInt32(cmbquy.Text);
            if (quy == 1)
            {
                x1 = 1;
                x2 = 2;
                x3 = 3;
            }
            else if (quy == 2)
            {
                x1 = 4;
                x2 = 5;
                x3 = 6;
            }
            else if (quy == 3)
            {
                x1 = 7;
                x2 = 8;
                x3 = 9;
            }
            else
            {
                x1 = 10;
                x2 = 11;
                x3 = 12;
            }
            DataTable dtQuy = new DataTable();
            cmd.CommandText = "SELECT CHITIETHDB.MAH,TENH,CHITIETHDB.SOLUONG, SUM(THANHTIEN) AS 'TONGTIEN',SUM((DMHANGHOA.DGBAN - DMHANGHOA.DGNHAP)*CHITIETHDB.SOLUONG) as 'LÃI' FROM CHITIETHDB JOIN DMHANGHOA ON CHITIETHDB.MAH=DMHANGHOA.MAH WHERE MAHDB IN(SELECT MAHDB FROM HOADONBAN WHERE YEAR(NGAYBAN)='" + cmbnam.Text + "' AND (MONTH(NGAYBAN)='" + x1.ToString() + "' OR  MONTH(NGAYBAN)='" + x2.ToString() + "' OR MONTH(NGAYBAN)='" + x3.ToString() + "')) GROUP BY CHITIETHDB.MAH,TENH,CHITIETHDB.SOLUONG";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtQuy);
                con.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dtQuy;
        }
        private DataTable LoadNam()
        {
            DataTable dtNam = new DataTable();
            cmd.CommandText = "SELECT CHITIETHDB.MAH,MONTH(HOADONBAN.NGAYBAN) AS 'THANG',TENH,CHITIETHDB.SOLUONG, SUM(THANHTIEN) AS 'TONGTIEN',SUM((DMHANGHOA.DGBAN - DMHANGHOA.DGNHAP)*CHITIETHDB.SOLUONG) as 'LÃI' FROM CHITIETHDB JOIN DMHANGHOA ON CHITIETHDB.MAH=DMHANGHOA.MAH JOIN HOADONBAN ON HOADONBAN.MAHDB=CHITIETHDB.MAHDB WHERE CHITIETHDB.MAHDB IN(SELECT MAHDB FROM HOADONBAN WHERE YEAR(NGAYBAN)='" + cmbnam.Text + "' ) GROUP BY HOADONBAN.NGAYBAN,CHITIETHDB.MAH,TENH,CHITIETHDB.SOLUONG";
            //cmd.CommandText = "SELECT CHITIETHDB.MAH,TENH,CHITIETHDB.SOLUONG, SUM(THANHTIEN) AS 'TONGTIEN',SUM((DMHANGHOA.DGBAN - DMHANGHOA.DGNHAP)*CHITIETHDB.SOLUONG) as 'LÃI' FROM CHITIETHDB JOIN DMHANGHOA ON CHITIETHDB.MAH=DMHANGHOA.MAH WHERE MAHDB IN(SELECT MAHDB FROM HOADONBAN WHERE YEAR(NGAYBAN)='" + cmbnam.Text + "' ) GROUP BY CHITIETHDB.MAH,TENH,CHITIETHDB.SOLUONG";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtNam);
                con.CloseConn();

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dtNam;
        }

        private void cmbquy_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtQuy = new DataTable();
            dtQuy = LoadQuy();
            chart1.DataSource = dtQuy;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mặt hàng";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tổng tiền";
            chart1.Series["doanh thu hàng"].XValueMember = "MAH";
            chart1.Series["doanh thu hàng"].YValueMembers = "TONGTIEN";
            chart1.Series["doanh thu hàng"].ChartType = SeriesChartType.Column;
  

        }
        private void cmbnam_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dtNam = new DataTable();
            dtNam = getNam();

            cmbnam.DataSource = dtNam;
            cmbnam.DisplayMember = "Ngayban";
        }

        private void rdoQuy_Click(object sender, EventArgs e)
        {
            rdoThang.Enabled = false;
            cmbquy.Enabled = true;
            cmbthang.Enabled = false;
        }

        private void rdoThang_Click(object sender, EventArgs e)
        {
            rdoQuy.Enabled = false;
            cmbthang.Enabled = true;
            cmbquy.Enabled = false;
        }

        private void cmbthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtThang = new DataTable();
            dtThang = LoadThang();
            chart1.DataSource = dtThang;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mặt hàng";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tổng tiền";
            chart1.Series["doanh thu hàng"].XValueMember = "MAH";
            chart1.Series["doanh thu hàng"].YValueMembers = "TONGTIEN";
        }
        private void cmbnam_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtNam = new DataTable();
            dtNam = LoadNam();
            if (rdoThang.Checked == false && rdoQuy.Checked == false)
            {
                chart1.DataSource = dtNam;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mặt hàng";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tổng tiền";
                chart1.Series["doanh thu hàng"].XValueMember = "THANG";
                chart1.Series["doanh thu hàng"].YValueMembers = "TONGTIEN";
            }


        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            rdoQuy.Enabled = true;
            rdoThang.Enabled = true;
            cmbthang.Enabled = false;
            cmbquy.Enabled = false;
            cmbthang.ResetText();
            cmbnam.ResetText();
            cmbquy.ResetText();
            rdoQuy.Checked = false;
            rdoThang.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

    }
}
