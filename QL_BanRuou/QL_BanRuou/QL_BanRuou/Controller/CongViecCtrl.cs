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
    class CongViecCtrl
    {
        CongViecMod cvMod = new CongViecMod();
        public DataTable getData()
        {
            return cvMod.GetData();
        }
        public bool addData(CongViecObj cvObj)
        {
            return cvMod.AddData(cvObj);
        }
        public bool updData(CongViecObj cvObj)
        {
            return cvMod.UpdData(cvObj);
        }
        public bool delData(String ma)
        {
            return cvMod.DelData(ma);
        }
    }
}
