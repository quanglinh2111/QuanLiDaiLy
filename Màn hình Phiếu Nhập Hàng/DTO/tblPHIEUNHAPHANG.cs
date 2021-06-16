using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblPHIEUNHAPHANG
    {
        private int MaPhieuNhapHang;
        private DateTime NgayLapPhieu;
        private float TongTienPhieuNhap;

        public tblPHIEUNHAPHANG(int maPhieuNhapHang, DateTime ngayLapPhieu, float tongTienPhieuNhap)
        {
            MaPhieuNhapHang = maPhieuNhapHang;
            NgayLapPhieu = ngayLapPhieu;
            TongTienPhieuNhap = tongTienPhieuNhap;
        }

        public int MaPhieuNhapHang1 { get => MaPhieuNhapHang; set => MaPhieuNhapHang = value; }
        public DateTime NgayLapPhieu1 { get => NgayLapPhieu; set => NgayLapPhieu = value; }
        public float TongTienPhieuNhap1 { get => TongTienPhieuNhap; set => TongTienPhieuNhap = value; }
       
    }
}
