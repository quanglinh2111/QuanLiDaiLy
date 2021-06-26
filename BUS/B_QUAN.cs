
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
    public class B_QUAN
    {
        public static void ThemQuan(tblQUAN q)
        {
            DataTable tb = Logic.GetTableByQuery("select * from QUAN");
            q.MaQuan1 = Logic.layma(tb);
            D_QUAN.ThemQuan(q);

        }

    }
}
