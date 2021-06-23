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
    public class D_DaiLy
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("dl_GetAllDaiLy", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        
        //Tiep nhan dai ly
        public static void TiepNhanDaiLy(tblDAILY dl)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("dl_tiepnhandaily", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaDaiLy", SqlDbType.Int);
            command.Parameters.Add("@TenDaiLy", SqlDbType.NVarChar,50);
            command.Parameters.Add("@MaLoaiDaiLy", SqlDbType.Int);
            command.Parameters.Add("@DienThoai", SqlDbType.Int);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar,50);
            command.Parameters.Add("@MaQuan", SqlDbType.Int);
            command.Parameters.Add("@NgayTiepNhan", SqlDbType.Date);
            command.Parameters.Add("@TongNo", SqlDbType.Int);
            command.Parameters.Add("@Email", SqlDbType.NVarChar,50);


            command.Parameters["@MaDaiLy"].Value = dl.MaDaiLy1;
            command.Parameters["@TenDaiLy"].Value = dl.TenDaiLy1;
            command.Parameters["@MaLoaiDaiLy"].Value = dl.MaLoaiDaiLy1;
            command.Parameters["@DienThoai"].Value = dl.DienThoai1;
            command.Parameters["@DiaChi"].Value = dl.DiaChi1;
            command.Parameters["@MaQuan"].Value = dl.MaQuan1;
            command.Parameters["@NgayTiepNhan"].Value = dl.NgayTiepNhan1;
            command.Parameters["@TongNo"].Value = dl.TongNo1;
            command.Parameters["@Email"].Value = dl.Email1;


            command.ExecuteNonQuery();
            Conn.Close();
        }
        //Sua dai ly
        public static void SuaDaiLy(tblDAILY dl)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("dl_suadaily", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaDaiLy", SqlDbType.Int);
            command.Parameters.Add("@DienThoai", SqlDbType.Int);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NgayTiepNhan", SqlDbType.Date);

            command.Parameters["@MaDaiLy"].Value = dl.MaDaiLy1;
            command.Parameters["@DienThoai"].Value = dl.DienThoai1;
            command.Parameters["@DiaChi"].Value = dl.DiaChi1;
            command.Parameters["@NgayTiepNhan"].Value = dl.NgayTiepNhan1;

            command.ExecuteNonQuery();
            Conn.Close();
        }
        //Xoa dai ly
        public static void XoaDaiLy(int madl)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("dl_xoadaily", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaDaiLy", SqlDbType.Int);
      
            command.Parameters["@MaDaiLy"].Value = madl;

            command.ExecuteNonQuery();
            Conn.Close();
        }
        //Tra cuu dai ly
        public static void TraCuuDaiLy(int madl)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("dl_tracuudaily", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaDaiLy", SqlDbType.Int);

            command.Parameters["@MaDaiLy"].Value = madl;

            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
