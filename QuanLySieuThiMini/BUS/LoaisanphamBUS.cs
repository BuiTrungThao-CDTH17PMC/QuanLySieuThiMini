using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLySieuThiMini.BUS
{
    public class LoaisanphamBUS
    {
        DAO.LoaisanphamDAO lspd;
        public LoaisanphamBUS()
        {
            lspd = new DAO.LoaisanphamDAO();
        }
        public DataTable Tableloaisanpham()
        {
            return lspd.Tableloaisanpham();
        }
        public bool Themloaisanpham(DTO.Loaisanpham lsp)
        {
            return lspd.Themloaisanpham(lsp);
        }
        public bool Sualoaisanpham(DTO.Loaisanpham lsp)
        {
            return lspd.Sualoaisanpham(lsp);
        }
        public bool Xoaloaisanpham(DTO.Loaisanpham lsp)
        {
            return lspd.Xoaloaisanpham(lsp);
        }
    }
}
