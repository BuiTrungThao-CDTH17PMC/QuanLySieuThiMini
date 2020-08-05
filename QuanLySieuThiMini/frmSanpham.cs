using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLySieuThiMini
{
    public partial class frmSanpham : Form
    {
        BUS.SanphamBUS spb;
        OpenFileDialog open;
        int ID;
        string duongdan;

        public frmSanpham()
        {
            InitializeComponent();
            spb = new BUS.SanphamBUS();
        }

        public void Hienthisanpham()
        {
            DataTable dt = spb.Tablesanpham();
            dgvHienthisanpham.DataSource = dt;
        }

        public void Hienloaisanpham()
        {
            DataTable dt = spb.Tableloaisanpham();
            cbbLoaisanpham.DataSource = dt;
            cbbLoaisanpham.ValueMember = "MALOAI";
            cbbLoaisanpham.DisplayMember = "TENLOAI";
        }

        public void Hiennhacungcap()
        {
            DataTable dt = spb.Tablenhacungcap();
            cbbNhacungcap.DataSource = dt;
            cbbNhacungcap.ValueMember = "MANCC";
            cbbNhacungcap.DisplayMember = "TENNCC";
        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            Hienthisanpham();
            Hienloaisanpham();
            Hiennhacungcap();
            btnSuasp.Enabled = false;
            btnXoasanpham.Enabled = false;
        }

        public bool Kiemtraso(string text)
        {
            int num = 0;
            if (Int32.TryParse(text, out num))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Kiemtraduulieu()
        {
            if (String.IsNullOrEmpty(txtTensanpham.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            if (String.IsNullOrEmpty(txtSoluong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            if (String.IsNullOrEmpty(txtDongia.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            if (Kiemtraso(txtSoluong.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập số không nhập ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            if (Kiemtraso(txtDongia.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập số không nhập ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            if (String.IsNullOrEmpty(txtTenanh.Text))
            {
                MessageBox.Show("Bạn chưa chọn ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            return true;
        }

        private void btnThemmoisp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Kiemtraduulieu())
                {
                    DTO.Sanpham sp = new DTO.Sanpham();
                    sp.TENSP1 = txtTensanpham.Text;
                    sp.SOLUONG1 = Int32.Parse(txtSoluong.Text);
                    sp.DONGIA1 = Int32.Parse(txtDongia.Text);
                    sp.MALOAI1 = Int32.Parse(cbbLoaisanpham.SelectedValue.ToString());
                    sp.MANCC1 = Int32.Parse(cbbNhacungcap.SelectedValue.ToString());
                    sp.GIAMGIA1 = Int32.Parse(txtGiamgia.Text);
                    sp.HINHANH1 = txtTenanh.Text;
                    if (spb.Themsanpham(sp))
                    {
                        Hienthisanpham();
                        ResertCotroll();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuasp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Kiemtraduulieu())
                {
                    DTO.Sanpham sp = new DTO.Sanpham();
                    sp.MASP1 = ID;
                    sp.TENSP1 = txtTensanpham.Text;
                    sp.SOLUONG1 = Int32.Parse(txtSoluong.Text);
                    sp.DONGIA1 = Int32.Parse(txtDongia.Text);
                    sp.MALOAI1 = Int32.Parse(cbbLoaisanpham.SelectedValue.ToString());
                    sp.MANCC1 = Int32.Parse(cbbNhacungcap.SelectedValue.ToString());
                    sp.GIAMGIA1 = Int32.Parse(txtGiamgia.Text);
                    sp.HINHANH1 = txtTenanh.Text;
                    Luuanh();
                    if (spb.Suasanpham(sp))
                    {
                        Hienthisanpham();
                        btnThemmoisp.Enabled = true;
                        btnSuasp.Enabled = false;
                        btnXoasanpham.Enabled = false;
                        ResertCotroll();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvHienthisanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            try 
            {
                if (index >= 0)
                {
                    ID = Int32.Parse(dgvHienthisanpham.Rows[index].Cells["MASP"].Value.ToString());
                    txtTensanpham.Text = dgvHienthisanpham.Rows[index].Cells["TENSP"].Value.ToString();
                    txtSoluong.Text = dgvHienthisanpham.Rows[index].Cells["SOLUONG"].Value.ToString();
                    txtDongia.Text = dgvHienthisanpham.Rows[index].Cells["DONGIA"].Value.ToString();
                    cbbLoaisanpham.SelectedValue = Int32.Parse(dgvHienthisanpham.Rows[index].Cells["MALOAI"].Value.ToString());
                    cbbNhacungcap.SelectedValue = Int32.Parse(dgvHienthisanpham.Rows[index].Cells["MANCC"].Value.ToString());
                    txtGiamgia.Text = dgvHienthisanpham.Rows[index].Cells["GIAMGIA"].Value.ToString();
                    btnSuasp.Enabled = true;
                    btnXoasanpham.Enabled = true;
                    btnThemmoisp.Enabled = false;
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtTimsanpham_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string value = txtTimsanpham.Text;
                if (!String.IsNullOrEmpty(value))
                {
                    DataTable dt = spb.Timkiemsanpham(value);
                    dgvHienthisanpham.DataSource = dt;
                }
                else
                {
                    Hienthisanpham();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDongsp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ResertCotroll()
        {
            txtDongia.Text = "";
            txtSoluong.Text = "";
            txtTensanpham.Text = "";
            txtGiamgia.Text = "";
            txtTenanh.Text = "";
        }

        private void btnHuythaotacsp_Click(object sender, EventArgs e)
        {
            ResertCotroll();
            btnSuasp.Enabled = false;
            btnXoasanpham.Enabled = false;
            btnThemmoisp.Enabled =true;
        }

        private void btnXoasanpham_Click(object sender, EventArgs e)
        {
            DTO.Sanpham sp = new DTO.Sanpham();
            sp.MASP1 = ID;
            if (spb.Xoasanpham(sp))
            {
                Hienthisanpham();
            }
            btnThemmoisp.Enabled = true;
            btnSuasp.Enabled = false;
            btnXoasanpham.Enabled = false;
            ResertCotroll();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "Images(*.jpg)|*.jpg|PNG (*.png)|*.png|All files (*.*)|*.*";
            if(open.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(open.FileName);
                ptbAnhsanpham.Image = img;
                duongdan = open.FileName;
                txtTenanh.Text = Path.GetFileName(duongdan);
            }
        }

        public void Luuanh()
        {
            try
            {
                var s = Path.Combine("..\\..\\Resources\\Images\\");
                s = Path.GetFullPath(s);
                File.Copy(duongdan, Path.Combine(s, Path.GetFileName(txtTenanh.Text)), true);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHienthisanpham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHienthisanpham.Columns[e.ColumnIndex].Name == "HINHANH")
                {
                    var s = Path.Combine("..\\..\\Resources\\Images\\");
                    s = Path.GetFullPath(s);
                    e.Value = Bitmap.FromFile(s + e.Value.ToString());
                    e.FormattingApplied = true;
                }
        }
    }
}
