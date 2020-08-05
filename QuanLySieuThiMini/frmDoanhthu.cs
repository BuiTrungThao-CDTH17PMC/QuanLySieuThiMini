using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.IO;

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

        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            if(dgvDanhsachhoadon.RowCount > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                if (save.ShowDialog() == DialogResult.OK)
                {
                    export2Excel(dgvDanhsachhoadon, save.FileName, " từ " + dtpNgaybatdau.Value.Date.ToString("dd-MM-yyyy") + " đến " + dtpNgayketthuc.Value.Date.ToString("dd-MM-yyyy"));
                }
            }else
            {
                MessageBox.Show("Bạn chưa có danh sách cần báo cáo");
            }    
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
