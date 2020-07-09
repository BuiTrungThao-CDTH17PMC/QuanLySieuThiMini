using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiMini.BUS
{ 
    
    public class DangnhapBUS
    {
        DAO.DangnhapDAO dnd;
        public DangnhapBUS()
        {
            dnd = new DAO.DangnhapDAO();
        }
        public int Kiemtradangnhap(string tdn, string mk)
        {
            return dnd.Kiemtradangnhap(tdn, mk);
        }
    }
}
