using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInvestion.Demostration.Wrong
{
    public class Program
    {
        void Main()
        {
            //Sql conenction
            SqlServerConnection sqlDataBaseConnector = new SqlServerConnection();

            UserRepository userRepositorySqlConnector = new UserRepository(sqlDataBaseConnector);

            userRepositorySqlConnector.SaveUserDetails();        
        }
    }
}
