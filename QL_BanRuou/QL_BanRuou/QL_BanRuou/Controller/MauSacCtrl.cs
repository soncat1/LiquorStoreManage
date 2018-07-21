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
    class MauSacCtrl
    {
         MauSacMod msMod = new MauSacMod();
        public DataTable getData()
        {
            return msMod.GetData();
        }
        public bool addData(MauSacObj msObj)
        {
            return msMod.AddData(msObj);
        }
        public bool updData(MauSacObj msObj)
        {
            return msMod.UpdData(msObj);
        }
        public bool delData(String ma)
        {
            return msMod.DelData(ma);
        }
    }
}
