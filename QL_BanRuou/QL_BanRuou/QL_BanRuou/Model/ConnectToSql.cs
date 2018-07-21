using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QL_BanRuou.Model
{
    class ConnectToSql
    {
        #region Availible
        public static SqlConnection Conn;
        private SqlCommand _cmd;
        private string StrCon = null;
        private string _error;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public SqlConnection Connection
        {
            get { return Conn; }
        }

        public SqlCommand CMD
        {
            get { return _cmd; }
            set { _cmd = value; }
        }
        #endregion
        #region Contrustor
        public ConnectToSql()
        {
            StrCon = @"Data Source = .\SQLEXPRESS; Initial Catalog = QLBanRuou; Integrated Security=true";
            Conn = new SqlConnection(StrCon);
        }
        #endregion

        #region Methods
        public void fail()
        {
            MessageBox.Show("Không kết nối được tới cơ sở dữ liệu :(");
        }
        public static void opencc()
        {
            if(Conn.State == ConnectionState.Closed)
                Conn.Open();
        }
        public bool OpenConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                fail();
                return false;
            }
            return true;
        }
        public bool CloseConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        public static string GetFieldValues(string sql)//select anh form nhanhvien where ma= giá trị ở dgv
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, ConnectToSql.Conn);
            SqlDataReader reader;
            opencc();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
        #endregion
    }
}
