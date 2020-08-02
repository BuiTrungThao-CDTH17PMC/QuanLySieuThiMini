using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySieuThiMini.DAO
{
    
    public class DangnhapDAO
    {
        DAO.DataConnection dc;
        SqlCommand cmd;
        SqlDataAdapter da;

        public DangnhapDAO()
        {
            dc = new DataConnection();
        }

        public int Kiemtradangnhap(string tdn, string mk)
        {

            string sql = "SELECT COUNT(*) FROM NHANVIEN WHERE TENTK = @TENDANGNHAP AND MATKHAU = @MATKHAU";
            SqlConnection con = dc.getConnect();
            int num;
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TENDANGNHAP", SqlDbType.VarChar).Value = tdn;
                cmd.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = mk;
                num = (int)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                return 0;
            }
            return num;
        }

        public List<DTO.Quyennhanvien> Quyennhanvien(string tdn)
        {
            List<DTO.Quyennhanvien> list = new List<DTO.Quyennhanvien>();
            string sql = "SELECT TENNV, MANV, TENLOAI FROM  NHANVIEN, LOAINHANVIEN    WHERE TENTK = '" + tdn + "' AND LOAINV = MALOAI";
            SqlConnection con = dc.getConnect();
            cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                DTO.Quyennhanvien qnv = new DTO.Quyennhanvien();
                qnv.MANV1 = Int32.Parse( dr["MANV"].ToString());
                qnv.TENNV1 = dr["TENNV"].ToString();
                qnv.TENLOAINV1 = dr["TENLOAI"].ToString();
                list.Add(qnv);

            }
            con.Close();
            return list;
        }
    }
}
