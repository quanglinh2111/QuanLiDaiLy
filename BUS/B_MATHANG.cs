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
    public class B_MATHANG
    {
        public static DataTable GetAllMatHang()
        {
            return D_MATHANG.getData();
        }
        public static void ThemMatHang(tblMATHANG mh)

        {
            DataTable tb = Logic.GetTableByQuery("select * from mathang");
            mh.Mamh = Logic.layma(tb);
            D_MATHANG.ThemMatHang(mh);
        }
    }
}
