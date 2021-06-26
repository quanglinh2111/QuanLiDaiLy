using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dbConnectionData
    {
        public static SqlConnection HamKetNoi()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-FAJU1CK\SQLEXPRESS;Initial Catalog=QuanLy;Integrated Security=True");
            return Conn;
        }

        //lấy tên các column trong 1 table vd: MaMatHang, TenMatHang
        public static List<string> GetnameCol(string tbl)
        {
            List<string> name = new List<string>();
            SqlCommand sqlCmd;
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            string sql = "select * from " + tbl + "";

            sqlCmd = new SqlCommand(sql, Conn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            for (int i = 0; i < sqlReader.FieldCount; i++)
            {
                name.Add(sqlReader.GetName(i));
            }
            sqlReader.Close();
            sqlCmd.Dispose();
            Conn.Close();

            return name;
        }
        // Trả về 1 bảng table khi truyền vào query
        public static DataTable getDatabyquery(string query)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            DataTable bangdulieu = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter(query, Conn);
            Adapter.Fill(bangdulieu);
            Adapter.Dispose();
            Conn.Close();
            return bangdulieu;
        }

        // thực thi câu lệnh nhưng không có giá trị trả về
        public static void ExecuteQuery(string query)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            DataTable bangdulieu = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter(query, Conn);
            Adapter.Fill(bangdulieu);
            Conn.Close();
        }
    }
}
