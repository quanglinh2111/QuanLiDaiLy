using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_LOGIN
    {
        public static DataTable getData()
        {
            SqlConnection Con = dbConnectionData.HamKetNoi();
            SqlCommand Commad = new SqlCommand("sp_GetLogin", Con);
            Commad.CommandType = CommandType.StoredProcedure;
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter("sp_Getlogin", Con);
            da.SelectCommand = Commad;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Con.Close();
            return dt;
        }
    }
}
