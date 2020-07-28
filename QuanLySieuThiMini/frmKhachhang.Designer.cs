namespace QuanLySieuThiMini
{
    partial class frmKhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachhang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHienthikhachhang = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TICHDIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTimkiemkh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoakh = new System.Windows.Forms.Button();
            this.btnDongkh = new System.Windows.Forms.Button();
            this.btnThemkh = new System.Windows.Forms.Button();
            this.btnHuythaotac = new System.Windows.Forms.Button();
            this.btnSuakh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSodiemtich = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSodienthoaikh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiachikh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenkhachhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthikhachhang)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(5, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 599);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHienthikhachhang);
            this.groupBox3.Location = new System.Drawing.Point(3, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(677, 267);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách khách hàng";
            // 
            // dgvHienthikhachhang
            // 
            this.dgvHienthikhachhang.AllowUserToAddRows = false;
            this.dgvHienthikhachhang.AllowUserToDeleteRows = false;
            this.dgvHienthikhachhang.BackgroundColor = System.Drawing.Color.White;
            this.dgvHienthikhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienthikhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.DIACHI,
            this.SDT,
            this.TICHDIEM});
            this.dgvHienthikhachhang.Location = new System.Drawing.Point(0, 28);
            this.dgvHienthikhachhang.Name = "dgvHienthikhachhang";
            this.dgvHienthikhachhang.ReadOnly = true;
            this.dgvHienthikhachhang.Size = new System.Drawing.Size(677, 239);
            this.dgvHienthikhachhang.TabIndex = 0;
            this.dgvHienthikhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienthikhachhang_CellClick);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã khách hàng";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            this.MAKH.Visible = false;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên khác hàng";
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            this.TENKH.Width = 200;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            this.DIACHI.Width = 280;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 150;
            // 
            // TICHDIEM
            // 
            this.TICHDIEM.DataPropertyName = "TICHDIEM";
            this.TICHDIEM.HeaderText = "Điểm đã tích";
            this.TICHDIEM.Name = "TICHDIEM";
            this.TICHDIEM.ReadOnly = true;
            this.TICHDIEM.Width = 150;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtTimkiemkh);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(3, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 54);
            this.panel3.TabIndex = 9;
            // 
            // txtTimkiemkh
            // 
            this.txtTimkiemkh.Location = new System.Drawing.Point(234, 12);
            this.txtTimkiemkh.Name = "txtTimkiemkh";
            this.txtTimkiemkh.Size = new System.Drawing.Size(305, 29);
            this.txtTimkiemkh.TabIndex = 7;
            this.txtTimkiemkh.TextChanged += new System.EventHandler(this.txtTimkiemkh_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tìm kiếm khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoakh);
            this.groupBox2.Controls.Add(this.btnDongkh);
            this.groupBox2.Controls.Add(this.btnThemkh);
            this.groupBox2.Controls.Add(this.btnHuythaotac);
            this.groupBox2.Controls.Add(this.btnSuakh);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 71);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btnXoakh
            // 
            this.btnXoakh.Location = new System.Drawing.Point(196, 28);
            this.btnXoakh.Name = "btnXoakh";
            this.btnXoakh.Size = new System.Drawing.Size(86, 29);
            this.btnXoakh.TabIndex = 6;
            this.btnXoakh.Text = "Xóa";
            this.btnXoakh.UseVisualStyleBackColor = true;
            this.btnXoakh.Click += new System.EventHandler(this.btnXoakh_Click);
            // 
            // btnDongkh
            // 
            this.btnDongkh.Location = new System.Drawing.Point(587, 28);
            this.btnDongkh.Name = "btnDongkh";
            this.btnDongkh.Size = new System.Drawing.Size(84, 29);
            this.btnDongkh.TabIndex = 5;
            this.btnDongkh.Text = "Đóng";
            this.btnDongkh.UseVisualStyleBackColor = true;
            this.btnDongkh.Click += new System.EventHandler(this.btnDongkh_Click);
            // 
            // btnThemkh
            // 
            this.btnThemkh.Location = new System.Drawing.Point(90, 28);
            this.btnThemkh.Name = "btnThemkh";
            this.btnThemkh.Size = new System.Drawing.Size(86, 29);
            this.btnThemkh.TabIndex = 4;
            this.btnThemkh.Text = "Thêm";
            this.btnThemkh.UseVisualStyleBackColor = true;
            this.btnThemkh.Click += new System.EventHandler(this.btnThemkh_Click);
            // 
            // btnHuythaotac
            // 
            this.btnHuythaotac.Location = new System.Drawing.Point(430, 28);
            this.btnHuythaotac.Name = "btnHuythaotac";
            this.btnHuythaotac.Size = new System.Drawing.Size(141, 29);
            this.btnHuythaotac.TabIndex = 3;
            this.btnHuythaotac.Text = "Hủy thao tác";
            this.btnHuythaotac.UseVisualStyleBackColor = true;
            this.btnHuythaotac.Click += new System.EventHandler(this.btnHuythaotac_Click);
            // 
            // btnSuakh
            // 
            this.btnSuakh.Location = new System.Drawing.Point(302, 28);
            this.btnSuakh.Name = "btnSuakh";
            this.btnSuakh.Size = new System.Drawing.Size(81, 29);
            this.btnSuakh.TabIndex = 2;
            this.btnSuakh.Text = "Sửa";
            this.btnSuakh.UseVisualStyleBackColor = true;
            this.btnSuakh.Click += new System.EventHandler(this.btnSuakh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSodiemtich);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSodienthoaikh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDiachikh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenkhachhang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtSodiemtich
            // 
            this.txtSodiemtich.Location = new System.Drawing.Point(199, 141);
            this.txtSodiemtich.Name = "txtSodiemtich";
            this.txtSodiemtich.ReadOnly = true;
            this.txtSodiemtich.Size = new System.Drawing.Size(184, 29);
            this.txtSodiemtich.TabIndex = 7;
            this.txtSodiemtich.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số điểm tích";
            // 
            // txtSodienthoaikh
            // 
            this.txtSodienthoaikh.Location = new System.Drawing.Point(199, 106);
            this.txtSodienthoaikh.Name = "txtSodienthoaikh";
            this.txtSodienthoaikh.Size = new System.Drawing.Size(184, 29);
            this.txtSodienthoaikh.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // txtDiachikh
            // 
            this.txtDiachikh.Location = new System.Drawing.Point(199, 71);
            this.txtDiachikh.Name = "txtDiachikh";
            this.txtDiachikh.Size = new System.Drawing.Size(394, 29);
            this.txtDiachikh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // txtTenkhachhang
            // 
            this.txtTenkhachhang.Location = new System.Drawing.Point(199, 36);
            this.txtTenkhachhang.Name = "txtTenkhachhang";
            this.txtTenkhachhang.Size = new System.Drawing.Size(283, 29);
            this.txtTenkhachhang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            // 
            // frmKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(699, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.frmKhachhang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthikhachhang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvHienthikhachhang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTimkiemkh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoakh;
        private System.Windows.Forms.Button btnDongkh;
        private System.Windows.Forms.Button btnThemkh;
        private System.Windows.Forms.Button btnHuythaotac;
        private System.Windows.Forms.Button btnSuakh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSodiemtich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSodienthoaikh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiachikh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenkhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TICHDIEM;
    }
}