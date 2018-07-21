using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanRuou.Object
{
    class HinhDangObj
    {
        string mahd, tenhd;

       
        public string MaHd
        {
            get
            {
                return mahd;
            }

            set
            {
                mahd = value;
            }
        }

       
        public string TenHd
        {
            get
            {
                return tenhd;
            }

            set
            {
                tenhd = value;
            }
        }

        public HinhDangObj(string mahd, string tenhd)
        {
            this.mahd = mahd;
            this.tenhd = tenhd;
        }

        public HinhDangObj()
        {
            // TODO: Complete member initialization
        }

    }
}
