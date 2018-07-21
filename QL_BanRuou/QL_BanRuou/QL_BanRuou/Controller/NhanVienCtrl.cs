using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QL_BanRuou.Model;
using QL_BanRuou.Object;
using System.Data;

namespace QL_BanRuou.Controller
{
    class NhanVienCtrl
    {
        NhanVienMod nvMod = new NhanVienMod();
        public DataTable getData()
        {
            return nvMod.GetData();
        }
        public bool addData(NhanVienObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
        public bool updData(NhanVienObj nvObj)
        {
            return nvMod.UpdData(nvObj);
        }
        public bool delData(String ma)
        {
            return nvMod.DelData(ma);
        }
    }
}
