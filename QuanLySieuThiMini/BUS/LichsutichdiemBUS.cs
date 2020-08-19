using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLySieuThiMini.BUS
{
    public class LichsutichdiemBUS
    {
        DAO.LichsutichdiemDAO lstd;

        public LichsutichdiemBUS()
        {
            lstd = new DAO.LichsutichdiemDAO();
        }

        public DataTable Tabletichdiem()
        {
            return lstd.Tabletichdiem();
        }

        public bool Luulichsutichdiem(DTO.Lichsutichdiem ls)
        {
            return lstd.Luulichsu(ls);
        }
    }
}
