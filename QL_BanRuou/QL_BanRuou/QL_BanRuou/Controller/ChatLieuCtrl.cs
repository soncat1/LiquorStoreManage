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
    class ChatLieuCtrl
    {
        ChatLieuMod clMod = new ChatLieuMod();
        public DataTable getData()
        {
            return clMod.GetData();
        }
        public bool addData(ChatLieuObj clObj)
        {
            return clMod.AddData(clObj);
        }
        public bool updData(ChatLieuObj clObj)
        {
            return clMod.UpdData(clObj);
        }
        public bool delData(String ma)
        {
            return clMod.DelData(ma);
        }
    }
}

