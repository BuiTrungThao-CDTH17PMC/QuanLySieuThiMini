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
        SqlDataAdapter da;

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

        //public DataTable Laysanpham(int masp)
        //{
        //    string sql = "SELECT MASP,TENSP,DONGIA FROM SANPHAM WHERE MASP = "+ masp;
        //    SqlConnection con = dc.getConnect();
        //    da = new SqlDataAdapter(sql, con);
        //    con.Open();
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    con.Close();
        //    return dt;

        //}

        public List<DTO.Chitiethoadonxuat> Laysanpham(int masp)
        {
            List<DTO.Chitiethoadonxuat> list = new List<DTO.Chitiethoadonxuat>();
            string sql = "SELECT MASP,TENSP,DONGIA FROM SANPHAM WHERE MASP = " + masp;
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
                list.Add(cthd);
            }
            return list;
        }

        
    }
}
