using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QL_BanRuou.Model
{
    class DATABASE
    {
        String ChuoiKN = @"Data Source=.\SQLEXPRESS;DataBase = QLBanRuou; Integrated Security=true";
        SqlConnection conn = null;
        public void KetNoi()
        {
            conn = new SqlConnection(ChuoiKN);
            conn.Open();
        }
        public void DongKetNoi()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataTable DocDuLieu(String sql)
        {
            KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            DongKetNoi();
            return tbl;
        }
        public int CapNhatDuLieu(String sql)
        {
            int DongAH;
            KetNoi();
            SqlCommand cmd = new SqlCommand(sql, conn);
            DongAH = cmd.ExecuteNonQuery();
            DongKetNoi();
            return DongAH;
        }
        public object TuyBien(String sql)
        {
            System.Object var;
            KetNoi();
            SqlCommand cmd = new SqlCommand(sql, conn);
            var = cmd.ExecuteScalar();
            DongKetNoi();
            return var;
        }

 
    }
}
