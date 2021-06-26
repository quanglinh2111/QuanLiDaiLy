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
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            InitializeComponent();
        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            dgvMatHang.DataSource = Logic.GetTableByQuery("select * from MATHANG");
            cbBoxDonViTinh.DataSource = Logic.GetTableByQuery("select * from donvitinh");
            cbBoxDonViTinh.DisplayMember = "donvitinh";
        }

        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            string query = "select count(mamathang) from MATHANG";
            int somhhienco = int.Parse(Logic.getDatabyquery(query));
            int somhchophep = int.Parse(Logic.getDatabyquery("select SoLuongMatHang from QUIDINH"));
            if (somhhienco >= somhchophep)
                MessageBox.Show("đi ngủ");
            else
            {
                string tenmh = txtBoxTenMHM.Text;
                string dvt = cbBoxDonViTinh.Text;

                tblMATHANG mh = new tblMATHANG(0,tenmh,dvt,0);
                B_MATHANG.ThemMatHang(mh);
                dgvMatHang.DataSource = Logic.GetTableByQuery("select * from MATHANG");
            }
        }
    }
}
