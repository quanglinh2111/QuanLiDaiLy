
namespace QuanLiCacDaiLy
{
    partial class frmManHinhBaoCaoDoanhSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinhBaoCaoDoanhSo));
            this.grBoxLapBCDoanhSo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLapBCDoanhSo = new System.Windows.Forms.Button();
            this.cbBoxNamBCDoanhSo = new System.Windows.Forms.ComboBox();
            this.cbBoxThangBCDoanhSo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grBoxCTBCDoanhSo = new System.Windows.Forms.GroupBox();
            this.dgvCTBaoCaoDS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatBCDoanhSo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grBoxLapBCDoanhSo.SuspendLayout();
            this.grBoxCTBCDoanhSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTBaoCaoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxLapBCDoanhSo
            // 
            this.grBoxLapBCDoanhSo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grBoxLapBCDoanhSo.Controls.Add(this.pictureBox1);
            this.grBoxLapBCDoanhSo.Controls.Add(this.label6);
            this.grBoxLapBCDoanhSo.Controls.Add(this.label5);
            this.grBoxLapBCDoanhSo.Controls.Add(this.btnLapBCDoanhSo);
            this.grBoxLapBCDoanhSo.Controls.Add(this.cbBoxNamBCDoanhSo);
            this.grBoxLapBCDoanhSo.Controls.Add(this.cbBoxThangBCDoanhSo);
            this.grBoxLapBCDoanhSo.Controls.Add(this.label2);
            this.grBoxLapBCDoanhSo.Location = new System.Drawing.Point(12, 12);
            this.grBoxLapBCDoanhSo.Name = "grBoxLapBCDoanhSo";
            this.grBoxLapBCDoanhSo.Size = new System.Drawing.Size(298, 540);
            this.grBoxLapBCDoanhSo.TabIndex = 4;
            this.grBoxLapBCDoanhSo.TabStop = false;
            this.grBoxLapBCDoanhSo.Text = "Báo cáo doanh số";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(17, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Năm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(16, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tháng";
            // 
            // btnLapBCDoanhSo
            // 
            this.btnLapBCDoanhSo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLapBCDoanhSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapBCDoanhSo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnLapBCDoanhSo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLapBCDoanhSo.Location = new System.Drawing.Point(105, 285);
            this.btnLapBCDoanhSo.Name = "btnLapBCDoanhSo";
            this.btnLapBCDoanhSo.Size = new System.Drawing.Size(148, 44);
            this.btnLapBCDoanhSo.TabIndex = 1;
            this.btnLapBCDoanhSo.Text = "Tạo báo cáo";
            this.btnLapBCDoanhSo.UseVisualStyleBackColor = false;
            this.btnLapBCDoanhSo.Click += new System.EventHandler(this.btnLapBCDoanhSo_Click);
            // 
            // cbBoxNamBCDoanhSo
            // 
            this.cbBoxNamBCDoanhSo.FormattingEnabled = true;
            this.cbBoxNamBCDoanhSo.Location = new System.Drawing.Point(21, 219);
            this.cbBoxNamBCDoanhSo.Name = "cbBoxNamBCDoanhSo";
            this.cbBoxNamBCDoanhSo.Size = new System.Drawing.Size(232, 28);
            this.cbBoxNamBCDoanhSo.TabIndex = 2;
            // 
            // cbBoxThangBCDoanhSo
            // 
            this.cbBoxThangBCDoanhSo.FormattingEnabled = true;
            this.cbBoxThangBCDoanhSo.Location = new System.Drawing.Point(20, 131);
            this.cbBoxThangBCDoanhSo.Name = "cbBoxThangBCDoanhSo";
            this.cbBoxThangBCDoanhSo.Size = new System.Drawing.Size(232, 28);
            this.cbBoxThangBCDoanhSo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lập báo cáo doanh số";
            // 
            // grBoxCTBCDoanhSo
            // 
            this.grBoxCTBCDoanhSo.BackColor = System.Drawing.Color.AliceBlue;
            this.grBoxCTBCDoanhSo.Controls.Add(this.dgvCTBaoCaoDS);
            this.grBoxCTBCDoanhSo.Controls.Add(this.label1);
            this.grBoxCTBCDoanhSo.Controls.Add(this.btnXuatBCDoanhSo);
            this.grBoxCTBCDoanhSo.Location = new System.Drawing.Point(324, 14);
            this.grBoxCTBCDoanhSo.Name = "grBoxCTBCDoanhSo";
            this.grBoxCTBCDoanhSo.Size = new System.Drawing.Size(902, 549);
            this.grBoxCTBCDoanhSo.TabIndex = 5;
            this.grBoxCTBCDoanhSo.TabStop = false;
            this.grBoxCTBCDoanhSo.Text = "Chi tiết báo cáo doanh số";
            // 
            // dgvCTBaoCaoDS
            // 
            this.dgvCTBaoCaoDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTBaoCaoDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvCTBaoCaoDS.Location = new System.Drawing.Point(18, 51);
            this.dgvCTBaoCaoDS.Name = "dgvCTBaoCaoDS";
            this.dgvCTBaoCaoDS.RowHeadersWidth = 62;
            this.dgvCTBaoCaoDS.RowTemplate.Height = 28;
            this.dgvCTBaoCaoDS.Size = new System.Drawing.Size(870, 440);
            this.dgvCTBaoCaoDS.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaBCDoanhSo";
            this.Column1.HeaderText = "Mã BC doanh số";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SoPhieuXuat";
            this.Column2.HeaderText = "Số phiếu xuất";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 145;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TongTriGia";
            this.Column3.HeaderText = "Tổng trị giá";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TyLe";
            this.Column4.HeaderText = "Tỷ lệ";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaDaiLy";
            this.Column5.HeaderText = "Mã đại lý";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenDaiLy";
            this.Column6.HeaderText = "Tên đại lý";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(254, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách chi tiết báo cáo doanh số";
            // 
            // btnXuatBCDoanhSo
            // 
            this.btnXuatBCDoanhSo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXuatBCDoanhSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBCDoanhSo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnXuatBCDoanhSo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXuatBCDoanhSo.Location = new System.Drawing.Point(706, 502);
            this.btnXuatBCDoanhSo.Name = "btnXuatBCDoanhSo";
            this.btnXuatBCDoanhSo.Size = new System.Drawing.Size(170, 41);
            this.btnXuatBCDoanhSo.TabIndex = 1;
            this.btnXuatBCDoanhSo.Text = "Xuất báo cáo";
            this.btnXuatBCDoanhSo.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 158);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmManHinhBaoCaoDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 564);
            this.Controls.Add(this.grBoxCTBCDoanhSo);
            this.Controls.Add(this.grBoxLapBCDoanhSo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManHinhBaoCaoDoanhSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManHinhBaoCaoDoanhSo";
            this.Load += new System.EventHandler(this.frmManHinhBaoCaoDoanhSo_Load);
            this.grBoxLapBCDoanhSo.ResumeLayout(false);
            this.grBoxLapBCDoanhSo.PerformLayout();
            this.grBoxCTBCDoanhSo.ResumeLayout(false);
            this.grBoxCTBCDoanhSo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTBaoCaoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxLapBCDoanhSo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLapBCDoanhSo;
        private System.Windows.Forms.ComboBox cbBoxNamBCDoanhSo;
        private System.Windows.Forms.ComboBox cbBoxThangBCDoanhSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grBoxCTBCDoanhSo;
        private System.Windows.Forms.DataGridView dgvCTBaoCaoDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuatBCDoanhSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}