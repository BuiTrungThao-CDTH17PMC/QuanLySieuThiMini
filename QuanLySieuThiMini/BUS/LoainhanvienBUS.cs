using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLySieuThiMini.BUS
{
    public class LoainhanvienBUS
    {
        DAO.LoainhanvienDAO lnvd;
        public LoainhanvienBUS()
        {
            lnvd = new DAO.LoainhanvienDAO();
        }
        public bool Themloainhanvien(DTO.Loainhanvien lnv)
        {
            return lnvd.Themloainhanvien(lnv);
        }
        public DataTable Tableloainhanvien()
        {
            return lnvd.Tableloainhanvien();
        }
        public bool Sualoainhanvien(DTO.Loainhanvien lnv)
        {
            return lnvd.Sualoainhanvien(lnv);
        }
        public bool Xoaloainhanvien(DTO.Loainhanvien lnv)
        {
            return lnvd.Xoaloainhanvien(lnv);
        }
    }
}
