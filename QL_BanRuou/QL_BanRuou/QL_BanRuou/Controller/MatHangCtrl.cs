using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QL_BanRuou.Model;
using QL_BanRuou.Object;


namespace QL_BanRuou.Controller
{
    class MatHangCtrl
    {
        MatHangMod mhMod = new MatHangMod();
        public DataTable getData()
        {
            return mhMod.GetData();
        }
        public bool addData(MatHangObj mhObj)
        {
            return mhMod.AddData(mhObj);
        }
        public bool updData(MatHangObj mhObj)
        {
            return mhMod.UpdData(mhObj);
        }
        public bool delData(String ma)
        {
            return mhMod.DelData(ma);
        }
        
    }
}
