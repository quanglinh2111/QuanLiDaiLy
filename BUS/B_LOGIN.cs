using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class B_LOGIN
    {
        public static DataTable getData()
        {
            return D_LOGIN.getData();
        }
    }
}
