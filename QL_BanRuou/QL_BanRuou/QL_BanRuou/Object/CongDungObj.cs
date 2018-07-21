using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanRuou.Object
{
    class CongDungObj
    {
        string macd, tencd;

       
        public string MaCd
        {
            get
            {
                return macd;
            }

            set
            {
                macd = value;
            }
        }

       
        public string TenCd
        {
            get
            {
                return tencd;
            }

            set
            {
                tencd= value;
            }
        }

        public CongDungObj(string macd, string tencd)
        {
            this.macd = macd;
            this.tencd = tencd;
        }

        public CongDungObj()
        {
            // TODO: Complete member initialization
        }

       
    }
   }

