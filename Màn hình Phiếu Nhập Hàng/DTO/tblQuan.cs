﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblQuan
    {
        private int MaQuan;
        private String TenQuan;

        public tblQuan(int maQuan, string tenQuan)
        {
            MaQuan = maQuan;
            TenQuan = tenQuan;
        }

        public int MaQuan1 { get => MaQuan; set => MaQuan = value; }
        public string TenQuan1 { get => TenQuan; set => TenQuan = value; }
    }
}
