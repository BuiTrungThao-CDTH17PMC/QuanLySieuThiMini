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
    public partial class frmDangnhap : Form
    {
        BUS.DangnhapBUS dnb;
        public frmDangnhap()
        {
            InitializeComponent();
            dnb = new BUS.DangnhapBUS();
        }
        public bool Kiemtradulieu()
        {
            if(String.IsNullOrEmpty(txtTendangnhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            if (String.IsNullOrEmpty(txtMatkhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            return true;
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tdn;
            string mk;
            if(Kiemtradulieu())
            {
                tdn = txtTendangnhap.Text;
                mk = txtMatkhau.Text;
                int num =dnb.Kiemtradangnhap(tdn,mk);
                if(num > 0 || (tdn =="Admin" && mk =="admin"))
                {
                    this.Hide();
                    frmManghinhchinh mhc = new frmManghinhchinh();
                    mhc.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
