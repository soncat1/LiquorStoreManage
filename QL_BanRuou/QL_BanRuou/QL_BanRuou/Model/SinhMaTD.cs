using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QL_BanRuou.Model;

namespace QL_BanRuou.Model
{
    class SinhMaTD
    {
        DATABASE db = new DATABASE();
        public string SinhMaTuDong(string TenBang, string MaBatDau, string TruongMa)
        {
            int id = 0;
            bool dung = false;
            string ma = "";
            DataTable dm = new DataTable();
            while (dung == false)
            {
                dm = db.DocDuLieu("Select * from " + TenBang + " where " + TruongMa + "='" + MaBatDau + id.ToString() + "'");
                if (dm.Rows.Count == 0)
                {
                    dung = true;
                }
                else
                {
                    id++;
                    dung = false;
                }
            }
            ma = MaBatDau + id.ToString();
            return ma;
        }
    }
}
