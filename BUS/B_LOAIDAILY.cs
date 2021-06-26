using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class B_LOAIDAILY
    {
        public static void ThemLoaiDaiLy(tblLOAIDAILY ldl)
        {
            DataTable tb = Logic.GetTableByQuery("select * from LOAIDAILY");
            ldl.MaLoaiDaiLy1 = Logic.layma(tb);
            D_LOAIDAILY.ThemLoaiDaiLy(ldl);

        }

    }
}
