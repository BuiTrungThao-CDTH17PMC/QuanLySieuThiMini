using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySieuThiMini.DAO
{
   public class HoadonbanDAO
    {
       SqlDataAdapter dr;
       DAO.DataConnection dc;
       SqlCommand cmd;
       public HoadonbanDAO()
       {
           dc = new DataConnection();
       }
       public DataTable Tablehoadonxuat()
       {
           string sql = "SELECT * FROM HOADONXUAT";
           SqlConnection con = dc.getConnect();
           dr = new SqlDataAdapter(sql, con);
           con.Open();
           DataTable dt = new DataTable();
           dr.Fill(dt);
           con.Close();
           return dt;
       }
       public DataTable Tablechitietxuat(int ID)
       {
           string sql = "SELECT * FROM CHITIETHOADONXUAT WHERE MAHDX = '"+ ID + "'";
           SqlConnection con = dc.getConnect();
           dr = new SqlDataAdapter(sql, con);
           con.Open();
           DataTable dt = new DataTable();
           dr.Fill(dt);
           con.Close();
           return dt;
       }
    }
}
