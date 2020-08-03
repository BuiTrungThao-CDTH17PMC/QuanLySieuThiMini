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
    public partial class frmLoaisanpham : Form
    {
        BUS.LoaisanphamBUS lspb;
        int ID;

        public frmLoaisanpham()
        {
            InitializeComponent();
            lspb = new BUS.LoaisanphamBUS();
        }
        public void Hienthiloaisanpham()
        {
            DataTable dt = lspb.Tableloaisanpham();
            dgvLoaisanpham.DataSource = dt;
        }
        private void frmLoaisanpham_Load(object sender, EventArgs e)
        {
            Hienthiloaisanpham();
            btnSualoaisp.Enabled = false;
            btnXoaloaisp.Enabled = false;
        }
        public bool Kiemtradulieu()
        {
            if (string.IsNullOrEmpty(txtTenloaisp.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnThemloaisp_Click(object sender, EventArgs e)
        {
            if(Kiemtradulieu())
            {
                DTO.Loaisanpham lsp = new DTO.Loaisanpham();
                lsp.TENLOAI1 = txtTenloaisp.Text;

                if (lspb.Themloaisanpham(lsp))
                    Hienthiloaisanpham();
                txtTenloaisp.Text = "";
            }
        }

        private void btnSualoaisp_Click(object sender, EventArgs e)
        {
            if (Kiemtradulieu())
            {
                DTO.Loaisanpham lsp = new DTO.Loaisanpham();
                lsp.MALOAI1 = ID;
                lsp.TENLOAI1 = txtTenloaisp.Text;

                if (lspb.Sualoaisanpham(lsp))
                    Hienthiloaisanpham();
                btnThemloaisp.Enabled = true;
                btnSualoaisp.Enabled = false;
                btnXoaloaisp.Enabled = false;
                txtTenloaisp.Text = "";
            }
        }

        private void btnHuythaotacloaisp_Click(object sender, EventArgs e)
        {
            btnThemloaisp.Enabled = true;
            btnSualoaisp.Enabled = false;
            btnXoaloaisp.Enabled = false;
            txtTenloaisp.Text = "";
        }

        private void btnDongloaisp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaloaisp_Click(object sender, EventArgs e)
        {
            if (Kiemtradulieu())
            {
                DTO.Loaisanpham lsp = new DTO.Loaisanpham();
                lsp.MALOAI1 = ID;
                if (lspb.Xoaloaisanpham(lsp))
                    Hienthiloaisanpham();
                btnThemloaisp.Enabled = true;
                btnSualoaisp.Enabled = false;
                btnXoaloaisp.Enabled = false;
                txtTenloaisp.Text = "";
            }
        }

        private void dgvLoaisanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = Int32.Parse(dgvLoaisanpham.Rows[index].Cells["MALOAISP"].Value.ToString());
                txtTenloaisp.Text = dgvLoaisanpham.Rows[index].Cells["TENLOAI"].Value.ToString();
                btnSualoaisp.Enabled = true;
                btnXoaloaisp.Enabled = true;
                btnThemloaisp.Enabled = false;
                
            }
        }
    }
}
