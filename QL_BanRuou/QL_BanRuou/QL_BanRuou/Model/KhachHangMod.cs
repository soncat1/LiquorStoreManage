using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanRuou.Object;
using System.Data;
using System.Data.SqlClient;
using QL_BanRuou.Controller;

namespace QL_BanRuou.Model
{
    class KhachHangMod
    {
        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT MAKH, TENKH, DIACHI, SDT FROM KHACHHANG";
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
        public bool AddData(KhachHangObj khObj)
        {
            cmd.CommandText = "INSERT INTO KHACHHANG VALUES ('" + khObj.MaKh + "', N'" + khObj.TenKh + "', N'" + khObj.DiaChi + "', N'" + khObj.Sdt + "', '" + View.ucKhachHang.name_Image + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
        public bool UpdData(KhachHangObj khObj)
        {
            cmd.CommandText = "UPDATE KHACHHANG SET TENKH = N'" + khObj.TenKh + "', DIACHI = N'" + khObj.DiaChi + "', SDT = '" + khObj.Sdt + "', ANH = '" + View.ucKhachHang.name_Image + "' WHERE MAKH = '" + khObj.MaKh + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
        public bool DelData(String ma)
        {
            cmd.CommandText = "DELETE KHACHHANG WHERE MAKH = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }
            return false;
        }
        public string SinhMaTuDong(string tenbang, string tenma, string MaBatDau)
        {
            KhachHangCtrl nvCtrl = new KhachHangCtrl();
            int id = 0;
            bool dung = false;
            string ma = "";
            DataTable dt = new DataTable();
            while (dung == false)
            {
                dt = CheckID(tenbang, tenma, MaBatDau + id.ToString());

                if (dt.Rows.Count == 0)
                {
                    dung = true;
                }
                else
                {

                    id++;

                    dung = false;

                }
            }
            ma = MaBatDau + id.ToString();
            return ma;
        }
        public DataTable CheckID(string tbl, string matbl, string ma2)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM " + tbl + " WHERE " + matbl + " = N'" + ma2 + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;


            con.OpenConn();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            con.CloseConn();
            return dt;
        }
    }
}
