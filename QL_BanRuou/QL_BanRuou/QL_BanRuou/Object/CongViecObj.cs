using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanRuou.Object
{
    class CongViecObj
    {
        string macv, tencv;
        int mucluong;

       
        public string MaCv
        {
            get
            {
                return macv;
            }

            set
            {
                macv = value;
            }
        }

       
        public string TenCv
        {
            get
            {
                return tencv;
            }

            set
            {
                tencv = value;
            }
        }
        public int MucLuong
        {
            get
            {
                return mucluong;
            }

            set
            {
                mucluong = value;
            }
        }

        public CongViecObj(string macv, string tencv,int mucluong)
        {
            this.macv = macv;
            this.tencv = tencv;
            this.mucluong = mucluong;
        }

        public CongViecObj()
        {
            // TODO: Complete member initialization
        }
    }
}
