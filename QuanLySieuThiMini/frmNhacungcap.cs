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
    public partial class frmNhacungcap : Form
    {
        BUS.NhacungcapBUS nccb;

        public frmNhacungcap()
        {
            InitializeComponent();
            nccb = new BUS.NhacungcapBUS();
        }
        public void Hienthinhacungcap()
        {
            DataTable dt = nccb.Tablenhacungcap();
            dgvNhacungcap.DataSource = dt;
        }
        private void txtTimnhacungcap_TextChanged(object sender, EventArgs e)
        {
            string value = txtTimnhacungcap.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = nccb.Timkiemnhacungcap(value);
                dgvNhacungcap.DataSource = dt;
            }
            else
                Hienthinhacungcap();
        }
        public bool Kiemtradulieu()
        {
            if (string.IsNullOrEmpty(txtTennhacungcap.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtDcnhacungcap.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ nha cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtSdtnhacungcap.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại nha cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //if (Kiemtraso(txtSdtnhacungcap.Text)==false)
            //{
            //    MessageBox.Show("Vui lòng nhập số điện thoại nha cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}
            return true;
        }

        //private bool Kiemtraso(string text)
        //{
        //    int num = 0;
        //    if (Int32.TryParse(text, out num))
        //        return true;
        //    else
        //        return false;
        //}

        private void btnThemnhacungcap_Click(object sender, EventArgs e)
        {
            if (Kiemtradulieu())
            {
                DTO.Nhacungcap ncc = new DTO.Nhacungcap();
                ncc.TENNCC1 = txtTennhacungcap.Text;
                ncc.DIACHI1 = txtDcnhacungcap.Text;
                ncc.SDT1 = txtSdtnhacungcap.Text;
               
                if (nccb.Themnhacungcap(ncc))
                {
                    Hienthinhacungcap();
                }
            }
        }
        int ID;
        private void btnSuanhacungcap_Click(object sender, EventArgs e)
        {
            if (Kiemtradulieu())
            {
                DTO.Nhacungcap ncc = new DTO.Nhacungcap();
                ncc.MANCC1 = ID;
                ncc.TENNCC1 = txtTennhacungcap.Text;
                ncc.DIACHI1 = txtDcnhacungcap.Text;
                ncc.SDT1 = txtSdtnhacungcap.Text;

                if (nccb.Suanhacungcap(ncc))
                {
                    Hienthinhacungcap();
                }
                ResertControll();
                btnSuanhacungcap.Enabled = false;
                btnXoanhacungcap.Enabled = false;
                btnThemnhacungcap.Enabled = true;
            }
        }

        private void btnDongnhacungcap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ResertControll()
        {
            txtTennhacungcap.Text = "";
            txtDcnhacungcap.Text = "";
            txtSdtnhacungcap.Text = "";
        }

        private void btnHuynhacungcap_Click(object sender, EventArgs e)
        {
            ResertControll();
            btnSuanhacungcap.Enabled = false;
            btnXoanhacungcap.Enabled = false;
            btnThemnhacungcap.Enabled = true;
        }

        private void frmNhacungcap_Load(object sender, EventArgs e)
        {
            Hienthinhacungcap();
            btnSuanhacungcap.Enabled = false;
            btnXoanhacungcap.Enabled = false;

        }

        private void dgvNhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            btnThemnhacungcap.Enabled = false;
            try
            {
                if (index >= 0)
                {
                    ID = Int32.Parse(dgvNhacungcap.Rows[index].Cells["MANCC"].Value.ToString());
                    txtTennhacungcap.Text = dgvNhacungcap.Rows[index].Cells["TENNCC"].Value.ToString();
                    txtDcnhacungcap.Text = dgvNhacungcap.Rows[index].Cells["DIACHI"].Value.ToString();
                    txtSdtnhacungcap.Text = dgvNhacungcap.Rows[index].Cells["SDT"].Value.ToString();
                    btnSuanhacungcap.Enabled = true;
                    btnXoanhacungcap.Enabled = true;
                    btnThemnhacungcap.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void btnXoanhacungcap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhà cung cấp này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DTO.Nhacungcap ncc = new DTO.Nhacungcap();
                ncc.MANCC1 = ID;
                if (nccb.Xoanhacungcap(ncc))
                {
                    Hienthinhacungcap();
                }
                ResertControll();
                btnSuanhacungcap.Enabled = false;
                btnXoanhacungcap.Enabled = false;
                btnThemnhacungcap.Enabled = true;
                MessageBox.Show("Xóa nhân viên thành công", "thông báo", MessageBoxButtons.OK);
            }
            else
            {
                this.Activate();
            }
        }

        private void txtSdtnhacungcap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
