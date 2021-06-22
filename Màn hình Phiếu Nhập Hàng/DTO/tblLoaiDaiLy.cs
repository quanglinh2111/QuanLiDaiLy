using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblLoaiDaiLy
    {
        private int MaLoaiDaiLy;
        private String TenLoaiDaiLy;

        public tblLoaiDaiLy(int maLoaiDaiLy, string tenLoaiDaiLy)
        {
            MaLoaiDaiLy = maLoaiDaiLy;
            TenLoaiDaiLy = tenLoaiDaiLy;
        }

        public int MaLoaiDaiLy1 { get => MaLoaiDaiLy; set => MaLoaiDaiLy = value; }
        public string TenLoaiDaiLy1 { get => TenLoaiDaiLy; set => TenLoaiDaiLy = value; }
    }
}
