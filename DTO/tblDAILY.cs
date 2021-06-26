using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblDAILY
    {
        private int MaDaiLy;
        private String TenDaiLy;
        private int MaLoaiDaiLy;
        private int DienThoai;
        private String DiaChi;
        private int MaQuan;
        private DateTime NgayTiepNhan;
        private float TongNo;
        private String Email;

        public tblDAILY(int maDaiLy, string tenDaiLy, int maLoaiDaiLy, int dienThoai, string diaChi, int maQuan, DateTime ngayTiepNhan, float tongNo, string email)
        {
            MaDaiLy = maDaiLy;
            TenDaiLy = tenDaiLy;
            MaLoaiDaiLy = maLoaiDaiLy;
            DienThoai = dienThoai;
            DiaChi = diaChi;
            MaQuan = maQuan;
            NgayTiepNhan = ngayTiepNhan;
            TongNo = tongNo;
            Email = email;
        }

        public int MaDaiLy1 { get => MaDaiLy; set => MaDaiLy = value; }
        public string TenDaiLy1 { get => TenDaiLy; set => TenDaiLy = value; }
        public int MaLoaiDaiLy1 { get => MaLoaiDaiLy; set => MaLoaiDaiLy = value; }
        public int DienThoai1 { get => DienThoai; set => DienThoai = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public int MaQuan1 { get => MaQuan; set => MaQuan = value; }
        public DateTime NgayTiepNhan1 { get => NgayTiepNhan; set => NgayTiepNhan = value; }
        public float TongNo1 { get => TongNo; set => TongNo = value; }
        public string Email1 { get => Email; set => Email = value; }
    }
}
