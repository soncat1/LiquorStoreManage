using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanRuou.Object
{
    class MatHangObj
    {
        string mamh, tenmh, ncc, loai, dl, cd, cl, hd, nd, mau, nsx, sl, dgn, dgb, tgbh, ghichu;

        public string Cd
        {
            get
            {
                return cd;
            }

            set
            {
                cd = value;
            }
        }

        public string Cl
        {
            get
            {
                return cl;
            }

            set
            {
                cl = value;
            }
        }

        public string Dgb
        {
            get
            {
                return dgb;
            }

            set
            {
                dgb = value;
            }
        }

        public string Dgn
        {
            get
            {
                return dgn;
            }

            set
            {
                dgn = value;
            }
        }

        public string Dl
        {
            get
            {
                return dl;
            }

            set
            {
                dl = value;
            }
        }

        public string Hd
        {
            get
            {
                return hd;
            }

            set
            {
                hd = value;
            }
        }

        public string Loai
        {
            get
            {
                return loai;
            }

            set
            {
                loai = value;
            }
        }

        public string MaMh
        {
            get
            {
                return mamh;
            }

            set
            {
                mamh = value;
            }
        }

        public string Mau
        {
            get
            {
                return mau;
            }

            set
            {
                mau = value;
            }
        }

        public string Ncc
        {
            get
            {
                return ncc;
            }

            set
            {
                ncc = value;
            }
        }

        public string Nd
        {
            get
            {
                return nd;
            }

            set
            {
                nd = value;
            }
        }

        public string Nsx
        {
            get
            {
                return nsx;
            }

            set
            {
                nsx = value;
            }
        }

        public string Sl
        {
            get
            {
                return sl;
            }

            set
            {
                sl = value;
            }
        }

        public string TenMh
        {
            get
            {
                return tenmh;
            }

            set
            {
                tenmh = value;
            }
        }

        public string Tgbh
        {
            get
            {
                return tgbh;
            }

            set
            {
                tgbh = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghichu;
            }

            set
            {
                ghichu = value;
            }
        }

        public MatHangObj()
        {

        }
        public MatHangObj(string mamh, string tenmh, string ncc, string loai, string dl, string cd, string cl, string hd, string nd, string mau, string nsx, string sl, string dgn, string dgb, string tgbh, string ghichu)
        {
            this.mamh = mamh;
            this.tenmh = tenmh;
            this.ncc = ncc;
            this.loai = loai;
            this.dl = dl;
            this.cd = cd;
            this.cl = cl;
            this.hd = hd;
            this.nd = nd;
            this.mau = mau;
            this.nsx = nsx;
            this.sl = sl;
            this.dgn = dgn;
            this.dgb = dgb;
            this.tgbh = tgbh;
            this.ghichu = ghichu;
        }
    }
}
