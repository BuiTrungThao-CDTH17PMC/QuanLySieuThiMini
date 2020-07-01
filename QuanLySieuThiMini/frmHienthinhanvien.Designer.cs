namespace QuanLySieuThiMini
{
    partial class frmHienthinhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHienthinhanvien));
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtTimnhanvien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTimnhanvien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHienthinhanvien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthinhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.groupBox1);
            this.panelEx2.Controls.Add(this.panel1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Location = new System.Drawing.Point(5, 6);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(687, 357);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnTimnhanvien);
            this.panel1.Controls.Add(this.txtTimnhanvien);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 58);
            this.panel1.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(25, 14);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(146, 26);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tìm kiếm nhân viên ";
            // 
            // txtTimnhanvien
            // 
            // 
            // 
            // 
            this.txtTimnhanvien.Border.Class = "TextBoxBorder";
            this.txtTimnhanvien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimnhanvien.Location = new System.Drawing.Point(177, 14);
            this.txtTimnhanvien.Name = "txtTimnhanvien";
            this.txtTimnhanvien.PreventEnterBeep = true;
            this.txtTimnhanvien.Size = new System.Drawing.Size(331, 26);
            this.txtTimnhanvien.TabIndex = 1;
            // 
            // btnTimnhanvien
            // 
            this.btnTimnhanvien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTimnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimnhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimnhanvien.Location = new System.Drawing.Point(540, 14);
            this.btnTimnhanvien.Name = "btnTimnhanvien";
            this.btnTimnhanvien.Size = new System.Drawing.Size(75, 26);
            this.btnTimnhanvien.TabIndex = 2;
            this.btnTimnhanvien.Text = "Tìm";
            this.btnTimnhanvien.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgvHienthinhanvien);
            this.groupBox1.Location = new System.Drawing.Point(6, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 278);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // dgvHienthinhanvien
            // 
            this.dgvHienthinhanvien.AllowUserToAddRows = false;
            this.dgvHienthinhanvien.AllowUserToDeleteRows = false;
            this.dgvHienthinhanvien.BackgroundColor = System.Drawing.Color.White;
            this.dgvHienthinhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienthinhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvHienthinhanvien.Location = new System.Drawing.Point(6, 25);
            this.dgvHienthinhanvien.Name = "dgvHienthinhanvien";
            this.dgvHienthinhanvien.ReadOnly = true;
            this.dgvHienthinhanvien.Size = new System.Drawing.Size(664, 247);
            this.dgvHienthinhanvien.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Giới tính(Nam)";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Là nhân viên";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tài khoản đăng nhập";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mật khẩu";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // frmHienthinhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(697, 366);
            this.Controls.Add(this.panelEx2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHienthinhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hiện thị nhân viên";
            this.panelEx2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthinhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimnhanvien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimnhanvien;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHienthinhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}