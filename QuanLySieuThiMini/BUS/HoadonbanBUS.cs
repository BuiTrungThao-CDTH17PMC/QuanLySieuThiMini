using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySieuThiMini.BUS
{
    public class HoadonbanBUS
    {
        DAO.HoadonbanDAO hdxd;

        public HoadonbanBUS()
        {
            hdxd = new DAO.HoadonbanDAO();
        }

        public DataTable Tablehoadonxuat()
        {
            return hdxd.Tablehoadonxuat();
        }

        public DataTable Tablechitiethoadonxuat(int ID)
        {
            return hdxd.Tablechitietxuat(ID);
        }

        public bool Themhoadonxuat(DTO.Hoadonxuat hdx)
        {
            return hdxd.Themhoadonxuat(hdx);
        }

        public bool Themchitiethoadonxuat(DTO.Chitiethoadonxuat cthdx)
        {
            return hdxd.Themchitiethoadonxuat(cthdx);
        }

        public DataTable Tabletheongay(string date)
        {
            return hdxd.Tabletheongay(date);
        }

    }
}
