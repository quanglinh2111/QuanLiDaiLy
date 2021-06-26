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
    public class D_CT_PHIEUXUATHANG
    {
        public static DataTable GetAllCTPhieuXuat(string query)
        {
            DataTable dt = dbConnectionData.getDatabyquery(query);
            return dt;
        }

        //them ct phiếu xuất
        public static void ThemChiTietPhieuXuat(tblCT_PHIEUXUATHANG ct)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("pn_taophieuctxuat", Conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            //
            command.Parameters.Add("@mactpx", SqlDbType.Int);
            command.Parameters.Add("@mapx", SqlDbType.Int);
            command.Parameters.Add("@tenmh", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@mamh", SqlDbType.Int);
            command.Parameters.Add("@sl", SqlDbType.Int);
            command.Parameters.Add("@dg", SqlDbType.Float);
            command.Parameters.Add("@tt", SqlDbType.Float);


            command.Parameters["@mactpx"].Value = ct.Mactpxh;
            command.Parameters["@mapx"].Value = ct.Mapx;
            command.Parameters["@tenmh"].Value = ct.Tenmh;
            command.Parameters["@mamh"].Value = ct.Mamh;
            command.Parameters["@sl"].Value = ct.Slx;
            command.Parameters["@dg"].Value = ct.Dgx;
            command.Parameters["@tt"].Value = ct.Thanhtien;

            command.ExecuteNonQuery();
            //
            Conn.Close();
        }
    }
}
