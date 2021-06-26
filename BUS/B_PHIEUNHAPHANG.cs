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
    public class B_PHIEUNHAPHANG
    {
        public static DataTable GetAllPhieuNhap()
        {
            return D_PHIEUNHAPHANG.getData();
        }
        //thêm phiếu nhập
        public static int ThemThongTinPhieuNhap()
        {
            // lấy mã nhaphang
            DataTable tb = D_PHIEUNHAPHANG.getData();
            tblPHIEUNHAPHANG nh = new tblPHIEUNHAPHANG(Logic.layma(tb), DateTime.Now, 0);
            int ma = D_PHIEUNHAPHANG.ThemThongTinPhieuNhap(nh);
            return ma;
        }




    }
}
