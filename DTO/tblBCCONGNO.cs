using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblBCCONGNO
    {
        int mabc;
        int thang;
        int nam;

        public tblBCCONGNO(int mabc, int thang, int nam)
        {
            this.mabc = mabc;
            this.thang = thang;
            this.nam = nam;
        }

        public int Mabc { get => mabc; set => mabc = value; }
        public int Thang { get => thang; set => thang = value; }
        public int Nam { get => nam; set => nam = value; }
    }
}
