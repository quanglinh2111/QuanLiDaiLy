using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLiCacDaiLy
{
    public partial class frmManHinhDaiLy : Form
    {
        public frmManHinhDaiLy()
        {
            InitializeComponent();
        }


        private void frmManHinhDaiLy_Load(object sender, EventArgs e)
        {
            grboxTraCuu.Hide();
            grBoxTiepNhan.Hide();
            grbDSDL.Show();
            grbDSDL.Location = new Point(90, 1);
            //
            cbBoxLoaiDaiLy.DataSource = Logic.GetTableByQuery("select * from LOAIDAILY");
            cbBoxLoaiDaiLy.DisplayMember = "MaLoaiDaiLy";

            cbBoxQuan.DataSource = Logic.GetTableByQuery("select * from QUAN");
            cbBoxQuan.DisplayMember = "MaQuan";

            cbBoxTraCuuMaDL.DataSource = Logic.GetTableByQuery("select * from DAILY");
            cbBoxTraCuuMaDL.DisplayMember = "MaDaiLy";
            dgvDSDL.DataSource = B_DAILY.GetAllDaiLy();


        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            dgvDSDL.DataSource = B_DAILY.GetAllDaiLy();

            grboxTraCuu.Hide();
            grBoxTiepNhan.Hide();
            grbDSDL.Show();
            grbDSDL.Location = new Point(90, 1);
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            dgvDSDL.DataSource = B_DAILY.GetAllDaiLy();

            grboxTraCuu.Hide();
            grBoxTiepNhan.Show();
            grbDSDL.Show();
            grbDSDL.Location = new Point(90, 140);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dgvDSDL.DataSource = B_DAILY.GetAllDaiLy();

            grboxTraCuu.Show();
            grBoxTiepNhan.Hide();
            grbDSDL.Show();
            grbDSDL.Location = new Point(90, 140);
     
        }

        private void btnThemDL_Click(object sender, EventArgs e)
        {
            int madl = Int32.Parse(txtBoxMaDaiLy.Text);
            string tendl = txtBoxTenDaiLy.Text;
            int maldl = Int32.Parse(cbBoxLoaiDaiLy.Text);
            int dt = Int32.Parse(txtBoxDienThoai.Text);
            string dc = txtBoxDiaChi.Text;
            int maquan = Int32.Parse(cbBoxQuan.Text);
            DateTime ntn = dtimeNgayTiepNhan.Value;
            int tongno = 0;
            string email = txtBoxEmail.Text;
            tblDAILY daily = new tblDAILY(madl, tendl, maldl, dt, dc, maquan, ntn, tongno, email);
            B_DAILY.TiepNhanDaiLy(daily);
            MessageBox.Show("Đã thêm đại lý " + madl + " thành công");
            dgvDSDL.DataSource = B_DAILY.GetAllDaiLy();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaDL_Click(object sender, EventArgs e)
        {
            int madl = Int32.Parse(txtBoxMaDaiLy.Text);
            string tendl = txtBoxTenDaiLy.Text;
            int maldl = Int32.Parse(cbBoxLoaiDaiLy.Text);
            int dt = Int32.Parse(txtBoxDienThoai.Text);
            string dc = txtBoxDiaChi.Text;
            int maquan = Int32.Parse(cbBoxQuan.Text);
            DateTime ntn = dtimeNgayTiepNhan.Value;
            int tongno = 0;
            string email = txtBoxEmail.Text;
            tblDAILY daily = new tblDAILY(madl, tendl, maldl, dt, dc, maquan, ntn, tongno, email);
            B_DAILY.SuaDaiLy(daily);
            MessageBox.Show("Đã sửa đại lý " + madl + " thành công");
            dgvDSDL.DataSource = B_DAILY.GetAllDaiLy();
        }

        private void dgvDSDL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDSDL.Rows[e.RowIndex];
            txtBoxMaDaiLy.Text = row.Cells[0].Value.ToString();
            txtBoxTenDaiLy.Text = row.Cells[1].Value.ToString();
            txtBoxDienThoai.Text = row.Cells[2].Value.ToString();
            txtBoxDiaChi.Text = row.Cells[3].Value.ToString();
            // cbBoxLoaiDaiLy.Text = row.Cells[5].Value.ToString();
            dtimeNgayTiepNhan.Text = row.Cells[6].Value.ToString();
            txtBoxEmail.Text = row.Cells[7].Value.ToString();
        }

        private void btnXoaDL_Click(object sender, EventArgs e)
        {
            int madl = Int32.Parse(txtBoxMaDaiLy.Text);
            B_DAILY.XoaDaiLy(madl);
            MessageBox.Show("Đã xóa đại lý " + madl + " thành công");
            dgvDSDL.DataSource = B_DAILY.GetAllDaiLy();
        }

        private void btnOKTraCuu_Click(object sender, EventArgs e)
        {
            int madl = Int32.Parse(cbBoxTraCuuMaDL.Text);
            dgvDSDL.DataSource = B_DAILY.TraCuuDaiLy(madl);
        }
    }
}
