using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanRuou.Object
{
    class MauSacObj
    {
        string mam, tenm;

       
        public string MaM
        {
            get
            {
                return mam;
            }

            set
            {
                mam = value;
            }
        }

       
        public string TenM
        {
            get
            {
                return tenm;
            }

            set
            {
                tenm = value;
            }
        }

        public MauSacObj(string mam, string tenm)
        {
            this.mam = mam;
            this.tenm = tenm;
        }

        public MauSacObj()
        {
            // TODO: Complete member initialization
        }

    }
}
