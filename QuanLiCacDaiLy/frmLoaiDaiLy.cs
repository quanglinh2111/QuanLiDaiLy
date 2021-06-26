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
    public partial class frmLoaiDaiLy : Form
    {
        public frmLoaiDaiLy()
        {
            InitializeComponent();
        }

        private void frmLoaiDaiLy_Load(object sender, EventArgs e)
        {
            dgvLoaiDaiLy.DataSource = Logic.GetTableByQuery("select * from loaidaily");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoPhieuThu_Click(object sender, EventArgs e)
        {
            string query = "select count(MaLoaiDaiLy) from LOAIDAILY";
            int sodailyhienco = int.Parse(Logic.getDatabyquery(query));
            int sodailytoidachophep = int.Parse(Logic.getDatabyquery("select SoLuongLoaiDaiLy from QUIDINH"));
            if (sodailyhienco >= sodailytoidachophep)
                MessageBox.Show("đi ngủ");
            else
            {
                string tenldl = txtBoxTenLDL.Text;
                float sodotoida = float.Parse(txtBoxSoNoToiDa.Text);
                tblLOAIDAILY ldl = new tblLOAIDAILY(0, tenldl, sodotoida);
                B_LOAIDAILY.ThemLoaiDaiLy(ldl);
                dgvLoaiDaiLy.DataSource = Logic.GetTableByQuery("select * from loaidaily");
            }
        }
    }
}
