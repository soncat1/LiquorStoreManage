using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanRuou.Object
{
    class ChatLieuObj
    {
        string macl, tencl;

       
        public string MaCl
        {
            get
            {
                return macl;
            }

            set
            {
                macl = value;
            }
        }

       
        public string TenCl
        {
            get
            {
                return tencl;
            }

            set
            {
                tencl = value;
            }
        }

        public ChatLieuObj(string macl, string tencl)
        {
            this.macl = macl;
            this.tencl = tencl;
        }

        public ChatLieuObj()
        {
            // TODO: Complete member initialization
        }
      
    
    }
}
