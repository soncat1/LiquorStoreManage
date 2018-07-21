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
    class CongDungCtrl
    {
         CongDungMod cdMod = new CongDungMod();
        public DataTable getData()
        {
            return cdMod.GetData();
        }
        public bool addData(CongDungObj cdObj)
        {
            return cdMod.AddData(cdObj);
        }
        public bool updData(CongDungObj cdObj)
        {
            return cdMod.UpdData(cdObj);
        }
        public bool delData(String ma)
        {
            return cdMod.DelData(ma);
        }
    }
    }

