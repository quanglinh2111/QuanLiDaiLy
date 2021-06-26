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
    public class D_PHIEUXUATHANG
    {
        public static DataTable GetAllPhieuXuat(string query)
        {
            DataTable dt = dbConnectionData.getDatabyquery(query);
            return dt;
        }

        public static void ThemPhieuXuat(tblPHIEUXUATHANG px)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("pn_themphieuxuat", Conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            //

            command.Parameters.Add("@mapx", SqlDbType.Int);
            command.Parameters.Add("@madl", SqlDbType.Int);
            command.Parameters.Add("@ngaylapphieu", SqlDbType.DateTime);
            command.Parameters.Add("@tongtien", SqlDbType.Float);
            command.Parameters.Add("@sotientra", SqlDbType.Float);
            command.Parameters.Add("@conlai", SqlDbType.Float);

            command.Parameters["@mapx"].Value = px.Mapxh;
            command.Parameters["@madl"].Value = px.Madl;
            command.Parameters["@ngaylapphieu"].Value = px.Ngaylapphieu;
            command.Parameters["@tongtien"].Value = px.Tongtienphieuxuat;
            command.Parameters["@sotientra"].Value = px.Sotientra;
            command.Parameters["@conlai"].Value = px.Conlai;

            command.ExecuteNonQuery();
            //
            Conn.Close();
        }
    }
}
