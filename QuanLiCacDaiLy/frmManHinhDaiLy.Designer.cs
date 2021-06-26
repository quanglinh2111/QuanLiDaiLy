
namespace QuanLiCacDaiLy
{
    partial class frmManHinhDaiLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinhDaiLy));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbDSDL = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaDL = new System.Windows.Forms.Button();
            this.btnSuaDL = new System.Windows.Forms.Button();
            this.dgvDSDL = new System.Windows.Forms.DataGridView();
            this.grboxTraCuu = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOKTraCuu = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cbBoxTraCuuMaDL = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.grBoxTiepNhan = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBoxTenDaiLy = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThemDL = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtimeNgayTiepNhan = new System.Windows.Forms.DateTimePicker();
            this.cbBoxLoaiDaiLy = new System.Windows.Forms.ComboBox();
            this.cbBoxQuan = new System.Windows.Forms.ComboBox();
            this.txtBoxDiaChi = new System.Windows.Forms.TextBox();
            this.txtBoxDienThoai = new System.Windows.Forms.TextBox();
            this.txtBoxMaDaiLy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnTiepNhan = new System.Windows.Forms.Button();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.grbDSDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDL)).BeginInit();
            this.grboxTraCuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grBoxTiepNhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.grbDSDL);
            this.groupBox1.Controls.Add(this.grboxTraCuu);
            this.groupBox1.Controls.Add(this.grBoxTiepNhan);
            this.groupBox1.Controls.Add(this.btnTraCuu);
            this.groupBox1.Controls.Add(this.btnTiepNhan);
            this.groupBox1.Controls.Add(this.btnDanhSach);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1209, 536);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đại lý";
            // 
            // grbDSDL
            // 
            this.grbDSDL.Controls.Add(this.label1);
            this.grbDSDL.Controls.Add(this.btnXoaDL);
            this.grbDSDL.Controls.Add(this.btnSuaDL);
            this.grbDSDL.Controls.Add(this.dgvDSDL);
            this.grbDSDL.Location = new System.Drawing.Point(136, 213);
            this.grbDSDL.Name = "grbDSDL";
            this.grbDSDL.Size = new System.Drawing.Size(1065, 333);
            this.grbDSDL.TabIndex = 3;
            this.grbDSDL.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(398, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Đại Lý";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnXoaDL
            // 
            this.btnXoaDL.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXoaDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXoaDL.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDL.Image")));
            this.btnXoaDL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDL.Location = new System.Drawing.Point(786, 273);
            this.btnXoaDL.Name = "btnXoaDL";
            this.btnXoaDL.Size = new System.Drawing.Size(102, 54);
            this.btnXoaDL.TabIndex = 1;
            this.btnXoaDL.Text = "Xóa";
            this.btnXoaDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDL.UseVisualStyleBackColor = false;
            this.btnXoaDL.Click += new System.EventHandler(this.btnXoaDL_Click);
            // 
            // btnSuaDL
            // 
            this.btnSuaDL.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSuaDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuaDL.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDL.Image")));
            this.btnSuaDL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDL.Location = new System.Drawing.Point(920, 273);
            this.btnSuaDL.Name = "btnSuaDL";
            this.btnSuaDL.Size = new System.Drawing.Size(92, 54);
            this.btnSuaDL.TabIndex = 1;
            this.btnSuaDL.Text = "Sửa";
            this.btnSuaDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDL.UseVisualStyleBackColor = false;
            this.btnSuaDL.Click += new System.EventHandler(this.btnSuaDL_Click);
            // 
            // dgvDSDL
            // 
            this.dgvDSDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDL.Location = new System.Drawing.Point(20, 46);
            this.dgvDSDL.Name = "dgvDSDL";
            this.dgvDSDL.RowHeadersWidth = 62;
            this.dgvDSDL.RowTemplate.Height = 28;
            this.dgvDSDL.Size = new System.Drawing.Size(1028, 212);
            this.dgvDSDL.TabIndex = 2;
            this.dgvDSDL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDL_CellClick);
            // 
            // grboxTraCuu
            // 
            this.grboxTraCuu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grboxTraCuu.Controls.Add(this.pictureBox1);
            this.grboxTraCuu.Controls.Add(this.btnOKTraCuu);
            this.grboxTraCuu.Controls.Add(this.label15);
            this.grboxTraCuu.Controls.Add(this.cbBoxTraCuuMaDL);
            this.grboxTraCuu.Controls.Add(this.label16);
            this.grboxTraCuu.Location = new System.Drawing.Point(136, 9);
            this.grboxTraCuu.Name = "grboxTraCuu";
            this.grboxTraCuu.Size = new System.Drawing.Size(1067, 206);
            this.grboxTraCuu.TabIndex = 1;
            this.grboxTraCuu.TabStop = false;
            this.grboxTraCuu.Text = "Tra cứu ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(638, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 196);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnOKTraCuu
            // 
            this.btnOKTraCuu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnOKTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKTraCuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOKTraCuu.Location = new System.Drawing.Point(451, 97);
            this.btnOKTraCuu.Name = "btnOKTraCuu";
            this.btnOKTraCuu.Size = new System.Drawing.Size(124, 36);
            this.btnOKTraCuu.TabIndex = 3;
            this.btnOKTraCuu.Text = "Tra cứu";
            this.btnOKTraCuu.UseVisualStyleBackColor = false;
            this.btnOKTraCuu.Click += new System.EventHandler(this.btnOKTraCuu_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(42, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 25);
            this.label15.TabIndex = 3;
            this.label15.Text = "Mã đại lý";
            // 
            // cbBoxTraCuuMaDL
            // 
            this.cbBoxTraCuuMaDL.FormattingEnabled = true;
            this.cbBoxTraCuuMaDL.Location = new System.Drawing.Point(174, 102);
            this.cbBoxTraCuuMaDL.Name = "cbBoxTraCuuMaDL";
            this.cbBoxTraCuuMaDL.Size = new System.Drawing.Size(230, 28);
            this.cbBoxTraCuuMaDL.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label16.Location = new System.Drawing.Point(190, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(198, 32);
            this.label16.TabIndex = 2;
            this.label16.Text = "Tra cứu đại lý";
            // 
            // grBoxTiepNhan
            // 
            this.grBoxTiepNhan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grBoxTiepNhan.Controls.Add(this.label19);
            this.grBoxTiepNhan.Controls.Add(this.txtBoxEmail);
            this.grBoxTiepNhan.Controls.Add(this.label18);
            this.grBoxTiepNhan.Controls.Add(this.txtBoxTenDaiLy);
            this.grBoxTiepNhan.Controls.Add(this.btnThoat);
            this.grBoxTiepNhan.Controls.Add(this.btnThemDL);
            this.grBoxTiepNhan.Controls.Add(this.label8);
            this.grBoxTiepNhan.Controls.Add(this.label7);
            this.grBoxTiepNhan.Controls.Add(this.label9);
            this.grBoxTiepNhan.Controls.Add(this.label10);
            this.grBoxTiepNhan.Controls.Add(this.label11);
            this.grBoxTiepNhan.Controls.Add(this.label12);
            this.grBoxTiepNhan.Controls.Add(this.dtimeNgayTiepNhan);
            this.grBoxTiepNhan.Controls.Add(this.cbBoxLoaiDaiLy);
            this.grBoxTiepNhan.Controls.Add(this.cbBoxQuan);
            this.grBoxTiepNhan.Controls.Add(this.txtBoxDiaChi);
            this.grBoxTiepNhan.Controls.Add(this.txtBoxDienThoai);
            this.grBoxTiepNhan.Controls.Add(this.txtBoxMaDaiLy);
            this.grBoxTiepNhan.Controls.Add(this.label13);
            this.grBoxTiepNhan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grBoxTiepNhan.Location = new System.Drawing.Point(142, 15);
            this.grBoxTiepNhan.Name = "grBoxTiepNhan";
            this.grBoxTiepNhan.Size = new System.Drawing.Size(1067, 206);
            this.grBoxTiepNhan.TabIndex = 1;
            this.grBoxTiepNhan.TabStop = false;
            this.grBoxTiepNhan.Text = "Tiếp nhận đại lý";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Teal;
            this.label19.Location = new System.Drawing.Point(704, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 22);
            this.label19.TabIndex = 7;
            this.label19.Text = "Email";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(851, 96);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(163, 26);
            this.txtBoxEmail.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Teal;
            this.label18.Location = new System.Drawing.Point(18, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 22);
            this.label18.TabIndex = 5;
            this.label18.Text = "Tên đại lý";
            // 
            // txtBoxTenDaiLy
            // 
            this.txtBoxTenDaiLy.Location = new System.Drawing.Point(143, 99);
            this.txtBoxTenDaiLy.Name = "txtBoxTenDaiLy";
            this.txtBoxTenDaiLy.Size = new System.Drawing.Size(134, 26);
            this.txtBoxTenDaiLy.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThoat.Location = new System.Drawing.Point(788, 152);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 49);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThemDL
            // 
            this.btnThemDL.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThemDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemDL.Location = new System.Drawing.Point(912, 152);
            this.btnThemDL.Name = "btnThemDL";
            this.btnThemDL.Size = new System.Drawing.Size(102, 49);
            this.btnThemDL.TabIndex = 3;
            this.btnThemDL.Text = "Đồng ý";
            this.btnThemDL.UseVisualStyleBackColor = false;
            this.btnThemDL.Click += new System.EventHandler(this.btnThemDL_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(305, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ngày tiếp nhận";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(19, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Loại đại lý";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(305, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quận";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(305, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "Địa chỉ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(700, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 22);
            this.label11.TabIndex = 3;
            this.label11.Text = "Điện thoại";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(18, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 22);
            this.label12.TabIndex = 3;
            this.label12.Text = "Mã đại lý";
            // 
            // dtimeNgayTiepNhan
            // 
            this.dtimeNgayTiepNhan.Location = new System.Drawing.Point(451, 149);
            this.dtimeNgayTiepNhan.Name = "dtimeNgayTiepNhan";
            this.dtimeNgayTiepNhan.Size = new System.Drawing.Size(163, 26);
            this.dtimeNgayTiepNhan.TabIndex = 3;
            // 
            // cbBoxLoaiDaiLy
            // 
            this.cbBoxLoaiDaiLy.FormattingEnabled = true;
            this.cbBoxLoaiDaiLy.Location = new System.Drawing.Point(143, 147);
            this.cbBoxLoaiDaiLy.Name = "cbBoxLoaiDaiLy";
            this.cbBoxLoaiDaiLy.Size = new System.Drawing.Size(134, 28);
            this.cbBoxLoaiDaiLy.TabIndex = 3;
            // 
            // cbBoxQuan
            // 
            this.cbBoxQuan.FormattingEnabled = true;
            this.cbBoxQuan.Location = new System.Drawing.Point(451, 96);
            this.cbBoxQuan.Name = "cbBoxQuan";
            this.cbBoxQuan.Size = new System.Drawing.Size(163, 28);
            this.cbBoxQuan.TabIndex = 3;
            // 
            // txtBoxDiaChi
            // 
            this.txtBoxDiaChi.Location = new System.Drawing.Point(451, 51);
            this.txtBoxDiaChi.Name = "txtBoxDiaChi";
            this.txtBoxDiaChi.Size = new System.Drawing.Size(163, 26);
            this.txtBoxDiaChi.TabIndex = 4;
            // 
            // txtBoxDienThoai
            // 
            this.txtBoxDienThoai.Location = new System.Drawing.Point(851, 50);
            this.txtBoxDienThoai.Name = "txtBoxDienThoai";
            this.txtBoxDienThoai.Size = new System.Drawing.Size(163, 26);
            this.txtBoxDienThoai.TabIndex = 4;
            // 
            // txtBoxMaDaiLy
            // 
            this.txtBoxMaDaiLy.Location = new System.Drawing.Point(143, 52);
            this.txtBoxMaDaiLy.Name = "txtBoxMaDaiLy";
            this.txtBoxMaDaiLy.Size = new System.Drawing.Size(134, 26);
            this.txtBoxMaDaiLy.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(406, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(252, 37);
            this.label13.TabIndex = 2;
            this.label13.Text = "Thông tin đại lý";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTraCuu.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuu.Image")));
            this.btnTraCuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTraCuu.Location = new System.Drawing.Point(6, 240);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(124, 72);
            this.btnTraCuu.TabIndex = 1;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTiepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTiepNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnTiepNhan.Image")));
            this.btnTiepNhan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTiepNhan.Location = new System.Drawing.Point(6, 147);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(124, 72);
            this.btnTiepNhan.TabIndex = 1;
            this.btnTiepNhan.Text = "Tiếp nhận";
            this.btnTiepNhan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTiepNhan.UseVisualStyleBackColor = false;
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDanhSach.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSach.Image")));
            this.btnDanhSach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDanhSach.Location = new System.Drawing.Point(6, 57);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(124, 72);
            this.btnDanhSach.TabIndex = 1;
            this.btnDanhSach.Text = "Danh Sách";
            this.btnDanhSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDanhSach.UseVisualStyleBackColor = false;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // frmManHinhDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 1050);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManHinhDaiLy";
            this.Text = "MÀN HÌNH DANH SÁCH CÁC ĐẠI LÝ";
            this.Load += new System.EventHandler(this.frmManHinhDaiLy_Load);
            this.groupBox1.ResumeLayout(false);
            this.grbDSDL.ResumeLayout(false);
            this.grbDSDL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDL)).EndInit();
            this.grboxTraCuu.ResumeLayout(false);
            this.grboxTraCuu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grBoxTiepNhan.ResumeLayout(false);
            this.grBoxTiepNhan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSDL;
        private System.Windows.Forms.Button btnXoaDL;
        private System.Windows.Forms.Button btnSuaDL;
        private System.Windows.Forms.GroupBox grBoxTiepNhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemDL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtimeNgayTiepNhan;
        private System.Windows.Forms.ComboBox cbBoxLoaiDaiLy;
        private System.Windows.Forms.ComboBox cbBoxQuan;
        private System.Windows.Forms.TextBox txtBoxDiaChi;
        private System.Windows.Forms.TextBox txtBoxDienThoai;
        private System.Windows.Forms.TextBox txtBoxMaDaiLy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grboxTraCuu;
        private System.Windows.Forms.Button btnOKTraCuu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbBoxTraCuuMaDL;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnTiepNhan;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBoxTenDaiLy;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbDSDL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}