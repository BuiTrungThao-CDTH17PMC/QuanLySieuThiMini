namespace QuanLySieuThiMini
{
    partial class frmHienthihoadonban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHienthihoadonban));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpNgaylap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvChitiethoadonban = new System.Windows.Forms.DataGridView();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhsachhoadonban = new System.Windows.Forms.DataGridView();
            this.MAHDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMSUDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiethoadonban)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachhoadonban)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 743);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.dtpNgaylap);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 52);
            this.panel2.TabIndex = 4;
            // 
            // dtpNgaylap
            // 
            this.dtpNgaylap.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaylap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaylap.Location = new System.Drawing.Point(234, 13);
            this.dtpNgaylap.Name = "dtpNgaylap";
            this.dtpNgaylap.Size = new System.Drawing.Size(258, 26);
            this.dtpNgaylap.TabIndex = 4;
            this.dtpNgaylap.Value = new System.DateTime(2020, 7, 31, 0, 0, 0, 0);
            this.dtpNgaylap.ValueChanged += new System.EventHandler(this.dtpNgaylap_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvChitiethoadonban);
            this.groupBox2.Location = new System.Drawing.Point(6, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(819, 322);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn bán";
            // 
            // dgvChitiethoadonban
            // 
            this.dgvChitiethoadonban.AllowUserToAddRows = false;
            this.dgvChitiethoadonban.AllowUserToDeleteRows = false;
            this.dgvChitiethoadonban.BackgroundColor = System.Drawing.Color.White;
            this.dgvChitiethoadonban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitiethoadonban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.MASP,
            this.TENSP,
            this.SOLUONG,
            this.GIATIEN,
            this.GIAMGIA});
            this.dgvChitiethoadonban.Location = new System.Drawing.Point(6, 25);
            this.dgvChitiethoadonban.Name = "dgvChitiethoadonban";
            this.dgvChitiethoadonban.ReadOnly = true;
            this.dgvChitiethoadonban.Size = new System.Drawing.Size(807, 291);
            this.dgvChitiethoadonban.TabIndex = 0;
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHDX";
            this.MAHD.HeaderText = "Mã hóa đơn bán";
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            this.MAHD.Width = 150;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            this.MASP.Width = 120;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            this.TENSP.Width = 200;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // GIATIEN
            // 
            this.GIATIEN.DataPropertyName = "GIATIEN";
            this.GIATIEN.HeaderText = "Giá tiền ";
            this.GIATIEN.Name = "GIATIEN";
            this.GIATIEN.ReadOnly = true;
            this.GIATIEN.Width = 110;
            // 
            // GIAMGIA
            // 
            this.GIAMGIA.DataPropertyName = "GIAMGIA";
            this.GIAMGIA.HeaderText = "Giảm giá";
            this.GIAMGIA.Name = "GIAMGIA";
            this.GIAMGIA.ReadOnly = true;
            this.GIAMGIA.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhsachhoadonban);
            this.groupBox1.Location = new System.Drawing.Point(8, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 351);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn bán ";
            // 
            // dgvDanhsachhoadonban
            // 
            this.dgvDanhsachhoadonban.AllowUserToAddRows = false;
            this.dgvDanhsachhoadonban.AllowUserToDeleteRows = false;
            this.dgvDanhsachhoadonban.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhsachhoadonban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachhoadonban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHDX,
            this.MANV,
            this.TENNV,
            this.TENKH,
            this.NGAYLAP,
            this.DIEMSUDUNG,
            this.TONGTIEN});
            this.dgvDanhsachhoadonban.Location = new System.Drawing.Point(6, 25);
            this.dgvDanhsachhoadonban.Name = "dgvDanhsachhoadonban";
            this.dgvDanhsachhoadonban.ReadOnly = true;
            this.dgvDanhsachhoadonban.Size = new System.Drawing.Size(807, 320);
            this.dgvDanhsachhoadonban.TabIndex = 0;
            this.dgvDanhsachhoadonban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsachhoadonban_CellClick);
            // 
            // MAHDX
            // 
            this.MAHDX.DataPropertyName = "MAHDX";
            this.MAHDX.HeaderText = "Mã hóa đơn";
            this.MAHDX.Name = "MAHDX";
            this.MAHDX.ReadOnly = true;
            this.MAHDX.Width = 120;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            this.MANV.Width = 120;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên nhân viên ";
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            this.TENNV.Width = 150;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "MAKH";
            this.TENKH.HeaderText = "Tên khách hàng";
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            this.TENKH.Width = 150;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày/Giờ lập";
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.ReadOnly = true;
            this.NGAYLAP.Width = 150;
            // 
            // DIEMSUDUNG
            // 
            this.DIEMSUDUNG.DataPropertyName = "SODIEMSUDUNG";
            this.DIEMSUDUNG.HeaderText = "Số điểm sự dụng";
            this.DIEMSUDUNG.Name = "DIEMSUDUNG";
            this.DIEMSUDUNG.ReadOnly = true;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(550, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 26);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.Black;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmHienthihoadonban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(843, 751);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHienthihoadonban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hiện thị hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.frmHienthihoadonban_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiethoadonban)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachhoadonban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhsachhoadonban;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvChitiethoadonban;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpNgaylap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMSUDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIA;
        private DevComponents.DotNetBar.ButtonX btnThoat;
    }
}