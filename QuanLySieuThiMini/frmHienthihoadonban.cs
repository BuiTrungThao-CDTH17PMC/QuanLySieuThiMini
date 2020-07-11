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
    public partial class frmHienthihoadonban : Form
    {
        BUS.HoadonbanBUS hdxb;
        public frmHienthihoadonban()
        {
            InitializeComponent();
            hdxb = new BUS.HoadonbanBUS();
        }
        public void Hienhoadonxuat()
        {
            DataTable dt = hdxb.Tablehoadonxuat();
            dgvDanhsachhoadonban.DataSource = dt;
        }
        private void frmHienthihoadonban_Load(object sender, EventArgs e)
        {
            Hienhoadonxuat();
        }
        int ID;
        private void dgvDanhsachhoadonban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >=0)
            {
                ID = Int32.Parse(dgvDanhsachhoadonban.Rows[index].Cells["MAHDX"].Value.ToString());
                DataTable dt = hdxb.Tablechitiethoadonxuat(ID);
                dgvChitiethoadonban.DataSource = dt;
            }
        }
    }
}
