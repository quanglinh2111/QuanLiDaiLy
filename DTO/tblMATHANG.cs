using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblMATHANG
    {
        int mamh;
        string tenmh;
        string donvitinh;
        int soluongton;

        public tblMATHANG(int mamh, string tenmh, string donvitinh, int soluongton)
        {
            this.mamh = mamh;
            this.tenmh = tenmh;
            this.donvitinh = donvitinh;
            this.soluongton = soluongton;
        }

        public int Mamh { get => mamh; set => mamh = value; }
        public string Tenmh { get => tenmh; set => tenmh = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
        public int Soluongton { get => soluongton; set => soluongton = value; }
    }
}
