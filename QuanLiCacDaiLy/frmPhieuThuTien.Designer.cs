
namespace QuanLiCacDaiLy
{
    partial class frmPhieuThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuThuTien));
            this.grBoxTaoPhieuThuTien = new System.Windows.Forms.GroupBox();
            this.grBoxDSPhieuThuTien = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTaoPhieuThu = new System.Windows.Forms.Button();
            this.cbBoxTracuu = new System.Windows.Forms.ComboBox();
            this.txtMapt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMadl = new System.Windows.Forms.TextBox();
            this.dtpNgaytt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSott = new System.Windows.Forms.TextBox();
            this.dgvDanhsachphieuthutien = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTraCuuPhieuThu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grBoxTaoPhieuThuTien.SuspendLayout();
            this.grBoxDSPhieuThuTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachphieuthutien)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxTaoPhieuThuTien
            // 
            this.grBoxTaoPhieuThuTien.BackColor = System.Drawing.Color.AliceBlue;
            this.grBoxTaoPhieuThuTien.Controls.Add(this.txtSott);
            this.grBoxTaoPhieuThuTien.Controls.Add(this.label4);
            this.grBoxTaoPhieuThuTien.Controls.Add(this.label3);
            this.grBoxTaoPhieuThuTien.Controls.Add(this.dtpNgaytt);
            this.grBoxTaoPhieuThuTien.Controls.Add(this.label1);
            this.grBoxTaoPhieuThuTien.Controls.Add(this.txtMadl);
            this.grBoxTaoPhieuThuTien.Controls.Add(this.txtMapt);
            this.grBoxTaoPhieuThuTien.Controls.Add(this.btnTaoPhieuThu);
            this.grBoxTaoPhieuThuTien.Controls.Add(this.label5);
            this.grBoxTaoPhieuThuTien.Controls.Add(this.label2);
            this.grBoxTaoPhieuThuTien.Location = new System.Drawing.Point(11, 13);
            this.grBoxTaoPhieuThuTien.Name = "grBoxTaoPhieuThuTien";
            this.grBoxTaoPhieuThuTien.Size = new System.Drawing.Size(1215, 190);
            this.grBoxTaoPhieuThuTien.TabIndex = 0;
            this.grBoxTaoPhieuThuTien.TabStop = false;
            this.grBoxTaoPhieuThuTien.Text = "Tạo phiếu thu tiền";
            // 
            // grBoxDSPhieuThuTien
            // 
            this.grBoxDSPhieuThuTien.BackColor = System.Drawing.Color.AliceBlue;
            this.grBoxDSPhieuThuTien.Controls.Add(this.label7);
            this.grBoxDSPhieuThuTien.Controls.Add(this.btnTraCuuPhieuThu);
            this.grBoxDSPhieuThuTien.Controls.Add(this.label6);
            this.grBoxDSPhieuThuTien.Controls.Add(this.dgvDanhsachphieuthutien);
            this.grBoxDSPhieuThuTien.Controls.Add(this.cbBoxTracuu);
            this.grBoxDSPhieuThuTien.Location = new System.Drawing.Point(11, 209);
            this.grBoxDSPhieuThuTien.Name = "grBoxDSPhieuThuTien";
            this.grBoxDSPhieuThuTien.Size = new System.Drawing.Size(1215, 343);
            this.grBoxDSPhieuThuTien.TabIndex = 0;
            this.grBoxDSPhieuThuTien.TabStop = false;
            this.grBoxDSPhieuThuTien.Text = "Danh sách phiếu thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(480, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tạo mới phiếu thu tiền ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(60, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã phiếu thu tiền ";
            // 
            // btnTaoPhieuThu
            // 
            this.btnTaoPhieuThu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTaoPhieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieuThu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnTaoPhieuThu.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoPhieuThu.Image")));
            this.btnTaoPhieuThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPhieuThu.Location = new System.Drawing.Point(1031, 88);
            this.btnTaoPhieuThu.Name = "btnTaoPhieuThu";
            this.btnTaoPhieuThu.Size = new System.Drawing.Size(154, 60);
            this.btnTaoPhieuThu.TabIndex = 5;
            this.btnTaoPhieuThu.Text = "Tạo phiếu";
            this.btnTaoPhieuThu.UseVisualStyleBackColor = false;
            this.btnTaoPhieuThu.Click += new System.EventHandler(this.btnTaoPhieuThu_Click);
            // 
            // cbBoxTracuu
            // 
            this.cbBoxTracuu.FormattingEnabled = true;
            this.cbBoxTracuu.Location = new System.Drawing.Point(757, 25);
            this.cbBoxTracuu.Name = "cbBoxTracuu";
            this.cbBoxTracuu.Size = new System.Drawing.Size(229, 28);
            this.cbBoxTracuu.TabIndex = 6;
            // 
            // txtMapt
            // 
            this.txtMapt.Location = new System.Drawing.Point(267, 81);
            this.txtMapt.Margin = new System.Windows.Forms.Padding(4);
            this.txtMapt.Name = "txtMapt";
            this.txtMapt.Size = new System.Drawing.Size(229, 26);
            this.txtMapt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(60, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã đại lý ";
            // 
            // txtMadl
            // 
            this.txtMadl.Location = new System.Drawing.Point(267, 131);
            this.txtMadl.Margin = new System.Windows.Forms.Padding(4);
            this.txtMadl.Name = "txtMadl";
            this.txtMadl.Size = new System.Drawing.Size(229, 26);
            this.txtMadl.TabIndex = 7;
            // 
            // dtpNgaytt
            // 
            this.dtpNgaytt.Location = new System.Drawing.Point(757, 81);
            this.dtpNgaytt.Name = "dtpNgaytt";
            this.dtpNgaytt.Size = new System.Drawing.Size(229, 26);
            this.dtpNgaytt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(568, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày thu tiền ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(568, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số tiền thu ";
            // 
            // txtSott
            // 
            this.txtSott.Location = new System.Drawing.Point(757, 132);
            this.txtSott.Margin = new System.Windows.Forms.Padding(4);
            this.txtSott.Name = "txtSott";
            this.txtSott.Size = new System.Drawing.Size(229, 26);
            this.txtSott.TabIndex = 12;
            // 
            // dgvDanhsachphieuthutien
            // 
            this.dgvDanhsachphieuthutien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachphieuthutien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDanhsachphieuthutien.Location = new System.Drawing.Point(0, 80);
            this.dgvDanhsachphieuthutien.Name = "dgvDanhsachphieuthutien";
            this.dgvDanhsachphieuthutien.RowHeadersWidth = 62;
            this.dgvDanhsachphieuthutien.RowTemplate.Height = 28;
            this.dgvDanhsachphieuthutien.Size = new System.Drawing.Size(1214, 253);
            this.dgvDanhsachphieuthutien.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(568, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã phiếu thu ";
            // 
            // btnTraCuuPhieuThu
            // 
            this.btnTraCuuPhieuThu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTraCuuPhieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuPhieuThu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnTraCuuPhieuThu.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuuPhieuThu.Image")));
            this.btnTraCuuPhieuThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuuPhieuThu.Location = new System.Drawing.Point(1031, 14);
            this.btnTraCuuPhieuThu.Name = "btnTraCuuPhieuThu";
            this.btnTraCuuPhieuThu.Size = new System.Drawing.Size(154, 60);
            this.btnTraCuuPhieuThu.TabIndex = 13;
            this.btnTraCuuPhieuThu.Text = "Tra cứu";
            this.btnTraCuuPhieuThu.UseVisualStyleBackColor = false;
            this.btnTraCuuPhieuThu.Click += new System.EventHandler(this.btnTraCuuPhieuThu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(406, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "Danh sách phiếu thu tiền ";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPhieuThuTien";
            this.Column1.HeaderText = "Mã phiếu thu";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaDaiLy";
            this.Column2.HeaderText = "Mã đại lý";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayThuTien";
            this.Column3.HeaderText = "Ngày thu tiền";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoTienThu";
            this.Column4.HeaderText = "số tiền thu";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // frmPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 564);
            this.Controls.Add(this.grBoxDSPhieuThuTien);
            this.Controls.Add(this.grBoxTaoPhieuThuTien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhieuThuTien";
            this.Text = "MÀN HÌNH PHIẾU THU TIỀN";
            this.Load += new System.EventHandler(this.frmPhieuThuTien_Load);
            this.grBoxTaoPhieuThuTien.ResumeLayout(false);
            this.grBoxTaoPhieuThuTien.PerformLayout();
            this.grBoxDSPhieuThuTien.ResumeLayout(false);
            this.grBoxDSPhieuThuTien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachphieuthutien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxTaoPhieuThuTien;
        private System.Windows.Forms.GroupBox grBoxDSPhieuThuTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTaoPhieuThu;
        private System.Windows.Forms.ComboBox cbBoxTracuu;
        private System.Windows.Forms.TextBox txtMapt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSott;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaytt;
        private System.Windows.Forms.TextBox txtMadl;
        private System.Windows.Forms.Button btnTraCuuPhieuThu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDanhsachphieuthutien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}