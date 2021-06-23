using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Màn_hình_Phiếu_Nhập_Hàng
{
    public partial class ManHinhDaiLy : Form
    {
        public ManHinhDaiLy()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grBoxTiepNhanDL.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ManHinhDaiLy_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = B_DaiLy.GetAllDaiLy();

            cbBoxLoaiDaiLy.DataSource = Logic.GetTableByQuery("select * from LOAIDAILY");
            cbBoxLoaiDaiLy.DisplayMember="MaLoaiDaiLy";

            cbBoxQuan.DataSource = Logic.GetTableByQuery("select * from QUAN");
            cbBoxQuan.DisplayMember = "MaQuan";

            cbBoxTraCuu.DataSource = Logic.GetTableByQuery("select * from DAILY");
            cbBoxTraCuu.DisplayMember = "MaDaiLy";
            //grBoxTiepNhanDL.Hide();
        }

        private void grBoxMain_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbBoxQuan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grBoxTiepNhanDL_Enter(object sender, EventArgs e)
        {
        }

        private void btnLapPhieuTiepNhanDL_Click(object sender, EventArgs e)
        {
            grBoxTiepNhanDL.Show();
        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTiepNhanDL_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTraCuuDL_Click(object sender, EventArgs e)
        {
            grBoxTiepNhanDL.Hide();
        }

        private void grBoxTraCuu_Enter(object sender, EventArgs e)
        {

        }

        private void btnDSDaiLy_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = B_DaiLy.GetAllDaiLy();
        }

        private void btnLapPhieuTiepNhanDL_Click_1(object sender, EventArgs e)
        {
            grBoxTiepNhanDL.Show();
        }

        private void btnTraCuuDL_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            grBoxTiepNhanDL.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void grBoxSuaDaiLy_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Sua
        private void button1_Click_1(object sender, EventArgs e)
        {
            int madl = Int32.Parse(txtBoxMaDaiLy.Text);
            string tendl = txtBoxTendaily.Text;
            int maldl = Int32.Parse(cbBoxLoaiDaiLy.Text);
            int dt = Int32.Parse(txtBoxDienThoai.Text);
            string dc = txtBoxDiaChi.Text;
            int maquan = Int32.Parse(cbBoxQuan.Text);
            DateTime ntn = dtpNgayTiepNhan.Value;
            int tongno = 0;
            string email = txtBoxEmail.Text;
            tblDAILY daily = new tblDAILY(madl, tendl, maldl, dt, dc, maquan, ntn, tongno, email);
            B_DaiLy.SuaDaiLy(daily);
            MessageBox.Show("Đã sửa đại lý " + madl + " thành công");
            dataGridView2.DataSource = B_DaiLy.GetAllDaiLy();
        }
        //Xoa
        private void button4_Click_1(object sender, EventArgs e)
        {
            int madl = Int32.Parse(txtBoxMaDaiLy.Text);
            B_DaiLy.XoaDaiLy(madl);
            MessageBox.Show("Đã xoá đại lý " + madl + " thành công");
            dataGridView2.DataSource = B_DaiLy.GetAllDaiLy();
        }
        //Tiep nhan
        private void button3_Click(object sender, EventArgs e)
        {
            int madl = Int32.Parse(txtBoxMaDaiLy.Text);
            string tendl = txtBoxTendaily.Text;
            int maldl = Int32.Parse(cbBoxLoaiDaiLy.Text);
            int dt = Int32.Parse(txtBoxDienThoai.Text);
            string dc = txtBoxDiaChi.Text;
            int maquan = Int32.Parse(cbBoxQuan.Text);
            DateTime ntn = dtpNgayTiepNhan.Value;
            int tongno = 0;
            string email = txtBoxEmail.Text;
            tblDAILY daily = new tblDAILY(madl, tendl, maldl, dt, dc, maquan, ntn, tongno, email);
            B_DaiLy.TiepNhanDaiLy(daily);
            MessageBox.Show("Đã thêm đại lý " + madl + " thành công");
            dataGridView2.DataSource = B_DaiLy.GetAllDaiLy();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        //Tra cuu
        private void button6_Click(object sender, EventArgs e)
        {
            int madl = Int32.Parse(cbBoxTraCuu.Text);
            dataGridView2.DataSource = B_DaiLy.getTablebyquery("select * from DAILY where MaDaiLy="+madl+"");
        }
    }
}
