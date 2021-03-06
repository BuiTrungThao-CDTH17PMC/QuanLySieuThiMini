﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySieuThiMini.DAO
{
    public class KhachhangDAO
    {
        DAO.DataConnection dc;
        SqlCommand cmd;
        SqlDataAdapter dr;

        public KhachhangDAO()
        {
            dc = new DataConnection();
        }
        public DataTable Tablekhachhang()
        {
            string sql = "SELECT * FROM  KHACHHANG WHERE XOA = 0 ";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Themkhachhang(DTO.Khachhang kh)
        {
            string sql = "INSERT INTO KHACHHANG (TENKH,DIACHI,SDT,TICHDIEM) VALUES (@TENKH,@DIACHI,@SDT,@TICHDIEM)";
            SqlConnection con = dc.getConnect();
            try 
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TENKH",SqlDbType.NVarChar).Value = kh.TENKH1;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = kh.DIACHI1;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = kh.SDT1;
                cmd.Parameters.Add("@TICHDIEM", SqlDbType.Int).Value = kh.TICHDIEM1;
                cmd.ExecuteNonQuery();
                con.Close();
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public bool Suakhachhang(DTO.Khachhang kh)
        {
            string sql = "UPDATE KHACHHANG SET TENKH=@TENKH, DIACHI=@DIACHI, SDT=@SDT, TICHDIEM=@TICHDIEM WHERE MAKH=@MAKH";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAKH", SqlDbType.Int).Value = kh.MAKH1;
                cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = kh.TENKH1;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = kh.DIACHI1;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = kh.SDT1;
                cmd.Parameters.Add("@TICHDIEM", SqlDbType.Int).Value = kh.TICHDIEM1;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable Timkiemkhachhang(string tkh)
        {
            string sql = "DECLARE @query NVARCHAR(max)SELECT @query =  dbo.non_unicode_convert(N'" + tkh + "')SELECT  * FROM KHACHHANG WHERE XOA = 0 AND dbo.non_unicode_convert(TENKH) LIKE  '%' + @query+ '%'";
            //string sql = "SELECT * FROM KHACHHANG WHERE  XOA = 0 AND TENKH LIKE N'%" + tkh + "%'";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Xoakhachhang(DTO.Khachhang kh)
        {
            string sql = "UPDATE KHACHHANG SET XOA = 1 WHERE MAKH = @MAKH";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAKH", SqlDbType.Int).Value = kh.MAKH1;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool Tichdiem(int diem, int Makh)
        {
            string sql = "UPDATE KHACHHANG SET TICHDIEM = TICHDIEM +" + diem + " WHERE MAKH = " + Makh;
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
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
