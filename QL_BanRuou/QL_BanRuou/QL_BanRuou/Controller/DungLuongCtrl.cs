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
    class DungLuongCtrl
    {
        DungLuongMod dlMod = new DungLuongMod();
        public DataTable getData()
        {
            return dlMod.GetData();
        }
        public bool addData(DungLuongObj dlObj)
        {
            return dlMod.AddData(dlObj);
        }
        public bool updData(DungLuongObj dlObj)
        {
            return dlMod.UpdData(dlObj);
        }
        public bool delData(String ma)
        {
            return dlMod.DelData(ma);
        }
    }
}
