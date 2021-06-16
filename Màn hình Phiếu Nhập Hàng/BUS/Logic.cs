using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Logic
    {
        public static int layma(DataTable tb)
        {

            int ma = 1;
            foreach (DataRow row in tb.Rows)
            {
                ma += 1;
            }
            return ma;
        }
        // tự động nhập mã khi nhập tên măt hàng
        

    }

   
}
