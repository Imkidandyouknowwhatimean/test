using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kursovaya
{
    internal class DataBase
    {

        SqlConnection SqlConnection = new SqlConnection(@"Data Source = PC\SQLEXPRESS; Initial Catalog = Kursovaya; Integrated Security = true");

        public void OpenConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if(SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();  
            }

        }

        public SqlConnection GetConnection()
        {
            {
                return SqlConnection;
            }
        }

    }
}
