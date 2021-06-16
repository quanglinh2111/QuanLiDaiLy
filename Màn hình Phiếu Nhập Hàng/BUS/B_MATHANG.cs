using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class B_MATHANG
    {
        public static DataTable GetAllMatHang()
        {
            return D_MATHANG.getData();
        }
    }
}
