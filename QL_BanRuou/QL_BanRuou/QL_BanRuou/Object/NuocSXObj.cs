using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanRuou.Object
{
    class NuocSXObj
    {
        string mansx, tennsx;

       
        public string MaNsx
        {
            get
            {
                return mansx;
            }

            set
            {
                mansx = value;
            }
        }

       
        public string TenNsx
        {
            get
            {
                return tennsx;
            }

            set
            {
                tennsx = value;
            }
        }

        public NuocSXObj(string mansx, string tennsx)
        {
            this.mansx = mansx;
            this.tennsx = tennsx;
        }

        public NuocSXObj()
        {
            // TODO: Complete member initialization
        }

   
    }
}
