using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    
   public class DataBaseAccess
    {
        string strcon = "Data Source=RIN;Database=QLSP;Integrated Security=True";
       protected SqlConnection conn = null;
        public void OpenConnection()
        {
            if(conn ==null)
            {
                conn = new SqlConnection(strcon);
            }
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if(conn!=null &&  conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
