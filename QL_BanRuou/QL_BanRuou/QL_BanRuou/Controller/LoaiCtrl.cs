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
    class LoaiCtrl
    {
        LoaiMod lMod = new LoaiMod();
        public DataTable getData()
        {
            return lMod.GetData();
        }
        public bool addData(LoaiObj lObj)
        {
            return lMod.AddData(lObj);
        }
        public bool updData(LoaiObj lObj)
        {
            return lMod.UpdData(lObj);
        }
        public bool delData(String ma)
        {
            return lMod.DelData(ma);
        }
    }
}
