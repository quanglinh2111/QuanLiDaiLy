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
            dgvDSPhieuNhap.DataSource = B_PHIEUNHAPHANG.GetAllPhieuNhap();
            //lấy giá trị của cột mã mặt hàng truyền vào ccb
            ccbTenMH.DataSource = B_MATHANG.GetAllMatHang();
            ccbTenMH.DisplayMember = "TenMatHang";
            //

            //
            grbChiTietPhieuNhap.Hide();
            grbDanhSachPhieunhạp.Show();
            grbTaoPhieu.Hide();
            grbTraCuuPhieuNhap.Hide();
            congchieudai();
        }  

        //lập phiếu menu

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
            txtTongTien.Text= B_CT_PHIEUNHAPHANG.GetSumMoney(str).ToString();
            //
            string str2 = "  update PHIEUNHAPHANG set TongTienPhieuNhap = " + txtTongTien.Text + " where MaPhieuNhapHang = "+mapn+"";
            Logic.ExecuteQuery(str2);
          
        }
        //ccbox thay đổi
        private void ccbTenMH_TextChanged(object sender, EventArgs e)
        {
            string str;
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = " select MaMatHang from MATHANG where TenMatHang like '%"+ccbTenMH.Text+"%'";
            txtMaMH.Text = B_CT_PHIEUNHAPHANG.getDatabyquery(str);
        }

        //nhấp vào row trong bảng thì nhảy thông tin lên form
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
            txtTongTien.Text = B_CT_PHIEUNHAPHANG.GetSumMoney(str).ToString();
            dgvCTPNH.DataSource = B_CT_PHIEUNHAPHANG.getTablebyquery("select * from CT_PHIEUNHAPHANG where MaPhieuNhapHang = " + mapn + "");
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            //update tổng tiền phiếu nhập
            string str2 = "  update PHIEUNHAPHANG set TongTienPhieuNhap = " + txtTongTien.Text + " where MaPhieuNhapHang = " + mapn + "";
            Logic.ExecuteQuery(str2);
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
            txtTongTien.Text = B_CT_PHIEUNHAPHANG.GetSumMoney(str).ToString();
            dgvCTPNH.DataSource = B_CT_PHIEUNHAPHANG.getTablebyquery("select * from CT_PHIEUNHAPHANG where MaPhieuNhapHang = "+mapn+"");
            //update tổng tiền phiếu nhập
            string str2 = "  update PHIEUNHAPHANG set TongTienPhieuNhap = " + txtTongTien.Text + " where MaPhieuNhapHang = " + mapn + "";
            Logic.ExecuteQuery(str2);
        }

        // tự động tạo 1 phiếu nhập hàng khi bấm vào tạo mới phiếu nhập
        private void button2_Click(object sender, EventArgs e)
        {
            int mapn = B_PHIEUNHAPHANG.ThemThongTinPhieuNhap();
            MessageBox.Show("bạn đã tạo mới 1 phiếu nhập hàng");
            dgvDSPhieuNhap.DataSource = B_PHIEUNHAPHANG.GetAllPhieuNhap();
            txtMPN.Text = mapn.ToString();
            dgvCTPNH.DataSource = B_CT_PHIEUNHAPHANG.getTablebyquery("select * from CT_PHIEUNHAPHANG where MaPhieuNhapHang = " + mapn + "");
            txtDonGiaNhap.Text = "0";
            txtSoLuongNhap.Text = "0";
        }
        //tra cuu phiêu nhap hang khi biết mã phiêu nhập
        private void button1_Click(object sender, EventArgs e)
        {

            dgvTraCTPhieuNhap.DataSource = B_CT_PHIEUNHAPHANG.getTablebyquery("select * from CT_PHIEUNHAPHANG where MaPhieuNhapHang = "+txtTra.Text+"");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            grbChiTietPhieuNhap.Show();
            grbDanhSachPhieunhạp.Hide();
            grbTaoPhieu.Show();
            grbTraCuuPhieuNhap.Hide();
            truchieudai();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grbChiTietPhieuNhap.Hide();
            grbDanhSachPhieunhạp.Show();
            grbTaoPhieu.Hide();
            grbTraCuuPhieuNhap.Hide();
            //load lại khi update tính tổng
            dgvDSPhieuNhap.DataSource = B_PHIEUNHAPHANG.GetAllPhieuNhap();
            congchieudai();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            grbChiTietPhieuNhap.Hide();
            grbDanhSachPhieunhạp.Show();
            grbTaoPhieu.Hide();
            grbTraCuuPhieuNhap.Show();
            //load lại khi update tính tổng
            dgvDSPhieuNhap.DataSource = B_PHIEUNHAPHANG.GetAllPhieuNhap();
            truchieudai();

        }

        private void congchieudai()
        {
            grbDanhSachPhieunhạp.Height = 460;
            dgvDSPhieuNhap.Height = 400;
        }
        private void truchieudai()
        {
            grbDanhSachPhieunhạp.Height = 240;
            dgvDSPhieuNhap.Height = 169;
        }
    }
}
