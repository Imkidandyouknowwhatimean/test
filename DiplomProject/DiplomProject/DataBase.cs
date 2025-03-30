using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DiplomProject
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=PC\SQLEXPRESS; Initial Catalog = DiplomProject; Integrated Security=true");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }

        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
