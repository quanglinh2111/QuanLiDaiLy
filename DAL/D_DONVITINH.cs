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
    public class D_DONVITINH
    {
        //them loại đại lý
        public static void ThemDonViTinh(tblDONVITINH dvt)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("themdonvitinh", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@donvitinh", SqlDbType.NVarChar,50);

            command.Parameters["@donvitinh"].Value = dvt.Donvitinh;
      
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
