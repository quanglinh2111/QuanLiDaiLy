using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblBCDOANHSO
    {
        int mabcds;
        int thang;
        int nam;
        float tongdoanhso;

        public tblBCDOANHSO(int mabcds, int thang, int nam, float tongdoanhso)
        {
            this.mabcds = mabcds;
            this.thang = thang;
            this.nam = nam;
            this.tongdoanhso = tongdoanhso;
        }

        public int Mabcds { get => mabcds; set => mabcds = value; }
        public int Thang { get => thang; set => thang = value; }
        public int Nam { get => nam; set => nam = value; }
        public float Tongdoanhso { get => tongdoanhso; set => tongdoanhso = value; }
    }
}
