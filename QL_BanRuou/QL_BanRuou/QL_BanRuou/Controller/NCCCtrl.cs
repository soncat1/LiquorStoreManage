using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanRuou.Model;
using System.Data;
using System.Data.SqlClient;
using QL_BanRuou.Object;

namespace QL_BanRuou.Controller
{
    class NCCCtrl
    {
        NCCMod nccMod = new NCCMod();
        public DataTable getData()
        {
            return nccMod.GetData();
        }
        public bool addData(NCCObj nccObj)
        {
            return nccMod.AddData(nccObj);
        }
        public bool updData(NCCObj nccObj)
        {
            return nccMod.UpdData(nccObj);
        }
        public bool delData(String ma)
        {
            return nccMod.DelData(ma);
        }        
    }
}
