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
    public class B_BCDOANHSO
    {
        public static int ThemBaoCaoDoanhSo(tblBCDOANHSO bc)
        {
            //lay ma
            DataTable tb = Logic.GetTableByQuery("select * from BCDOANHSO");
            bc.Mabcds = Logic.layma(tb);
            //lấy tổng doanh số
            string str = "select sum(TongTienPhieuXuat) as SoPhieuXuat from PHIEUXUATHANG where MONTH(NgayLapPhieu) =" + bc.Thang + "  and year(NgayLapPhieu) =" + bc.Nam + " group by month(NgayLapPhieu)";
            bc.Tongdoanhso = Logic.GetSumMoney(str);
            //truy vấn xuống data
            D_BCDOANHSO.ThemBaoCaoDoanhSo(bc);
            return bc.Mabcds;
        }
    }
}
