using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInvestion.Demostration.Wrong
{
    public class UserRepository
    {
        private readonly SqlServerConnection sqlServerConnection;

        public UserRepository(SqlServerConnection sqlServerConnection)
        {
            this.sqlServerConnection = sqlServerConnection;
        }

        public void SaveUserDetails()
        {
            sqlServerConnection.Connect();

            //use sql query to save connection
        }
    }
}
