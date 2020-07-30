using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySieuThiMini.BUS
{
    public class DoanhthuBUS
    {
        DAO.DoanhthuDAO dtd;
        public DoanhthuBUS()
        {
            dtd = new DAO.DoanhthuDAO();
        }
        public DataTable Danhsachhoadonxuat(string nbd, string nkt)
        {
            return dtd.Danhsachhoadonxuat(nbd,nkt);
        }
    }
}
