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
    public class B_CT_PHIEUNHAPHANG
    {
        public static DataTable GetAllCTPhieuNhap()
        {
            return D_CT_PHIEUNHAPHANG.getData();

        }
        //thấy thông tin của ctmathang và thêm vào mã ctmathang
        public static void ThemChiTietPhieuNhap(tblCT_PHIEUNHAPHANG ct)
        {
            DataTable tb = D_CT_PHIEUNHAPHANG.getData();
            ct.MaCT_PhieuNhapHang1 = Logic.layma(tb);
            D_CT_PHIEUNHAPHANG.ThemChiTietPhieuNhap(ct);
        }

        ////lấy tên các column trong 1 table(bảng MatHang) vd: MaMatHang, TenMatHang
        public static List<string> GetnameCol()
        {
            return dbConnectionData.GetnameCol("MATHANG");
        }
        //lay gia tri cot
        public static string getDatabyquery(string query)
        {

            DataTable dt = dbConnectionData.getDatabyquery(query);
            if (dt.Rows.Count == 0) return "";
            DataRow dr = dt.Rows[0];
            return dr[0].ToString();
        }
        //lay bang tu query
        public static DataTable getTablebyquery(string query)
        {

            DataTable dt = dbConnectionData.getDatabyquery(query);
            return dt;
        }
        //tinh tổng tiền
        public static int GetSumMoney(string query)
        {

            DataTable dt = dbConnectionData.getDatabyquery(query);

            int sum = 0;
            int result = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // your index is in i
                if (int.TryParse(dt.Rows[i][0].ToString(), out result))
                    sum += int.Parse(dt.Rows[i][0].ToString());
            }
            return sum;
        }
        //xóa
        public static void XoaChiTietPhieuNhapHang(tblCT_PHIEUNHAPHANG ct)
        {
            string query = "delete from CT_PHIEUNHAPHANG where MaCT_PhieuNhapHang = " + ct.MaCT_PhieuNhapHang1 + "";
            dbConnectionData.ExecuteQuery(query);
        }
        public static void SuaChiTietPhieuNhapHang(tblCT_PHIEUNHAPHANG ct)
        {

            string query = "UPDATE CT_PHIEUNHAPHANG SET MaMatHang = " + ct.MaMatHang1 + ", TenMatHang = '" + ct.TenMatHang1 + "', SoLuong = " + ct.SoLuong1 + ", DonGiaNhap = " + ct.DonGiaNhap1 + "  WHERE MaCT_PhieuNhapHang = " + ct.MaCT_PhieuNhapHang1 + " ";
            dbConnectionData.ExecuteQuery(query);
        }

    }
}
