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
using BarcodeLib;

namespace QuanLySieuThiMini
{
    public partial class frmBanhang : Form
    {
        // Khai báo
        private FilterInfoCollection camera;
        private VideoCaptureDevice cam;
        BUS.BanhangBUS bhb;
        BUS.HoadonbanBUS hdb;

        public frmBanhang()
        {
            InitializeComponent();
            bhb = new BUS.BanhangBUS();
            hdb = new BUS.HoadonbanBUS();
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
            Barcode brc = new Barcode();
            var result = 
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
        // Buton tìm sản phẩm
        private void btnTimsanphambh_Click(object sender, EventArgs e)
        {
            List<DTO.Chitiethoadonxuat> List = bhb.Laysanpham(Int32.Parse(txtTimsanphambh.Text));
            dgvBanhang.Rows.Add();
            int index = dgvBanhang.RowCount;
            if ( index >= 0)
            {
                foreach (DTO.Chitiethoadonxuat ls in List)
                {
                    dgvBanhang.Rows[index-1].Cells["TENSP"].Value = ls.TENSP1;
                    dgvBanhang.Rows[index-1].Cells["MASP"].Value = ls.MASP1;
                    dgvBanhang.Rows[index-1].Cells["DONGIA"].Value = ls.GIATIEN1;
                    dgvBanhang.Rows[index-1].Cells["SOLUONG"].Value = txtSoluong.Text;
                    dgvBanhang.Rows[index-1].Cells["GIAMGIA"].Value = "3000";
                }
            }
            lblTongtienbh.Text = Tinhtien().ToString();
        }
        // Buton thanh toán
        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            int index = dgvBanhang.RowCount;
            DTO.Hoadonxuat hdx = new DTO.Hoadonxuat();
            if(index > 0)
            {
                hdx.MAKH1 = Int32.Parse(lblMakhachhangbh.Text);
                hdx.MANV1 = Int32.Parse(lblManv.Text);
                hdx.TENNV1 = lblTennhanvienbh.Text;
                hdx.TONGTIEN1 = Int32.Parse(lblTongtienbh.Text);
                hdx.TENNV1 = lblTennhanvienbh.Text;
                hdx.NGAYLAP1 = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd"));
                if(hdb.Themhoadonxuat(hdx))
                {
                    DTO.Chitiethoadonxuat cthdx = new DTO.Chitiethoadonxuat();
                    for(int i = 0; i < index; i++)
                    {
                        cthdx.MAHDX1 = Int32.Parse(lblMahoadonbh.Text);
                        cthdx.MASP1 = Int32.Parse(dgvBanhang.Rows[i].Cells["MASP"].Value.ToString());
                        cthdx.TENSP1 = dgvBanhang.Rows[i].Cells["TENSP"].Value.ToString();
                        cthdx.SOLUONG1 = Int32.Parse(dgvBanhang.Rows[i].Cells["SOLUONG"].Value.ToString());
                        cthdx.GIATIEN1 = Int32.Parse(dgvBanhang.Rows[i].Cells["DONGIA"].Value.ToString());
                        cthdx.GIAMGIA1 = Int32.Parse(dgvBanhang.Rows[i].Cells["GIAMGIA"].Value.ToString());
                    }
                    if (hdb.Themchitiethoadonxuat(cthdx))
                    {
                        MessageBox.Show("Đã thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }
        // Tính tiền của hóa đơn
        public int Tinhtien()
        {
            int gia, soluong, giamgia, tinhdem, tongtien = 0;
            int index = dgvBanhang.RowCount;
            for(int i = 0; i < index; i++)
            {
                gia = Int32.Parse(dgvBanhang.Rows[i].Cells["DONGIA"].Value.ToString());
                soluong = Int32.Parse(dgvBanhang.Rows[i].Cells["SOLUONG"].Value.ToString());
                giamgia = Int32.Parse(dgvBanhang.Rows[i].Cells["GIAMGIA"].Value.ToString());
                tinhdem = (gia - giamgia) * soluong;
                tongtien = tongtien + tinhdem;
            }
            return tongtien;
        }
    }
}
