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
    public partial class frmKhachhang : Form
    {
        BUS.KhachhangBUS khb;
        public frmKhachhang()
        {
            InitializeComponent();
            khb = new BUS.KhachhangBUS();
        }
        public void Hienthikhachhang()
        {
            DataTable dt = khb.Tablekhachhang();
            dgvHienthikhachhang.DataSource = dt;
        }
        public bool Kiemtradulieu()
        {
            if(String.IsNullOrEmpty(txtTenkhachhang.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(txtDiachikh.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chi khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(txtSodienthoaikh.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(txtSodiemtich.Text))
            {
                MessageBox.Show("Bạn chưa điểm tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(Kiemtraso(txtSodienthoaikh.Text)==false)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }
        public bool Kiemtraso(string text)
        {
            int num = 0;
            if(Int32.TryParse(text,out num))
            {
                return true;
            }
            return false;
        }
        private void btnThemkh_Click(object sender, EventArgs e)
        {
            if(Kiemtradulieu())
            {
                DTO.Khachhang kh = new DTO.Khachhang();
                kh.TENKH1 = txtTenkhachhang.Text;
                kh.DIACHI1 = txtDiachikh.Text;
                kh.TICHDIEM1 = Int32.Parse(txtSodiemtich.Text);
                kh.SDT1 = txtSodienthoaikh.Text;
                if(khb.Themkhachhang(kh))
                {
                    Hienthikhachhang();
                }
            }
        }
        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            Hienthikhachhang();
            btnSuakh.Enabled = false;
            btnXoakh.Enabled = false;
        }
        int ID;
        private void dgvHienthikhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            btnSuakh.Enabled = true;
            btnXoakh.Enabled = true;
            btnThemkh.Enabled = false;
            try 
            {
                if (index >= 0)
                {
                    ID = Int32.Parse(dgvHienthikhachhang.Rows[index].Cells["MAKH"].Value.ToString());
                    txtTenkhachhang.Text = dgvHienthikhachhang.Rows[index].Cells["TENKH"].Value.ToString();
                    txtDiachikh.Text = dgvHienthikhachhang.Rows[index].Cells["DIACHI"].Value.ToString();
                    txtSodienthoaikh.Text = dgvHienthikhachhang.Rows[index].Cells["SDT"].Value.ToString();
                    txtSodiemtich.Text = dgvHienthikhachhang.Rows[index].Cells["TICHDIEM"].Value.ToString();
                }
            }
            catch { }
        }
        private void btnSuakh_Click(object sender, EventArgs e)
        {
            if (Kiemtradulieu())
            {
                DTO.Khachhang kh = new DTO.Khachhang();
                kh.MAKH1 = ID;
                kh.TENKH1 = txtTenkhachhang.Text;
                kh.DIACHI1 = txtDiachikh.Text;
                kh.TICHDIEM1 = Int32.Parse(txtSodiemtich.Text);
                kh.SDT1 = txtSodienthoaikh.Text;
                if (khb.Suakhachhang(kh))
                {
                    Hienthikhachhang();
                }
                btnThemkh.Enabled = true;
                btnSuakh.Enabled = false;
                btnXoakh.Enabled = false;
                ResertControll();
            }
        }
        public void ResertControll()
        {
            txtTenkhachhang.Text = "";
            txtSodienthoaikh.Text = "";
            txtDiachikh.Text = "";
        }
        private void btnHuythaotac_Click(object sender, EventArgs e)
        {
            ResertControll();
            btnThemkh.Enabled = true;
            btnSuakh.Enabled = false;
            btnXoakh.Enabled = false;
        }
        private void btnDongkh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtTimkiemkh_TextChanged(object sender, EventArgs e)
        {
            string tkh = txtTimkiemkh.Text;
            if(!String.IsNullOrEmpty(txtTimkiemkh.Text))
            {
                DataTable dt = khb.Timkiemkhachhang(tkh);
                dgvHienthikhachhang.DataSource = dt;
            }
            else
            {
                Hienthikhachhang();
            }
        }
        private void btnXoakh_Click(object sender, EventArgs e)
        {
            if (Kiemtradulieu())
            {
                DTO.Khachhang kh = new DTO.Khachhang();
                kh.MAKH1 = ID;
                if (khb.Xoakhachhang(kh))
                {
                    Hienthikhachhang();
                }
                btnThemkh.Enabled = true;
                btnSuakh.Enabled = false;
                btnXoakh.Enabled = false;
                ResertControll();
            }
        }

    }
}
