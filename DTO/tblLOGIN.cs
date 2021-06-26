using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblLOGIN
    {
        private String TaiKhoan;
        private String MatKhau;

        public tblLOGIN(string taiKhoan, string matKhau)
        {
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
        }

        public string TaiKhoan1 { get => TaiKhoan; set => TaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
    }
}
