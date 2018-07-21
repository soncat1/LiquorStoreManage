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
    class NuocSXCtrl
    {
        NuocSXMod nsxMod = new NuocSXMod();
        public DataTable getData()
        {
            return nsxMod.GetData();
        }
        public bool addData(NuocSXObj nsxObj)
        {
            return nsxMod.AddData(nsxObj);
        }
        public bool updData(NuocSXObj nsxObj)
        {
            return nsxMod.UpdData(nsxObj);
        }
        public bool delData(String ma)
        {
            return nsxMod.DelData(ma);
        }
    }

}
