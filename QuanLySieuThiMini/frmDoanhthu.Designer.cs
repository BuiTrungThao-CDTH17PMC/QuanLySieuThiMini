namespace QuanLySieuThiMini
{
    partial class frmDoanhthu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtTongdoanhthu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhsachhoadon = new System.Windows.Forms.DataGridView();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThongke = new System.Windows.Forms.Button();
            this.dtpNgaybatdau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayketthuc = new System.Windows.Forms.DateTimePicker();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachhoadon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.txtTongdoanhthu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(8, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 625);
            this.panel1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(794, 574);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(134, 35);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtTongdoanhthu
            // 
            this.txtTongdoanhthu.BackColor = System.Drawing.Color.White;
            this.txtTongdoanhthu.Location = new System.Drawing.Point(216, 571);
            this.txtTongdoanhthu.Name = "txtTongdoanhthu";
            this.txtTongdoanhthu.ReadOnly = true;
            this.txtTongdoanhthu.Size = new System.Drawing.Size(278, 29);
            this.txtTongdoanhthu.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng doanh thu :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhsachhoadon);
            this.groupBox1.Location = new System.Drawing.Point(14, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(942, 430);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách";
            // 
            // dgvDanhsachhoadon
            // 
            this.dgvDanhsachhoadon.AllowUserToAddRows = false;
            this.dgvDanhsachhoadon.AllowUserToDeleteRows = false;
            this.dgvDanhsachhoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhsachhoadon.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhsachhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENNV,
            this.MAHDX,
            this.NGAYLAP,
            this.TONGTIEN});
            this.dgvDanhsachhoadon.Location = new System.Drawing.Point(15, 37);
            this.dgvDanhsachhoadon.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvDanhsachhoadon.Name = "dgvDanhsachhoadon";
            this.dgvDanhsachhoadon.ReadOnly = true;
            this.dgvDanhsachhoadon.RowHeadersWidth = 51;
            this.dgvDanhsachhoadon.RowTemplate.Height = 24;
            this.dgvDanhsachhoadon.Size = new System.Drawing.Size(916, 379);
            this.dgvDanhsachhoadon.TabIndex = 5;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên nhân viên";
            this.TENNV.MinimumWidth = 6;
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            // 
            // MAHDX
            // 
            this.MAHDX.DataPropertyName = "MAHDX";
            this.MAHDX.HeaderText = "Mã hóa đơn";
            this.MAHDX.MinimumWidth = 6;
            this.MAHDX.Name = "MAHDX";
            this.MAHDX.ReadOnly = true;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày lập";
            this.NGAYLAP.MinimumWidth = 6;
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.ReadOnly = true;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.MinimumWidth = 6;
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnIn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnThongke);
            this.panel2.Controls.Add(this.dtpNgaybatdau);
            this.panel2.Controls.Add(this.dtpNgayketthuc);
            this.panel2.Location = new System.Drawing.Point(14, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 112);
            this.panel2.TabIndex = 4;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(766, 33);
            this.btnIn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(147, 42);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "Báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(605, 33);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(147, 42);
            this.btnThongke.TabIndex = 2;
            this.btnThongke.Text = "Thống Kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // dtpNgaybatdau
            // 
            this.dtpNgaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaybatdau.Location = new System.Drawing.Point(201, 16);
            this.dtpNgaybatdau.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtpNgaybatdau.Name = "dtpNgaybatdau";
            this.dtpNgaybatdau.Size = new System.Drawing.Size(331, 29);
            this.dtpNgaybatdau.TabIndex = 1;
            // 
            // dtpNgayketthuc
            // 
            this.dtpNgayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayketthuc.Location = new System.Drawing.Point(201, 60);
            this.dtpNgayketthuc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtpNgayketthuc.Name = "dtpNgayketthuc";
            this.dtpNgayketthuc.Size = new System.Drawing.Size(331, 29);
            this.dtpNgayketthuc.TabIndex = 0;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmDoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 644);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoanhthu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaocaodoanhthu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachhoadon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhsachhoadon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.DateTimePicker dtpNgaybatdau;
        private System.Windows.Forms.DateTimePicker dtpNgayketthuc;
        private System.Windows.Forms.TextBox txtTongdoanhthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnDong;
    }
}