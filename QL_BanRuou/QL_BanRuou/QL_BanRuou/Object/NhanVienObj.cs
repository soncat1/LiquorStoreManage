using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanRuou.Object
{
    class NhanVienObj
    {
        string manv, tennv, gioitinh, sdt, diachi, macv, anh;

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

        public string GioiTinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

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
        

        public string MaNv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
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

        public string TenNv
        {
            get
            {
                return tennv;
            }

            set
            {
                tennv = value;
            }
        }

        string ngaysinh;
        public string NgaySinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Anh
        {
            get
            {
                return anh;
            }

            set
            {
                anh = value;
            }
        }
        public NhanVienObj()
        {

        }
        public NhanVienObj(string manv, string tennv, string gioitinh, string sdt, string diachi, string macv, string ngaysinh, string anh)
        {
            this.anh = anh;
            this.manv = manv;
            this.tennv = tennv;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.diachi = diachi;
            this.macv = macv;
            this.ngaysinh = ngaysinh;
            
        }
    }
}
