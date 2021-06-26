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

namespace QuanLiCacDaiLy
{
    public partial class frmPhieuThuTien : Form
    {
        public frmPhieuThuTien()
        {
            InitializeComponent();
        }

        private void frmPhieuThuTien_Load(object sender, EventArgs e)
        {
            dgvDanhsachphieuthutien.DataSource = B_PhieuThuTien.GetAllPhieuThuTien();
            //
            cbBoxTracuu.DataSource = Logic.GetTableByQuery("select * from PHIEUTHUTIEN");
            cbBoxTracuu.DisplayMember = "MaPhieuThuTien";
        }

        private void btnTraCuuPhieuThu_Click(object sender, EventArgs e)
        {
            int maptt = Int32.Parse(cbBoxTracuu.Text);
            dgvDanhsachphieuthutien.DataSource = B_PhieuThuTien.getTablebyquery("select * from PHIEUTHUTIEN where MaPhieuThuTien=" + maptt + "");
        }

        private void btnTaoPhieuThu_Click(object sender, EventArgs e)
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
