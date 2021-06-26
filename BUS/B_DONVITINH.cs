using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class B_DONVITINH
    {
        public static void ThemDonViTinh(tblDONVITINH dvt)
        {
            D_DONVITINH.ThemDonViTinh(dvt);
        }


    }
}
