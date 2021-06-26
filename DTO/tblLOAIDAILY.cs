using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblLOAIDAILY
    {
        private int MaLoaiDaiLy;
        private String TenLoaiDaiLy;
        private float SoTienNoToiDa;

        public tblLOAIDAILY(int maLoaiDaiLy, string tenLoaiDaiLy, float soTienNoToiDa)
        {
            MaLoaiDaiLy = maLoaiDaiLy;
            TenLoaiDaiLy = tenLoaiDaiLy;
            SoTienNoToiDa = soTienNoToiDa;
        }

        public int MaLoaiDaiLy1 { get => MaLoaiDaiLy; set => MaLoaiDaiLy = value; }
        public string TenLoaiDaiLy1 { get => TenLoaiDaiLy; set => TenLoaiDaiLy = value; }
        public float SoTienNoToiDa1 { get => SoTienNoToiDa; set => SoTienNoToiDa = value; }

    }
}
