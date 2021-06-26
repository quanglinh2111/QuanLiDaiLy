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
    public partial class frmManHinhBaoCaoDoanhSo : Form
    {
        public frmManHinhBaoCaoDoanhSo()
        {
            InitializeComponent();
        }

        private void frmManHinhBaoCaoDoanhSo_Load(object sender, EventArgs e)
        {
            cbBoxThangBCDoanhSo.Items.Add("");
            cbBoxNamBCDoanhSo.Items.Add("");
            for (int i = 2000; i <= 2030; i++)
                cbBoxNamBCDoanhSo.Items.Add(i);
            for (int i = 1; i <= 12; i++)
                cbBoxThangBCDoanhSo.Items.Add(i);
        }

        private void btnLapBCDoanhSo_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cbBoxThangBCDoanhSo.Text);
            int nam = int.Parse(cbBoxNamBCDoanhSo.Text);
            tblBCDOANHSO bc = new tblBCDOANHSO(0, thang, nam, 0);
            int mabc = B_BCDOANHSO.ThemBaoCaoDoanhSo(bc);
            MessageBox.Show("tạo thành công báo cáo doanh số");
            //xuất
            string str = "select a.MaBCDoanhSo, a.SoPhieuXuat, a.TongTriGia, a.TyLe , a.MaDaiLy , b.TenDaiLy  from CT_BCDOANHSO a join DAILY b on a.MaDaiLy = b.MaDaiLy where a.MaBCDoanhSo = " + mabc + "";
            dgvCTBaoCaoDS.DataSource = Logic.GetTableByQuery(str);
        }
    }
}
