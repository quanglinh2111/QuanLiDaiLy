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
    public class D_QUAN
    {
        //Chon Quan
        public static void ChonQuan(tblQUAN dl)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("q_chonquan", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaQuan", SqlDbType.Int);
            command.Parameters.Add("@TenQuan", SqlDbType.NVarChar, 50);

            command.Parameters["@MaQuan"].Value = dl.MaQuan1;
            command.Parameters["@TenQuan"].Value = dl.TenQuan1;

            command.ExecuteNonQuery();
            Conn.Close();
        }
        //them quận
        public static void ThemQuan(tblQUAN q)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("q_themquan", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@maquan", SqlDbType.Int);
            command.Parameters.Add("@Tenquan", SqlDbType.NVarChar, 50);

            command.Parameters["@maquan"].Value = q.MaQuan1;
            command.Parameters["@Tenquan"].Value = q.TenQuan1;

            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
