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
    public class D_MATHANG
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("pn_GetAllMatHang", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;

        }

        //them loại đại lý
        public static void ThemMatHang(tblMATHANG mh)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("themmathang", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@mamh", SqlDbType.Int);
            command.Parameters.Add("@tenmh", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@dvt", SqlDbType.NVarChar,50);
            command.Parameters.Add("@slton", SqlDbType.Int);
        

            command.Parameters["@mamh"].Value = mh.Mamh;
            command.Parameters["@tenmh"].Value = mh.Tenmh;
            command.Parameters["@dvt"].Value = mh.Donvitinh;
            command.Parameters["@slton"].Value = mh.Soluongton;

            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
