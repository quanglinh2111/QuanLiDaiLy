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
    public partial class frmManHinhXuatHang : Form
    {
        public frmManHinhXuatHang()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmManHinhXuatHang_Load(object sender, EventArgs e)
        {
            //dgvCTPhieuXuatHang.DataSource = B_CT_PHIEUXUATHANG.GetAllCTPhieuXuat();
            dgvDSPhieuXuat.DataSource = B_PHIEUXUATHANG.GetAllPhieuXuat();
            //combobox
            cbBoxTenMatHang.DataSource = B_MATHANG.GetAllMatHang();
            cbBoxTenMatHang.DisplayMember = "TenMatHang";
            //
            cbBoxTenDL.DataSource = Logic.GetTableByQuery("select * from DAILY");
            cbBoxTenDL.DisplayMember = "TenDaiLy";
            cbBoxTraCuuPhieuXuat.DataSource = Logic.GetTableByQuery("select * from DAILY");
            cbBoxTraCuuPhieuXuat.DisplayMember = "TenDaiLy";
            //
           // pnlTinhToan.Visible = false;
            //thêm item cho tra cứu
            cbBoxNgay.Items.Add("");
            cbBoxThang.Items.Add("");
            for (int i = 1; i <= 31; i++)
                cbBoxNgay.Items.Add(i);
            for (int i = 1; i <= 12; i++)
                cbBoxThang.Items.Add(i);

            grBoxChiTiet.Hide();
            grBoxTaoPhieuXuatHang.Hide();
            grbDanhSachPhieuXuat.Show();
            grbTraCuu.Hide();
            congchieudai();
        }

        private void cbBoxTenDL_TextChanged(object sender, EventArgs e)
        {
            string str;
            // Khi chọn tên thì mã hiện ra
            str = " select MaDaiLy from DAILY where TenDaiLy like '%" + cbBoxTenDL.Text + "%'";
            txtMaDL.Text = Logic.getDatabyquery(str);
        }

     

        private void btnTaoPhieuXuat_Click(object sender, EventArgs e)
        {
            DataTable tb = B_PHIEUXUATHANG.GetAllPhieuXuat();
            int Mapxh = Logic.layma(tb);
            int madl = int.Parse(txtMaDL.Text);
            txtMaPhieuXuat.Text = Mapxh.ToString();
            tblPHIEUXUATHANG px = new tblPHIEUXUATHANG(Mapxh, madl, DateTime.Now, 0, 0, 0);
            B_PHIEUXUATHANG.ThemPhieuXuat(px);
            MessageBox.Show("bạn tạo 1 phiếu xuất hàng");
            //load lại datagridview
            dgvDSPhieuXuat.DataSource = B_PHIEUXUATHANG.GetAllPhieuXuat();
            dgvCTPhieuXuatHang.DataSource = Logic.GetTableByQuery("select * from CT_PHIEUXUATHANG where MaPhieuXuatHang = " + txtMaPhieuXuat.Text + "");

        }

        private void btnOKTaoPhieuXuat_Click(object sender, EventArgs e)
        {
            int mactpx = 0;
            int mapx = int.Parse(txtMaPhieuXuat.Text);
            string tenmh = cbBoxTenMatHang.Text;
            int mamh = int.Parse(txtMaMatHang.Text);
            int sl = int.Parse(txtSoLuong.Text);
            int dg = int.Parse(txtDonGiaXuat.Text);
            int tt = (sl * dg);
            tblCT_PHIEUXUATHANG ct = new tblCT_PHIEUXUATHANG(mactpx, mapx, tenmh, mamh, sl, dg, tt);
            B_CT_PHIEUXUATHANG.ThemChiTietPhieuXuat(ct);
            MessageBox.Show("bạn thêm thành công 1 chi tiết phiếu nhập hàng");
            //load lại datagrigfiew
            dgvCTPhieuXuatHang.DataSource = Logic.GetTableByQuery("select *from CT_PHIEUXUATHANG where MaPhieuXuatHang = " + txtMaPhieuXuat.Text + "");
        }

        private void cbBoxTenMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = " select MaMatHang from MATHANG where TenMatHang like '%" + cbBoxTenMatHang.Text + "%'";
            txtMaMatHang.Text = Logic.getDatabyquery(str);

        }

        private void txtDonGiaXuat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaMatHang_TextChanged(object sender, EventArgs e)
        {
            //select top 1 DonGiaNhap from CT_PHIEUNHAPHANG where TenMatHang like '%iphone%' order by MaPhieuNhapHang desc
            string str = "select top 1 DonGiaNhap from CT_PHIEUNHAPHANG where TenMatHang like '%" + cbBoxTenMatHang.Text + "%' order by MaPhieuNhapHang desc";
            float dgx = float.Parse(Logic.getDatabyquery(str));
            string str2 = "select giatri from thamso where tenthamso like 'tyledongiaxuat'";
            float tyle = float.Parse(Logic.getDatabyquery(str2));
            dgx *= tyle;
            txtDonGiaXuat.Text = dgx.ToString();
        }

        private void btnSuaPhieuXuat_Click(object sender, EventArgs e)
        { 
            int sl = int.Parse(txtSoLuong.Text);
             int dg = int.Parse(txtDonGiaXuat.Text);
             float thanhtienmoi = (sl * dg);
             string query = "update CT_PHIEUXUATHANG set	TenMatHang = '" + cbBoxTenMatHang.Text + "' , MaMatHang= " + txtMaMatHang.Text + ", SoLuongXuat = " + txtSoLuong.Text + " , DonGiaXuat = " + txtDonGiaXuat.Text + " , ThanhTien =" + thanhtienmoi + " where MaCT_PhieuXuatHang = " + txtMaCTPX.Text + "";
            Logic.ExecuteQuery(query);
            MessageBox.Show("sửa thành công chi tiết phiếu xuất hàng thứ : "+ txtMaCTPX.Text+"!");
            dgvCTPhieuXuatHang.DataSource = Logic.GetTableByQuery("select * from CT_PHIEUXUATHANG where MaPhieuXuatHang = " + txtMaPhieuXuat.Text + "");
        }

        private void dgvCTPhieuXuatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvCTPhieuXuatHang.Rows[e.RowIndex];
            txtMaCTPX.Text = row.Cells[0].Value.ToString();
            txtMaMatHang.Text = row.Cells[3].Value.ToString();
            cbBoxTenMatHang.Text = row.Cells[2].Value.ToString();
            txtSoLuong.Text = row.Cells[4].Value.ToString();
            txtDonGiaXuat.Text = row.Cells[5].Value.ToString();
        }

        private void btnXoaPhieuXuat_Click(object sender, EventArgs e)
        {
            string query = "delete from CT_PHIEUXUATHANG where MaCT_PhieuXuatHang = " + txtMaCTPX.Text + "";
            Logic.ExecuteQuery(query);
            MessageBox.Show("xóa thành công!");
            dgvCTPhieuXuatHang.DataSource = Logic.GetTableByQuery("select * from CT_PHIEUXUATHANG where MaPhieuXuatHang = " + txtMaPhieuXuat.Text + "");
        }

        private void btnTraCuuChiTiet_Click(object sender, EventArgs e)
        {
            string str = "";

            if (cbBoxNgay.Text != "" && cbBoxThang.Text == "")
                str = "select * from PHIEUXUATHANG where MaDaiLy in(select MaDaiLy from DAILY where TenDaiLy like '%" + cbBoxTraCuuPhieuXuat.Text + "%')and DAY(NgayLapPhieu) = " + cbBoxNgay.Text + "";
            else if (cbBoxNgay.Text == "" && cbBoxThang.Text != "")
                str = "select * from PHIEUXUATHANG where MaDaiLy in(select MaDaiLy from DAILY where TenDaiLy like '%" + cbBoxTraCuuPhieuXuat.Text + "%')and month(NgayLapPhieu) = " + cbBoxThang.Text + "";
            else if (cbBoxNgay.Text != "" && cbBoxThang.Text != "")
                str = "select * from PHIEUXUATHANG where MaDaiLy in(select MaDaiLy from DAILY where TenDaiLy like '%" + cbBoxTraCuuPhieuXuat.Text + "%') and MONTH(NgayLapPhieu) = " + cbBoxThang.Text + " and DAY(NgayLapPhieu) = " + cbBoxNgay.Text + "";
            else
                str = "select * from PHIEUXUATHANG where MaDaiLy in(select MaDaiLy from DAILY where TenDaiLy like '%" + cbBoxTraCuuPhieuXuat.Text + "%')";
            dgvTraPhieuXuat.DataSource = Logic.GetTableByQuery(str);
        }

        private void btnLapPhieuXuat_Click(object sender, EventArgs e)
        {
            grBoxChiTiet.Show();
            grBoxTaoPhieuXuatHang.Show();
            grbDanhSachPhieuXuat.Hide();
            grbTraCuu.Hide();
            truchieudai();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            grBoxChiTiet.Hide();
            grBoxTaoPhieuXuatHang.Hide();
            grbDanhSachPhieuXuat.Show();
            grbTraCuu.Hide();
            congchieudai();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            grBoxChiTiet.Hide();
            grBoxTaoPhieuXuatHang.Hide();
            grbDanhSachPhieuXuat.Show();
            grbTraCuu.Show();
            truchieudai();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "select ThanhTien from CT_PHIEUXUATHANG where MaPhieuXuatHang =" + txtMaPhieuXuat.Text + "";
            txtBoxTongTienPhieuXuat.Text = Logic.GetSumMoney(str).ToString();
            txtConLai.Text = txtBoxTongTienPhieuXuat.Text;
            grBoxTongTienPhieuXuat.Visible = true;
        }

        private void txtDLTra_TextChanged(object sender, EventArgs e)
        {

            float tongtienphieuxuat = float.Parse(txtBoxTongTienPhieuXuat.Text);
            float sotiendltra = 0;
            if (float.TryParse(txtDLTra.Text, out sotiendltra))
            {
                sotiendltra = float.Parse(txtDLTra.Text);
            }

            if (sotiendltra > tongtienphieuxuat)
            {
                MessageBox.Show("số tiền trả phải nhỏ hơn hoặc bằng tổng tiền phiếu xuất");
                txtDLTra.Text = "";
                sotiendltra = 0;
                txtConLai.Text = txtBoxTongTienPhieuXuat.Text;
            }

            txtConLai.Text = (tongtienphieuxuat - sotiendltra).ToString();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            //kiem tra tổng nợ đại lý
            string query1 = "select SoTienNoToiDa from LOAIDAILY where MaLoaiDaiLy in(select MaLoaiDaiLy from DAILY where TenDaiLy like '%" + cbBoxTenDL.Text + "%')";
            float notoidaldl = float.Parse(Logic.getDatabyquery(query1));
            //kiểm tra tổng nợ của đại lý + với số tiền còn lại xem có quá số tiền nợ tối đá hay không
            string query2 = "select TongNo from DAILY where TenDaiLy like '%" + cbBoxTenDL.Text + "%'";
            float nodaily = float.Parse(Logic.getDatabyquery(query2));
            //số tiền nợ mới của đại lý
            float nomoi = float.Parse(txtConLai.Text);
            if ((nodaily + nomoi) > notoidaldl)
            {
                MessageBox.Show("nợ không được nhiều hơn : " + notoidaldl + "");
            }
            else
            {
                float sotiendltra;
                if (txtDLTra.Text == "")
                    sotiendltra = 0;
                else
                    sotiendltra = float.Parse(txtDLTra.Text);
                //cập nhật lại phiếu xuất khi đã nhập xong chi tiết phiếu xuất
                string str = "update PHIEUXUATHANG set TongTienPhieuXuat = " + txtBoxTongTienPhieuXuat.Text + ", SoTienTra = " + sotiendltra + " , ConLai = " + txtConLai.Text + " where MaPhieuXuatHang =" + txtMaPhieuXuat.Text + "";
                Logic.ExecuteQuery(str);
                MessageBox.Show("bạn hoàn thành 1 phiếu nhập");
                dgvDSPhieuXuat.DataSource = B_PHIEUXUATHANG.GetAllPhieuXuat();
                grBoxTongTienPhieuXuat.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxTongTienPhieuXuat_TextChanged(object sender, EventArgs e)
        {

        }
        private void congchieudai()
        {
            grbDanhSachPhieuXuat.Height = 350;
            dgvDSPhieuXuat.Height = 300;
        }
        private void truchieudai()
        {
            grbDanhSachPhieuXuat.Height = 180;
            dgvDSPhieuXuat.Height = 150;
        }

    }
}
