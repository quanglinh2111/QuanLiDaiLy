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
    public partial class ManHinhXuatHang : Form
    {
        public ManHinhXuatHang()
        {
            InitializeComponent();
        }

        private void ManHinhXuatHang_Load(object sender, EventArgs e)
        {
            //dgvCTPhieuXuatHang.DataSource = B_CT_PHIEUXUATHANG.GetAllCTPhieuXuat();
            dgvDSPhieuXuat.DataSource = B_PHIEUXUATHANG.GetAllPhieuXuat();
            //combobox
            ccbTenMH.DataSource = B_MATHANG.GetAllMatHang();
            ccbTenMH.DisplayMember = "TenMatHang";
            //
            ccbTenDL.DataSource = Logic.GetTableByQuery("select * from DAILY");
            ccbTenDL.DisplayMember = "TenDaiLy";
            ccbTraDl.DataSource = Logic.GetTableByQuery("select * from DAILY");
            ccbTraDl.DisplayMember = "TenDaiLy";
            //
            pnlTinhToan.Visible = false;
            //thêm item cho tra cứu
            ccbNgay.Items.Add("");
            ccbThang.Items.Add("");
            for (int i = 1; i <= 31; i++)
                ccbNgay.Items.Add(i);
            for (int i = 1; i <= 12; i++)
                ccbThang.Items.Add(i);
            //
            grbChiTietPhieuXuat.Hide();
            grbDanhSachPhieuXuat.Show();
            grbTaoMoiPhieuXuat.Hide();
            grbTraPhieuXuat.Hide();
            congchieudai();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

      

        private void ccbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            // Khi chọn tên thì mã hiện ra
            str = " select MaMatHang from MATHANG where TenMatHang like '%" + ccbTenMH.Text + "%'";
            txtMaMatHang.Text = Logic.getDatabyquery(str);
        }
        //thêm ct phiếu xuất
        private void btnThemCTPX_Click(object sender, EventArgs e)
        {
            int mactpx = 0;
            int mapx = int.Parse(txtMaPhieuXuat.Text);
            string tenmh = ccbTenMH.Text;
            int mamh = int.Parse(txtMaMatHang.Text);
            int sl = int.Parse(txtSoLuongXuat.Text);
            int dg = int.Parse(txtDonGiaXuat.Text);
            int tt = (sl * dg);
            tblCT_PHIEUXUATHANG ct = new tblCT_PHIEUXUATHANG(mactpx, mapx, tenmh, mamh, sl, dg, tt);
            B_CT_PHIEUXUATHANG.ThemChiTietPhieuXuat(ct);
            MessageBox.Show("bạn thêm thành công 1 chi tiết phiếu nhập hàng");
            //load lại datagrigfiew
            dgvCTPhieuXuatHang.DataSource = Logic.GetTableByQuery("select *from CT_PHIEUXUATHANG where MaPhieuXuatHang = " + txtMaPhieuXuat.Text + "");
        }
        //thêm phiếu  xuất
        private void btnTaoPhieuXuat_Click(object sender, EventArgs e)
        {
            DataTable tb = B_PHIEUXUATHANG.GetAllPhieuXuat();
            int Mapxh = Logic.layma(tb);
            int madl = int.Parse(txtMaDL.Text);
            txtMaPhieuXuat.Text = Mapxh.ToString();
            tblPHIEUXUATHANG px = new tblPHIEUXUATHANG(Mapxh, madl,DateTime.Now,0,0,0);
            B_PHIEUXUATHANG.ThemPhieuXuat(px);
            MessageBox.Show("bạn tạo 1 phiếu xuất hàng");
            //load lại datagridview
            dgvDSPhieuXuat.DataSource = B_PHIEUXUATHANG.GetAllPhieuXuat();
            dgvCTPhieuXuatHang.DataSource = Logic.GetTableByQuery("select * from CT_PHIEUXUATHANG where MaPhieuXuatHang = " + txtMaPhieuXuat.Text + "");

        }

        private void ccbTenDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            // Khi chọn tên thì mã hiện ra
            str = " select MaDaiLy from DAILY where TenDaiLy like '%" + ccbTenDL.Text + "%'";
           txtMaDL.Text = Logic.getDatabyquery(str);
        }

        private void txtMaMatHang_TextChanged(object sender, EventArgs e)
        {
            //select top 1 DonGiaNhap from CT_PHIEUNHAPHANG where TenMatHang like '%iphone%' order by MaPhieuNhapHang desc
            string str = "select top 1 DonGiaNhap from CT_PHIEUNHAPHANG where TenMatHang like '%"+ccbTenMH.Text+"%' order by MaPhieuNhapHang desc";
            float dgx = float.Parse(Logic.getDatabyquery(str));
            dgx *= 102;
            dgx /= 100;
            txtDonGiaXuat.Text = dgx.ToString();
        }

        private void btnKetThucNhapPhieu_Click(object sender, EventArgs e)
        {
            string str = "select ThanhTien from CT_PHIEUXUATHANG where MaPhieuXuatHang =" + txtMaPhieuXuat.Text + "";
            txtTongTienPX.Text = Logic.GetSumMoney(str).ToString();
            txtConLai.Text = txtTongTienPX.Text;
            pnlTinhToan.Visible = true;
           
        }
        private void txtSoTienDLTra_TextChanged(object sender, EventArgs e)
        {
            float tongtienphieuxuat = float.Parse(txtTongTienPX.Text);
            float sotiendltra =0;
            if (float.TryParse(txtSoTienDLTra.Text, out sotiendltra))
            {
                 sotiendltra = float.Parse(txtSoTienDLTra.Text);
            }
            
            if (sotiendltra > tongtienphieuxuat)
            {
                MessageBox.Show("số tiền trả phải nhỏ hơn hoặc bằng tổng tiền phiếu xuất");
                txtSoTienDLTra.Text = "";
                sotiendltra = 0;
                txtConLai.Text = txtTongTienPX.Text;
            }    
           
            txtConLai.Text = (tongtienphieuxuat - sotiendltra).ToString();
              
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            //kiem tra tổng nợ đại lý
            string query1 = "select SoTienNoToiDa from LOAIDAILY where MaLoaiDaiLy in(select MaLoaiDaiLy from DAILY where TenDaiLy like '%"+ccbTenDL.Text+"%')";
            float notoidaldl = float.Parse(Logic.getDatabyquery(query1));
            //kiểm tra tổng nợ của đại lý + với số tiền còn lại xem có quá số tiền nợ tối đá hay không
            string query2 = "select TongNo from DAILY where TenDaiLy like '%"+ccbTenDL.Text+"%'";
            float nodaily = float.Parse(Logic.getDatabyquery(query2));
            //số tiền nợ mới của đại lý
            float nomoi = float.Parse(txtConLai.Text);
            if((nodaily + nomoi)>notoidaldl)
            {
                MessageBox.Show("nợ không được nhiều hơn : "+notoidaldl+"");
            }
            else {            
                float sotiendltra;
                if (txtSoTienDLTra.Text == "")
                    sotiendltra = 0;
                else
                    sotiendltra = float.Parse(txtSoTienDLTra.Text);
               //cập nhật lại phiếu xuất khi đã nhập xong chi tiết phiếu xuất
            string str = "update PHIEUXUATHANG set TongTienPhieuXuat = "+txtTongTienPX.Text+", SoTienTra = "+ sotiendltra + " , ConLai = "+txtConLai.Text+" where MaPhieuXuatHang ="+txtMaPhieuXuat.Text+"";
            Logic.ExecuteQuery(str);
            MessageBox.Show("bạn hoàn thành 1 phiếu nhập");          
            dgvDSPhieuXuat.DataSource = B_PHIEUXUATHANG.GetAllPhieuXuat();
            pnlTinhToan.Visible = false;
            }
            

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            string str = "";

            if (ccbNgay.Text != "" && ccbThang.Text == "")
                str = "select * from PHIEUXUATHANG where MaDaiLy in(select MaDaiLy from DAILY where TenDaiLy like '%"+ccbTraDl.Text+"%')and DAY(NgayLapPhieu) = " + ccbNgay.Text + "";
            else if (ccbNgay.Text == "" && ccbThang.Text != "")
                str = "select * from PHIEUXUATHANG where MaDaiLy in(select MaDaiLy from DAILY where TenDaiLy like '%" + ccbTraDl.Text + "%')and month(NgayLapPhieu) = " + ccbThang.Text + "";
            else if (ccbNgay.Text != "" && ccbThang.Text != "")
                str = "select * from PHIEUXUATHANG where MaDaiLy in(select MaDaiLy from DAILY where TenDaiLy like '%" + ccbTraDl.Text + "%') and MONTH(NgayLapPhieu) = " + ccbThang.Text+" and DAY(NgayLapPhieu) = "+ccbNgay.Text+"";
            else
                str = "select * from PHIEUXUATHANG where MaDaiLy in(select MaDaiLy from DAILY where TenDaiLy like '%" + ccbTraDl.Text + "%')";
            dgvTraPhieuXuat.DataSource = Logic.GetTableByQuery(str);
                       
        }

        private void dgvCTPhieuXuatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                    DataGridViewRow row = new DataGridViewRow();
                    row = dgvCTPhieuXuatHang.Rows[e.RowIndex];
                    txtMaCTPX.Text = row.Cells[0].Value.ToString();
                    txtMaMatHang.Text = row.Cells[3].Value.ToString();
                    ccbTenMH.Text = row.Cells[2].Value.ToString();
                    txtSoLuongXuat.Text = row.Cells[4].Value.ToString();
                    txtDonGiaXuat.Text = row.Cells[5].Value.ToString();
        }
        //xóa chi tiết phiếu nhập
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "delete from CT_PHIEUXUATHANG where MaCT_PhieuXuatHang = "+txtMaCTPX.Text+"";
            Logic.ExecuteQuery(query);
            MessageBox.Show("xóa thành công!");
            dgvCTPhieuXuatHang.DataSource = Logic.GetTableByQuery("select * from CT_PHIEUXUATHANG where MaPhieuXuatHang = " + txtMaPhieuXuat.Text + "");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(txtSoLuongXuat.Text);
            int dg = int.Parse(txtDonGiaXuat.Text);
            float thanhtienmoi = (sl * dg);
            string query = "update CT_PHIEUXUATHANG set	TenMatHang = '"+ccbTenMH.Text+"' , MaMatHang= "+txtMaMatHang.Text+", SoLuongXuat = "+txtSoLuongXuat.Text+" , DonGiaXuat = "+txtDonGiaXuat.Text+" , ThanhTien ="+thanhtienmoi+" where MaCT_PhieuXuatHang = "+txtMaCTPX.Text+"";
            Logic.ExecuteQuery(query);
            MessageBox.Show("sửa thành công chi tiết phiếu xuất hàng thứ : "+txtMaCTPX.Text+"!");
            dgvCTPhieuXuatHang.DataSource = Logic.GetTableByQuery("select * from CT_PHIEUXUATHANG where MaPhieuXuatHang = " + txtMaPhieuXuat.Text + "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grbChiTietPhieuXuat.Hide();
            grbDanhSachPhieuXuat.Show();
            grbTaoMoiPhieuXuat.Hide();
            grbTraPhieuXuat.Hide();
            congchieudai();
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            grbChiTietPhieuXuat.Show();
            grbDanhSachPhieuXuat.Hide();
            grbTaoMoiPhieuXuat.Show();
            grbTraPhieuXuat.Hide();
            truchieudai();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            grbChiTietPhieuXuat.Hide();
            grbDanhSachPhieuXuat.Show();
            grbTaoMoiPhieuXuat.Hide();
            grbTraPhieuXuat.Show();
            truchieudai();
        }

        private void congchieudai()
        {
            grbDanhSachPhieuXuat.Height = 460;
            dgvDSPhieuXuat.Height = 400;
        }
        private void truchieudai()
        {
            grbDanhSachPhieuXuat.Height = 240;
            dgvDSPhieuXuat.Height = 169;
        }
    }
}
