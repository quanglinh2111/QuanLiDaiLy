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
    public partial class ManHinhPhieuThuTien : Form
    {
        public ManHinhPhieuThuTien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dgvDanhsachphieuthutien.DataSource = B_PhieuThuTien.GetAllPhieuThuTien();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        //Tra cuu
        private void button1_Click(object sender, EventArgs e)
        {
            int maptt = Int32.Parse(cbBoxTracuu.Text);
            dgvDanhsachphieuthutien.DataSource = B_PhieuThuTien.getTablebyquery("select * from PHIEUTHUTIEN where MaPhieuThuTien=" + maptt + "");
        }
        //Tao phieu thu tien
        private void button2_Click(object sender, EventArgs e)
        {
            int maptt = Int32.Parse(txtMapt.Text);
            int madl = Int32.Parse(txtMadl.Text);
            DateTime ngaytt = dtpNgaytt.Value;
            float sott = float.Parse(txtSott.Text);
            tblPHIEUTHUTIEN phieutt = new tblPHIEUTHUTIEN(maptt, madl, ngaytt, sott);
            B_PhieuThuTien.TaoPhieuThu(phieutt);
            MessageBox.Show("Đã thêm phiếu thu " + maptt + " thành công");
            dgvDanhsachphieuthutien.DataSource = B_PhieuThuTien.GetAllPhieuThuTien();
        }
    }
}
