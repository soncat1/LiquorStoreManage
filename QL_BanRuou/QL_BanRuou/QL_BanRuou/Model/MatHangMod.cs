using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QL_BanRuou.Object;
using QL_BanRuou.Controller;
using System.Windows.Forms;

namespace QL_BanRuou.Model
{
    class MatHangMod
    {
        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT DMHANGHOA.MAH, DMHANGHOA.TENH, LOAI.TENL, DUNGLUONG.TENDL, CONGDUNG.TENCD, CHATLIEU.TENCL, HINHDANG.TENHD, DORUOU.TENDO, MAUSAC.TENM, NUOCSX.TENNSX, DMHANGHOA.SOLUONG, DMHANGHOA.DGNHAP, DMHANGHOA.DGBAN, DMHANGHOA.THOIGIANBH, DMHANGHOA.GHICHU, NHACC.TENNCC FROM DMHANGHOA JOIN LOAI ON DMHANGHOA.MAL = LOAI.MAL JOIN DUNGLUONG ON DMHANGHOA.MADL = DUNGLUONG.MADL JOIN CONGDUNG ON DMHANGHOA.MACD = CONGDUNG.MACD JOIN CHATLIEU ON DMHANGHOA.MACL = CHATLIEU.MACL JOIN HINHDANG ON DMHANGHOA.MAHD = HINHDANG.MAHD JOIN DORUOU ON DMHANGHOA.MADO = DORUOU.MADO JOIN MAUSAC ON DMHANGHOA.MAM = MAUSAC.MAM JOIN NUOCSX ON DMHANGHOA.MANSX = NUOCSX.MANSX JOIN NHACC ON DMHANGHOA.MANCC = NHACC.MANCC";
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

        public bool AddData(MatHangObj mhObj)
        {
            //cmd.CommandText = "INSERT INTO DMHANGHOA VALUES ('MH002', N'chivas','L001','DL001','CD001','CL001','HD001','DO001','M001','NSX001','20','10','10','1','a','NCC001','C:\\Users\\HongSon\\Desktop\\NET\\QL_BanRuou\\QL_BanRuou\\AnhNv\\DHS.jpg')";
            cmd.CommandText = "INSERT INTO DMHANGHOA VALUES ('" + mhObj.MaMh + "', N'" + mhObj.TenMh + "', N'" + mhObj.Loai + "', N'" + mhObj.Dl + "', N'" + mhObj.Cd + "', N'" + mhObj.Cl + "', N'" + mhObj.Hd + "',N'" + mhObj.Nd + "', N'" + mhObj.Mau + "', N'" + mhObj.Nsx + "', '" + mhObj.Sl + "', '" + mhObj.Dgn + "', '" + mhObj.Dgb + "', '" + mhObj.Tgbh + "', N'" + mhObj.GhiChu + "','" + mhObj.Ncc + "','"+View.ucMatHang.name_Image+"')";
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
        public bool UpdData(MatHangObj mhObj)
        {
            cmd.CommandText = "UPDATE DMHANGHOA SET TENH = N'" + mhObj.TenMh + "', MAL = N'" + mhObj.Loai + "', MADL = N'" + mhObj.Dl + "', MACD= N'" + mhObj.Cd + "', MACL = N'" + mhObj.Cl + "', MAHD = N'" + mhObj.Hd + "', MADO = N'" + mhObj.Nd + "', MAM = N'" + mhObj.Mau + "', MANSX = '" + mhObj.Nsx + "', SOLUONG = N'" + mhObj.Sl + "', DGNHAP = N'" + mhObj.Dgn + "', DGBAN = N'" + mhObj.Dgb + "', THOIGIANBH = N'" + mhObj.Tgbh + "', GHICHU = N'" + mhObj.GhiChu + "',MANCC = N'" + mhObj.Ncc + "', ANH = '" + View.ucMatHang.name_Image + "' WHERE MAH = '" + mhObj.MaMh + "'";
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
            cmd.CommandText = "DELETE DMHANGHOA WHERE MAH = '" + ma + "'";
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
            MatHangCtrl mhCtrl = new MatHangCtrl();
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
