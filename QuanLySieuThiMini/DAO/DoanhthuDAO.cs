using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLySieuThiMini.DAO
{
    public class DoanhthuDAO
    {
        SqlDataAdapter dr;
        DAO.DataConnection dc;
        SqlCommand cmd;
        public DoanhthuDAO()
       {
           dc = new DataConnection();
       }
        public DataTable Danhsachhoadonxuat(string nbd, string nkt)
        {

            string sql = "SELECT MAHDX,NGAYLAP,TONGTIEN, TENNV FROM HOADONXUAT WHERE  NGAYLAP BETWEEN '" + nbd + "'AND'" + nkt + "'";
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
