using QL_BanRuou.Model;
using QL_BanRuou.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanRuou.Controller
{
    class HinhDangCtrl
    {
         HinhDangMod hdMod = new HinhDangMod();
        public DataTable getData()
        {
            return hdMod.GetData();
        }
        public bool addData(HinhDangObj hdObj)
        {
            return hdMod.AddData(hdObj);
        }
        public bool updData(HinhDangObj hdObj)
        {
            return hdMod.UpdData(hdObj);
        }
        public bool delData(String ma)
        {
            return hdMod.DelData(ma);
        }
    }
}

