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
namespace QL_BanRuou.View
{
    public partial class ucBieuDo : UserControl
    {
        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();

        public ucBieuDo()
        {
            InitializeComponent();
        }

    }
}
