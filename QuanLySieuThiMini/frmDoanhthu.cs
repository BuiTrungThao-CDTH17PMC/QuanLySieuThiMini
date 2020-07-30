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
    public partial class frmDoanhthu : Form
    {
        BUS.DoanhthuBUS dtb;
        public frmDoanhthu()
        {
            InitializeComponent();
            dtb = new BUS.DoanhthuBUS();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            DataTable dt = dtb.Danhsachhoadonxuat(dtpNgaybatdau.Value.Date.ToString("yyyy/MM/dd"), dtpNgayketthuc.Value.Date.ToString("yyyy/MM/dd"));
            dgvDanhsachhoadon.DataSource = dt;
            txtTongdoanhthu.Text = Tinhtong().ToString();
        }

        public int Tinhtong()
        {
            int index = dgvDanhsachhoadon.RowCount;
            int Tong = 0;
            for (int i = 0; i < index; i++)
            {
                Tong = Tong + Int32.Parse(dgvDanhsachhoadon.Rows[i].Cells["TONGTIEN"].Value.ToString());
            }
            return Tong;
        }
    }
}
