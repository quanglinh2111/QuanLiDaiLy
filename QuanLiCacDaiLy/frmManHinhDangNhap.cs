using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;

namespace QuanLiCacDaiLy
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection Con = dbConnectionData.HamKetNoi();
            SqlCommand Commad = new SqlCommand("sp_GetLogin", Con);
            Commad.CommandType = CommandType.StoredProcedure;
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Count (*) From LOGIN Where TaiKhoan='" + txtTenDangNhap.Text + "' and MatKhau='" + txtMatKhau.Text + "'", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Ðang nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmManHinhChinh menu = new frmManHinhChinh();
                menu.Show();
                // string strConn = @"Data Source=DESKTOP-FAJU1CK\SQLEXPRESS;Initial Catalog=QuanLy;Integrated Security=True";
                //SqlConnection sqlConn = new SqlConnection(strConn);
                



            }
            else
            {
                MessageBox.Show("Ðang nhập thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
