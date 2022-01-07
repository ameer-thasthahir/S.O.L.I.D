using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInvestion.Demostration.Correct
{
    public class UserRepository
    {
        private readonly IDataBaseConnector dataBaseConnector;

        public UserRepository(IDataBaseConnector dataBaseConnector)
        {
            this.dataBaseConnector = dataBaseConnector;
        }

        public void SaveUserDetails()
        {
            dataBaseConnector.Connect();

            //use sql query to save connection
        }
    }
}
