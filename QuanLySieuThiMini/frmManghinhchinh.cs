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
    public partial class frmManghinhchinh : Form
    {
        public frmManghinhchinh()
        {
            InitializeComponent();
        }

        private void frmManghinhchinh_Load(object sender, EventArgs e)
        {
            frmBanhang frmbh = new frmBanhang();
            frmbh.ShowDialog();
        }
        private void TSMI_Sanpham_Click(object sender, EventArgs e)
        {
            frmSanpham frmsp = new frmSanpham();
            frmsp.ShowDialog();
        }

        private void TSMI_Khachhang_Click(object sender, EventArgs e)
        {
            frmKhachhang kh = new frmKhachhang();
            kh.ShowDialog();
        }

        private void TSMI_Loaisanpham_Click(object sender, EventArgs e)
        {
            frmLoaisanpham lsp = new frmLoaisanpham();
            lsp.ShowDialog();
        }

        private void TSMI_Nhacungcap_Click(object sender, EventArgs e)
        {
            frmNhacungcap ncc = new frmNhacungcap();
            ncc.ShowDialog();
        }

        private void TSMI_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangnhap dn = new frmDangnhap();
            dn.Close();
        }

        private void TSMI_Hoadonbanhang_Click(object sender, EventArgs e)
        {
            frmHienthihoadonban hdbh = new frmHienthihoadonban();
            hdbh.ShowDialog();
        }

        private void TSMI_Loainhanvien_Click(object sender, EventArgs e)
        {
            frmLoainhanvien lnv = new frmLoainhanvien();
            lnv.Show();
        }

        private void TSMI_Nhanvien_Click_1(object sender, EventArgs e)
        {
            frmNhanvien frmnv = new frmNhanvien();
            frmnv.ShowDialog();
        }
    }
}
