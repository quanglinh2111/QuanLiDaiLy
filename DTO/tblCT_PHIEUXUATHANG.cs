using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblCT_PHIEUXUATHANG
    {
        int mactpxh;
        int mapx;
        string tenmh;
        int mamh;
        int slx;
        float dgx;
        float thanhtien;

        public tblCT_PHIEUXUATHANG(int mactpxh, int mapx, string tenmh, int mamh, int slx, float dgx, float thanhtien)
        {
            this.mactpxh = mactpxh;
            this.mapx = mapx;
            this.tenmh = tenmh;
            this.mamh = mamh;
            this.slx = slx;
            this.dgx = dgx;
            this.thanhtien = thanhtien;
        }

        public int Mactpxh { get => mactpxh; set => mactpxh = value; }
        public int Mapx { get => mapx; set => mapx = value; }
        public string Tenmh { get => tenmh; set => tenmh = value; }
        public int Mamh { get => mamh; set => mamh = value; }
        public int Slx { get => slx; set => slx = value; }
        public float Dgx { get => dgx; set => dgx = value; }
        public float Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}
