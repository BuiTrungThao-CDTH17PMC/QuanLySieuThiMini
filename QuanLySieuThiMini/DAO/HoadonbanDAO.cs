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
            string sql = "SELECT * FROM CHITIETHOADONXUAT WHERE MAHDX = '" + ID + "'";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
       }
        public DataTable Tabletheongay(string date)
        {
            string sql = "SELECT * FROM HOADONXUAT WHERE NGAYLAP = '" + date + "'";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Themhoadonxuat(DTO.Hoadonxuat hdx)
       {
           string sql = "INSERT INTO HOADONXUAT(MANV,TENNV,NGAYLAP,SODIEMSUDUNG,TONGTIEN,MAKH)VALUES(@MANV, @TENNV, @NGAYLAP, @SODIEMSUDUNG, @TONGTIEN, @MAKH)";
           SqlConnection con = dc.getConnect();
           try
           {
               con.Open();
               cmd = new SqlCommand(sql, con);
               cmd.Parameters.Add("@MANV", SqlDbType.Int).Value = hdx.MANV1;
               cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = hdx.TENNV1;
               cmd.Parameters.Add("@NGAYLAP", SqlDbType.DateTime).Value = hdx.NGAYLAP1;
               cmd.Parameters.Add("@SODIEMSUDUNG", SqlDbType.Int).Value = hdx.SODIEMSUDUNG1;
               cmd.Parameters.Add("@TONGTIEN", SqlDbType.Int).Value = hdx.TONGTIEN1;
               cmd.Parameters.Add("@MAKH", SqlDbType.Int).Value = hdx.MAKH1;
               cmd.ExecuteNonQuery();
               con.Close();
           }catch(Exception e)
           {
               return false;
           }
           return true;
       }

       public bool Themchitiethoadonxuat(DTO.Chitiethoadonxuat cthdx)
       {
           string sql = "INSERT INTO CHITIETHOADONXUAT(MAHDX,MASP,TENSP,SOLUONG,GIATIEN,GIAMGIA)VALUES(@MAHDX, @MASP, @TENSP, @SOLUONG, @GIATIEN, @GIAMGIA)";
           SqlConnection con = dc.getConnect();
           try
           {
               con.Open();
               cmd = new SqlCommand(sql, con);
               cmd.Parameters.Add("@MAHDX", SqlDbType.Int).Value = cthdx.MAHDX1;
               cmd.Parameters.Add("@MASP", SqlDbType.Int).Value = cthdx.MASP1;
               cmd.Parameters.Add("@TENSP", SqlDbType.NVarChar).Value = cthdx.TENSP1;
               cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = cthdx.SOLUONG1;
               cmd.Parameters.Add("@GIATIEN", SqlDbType.Int).Value = cthdx.GIATIEN1;
               cmd.Parameters.Add("@GIAMGIA", SqlDbType.Int).Value = cthdx.GIAMGIA1;
               cmd.ExecuteNonQuery();
               con.Close();
           }
           catch (Exception e)
           {
               return false;
           }
               return true;
       }
    }
}
