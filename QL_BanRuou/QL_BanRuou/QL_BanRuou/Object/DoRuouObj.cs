using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanRuou.Object
{
    class DoRuouObj
    {
        string mado, tendo;

       
        public string MaDo
        {
            get
            {
                return mado;
            }

            set
            {
                mado = value;
            }
        }

       
        public string TenDo
        {
            get
            {
                return tendo;
            }

            set
            {
                tendo = value;
            }
        }

        public DoRuouObj(string mado, string tendo)
        {
            this.mado = mado;
            this.tendo = tendo;
        }

        public DoRuouObj()
        {
            // TODO: Complete member initialization
        }
    }
}
