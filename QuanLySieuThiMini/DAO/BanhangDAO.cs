using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySieuThiMini.DAO
{
    public class BanhangDAO
    {
        DataConnection dc;
        SqlCommand cmd;

        public BanhangDAO()
        {
            dc = new DataConnection();
        }

        public int Laymahoadon()
        {
            string sql = "SELECT MAX(MAHDX) AS ML FROM HOADONXUAT";
            SqlConnection con = dc.getConnect();
            cmd = new SqlCommand(sql, con);
            con.Open();
            int maxhd = (int) cmd.ExecuteScalar();
            con.Close();
            return maxhd + 1;
        }

        public List<DTO.Chitiethoadonxuat> Laysanpham(int masp)
        {
            List<DTO.Chitiethoadonxuat> list = new List<DTO.Chitiethoadonxuat>();
            string sql = "SELECT MASP,TENSP,DONGIA,GIAMGIA FROM SANPHAM WHERE  MASP = " + masp;
            SqlConnection con = dc.getConnect();
            cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {

                DTO.Chitiethoadonxuat cthd = new DTO.Chitiethoadonxuat();
                cthd.MASP1 = Int32.Parse(dr["MASP"].ToString());
                cthd.TENSP1 = dr["TENSP"].ToString();
                cthd.GIATIEN1 = Int32.Parse(dr["DONGIA"].ToString());
                cthd.GIAMGIA1 = Int32.Parse(dr["GIAMGIA"].ToString());
                list.Add(cthd);
            }
            return list;
        }

        public bool Trusoluong(int masp, int soluongmua)
        {
            try
            {
                string sql = "UPDATE SANPHAM SET SOLUONG = SOLUONG - " + soluongmua + " WHERE MASP = " + masp;
                SqlConnection con = dc.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }catch
            {
                return false;
            }
            return true;
            
        }

        public int Laysoluong(int masp)
        {
            int soluong = 0;
            try
            {
                string sql = "SELECT SOLUONG FROM SANPHAM WHERE MASP = " + masp;
                SqlConnection con = dc.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                soluong = (int)cmd.ExecuteScalar();
                con.Close();
            }
            catch { }
            return soluong;
        }
    }
}
