using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLySieuThiMini.BUS
{
    public class NhanvienBUS
    {
        DAO.NhanvienDAO nvd;
        public NhanvienBUS()
        {
            nvd = new DAO.NhanvienDAO();
        }
        public DataTable Tablenhanvien()
        {
            return nvd.Tablenhanvien();
        }
        public bool Themnhanvien(DTO.Nhanvien nv)
        {
            return nvd.Themnhanvien(nv);
        }
        public bool Suanhanvien(DTO.Nhanvien nv)
        {
            return nvd.Suanhanvien(nv);
        }
        public DataTable Timkiemnhanvien (string tnv)
        {
            return nvd.Timkiemnhanvien(tnv);
        }
        public DataTable Tableloainhanvien()
        {
            return nvd.Tableloainhanvien();
        }
    }

}
