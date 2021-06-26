
namespace QuanLiCacDaiLy
{
    partial class frmQUAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQUAN));
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxTenQuan = new System.Windows.Forms.TextBox();
            this.btnThemQuan = new System.Windows.Forms.Button();
            this.dgvQuan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(237, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thêm Quận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(52, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tên quận";
            // 
            // txtBoxTenQuan
            // 
            this.txtBoxTenQuan.Location = new System.Drawing.Point(203, 104);
            this.txtBoxTenQuan.Name = "txtBoxTenQuan";
            this.txtBoxTenQuan.Size = new System.Drawing.Size(196, 26);
            this.txtBoxTenQuan.TabIndex = 9;
            // 
            // btnThemQuan
            // 
            this.btnThemQuan.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThemQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemQuan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnThemQuan.Image = ((System.Drawing.Image)(resources.GetObject("btnThemQuan.Image")));
            this.btnThemQuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemQuan.Location = new System.Drawing.Point(451, 92);
            this.btnThemQuan.Name = "btnThemQuan";
            this.btnThemQuan.Size = new System.Drawing.Size(145, 50);
            this.btnThemQuan.TabIndex = 14;
            this.btnThemQuan.Text = "Thêm";
            this.btnThemQuan.UseVisualStyleBackColor = false;
            this.btnThemQuan.Click += new System.EventHandler(this.btnThemLoaiDl_Click);
            // 
            // dgvQuan
            // 
            this.dgvQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuan.Location = new System.Drawing.Point(34, 167);
            this.dgvQuan.Name = "dgvQuan";
            this.dgvQuan.RowHeadersWidth = 62;
            this.dgvQuan.RowTemplate.Height = 28;
            this.dgvQuan.Size = new System.Drawing.Size(599, 188);
            this.dgvQuan.TabIndex = 13;
            // 
            // frmQUAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 391);
            this.Controls.Add(this.btnThemQuan);
            this.Controls.Add(this.dgvQuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxTenQuan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQUAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÀN HÌNH QUẬN";
            this.Load += new System.EventHandler(this.frmQUAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxTenQuan;
        private System.Windows.Forms.Button btnThemQuan;
        private System.Windows.Forms.DataGridView dgvQuan;
    }
}