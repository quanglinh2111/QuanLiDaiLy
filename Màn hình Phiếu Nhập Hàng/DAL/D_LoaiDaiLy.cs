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
    public class D_LoaiDaiLy
    {

        //Chon Loai Dai Ly
        public static void ChonLoaiDaiLy(tblLoaiDaiLy ldl)
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
    }
}
