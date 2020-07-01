using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySieuThiMini.DAO
{
     public class DataProvider
    {
         private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string StrConn = @"Data Source=DESKTOP-RELM40O\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        
        public DataTable ExecuteQuery(string sql, object[] parameter = null)
        {
            DataTable data = new DataTable ();
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                if(parameter!=null)
                {
                    string[] ListPara = sql.Split(' ');
                    int i = 0;
                    foreach(string item in ListPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                conn.Close();
            }

            

            return data;
        }

        public int ExecuteNonQuery(string sql, object[] parameter = null)
        {
            
            int data = 0;
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                if (parameter != null)
                {
                    string[] ListPara = sql.Split(' ');
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                
                    data = command.ExecuteNonQuery();
               

                conn.Close();
            }



            return data;
        }
        public object ExecuteScalar(string sql, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                if (parameter != null)
                {
                    string[] ListPara = sql.Split(' ');
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                data = command.ExecuteScalar();

                conn.Close();
            }



            return data;
        }

    }
}
