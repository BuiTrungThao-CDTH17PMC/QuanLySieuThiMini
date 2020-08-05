
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLySieuThiMini.DAO
{
    public class LoaisanphamDAO
    {
        DAO.DataConnection dc;
        SqlDataAdapter dr;
        SqlCommand cmd;
        public LoaisanphamDAO()
        {
            dc = new DataConnection();
        }
        public DataTable Tableloaisanpham()
        {
            string sql = "SELECT * FROM LOAISANPHAM WHERE XOA = 0";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Themloaisanpham(DTO.Loaisanpham lsp)
        {
            string sql = "INSERT INTO LOAISANPHAM(TENLOAI)values (@TENLOAI)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TENLOAI", SqlDbType.NVarChar).Value = lsp.TENLOAI1;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool Sualoaisanpham(DTO.Loaisanpham lsp)
        {
            string sql = "UPDATE LOAISANPHAM SET TENLOAI=@TENLOAI WHERE MALOAI = @MALOAI";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MALOAI", SqlDbType.Int).Value = lsp.MALOAI1;
                cmd.Parameters.Add("@TENLOAI", SqlDbType.NVarChar).Value = lsp.TENLOAI1;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool Xoaloaisanpham(DTO.Loaisanpham lsp)
        {
            string sql = "UPDATE LOAISANPHAM SET XOA = 1 WHERE MALOAI = @MALOAI";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MALOAI", SqlDbType.Int).Value = lsp.MALOAI1;
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
