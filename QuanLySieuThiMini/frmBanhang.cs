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
    public partial class frmBanhang : Form
    {
        public frmBanhang()
        {
            InitializeComponent();
        }

        private void btnChonkhachhang_Click(object sender, EventArgs e)
        {
            frmHienthikhachhang htkh = new frmHienthikhachhang();
            htkh.ShowDialog();
        }
    }
}
