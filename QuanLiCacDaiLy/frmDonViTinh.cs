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
    public partial class frmDonViTinh : Form
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            dgvDonViTinh.DataSource = Logic.GetTableByQuery("select * from donvitinh");

        }

        private void btnThemDVT_Click(object sender, EventArgs e)
        {
            string query = "select count(donvitinh) from donvitinh";
            int sodvthienco = int.Parse(Logic.getDatabyquery(query));
            int sodvtchophep = int.Parse(Logic.getDatabyquery("select SoLuongDonViTinh from QUIDINH"));
            if (sodvthienco >= sodvtchophep)
                MessageBox.Show("đi ngủ");
            else
            {
                string dvt = txtBoxTenDVT.Text;
                
                tblDONVITINH donvitinh = new tblDONVITINH(dvt);
                B_DONVITINH.ThemDonViTinh(donvitinh);
                dgvDonViTinh.DataSource = Logic.GetTableByQuery("select * from donvitinh");
            }
        }
    }
}
