
namespace Màn_hình_Phiếu_Nhập_Hàng
{
    partial class frmManHinhPhieuNhapHang
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
            this.dgvCTPNH = new System.Windows.Forms.DataGridView();
            this.dgvDSPhieuNhap = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.grBTaoPhieu.SuspendLayout();
            this.grBDanhSachPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btnTraCuu);
            this.groupBox1.Controls.Add(this.btnLapPhieu);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(6, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(100, 419);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập - tra cứu";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(6, 113);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(90, 50);
            this.btnTraCuu.TabIndex = 0;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLapPhieu.Location = new System.Drawing.Point(6, 44);
            this.btnLapPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(90, 50);
            this.btnLapPhieu.TabIndex = 0;
            this.btnLapPhieu.Text = "Lập phiếu";
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
            this.grBTaoPhieu.Location = new System.Drawing.Point(120, 42);
            this.grBTaoPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBTaoPhieu.Name = "grBTaoPhieu";
            this.grBTaoPhieu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBTaoPhieu.Size = new System.Drawing.Size(369, 419);
            this.grBTaoPhieu.TabIndex = 0;
            this.grBTaoPhieu.TabStop = false;
            this.grBTaoPhieu.Text = "Tạo mới phiếu nhập hàng";
            // 
            // ccbTenMH
            // 
            this.ccbTenMH.FormattingEnabled = true;
            this.ccbTenMH.Location = new System.Drawing.Point(179, 139);
            this.ccbTenMH.Name = "ccbTenMH";
            this.ccbTenMH.Size = new System.Drawing.Size(177, 24);
            this.ccbTenMH.TabIndex = 2;
            this.ccbTenMH.TextChanged += new System.EventHandler(this.ccbTenMH_TextChanged);
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(179, 99);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(178, 22);
            this.txtMaMH.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Mã mặt hàng";
            // 
            // txtMPN
            // 
            this.txtMPN.Enabled = false;
            this.txtMPN.Location = new System.Drawing.Point(181, 61);
            this.txtMPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMPN.Name = "txtMPN";
            this.txtMPN.Size = new System.Drawing.Size(177, 22);
            this.txtMPN.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Mã của phiếu nhập";
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTao.Location = new System.Drawing.Point(274, 371);
            this.btnTao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(70, 30);
            this.btnTao.TabIndex = 4;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuyBo.Location = new System.Drawing.Point(155, 371);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(70, 30);
            this.btnHuyBo.TabIndex = 4;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(179, 232);
            this.txtDonGiaNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(178, 22);
            this.txtDonGiaNhap.TabIndex = 3;
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Location = new System.Drawing.Point(179, 186);
            this.txtSoLuongNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(178, 22);
            this.txtSoLuongNhap.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đơn giá nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nhập số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập tên mặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Thông Tin Mặt Hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(465, 381);
            this.txtTong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(119, 22);
            this.txtTong.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tổng";
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
            this.grBDanhSachPhieuNhap.Location = new System.Drawing.Point(510, 42);
            this.grBDanhSachPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBDanhSachPhieuNhap.Name = "grBDanhSachPhieuNhap";
            this.grBDanhSachPhieuNhap.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBDanhSachPhieuNhap.Size = new System.Drawing.Size(931, 419);
            this.grBDanhSachPhieuNhap.TabIndex = 0;
            this.grBDanhSachPhieuNhap.TabStop = false;
            this.grBDanhSachPhieuNhap.Text = "Danh sách phiếu nhập hàng";
            // 
            // dgvCTPNH
            // 
            this.dgvCTPNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPNH.Location = new System.Drawing.Point(20, 188);
            this.dgvCTPNH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCTPNH.Name = "dgvCTPNH";
            this.dgvCTPNH.RowHeadersWidth = 62;
            this.dgvCTPNH.RowTemplate.Height = 28;
            this.dgvCTPNH.Size = new System.Drawing.Size(872, 84);
            this.dgvCTPNH.TabIndex = 7;
            // 
            // dgvDSPhieuNhap
            // 
            this.dgvDSPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhieuNhap.Location = new System.Drawing.Point(20, 71);
            this.dgvDSPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSPhieuNhap.Name = "dgvDSPhieuNhap";
            this.dgvDSPhieuNhap.RowHeadersWidth = 62;
            this.dgvDSPhieuNhap.RowTemplate.Height = 28;
            this.dgvDSPhieuNhap.Size = new System.Drawing.Size(872, 95);
            this.dgvDSPhieuNhap.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Danh sách phiếu nhập hàng";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phiếu nhập hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(20, 293);
            this.dgv1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(872, 84);
            this.dgv1.TabIndex = 8;
            // 
            // frmManHinhPhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 662);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grBDanhSachPhieuNhap);
            this.Controls.Add(this.grBTaoPhieu);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmManHinhPhieuNhapHang";
            this.Text = "Màn hình Phiếu nhập hàng";
            this.Load += new System.EventHandler(this.frmManHinhPhieuNhapHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.grBTaoPhieu.ResumeLayout(false);
            this.grBTaoPhieu.PerformLayout();
            this.grBDanhSachPhieuNhap.ResumeLayout(false);
            this.grBDanhSachPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
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

