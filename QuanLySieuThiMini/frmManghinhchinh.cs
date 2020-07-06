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

        private void TSMI_Nhanvien_Click(object sender, EventArgs e)
        {
            frmNhanvien frmnv = new frmNhanvien();
            frmnv.ShowDialog();
        }

        private void TSMI_Sanpham_Click(object sender, EventArgs e)
        {
            frmSanpham frmsp = new frmSanpham();
            frmsp.ShowDialog();
        }

        private void TSMI_Sanpham_Click_1(object sender, EventArgs e)
        {
            frmSanpham frmsp = new frmSanpham();
            frmsp.ShowDialog();
        }
    }
}
