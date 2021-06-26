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
    public class D_PHIEUNHAPHANG
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("pn_GetAllPhieuNhap", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        //tạo 1 mã phiếu nhập
        public static int ThemThongTinPhieuNhap(tblPHIEUNHAPHANG pn)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("pn_themtongtinpnh", Conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            //
            command.Parameters.Add("@maphieunhaphang", SqlDbType.Int);
            command.Parameters.Add("@ngaylapphieu", SqlDbType.DateTime);
            command.Parameters.Add("@tongtienphieunhap", SqlDbType.Float);


            command.Parameters["@maphieunhaphang"].Value = pn.MaPhieuNhapHang1;
            command.Parameters["@ngaylapphieu"].Value = pn.NgayLapPhieu1;
            command.Parameters["@tongtienphieunhap"].Value = pn.TongTienPhieuNhap1;

            command.ExecuteNonQuery();
            //
            Conn.Close();
            return pn.MaPhieuNhapHang1;
        }

    }
}
