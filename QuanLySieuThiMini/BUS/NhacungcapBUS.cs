using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiMini.BUS
{
    class NhacungcapBUS
    {
        DAO.NhacungcapDAO nccd;

        public NhacungcapBUS()
        {
            nccd = new DAO.NhacungcapDAO();
        }
        public DataTable Tablenhacungcap()
        {
            return nccd.Tablenhacungcap();
        }
        public bool Themnhacungcap(DTO.Nhacungcap ncc)
        {
            return nccd.Themnhacungcap(ncc);
        }
        public bool Suanhacungcap(DTO.Nhacungcap ncc)
        {
            return nccd.Suanhacungcap(ncc);
        }
        public DataTable Timkiemnhacungcap(string tncc)
        {
            return nccd.Timkiemnhacungcap(tncc);
        }
        
        public bool Xoanhacungcap(DTO.Nhacungcap ncc)
        {
            return nccd.Xoanhacungcap(ncc);
        }
    }
}
