using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySieuThiMini.BUS
{
    public class BanhangBUS
    {
        DAO.BanhangDAO bhd;

        public BanhangBUS()
        {
            bhd = new DAO.BanhangDAO();
        }

        public int Laymahoadon()
        {
            return bhd.Laymahoadon();
        }

        public List<DTO.Chitiethoadonxuat> Laysanpham(int masp)
        {
            return bhd.Laysanpham(masp);
        }
        
        public bool Trusoluong(int masp, int soluongmua)
        {
            return bhd.Trusoluong(masp, soluongmua);
        }

        public int Laysoluong(int masp)
        {
            return bhd.Laysoluong(masp);
        }
    }
}
