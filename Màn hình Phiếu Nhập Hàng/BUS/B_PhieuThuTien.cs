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
    public class B_PhieuThuTien
    {
        public static DataTable GetAllPhieuThuTien()
        {
            return D_PhieuThuTien.getData();
        }

        public static void TaoPhieuThu(tblPHIEUTHUTIEN pt)
        {
            D_PhieuThuTien.TaoPhieuThuTien(pt);
        }
    }
}
