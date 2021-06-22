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
    public class B_PHIEUXUATHANG
    {
       
        public static DataTable GetAllPhieuXuat()
        {
            string str = "select *from PHIEUXUATHANG";
            return D_CT_PHIEUXUATHANG.GetAllCTPhieuXuat(str);

        }
        //them phieu xuat
        public static void ThemPhieuXuat(tblPHIEUXUATHANG px)
        {           
            D_PHIEUXUATHANG.ThemPhieuXuat(px);
        }
    }
}
