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
    class DoRuouCtrl
    {
        DoRuouMod drMod = new DoRuouMod();
        public DataTable getData()
        {
            return drMod.GetData();
        }
        public bool addData(DoRuouObj drObj)
        {
            return drMod.AddData(drObj);
        }
        public bool updData(DoRuouObj drObj)
        {
            return drMod.UpdData(drObj);
        }
        public bool delData(String ma)
        {
            return drMod.DelData(ma);
        }
    }
}

