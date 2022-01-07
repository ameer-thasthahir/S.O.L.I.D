using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DependencyInvestion.Demostration.Wrong
{
    public class SqlServerConnection
    {
        public void Connect()
        {
            SqlConnection connection = new SqlConnection();
            connection.Open();
        }      
    }
}
