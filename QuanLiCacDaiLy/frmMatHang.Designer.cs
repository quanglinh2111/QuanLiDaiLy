
namespace QuanLiCacDaiLy
{
    partial class frmMatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatHang));
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemMatHang = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.txtBoxTenMHM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBoxDonViTinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(212, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thêm mặt hàng";
            // 
            // btnThemMatHang
            // 
            this.btnThemMatHang.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThemMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMatHang.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnThemMatHang.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMatHang.Image")));
            this.btnThemMatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMatHang.Location = new System.Drawing.Point(496, 85);
            this.btnThemMatHang.Name = "btnThemMatHang";
            this.btnThemMatHang.Size = new System.Drawing.Size(145, 50);
            this.btnThemMatHang.TabIndex = 11;
            this.btnThemMatHang.Text = "Thêm";
            this.btnThemMatHang.UseVisualStyleBackColor = false;
            this.btnThemMatHang.Click += new System.EventHandler(this.btnThemMatHang_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên mặt hàng mới";
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Location = new System.Drawing.Point(17, 175);
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.RowHeadersWidth = 62;
            this.dgvMatHang.RowTemplate.Height = 28;
            this.dgvMatHang.Size = new System.Drawing.Size(624, 184);
            this.dgvMatHang.TabIndex = 9;
            // 
            // txtBoxTenMHM
            // 
            this.txtBoxTenMHM.Location = new System.Drawing.Point(241, 71);
            this.txtBoxTenMHM.Name = "txtBoxTenMHM";
            this.txtBoxTenMHM.Size = new System.Drawing.Size(186, 26);
            this.txtBoxTenMHM.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Đơn vị tính";
            // 
            // cbBoxDonViTinh
            // 
            this.cbBoxDonViTinh.FormattingEnabled = true;
            this.cbBoxDonViTinh.Location = new System.Drawing.Point(241, 131);
            this.cbBoxDonViTinh.Name = "cbBoxDonViTinh";
            this.cbBoxDonViTinh.Size = new System.Drawing.Size(186, 28);
            this.cbBoxDonViTinh.TabIndex = 15;
            // 
            // frmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 391);
            this.Controls.Add(this.cbBoxDonViTinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemMatHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvMatHang);
            this.Controls.Add(this.txtBoxTenMHM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MẶT HÀNG";
            this.Load += new System.EventHandler(this.frmMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemMatHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.TextBox txtBoxTenMHM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBoxDonViTinh;
    }
}