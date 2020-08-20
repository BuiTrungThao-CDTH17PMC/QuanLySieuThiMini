using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using QuanLySieuThiMini.DTO;

namespace QuanLySieuThiMini
{
    public partial class frmBanhang : Form
    {
        // Khai báo
        private FilterInfoCollection camera;
        private VideoCaptureDevice cam;
        BUS.BanhangBUS bhb;
        BUS.HoadonbanBUS hdb;
        BUS.KhachhangBUS khb;
        private List<CartItem> Banhang = new List<CartItem>();

        public frmBanhang()
        {
            InitializeComponent();
            bhb = new BUS.BanhangBUS();
            hdb = new BUS.HoadonbanBUS();
            khb = new BUS.KhachhangBUS();
            camera = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in camera)
            {
                cbbdscam.Items.Add(info.Name);
            }
            cbbdscam.SelectedIndex = 0;
        }
        // Lấy mã và tên nhân viên
        public frmBanhang(string tennv,int manv):this()
        {
            lblManv.Text = manv.ToString();
            lblTennhanvienbh.Text = tennv;
        }
        // Chạy webcam
        public void chaycamera()
        {
            if( cam!= null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam = new VideoCaptureDevice(camera[cbbdscam.SelectedIndex].MonikerString);
            cam.NewFrame +=  cam_NewFrame;
            cam.Start();
        }
        // Hiện thị webcam
        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader readr = new BarcodeReader();
            var resutl = readr.Decode(bitmap);
            if (resutl != null && resutl.ToString() != txtTimsanphambh.Text)
            {
                txtTimsanphambh.Invoke(new MethodInvoker(delegate()
                {
                    txtTimsanphambh.Text = resutl.ToString();
                    Laysanpham(Int32.Parse(txtTimsanphambh.Text));
                }));
            }
            ptbCamquetma.Image = bitmap;
        }
        // Đóng chương trình webcam ngưng chạy
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }
        //  Load form
        private void frmBanhang_Load(object sender, EventArgs e)
        {
            chaycamera();
            lblNgaymuahang.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblMahoadonbh.Text = bhb.Laymahoadon().ToString();
        }
        // Lấy dữ liệu từ khách hàng
        void laydata(string tkh, string mkh)
        {
            lblTenkhachhangbh.Text = tkh;
            lblMakhachhangbh.Text = mkh;
        }
        // Button chọn khách hàng
        private void btnChonkhachhang_Click(object sender, EventArgs e)
        {
            frmHienthikhachhang htkh = new frmHienthikhachhang();
            htkh.truyen = new frmHienthikhachhang.truyendulieu(laydata);
            htkh.ShowDialog();
        }
        // Hàm kiểm tra chung
        public bool Kiemtradulieu()
        {
            if(String.IsNullOrEmpty(txtTimsanphambh.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sản phẩm cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            if (String.IsNullOrEmpty(txtSoluong.Text))
            {
                MessageBox.Show("Bạn chưa số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            return true;
        }

        public bool kiemtra()
        {
            for (int i = 0; i < dgvBanhang.RowCount; i++)
            {
                if (txtTimsanphambh.Text == dgvBanhang.Rows[i].Cells["MASP"].Value.ToString())
                    return true;
            }
            return false;
        }

        // Buton tìm sản phẩm
        private void btnTimsanphambh_Click(object sender, EventArgs e)
        {
            if (Kiemtradulieu())
            {
                if(dgvBanhang.RowCount > 0 && kiemtra() && Kiemtrasoluong() == false)
                {
                    for (int i = 0; i < dgvBanhang.RowCount; i++)
                    {
                        if (txtTimsanphambh.Text == dgvBanhang.Rows[i].Cells["MASP"].Value.ToString())
                        {
                            dgvBanhang.Rows[i].Cells["SOLUONG"].Value = txtSoluong.Text;
                            lblTongtienbh.Text = Tinhtien().ToString();
                            lblTongtienbh.Text = string.Format("{0:n0}", decimal.Parse(lblTongtienbh.Text));
                        }
                    }           
                }else
                    Laysanpham(Int32.Parse(txtTimsanphambh.Text));              
            }
        }
        // Tìm sản phẩm
        public void Laysanpham(int Masp)
        {
            dgvBanhang.Columns["GIAMGIA"].DefaultCellStyle.Format = "N";
            dgvBanhang.Columns["DONGIA"].DefaultCellStyle.Format = "N";
            if(Kiemtrasoluong() ==  false)
            {
                List<DTO.Chitiethoadonxuat> List = bhb.Laysanpham(Masp);
                dgvBanhang.Rows.Add();
                if (dgvBanhang.RowCount >= 0)
                {
                    foreach (DTO.Chitiethoadonxuat ls in List)
                    {
                        dgvBanhang.Rows[dgvBanhang.RowCount - 1].Cells["TENSP"].Value = ls.TENSP1;
                        dgvBanhang.Rows[dgvBanhang.RowCount - 1].Cells["MASP"].Value = ls.MASP1;
                        dgvBanhang.Rows[dgvBanhang.RowCount - 1].Cells["DONGIA"].Value = ls.GIATIEN1;
                        dgvBanhang.Rows[dgvBanhang.RowCount - 1].Cells["SOLUONG"].Value = txtSoluong.Text;
                        dgvBanhang.Rows[dgvBanhang.RowCount - 1].Cells["GIAMGIA"].Value = ls.GIAMGIA1;
                    }
                    lblTongtienbh.Text = Tinhtien().ToString();
                    lblTongtienbh.Text = string.Format("{0:n0}", decimal.Parse(lblTongtienbh.Text));
                }
            }
        }
        public int chuyen(string la)
        {
            var lal = la;
            var clear = lal.Replace(",", "");
            return Int32.Parse(clear);
        }
        // Buton thanh toán
        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            if (dgvBanhang.RowCount > 0)
            {
                DTO.Hoadonxuat hdx = new DTO.Hoadonxuat();
                hdx.MAKH1 = Int32.Parse(lblMakhachhangbh.Text);
                hdx.MANV1 = Int32.Parse(lblManv.Text);
                hdx.TENNV1 = lblTennhanvienbh.Text;
                hdx.TONGTIEN1 = chuyen(lblTongtienbh.Text);
                hdx.TENNV1 = lblTennhanvienbh.Text;
                hdx.NGAYLAP1 = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd"));
                if(hdb.Themhoadonxuat(hdx))
                {
                    DTO.Chitiethoadonxuat cthdx = new DTO.Chitiethoadonxuat();
                    for (int i = 0; i < dgvBanhang.RowCount; i++)
                    {
                        cthdx.MAHDX1 = Int32.Parse(lblMahoadonbh.Text);
                        cthdx.MASP1 = Int32.Parse(dgvBanhang.Rows[i].Cells["MASP"].Value.ToString());
                        cthdx.TENSP1 = dgvBanhang.Rows[i].Cells["TENSP"].Value.ToString();
                        cthdx.SOLUONG1 = Int32.Parse(dgvBanhang.Rows[i].Cells["SOLUONG"].Value.ToString());
                        cthdx.GIATIEN1 = Int32.Parse(dgvBanhang.Rows[i].Cells["DONGIA"].Value.ToString());
                        cthdx.GIAMGIA1 = Int32.Parse(dgvBanhang.Rows[i].Cells["GIAMGIA"].Value.ToString());
                        if (hdb.Themchitiethoadonxuat(cthdx))
                        {
                            dem++;
                        }
                    }
                }
                if (dem == dgvBanhang.RowCount)
                {
                    Trusoluong();
                    Tichdiem();
                    Luulichsutichdiem();
                    printPreviewDialog1_Load();
                    Resert();
                   

                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK);
                    lblMahoadonbh.Text = bhb.Laymahoadon().ToString();
                }
            }else
            {
                MessageBox.Show("Chưa mua sản phẩm nào", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Lưu lịch sử tích điểm
        public void Luulichsutichdiem()
        {
            try
            {
                if(lblTenkhachhangbh.Text != "Khách vãng lai")
                {
                    BUS.LichsutichdiemBUS lstdb = new BUS.LichsutichdiemBUS();
                    DTO.Lichsutichdiem ls = new DTO.Lichsutichdiem();
                    ls.MAHDX1 = Int32.Parse(lblMahoadonbh.Text);
                    ls.MAKH1 = Int32.Parse(lblMakhachhangbh.Text);
                    ls.NGAY1 = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd"));
                    lstdb.Luulichsutichdiem(ls);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        // Tích điểm
        public void Tichdiem()
        {
            if(lblTenkhachhangbh.Text != "Khách vãng lai")
            {
                khb.Tichdiem(chuyen(lblTongtienbh.Text) / 10, Int32.Parse(lblMakhachhangbh.Text));
            }
        }
        // Hàm trừ số lương đã mua
        public void Trusoluong()
        {
            for (int i = 0; i < dgvBanhang.RowCount; i++)
            {
                bhb.Trusoluong(Int32.Parse(dgvBanhang.Rows[i].Cells["MASP"].Value.ToString()), Int32.Parse(dgvBanhang.Rows[i].Cells["SOLUONG"].Value.ToString()));
            }
        }
        // Tính tiền của hóa đơn
        public int Tinhtien()
        {
            int tinhdem, tongtien = 0;
            try
            {
                if (dgvBanhang.RowCount > 0)
                {
                    for (int i = 0; i < dgvBanhang.RowCount; i++)
                    {
                        tinhdem = (Int32.Parse(dgvBanhang.Rows[i].Cells["DONGIA"].Value.ToString()) - Int32.Parse(dgvBanhang.Rows[i].Cells["GIAMGIA"].Value.ToString())) * Int32.Parse(dgvBanhang.Rows[i].Cells["SOLUONG"].Value.ToString());
                        tongtien = tongtien + tinhdem;
                    }
                }
            }
            catch { }
            return tongtien;
        }
        // Thoát chương trình
        private void btnDongbanhang_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Tạo hóa đơn mới
        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            Resert();
        }
        // Load lại tất cả các control
        public void Resert()
        {
            dgvBanhang.Rows.Clear();
            lblTongtienbh.Text = "0";
            lblTenkhachhangbh.Text = "Khách vãng lai";
            lblMakhachhangbh.Text = "1";
            txtTimsanphambh.Clear();
        }
        // Xóa từng đã chọn trong dgvChitietsanpham
        private void btnXoasanmua_Click(object sender, EventArgs e)
        {
            if (dgvBanhang.SelectedRows.Count > 0)
            {
                dgvBanhang.Rows.RemoveAt(this.dgvBanhang.SelectedRows[0].Index);
            }
            lblTongtienbh.Text = Tinhtien().ToString();
            lblTongtienbh.Text = string.Format("{0:n0}", decimal.Parse(lblTongtienbh.Text));
        }

        private void txtTimsanphambh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public bool Kiemtrasoluong()
        {
            int soluong = bhb.Laysoluong(Int32.Parse(txtTimsanphambh.Text));
            int soluongnhap = Int32.Parse(txtSoluong.Text);
            if(soluongnhap <= 0)
            {
                soluongnhap = 1;
            }    
            if (Int32.Parse(txtSoluong.Text) > bhb.Laysoluong(Int32.Parse(txtTimsanphambh.Text)))
            {
                MessageBox.Show("Không đủ số lương", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        public void laydanhsachchitiet()
        {
            
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Ngày thanh toán " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString("người bán " + lblTennhanvienbh.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 30));
            e.Graphics.DrawString("================================================================================================================================== ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 60));
            e.Graphics.DrawString("Tên sản phẩm ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 90));
            e.Graphics.DrawString("Số lượng", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(130, 90));
            e.Graphics.DrawString("Giá tiền ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 90));
            e.Graphics.DrawString("================================================================================================================================== ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 120));

            dgvBanhang.Show();
            

            e.Graphics.DrawString("================================================================================================================================== ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 120));
            e.Graphics.DrawString("tổng tiền " + lblTongtienbh.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 90));
        }

        private void printPreviewDialog1_Load()
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
