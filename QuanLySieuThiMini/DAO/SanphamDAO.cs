using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySieuThiMini.DAO
{
    public class SanphamDAO
    {
        DAO.DataConnection dc;
        SqlCommand cmd;
        SqlDataAdapter dr;
        public SanphamDAO()
        {
            dc = new DataConnection();
        }
        public DataTable Tablesanpham()
        {
            string sql = "SELECT GIAMGIA, MASP,TENSP,SP.MALOAI,TENLOAI,DONGIA,HINHANH,SOLUONG,SP.MANCC,TENNCC FROM SANPHAM SP,NHACUNGCAP NCC,LOAISANPHAM LSP WHERE SP.MALOAI = LSP.MALOAI AND SP.MANCC = NCC.MANCC AND SP.XOA = 0";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
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
        public DataTable Tablenhacungcap()
        {
            string sql = "SELECT * FROM NHACUNGCAP WHERE XOA = 0";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Themsanpham(DTO.Sanpham sp)
        {

            string sql = "INSERT INTO SANPHAM(TENSP,MALOAI,MANCC,SOLUONG,DONGIA,GIAMGIA,HINHANH)VALUES(@TENSP,@MALOAI,@MANCC,@SOLUONG,@DONGIA,@GIAMGIA,@HINHANH)";
            SqlConnection con = dc.getConnect();
           try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TENSP", SqlDbType.NVarChar).Value = sp.TENSP1;
                cmd.Parameters.Add("@MALOAI", SqlDbType.Int).Value = sp.MALOAI1;
                cmd.Parameters.Add("@MANCC", SqlDbType.Int).Value = sp.MANCC1;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = sp.SOLUONG1;
                cmd.Parameters.Add("@DONGIA", SqlDbType.Int).Value = sp.DONGIA1;
                cmd.Parameters.Add("@GIAMGIA", SqlDbType.Int).Value = sp.GIAMGIA1;
                cmd.Parameters.Add("@HINHANH", SqlDbType.NVarChar).Value = sp.HINHANH1;
                cmd.ExecuteNonQuery();
                con.Close();
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public bool Suasanpham(DTO.Sanpham sp)
        {
            string sql = "UPDATE SANPHAM SET TENSP=@TENSP, MALOAI=@MALOAI, MANCC=@MANCC, SOLUONG=@SOLUONG, DONGIA=@DONGIA, HINHANH = @HINHANH, GIAMGIA = @GIAMGIA WHERE MASP=@MASP";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MASP", SqlDbType.Int).Value = sp.MASP1;
                cmd.Parameters.Add("@TENSP", SqlDbType.NVarChar).Value = sp.TENSP1;
                cmd.Parameters.Add("@MALOAI", SqlDbType.Int).Value = sp.MALOAI1;
                cmd.Parameters.Add("@MANCC", SqlDbType.Int).Value = sp.MANCC1;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = sp.SOLUONG1;
                cmd.Parameters.Add("@DONGIA", SqlDbType.Int).Value = sp.DONGIA1;
                cmd.Parameters.Add("@GIAMGIA", SqlDbType.Int).Value = sp.GIAMGIA1;
                cmd.Parameters.Add("@HINHANH", SqlDbType.NVarChar).Value = sp.HINHANH1;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable Timkiemsanpham(string tsp)
        {
            string sql = "SELECT GIAMGIA, MASP,TENSP,SP.MALOAI,TENLOAI,DONGIA,HINHANH,SOLUONG,SP.MANCC,TENNCC FROM SANPHAM SP,NHACUNGCAP NCC,LOAISANPHAM LSP WHERE SP.MALOAI = LSP.MALOAI AND SP.MANCC = NCC.MANCC AND TENSP LIKE N'%" + tsp + "%'";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Xoasanpham(DTO.Sanpham sp)
        {
            string sql = "UPDATE SANPHAM SET XOA = 1 WHERE MASP=@MASP";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MASP", SqlDbType.Int).Value = sp.MASP1;
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
