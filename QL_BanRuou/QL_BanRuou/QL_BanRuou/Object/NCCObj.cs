using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanRuou.Object
{
    class NCCObj
    {
        string mancc, tenncc, diachi, sdt;

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

        public string MaNCC
        {
            get
            {
                return mancc;
            }

            set
            {
                mancc = value;
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

        public string TenNCC
        {
            get
            {
                return tenncc;
            }

            set
            {
                tenncc = value;
            }
        }


        public NCCObj()
        {

        }
        public NCCObj(string mancc, string tenncc, string sdt, string diachi)
        {

            this.mancc = mancc;
            this.tenncc = tenncc;
            this.sdt = sdt;
            this.diachi = diachi;
        }
    }
}
