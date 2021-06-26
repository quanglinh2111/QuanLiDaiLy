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
    public class B_DAILY
    {
        public static DataTable GetAllDaiLy()
        {
            return D_DAILY.getData();
        }

        public static void TiepNhanDaiLy(tblDAILY dl)
        {
            D_DAILY.TiepNhanDaiLy(dl);
        }

        public static void SuaDaiLy(tblDAILY dl)
        {
            D_DAILY.SuaDaiLy(dl);
        }

        public static void XoaDaiLy(int mdl)
        {
            D_DAILY.XoaDaiLy(mdl);

        }
        public static DataTable TraCuuDaiLy(int mdl)
        {
            return D_DAILY.TraCuuDaiLy(mdl);
        }
        public static void ChonQuan(tblQUAN q)
        {
            D_QUAN.ChonQuan(q);
        }
        public static void ChonLoaiDaiLy(tblLOAIDAILY ldl)
        {
            D_LOAIDAILY.ChonLoaiDaiLy(ldl);
        }
    }
}
