
namespace QuanLiCacDaiLy
{
    partial class frmLoaiDaiLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiDaiLy));
            this.txtBoxTenLDL = new System.Windows.Forms.TextBox();
            this.dgvLoaiDaiLy = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSoNoToiDa = new System.Windows.Forms.TextBox();
            this.btnThemLoaiDl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDaiLy)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxTenLDL
            // 
            this.txtBoxTenLDL.Location = new System.Drawing.Point(313, 77);
            this.txtBoxTenLDL.Name = "txtBoxTenLDL";
            this.txtBoxTenLDL.Size = new System.Drawing.Size(151, 26);
            this.txtBoxTenLDL.TabIndex = 2;
            // 
            // dgvLoaiDaiLy
            // 
            this.dgvLoaiDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiDaiLy.Location = new System.Drawing.Point(46, 197);
            this.dgvLoaiDaiLy.Name = "dgvLoaiDaiLy";
            this.dgvLoaiDaiLy.RowHeadersWidth = 62;
            this.dgvLoaiDaiLy.RowTemplate.Height = 28;
            this.dgvLoaiDaiLy.Size = new System.Drawing.Size(599, 176);
            this.dgvLoaiDaiLy.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(41, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên loại đại lý mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(41, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nợ tối đa cho loại đại lý";
            // 
            // txtBoxSoNoToiDa
            // 
            this.txtBoxSoNoToiDa.Location = new System.Drawing.Point(313, 129);
            this.txtBoxSoNoToiDa.Name = "txtBoxSoNoToiDa";
            this.txtBoxSoNoToiDa.Size = new System.Drawing.Size(151, 26);
            this.txtBoxSoNoToiDa.TabIndex = 2;
            // 
            // btnThemLoaiDl
            // 
            this.btnThemLoaiDl.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThemLoaiDl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiDl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnThemLoaiDl.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLoaiDl.Image")));
            this.btnThemLoaiDl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLoaiDl.Location = new System.Drawing.Point(500, 93);
            this.btnThemLoaiDl.Name = "btnThemLoaiDl";
            this.btnThemLoaiDl.Size = new System.Drawing.Size(145, 50);
            this.btnThemLoaiDl.TabIndex = 6;
            this.btnThemLoaiDl.Text = "Thêm";
            this.btnThemLoaiDl.UseVisualStyleBackColor = false;
            this.btnThemLoaiDl.Click += new System.EventHandler(this.btnTaoPhieuThu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(212, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thêm loại đại lý";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmLoaiDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemLoaiDl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvLoaiDaiLy);
            this.Controls.Add(this.txtBoxSoNoToiDa);
            this.Controls.Add(this.txtBoxTenLDL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoaiDaiLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÀN HÌNH LOẠI ĐẠI LÝ";
            this.Load += new System.EventHandler(this.frmLoaiDaiLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDaiLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxTenLDL;
        private System.Windows.Forms.DataGridView dgvLoaiDaiLy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSoNoToiDa;
        private System.Windows.Forms.Button btnThemLoaiDl;
        private System.Windows.Forms.Label label2;
    }
}