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
    public class B_BCCONGNO
    {
        public static int ThemBaoCaoCongNo(tblBCCONGNO bc)
        {
            //lay ma
            DataTable tb = Logic.GetTableByQuery("select * from BCCONGNO");
            bc.Mabc = Logic.layma(tb);
            //truy vấn xuống data
            D_BCCONGNO.ThemBaoCaoCongNo(bc);
            return bc.Mabc;
        }

    }
}
