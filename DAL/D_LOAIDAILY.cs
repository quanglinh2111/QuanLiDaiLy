using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class D_LOAIDAILY
    {

        //Chon Loai Dai Ly
        public static void ChonLoaiDaiLy(tblLOAIDAILY ldl)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("ldl_chonloaidaily", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaLoaiDaiLy", SqlDbType.Int);
            command.Parameters.Add("@TenLoaiDaiLy", SqlDbType.NVarChar, 50);

            command.Parameters["@MaLoaiDaiLy"].Value = ldl.MaLoaiDaiLy1;
            command.Parameters["@TenLoaiDaiLy"].Value = ldl.TenLoaiDaiLy1;

            command.ExecuteNonQuery();
            Conn.Close();
        }

        //them loại đại lý
        public static void ThemLoaiDaiLy(tblLOAIDAILY ldl)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("ldl_themloaidaily", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@maloaidaily", SqlDbType.Int);
            command.Parameters.Add("@tenloaidaily", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@sotiennotoida", SqlDbType.Float);

            command.Parameters["@maloaidaily"].Value = ldl.MaLoaiDaiLy1;
            command.Parameters["@tenloaidaily"].Value = ldl.TenLoaiDaiLy1;
            command.Parameters["@sotiennotoida"].Value = ldl.SoTienNoToiDa1;

            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
