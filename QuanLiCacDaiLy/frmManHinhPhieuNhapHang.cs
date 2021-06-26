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
    public partial class frmManHinhPhieuNhapHang : Form
    {
        public frmManHinhPhieuNhapHang()
        {
            InitializeComponent();
        }

        private void btnOKTaoPhieuXuat_Click(object sender, EventArgs e)
        {
            int mactpn = 0;
            int mapn = int.Parse(txtBoxMaPhieuNhap.Text);
            int mamh = int.Parse(txtMatHang.Text);
            string tenmh = cbBoxTenMatHang.Text;
            int sl = int.Parse(txtSoLuongNhap.Text);
            float dg = float.Parse(txtDonGiaNhap.Text);

            tblCT_PHIEUNHAPHANG ct = new tblCT_PHIEUNHAPHANG(mactpn, mapn, mamh, tenmh, sl, dg);
            B_CT_PHIEUNHAPHANG.ThemChiTietPhieuNhap(ct);
            MessageBox.Show("bạn đã thêm 1 chi tiết nhập hàng");
            dgvCTPNH.DataSource = B_CT_PHIEUNHAPHANG.getTablebyquery("select * from CT_PHIEUNHAPHANG where MaPhieuNhapHang = " + mapn + "");
            //
            string str = " select ThanhTien from CT_PHIEUNHAPHANG where MaPhieuNhapHang = " + mapn + "";
            txtBoxTongTienPhieuNhap.Text = B_CT_PHIEUNHAPHANG.GetSumMoney(str).ToString();
            //
            string str2 = "  update PHIEUNHAPHANG set TongTienPhieuNhap = " + txtBoxTongTienPhieuNhap.Text + " where MaPhieuNhapHang = " + mapn + "";
            Logic.ExecuteQuery(str2);
        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            int mapn = B_PHIEUNHAPHANG.ThemThongTinPhieuNhap();
            MessageBox.Show("bạn đã tạo mới 1 phiếu nhập hàng");
            dgvTraCTPhieuNhap.DataSource = B_PHIEUNHAPHANG.GetAllPhieuNhap();
            txtBoxMaPhieuNhap.Text = mapn.ToString();
            dgvCTPNH.DataSource = B_CT_PHIEUNHAPHANG.getTablebyquery("select * from CT_PHIEUNHAPHANG where MaPhieuNhapHang = " + mapn + "");
            txtDonGiaNhap.Text = "0";
            txtSoLuongNhap.Text = "0";
        }

        private void frmManHinhPhieuNhapHang_Load(object sender, EventArgs e)
        {
           
            dgvDSPhieuNhap.DataSource = B_PHIEUNHAPHANG.GetAllPhieuNhap(); 
            cbBoxTenMatHang.DataSource = B_MATHANG.GetAllMatHang();
            cbBoxTenMatHang.DisplayMember = "TenMatHang";
            //
            grBoxChiTietPhieuNhap.Hide();
            grBoxDSPhieuNhapHang.Show();
            grBoxTaoPhieuNhapHang.Hide();
            grBoxTraPhieuNhap.Hide();         
        }

   

        private void dgvCTPNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCTPNH.Rows[e.RowIndex];
                txtMactpn.Text = row.Cells[0].Value.ToString();
                txtBoxMaPhieuNhap.Text = row.Cells[1].Value.ToString();
                txtMatHang.Text = row.Cells[2].Value.ToString();
                cbBoxTenMatHang.Text = row.Cells[3].Value.ToString();
                txtSoLuongNhap.Text = row.Cells[4].Value.ToString();
                txtDonGiaNhap.Text = row.Cells[5].Value.ToString();

            }
            catch
            {

            }
            // btnXoa.Enabled = true;
            // btnSua.Enabled = true;
        }

        private void cbBoxTenMatHang_TextChanged(object sender, EventArgs e)
        {
            string str;
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = " select MaMatHang from MATHANG where TenMatHang like '%" + cbBoxTenMatHang.Text + "%'";
            txtMatHang.Text = B_CT_PHIEUNHAPHANG.getDatabyquery(str);
        }

        private void btnSuaPhieuNhap_Click(object sender, EventArgs e)
        {

            int mactpn = int.Parse(txtMactpn.Text);
            int mapn = int.Parse(txtBoxMaPhieuNhap.Text);
            int mamh = int.Parse(txtMatHang.Text);
            string tenmh = cbBoxTenMatHang.Text;
            int sl = int.Parse(txtSoLuongNhap.Text);
            float dg = float.Parse(txtDonGiaNhap.Text);
            tblCT_PHIEUNHAPHANG ct = new tblCT_PHIEUNHAPHANG(mactpn, mapn, mamh, tenmh, sl, dg);
            B_CT_PHIEUNHAPHANG.SuaChiTietPhieuNhapHang(ct);
            MessageBox.Show("bạn đã sửa thành công");
            txtMactpn.Text = "1";
            string str = " select ThanhTien from CT_PHIEUNHAPHANG where MaPhieuNhapHang = " + mapn + "";
            txtBoxTongTienPhieuNhap.Text = B_CT_PHIEUNHAPHANG.GetSumMoney(str).ToString();
            dgvCTPNH.DataSource = B_CT_PHIEUNHAPHANG.getTablebyquery("select * from CT_PHIEUNHAPHANG where MaPhieuNhapHang = " + mapn + "");
            //update tổng tiền phiếu nhập
            string str2 = "  update PHIEUNHAPHANG set TongTienPhieuNhap = " + txtBoxTongTienPhieuNhap.Text + " where MaPhieuNhapHang = " + mapn + "";
            Logic.ExecuteQuery(str2);
            

        }

        private void btnXoaPhieuNhap_Click(object sender, EventArgs e)
        {
            int mactpn = int.Parse(txtMactpn.Text);
            int mapn = int.Parse(txtBoxMaPhieuNhap.Text);
            int mamh = int.Parse(txtMatHang.Text);
            string tenmh = cbBoxTenMatHang.Text;
            int sl = int.Parse(txtSoLuongNhap.Text);
            float dg = float.Parse(txtDonGiaNhap.Text);

            tblCT_PHIEUNHAPHANG ct = new tblCT_PHIEUNHAPHANG(mactpn, mapn, mamh, tenmh, sl, dg);
            B_CT_PHIEUNHAPHANG.XoaChiTietPhieuNhapHang(ct);
            MessageBox.Show("bạn đã xóa 1 chi tiết nhập hàng");
            txtMactpn.Text = "1";
            string str = " select ThanhTien from CT_PHIEUNHAPHANG where MaPhieuNhapHang = " + mapn + "";
            txtBoxTongTienPhieuNhap.Text = B_CT_PHIEUNHAPHANG.GetSumMoney(str).ToString();
            dgvCTPNH.DataSource = B_CT_PHIEUNHAPHANG.getTablebyquery("select * from CT_PHIEUNHAPHANG where MaPhieuNhapHang = " + mapn + "");
            //btnXoa.Enabled = false;
            //btnSua.Enabled = false;
            //update tổng tiền phiếu nhập
            string str2 = "  update PHIEUNHAPHANG set TongTienPhieuNhap = " + txtBoxTongTienPhieuNhap.Text + " where MaPhieuNhapHang = " + mapn + "";
            Logic.ExecuteQuery(str2);
        }

        private void btnTraCuuPhieuNhap_Click(object sender, EventArgs e)
        {
            cbBoxTraCuuPhieuNhap.DataSource = B_PHIEUNHAPHANG.GetAllPhieuNhap();
            cbBoxTraCuuPhieuNhap.DisplayMember = "MaPhieuNhapHang";
            dgvTraCTPhieuNhap.DataSource = B_CT_PHIEUNHAPHANG.GetAllCTPhieuNhap();
            //
            grBoxChiTietPhieuNhap.Hide();
            grBoxDSPhieuNhapHang.Show();
            grBoxTaoPhieuNhapHang.Hide();
            grBoxTraPhieuNhap.Show();
            dgvDSPhieuNhap.DataSource = B_PHIEUNHAPHANG.GetAllPhieuNhap();
            //


        }

        private void btnTraCuuCTPhieuNhap_Click(object sender, EventArgs e)
        {
            dgvTraCTPhieuNhap.DataSource = B_CT_PHIEUNHAPHANG.getTablebyquery("select * from CT_PHIEUNHAPHANG where MaPhieuNhapHang = " + cbBoxTraCuuPhieuNhap.Text + "");
        }

        private void btnDanhSachPhieuNhap_Click(object sender, EventArgs e)
        {
            grBoxChiTietPhieuNhap.Hide();
            grBoxDSPhieuNhapHang.Show();
            grBoxTaoPhieuNhapHang.Hide();
            grBoxTraPhieuNhap.Hide();
            dgvDSPhieuNhap.DataSource = B_PHIEUNHAPHANG.GetAllPhieuNhap();

        }

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            grBoxChiTietPhieuNhap.Show();
            grBoxDSPhieuNhapHang.Hide();
            grBoxTaoPhieuNhapHang.Show();
            grBoxTraPhieuNhap.Hide();
            dgvDSPhieuNhap.DataSource = B_PHIEUNHAPHANG.GetAllPhieuNhap();

        }

 
    }
}
