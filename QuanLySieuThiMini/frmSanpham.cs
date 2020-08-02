using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThiMini
{
    public partial class frmSanpham : Form
    {
        BUS.SanphamBUS spb;
        public frmSanpham()
        {
            InitializeComponent();
            spb = new BUS.SanphamBUS();
        }
        public void Hienthisanpham()
        {
            DataTable dt = spb.Tablesanpham();
            dgvHienthisanpham.DataSource = dt;
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
        public bool Kiemtraso(string text)
        {
            int num = 0;
            if(Int32.TryParse(text,out num))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public bool Kiemtraduulieu()
        {
            if(String.IsNullOrEmpty(txtTensanpham.Text))
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
            if(Kiemtraso(txtSoluong.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập số không nhập ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            if (Kiemtraso(txtDongia.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập số không nhập ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            return true;
        }
        private void btnThemmoisp_Click(object sender, EventArgs e)
        {
            if(Kiemtraduulieu())
            {
                DTO.Sanpham sp = new DTO.Sanpham();
                sp.TENSP1 = txtTensanpham.Text;
                sp.SOLUONG1 = Int32.Parse(txtSoluong.Text);
                sp.DONGIA1 = Int32.Parse(txtDongia.Text);
                sp.MALOAI1 = Int32.Parse(cbbLoaisanpham.SelectedValue.ToString());
                sp.MANCC1 = Int32.Parse(cbbNhacungcap.SelectedValue.ToString());
                if(spb.Themsanpham(sp))
                {
                    Hienthisanpham();
                }
            }
        }
        int ID;
        private void btnSuasp_Click(object sender, EventArgs e)
        {
            if (Kiemtraduulieu())
            {
                DTO.Sanpham sp = new DTO.Sanpham();
                sp.MASP1 = ID;
                sp.TENSP1 = txtTensanpham.Text;
                sp.SOLUONG1 = Int32.Parse(txtSoluong.Text);
                sp.DONGIA1 = Int32.Parse(txtDongia.Text);
                sp.MALOAI1 = Int32.Parse(cbbLoaisanpham.SelectedValue.ToString());
                sp.MANCC1 = Int32.Parse(cbbNhacungcap.SelectedValue.ToString());
                if (spb.Suasanpham(sp))
                {
                    Hienthisanpham();
                }
                btnThemmoisp.Enabled = true;
                btnSuasp.Enabled = false;
                btnXoasanpham.Enabled = false;
            }
        }
        private void dgvHienthisanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            try 
            {
                if (index >= 0)
                {
                    ID = Int32.Parse(dgvHienthisanpham.Rows[index].Cells["MASP"].Value.ToString());
                    txtTensanpham.Text = dgvHienthisanpham.Rows[index].Cells["TENSP"].Value.ToString();
                    txtSoluong.Text = dgvHienthisanpham.Rows[index].Cells["SOLUONG"].Value.ToString();
                    txtDongia.Text = dgvHienthisanpham.Rows[index].Cells["DONGIA"].Value.ToString();
                    cbbLoaisanpham.SelectedValue = Int32.Parse(dgvHienthisanpham.Rows[index].Cells["MALOAI"].Value.ToString());
                    cbbNhacungcap.SelectedValue = Int32.Parse(dgvHienthisanpham.Rows[index].Cells["MANCC"].Value.ToString());
                    btnSuasp.Enabled = true;
                    btnXoasanpham.Enabled = true;
                    btnThemmoisp.Enabled = false;
                }
            }
            catch { }
        }
        private void txtTimsanpham_TextChanged(object sender, EventArgs e)
        {
            string value = txtTimsanpham.Text;
            if(!String.IsNullOrEmpty(value))
            {
                DataTable dt = spb.Timkiemsanpham(value);
                dgvHienthisanpham.DataSource = dt;
            }
            else
            {
                Hienthisanpham();
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
        }
        private void btnHuythaotacsp_Click(object sender, EventArgs e)
        {
            ResertCotroll();
            btnSuasp.Enabled = false;
            btnXoasanpham.Enabled = false;
            btnThemmoisp.Enabled =true;
        }

        private void btnXoasanpham_Click(object sender, EventArgs e)
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
        }
    }
}
