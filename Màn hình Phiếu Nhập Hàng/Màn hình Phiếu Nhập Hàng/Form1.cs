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
    public partial class frmManHinhPhieuNhap : Form
    {
        public frmManHinhPhieuNhap()
        {
            InitializeComponent();
        }

      

        private void frmManHinhPhieuNhapHang_Load(object sender, EventArgs e)
        {
            dgvDSPhieuNhap.DataSource = B_PhieuNhapHang.GetAllPhieuNhap();           
            ccbTenMH.DataSource = B_MATHANG.GetAllMatHang();
            ccbTenMH.DisplayMember = "TenMatHang";
            //
            txtTong.Text = "0";
            //
            grbDsPhieuNhap.Show();
            grbTaoPhieu.Hide();
            dgvDSPhieuNhap.Show();
            dgvCTPNH.Hide();
        }  

        //lập phiếu
        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
           
            int mapn = B_PhieuNhapHang.ThemThongTinPhieuNhap();
            MessageBox.Show("bạn đã tạo mới 1 phiếu nhập hàng");
            dgvDSPhieuNhap.DataSource = B_PhieuNhapHang.GetAllPhieuNhap();
            txtMPN.Text = mapn.ToString();         
            dgvCTPNH.DataSource = B_CT_PHIEUNHAPHANG.getTablebyquery("select * from CT_PHIEUNHAPHANG where MaPhieuNhapHang = "+mapn+"");
            txtDonGiaNhap.Text = "0";
            txtSoLuongNhap.Text = "0";
            //
            grbDsPhieuNhap.Hide();
            grbTaoPhieu.Show();
            dgvDSPhieuNhap.Hide();
            dgvCTPNH.Show();
            dgvTraCTPhieuNhap.Hide();


        }
        //tạo chi tiết phiếu
        private void btnTao_Click(object sender, EventArgs e)
        {
            //int mactpn = int.Parse(txtMaCTPhieuNhap.Text);
            

            int mactpn = 0;
            int mapn = int.Parse(txtMPN.Text);
            int mamh= int.Parse(txtMaMH.Text);
            string tenmh= ccbTenMH.Text;        
            int sl=int.Parse(txtSoLuongNhap.Text);            
            float dg = float.Parse(txtDonGiaNhap.Text);

            tblCT_PHIEUNHAPHANG ct = new tblCT_PHIEUNHAPHANG(mactpn,mapn,mamh,tenmh,sl,dg);
            B_CT_PHIEUNHAPHANG.ThemChiTietPhieuNhap(ct);
            MessageBox.Show("bạn đã thêm 1 chi tiết nhập hàng");
            dgvCTPNH.DataSource = B_CT_PHIEUNHAPHANG.getTablebyquery("select * from CT_PHIEUNHAPHANG where MaPhieuNhapHang = " + mapn + "");
            //
            string str = " select ThanhTien from CT_PHIEUNHAPHANG where MaPhieuNhapHang = " + mapn + "";
            txtTong.Text= B_CT_PHIEUNHAPHANG.GetSumMoney(str).ToString();
        }

        private void ccbTenMH_TextChanged(object sender, EventArgs e)
        {
            string str;
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = " select MaMatHang from MATHANG where TenMatHang like '%"+ccbTenMH.Text+"%'";
            txtMaMH.Text = B_CT_PHIEUNHAPHANG.getDatabyquery(str);
        }


        private void dgvCTPNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCTPNH.Rows[e.RowIndex];
                txtMactpn.Text = row.Cells[0].Value.ToString();
                txtMPN.Text = row.Cells[1].Value.ToString();
                txtMaMH.Text = row.Cells[2].Value.ToString();
                ccbTenMH.Text = row.Cells[3].Value.ToString();
                txtSoLuongNhap.Text = row.Cells[4].Value.ToString();
                txtDonGiaNhap.Text = row.Cells[5].Value.ToString();

            }
            catch
            {

            }
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int mactpn = int.Parse(txtMactpn.Text);
            int mapn = int.Parse(txtMPN.Text);
            int mamh = int.Parse(txtMaMH.Text);
            string tenmh = ccbTenMH.Text;
            int sl = int.Parse(txtSoLuongNhap.Text);
            float dg = float.Parse(txtDonGiaNhap.Text);

            tblCT_PHIEUNHAPHANG ct = new tblCT_PHIEUNHAPHANG(mactpn, mapn, mamh, tenmh, sl, dg);
            B_CT_PHIEUNHAPHANG.XoaChiTietPhieuNhapHang(ct);
            MessageBox.Show("bạn đã xóa 1 chi tiết nhập hàng");
            txtMactpn.Text = "1";
            string str = " select ThanhTien from CT_PHIEUNHAPHANG where MaPhieuNhapHang = " + mapn + "";
            txtTong.Text = B_CT_PHIEUNHAPHANG.GetSumMoney(str).ToString();
            dgvCTPNH.DataSource = B_CT_PHIEUNHAPHANG.getTablebyquery("select * from CT_PHIEUNHAPHANG where MaPhieuNhapHang = " + mapn + "");
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            int mactpn = int.Parse(txtMactpn.Text);
            int mapn = int.Parse(txtMPN.Text);
            int mamh = int.Parse(txtMaMH.Text);
            string tenmh = ccbTenMH.Text;
            int sl = int.Parse(txtSoLuongNhap.Text);
            float dg = float.Parse(txtDonGiaNhap.Text);
            tblCT_PHIEUNHAPHANG ct = new tblCT_PHIEUNHAPHANG(mactpn, mapn, mamh, tenmh, sl, dg);
            B_CT_PHIEUNHAPHANG.SuaChiTietPhieuNhapHang(ct);
            MessageBox.Show("bạn đã sửa thành công");
            txtMactpn.Text = "1"; 
            string str = " select ThanhTien from CT_PHIEUNHAPHANG where MaPhieuNhapHang = " + mapn + "";
            txtTong.Text = B_CT_PHIEUNHAPHANG.GetSumMoney(str).ToString();
            dgvCTPNH.DataSource = B_CT_PHIEUNHAPHANG.getTablebyquery("select * from CT_PHIEUNHAPHANG where MaPhieuNhapHang = "+mapn+"");
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dgvDSPhieuNhap.Show();
            dgvCTPNH.Hide();
            grbDsPhieuNhap.Show();
            grbTaoPhieu.Hide();
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            dgvTraCTPhieuNhap.DataSource = B_CT_PHIEUNHAPHANG.getTablebyquery("select * from CT_PHIEUNHAPHANG where MaPhieuNhapHang = "+txtTra.Text+"");
        }

       
    }
}
