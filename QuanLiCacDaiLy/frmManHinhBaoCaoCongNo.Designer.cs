
namespace QuanLiCacDaiLy
{
    partial class frmManHinhBaoCaoCongNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinhBaoCaoCongNo));
            this.grBoxSua = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLapBCCongNo = new System.Windows.Forms.Button();
            this.cbBoxNamBCCongNo = new System.Windows.Forms.ComboBox();
            this.cbBoxThangBCCongNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grBoxCTBCCongNo = new System.Windows.Forms.GroupBox();
            this.dgvCTBaoCaoCongNo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatBCCongNo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grBoxSua.SuspendLayout();
            this.grBoxCTBCCongNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTBaoCaoCongNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxSua
            // 
            this.grBoxSua.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grBoxSua.Controls.Add(this.pictureBox1);
            this.grBoxSua.Controls.Add(this.label6);
            this.grBoxSua.Controls.Add(this.label5);
            this.grBoxSua.Controls.Add(this.btnLapBCCongNo);
            this.grBoxSua.Controls.Add(this.cbBoxNamBCCongNo);
            this.grBoxSua.Controls.Add(this.cbBoxThangBCCongNo);
            this.grBoxSua.Controls.Add(this.label2);
            this.grBoxSua.Location = new System.Drawing.Point(12, 12);
            this.grBoxSua.Name = "grBoxSua";
            this.grBoxSua.Size = new System.Drawing.Size(298, 540);
            this.grBoxSua.TabIndex = 5;
            this.grBoxSua.TabStop = false;
            this.grBoxSua.Text = "Báo cáo công nợ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(17, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Năm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(17, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tháng";
            // 
            // btnLapBCCongNo
            // 
            this.btnLapBCCongNo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLapBCCongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapBCCongNo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnLapBCCongNo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLapBCCongNo.Location = new System.Drawing.Point(114, 286);
            this.btnLapBCCongNo.Name = "btnLapBCCongNo";
            this.btnLapBCCongNo.Size = new System.Drawing.Size(147, 45);
            this.btnLapBCCongNo.TabIndex = 1;
            this.btnLapBCCongNo.Text = "Tạo báo cáo";
            this.btnLapBCCongNo.UseVisualStyleBackColor = false;
            this.btnLapBCCongNo.Click += new System.EventHandler(this.btnLapBCCongNo_Click);
            // 
            // cbBoxNamBCCongNo
            // 
            this.cbBoxNamBCCongNo.FormattingEnabled = true;
            this.cbBoxNamBCCongNo.Location = new System.Drawing.Point(21, 232);
            this.cbBoxNamBCCongNo.Name = "cbBoxNamBCCongNo";
            this.cbBoxNamBCCongNo.Size = new System.Drawing.Size(240, 28);
            this.cbBoxNamBCCongNo.TabIndex = 2;
            // 
            // cbBoxThangBCCongNo
            // 
            this.cbBoxThangBCCongNo.FormattingEnabled = true;
            this.cbBoxThangBCCongNo.Location = new System.Drawing.Point(21, 136);
            this.cbBoxThangBCCongNo.Name = "cbBoxThangBCCongNo";
            this.cbBoxThangBCCongNo.Size = new System.Drawing.Size(240, 28);
            this.cbBoxThangBCCongNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lập báo cáo công nợ";
            // 
            // grBoxCTBCCongNo
            // 
            this.grBoxCTBCCongNo.BackColor = System.Drawing.Color.AliceBlue;
            this.grBoxCTBCCongNo.Controls.Add(this.dgvCTBaoCaoCongNo);
            this.grBoxCTBCCongNo.Controls.Add(this.label1);
            this.grBoxCTBCCongNo.Controls.Add(this.btnXuatBCCongNo);
            this.grBoxCTBCCongNo.Location = new System.Drawing.Point(324, 12);
            this.grBoxCTBCCongNo.Name = "grBoxCTBCCongNo";
            this.grBoxCTBCCongNo.Size = new System.Drawing.Size(902, 549);
            this.grBoxCTBCCongNo.TabIndex = 6;
            this.grBoxCTBCCongNo.TabStop = false;
            this.grBoxCTBCCongNo.Text = "Chi tiết báo cáo công nợ";
            // 
            // dgvCTBaoCaoCongNo
            // 
            this.dgvCTBaoCaoCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTBaoCaoCongNo.Location = new System.Drawing.Point(18, 51);
            this.dgvCTBaoCaoCongNo.Name = "dgvCTBaoCaoCongNo";
            this.dgvCTBaoCaoCongNo.RowHeadersWidth = 62;
            this.dgvCTBaoCaoCongNo.RowTemplate.Height = 28;
            this.dgvCTBaoCaoCongNo.Size = new System.Drawing.Size(870, 440);
            this.dgvCTBaoCaoCongNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(254, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách chi tiết báo cáo công nợ";
            // 
            // btnXuatBCCongNo
            // 
            this.btnXuatBCCongNo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXuatBCCongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBCCongNo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnXuatBCCongNo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXuatBCCongNo.Location = new System.Drawing.Point(719, 504);
            this.btnXuatBCCongNo.Name = "btnXuatBCCongNo";
            this.btnXuatBCCongNo.Size = new System.Drawing.Size(157, 39);
            this.btnXuatBCCongNo.TabIndex = 1;
            this.btnXuatBCCongNo.Text = "Xuất báo cáo";
            this.btnXuatBCCongNo.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 158);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmManHinhBaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 564);
            this.Controls.Add(this.grBoxCTBCCongNo);
            this.Controls.Add(this.grBoxSua);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManHinhBaoCaoCongNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÀN HÌNH BÁO CÁO CÔNG NỢ";
            this.Load += new System.EventHandler(this.ManHinhBaoCaoCongNo_Load);
            this.grBoxSua.ResumeLayout(false);
            this.grBoxSua.PerformLayout();
            this.grBoxCTBCCongNo.ResumeLayout(false);
            this.grBoxCTBCCongNo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTBaoCaoCongNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLapBCCongNo;
        private System.Windows.Forms.ComboBox cbBoxNamBCCongNo;
        private System.Windows.Forms.ComboBox cbBoxThangBCCongNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grBoxCTBCCongNo;
        private System.Windows.Forms.DataGridView dgvCTBaoCaoCongNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuatBCCongNo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}