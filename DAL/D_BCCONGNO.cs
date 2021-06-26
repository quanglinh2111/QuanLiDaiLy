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
    public class D_BCCONGNO
    {
        public static void ThemBaoCaoCongNo(tblBCCONGNO bc)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("taobcongno", Conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            //
            command.Parameters.Add("@mabc", SqlDbType.Int);
            command.Parameters.Add("@thang", SqlDbType.Int);
            command.Parameters.Add("@nam", SqlDbType.Int);

            command.Parameters["@mabc"].Value = bc.Mabc;
            command.Parameters["@thang"].Value = bc.Thang;
            command.Parameters["@nam"].Value = bc.Nam;

            command.ExecuteNonQuery();
            //
            Conn.Close();
        }
    }
}
