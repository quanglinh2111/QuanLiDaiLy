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
    public class B_CT_PHIEUNHAPHANG
    {
        public static DataTable GetAllCTPhieuNhap()
        {
            return D_CT_PHIEUNHAPHANG.getData();
            
        }
        public static void ThemChiTietPhieuNhap(tblCT_PHIEUNHAPHANG ct)
        {
            DataTable tb = D_CT_PHIEUNHAPHANG.getData();
            ct.MaCT_PhieuNhapHang1 = Logic.layma(tb);
            D_CT_PHIEUNHAPHANG.ThemChiTietPhieuNhap(ct);
 
        }

        //lay ten cot 
        public static List<string> GetnameCol()
        {
            return dbConnectionData.GetnameCol("MATHANG");
        }
        //lay gia tri cot
        public static DataTable getDatabyquery(string query)
        {

            DataTable dt = dbConnectionData.getDatabyquery(query);
            return dt;
        }

    }
}
