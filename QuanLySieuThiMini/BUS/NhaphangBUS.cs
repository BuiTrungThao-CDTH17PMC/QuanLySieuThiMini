using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLySieuThiMini.BUS
{
    public class NhaphangBUS
    {
        DAO.NhaphangDAO nhd;

        public NhaphangBUS()
        {
            nhd = new DAO.NhaphangDAO();
        }

        public DataTable Danhsachsanpham()
        {
            return nhd.Danhsachsanpham();
        }

        public bool Capnhatsoluong(int soluong,int ID)
        {
            return nhd.Capnhatthemsoluong(soluong, ID);
        }
    }
}
