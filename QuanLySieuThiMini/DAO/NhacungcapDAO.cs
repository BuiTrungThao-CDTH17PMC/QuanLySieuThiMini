using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLySieuThiMini.DAO
{
    class NhacungcapDAO
    {
        DAO.DataConnection dc;
        SqlDataAdapter dr;
        SqlCommand cmd;
        public NhacungcapDAO()
        {
            dc = new DataConnection();
        }
        public DataTable Tablenhacungcap()
        {
            string sql = "select * from NHACUNGCAP Where XOA = 0";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
        }

        public bool Themnhacungcap(DTO.Nhacungcap ncc)
        {
            string sql = "INSERT INTO NHACUNGCAP(TENNCC,DIACHI,SDT)values (@TENNCC,@DIACHI,@SDT)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TENNCC", SqlDbType.NVarChar).Value = ncc.TENNCC1;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = ncc.DIACHI1;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = ncc.SDT1;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool Suanhacungcap(DTO.Nhacungcap ncc)
        {
            string sql = "UPDATE NHACUNGCAP SET TENNCC=@TENNCC, DIACHI=@DIACHI, SDT=@SDT WHERE MANCC = @MANCC";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.Int).Value = ncc.MANCC1;
                cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = ncc.TENNCC1;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = ncc.DIACHI1;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = ncc.SDT1;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable Timkiemnhacungcap(string tncc)
        {
            string sql = "DECLARE @query NVARCHAR(max)SELECT @query =  dbo.non_unicode_convert(N'"+ tncc +"')SELECT  * FROM NHACUNGCAP WHERE XOA = 0 AND dbo.non_unicode_convert(TENNCC) LIKE  '%' + @query+ '%'";
            //string sql = "SELECT * FROM NHACUNGCAP WHERE TENNCC LIKE N'%" + tncc + "%'";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable Tableloainhanvien()
        {
            string sql = "SELECT * FROM LOAINHANVIEN";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Xoanhacungcap(DTO.Nhacungcap ncc)
        {
            string sql = "UPDATE NHACUNGCAP SET XOA = 1 WHERE MANCC = @MANCC";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANCC", SqlDbType.Int).Value = ncc.MANCC1;
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
