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
    class KhachHangCtrl
    {
        KhachHangMod khMod = new KhachHangMod();
        public DataTable getData()
        {
            return khMod.GetData();
        }
        public bool addData(KhachHangObj khObj)
        {
            return khMod.AddData(khObj);
        }
        public bool updData(KhachHangObj khObj)
        {
            return khMod.UpdData(khObj);
        }
        public bool delData(String ma)
        {
            return khMod.DelData(ma);
        }
    }
}
