
namespace Màn_hình_Phiếu_Nhập_Hàng
{
    partial class frmManHinhPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinhPhieuNhap));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.grBTaoPhieu = new System.Windows.Forms.GroupBox();
            this.ccbTenMH = new System.Windows.Forms.ComboBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMPN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grBDanhSachPhieuNhap = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgvCTPNH = new System.Windows.Forms.DataGridView();
            this.dgvDSPhieuNhap = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grBTaoPhieu.SuspendLayout();
            this.grBDanhSachPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btnTraCuu);
            this.groupBox1.Controls.Add(this.btnLapPhieu);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnTraCuu
            // 
            resources.ApplyResources(this.btnTraCuu, "btnTraCuu");
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnLapPhieu, "btnLapPhieu");
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.UseVisualStyleBackColor = false;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // grBTaoPhieu
            // 
            this.grBTaoPhieu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grBTaoPhieu.Controls.Add(this.ccbTenMH);
            this.grBTaoPhieu.Controls.Add(this.txtMaMH);
            this.grBTaoPhieu.Controls.Add(this.label10);
            this.grBTaoPhieu.Controls.Add(this.txtMPN);
            this.grBTaoPhieu.Controls.Add(this.label9);
            this.grBTaoPhieu.Controls.Add(this.btnTao);
            this.grBTaoPhieu.Controls.Add(this.btnHuyBo);
            this.grBTaoPhieu.Controls.Add(this.txtDonGiaNhap);
            this.grBTaoPhieu.Controls.Add(this.txtSoLuongNhap);
            this.grBTaoPhieu.Controls.Add(this.label7);
            this.grBTaoPhieu.Controls.Add(this.label6);
            this.grBTaoPhieu.Controls.Add(this.label5);
            this.grBTaoPhieu.Controls.Add(this.label2);
            this.grBTaoPhieu.ForeColor = System.Drawing.SystemColors.InfoText;
            resources.ApplyResources(this.grBTaoPhieu, "grBTaoPhieu");
            this.grBTaoPhieu.Name = "grBTaoPhieu";
            this.grBTaoPhieu.TabStop = false;
            // 
            // ccbTenMH
            // 
            this.ccbTenMH.FormattingEnabled = true;
            resources.ApplyResources(this.ccbTenMH, "ccbTenMH");
            this.ccbTenMH.Name = "ccbTenMH";
            this.ccbTenMH.TextChanged += new System.EventHandler(this.ccbTenMH_TextChanged);
            // 
            // txtMaMH
            // 
            resources.ApplyResources(this.txtMaMH, "txtMaMH");
            this.txtMaMH.Name = "txtMaMH";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtMPN
            // 
            resources.ApplyResources(this.txtMPN, "txtMPN");
            this.txtMPN.Name = "txtMPN";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.btnTao, "btnTao");
            this.btnTao.Name = "btnTao";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.btnHuyBo, "btnHuyBo");
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            // 
            // txtDonGiaNhap
            // 
            resources.ApplyResources(this.txtDonGiaNhap, "txtDonGiaNhap");
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            // 
            // txtSoLuongNhap
            // 
            resources.ApplyResources(this.txtSoLuongNhap, "txtSoLuongNhap");
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtTong
            // 
            resources.ApplyResources(this.txtTong, "txtTong");
            this.txtTong.Name = "txtTong";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // grBDanhSachPhieuNhap
            // 
            this.grBDanhSachPhieuNhap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grBDanhSachPhieuNhap.Controls.Add(this.dgv1);
            this.grBDanhSachPhieuNhap.Controls.Add(this.dgvCTPNH);
            this.grBDanhSachPhieuNhap.Controls.Add(this.dgvDSPhieuNhap);
            this.grBDanhSachPhieuNhap.Controls.Add(this.label8);
            this.grBDanhSachPhieuNhap.Controls.Add(this.label4);
            this.grBDanhSachPhieuNhap.Controls.Add(this.txtTong);
            this.grBDanhSachPhieuNhap.ForeColor = System.Drawing.SystemColors.InfoText;
            resources.ApplyResources(this.grBDanhSachPhieuNhap, "grBDanhSachPhieuNhap");
            this.grBDanhSachPhieuNhap.Name = "grBDanhSachPhieuNhap";
            this.grBDanhSachPhieuNhap.TabStop = false;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv1, "dgv1");
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 28;
            // 
            // dgvCTPNH
            // 
            this.dgvCTPNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvCTPNH, "dgvCTPNH");
            this.dgvCTPNH.Name = "dgvCTPNH";
            this.dgvCTPNH.RowTemplate.Height = 28;
            // 
            // dgvDSPhieuNhap
            // 
            this.dgvDSPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvDSPhieuNhap, "dgvDSPhieuNhap");
            this.dgvDSPhieuNhap.Name = "dgvDSPhieuNhap";
            this.dgvDSPhieuNhap.RowTemplate.Height = 28;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // frmManHinhPhieuNhap
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grBDanhSachPhieuNhap);
            this.Controls.Add(this.grBTaoPhieu);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmManHinhPhieuNhap";
            this.Load += new System.EventHandler(this.frmManHinhPhieuNhapHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.grBTaoPhieu.ResumeLayout(false);
            this.grBTaoPhieu.PerformLayout();
            this.grBDanhSachPhieuNhap.ResumeLayout(false);
            this.grBDanhSachPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox grBTaoPhieu;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grBDanhSachPhieuNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSPhieuNhap;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMPN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvCTPNH;
        private System.Windows.Forms.ComboBox ccbTenMH;
        private System.Windows.Forms.DataGridView dgv1;
    }
}

