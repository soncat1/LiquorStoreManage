﻿using QL_BanRuou.Controller;
using QL_BanRuou.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanRuou.Model
{
    class CongDungMod
    {
        ConnectToSql con =new ConnectToSql();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM CONGDUNG";
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
        public bool AddData(CongDungObj cdObj)
        {
            cmd.CommandText = "INSERT INTO CONGDUNG VALUES ('" + cdObj.MaCd + "',N'" + cdObj.TenCd + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;

            }
            catch(Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
        public bool UpdData(CongDungObj cdObj)
        {
            cmd.CommandText = "UPDATE CONGDUNG SET TENCD=N'" + cdObj.TenCd + "'WHERE MACD='" + cdObj.MaCd + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch(Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
        public bool DelData(String ma)
        {
            cmd.CommandText = "DELETE CONGDUNG WHERE MACD = '" + ma + "'";
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
           CongDungCtrl cdCtrl = new CongDungCtrl();
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
