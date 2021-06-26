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
    public partial class frmQUAN : Form
    {
        public frmQUAN()
        {
            InitializeComponent();
        }

        private void btnThemLoaiDl_Click(object sender, EventArgs e)
        {
            string tentuan = txtBoxTenQuan.Text;
            tblQUAN q = new tblQUAN(0, tentuan);
            B_QUAN.ThemQuan(q);
            MessageBox.Show("Thêm thành công "+tentuan+" vào danh sách các quận");
            dgvQuan.DataSource = Logic.GetTableByQuery("select * from QUAN");

        }

        private void frmQUAN_Load(object sender, EventArgs e)
        {
            dgvQuan.DataSource = Logic.GetTableByQuery("select * from QUAN");

        }
    }
}
