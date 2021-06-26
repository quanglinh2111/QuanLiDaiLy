using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblDONVITINH
    {
        string donvitinh;

        public tblDONVITINH(string donvitinh)
        {
            this.Donvitinh = donvitinh;
        }

        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
    }
}
