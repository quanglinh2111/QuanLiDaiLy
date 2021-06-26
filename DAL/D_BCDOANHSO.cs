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
    public class D_BCDOANHSO
    {
        public static void ThemBaoCaoDoanhSo(tblBCDOANHSO bc)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("pn_lapbaocao", Conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            //
            command.Parameters.Add("@MaBCDS", SqlDbType.Int);
            command.Parameters.Add("@thang", SqlDbType.Int);
            command.Parameters.Add("@nam", SqlDbType.Int);
            command.Parameters.Add("@TongDoanhSo", SqlDbType.Float);



            command.Parameters["@MaBCDS"].Value = bc.Mabcds;
            command.Parameters["@thang"].Value = bc.Thang;
            command.Parameters["@nam"].Value = bc.Nam;
            command.Parameters["@TongDoanhSo"].Value = bc.Tongdoanhso;

            command.ExecuteNonQuery();
            //
            Conn.Close();
        }
    }
}
