using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class B_CT_PHIEUXUATHANG
    {
        public static DataTable GetAllCTPhieuXuat()
        {
            string str = "select *from CT_PHIEUXUATHANG";
            return D_CT_PHIEUXUATHANG.GetAllCTPhieuXuat(str);

        }
        //them chi tiết phiêu xuât
        public static void ThemChiTietPhieuXuat(tblCT_PHIEUXUATHANG ct)
        {
            DataTable tb = B_CT_PHIEUXUATHANG.GetAllCTPhieuXuat();
            ct.Mactpxh = Logic.layma(tb);
            D_CT_PHIEUXUATHANG.ThemChiTietPhieuXuat(ct);
        }
    }
}
