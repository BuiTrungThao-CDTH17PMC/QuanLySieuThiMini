using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Windows.Forms;

namespace QuanLySieuThiMini.DAO
{
    public class DoanhthuDAO
    {
        SqlDataAdapter dr;
        DAO.DataConnection dc;
        public DoanhthuDAO()
       {
           dc = new DataConnection();
       }
        public DataTable Danhsachhoadonxuat(string nbd, string nkt)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT MAHDX,NGAYLAP,TONGTIEN, TENNV FROM HOADONXUAT WHERE  NGAYLAP BETWEEN '" + nbd + "'AND'" + nkt + "'";
                SqlConnection con = dc.getConnect();
                dr = new SqlDataAdapter(sql, con);
                con.Open();
                dr.Fill(dt);
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

       
    }
}
