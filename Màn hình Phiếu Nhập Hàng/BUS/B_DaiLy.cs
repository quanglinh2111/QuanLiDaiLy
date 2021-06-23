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
    public class B_DaiLy
    {
        public static DataTable GetAllDaiLy()
        {
            return D_DaiLy.getData();
        }
    
        public static void TiepNhanDaiLy(tblDAILY dl)
        {
            D_DaiLy.TiepNhanDaiLy(dl);
        }

        public static void SuaDaiLy(tblDAILY dl)
        {
            D_DaiLy.SuaDaiLy(dl);
        }

        public static void XoaDaiLy(int mdl)
        {
            D_DaiLy.XoaDaiLy(mdl);

        }
        public static void TraCuuDaiLy(int mdl)
        {
            D_DaiLy.TraCuuDaiLy(mdl);
        }
        public static void ChonQuan(tblQuan q)
        {
            D_Quan.ChonQuan(q);
        }
        public static void ChonLoaiDaiLy(tblLoaiDaiLy ldl)
        {
            D_LoaiDaiLy.ChonLoaiDaiLy(ldl);
        }
        public static DataTable getTablebyquery(string query)
        {

            DataTable dt = dbConnectionData.getDatabyquery(query);
            return dt;
        }

    }
}
