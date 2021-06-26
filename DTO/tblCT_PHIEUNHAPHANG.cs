using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblCT_PHIEUNHAPHANG
    {
        int MaCT_PhieuNhapHang;
        int MaPhieuNhapHang;
        int MaMatHang;
        string TenMatHang;
        int SoLuong;
        float DonGiaNhap;
        public tblCT_PHIEUNHAPHANG(int maCT_PhieuNhapHang, int maPhieuNhapHang, int maMatHang, string tenMatHang, int soLuong, float donGiaNhap)
        {
            MaCT_PhieuNhapHang = maCT_PhieuNhapHang;
            MaPhieuNhapHang = maPhieuNhapHang;
            MaMatHang = maMatHang;
            TenMatHang = tenMatHang;
            SoLuong = soLuong;
            DonGiaNhap = donGiaNhap;

        }

        public int MaCT_PhieuNhapHang1 { get => MaCT_PhieuNhapHang; set => MaCT_PhieuNhapHang = value; }
        public int MaPhieuNhapHang1 { get => MaPhieuNhapHang; set => MaPhieuNhapHang = value; }
        public int MaMatHang1 { get => MaMatHang; set => MaMatHang = value; }
        public string TenMatHang1 { get => TenMatHang; set => TenMatHang = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public float DonGiaNhap1 { get => DonGiaNhap; set => DonGiaNhap = value; }
    }
}
