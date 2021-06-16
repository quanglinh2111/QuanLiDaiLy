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
    public partial class frmManHinhPhieuNhapHang : Form
    {
        public frmManHinhPhieuNhapHang()
        {
            InitializeComponent();
        }

      

        private void frmManHinhPhieuNhapHang_Load(object sender, EventArgs e)
        {
            dgvDSPhieuNhap.DataSource = B_PhieuNhapHang.GetAllPhieuNhap();
            dgvCTPNH.DataSource = B_CT_PHIEUNHAPHANG.GetAllCTPhieuNhap();
            ccbTenMH.DataSource = B_MATHANG.GetAllMatHang();
            ccbTenMH.DisplayMember = "TenMatHang";
            //
            string str;
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = " select MaMatHang from MATHANG where TenMatHang like '%" + ccbTenMH.Text + "%'";
            dgv1.DataSource = B_CT_PHIEUNHAPHANG.getDatabyquery(str);

        }  


        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
           
            int ma = B_PhieuNhapHang.ThemThongTinPhieuNhap();
            MessageBox.Show("bạn đã tạo mới 1 phiếu nhập hàng");
            dgvDSPhieuNhap.DataSource = B_PhieuNhapHang.GetAllPhieuNhap();
            txtMPN.Text = ma.ToString();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            //int mactpn = int.Parse(txtMaCTPhieuNhap.Text);
            int mactpn = 0;
            int mapn = int.Parse(txtMPN.Text);   
            int mamh = int.Parse(txtMaMH.Text);
            string tenmh = ccbTenMH.Text;
            int sl = int.Parse(txtSoLuongNhap.Text);
            float dg = float.Parse(txtDonGiaNhap.Text);
            float tt = float.Parse(txtDonGiaNhap.Text);
            tblCT_PHIEUNHAPHANG ct = new tblCT_PHIEUNHAPHANG(mactpn,mapn,mamh,tenmh,sl,dg,tt);
            B_CT_PHIEUNHAPHANG.ThemChiTietPhieuNhap(ct);
            dgvCTPNH.DataSource = B_CT_PHIEUNHAPHANG.GetAllCTPhieuNhap();
        }

        private void ccbTenMH_TextChanged(object sender, EventArgs e)
        {
            string str;
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = " select MaMatHang from MATHANG where TenMatHang like '%"+ccbTenMH.SelectedIndex+"%'";
            dgv1.DataSource = B_CT_PHIEUNHAPHANG.getDatabyquery(str);
        }
    }
}
