using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanRuou.Object
{
    class LoaiObj
    {
        string mal, tenl;
 
        public string MaL
        {
            get
            {
                return mal;
            }

            set
            {
                mal = value;
            }
        }

       
        public string TenL
        {
            get
            {
                return tenl;
            }

            set
            {
                tenl = value;
            }
        }

        public LoaiObj(string mal, string tenl)
        {
            this.mal = mal;
            this.tenl = tenl;
        }

        public LoaiObj()
        {
            // TODO: Complete member initialization
        }

    }
  }

