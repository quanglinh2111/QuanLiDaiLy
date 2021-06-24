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
    public class D_PhieuThuTien
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("pt_GetAllPhieuThuTien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        //Tao phieu thu tien
        public static void TaoPhieuThuTien(tblPHIEUTHUTIEN pt)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("ptt_taophieuthu", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaPhieuThuTien", SqlDbType.Int);
            command.Parameters.Add("@MaDaiLy", SqlDbType.Int);
            command.Parameters.Add("@NgayThuTien", SqlDbType.DateTime);
            command.Parameters.Add("@SoTienThu", SqlDbType.Float);

            command.Parameters["@MaPhieuThuTien"].Value = pt.MaPhieuThuTien1;
            command.Parameters["@MaDaiLy"].Value = pt.MaDaiLy1;
            command.Parameters["@NgayThuTien"].Value = pt.NgayThuTien1;
            command.Parameters["@SoTienThu"].Value = pt.@SoTienThu1;

            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
