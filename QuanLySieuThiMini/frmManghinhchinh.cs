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
        string tennv,tenlnv;
        int mnv;

        public frmManghinhchinh()
        {
            InitializeComponent();
            
        }

        public frmManghinhchinh( string tnv,string tlnv,int manv):this()
        {
            tennv = tnv;
            mnv = manv;
            tenlnv = tlnv;
        }

        private void frmManghinhchinh_Load(object sender, EventArgs e)
        {
            if(tenlnv != "Nhân viên trưởng")
            {
                TSMI_Quanlynhanvien.Enabled = false;
                TSMI_Quanlysanpham.Enabled = false;
                TSMI_Baocaobanhang.Enabled = false;
            }
            
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

        private void TSMI_Loainhanvien_Click(object sender, EventArgs e)
        {
            frmLoainhanvien lnv = new frmLoainhanvien();
            lnv.ShowDialog();
        }

        private void TSMI_Nhanvien_Click_1(object sender, EventArgs e)
        {
            frmNhanvien frmnv = new frmNhanvien();
            frmnv.ShowDialog();
        }

        private void TSMI_Danhsachhoadonban_Click(object sender, EventArgs e)
        {
            frmHienthihoadonban hdb = new frmHienthihoadonban();
            hdb.ShowDialog();
        }

        private void TSMI_Banhang_Click(object sender, EventArgs e)
        {
            frmBanhang bh = new frmBanhang(tennv,mnv);
            bh.ShowDialog();
        }

        private void TSMI_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMI_Baocaobanhang_Click(object sender, EventArgs e)
        {
            frmDoanhthu dt = new frmDoanhthu();
            dt.ShowDialog();
        }

        private void TSMI_Dangxuat_Click(object sender, EventArgs e)
        {
           
            //this.Close();
            //frmDangnhap dn = new frmDangnhap();
            //dn.ShowDialog();
        }
    }
}
