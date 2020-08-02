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
            this.btnHuythaotacloainv = new System.Windows.Forms.Button();
            this.txtTenloainhanvien = new System.Windows.Forms.TextBox();
            this.btnDongloainv = new System.Windows.Forms.Button();
            this.dgvHienthiloainv = new System.Windows.Forms.DataGridView();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSualoainv = new System.Windows.Forms.Button();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnXoaloainv = new System.Windows.Forms.Button();
            this.btnThemloainv = new System.Windows.Forms.Button();
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
            this.panelEx1.Location = new System.Drawing.Point(4, 7);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(688, 371);
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
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnHuythaotacloainv);
            this.groupBox1.Controls.Add(this.txtTenloainhanvien);
            this.groupBox1.Controls.Add(this.btnDongloainv);
            this.groupBox1.Controls.Add(this.dgvHienthiloainv);
            this.groupBox1.Controls.Add(this.btnSualoainv);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.btnXoaloainv);
            this.groupBox1.Controls.Add(this.btnThemloainv);
            this.groupBox1.Location = new System.Drawing.Point(9, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 294);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại nhân viên";
            // 
            // btnHuythaotacloainv
            // 
            this.btnHuythaotacloainv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnHuythaotacloainv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuythaotacloainv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuythaotacloainv.Location = new System.Drawing.Point(493, 181);
            this.btnHuythaotacloainv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnHuythaotacloainv.Name = "btnHuythaotacloainv";
            this.btnHuythaotacloainv.Size = new System.Drawing.Size(153, 42);
            this.btnHuythaotacloainv.TabIndex = 21;
            this.btnHuythaotacloainv.Text = "Hủy thao tác";
            this.btnHuythaotacloainv.UseVisualStyleBackColor = false;
            this.btnHuythaotacloainv.Click += new System.EventHandler(this.btnHuythaotacloainv_Click);
            // 
            // txtTenloainhanvien
            // 
            this.txtTenloainhanvien.Location = new System.Drawing.Point(176, 20);
            this.txtTenloainhanvien.Name = "txtTenloainhanvien";
            this.txtTenloainhanvien.Size = new System.Drawing.Size(287, 29);
            this.txtTenloainhanvien.TabIndex = 16;
            // 
            // btnDongloainv
            // 
            this.btnDongloainv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDongloainv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongloainv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongloainv.Location = new System.Drawing.Point(493, 232);
            this.btnDongloainv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDongloainv.Name = "btnDongloainv";
            this.btnDongloainv.Size = new System.Drawing.Size(153, 42);
            this.btnDongloainv.TabIndex = 20;
            this.btnDongloainv.Text = "Đóng";
            this.btnDongloainv.UseVisualStyleBackColor = false;
            this.btnDongloainv.Click += new System.EventHandler(this.btnDongloainv_Click);
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
            this.dgvHienthiloainv.Location = new System.Drawing.Point(59, 66);
            this.dgvHienthiloainv.Name = "dgvHienthiloainv";
            this.dgvHienthiloainv.ReadOnly = true;
            this.dgvHienthiloainv.Size = new System.Drawing.Size(404, 208);
            this.dgvHienthiloainv.TabIndex = 15;
            this.dgvHienthiloainv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienthiloainv_CellClick);
            // 
            // MALOAI
            // 
            this.MALOAI.DataPropertyName = "MALOAI";
            this.MALOAI.HeaderText = "Mã loại";
            this.MALOAI.Name = "MALOAI";
            this.MALOAI.ReadOnly = true;
            this.MALOAI.Width = 120;
            // 
            // XOA
            // 
            this.XOA.DataPropertyName = "XOA";
            this.XOA.HeaderText = "Xóa loại nhân viên";
            this.XOA.Name = "XOA";
            this.XOA.ReadOnly = true;
            this.XOA.Visible = false;
            // 
            // TENLOAI
            // 
            this.TENLOAI.DataPropertyName = "TENLOAI";
            this.TENLOAI.HeaderText = "Tên loại nhân viên";
            this.TENLOAI.Name = "TENLOAI";
            this.TENLOAI.ReadOnly = true;
            this.TENLOAI.Width = 200;
            // 
            // btnSualoainv
            // 
            this.btnSualoainv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSualoainv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSualoainv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSualoainv.Location = new System.Drawing.Point(493, 75);
            this.btnSualoainv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSualoainv.Name = "btnSualoainv";
            this.btnSualoainv.Size = new System.Drawing.Size(153, 42);
            this.btnSualoainv.TabIndex = 19;
            this.btnSualoainv.Text = "Sửa";
            this.btnSualoainv.UseVisualStyleBackColor = false;
            this.btnSualoainv.Click += new System.EventHandler(this.btnSualoainv_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(23, 20);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(146, 25);
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "Tên loại nhân viên";
            // 
            // btnXoaloainv
            // 
            this.btnXoaloainv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoaloainv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaloainv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaloainv.Location = new System.Drawing.Point(493, 128);
            this.btnXoaloainv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnXoaloainv.Name = "btnXoaloainv";
            this.btnXoaloainv.Size = new System.Drawing.Size(153, 42);
            this.btnXoaloainv.TabIndex = 18;
            this.btnXoaloainv.Text = "Xóa";
            this.btnXoaloainv.UseVisualStyleBackColor = false;
            this.btnXoaloainv.Click += new System.EventHandler(this.btnXoaloainv_Click);
            // 
            // btnThemloainv
            // 
            this.btnThemloainv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThemloainv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemloainv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemloainv.Location = new System.Drawing.Point(493, 20);
            this.btnThemloainv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnThemloainv.Name = "btnThemloainv";
            this.btnThemloainv.Size = new System.Drawing.Size(153, 42);
            this.btnThemloainv.TabIndex = 17;
            this.btnThemloainv.Text = "Thêm ";
            this.btnThemloainv.UseVisualStyleBackColor = false;
            this.btnThemloainv.Click += new System.EventHandler(this.btnThemloainv_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
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
            this.labelX1.Location = new System.Drawing.Point(18, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(222, 38);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Loại nhân viên";
            // 
            // frmLoainhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
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
        private System.Windows.Forms.Button btnHuythaotacloainv;
        private System.Windows.Forms.TextBox txtTenloainhanvien;
        private System.Windows.Forms.Button btnDongloainv;
        private System.Windows.Forms.DataGridView dgvHienthiloainv;
        private System.Windows.Forms.Button btnSualoainv;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Button btnXoaloainv;
        private System.Windows.Forms.Button btnThemloainv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn XOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAI;
    }
}