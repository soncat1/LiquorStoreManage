using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QL_BanRuou.Model;



namespace QL_BanRuou.View
{
    public partial class ucDoanhThu : UserControl
    {
        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();
        public ucDoanhThu()
        {
            InitializeComponent();
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
            DataTable dt= new DataTable();
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
            catch(Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        private void rdo1_Click(object sender, EventArgs e)
        {
            rdo2.Enabled = false;
            cmbthang.Enabled = true;
            cmbquy.Enabled = false;

        }

        private void ucDoanhThu_Load(object sender, EventArgs e)
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


        private void cmbnam_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dtNam = new DataTable();
            dtNam = getNam();
           
            cmbnam.DataSource = dtNam;
            cmbnam.DisplayMember = "Ngayban";
        }

        private void cmbthang_MouseClick(object sender, MouseEventArgs e)
        {
            //DataTable dtThang = new DataTable();
            //dtThang = LoadThang();
            //dgvds.DataSource = dtThang;
            //binding();
            
        }
        private void binding()
        {
            dgvds.Columns[0].HeaderText = "Mã hàng";
            dgvds.Columns[1].HeaderText = "Tên hàng";
            dgvds.Columns[2].HeaderText = "Số lượng";
            dgvds.Columns[3].HeaderText = "Tổng tiền";
            dgvds.Columns[4].HeaderText = "Lãi";
        }

        private void cmbthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtThang = new DataTable();
            dtThang = LoadThang();
            dgvds.DataSource = dtThang;
            binding();
            
        }
        public DataTable LoadQuy()
        {
            int x1,x2,x3,quy;
            quy=Convert.ToInt32(cmbquy.Text);
            if(quy==1)
            {
                x1=1;
                x2=2;
                x3=3;
            }
            else if(quy==2)
            {
                x1=4;
                x2=5;
                x3=6;
            }
            else if(quy==3)
            {
                x1=7;
                x2=8;
                x3=9;
            }
            else
            {
                x1=10;
                x2=11;
                x3=12;
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
            catch(Exception ex)
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
            cmd.CommandText = "SELECT CHITIETHDB.MAH,TENH,CHITIETHDB.SOLUONG, SUM(THANHTIEN) AS 'TONGTIEN',SUM((DMHANGHOA.DGBAN - DMHANGHOA.DGNHAP)*CHITIETHDB.SOLUONG) as 'LÃI' FROM CHITIETHDB JOIN DMHANGHOA ON CHITIETHDB.MAH=DMHANGHOA.MAH WHERE MAHDB IN(SELECT MAHDB FROM HOADONBAN WHERE YEAR(NGAYBAN)='" + cmbnam.Text + "' ) GROUP BY CHITIETHDB.MAH,TENH,CHITIETHDB.SOLUONG";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtNam);
                con.CloseConn();

            }
            catch(Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dtNam;
        }

        private void rdo2_Click(object sender, EventArgs e)
        {
            rdo1.Enabled = false;
            cmbthang.Enabled = false;
            cmbquy.Enabled = true;

        }

