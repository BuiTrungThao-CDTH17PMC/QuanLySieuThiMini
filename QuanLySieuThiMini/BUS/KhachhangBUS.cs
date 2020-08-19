using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLySieuThiMini.BUS
{
    public class KhachhangBUS
    {
        DAO.KhachhangDAO khd;
        public KhachhangBUS()
        {
            khd = new DAO.KhachhangDAO();
        }
        public DataTable Tablekhachhang()
        {
            return khd.Tablekhachhang();
        }
        public bool Themkhachhang(DTO.Khachhang kh)
        {
            return khd.Themkhachhang(kh);
        }
        public bool Suakhachhang(DTO.Khachhang kh)
        {
            return khd.Suakhachhang(kh);
        }
        public DataTable Timkiemkhachhang(string tkh)
        {
            return khd.Timkiemkhachhang(tkh);
        }
        public bool Xoakhachhang(DTO.Khachhang kh)
        {
            return khd.Xoakhachhang(kh);
        }
        public bool Tichdiem(int diem,int Makh)
        {
            return khd.Tichdiem(diem, Makh);
        }
    }
}
