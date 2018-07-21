using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanRuou.Object
{
    class DungLuongObj
    {
        string madl, tendl;

       
        public string MaDl
        {
            get
            {
                return madl;
            }

            set
            {
                madl = value;
            }
        }

       
        public string TenDl
        {
            get
            {
                return tendl;
            }

            set
            {
                tendl = value;
            }
        }

        public DungLuongObj(string madl, string tendl)
        {
            this.madl = madl;
            this.tendl = tendl;
        }

        public DungLuongObj()
        {
        }
    }
}
