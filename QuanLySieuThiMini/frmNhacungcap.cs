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
    public partial class frmNhacungcap : Form
    {
          BUS.NhacungcapBUS nccb;
        public frmNhacungcap()
        {
            InitializeComponent();
            nccb = new BUS.NhacungcapBUS();
        }

        ///     

        public void Hienthinhacungcap()
        {
            DataTable dt = nccb.Tablenhacungcap();
            dgvNhacungcap.DataSource = dt;
        }

        /*
           private void frmNhanvien_Load(object sender, EventArgs e)
         {
             Hienthinhanvien();
             Hienthicbbloainhanvien();
             btnSuanhanvien.Enabled = false;
         }
         private void txtTimnhanvien_TextChanged(object sender, EventArgs e)
         {
             string value = txtTimnhanvien.Text;
             if (!string.IsNullOrEmpty(value))
             {
                 DataTable dt = nvb.Timkiemnhanvien(value);
                 dgvHienthinhanvien.DataSource = dt;
             }
             else
                 Hienthinhanvien();
         }
         public void Hienthicbbloainhanvien()
         {
             DataTable dt = nvb.Tableloainhanvien();
             cbbLoainhanvien.DataSource = dt;
             cbbLoainhanvien.DisplayMember = "TENLOAI";
             cbbLoainhanvien.ValueMember = "MALOAI";
         }
         */


        public bool Kiemtradulieu()
        {
            if (string.IsNullOrEmpty(txtTennhacungcap.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtDcnhacungcap.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Kiemtraso(txtSdtnhacungcap.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
    
        public bool Kiemtraso(string text)
        {
            int num = 0;
            if (Int32.TryParse(text, out num))
                return true;
            else
                return false;
        }
        /// <summary>
        /// 
        /// </summary>
       


        private void btnHuynhacungcap_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuunhacungcap_Click(object sender, EventArgs e)
        {
             if(Kiemtradulieu())
            {
                DTO.Nhacungcap ncc = new DTO.Nhacungcap();
                ncc.TENNCC1 = txtTennhacungcap.Text;
                ncc.DIACHI1 = txtDcnhacungcap.Text;
                ncc.SDT1 = txtSdtnhacungcap.Text;
             
    
                if(nccb.Themnhacungcap(ncc))
                {
                    Hienthinhacungcap();
                }
            }
        }
        int ID;

        private void dgvNhacungcap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            btnSuanhacungcap.Enabled = true;
            btnLuunhacungcap.Enabled = false;
            try
            {
                if (index >= 0)
                {
                    ID = Int32.Parse(dgvNhacungcap.Rows[index].Cells["MANCC"].Value.ToString());
                    txtTennhacungcap.Text = dgvNhacungcap.Rows[index].Cells["TENNCC"].Value.ToString();
                    txtDcnhacungcap.Text = dgvNhacungcap.Rows[index].Cells["DIACHI"].Value.ToString();

                    txtSdtnhacungcap.Text = dgvNhacungcap.Rows[index].Cells["SDT"].Value.ToString();

                }
            }
            catch
            {
            }
        }

       

    }
    
}