        private void cmbquy_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtQuy = new DataTable();
            dtQuy = LoadQuy();
            dgvds.DataSource = dtQuy;
            binding();
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            rdo1.Enabled = true;
            rdo2.Enabled = true;
            cmbthang.Enabled = false;
            cmbquy.Enabled = false;
            cmbthang.ResetText();
            cmbnam.ResetText();
            cmbquy.ResetText();
            rdo1.Checked = false;
            rdo2.Checked = false;
            

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void btnindt_Click(object sender, EventArgs e)
        {
            if(dgvds.Rows.Count>0)
            {
                SaveFileDialog file = new SaveFileDialog();
                Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook exBook = exApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet exSheet = (Microsoft.Office.Interop.Excel.Worksheet)exBook.Worksheets[1];
                Microsoft.Office.Interop.Excel.Range tenTruong = (Microsoft.Office.Interop.Excel.Range)exSheet.Cells[1, 1];
                //Dua du lieu vao excel
                tenTruong.Range["A1:D1"].MergeCells = true;
                tenTruong.Range["A1"].Value = "Cửa Hàng Rượu Chivas 25";
                tenTruong.Range["A1"].Font.Size = 12;
                tenTruong.Range["A1"].Font.Bold = true;
                tenTruong.Range["A1"].Font.Color = Color.Red;
                tenTruong.Range["A2"].Value = "Địa chỉ: Xuân Diệu - Hà Nội";
                tenTruong.Range["A2"].Font.Size = 12;
                tenTruong.Range["A2"].Font.Bold = true;
                tenTruong.Range["A2"].Font.Color = Color.Green;
                tenTruong.Range["A3"].Value = "Điện thoại: 0964895108";
                tenTruong.Range["A3"].Font.Size = 12;
                tenTruong.Range["A3"].Font.Bold = true;
                tenTruong.Range["A3"].Font.Color = Color.Green;
                tenTruong.Range["C5:f5"].MergeCells = true;
                tenTruong.Range["C5:F5"].Font.Size = 18;
                tenTruong.Range["C5:F5"].Font.Color = Color.Red;
                tenTruong.Range["C5"].Value = "Doanh thu cửa hàng";       
                tenTruong.Range["A8"].Value = "STT ";
                tenTruong.Range["B8"].Value = "Mã hàng ";
                tenTruong.Range["B8"].ColumnWidth = 20;
                tenTruong.Range["C8"].Value = "Tên hàng ";
                tenTruong.Range["C8"].ColumnWidth = 20;
                tenTruong.Range["D8"].Value = "Số lượng";
                tenTruong.Range["D8"].ColumnWidth = 15;
                tenTruong.Range["E8"].Value = "Tổng tiền ";
                tenTruong.Range["E8"].ColumnWidth = 15;
                tenTruong.Range["F8"].Value = "Số tiền lãi";
                tenTruong.Range["F8"].ColumnWidth = 15;
                int hang = 8;

                for (int i = 0; i < dgvds.Rows.Count; i++)
                {
                    hang++;
                    tenTruong.Range["A" + hang.ToString()].Value = (i + 1).ToString();
                    tenTruong.Range["B" + hang.ToString()].Value = dgvds.Rows[i].Cells[0].Value.ToString();
                    tenTruong.Range["C" + hang.ToString()].Value = dgvds.Rows[i].Cells[1].Value.ToString();
                    tenTruong.Range["D" + hang.ToString()].Value = dgvds.Rows[i].Cells[2].Value.ToString();
                    tenTruong.Range["E" + hang.ToString()].Value = dgvds.Rows[i].Cells[3].Value.ToString();
                    tenTruong.Range["F" + hang.ToString()].Value = dgvds.Rows[i].Cells[4].Value.ToString();                
                }
                if(rdo1.Checked==true && cmbnam.Text!="")
                {
                    tenTruong.Range["E6"].Value = "Tháng " + cmbthang.Text ;
                    tenTruong.Range["E6"].ColumnWidth = 15;
                    tenTruong.Range["F6"].Value = " Năm " + cmbnam.Text;
                    tenTruong.Range["F6"].ColumnWidth = 15;
                }
                else if(rdo2.Checked==true && cmbnam.Text !="")
                {
                    tenTruong.Range["E6"].Value = "Quý "+ cmbquy.Text;
                    tenTruong.Range["E6"].ColumnWidth = 15;
                    tenTruong.Range["F6"].Value = " Năm " + cmbnam.Text;
                    tenTruong.Range["F6"].ColumnWidth = 15;
                    
                }
                else
                {
                    tenTruong.Range["E6"].Value = "Năm " + cmbnam.Text;
                    tenTruong.Range["E6"].ColumnWidth = 15;
                }
                exSheet.Name = "Doanhthu";
                exBook.Activate();
                if (file.ShowDialog() == DialogResult.OK)
                    exBook.SaveAs(file.FileName.ToString());
                exApp.Quit();

                dgvds.DataSource = null;
            }
            else
            {
                MessageBox.Show("Không có danh sách để in", "Thông báo");
            }
          }

        private void cmbnam_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtNam = new DataTable();
            dtNam = LoadNam();
            if(rdo1.Checked==false && rdo2.Checked==false)
            {
                dgvds.DataSource = dtNam;
                binding();
            }

            
        }

       
    }
}
