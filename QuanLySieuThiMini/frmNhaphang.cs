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
    public partial class frmNhaphang : Form
    {
        BUS.NhaphangBUS nhb;
        int IDSP;

        public frmNhaphang()
        {
            InitializeComponent();
            nhb = new BUS.NhaphangBUS();
        }

        public void LoadDGV()
        {
            DataTable dt = nhb.Danhsachsanpham();
            dgv_Danhsachsanpham.DataSource = dt;
        }

        private void frmNhaphang_Load(object sender, EventArgs e)
        {
            LoadDGV();
            btn_Themsoluong.Enabled = false;
        }

        private void dgv_Danhsachsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 )
            {
                IDSP = Int32.Parse(dgv_Danhsachsanpham.Rows[e.RowIndex].Cells["MASP"].Value.ToString());
                txt_Tensanpham.Text = dgv_Danhsachsanpham.Rows[e.RowIndex].Cells["TENSP"].Value.ToString();
                txt_Loaisanpham.Text = dgv_Danhsachsanpham.Rows[e.RowIndex].Cells["LOAISP"].Value.ToString();
                txt_Nhacungcap.Text = dgv_Danhsachsanpham.Rows[e.RowIndex].Cells["TENNCC"].Value.ToString();
                txt_Loaisanpham.Enabled = false;
                txt_Nhacungcap.Enabled = false;
                txt_Tensanpham.Enabled = false;
                btn_Themsoluong.Enabled = true;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Themsoluong_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Soluong.Text) == false)
            {
                if (nhb.Capnhatsoluong(Int32.Parse(txt_Soluong.Text), IDSP))
                {
                    LoadDGV();
                    txt_Loaisanpham.Clear();
                    txt_Nhacungcap.Clear();
                    txt_Soluong.Clear();
                    txt_Tensanpham.Clear();
                    btn_Themsoluong.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập số lượng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_formSanpham_Click(object sender, EventArgs e)
        {
            frmSanpham sp = new frmSanpham();
            sp.ShowDialog();
        }

        private void txt_Soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
