﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLySieuThiMini
{
    public partial class frmSanpham : Form
    {
        BUS.SanphamBUS spb;
        OpenFileDialog open;
        int ID;
        string duongdan;

        public frmSanpham()
        {
            InitializeComponent();
            spb = new BUS.SanphamBUS();
        }

        public void Hienthisanpham()
        {
            DataTable dt = spb.Tablesanpham();
            dgvHienthisanpham.DataSource = dt;
            dgvHienthisanpham.Columns["GIAMGIA"].DefaultCellStyle.Format = "N";
            dgvHienthisanpham.Columns["DONGIA"].DefaultCellStyle.Format = "N";
        }

        public void Hienloaisanpham()
        {
            DataTable dt = spb.Tableloaisanpham();
            cbbLoaisanpham.DataSource = dt;
            cbbLoaisanpham.ValueMember = "MALOAI";
            cbbLoaisanpham.DisplayMember = "TENLOAI";
        }

        public void Hiennhacungcap()
        {
            DataTable dt = spb.Tablenhacungcap();
            cbbNhacungcap.DataSource = dt;
            cbbNhacungcap.ValueMember = "MANCC";
            cbbNhacungcap.DisplayMember = "TENNCC";
        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            Hienthisanpham();
            Hienloaisanpham();
            Hiennhacungcap();
            btnSuasp.Enabled = false;
            btnXoasanpham.Enabled = false;
        }

        //public bool Kiemtraso(string text)
        //{
        //    int num = 0;
        //    if (Int32.TryParse(text, out num))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool Kiemtraduulieu()
        {
            if (String.IsNullOrEmpty(txtTensanpham.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            if (String.IsNullOrEmpty(txtSoluong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            if (String.IsNullOrEmpty(txtDongia.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            //if (Kiemtraso(txtSoluong.Text) == false)
            //{
            //    MessageBox.Show("Vui lòng nhập số không nhập ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //    return false;
            //}
            //if (Kiemtraso(Chuyen(txtDongia).ToString()) == false)
            //{
            //    MessageBox.Show("Vui lòng nhập số không nhập ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //    return false;
            //}
            if (String.IsNullOrEmpty(txtTenanh.Text))
            {
                MessageBox.Show("Bạn chưa chọn ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            return true;
        }

        private void btnThemmoisp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Kiemtraduulieu())
                {
                    DTO.Sanpham sp = new DTO.Sanpham();
                    sp.TENSP1 = txtTensanpham.Text;
                    sp.SOLUONG1 = Int32.Parse(txtSoluong.Text);
                    sp.DONGIA1 = Int32.Parse(txtDongia.Text);
                    sp.MALOAI1 = Int32.Parse(cbbLoaisanpham.SelectedValue.ToString());
                    sp.MANCC1 = Int32.Parse(cbbNhacungcap.SelectedValue.ToString());
                    sp.GIAMGIA1 = Int32.Parse(txtGiamgia.Text);
                    sp.HINHANH1 = txtTenanh.Text;
                    if (spb.Themsanpham(sp))
                    {
                        Hienthisanpham();
                        ResertCotroll();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuasp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Kiemtraduulieu())
                {
                    DTO.Sanpham sp = new DTO.Sanpham();
                    sp.MASP1 = ID;
                    sp.TENSP1 = txtTensanpham.Text;
                    sp.SOLUONG1 = Int32.Parse(txtSoluong.Text);
                    sp.DONGIA1 = Chuyen(txtDongia);
                    sp.MALOAI1 = Int32.Parse(cbbLoaisanpham.SelectedValue.ToString());
                    sp.MANCC1 = Int32.Parse(cbbNhacungcap.SelectedValue.ToString());
                    sp.GIAMGIA1 = Chuyen(txtGiamgia);
                    sp.HINHANH1 = txtTenanh.Text;
                    Luuanh();
                    if (spb.Suasanpham(sp))
                    {
                        Hienthisanpham();
                        btnThemmoisp.Enabled = true;
                        btnSuasp.Enabled = false;
                        btnXoasanpham.Enabled = false;
                        txtSoluong.Enabled = true;
                        ResertCotroll();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public int Chuyen(TextBox text)
        {
            var te = text.Text;
            var clear = te.Replace(",", "");
            return Int32.Parse(clear);
        }

        private void dgvHienthisanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var s = Path.Combine("..\\..\\Resources\\Images\\");
            s = Path.GetFullPath(s);
            int index = e.RowIndex;
            try 
            {
                if (index >= 0)
                {
                    ID = Int32.Parse(dgvHienthisanpham.Rows[index].Cells["MASP"].Value.ToString());
                    txtTensanpham.Text = dgvHienthisanpham.Rows[index].Cells["TENSP"].Value.ToString();
                    txtSoluong.Text = dgvHienthisanpham.Rows[index].Cells["SOLUONG"].Value.ToString();
                    txtDongia.Text = string.Format("{0:n0}",decimal.Parse( dgvHienthisanpham.Rows[index].Cells["DONGIA"].Value.ToString()));
                    cbbLoaisanpham.SelectedValue = Int32.Parse(dgvHienthisanpham.Rows[index].Cells["MALOAI"].Value.ToString());
                    cbbNhacungcap.SelectedValue = Int32.Parse(dgvHienthisanpham.Rows[index].Cells["MANCC"].Value.ToString());
                    txtGiamgia.Text = string.Format("{0:n0}",decimal.Parse( dgvHienthisanpham.Rows[index].Cells["GIAMGIA"].Value.ToString()));
                    txtTenanh.Text = dgvHienthisanpham.Rows[index].Cells["HINHANH"].Value.ToString();
                    Image image = Image.FromFile(s + dgvHienthisanpham.Rows[index].Cells["HINHANH"].Value.ToString());
                    ptbAnhsanpham.Image = image;
                    btnSuasp.Enabled = true;
                    btnXoasanpham.Enabled = true;
                    btnThemmoisp.Enabled = false;
                    txtSoluong.Enabled = false;
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtTimsanpham_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string value = txtTimsanpham.Text;
                if (!String.IsNullOrEmpty(value))
                {
                    DataTable dt = spb.Timkiemsanpham(value);
                    dgvHienthisanpham.DataSource = dt;
                }
                else
                {
                    Hienthisanpham();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDongsp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ResertCotroll()
        {
            txtDongia.Text = "";
            txtSoluong.Text = "";
            txtTensanpham.Text = "";
            txtGiamgia.Text = "";
            txtTenanh.Text = "";
        }

        private void btnHuythaotacsp_Click(object sender, EventArgs e)
        {
            ResertCotroll();
            btnSuasp.Enabled = false;
            btnXoasanpham.Enabled = false;
            btnThemmoisp.Enabled =true;
            txtSoluong.Enabled = true;
        }

        private void btnXoasanpham_Click(object sender, EventArgs e)
        {          
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DTO.Sanpham sp = new DTO.Sanpham();
                sp.MASP1 = ID;
                if (spb.Xoasanpham(sp))
                {
                    Hienthisanpham();
                }
                btnThemmoisp.Enabled = true;
                btnSuasp.Enabled = false;
                btnXoasanpham.Enabled = false;
                txtSoluong.Enabled = true;
                ResertCotroll();
                MessageBox.Show("Xóa sản phẩm thành công", "thông báo", MessageBoxButtons.OK);
            }
            else
            {
                this.Activate();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "Images(*.jpg)|*.jpg|PNG (*.png)|*.png|All files (*.*)|*.*";
            if(open.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(open.FileName);
                ptbAnhsanpham.Image = img;
                duongdan = open.FileName;
                txtTenanh.Text = Path.GetFileName(duongdan);
            }
        }

        public void Luuanh()
        {
            try
            {
                var s = Path.Combine("..\\..\\Resources\\Images\\");
                s = Path.GetFullPath(s);
                File.Copy(duongdan, Path.Combine(s, Path.GetFileName(txtTenanh.Text)), true);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHienthisanpham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvHienthisanpham.Columns[e.ColumnIndex].Name == "HINHANH")
                {
                    var s = Path.Combine("..\\..\\Resources\\Images\\");
                    s = Path.GetFullPath(s);
                    e.Value = Bitmap.FromFile(s + e.Value.ToString());
                    e.FormattingApplied = true;
                }
            }
            catch { }
        }

        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtDongia.Text = string.Format("{0:n0}", decimal.Parse(txtDongia.Text));
                txtDongia.SelectionStart = txtDongia.Text.Length;
            }
            catch { }
            
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtGiamgia.Text = string.Format("{0:n0}", decimal.Parse(txtGiamgia.Text));
                txtGiamgia.SelectionStart = txtGiamgia.Text.Length;
            }
            catch { }
            
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
