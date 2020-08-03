using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySieuThiMini.DAO
{
    public class LoainhanvienDAO
    {
        DAO.DataConnection dc;
        SqlCommand cmd;
        SqlDataAdapter dr;
        public LoainhanvienDAO()
        {
            dc = new DAO.DataConnection();
        }
        public DataTable Tableloainhanvien()
        {
            string sql = "SELECT * FROM LOAINHANVIEN WHERE XOA = 0";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql,con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Themloainhanvien(DTO.Loainhanvien lnv)
        {
            string sql = "INSERT INTO LOAINHANVIEN(TENLOAI)VALUES(@TENLOAI)";
            SqlConnection con = dc.getConnect();
            try 
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@TENLOAI", SqlDbType.NVarChar).Value = lnv.TENLOAI1;
                cmd.ExecuteNonQuery();
                con.Close();
            }catch(Exception e)
            {
                return false;
            }
            return true;
           
        }
        public bool Sualoainhanvien(DTO.Loainhanvien lnv)
        {
            string sql = "UPDATE LOAINHANVIEN SET TENLOAI = @TENLOAI WHERE MALOAI = @MALOAI";
            SqlConnection con = dc.getConnect();
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MALOAI", SqlDbType.Int).Value = lnv.MALOAI1;
                cmd.Parameters.Add("@TENLOAI", SqlDbType.NVarChar).Value = lnv.TENLOAI1;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool Xoaloainhanvien(DTO.Loainhanvien lnv)
        {
            string sql = "UPDATE LOAINHANVIEN SET XOA = 1 WHERE MALOAI = @MALOAI";
            SqlConnection con = dc.getConnect();
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MALOAI", SqlDbType.Int).Value = lnv.MALOAI1;
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
