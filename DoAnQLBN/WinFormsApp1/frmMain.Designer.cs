
namespace WinFormsApp1
{
    partial class formMHC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnTT = new System.Windows.Forms.Button();
            this.btnNH = new System.Windows.Forms.Button();
            this.btnBC = new System.Windows.Forms.Button();
            this.btnQD = new System.Windows.Forms.Button();
            this.btnDL = new System.Windows.Forms.Button();
            this.btnCSDL = new System.Windows.Forms.Button();
            this.btnBCDS = new System.Windows.Forms.Button();
            this.btnBCCN = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.AutoSize = true;
            this.pnlNav.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlNav.Controls.Add(this.btnTT);
            this.pnlNav.Controls.Add(this.btnNH);
            this.pnlNav.Controls.Add(this.btnBC);
            this.pnlNav.Controls.Add(this.btnQD);
            this.pnlNav.Controls.Add(this.btnDL);
            this.pnlNav.Controls.Add(this.btnCSDL);
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(1041, 45);
            this.pnlNav.TabIndex = 1;
            // 
            // btnTT
            // 
            this.btnTT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTT.Location = new System.Drawing.Point(490, 0);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(115, 42);
            this.btnTT.TabIndex = 6;
            this.btnTT.Text = "THÔNG TIN";
            this.btnTT.UseVisualStyleBackColor = false;
            this.btnTT.MouseLeave += new System.EventHandler(this.btnTT_MouseLeave);
            this.btnTT.MouseHover += new System.EventHandler(this.btnTT_MouseHover);
            // 
            // btnNH
            // 
            this.btnNH.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNH.Location = new System.Drawing.Point(369, 0);
            this.btnNH.Name = "btnNH";
            this.btnNH.Size = new System.Drawing.Size(115, 42);
            this.btnNH.TabIndex = 5;
            this.btnNH.Text = "NHẬP HÀNG";
            this.btnNH.UseVisualStyleBackColor = false;
            this.btnNH.MouseLeave += new System.EventHandler(this.btnNH_MouseLeave);
            this.btnNH.MouseHover += new System.EventHandler(this.btnNH_MouseHover);
            // 
            // btnBC
            // 
            this.btnBC.AllowDrop = true;
            this.btnBC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBC.Location = new System.Drawing.Point(269, 0);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(94, 42);
            this.btnBC.TabIndex = 4;
            this.btnBC.Text = "BÁO CÁO";
            this.btnBC.UseVisualStyleBackColor = false;
            this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
            this.btnBC.MouseLeave += new System.EventHandler(this.btnBC_MouseLeave);
            this.btnBC.MouseHover += new System.EventHandler(this.btnBC_MouseHover);
            // 
            // btnQD
            // 
            this.btnQD.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnQD.Location = new System.Drawing.Point(169, 0);
            this.btnQD.Name = "btnQD";
            this.btnQD.Size = new System.Drawing.Size(94, 42);
            this.btnQD.TabIndex = 3;
            this.btnQD.Text = "QUY ĐỊNH";
            this.btnQD.UseVisualStyleBackColor = false;
            this.btnQD.MouseLeave += new System.EventHandler(this.btnQD_MouseLeave);
            this.btnQD.MouseHover += new System.EventHandler(this.btnQD_MouseHover);
            // 
            // btnDL
            // 
            this.btnDL.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDL.Location = new System.Drawing.Point(69, 0);
            this.btnDL.Name = "btnDL";
            this.btnDL.Size = new System.Drawing.Size(94, 42);
            this.btnDL.TabIndex = 2;
            this.btnDL.Text = "QL ĐẠI LÝ";
            this.btnDL.UseVisualStyleBackColor = false;
            this.btnDL.MouseLeave += new System.EventHandler(this.btnDL_MouseLeave);
            this.btnDL.MouseHover += new System.EventHandler(this.btnDL_MouseHover);
            // 
            // btnCSDL
            // 
            this.btnCSDL.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCSDL.Location = new System.Drawing.Point(0, 0);
            this.btnCSDL.Name = "btnCSDL";
            this.btnCSDL.Size = new System.Drawing.Size(63, 42);
            this.btnCSDL.TabIndex = 1;
            this.btnCSDL.Text = "KN CSDL";
            this.btnCSDL.UseVisualStyleBackColor = false;
            // 
            // btnBCDS
            // 
            this.btnBCDS.Location = new System.Drawing.Point(146, 48);
            this.btnBCDS.Name = "btnBCDS";
            this.btnBCDS.Size = new System.Drawing.Size(166, 40);
            this.btnBCDS.TabIndex = 2;
            this.btnBCDS.Text = "BÁO CÁO DOANH SỐ";
            this.btnBCDS.UseVisualStyleBackColor = true;
            this.btnBCDS.Visible = false;
            // 
            // btnBCCN
            // 
            this.btnBCCN.Location = new System.Drawing.Point(318, 48);
            this.btnBCCN.Name = "btnBCCN";
            this.btnBCCN.Size = new System.Drawing.Size(166, 40);
            this.btnBCCN.TabIndex = 3;
            this.btnBCCN.Text = "BÁO CÁO CÔNG NỢ";
            this.btnBCCN.UseVisualStyleBackColor = true;
            this.btnBCCN.Visible = false;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlContent.Location = new System.Drawing.Point(0, 94);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(992, 370);
            this.pnlContent.TabIndex = 4;
            // 
            // formMHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnBCCN);
            this.Controls.Add(this.btnBCDS);
            this.Controls.Add(this.pnlNav);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.Name = "formMHC";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MÀN HÌNH CHÍNH";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnCSDL;
        private System.Windows.Forms.Button btnDL;
        private System.Windows.Forms.Button btnQD;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Button btnNH;
        private System.Windows.Forms.Button btnBCDS;
        private System.Windows.Forms.Button btnBCCN;
        private System.Windows.Forms.Panel pnlContent;
    }
}

