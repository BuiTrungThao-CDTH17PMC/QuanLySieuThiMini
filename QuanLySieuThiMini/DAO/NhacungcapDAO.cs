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
        //
        public NhacungcapDAO()
        {
            dc = new DataConnection();
        }
        //
        public DataTable Tablenhacungcap()
        {
            string sql = "select * from NHACUNGCAP";
            SqlConnection con = dc.getConnect();
            dr = new SqlDataAdapter(sql,con);
            con.Open();
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            return dt;
        }
        //
        public bool Themnhacungcap(DTO.Nhacungcap ncc)
        {
            string sql = "INSERT INTO NHACUNGCAP(MANCC,TENNCC,DIACHI,SDT)values (@MANCC,@TENNCC,@DIACHI,@SDT)";
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
            }catch(Exception e)
            {
               return false;
            }
            return true;
        }
        //
        public bool Suanhacungcap(DTO.Nhacungcap ncc)
        {
            string sql = "UPDATE NHACUNGCAP SET TENNCC=@TENNCC, DIACHI=@DIACHI, SDT=@SDT WHERE MANCC = @MANCC";
            SqlConnection con = dc.getConnect();
            //try
            //{
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANCC", SqlDbType.Int).Value = ncc.MANCC1;
                cmd.Parameters.Add("@TENNCC", SqlDbType.NVarChar).Value = ncc.TENNCC1;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = ncc.DIACHI1;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = ncc.SDT1;
                cmd.ExecuteNonQuery();
                con.Close();
           // }
            //catch (Exception e)
            //{
                //return false;
            //}
            return true;
        }
        //
        public DataTable Timkiemnhacungcap (string tncc)
        {
            string sql = "SELECT * FROM NHACUNGCAP WHERE TENNCC LIKE N'%" + tncc + "%'";
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
