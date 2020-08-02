using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySieuThiMini.BUS
{
    public class SanphamBUS
    {
        DAO.SanphamDAO spd;
        
        public SanphamBUS()
        {
            spd = new DAO.SanphamDAO();
            
        }
        public DataTable Tablesanpham()
        {
            return spd.Tablesanpham();
        }
        public DataTable Tableloaisanpham()
        {
            return spd.Tableloaisanpham();
        }
        public DataTable Tablenhacungcap()
        {
            return spd.Tablenhacungcap();
        }
        public bool Themsanpham(DTO.Sanpham sp)
        {
            return spd.Themsanpham(sp);
        }
        public bool Suasanpham(DTO.Sanpham sp)
        {
            return spd.Suasanpham(sp);
        }
        public DataTable Timkiemsanpham(string tsp)
        {
            return spd.Timkiemsanpham(tsp);
        }
        public bool Xoasanpham(DTO.Sanpham sp)
        {
            return spd.Xoasanpham(sp);
        }
    }
}
