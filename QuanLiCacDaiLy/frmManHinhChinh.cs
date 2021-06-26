using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCacDaiLy
{
    public partial class frmManHinhChinh : Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
        }

        private void tsDSDaiLy_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmManHinhDaiLy"))
            {
                frmManHinhDaiLy frm = new frmManHinhDaiLy();
                frm.MdiParent = this;
                frm.Name = "frmManHinhDaiLy";
                frm.Show();
            }

            else ActiveChildForm("frmManHinhDaiLy");
            
        }

        private void phiếuXuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!CheckExitsForm("frmManHinhXuatHang"))
            {
                frmManHinhXuatHang frm = new frmManHinhXuatHang();
                frm.MdiParent = this;
                frm.Name = "frmManHinhXuatHang";
                frm.Show();
            }

            else ActiveChildForm("frmManHinhXuatHang");
           

        }

        private void tsBCDoanhSo_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmManHinhBaoCaoDoanhSo"))
            {
                frmManHinhBaoCaoDoanhSo frm = new frmManHinhBaoCaoDoanhSo();
                frm.MdiParent = this;
                frm.Name = "frmManHinhBaoCaoDoanhSo";
                frm.Show();
            }

            else ActiveChildForm("frmManHinhBaoCaoDoanhSo");
            
        }

        private void tsBCCongNo_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmManHinhBaoCaoCongNo"))
            {
                frmManHinhBaoCaoCongNo frm = new frmManHinhBaoCaoCongNo();
                frm.MdiParent = this;
                frm.Name = "frmManHinhBaoCaoCongNo";
                frm.Show();
            }

            else ActiveChildForm("frmManHinhBaoCaoCongNo");
          

        }

        private void tsNhapHang_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmManHinhPhieuNhapHang"))
            {
                frmManHinhPhieuNhapHang frm = new frmManHinhPhieuNhapHang();
                frm.MdiParent = this;
                frm.Name = "frmManHinhPhieuNhapHang";
                frm.Show();
            }

            else ActiveChildForm("frmManHinhPhieuNhapHang");
           
        }


        private void tsThongTin_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmManHinhThongTin"))
            {
                frmManHinhThongTin frm = new frmManHinhThongTin();
                frm.MdiParent = this;
                frm.Name = "frmManHinhThongTin";
                frm.Show();
            }

            else ActiveChildForm("frmManHinhThongTin");
            
        }

        private void tsPhieuThuTien_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmPhieuThuTien"))
            {
                frmPhieuThuTien frm = new frmPhieuThuTien();
                frm.MdiParent = this;
                frm.Name = "frmPhieuThuTien";
                frm.Show();
            }

            else ActiveChildForm("frmPhieuThuTien");

        }

        private void lsSuaQD_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmManHinhQuiDinh"))
            {
                frmManHinhQuiDinh frm = new frmManHinhQuiDinh();
                frm.MdiParent = this;
                frm.Name = "frmManHinhQuiDinh";
                frm.Show();
            }

            else ActiveChildForm("frmManHinhQuiDinh");
        }


        private void lsLoaiDaiLy_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmLoaiDaiLy"))
            {
                frmLoaiDaiLy frm = new frmLoaiDaiLy();
                frm.MdiParent = this;
                frm.Name = "frmLoaiDaiLy";
                frm.Show();
            }

            else ActiveChildForm("frmLoaiDaiLy");
        }


        private void lsQuanMoi_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmQUAN"))
            {
                frmQUAN frm = new frmQUAN();
                frm.MdiParent = this;
                frm.Name = "frmQUAN";
                frm.Show();
            }

            else ActiveChildForm("frmQUAN");

        }


        private void lsMatHang_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmMatHang"))
            {
                frmMatHang frm = new frmMatHang();
                frm.MdiParent = this;
                frm.Name = "frmMatHang";
                frm.Show();
            }

            else ActiveChildForm("frmMatHang");
        }

        private void lsDonViTinh_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmDonViTinh"))
            {
                frmDonViTinh frm = new frmDonViTinh();
                frm.MdiParent = this;
                frm.Name = "frmDonViTinh";
                frm.Show();
            }

            else ActiveChildForm("frmDonViTinh");

        }




        private bool CheckExitsForm( string name)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }


        private void ActiveChildForm(string name)
        {
            foreach( Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void tsDangXuat_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmDangNhap"))
            {
                frmDangNhap frm = new frmDangNhap();
                frm.Name = "frmDangNhap";
                frm.Show();
                this.Hide();       
            }

            else ActiveChildForm("frmDangNhap");

        }

        private void frmManHinhChinh_Load(object sender, EventArgs e)
        {

        }
    }
}
