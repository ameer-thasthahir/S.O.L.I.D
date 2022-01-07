using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInvestion.Demostration.Correct
{
    public class Program
    {
        void Main()
        {
            //Sql conenction
            IDataBaseConnector sqlDataBaseConnector = new SqlServerConnection();

            UserRepository userRepositorySqlConnector = new UserRepository(sqlDataBaseConnector);

            userRepositorySqlConnector.SaveUserDetails();



            //Oracle connection
            IDataBaseConnector oracleDatabaseConnection = new OracleDatabaseConnection();

            UserRepository userRepositoryOracleConnector = new UserRepository(oracleDatabaseConnection);

            userRepositoryOracleConnector.SaveUserDetails();
        }
    }
}
