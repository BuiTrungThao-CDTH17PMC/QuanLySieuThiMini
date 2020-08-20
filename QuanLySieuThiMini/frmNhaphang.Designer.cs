namespace QuanLySieuThiMini
{
    partial class frmNhaphang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaphang));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btn_Thoat = new DevComponents.DotNetBar.ButtonX();
            this.btn_Themsoluong = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_Danhsachsanpham = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btn_formSanpham = new DevComponents.DotNetBar.ButtonX();
            this.txt_Tensanpham = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Loaisanpham = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Nhacungcap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Soluong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAISP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAISP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Danhsachsanpham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btn_Thoat);
            this.panelEx1.Controls.Add(this.btn_Themsoluong);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Controls.Add(this.groupBox1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1033, 646);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Thoat.Location = new System.Drawing.Point(911, 187);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(103, 64);
            this.btn_Thoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Themsoluong
            // 
            this.btn_Themsoluong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Themsoluong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Themsoluong.Location = new System.Drawing.Point(745, 187);
            this.btn_Themsoluong.Name = "btn_Themsoluong";
            this.btn_Themsoluong.Size = new System.Drawing.Size(125, 64);
            this.btn_Themsoluong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Themsoluong.TabIndex = 0;
            this.btn_Themsoluong.Text = "Thêm hàng";
            this.btn_Themsoluong.Click += new System.EventHandler(this.btn_Themsoluong_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgv_Danhsachsanpham);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 254);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1008, 384);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "Danh sách sản phẩm";
            // 
            // dgv_Danhsachsanpham
            // 
            this.dgv_Danhsachsanpham.AllowUserToAddRows = false;
            this.dgv_Danhsachsanpham.AllowUserToDeleteRows = false;
            this.dgv_Danhsachsanpham.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Danhsachsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Danhsachsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.TENSP,
            this.TENNCC,
            this.MANCC,
            this.MALOAISP,
            this.LOAISP,
            this.SOLUONG});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Danhsachsanpham.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Danhsachsanpham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_Danhsachsanpham.Location = new System.Drawing.Point(3, 3);
            this.dgv_Danhsachsanpham.Name = "dgv_Danhsachsanpham";
            this.dgv_Danhsachsanpham.ReadOnly = true;
            this.dgv_Danhsachsanpham.Size = new System.Drawing.Size(996, 348);
            this.dgv_Danhsachsanpham.TabIndex = 0;
            this.dgv_Danhsachsanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Danhsachsanpham_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.btn_formSanpham);
            this.groupBox1.Controls.Add(this.txt_Tensanpham);
            this.groupBox1.Controls.Add(this.txt_Loaisanpham);
            this.groupBox1.Controls.Add(this.txt_Nhacungcap);
            this.groupBox1.Controls.Add(this.txt_Soluong);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập hàng";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(505, 103);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(128, 23);
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "Loại sản phẩm : ";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(505, 48);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(132, 23);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "Nhà cung cấp : ";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(17, 103);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(106, 23);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Số lượng : ";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(17, 45);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(106, 29);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "Sản phẩm : ";
            // 
            // btn_formSanpham
            // 
            this.btn_formSanpham.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_formSanpham.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_formSanpham.Location = new System.Drawing.Point(383, 45);
            this.btn_formSanpham.Name = "btn_formSanpham";
            this.btn_formSanpham.Size = new System.Drawing.Size(75, 29);
            this.btn_formSanpham.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_formSanpham.TabIndex = 8;
            this.btn_formSanpham.Text = "Thêm SP";
            this.btn_formSanpham.Click += new System.EventHandler(this.btn_formSanpham_Click);
            // 
            // txt_Tensanpham
            // 
            // 
            // 
            // 
            this.txt_Tensanpham.Border.Class = "TextBoxBorder";
            this.txt_Tensanpham.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Tensanpham.Location = new System.Drawing.Point(138, 45);
            this.txt_Tensanpham.Name = "txt_Tensanpham";
            this.txt_Tensanpham.PreventEnterBeep = true;
            this.txt_Tensanpham.Size = new System.Drawing.Size(226, 29);
            this.txt_Tensanpham.TabIndex = 9;
            // 
            // txt_Loaisanpham
            // 
            // 
            // 
            // 
            this.txt_Loaisanpham.Border.Class = "TextBoxBorder";
            this.txt_Loaisanpham.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Loaisanpham.Location = new System.Drawing.Point(643, 103);
            this.txt_Loaisanpham.Name = "txt_Loaisanpham";
            this.txt_Loaisanpham.PreventEnterBeep = true;
            this.txt_Loaisanpham.Size = new System.Drawing.Size(242, 29);
            this.txt_Loaisanpham.TabIndex = 7;
            // 
            // txt_Nhacungcap
            // 
            // 
            // 
            // 
            this.txt_Nhacungcap.Border.Class = "TextBoxBorder";
            this.txt_Nhacungcap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Nhacungcap.Location = new System.Drawing.Point(643, 45);
            this.txt_Nhacungcap.Name = "txt_Nhacungcap";
            this.txt_Nhacungcap.PreventEnterBeep = true;
            this.txt_Nhacungcap.Size = new System.Drawing.Size(242, 29);
            this.txt_Nhacungcap.TabIndex = 5;
            // 
            // txt_Soluong
            // 
            // 
            // 
            // 
            this.txt_Soluong.Border.Class = "TextBoxBorder";
            this.txt_Soluong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Soluong.Location = new System.Drawing.Point(138, 103);
            this.txt_Soluong.Name = "txt_Soluong";
            this.txt_Soluong.PreventEnterBeep = true;
            this.txt_Soluong.Size = new System.Drawing.Size(226, 29);
            this.txt_Soluong.TabIndex = 3;
            this.txt_Soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Soluong_KeyPress);
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            this.MASP.Visible = false;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            this.TENSP.Width = 350;
            // 
            // TENNCC
            // 
            this.TENNCC.DataPropertyName = "TENNCC";
            this.TENNCC.HeaderText = "Nhà cung cấp";
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.ReadOnly = true;
            this.TENNCC.Width = 350;
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "Mã nhà cung cấp";
            this.MANCC.Name = "MANCC";
            this.MANCC.ReadOnly = true;
            this.MANCC.Visible = false;
            this.MANCC.Width = 150;
            // 
            // MALOAISP
            // 
            this.MALOAISP.DataPropertyName = "MALOAI";
            this.MALOAISP.HeaderText = "Mã loại sản phẩm";
            this.MALOAISP.Name = "MALOAISP";
            this.MALOAISP.ReadOnly = true;
            this.MALOAISP.Visible = false;
            this.MALOAISP.Width = 150;
            // 
            // LOAISP
            // 
            this.LOAISP.DataPropertyName = "TENLOAI";
            this.LOAISP.HeaderText = "Loại sản phẩm";
            this.LOAISP.Name = "LOAISP";
            this.LOAISP.ReadOnly = true;
            this.LOAISP.Width = 150;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            this.SOLUONG.Width = 200;
            // 
            // frmNhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1032, 645);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhaphang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.frmNhaphang_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Danhsachsanpham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btn_Thoat;
        private DevComponents.DotNetBar.ButtonX btn_Themsoluong;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_Danhsachsanpham;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_formSanpham;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Tensanpham;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Loaisanpham;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Nhacungcap;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAISP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAISP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;


    }
}