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
    public class B_PhieuNhapHang
    {
        public static DataTable GetAllPhieuNhap()
        {
            return D_PhieuNhapHang.getData();
        }
        public static int ThemThongTinPhieuNhap()
        {
            // lấy mã nhaphang
            DataTable tb = D_PhieuNhapHang.getData();
            tblPHIEUNHAPHANG nh = new tblPHIEUNHAPHANG(Logic.layma(tb), DateTime.Now, 0);
            int ma = D_PhieuNhapHang.ThemThongTinPhieuNhap(nh);
            return ma;
        }


   
      
    }
}
