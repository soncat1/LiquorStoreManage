using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QL_BanRuou.Object;
using QL_BanRuou.Controller;

namespace QL_BanRuou.Model
{
    class NhanVienMod
    {
        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT NHANVIEN.MANV, NHANVIEN.TENNV, NHANVIEN.GIOITINH, NHANVIEN.NGAYSINH, NHANVIEN.SDT, NHANVIEN.DIACHI, CONGVIEC.TENCV FROM NHANVIEN JOIN CONGVIEC ON NHANVIEN.MACV = CONGVIEC.MACV ";
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
        
        public bool AddData(NhanVienObj nvObj)
        {
            cmd.CommandText = "INSERT INTO NHANVIEN VALUES ('" + nvObj.MaNv + "', N'" + nvObj.TenNv + "', N'" + nvObj.GioiTinh + "', CONVERT(DATE, '" + nvObj.NgaySinh + "', 103), '" + nvObj.Sdt + "', N'" + nvObj.DiaChi + "', N'" + nvObj.MaCv +"', '" + View.ucNhanVien.name_Image + "')";
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
        public bool UpdData(NhanVienObj nvObj)
        {
            cmd.CommandText = "UPDATE NHANVIEN SET TENNV = N'" + nvObj.TenNv + "', GIOITINH = N'" + nvObj.GioiTinh + "', NGAYSINH = CONVERT(DATE, '" + nvObj.NgaySinh + "', 103), SDT = '" + nvObj.Sdt + "', DIACHI = N'" + nvObj.DiaChi + "',MACV = N'" + nvObj.MaCv + "', ANH = '" + View.ucNhanVien.name_Image + "' WHERE MANV = '" + nvObj.MaNv + "'";
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
            cmd.CommandText = "DELETE NHANVIEN WHERE MANV = '" + ma + "'";
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
        public string SinhMaTuDong(string tenbang ,string tenma,string MaBatDau)
        {
            NhanVienCtrl nvCtrl = new NhanVienCtrl();
            int id = 0;
            bool dung = false;
            string ma = "";
            DataTable dt = new DataTable();
            while (dung == false)
            {   
                dt = CheckID(tenbang, tenma, MaBatDau+id.ToString()) ;
                
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
        public DataTable CheckID(string tbl, string matbl,string ma2)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM " + tbl + " WHERE "+matbl+" = N'"+ma2+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
           
            
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            return dt;
        }
    }
    
   // NhanVienCtrl nvCtrl = new NhanVienCtrl();

}
