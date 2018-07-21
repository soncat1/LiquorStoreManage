using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanRuou.Object
{
    class KhachHangObj
    {
        string makh, tenkh, sdt, diachi;

        public string DiaChi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string MaKh
        {
            get
            {
                return makh;
            }

            set
            {
                makh = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public string TenKh
        {
            get
            {
                return tenkh;
            }

            set
            {
                tenkh = value;
            }
        }

        public KhachHangObj(string makh, string tenkh, string sdt, string diachi)
        {
            this.makh = makh;
            this.tenkh = tenkh;            
            this.sdt = sdt;
            this.diachi = diachi;
        }

        public KhachHangObj()
        {
        }
    }
}

