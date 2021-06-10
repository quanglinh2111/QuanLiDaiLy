using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class formMHC : Form
    {
        public formMHC()
        {
            InitializeComponent();
        }
        //btnDL_hover
        private void btnDL_MouseHover(object sender, EventArgs e)
        {
            this.btnDL.BackColor = Color.White;
        }

        private void btnDL_MouseLeave(object sender, EventArgs e)
        {
            this.btnDL.BackColor = System.Drawing.SystemColors.ActiveBorder;

        }
        //btnQD_hover
        private void btnQD_MouseHover(object sender, EventArgs e)
        {
            this.btnQD.BackColor = Color.White;

        }

        private void btnQD_MouseLeave(object sender, EventArgs e)
        {
            this.btnQD.BackColor = System.Drawing.SystemColors.ActiveBorder;

        }
        //btnBC_hover
        private void btnBC_MouseHover(object sender, EventArgs e)
        {
            this.btnBC.BackColor = Color.White;
        }

        private void btnBC_MouseLeave(object sender, EventArgs e)
        {
            this.btnBC.BackColor = System.Drawing.SystemColors.ActiveBorder;

        }
        //btnNH_hover
        private void btnNH_MouseHover(object sender, EventArgs e)
        {
            this.btnNH.BackColor = Color.White;
        }

        private void btnNH_MouseLeave(object sender, EventArgs e)
        {
            this.btnNH.BackColor = System.Drawing.SystemColors.ActiveBorder;

        }

        private void btnTT_MouseHover(object sender, EventArgs e)
        {
            this.btnTT.BackColor = Color.White;

        }

        private void btnTT_MouseLeave(object sender, EventArgs e)
        {
            this.btnTT.BackColor = System.Drawing.SystemColors.ActiveBorder;

        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            this.btnBCCN.Visible = true;
            this.btnBCDS.Visible = true;
        }

       
    }
}
