using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySieuThiMini.DAO
{
    public class LichsutichdiemDAO
    {
        DataConnection dc;

        public LichsutichdiemDAO()
        {
            dc = new DataConnection();
        }

        public DataTable Tabletichdiem()
        {
            DataTable dt = new DataTable();;
            try
            {
                string sql = "SELECT * FROM LICHSUTICHDIEM ";
                SqlConnection con = dc.getConnect();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                con.Open();
                da.Fill(dt);
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public bool Luulichsu(DTO.Lichsutichdiem lstd)
        {
            try
            {
                string sql = "INSERT INTO LICHSUTICHDIEM(MAKH,MAHD,NGAY)VALUES(@MAKH,@MAHD,@NGAY)";
                SqlConnection con = dc.getConnect();
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAKH", SqlDbType.Int).Value = lstd.MAKH1;
                cmd.Parameters.Add("@MAHD", SqlDbType.Int).Value = lstd.MAHDX1;
                cmd.Parameters.Add("@NGAY", SqlDbType.Date).Value = lstd.NGAY1;
                cmd.ExecuteNonQuery();
                con.Close();
            }catch
            {
                return false;
            }
            return true;
        }


    }
}
