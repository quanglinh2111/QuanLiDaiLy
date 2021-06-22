using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblPHIEUXUATHANG
    {
        int mapxh;
        int madl;
        DateTime ngaylapphieu;
        float tongtienphieuxuat;
        float sotientra;
        float conlai;

        public tblPHIEUXUATHANG(int mapxh, int madl, DateTime ngaylapphieu, float tongtienphieuxuat, float sotientra, float conlai)
        {
            this.mapxh = mapxh;
            this.madl = madl;
            this.ngaylapphieu = ngaylapphieu;
            this.tongtienphieuxuat = tongtienphieuxuat;
            this.sotientra = sotientra;
            this.conlai = conlai;
        }

        public int Mapxh { get => mapxh; set => mapxh = value; }
        public int Madl { get => madl; set => madl = value; }
        public DateTime Ngaylapphieu { get => ngaylapphieu; set => ngaylapphieu = value; }
        public float Tongtienphieuxuat { get => tongtienphieuxuat; set => tongtienphieuxuat = value; }
        public float Sotientra { get => sotientra; set => sotientra = value; }
        public float Conlai { get => conlai; set => conlai = value; }
    }
}
