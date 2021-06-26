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
    public class D_CT_PHIEUNHAPHANG
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("pn_GetAllCTPhieuNhap", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        // them chi tiet phieu nhap
        public static void ThemChiTietPhieuNhap(tblCT_PHIEUNHAPHANG ct)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("pn_themchitietpnh", Conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            //
            command.Parameters.Add("@mact_pnh", SqlDbType.Int);
            command.Parameters.Add("@maphieunhaphang", SqlDbType.Int);
            command.Parameters.Add("@mamh", SqlDbType.Int);
            command.Parameters.Add("@tenmathang", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@soluong", SqlDbType.Int);
            command.Parameters.Add("@dongianhap", SqlDbType.Float);


            command.Parameters["@mact_pnh"].Value = ct.MaCT_PhieuNhapHang1;
            command.Parameters["@maphieunhaphang"].Value = ct.MaPhieuNhapHang1;
            command.Parameters["@mamh"].Value = ct.MaMatHang1;
            command.Parameters["@tenmathang"].Value = ct.TenMatHang1;
            command.Parameters["@soluong"].Value = ct.SoLuong1;
            command.Parameters["@dongianhap"].Value = ct.DonGiaNhap1;
            command.ExecuteNonQuery();
            //
            Conn.Close();
        }
        //sưa
        public static void SuaChiTietMatHang(tblCT_PHIEUNHAPHANG ct)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand command = new SqlCommand("pn_themchitietpnh", Conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            //
            command.Parameters.Add("@mact_pnh", SqlDbType.Int);
            command.Parameters.Add("@maphieunhaphang", SqlDbType.Int);
            command.Parameters.Add("@mamh", SqlDbType.Int);
            command.Parameters.Add("@tenmathang", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@soluong", SqlDbType.Int);
            command.Parameters.Add("@dongianhap", SqlDbType.Float);

            command.Parameters["@mact_pnh"].Value = ct.MaCT_PhieuNhapHang1;
            command.Parameters["@maphieunhaphang"].Value = ct.MaPhieuNhapHang1;
            command.Parameters["@mamh"].Value = ct.MaMatHang1;
            command.Parameters["@tenmathang"].Value = ct.TenMatHang1;
            command.Parameters["@soluong"].Value = ct.SoLuong1;
            command.Parameters["@dongianhap"].Value = ct.DonGiaNhap1;


            command.ExecuteNonQuery();
            //
            Conn.Close();
        }

    }
}
