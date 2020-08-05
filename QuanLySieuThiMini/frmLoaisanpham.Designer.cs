namespace QuanLySieuThiMini
{
    partial class frmLoaisanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaisanpham));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenloaisp = new System.Windows.Forms.TextBox();
            this.dgvLoaisanpham = new System.Windows.Forms.DataGridView();
            this.MALOAISP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemloaisp = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaloaisp = new DevComponents.DotNetBar.ButtonX();
            this.btnSualoaisp = new DevComponents.DotNetBar.ButtonX();
            this.btnHuythaotacloaisp = new DevComponents.DotNetBar.ButtonX();
            this.btnDongloaisp = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaisanpham)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(-1, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(782, 434);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 418);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDongloaisp);
            this.groupBox1.Controls.Add(this.btnHuythaotacloaisp);
            this.groupBox1.Controls.Add(this.btnSualoaisp);
            this.groupBox1.Controls.Add(this.btnXoaloaisp);
            this.groupBox1.Controls.Add(this.btnThemloaisp);
            this.groupBox1.Controls.Add(this.txtTenloaisp);
            this.groupBox1.Controls.Add(this.dgvLoaisanpham);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(748, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại sản phẩm";
            // 
            // txtTenloaisp
            // 
            this.txtTenloaisp.Location = new System.Drawing.Point(175, 34);
            this.txtTenloaisp.Name = "txtTenloaisp";
            this.txtTenloaisp.Size = new System.Drawing.Size(334, 29);
            this.txtTenloaisp.TabIndex = 10;
            // 
            // dgvLoaisanpham
            // 
            this.dgvLoaisanpham.AllowUserToAddRows = false;
            this.dgvLoaisanpham.AllowUserToDeleteRows = false;
            this.dgvLoaisanpham.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaisanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaisanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOAISP,
            this.TENLOAI});
            this.dgvLoaisanpham.Location = new System.Drawing.Point(116, 75);
            this.dgvLoaisanpham.Margin = new System.Windows.Forms.Padding(6);
            this.dgvLoaisanpham.Name = "dgvLoaisanpham";
            this.dgvLoaisanpham.ReadOnly = true;
            this.dgvLoaisanpham.Size = new System.Drawing.Size(393, 209);
            this.dgvLoaisanpham.TabIndex = 3;
            this.dgvLoaisanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaisanpham_CellClick);
            // 
            // MALOAISP
            // 
            this.MALOAISP.DataPropertyName = "MALOAI";
            this.MALOAISP.HeaderText = "Mã loại";
            this.MALOAISP.Name = "MALOAISP";
            this.MALOAISP.ReadOnly = true;
            this.MALOAISP.Visible = false;
            // 
            // TENLOAI
            // 
            this.TENLOAI.DataPropertyName = "TENLOAI";
            this.TENLOAI.HeaderText = "Tên Loại sản phẩm";
            this.TENLOAI.Name = "TENLOAI";
            this.TENLOAI.ReadOnly = true;
            this.TENLOAI.Width = 350;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại sản phẩm";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 80);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại sản phẩm";
            // 
            // btnThemloaisp
            // 
            this.btnThemloaisp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemloaisp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemloaisp.Location = new System.Drawing.Point(545, 41);
            this.btnThemloaisp.Name = "btnThemloaisp";
            this.btnThemloaisp.Size = new System.Drawing.Size(169, 32);
            this.btnThemloaisp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemloaisp.TabIndex = 11;
            this.btnThemloaisp.Text = "Thêm";
            this.btnThemloaisp.Click += new System.EventHandler(this.btnThemloaisp_Click);
            // 
            // btnXoaloaisp
            // 
            this.btnXoaloaisp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaloaisp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaloaisp.Location = new System.Drawing.Point(545, 93);
            this.btnXoaloaisp.Name = "btnXoaloaisp";
            this.btnXoaloaisp.Size = new System.Drawing.Size(169, 32);
            this.btnXoaloaisp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaloaisp.TabIndex = 12;
            this.btnXoaloaisp.Text = "Xóa";
            this.btnXoaloaisp.Click += new System.EventHandler(this.btnXoaloaisp_Click);
            // 
            // btnSualoaisp
            // 
            this.btnSualoaisp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSualoaisp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSualoaisp.Location = new System.Drawing.Point(545, 144);
            this.btnSualoaisp.Name = "btnSualoaisp";
            this.btnSualoaisp.Size = new System.Drawing.Size(169, 32);
            this.btnSualoaisp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSualoaisp.TabIndex = 13;
            this.btnSualoaisp.Text = "Sửa";
            this.btnSualoaisp.Click += new System.EventHandler(this.btnSualoaisp_Click);
            // 
            // btnHuythaotacloaisp
            // 
            this.btnHuythaotacloaisp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuythaotacloaisp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuythaotacloaisp.Location = new System.Drawing.Point(545, 194);
            this.btnHuythaotacloaisp.Name = "btnHuythaotacloaisp";
            this.btnHuythaotacloaisp.Size = new System.Drawing.Size(169, 32);
            this.btnHuythaotacloaisp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuythaotacloaisp.TabIndex = 14;
            this.btnHuythaotacloaisp.Text = "Hủy thao tác";
            this.btnHuythaotacloaisp.Click += new System.EventHandler(this.btnHuythaotacloaisp_Click);
            // 
            // btnDongloaisp
            // 
            this.btnDongloaisp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongloaisp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongloaisp.Location = new System.Drawing.Point(545, 245);
            this.btnDongloaisp.Name = "btnDongloaisp";
            this.btnDongloaisp.Size = new System.Drawing.Size(169, 32);
            this.btnDongloaisp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDongloaisp.TabIndex = 15;
            this.btnDongloaisp.Text = "Thoát";
            this.btnDongloaisp.Click += new System.EventHandler(this.btnDongloaisp_Click);
            // 
            // frmLoaisanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(780, 434);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoaisanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại sản phẩm";
            this.Load += new System.EventHandler(this.frmLoaisanpham_Load);
            this.panelEx1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaisanpham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnDongloaisp;
        private DevComponents.DotNetBar.ButtonX btnHuythaotacloaisp;
        private DevComponents.DotNetBar.ButtonX btnSualoaisp;
        private DevComponents.DotNetBar.ButtonX btnXoaloaisp;
        private DevComponents.DotNetBar.ButtonX btnThemloaisp;
        private System.Windows.Forms.TextBox txtTenloaisp;
        private System.Windows.Forms.DataGridView dgvLoaisanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAISP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;

    }
}