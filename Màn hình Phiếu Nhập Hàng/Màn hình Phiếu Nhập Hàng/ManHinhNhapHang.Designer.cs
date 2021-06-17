
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
            this.grbDanhSachPhieunhạp = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dgvDSPhieuNhap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTraCuuPhieuNhap = new System.Windows.Forms.GroupBox();
            this.dgvTraCTPhieuNhap = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChiTietPhieuNhap = new System.Windows.Forms.GroupBox();
            this.txtMactpn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCTPNH = new System.Windows.Forms.DataGridView();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.grbTaoPhieu = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.txtTra = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.grbDanhSachPhieunhạp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuNhap)).BeginInit();
            this.grbTraCuuPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCTPhieuNhap)).BeginInit();
            this.grbChiTietPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPNH)).BeginInit();
            this.grbTaoPhieu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbDanhSachPhieunhạp);
            this.panel1.Controls.Add(this.grbTraCuuPhieuNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grbChiTietPhieuNhap);
            this.panel1.Controls.Add(this.grbTaoPhieu);
            this.panel1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // grbDanhSachPhieunhạp
            // 
            this.grbDanhSachPhieunhạp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbDanhSachPhieunhạp.Controls.Add(this.label22);
            this.grbDanhSachPhieunhạp.Controls.Add(this.dgvDSPhieuNhap);
            resources.ApplyResources(this.grbDanhSachPhieunhạp, "grbDanhSachPhieunhạp");
            this.grbDanhSachPhieunhạp.Name = "grbDanhSachPhieunhạp";
            this.grbDanhSachPhieunhạp.TabStop = false;
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // dgvDSPhieuNhap
            // 
            this.dgvDSPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            resources.ApplyResources(this.dgvDSPhieuNhap, "dgvDSPhieuNhap");
            this.dgvDSPhieuNhap.Name = "dgvDSPhieuNhap";
            this.dgvDSPhieuNhap.RowTemplate.Height = 28;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPhieuNhapHang";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayLapPhieu";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TongTienPhieuNhap";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // grbTraCuuPhieuNhap
            // 
            this.grbTraCuuPhieuNhap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbTraCuuPhieuNhap.Controls.Add(this.txtTra);
            this.grbTraCuuPhieuNhap.Controls.Add(this.dgvTraCTPhieuNhap);
            this.grbTraCuuPhieuNhap.Controls.Add(this.button1);
            this.grbTraCuuPhieuNhap.Controls.Add(this.label16);
            this.grbTraCuuPhieuNhap.Controls.Add(this.label15);
            resources.ApplyResources(this.grbTraCuuPhieuNhap, "grbTraCuuPhieuNhap");
            this.grbTraCuuPhieuNhap.Name = "grbTraCuuPhieuNhap";
            this.grbTraCuuPhieuNhap.TabStop = false;
            // 
            // dgvTraCTPhieuNhap
            // 
            this.dgvTraCTPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvTraCTPhieuNhap, "dgvTraCTPhieuNhap");
            this.dgvTraCTPhieuNhap.Name = "dgvTraCTPhieuNhap";
            this.dgvTraCTPhieuNhap.RowTemplate.Height = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // grbChiTietPhieuNhap
            // 
            this.grbChiTietPhieuNhap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbChiTietPhieuNhap.Controls.Add(this.txtMactpn);
            this.grbChiTietPhieuNhap.Controls.Add(this.label3);
            this.grbChiTietPhieuNhap.Controls.Add(this.txtTongTien);
            this.grbChiTietPhieuNhap.Controls.Add(this.btnSua);
            this.grbChiTietPhieuNhap.Controls.Add(this.btnXoa);
            this.grbChiTietPhieuNhap.Controls.Add(this.label8);
            this.grbChiTietPhieuNhap.Controls.Add(this.label4);
            this.grbChiTietPhieuNhap.Controls.Add(this.dgvCTPNH);
            this.grbChiTietPhieuNhap.Controls.Add(this.txtTong);
            this.grbChiTietPhieuNhap.ForeColor = System.Drawing.SystemColors.InfoText;
            resources.ApplyResources(this.grbChiTietPhieuNhap, "grbChiTietPhieuNhap");
            this.grbChiTietPhieuNhap.Name = "grbChiTietPhieuNhap";
            this.grbChiTietPhieuNhap.TabStop = false;
            // 
            // txtMactpn
            // 
            resources.ApplyResources(this.txtMactpn, "txtMactpn");
            this.txtMactpn.Name = "txtMactpn";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtTongTien
            // 
            resources.ApplyResources(this.txtTongTien, "txtTongTien");
            this.txtTongTien.Name = "txtTongTien";
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
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.btnXoa, "btnXoa");
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            // dgvCTPNH
            // 
            this.dgvCTPNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvCTPNH, "dgvCTPNH");
            this.dgvCTPNH.Name = "dgvCTPNH";
            this.dgvCTPNH.RowTemplate.Height = 28;
            this.dgvCTPNH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPNH_CellClick);
            // 
            // txtTong
            // 
            resources.ApplyResources(this.txtTong, "txtTong");
            this.txtTong.Name = "txtTong";
            // 
            // grbTaoPhieu
            // 
            this.grbTaoPhieu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbTaoPhieu.Controls.Add(this.button2);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.groupBox1.Controls.Add(this.btnDanhSach);
            this.groupBox1.Controls.Add(this.btnLapPhieu);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnDanhSach
            // 
            resources.ApplyResources(this.btnDanhSach, "btnDanhSach");
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnLapPhieu, "btnLapPhieu");
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.UseVisualStyleBackColor = false;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // txtTra
            // 
            resources.ApplyResources(this.txtTra, "txtTra");
            this.txtTra.Name = "txtTra";
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
            this.grbDanhSachPhieunhạp.ResumeLayout(false);
            this.grbDanhSachPhieunhạp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuNhap)).EndInit();
            this.grbTraCuuPhieuNhap.ResumeLayout(false);
            this.grbTraCuuPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCTPhieuNhap)).EndInit();
            this.grbChiTietPhieuNhap.ResumeLayout(false);
            this.grbChiTietPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPNH)).EndInit();
            this.grbTaoPhieu.ResumeLayout(false);
            this.grbTaoPhieu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbChiTietPhieuNhap;
        private System.Windows.Forms.DataGridView dgvTraCTPhieuNhap;
        private System.Windows.Forms.Button btnSua;
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
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.GroupBox grbDanhSachPhieunhạp;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox grbTraCuuPhieuNhap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMactpn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtTra;
    }
}

