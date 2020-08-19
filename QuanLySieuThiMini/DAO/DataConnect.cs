using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLySieuThiMini.DAO
{
    
    public class DataConnection
    {
        string conStr;

        public DataConnection()
        {
            conStr = @"Data Source=DESKTOP-8GNIKAI\SQLEXPRESS;Initial Catalog=CSDLSieuThiMini;Integrated Security=True";
           // conStr = @"Data Source=DESKTOP-7KJPPJF\SQLEXPRESS;Initial Catalog=CSDLSieuThiMini;Integrated Security=True";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
