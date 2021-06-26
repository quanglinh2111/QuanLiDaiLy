using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Logic
    {  // tự động nhập mã khi nhập tên măt hàng
        public static int layma(DataTable tb)
        {
            int ma = 1;
            foreach (DataRow row in tb.Rows)
            {
                ma += 1;
            }
            return ma;
        }

        //thực thi câu lệnh
        public static void ExecuteQuery(string query)
        {
            dbConnectionData.ExecuteQuery(query);
        }
        //trả về table
        public static DataTable GetTableByQuery(string query)
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

        public static string getDatabyquery(string query)
        {

            DataTable dt = dbConnectionData.getDatabyquery(query);
            if (dt.Rows.Count == 0) return "";
            DataRow dr = dt.Rows[0];
            return dr[0].ToString();
        }
        //tinh tong tien
        public static int GetSumMoney(string query)
        {

            DataTable dt = dbConnectionData.getDatabyquery(query);

            int sum = 0;
            int result = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // your index is in i
                if (int.TryParse(dt.Rows[i][0].ToString(), out result))
                    sum += int.Parse(dt.Rows[i][0].ToString());
            }
            return sum;
        }
        //xóa


    }


}
