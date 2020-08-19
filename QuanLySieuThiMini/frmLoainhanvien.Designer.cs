namespace QuanLySieuThiMini
{
    partial class frmLoainhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoainhanvien));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnHuythaotac = new DevComponents.DotNetBar.ButtonX();
            this.btnSualoainv = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaloainv = new DevComponents.DotNetBar.ButtonX();
            this.btnThemloainv = new DevComponents.DotNetBar.ButtonX();
            this.txtTenloainhanvien = new System.Windows.Forms.TextBox();
            this.dgvHienthiloainv = new System.Windows.Forms.DataGridView();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthiloainv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupBox1);
            this.panelEx1.Controls.Add(this.panel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(698, 381);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnHuythaotac);
            this.groupBox1.Controls.Add(this.btnSualoainv);
            this.groupBox1.Controls.Add(this.btnXoaloainv);
            this.groupBox1.Controls.Add(this.btnThemloainv);
            this.groupBox1.Controls.Add(this.txtTenloainhanvien);
            this.groupBox1.Controls.Add(this.dgvHienthiloainv);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Location = new System.Drawing.Point(9, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 294);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại nhân viên";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(493, 238);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(153, 32);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnDongloainv_Click);
            // 
            // btnHuythaotac
            // 
            this.btnHuythaotac.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuythaotac.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuythaotac.Location = new System.Drawing.Point(493, 187);
            this.btnHuythaotac.Name = "btnHuythaotac";
            this.btnHuythaotac.Size = new System.Drawing.Size(153, 32);
            this.btnHuythaotac.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuythaotac.TabIndex = 25;
            this.btnHuythaotac.Text = "Hủy thao tác";
            this.btnHuythaotac.Click += new System.EventHandler(this.btnHuythaotacloainv_Click);
            // 
            // btnSualoainv
            // 
            this.btnSualoainv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSualoainv.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSualoainv.Location = new System.Drawing.Point(493, 134);
            this.btnSualoainv.Name = "btnSualoainv";
            this.btnSualoainv.Size = new System.Drawing.Size(153, 32);
            this.btnSualoainv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSualoainv.TabIndex = 24;
            this.btnSualoainv.Text = "Sửa";
            this.btnSualoainv.Click += new System.EventHandler(this.btnSualoainv_Click);
            // 
            // btnXoaloainv
            // 
            this.btnXoaloainv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaloainv.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaloainv.Location = new System.Drawing.Point(493, 81);
            this.btnXoaloainv.Name = "btnXoaloainv";
            this.btnXoaloainv.Size = new System.Drawing.Size(153, 32);
            this.btnXoaloainv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaloainv.TabIndex = 23;
            this.btnXoaloainv.Text = "Xóa";
            this.btnXoaloainv.Click += new System.EventHandler(this.btnXoaloainv_Click);
            // 
            // btnThemloainv
            // 
            this.btnThemloainv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemloainv.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemloainv.Location = new System.Drawing.Point(493, 27);
            this.btnThemloainv.Name = "btnThemloainv";
            this.btnThemloainv.Size = new System.Drawing.Size(153, 32);
            this.btnThemloainv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemloainv.TabIndex = 22;
            this.btnThemloainv.Text = "Thêm";
            this.btnThemloainv.Click += new System.EventHandler(this.btnThemloainv_Click);
            // 
            // txtTenloainhanvien
            // 
            this.txtTenloainhanvien.Location = new System.Drawing.Point(174, 21);
            this.txtTenloainhanvien.Name = "txtTenloainhanvien";
            this.txtTenloainhanvien.Size = new System.Drawing.Size(287, 35);
            this.txtTenloainhanvien.TabIndex = 16;
            // 
            // dgvHienthiloainv
            // 
            this.dgvHienthiloainv.AllowUserToAddRows = false;
            this.dgvHienthiloainv.AllowUserToDeleteRows = false;
            this.dgvHienthiloainv.BackgroundColor = System.Drawing.Color.White;
            this.dgvHienthiloainv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienthiloainv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOAI,
            this.XOA,
            this.TENLOAI});
            this.dgvHienthiloainv.Location = new System.Drawing.Point(57, 66);
            this.dgvHienthiloainv.Name = "dgvHienthiloainv";
            this.dgvHienthiloainv.ReadOnly = true;
            this.dgvHienthiloainv.RowHeadersWidth = 51;
            this.dgvHienthiloainv.Size = new System.Drawing.Size(404, 208);
            this.dgvHienthiloainv.TabIndex = 15;
            this.dgvHienthiloainv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienthiloainv_CellClick);
            // 
            // MALOAI
            // 
            this.MALOAI.DataPropertyName = "MALOAI";
            this.MALOAI.HeaderText = "Mã loại";
            this.MALOAI.MinimumWidth = 6;
            this.MALOAI.Name = "MALOAI";
            this.MALOAI.ReadOnly = true;
            this.MALOAI.Width = 120;
            // 
            // XOA
            // 
            this.XOA.DataPropertyName = "XOA";
            this.XOA.HeaderText = "Xóa loại nhân viên";
            this.XOA.MinimumWidth = 6;
            this.XOA.Name = "XOA";
            this.XOA.ReadOnly = true;
            this.XOA.Visible = false;
            this.XOA.Width = 125;
            // 
            // TENLOAI
            // 
            this.TENLOAI.DataPropertyName = "TENLOAI";
            this.TENLOAI.HeaderText = "Tên loại nhân viên";
            this.TENLOAI.MinimumWidth = 6;
            this.TENLOAI.Name = "TENLOAI";
            this.TENLOAI.ReadOnly = true;
            this.TENLOAI.Width = 200;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(9, 21);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(146, 25);
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "Tên loại nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 61);
            this.panel1.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.FontBold = true;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(18, 9);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(222, 38);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Loại nhân viên";
            // 
            // frmLoainhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(697, 381);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoainhanvien";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại nhân viên";
            this.Load += new System.EventHandler(this.frmLoainhanvien_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthiloainv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenloainhanvien;
        private System.Windows.Forms.DataGridView dgvHienthiloainv;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn XOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAI;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnHuythaotac;
        private DevComponents.DotNetBar.ButtonX btnSualoainv;
        private DevComponents.DotNetBar.ButtonX btnXoaloainv;
        private DevComponents.DotNetBar.ButtonX btnThemloainv;
    }
}