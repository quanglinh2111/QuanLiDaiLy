
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbDsPhieuNhap = new System.Windows.Forms.GroupBox();
            this.btnTra = new System.Windows.Forms.Button();
            this.txtTra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDanhSachPhieuNhap = new System.Windows.Forms.GroupBox();
            this.dgvTraCTPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMactpn = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvCTPNH = new System.Windows.Forms.DataGridView();
            this.dgvDSPhieuNhap = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.grbTaoPhieu = new System.Windows.Forms.GroupBox();
            this.ccbTenMH = new System.Windows.Forms.ComboBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMPN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grbDsPhieuNhap.SuspendLayout();
            this.grbDanhSachPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCTPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuNhap)).BeginInit();
            this.grbTaoPhieu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbDsPhieuNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grbDanhSachPhieuNhap);
            this.panel1.Controls.Add(this.grbTaoPhieu);
            this.panel1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // grbDsPhieuNhap
            // 
            this.grbDsPhieuNhap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbDsPhieuNhap.Controls.Add(this.btnTra);
            this.grbDsPhieuNhap.Controls.Add(this.txtTra);
            this.grbDsPhieuNhap.Controls.Add(this.txtMactpn);
            this.grbDsPhieuNhap.Controls.Add(this.label3);
            resources.ApplyResources(this.grbDsPhieuNhap, "grbDsPhieuNhap");
            this.grbDsPhieuNhap.Name = "grbDsPhieuNhap";
            this.grbDsPhieuNhap.TabStop = false;
            // 
            // btnTra
            // 
            this.btnTra.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.btnTra, "btnTra");
            this.btnTra.Name = "btnTra";
            this.btnTra.UseVisualStyleBackColor = false;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // txtTra
            // 
            resources.ApplyResources(this.txtTra, "txtTra");
            this.txtTra.Name = "txtTra";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // grbDanhSachPhieuNhap
            // 
            this.grbDanhSachPhieuNhap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbDanhSachPhieuNhap.Controls.Add(this.dgvTraCTPhieuNhap);
            this.grbDanhSachPhieuNhap.Controls.Add(this.btnSua);
            this.grbDanhSachPhieuNhap.Controls.Add(this.btnXoa);
            this.grbDanhSachPhieuNhap.Controls.Add(this.dgvCTPNH);
            this.grbDanhSachPhieuNhap.Controls.Add(this.dgvDSPhieuNhap);
            this.grbDanhSachPhieuNhap.Controls.Add(this.label8);
            this.grbDanhSachPhieuNhap.Controls.Add(this.label4);
            this.grbDanhSachPhieuNhap.Controls.Add(this.txtTong);
            this.grbDanhSachPhieuNhap.ForeColor = System.Drawing.SystemColors.InfoText;
            resources.ApplyResources(this.grbDanhSachPhieuNhap, "grbDanhSachPhieuNhap");
            this.grbDanhSachPhieuNhap.Name = "grbDanhSachPhieuNhap";
            this.grbDanhSachPhieuNhap.TabStop = false;
            // 
            // dgvTraCTPhieuNhap
            // 
            this.dgvTraCTPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvTraCTPhieuNhap, "dgvTraCTPhieuNhap");
            this.dgvTraCTPhieuNhap.Name = "dgvTraCTPhieuNhap";
            this.dgvTraCTPhieuNhap.RowTemplate.Height = 28;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnSua, "btnSua");
            this.btnSua.Name = "btnSua";
            this.btnSua.TabStop = false;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMactpn
            // 
            resources.ApplyResources(this.txtMactpn, "txtMactpn");
            this.txtMactpn.Name = "txtMactpn";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.btnXoa, "btnXoa");
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvCTPNH
            // 
            this.dgvCTPNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvCTPNH, "dgvCTPNH");
            this.dgvCTPNH.Name = "dgvCTPNH";
            this.dgvCTPNH.RowTemplate.Height = 28;
            this.dgvCTPNH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPNH_CellClick);
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtTong
            // 
            resources.ApplyResources(this.txtTong, "txtTong");
            this.txtTong.Name = "txtTong";
            // 
            // grbTaoPhieu
            // 
            this.grbTaoPhieu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbTaoPhieu.Controls.Add(this.ccbTenMH);
            this.grbTaoPhieu.Controls.Add(this.txtMaMH);
            this.grbTaoPhieu.Controls.Add(this.label10);
            this.grbTaoPhieu.Controls.Add(this.txtMPN);
            this.grbTaoPhieu.Controls.Add(this.label9);
            this.grbTaoPhieu.Controls.Add(this.btnTao);
            this.grbTaoPhieu.Controls.Add(this.btnKetThuc);
            this.grbTaoPhieu.Controls.Add(this.txtDonGiaNhap);
            this.grbTaoPhieu.Controls.Add(this.txtSoLuongNhap);
            this.grbTaoPhieu.Controls.Add(this.label7);
            this.grbTaoPhieu.Controls.Add(this.label6);
            this.grbTaoPhieu.Controls.Add(this.label5);
            this.grbTaoPhieu.Controls.Add(this.label2);
            this.grbTaoPhieu.ForeColor = System.Drawing.SystemColors.InfoText;
            resources.ApplyResources(this.grbTaoPhieu, "grbTaoPhieu");
            this.grbTaoPhieu.Name = "grbTaoPhieu";
            this.grbTaoPhieu.TabStop = false;
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
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.btnKetThuc, "btnKetThuc");
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.UseVisualStyleBackColor = false;
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
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnLapPhieu, "btnLapPhieu");
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.UseVisualStyleBackColor = false;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // frmManHinhPhieuNhap
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "frmManHinhPhieuNhap";
            this.Load += new System.EventHandler(this.frmManHinhPhieuNhapHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbDsPhieuNhap.ResumeLayout(false);
            this.grbDsPhieuNhap.PerformLayout();
            this.grbDanhSachPhieuNhap.ResumeLayout(false);
            this.grbDanhSachPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCTPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuNhap)).EndInit();
            this.grbTaoPhieu.ResumeLayout(false);
            this.grbTaoPhieu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbDsPhieuNhap;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.TextBox txtTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDanhSachPhieuNhap;
        private System.Windows.Forms.DataGridView dgvTraCTPhieuNhap;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMactpn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvCTPNH;
        private System.Windows.Forms.DataGridView dgvDSPhieuNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.GroupBox grbTaoPhieu;
        private System.Windows.Forms.ComboBox ccbTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMPN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnLapPhieu;
    }
}

