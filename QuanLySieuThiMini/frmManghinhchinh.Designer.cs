namespace QuanLySieuThiMini
{
    partial class frmManghinhchinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManghinhchinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Loaisanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Nhacungcap = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Sanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Khachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Hoadonbanhang = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.ngườiDùngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1012, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Nhanvien,
            this.TSMI,
            this.TSMI_Khachhang});
            this.quảnLýToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // TSMI_Nhanvien
            // 
            this.TSMI_Nhanvien.Name = "TSMI_Nhanvien";
            this.TSMI_Nhanvien.Size = new System.Drawing.Size(168, 26);
            this.TSMI_Nhanvien.Text = "Nhân viên";
            this.TSMI_Nhanvien.Click += new System.EventHandler(this.TSMI_Nhanvien_Click);
            // 
            // TSMI
            // 
            this.TSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Loaisanpham,
            this.TSMI_Nhacungcap,
            this.TSMI_Sanpham});
            this.TSMI.Name = "TSMI";
            this.TSMI.Size = new System.Drawing.Size(168, 26);
            this.TSMI.Text = "Sản phẩm";
            // 
            // TSMI_Loaisanpham
            // 
            this.TSMI_Loaisanpham.Name = "TSMI_Loaisanpham";
            this.TSMI_Loaisanpham.Size = new System.Drawing.Size(189, 26);
            this.TSMI_Loaisanpham.Text = "Loại sản phẩm";
            this.TSMI_Loaisanpham.Click += new System.EventHandler(this.TSMI_Loaisanpham_Click);
            // 
            // TSMI_Nhacungcap
            // 
            this.TSMI_Nhacungcap.Name = "TSMI_Nhacungcap";
            this.TSMI_Nhacungcap.Size = new System.Drawing.Size(189, 26);
            this.TSMI_Nhacungcap.Text = "Nhà cung cấp";
            this.TSMI_Nhacungcap.Click += new System.EventHandler(this.TSMI_Nhacungcap_Click);
            // 
            // TSMI_Sanpham
            // 
            this.TSMI_Sanpham.Name = "TSMI_Sanpham";
            this.TSMI_Sanpham.Size = new System.Drawing.Size(189, 26);
            this.TSMI_Sanpham.Text = "Sản phẩm";
            this.TSMI_Sanpham.Click += new System.EventHandler(this.TSMI_Sanpham_Click);
            // 
            // TSMI_Khachhang
            // 
            this.TSMI_Khachhang.Name = "TSMI_Khachhang";
            this.TSMI_Khachhang.Size = new System.Drawing.Size(168, 26);
            this.TSMI_Khachhang.Text = "Khách hàng";
            this.TSMI_Khachhang.Click += new System.EventHandler(this.TSMI_Khachhang_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Hoadonbanhang});
            this.hóaĐơnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // TSMI_Hoadonbanhang
            // 
            this.TSMI_Hoadonbanhang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMI_Hoadonbanhang.Name = "TSMI_Hoadonbanhang";
            this.TSMI_Hoadonbanhang.Size = new System.Drawing.Size(217, 26);
            this.TSMI_Hoadonbanhang.Text = "Hóa đơn bán hàng";
            this.TSMI_Hoadonbanhang.Click += new System.EventHandler(this.TSMI_Hoadonbanhang_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoNhậpToolStripMenuItem,
            this.báoCáoBánHàngToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // báoCáoNhậpToolStripMenuItem
            // 
            this.báoCáoNhậpToolStripMenuItem.Name = "báoCáoNhậpToolStripMenuItem";
            this.báoCáoNhậpToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.báoCáoNhậpToolStripMenuItem.Text = "Báo cáo nhập";
            // 
            // báoCáoBánHàngToolStripMenuItem
            // 
            this.báoCáoBánHàngToolStripMenuItem.Name = "báoCáoBánHàngToolStripMenuItem";
            this.báoCáoBánHàngToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.báoCáoBánHàngToolStripMenuItem.Text = "Báo cáo bán hàng";
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Dangxuat,
            this.TSMI_Thoat});
            this.ngườiDùngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            // 
            // TSMI_Dangxuat
            // 
            this.TSMI_Dangxuat.Name = "TSMI_Dangxuat";
            this.TSMI_Dangxuat.Size = new System.Drawing.Size(156, 26);
            this.TSMI_Dangxuat.Text = "Đăng xuất";
            // 
            // TSMI_Thoat
            // 
            this.TSMI_Thoat.Name = "TSMI_Thoat";
            this.TSMI_Thoat.Size = new System.Drawing.Size(156, 26);
            this.TSMI_Thoat.Text = "Thoát";
            this.TSMI_Thoat.Click += new System.EventHandler(this.TSMI_Thoat_Click);
            // 
            // frmManghinhchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1012, 520);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmManghinhchinh";
            this.Text = "Siêu thị mini";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManghinhchinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Nhanvien;
        private System.Windows.Forms.ToolStripMenuItem TSMI;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Khachhang;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Hoadonbanhang;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Dangxuat;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Thoat;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Loaisanpham;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Nhacungcap;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Sanpham;

    }
}