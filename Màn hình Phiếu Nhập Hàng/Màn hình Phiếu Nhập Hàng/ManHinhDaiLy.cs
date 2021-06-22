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
    public partial class ManHinhDaiLy : Form
    {
        public ManHinhDaiLy()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ManHinhDaiLy_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = B_DaiLy.GetAllDaiLy();
        }

        private void grBoxMain_Enter(object sender, EventArgs e)
        {

        }
    }
}
