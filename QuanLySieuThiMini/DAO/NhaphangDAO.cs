using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySieuThiMini.DAO
{
    public class NhaphangDAO
    {
        DAO.DataConnection dc;
        SqlCommand cmd;
        SqlDataAdapter dr;
        public NhaphangDAO()
        {
            dc = new DataConnection();
        }

        public DataTable Danhsachsanpham()
        {
            string sql = "SELECT MASP,TENSP,SP.MALOAI,NCC.MANCC,SOLUONG,NCC.TENNCC,TENLOAI FROM SANPHAM SP,NHACUNGCAP NCC ,LOAISANPHAM LSP WHERE SP.XOA = 0 AND SP.MANCC = NCC.MANCC AND SP.MALOAI = LSP.MALOAI";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
        }

        public bool Capnhatthemsoluong(int soluong, int ID)
        {
            try
            {
                string sql = "UPDATE SANPHAM SET SOLUONG = SOLUONG + " + soluong + " WHERE MASP = " + ID;
                SqlConnection con = dc.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch { return false; }
            return true;
           
        }
    }
}
