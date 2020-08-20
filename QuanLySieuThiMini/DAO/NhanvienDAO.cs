using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLySieuThiMini.DAO
{
    public class NhanvienDAO
    {
        DAO.DataConnection dc;
        SqlDataAdapter dr;
        SqlCommand cmd;
        public NhanvienDAO()
        {
            dc = new DataConnection();
        }
        public DataTable Tablenhanvien()
        {
            string sql = "SELECT MANV,TENNV,DIACHI,LOAINV,TENTK,MATKHAU,SDT,GIOITINH,NV.XOA,TENLOAI FROM NHANVIEN NV, LOAINHANVIEN WHERE NV.XOA = 0 AND MALOAI = LOAINV";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql,con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Themnhanvien(DTO.Nhanvien nv)
        {
            string sql = "INSERT INTO NHANVIEN(TENNV,DIACHI,LOAINV,TENTK,MATKHAU,SDT,GIOITINH)VALUES(@TENNV,@DIACHI,@LOAINV,@TENTAIKHOAN,@MATKHAU,@SDT,@GIOITINH)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = nv.TENNV1;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = nv.DIACHI1;
                cmd.Parameters.Add("@TENTAIKHOAN", SqlDbType.VarChar).Value = nv.TENTK1;
                cmd.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = nv.MATKHAU1;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = nv.SDT1;
                cmd.Parameters.Add("@GIOITINH", SqlDbType.Bit).Value = nv.GIOITINH1;
                cmd.Parameters.Add("@LOAINV", SqlDbType.Int).Value = nv.LOAINV1;
                cmd.ExecuteNonQuery();
                con.Close();
            }catch(Exception e)
            {
               return false;
            }
            return true;
        }
        public bool Suanhanvien(DTO.Nhanvien nv)
        {
            string sql = "UPDATE NHANVIEN SET TENNV=@TENNV, DIACHI=@DIACHI, TENTK=@TENTAIKHOAN, MATKHAU=@MATKHAU, SDT=@SDT, GIOITINH=@GIOITINH, LOAINV=@LOAINV WHERE MANV = @MANV";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.Int).Value = nv.MANV1;
                cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = nv.TENNV1;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = nv.DIACHI1;
                cmd.Parameters.Add("@TENTAIKHOAN", SqlDbType.VarChar).Value = nv.TENTK1;
                cmd.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = nv.MATKHAU1;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = nv.SDT1;
                cmd.Parameters.Add("@GIOITINH", SqlDbType.Bit).Value = nv.GIOITINH1;
                cmd.Parameters.Add("@LOAINV", SqlDbType.Int).Value = nv.LOAINV1;
                cmd.ExecuteNonQuery();
                con.Close();
           }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable Timkiemnhanvien (string tnv)
        {
            string sql = "DECLARE @query NVARCHAR(max)SELECT @query =  dbo.non_unicode_convert(N'"+ tnv +"')SELECT  MANV,TENNV,DIACHI,LOAINV,TENTK,MATKHAU,SDT,GIOITINH,NV.XOA,TENLOAI FROM NHANVIEN NV, LOAINHANVIEN WHERE NV.XOA = 0 AND MALOAI = LOAINV AND dbo.non_unicode_convert(TENNV) LIKE  '%' + @query+ '%'";
            //string sql = "SELECT MANV,TENNV,DIACHI,LOAINV,TENTK,MATKHAU,SDT,GIOITINH,NV.XOA,TENLOAI FROM NHANVIEN NV, LOAINHANVIEN WHERE NV.XOA = 0 AND MALOAI = LOAINV AND TENNV LIKE N'%" + tnv + "%'";
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
            string sql = "SELECT * FROM LOAINHANVIEN WHERE XOA = 0";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
        }
        public int Kiemtratontai(string tdn)
        {

            string sql = "SELECT COUNT(*) FROM NHANVIEN WHERE TENTK = @TENDANGNHAP";
            SqlConnection con = dc.getConnect();
            int num;
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TENDANGNHAP", SqlDbType.VarChar).Value = tdn;
                num = (int)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                return 0;
            }
            return num;
        }
        public bool Xoanhanvien(DTO.Nhanvien nv)
        {
            string sql = "UPDATE NHANVIEN SET XOA = 1 WHERE MANV = @MANV";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.Int).Value = nv.MANV1;
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
