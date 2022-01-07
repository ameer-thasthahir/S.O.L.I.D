using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SingleResposibility.Demostration.Correct
{
    public class UserRepository : IUserRepository
    {
        public void Insert()
        {
            SqlConnection connection = new SqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [...]");//Insert user into database. 
        }
    }
}
