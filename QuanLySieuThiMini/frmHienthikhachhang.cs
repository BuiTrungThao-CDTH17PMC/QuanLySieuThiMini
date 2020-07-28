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
    public partial class frmHienthikhachhang : Form
    {
        BUS.KhachhangBUS khb;

        public delegate void truyendulieu(string tkh,string mkh);
        public truyendulieu truyen;

        public frmHienthikhachhang()
        {
            InitializeComponent();
            khb = new BUS.KhachhangBUS();
        }
        public void Hienthikhachhang()
        {
            DataTable dt = khb.Tablekhachhang();
            dgvChonkhachhang.DataSource = dt;
        }
        private void frmHienthikhachhang_Load(object sender, EventArgs e)
        {
            Hienthikhachhang();
        }

        private void txtTimkiemkhachhang_TextChanged(object sender, EventArgs e)
        {
            string value = txtTimkiemkhachhang.Text;
            if(!String.IsNullOrEmpty(value))
            {
                DataTable dt = khb.Timkiemkhachhang(value);
                dgvChonkhachhang.DataSource = dt;
            }
        }

        private void dgvChonkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                string mkh = dgvChonkhachhang.Rows[index].Cells["MAKH"].Value.ToString();
                string tkh = dgvChonkhachhang.Rows[index].Cells["TENKH"].Value.ToString();

                truyen(tkh,mkh);

                this.Close();
            }
            
        }
    }
}
