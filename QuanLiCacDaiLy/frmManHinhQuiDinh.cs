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

namespace QuanLiCacDaiLy
{
    public partial class frmManHinhQuiDinh : Form
    {
        public frmManHinhQuiDinh()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmManHinhQuiDinh_Load(object sender, EventArgs e)
        {
            txtSoDL.Text = Logic.getDatabyquery("select SoLuongLoaiDaiLy from QUIDINH");
            txtSoDVT.Text = Logic.getDatabyquery("select SoLuongDonViTinh from QUIDINH");
            txtSoMH.Text = Logic.getDatabyquery("select SoLuongMatHang from QUIDINH");
            txtSoDLTD.Text = Logic.getDatabyquery("select GiaTri from THAMSO where TenThamSo like 'soluongdailytoida' ");
            txtTLX.Text = Logic.getDatabyquery("select GiaTri from THAMSO where TenThamSo like 'tyledongiaxuat' ");
        }

        private void btnThemLoaiDL_Click(object sender, EventArgs e)
        {
            int newsodl = int.Parse(txtSoDL.Text);
            newsodl += 1;
            txtSoDL.Text = newsodl.ToString();
        }

        private void btnThemSLMatHang_Click(object sender, EventArgs e)
        {
            int newsodl = int.Parse(txtSoMH.Text);
            newsodl += 1;
            txtSoMH.Text = newsodl.ToString();
        }

        private void btnThemSLDVT_Click(object sender, EventArgs e)
        {
            int newsodl = int.Parse(txtSoDVT.Text);
            newsodl += 1;
            txtSoDVT.Text = newsodl.ToString();
        }

        private void txtTLX_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemTLDGX_Click(object sender, EventArgs e)
        {
            double newsodl = double.Parse(txtTLX.Text);
            newsodl += 0.01;
            txtTLX.Text = newsodl.ToString();
        }

        private void btnThemSLDALTD_Click(object sender, EventArgs e)
        {
            int newsodl = int.Parse(txtSoDLTD.Text);
            newsodl += 1;
            txtSoDLTD.Text = newsodl.ToString();
        }

        private void btnGiamLDL_Click(object sender, EventArgs e)
        {
            int newsodl = int.Parse(txtSoDL.Text);
            newsodl -= 1;
            txtSoDL.Text = newsodl.ToString();
        }

        private void btnGiamSLMH_Click(object sender, EventArgs e)
        {
            int newsodl = int.Parse(txtSoMH.Text);
            newsodl -= 1;
            txtSoMH.Text = newsodl.ToString();
        }

        private void btnGiamSLDVT_Click(object sender, EventArgs e)
        {
            int newsodl = int.Parse(txtSoDVT.Text);
            newsodl -= 1;
            txtSoDVT.Text = newsodl.ToString();
        }

        private void btnGiamTLDGX_Click(object sender, EventArgs e)
        {
            double newsodl = double.Parse(txtTLX.Text);
            newsodl -= 0.01;
            txtTLX.Text = newsodl.ToString();
        }

        private void btnGiamSLDLTD_Click(object sender, EventArgs e)
        {
            int newsodl = int.Parse(txtSoDLTD.Text);
            newsodl -= 1;
            txtSoDLTD.Text = newsodl.ToString();
        }

        private void btnSuaQuiDinh_Click(object sender, EventArgs e)
        {
            int soldl = int.Parse(txtSoDL.Text);
            int sodvt = int.Parse(txtSoDVT.Text);
            int somh = int.Parse(txtSoMH.Text);
            /////////
            int sodltd = int.Parse(txtSoDLTD.Text);
            double tldgx = double.Parse(txtTLX.Text);
            //
            string str1 = "update THAMSO set GiaTri = " + sodltd + " where TenThamSo like 'soluongdailytoida'";
            string str2 = "update THAMSO set GiaTri = " + tldgx + " where TenThamSo like 'tyledongiaxuat'";
            string str3 = "update QUIDINH  set SoLuongLoaiDaiLy = " + soldl + " , SoLuongMatHang = " + somh + ", SoLuongDonViTinh = " + sodvt + "";

            Logic.ExecuteQuery(str1);
            Logic.ExecuteQuery(str2);
            Logic.ExecuteQuery(str3);


            MessageBox.Show("Bạn đã sửa quy định thành công! hú hú");
        }


    }
}
