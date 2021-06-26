using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblPHIEUTHUTIEN
    {
        private int MaPhieuThuTien;
        private int MaDaiLy;
        private DateTime NgayThuTien;
        private float SoTienThu;

        public tblPHIEUTHUTIEN(int maPhieuThuTien, int maDaiLy, DateTime ngayThuTien, float soTienThu)
        {
            MaPhieuThuTien = maPhieuThuTien;
            MaDaiLy = maDaiLy;
            NgayThuTien = ngayThuTien;
            SoTienThu = soTienThu;
        }

        public int MaPhieuThuTien1 { get => MaPhieuThuTien; set => MaPhieuThuTien = value; }
        public int MaDaiLy1 { get => MaDaiLy; set => MaDaiLy = value; }
        public DateTime NgayThuTien1 { get => NgayThuTien; set => NgayThuTien = value; }
        public float SoTienThu1 { get => SoTienThu; set => SoTienThu = value; }
    }
}
