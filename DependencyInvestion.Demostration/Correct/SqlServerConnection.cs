using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DependencyInvestion.Demostration.Correct
{
    public class SqlServerConnection: IDataBaseConnector
    {
        public void Connect()
        {
            SqlConnection connection = new SqlConnection();
            connection.Open();
        }

        public SqlCommand Query { get; set; }
    }
}
