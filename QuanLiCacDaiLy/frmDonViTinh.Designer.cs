
namespace QuanLiCacDaiLy
{
    partial class frmDonViTinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonViTinh));
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemDVT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDonViTinh = new System.Windows.Forms.DataGridView();
            this.txtBoxTenDVT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonViTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(219, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thêm đơn vị tính";
            // 
            // btnThemDVT
            // 
            this.btnThemDVT.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThemDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDVT.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnThemDVT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDVT.Image")));
            this.btnThemDVT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDVT.Location = new System.Drawing.Point(506, 94);
            this.btnThemDVT.Name = "btnThemDVT";
            this.btnThemDVT.Size = new System.Drawing.Size(145, 50);
            this.btnThemDVT.TabIndex = 11;
            this.btnThemDVT.Text = "Thêm";
            this.btnThemDVT.UseVisualStyleBackColor = false;
            this.btnThemDVT.Click += new System.EventHandler(this.btnThemDVT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(21, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên đơn vị tính mới ";
            // 
            // dgvDonViTinh
            // 
            this.dgvDonViTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonViTinh.Location = new System.Drawing.Point(26, 187);
            this.dgvDonViTinh.Name = "dgvDonViTinh";
            this.dgvDonViTinh.RowHeadersWidth = 62;
            this.dgvDonViTinh.RowTemplate.Height = 28;
            this.dgvDonViTinh.Size = new System.Drawing.Size(625, 170);
            this.dgvDonViTinh.TabIndex = 9;
            // 
            // txtBoxTenDVT
            // 
            this.txtBoxTenDVT.Location = new System.Drawing.Point(253, 107);
            this.txtBoxTenDVT.Name = "txtBoxTenDVT";
            this.txtBoxTenDVT.Size = new System.Drawing.Size(190, 26);
            this.txtBoxTenDVT.TabIndex = 8;
            // 
            // frmDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemDVT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDonViTinh);
            this.Controls.Add(this.txtBoxTenDVT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDonViTinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐƠN VỊ TÍNH";
            this.Load += new System.EventHandler(this.frmDonViTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonViTinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemDVT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDonViTinh;
        private System.Windows.Forms.TextBox txtBoxTenDVT;
    }
}