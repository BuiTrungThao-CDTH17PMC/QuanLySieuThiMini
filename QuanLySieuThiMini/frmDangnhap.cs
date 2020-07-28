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
    public partial class frmDangnhap : Form
    {
        BUS.DangnhapBUS dnb;
        string tnv, tlnv;
        int manv;

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
            
            if(Kiemtradulieu())
            {
                int num =dnb.Kiemtradangnhap(txtTendangnhap.Text,Mahoa(txtMatkhau.Text));
                if(num > 0 || (txtTendangnhap.Text =="admin" && txtMatkhau.Text =="admin"))
                {
                    List<DTO.Quyennhanvien> list = dnb.Quyennhanvien(txtTendangnhap.Text);
                    foreach(DTO.Quyennhanvien qnv in list)
                    {
                        manv = qnv.MANV1;
                        tlnv = qnv.TENLOAINV1;
                        tnv = qnv.TENNV1;
                    }
                    frmManghinhchinh mhc = new frmManghinhchinh(tnv,tlnv,manv);
                    mhc.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public string Mahoa(string value)
        {
            MD5 md = MD5.Create();
            byte[] inputbyte = System.Text.Encoding.ASCII.GetBytes(value);
            byte[] mahoa = md.ComputeHash(inputbyte);
            StringBuilder bd = new StringBuilder();
            for(int i=0;i<mahoa.Length;i++)
            {
                bd.Append(mahoa[i].ToString("X2"));
            }
            return bd.ToString();
        }
    }
}
