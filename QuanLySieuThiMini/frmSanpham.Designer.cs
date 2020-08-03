namespace QuanLySieuThiMini
{
    partial class frmSanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanpham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvHienthisanpham = new System.Windows.Forms.DataGridView();
            this.HINHANH = new System.Windows.Forms.DataGridViewImageColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimsanpham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoasanpham = new System.Windows.Forms.Button();
            this.btnHuythaotacsp = new System.Windows.Forms.Button();
            this.btnDongsp = new System.Windows.Forms.Button();
            this.btnSuasp = new System.Windows.Forms.Button();
            this.btnThemmoisp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiamgia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ptbAnhsanpham = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtTenanh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbNhacungcap = new System.Windows.Forms.ComboBox();
            this.cbbLoaisanpham = new System.Windows.Forms.ComboBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTensanpham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.HINHANH = new System.Windows.Forms.DataGridViewImageColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthisanpham)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhsanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 849);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(8, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 430);
            this.panel2.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvHienthisanpham);
            this.groupBox4.Location = new System.Drawing.Point(3, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(804, 337);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách sản phẩm";
            // 
            // dgvHienthisanpham
            // 
            this.dgvHienthisanpham.AllowUserToAddRows = false;
            this.dgvHienthisanpham.AllowUserToDeleteRows = false;
            this.dgvHienthisanpham.BackgroundColor = System.Drawing.Color.White;
            this.dgvHienthisanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienthisanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HINHANH,
            this.MASP,
            this.TENSP,
            this.DONGIA,
            this.GIAMGIA,
            this.SOLUONG,
            this.TENLOAI,
            this.TENNCC,
            this.MALOAI,
            this.MANCC});
            this.dgvHienthisanpham.Location = new System.Drawing.Point(3, 25);
            this.dgvHienthisanpham.Name = "dgvHienthisanpham";
            this.dgvHienthisanpham.ReadOnly = true;
            this.dgvHienthisanpham.Size = new System.Drawing.Size(795, 320);
            this.dgvHienthisanpham.TabIndex = 0;
            this.dgvHienthisanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienthisanpham_CellClick);
            // 
            // HINHANH
            // 
            this.HINHANH.DataPropertyName = "HINHANH";
            this.HINHANH.HeaderText = "Hình ảnh";
            this.HINHANH.Name = "HINHANH";
            this.HINHANH.ReadOnly = true;
            this.HINHANH.Width = 150;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            this.MASP.Width = 150;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            this.TENSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TENSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TENSP.Width = 250;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            this.DONGIA.Width = 120;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            this.SOLUONG.Width = 120;
            // 
            // TENLOAI
            // 
            this.TENLOAI.DataPropertyName = "TENLOAI";
            this.TENLOAI.HeaderText = "Loại sản phẩm";
            this.TENLOAI.Name = "TENLOAI";
            this.TENLOAI.ReadOnly = true;
            this.TENLOAI.Width = 150;
            // 
            // TENNCC
            // 
            this.TENNCC.DataPropertyName = "TENNCC";
            this.TENNCC.HeaderText = "Nhà cung cấp";
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.ReadOnly = true;
            this.TENNCC.Width = 150;
            // 
            // MALOAI
            // 
            this.MALOAI.DataPropertyName = "MALOAI";
            this.MALOAI.HeaderText = "Mã loai sản phẩm";
            this.MALOAI.Name = "MALOAI";
            this.MALOAI.ReadOnly = true;
            this.MALOAI.Visible = false;
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "Mã nhà cung cấp";
            this.MANCC.Name = "MANCC";
            this.MANCC.ReadOnly = true;
            this.MANCC.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimsanpham);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(3, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 63);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // txtTimsanpham
            // 
            this.txtTimsanpham.Location = new System.Drawing.Point(231, 23);
            this.txtTimsanpham.Name = "txtTimsanpham";
            this.txtTimsanpham.Size = new System.Drawing.Size(368, 29);
            this.txtTimsanpham.TabIndex = 1;
            this.txtTimsanpham.TextChanged += new System.EventHandler(this.txtTimsanpham_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tìm kiếm sản phẩm";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(8, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(812, 401);
            this.panel3.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoasanpham);
            this.groupBox2.Controls.Add(this.btnHuythaotacsp);
            this.groupBox2.Controls.Add(this.btnDongsp);
            this.groupBox2.Controls.Add(this.btnSuasp);
            this.groupBox2.Controls.Add(this.btnThemmoisp);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 322);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(792, 72);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnXoasanpham

            this.btnXoasanpham.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoasanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoasanpham.Location = new System.Drawing.Point(166, 23);
            this.btnXoasanpham.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoasanpham.Name = "btnXoasanpham";
            this.btnXoasanpham.Size = new System.Drawing.Size(101, 40);
            this.btnXoasanpham.TabIndex = 14;
            this.btnXoasanpham.Text = "Xóa";
            this.btnXoasanpham.UseVisualStyleBackColor = false;
            this.btnXoasanpham.Click += new System.EventHandler(this.btnXoasanpham_Click);

            // btnHuythaotacsp
            // 
            this.btnHuythaotacsp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnHuythaotacsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuythaotacsp.Location = new System.Drawing.Point(388, 23);
            this.btnHuythaotacsp.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuythaotacsp.Name = "btnHuythaotacsp";
            this.btnHuythaotacsp.Size = new System.Drawing.Size(138, 40);
            this.btnHuythaotacsp.TabIndex = 13;
            this.btnHuythaotacsp.Text = "Hủy thao tác";
            this.btnHuythaotacsp.UseVisualStyleBackColor = false;
            this.btnHuythaotacsp.Click += new System.EventHandler(this.btnHuythaotacsp_Click);
            // 
            // btnDongsp
            // 
            this.btnDongsp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDongsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongsp.Location = new System.Drawing.Point(670, 23);
            this.btnDongsp.Margin = new System.Windows.Forms.Padding(5);
            this.btnDongsp.Name = "btnDongsp";
            this.btnDongsp.Size = new System.Drawing.Size(101, 40);
            this.btnDongsp.TabIndex = 11;
            this.btnDongsp.Text = "Thoát";
            this.btnDongsp.UseVisualStyleBackColor = false;
            this.btnDongsp.Click += new System.EventHandler(this.btnDongsp_Click);
            // 
            // btnSuasp
            // 
            this.btnSuasp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSuasp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuasp.Location = new System.Drawing.Point(277, 23);
            this.btnSuasp.Margin = new System.Windows.Forms.Padding(5);
            this.btnSuasp.Name = "btnSuasp";
            this.btnSuasp.Size = new System.Drawing.Size(101, 40);
            this.btnSuasp.TabIndex = 9;
            this.btnSuasp.Text = "Sửa";
            this.btnSuasp.UseVisualStyleBackColor = false;
            this.btnSuasp.Click += new System.EventHandler(this.btnSuasp_Click);
            // 
            // btnThemmoisp
            // 
            this.btnThemmoisp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThemmoisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemmoisp.Location = new System.Drawing.Point(55, 23);
            this.btnThemmoisp.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemmoisp.Name = "btnThemmoisp";
            this.btnThemmoisp.Size = new System.Drawing.Size(101, 40);
            this.btnThemmoisp.TabIndex = 8;
            this.btnThemmoisp.Text = "Thêm";
            this.btnThemmoisp.UseVisualStyleBackColor = false;
            this.btnThemmoisp.Click += new System.EventHandler(this.btnThemmoisp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGiamgia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ptbAnhsanpham);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtTenanh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbNhacungcap);
            this.groupBox1.Controls.Add(this.cbbLoaisanpham);
            this.groupBox1.Controls.Add(this.txtDongia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTensanpham);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(792, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtGiamgia
            // 
            this.txtGiamgia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamgia.Location = new System.Drawing.Point(193, 136);
            this.txtGiamgia.Margin = new System.Windows.Forms.Padding(5);
            this.txtGiamgia.Name = "txtGiamgia";
            this.txtGiamgia.Size = new System.Drawing.Size(286, 29);
            this.txtGiamgia.TabIndex = 18;
            this.txtGiamgia.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Giảm giá";
            // 
            // ptbAnhsanpham
            // 
            this.ptbAnhsanpham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbAnhsanpham.Location = new System.Drawing.Point(487, 61);
            this.ptbAnhsanpham.Name = "ptbAnhsanpham";
            this.ptbAnhsanpham.Size = new System.Drawing.Size(297, 186);
            this.ptbAnhsanpham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAnhsanpham.TabIndex = 16;
            this.ptbAnhsanpham.TabStop = false;
            // 
            // btnBrowse

            this.btnBrowse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(489, 259);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(101, 29);
            this.btnBrowse.TabIndex = 15;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

            // txtTenanh
            // 
            this.txtTenanh.BackColor = System.Drawing.Color.White;
            this.txtTenanh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenanh.Location = new System.Drawing.Point(193, 259);
            this.txtTenanh.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenanh.Name = "txtTenanh";
            this.txtTenanh.ReadOnly = true;
            this.txtTenanh.Size = new System.Drawing.Size(286, 29);
            this.txtTenanh.TabIndex = 9;
            // 
           // label7

            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Link ảnh";

            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nhà cung cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Loại sản phẩm";
            // 
            // cbbNhacungcap
            // 
            this.cbbNhacungcap.BackColor = System.Drawing.Color.White;
            this.cbbNhacungcap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhacungcap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbNhacungcap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNhacungcap.FormattingEnabled = true;
            this.cbbNhacungcap.Location = new System.Drawing.Point(193, 218);
            this.cbbNhacungcap.Margin = new System.Windows.Forms.Padding(5);
            this.cbbNhacungcap.Name = "cbbNhacungcap";
            this.cbbNhacungcap.Size = new System.Drawing.Size(286, 29);
            this.cbbNhacungcap.TabIndex = 0;
            // 
            // cbbLoaisanpham
            // 
            this.cbbLoaisanpham.BackColor = System.Drawing.Color.White;
            this.cbbLoaisanpham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaisanpham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaisanpham.FormattingEnabled = true;
            this.cbbLoaisanpham.Location = new System.Drawing.Point(193, 179);
            this.cbbLoaisanpham.Margin = new System.Windows.Forms.Padding(5);
            this.cbbLoaisanpham.Name = "cbbLoaisanpham";
            this.cbbLoaisanpham.Size = new System.Drawing.Size(286, 29);
            this.cbbLoaisanpham.TabIndex = 1;
            // 
            // txtDongia
            // 
            this.txtDongia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDongia.Location = new System.Drawing.Point(193, 97);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(5);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(286, 29);
            this.txtDongia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn giá";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(193, 61);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(286, 29);
            this.txtSoluong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng ";
            // 
            // txtTensanpham
            // 
            this.txtTensanpham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensanpham.Location = new System.Drawing.Point(193, 22);
            this.txtTensanpham.Margin = new System.Windows.Forms.Padding(5);
            this.txtTensanpham.Name = "txtTensanpham";
            this.txtTensanpham.Size = new System.Drawing.Size(482, 29);
            this.txtTensanpham.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // HINHANH
            // 
            this.HINHANH.DataPropertyName = "HINHANH";
            this.HINHANH.HeaderText = "Hình ảnh";
            this.HINHANH.Name = "HINHANH";
            this.HINHANH.ReadOnly = true;
            this.HINHANH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HINHANH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HINHANH.Width = 150;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            this.MASP.Width = 150;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            this.TENSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TENSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TENSP.Width = 250;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            this.DONGIA.Width = 120;
            // 
            // GIAMGIA
            // 
            this.GIAMGIA.DataPropertyName = "GIAMGIA";
            this.GIAMGIA.HeaderText = "Giảm giá";
            this.GIAMGIA.Name = "GIAMGIA";
            this.GIAMGIA.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            this.SOLUONG.Width = 120;
            // 
            // TENLOAI
            // 
            this.TENLOAI.DataPropertyName = "TENLOAI";
            this.TENLOAI.HeaderText = "Loại sản phẩm";
            this.TENLOAI.Name = "TENLOAI";
            this.TENLOAI.ReadOnly = true;
            this.TENLOAI.Width = 150;
            // 
            // TENNCC
            // 
            this.TENNCC.DataPropertyName = "TENNCC";
            this.TENNCC.HeaderText = "Nhà cung cấp";
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.ReadOnly = true;
            this.TENNCC.Width = 150;
            // 
            // MALOAI
            // 
            this.MALOAI.DataPropertyName = "MALOAI";
            this.MALOAI.HeaderText = "Mã loai sản phẩm";
            this.MALOAI.Name = "MALOAI";
            this.MALOAI.ReadOnly = true;
            this.MALOAI.Visible = false;
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "Mã nhà cung cấp";
            this.MANCC.Name = "MANCC";
            this.MANCC.ReadOnly = true;
            this.MANCC.Visible = false;
            // 
            // frmSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(844, 855);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.frmSanpham_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthisanpham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhsanpham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTensanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbNhacungcap;
        private System.Windows.Forms.ComboBox cbbLoaisanpham;
        private System.Windows.Forms.Button btnHuythaotacsp;
        private System.Windows.Forms.Button btnDongsp;
        private System.Windows.Forms.Button btnSuasp;
        private System.Windows.Forms.Button btnThemmoisp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvHienthisanpham;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimsanpham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoasanpham;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtTenanh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ptbAnhsanpham;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtGiamgia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewImageColumn HINHANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.TextBox textBox1;
    }
}