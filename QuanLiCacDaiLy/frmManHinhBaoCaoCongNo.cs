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
    public partial class frmManHinhBaoCaoCongNo : Form
    {
        public frmManHinhBaoCaoCongNo()
        {
            InitializeComponent();
        }

        private void ManHinhBaoCaoCongNo_Load(object sender, EventArgs e)
        {
            cbBoxNamBCCongNo.Items.Add("");
            cbBoxThangBCCongNo.Items.Add("");
            for (int i = 2010; i <= 2025; i++)
                cbBoxNamBCCongNo.Items.Add(i);
            for (int i = 1; i <= 12; i++)
                cbBoxThangBCCongNo.Items.Add(i);
        }


        private void btnLapBCCongNo_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cbBoxThangBCCongNo.Text);
            int nam = int.Parse(cbBoxNamBCCongNo.Text);
            tblBCCONGNO bc = new tblBCCONGNO(0, thang, nam);
            int ma = B_BCCONGNO.ThemBaoCaoCongNo(bc);
            dgvCTBaoCaoCongNo.DataSource = Logic.GetTableByQuery("select * from CT_BCCONGNO where MaBCCongNo ="+ma+"");
        }


    }
}
