using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace QuanLySieuThiMini
{
    public partial class frmNhanvien : Form
    {
        BUS.NhanvienBUS nvb;
        int ID;

        public frmNhanvien()
        {
            InitializeComponent();
            nvb = new BUS.NhanvienBUS();
        }

        public void Hienthinhanvien ()
        {
            DataTable dt = nvb.Tablenhanvien();
            dgvHienthinhanvien.DataSource = dt;
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            Hienthinhanvien();
            Hienthicbbloainhanvien();
            btnSuanhanvien.Enabled = false;
            btnXoanhanvien.Enabled = false;
        }

        private void txtTimnhanvien_TextChanged(object sender, EventArgs e)
        {
            string value = txtTimnhanvien.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = nvb.Timkiemnhanvien(value);
                dgvHienthinhanvien.DataSource = dt;
            }
            else
                Hienthinhanvien();
        }

        public void Hienthicbbloainhanvien()
        {
            DataTable dt = nvb.Tableloainhanvien();
            cbbLoainhanvien.DataSource = dt;
            cbbLoainhanvien.DisplayMember = "TENLOAI";
            cbbLoainhanvien.ValueMember = "MALOAI";
        }

        public bool Kiemtradulieu()
        {
            if (string.IsNullOrEmpty(txtTennhanvien.Text))
            { 
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtDiachinv.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtSodienthoainv.Text))
            { 
                MessageBox.Show("Bạn chưa nhập số điện thoại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtTentaikhoan.Text))
            { 
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtMatkhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.Compare(txtMatkhau.Text, txtXacnhanmatkhau.Text) != 0)
            {
               MessageBox.Show("Mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return false;
            }
            if(Kiemtraso(txtSodienthoainv.Text)==false)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool Kiemtraso(string text)
        {
            int num = 0;
            if (Int32.TryParse(text, out num))
                return true; 
            else 
                return false;
        }

        private void btnThemnhanvien_Click(object sender, EventArgs e)
        {
            int num = nvb.Kiemtratontai(txtTentaikhoan.Text);
            if (Kiemtradulieu())
            {
                DTO.Nhanvien nv = new DTO.Nhanvien();
                nv.TENNV1 = txtTennhanvien.Text;
                nv.DIACHI1 = txtDiachinv.Text;
                nv.SDT1 = txtSodienthoainv.Text;
                nv.GIOITINH1 = rdbGioitinhnam.Checked?1:0;
                nv.LOAINV1 = Int32.Parse(cbbLoainhanvien.SelectedValue.ToString());
                nv.MATKHAU1 = Mahoa(txtMatkhau.Text);
                nv.TENTK1 = txtTentaikhoan.Text;
                if(nvb.Themnhanvien(nv))
                {
                    Hienthinhanvien();
                }
            }
        }
        
        private void dgvHienthinhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            btnSuanhanvien.Enabled = true;
            btnXoanhanvien.Enabled = true;
            btnThemnhanvien.Enabled = false;
            try 
            {
                if (index >= 0)
                {
                    ID = Int32.Parse(dgvHienthinhanvien.Rows[index].Cells["MANV"].Value.ToString());
                    txtTennhanvien.Text = dgvHienthinhanvien.Rows[index].Cells["TENNV"].Value.ToString();
                    txtDiachinv.Text = dgvHienthinhanvien.Rows[index].Cells["DIACHI"].Value.ToString();
                    txtMatkhau.Text = dgvHienthinhanvien.Rows[index].Cells["MATKHAU"].Value.ToString();
                    txtSodienthoainv.Text = dgvHienthinhanvien.Rows[index].Cells["SDT"].Value.ToString();
                    txtTentaikhoan.Text = dgvHienthinhanvien.Rows[index].Cells["TENTK"].Value.ToString();
                    txtXacnhanmatkhau.Text = dgvHienthinhanvien.Rows[index].Cells["MATKHAU"].Value.ToString();
                    cbbLoainhanvien.SelectedValue = Int32.Parse(dgvHienthinhanvien.Rows[index].Cells["LOAINV"].Value.ToString());
                    bool bit =bool.Parse( dgvHienthinhanvien.Rows[index].Cells["GIOITINH"].Value.ToString());
                    if (bit == true)
                        rdbGioitinhnam.Checked = true;
                    else
                        rdbGioitinhnu.Checked = true;
                }
            }
            catch 
            {
            }
        }

        private void btnSuanhanvien_Click(object sender, EventArgs e)
        {
            if (Kiemtradulieu())
            {
                DTO.Nhanvien nv = new DTO.Nhanvien();
                nv.MANV1 = ID;
                nv.TENNV1 = txtTennhanvien.Text;
                nv.DIACHI1 = txtDiachinv.Text;
                nv.SDT1 = txtSodienthoainv.Text;
                nv.GIOITINH1 = rdbGioitinhnam.Checked?1:0;
                nv.LOAINV1 = Int32.Parse(cbbLoainhanvien.SelectedValue.ToString());
                nv.MATKHAU1 = Mahoa(txtMatkhau.Text);
                nv.TENTK1 = txtTentaikhoan.Text;

                if (nvb.Suanhanvien(nv))
                {
                    Hienthinhanvien();
                }
                ResertControll();
                btnSuanhanvien.Enabled = false;
                btnXoanhanvien.Enabled = false;
                btnThemnhanvien.Enabled = true;
            }
        }

        private void btnDongnhanvien_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ResertControll()
        {
            txtTennhanvien.Text = "";
            txtDiachinv.Text = "";
            txtMatkhau.Text = "";
            txtSodienthoainv.Text = "";
            txtTentaikhoan.Text = "";
            txtXacnhanmatkhau.Text = "";
        }

        private void btnHuythaotacnv_Click(object sender, EventArgs e)
        {
            ResertControll();
            btnThemnhanvien.Enabled = true;
            btnSuanhanvien.Enabled = false;
            btnXoanhanvien.Enabled = false;
        }

        private void btnXoanhanvien_Click(object sender, EventArgs e)
        {

        }

        public string Mahoa(string value)
        {
            MD5 md = MD5.Create();
            byte[] inputbyte = System.Text.Encoding.ASCII.GetBytes(value);
            byte[] mahoa = md.ComputeHash(inputbyte);
            StringBuilder bd = new StringBuilder();
            for (int i = 0; i < mahoa.Length; i++)
            {
                bd.Append(mahoa[i].ToString("X2"));
            }
            return bd.ToString();
        }
    }
}
