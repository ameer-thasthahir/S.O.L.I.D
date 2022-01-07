using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;

namespace SingleResposibility.Demostration.Wrong
{
    // does not follow SRP
    public class RegisterService
    {
        public void RegisterUser(string username)
        {
            if (username == "admin")
                throw new InvalidOperationException();

            SqlConnection connection = new SqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [...]");//Insert user into database. 

            SmtpClient client = new SmtpClient("smtp.myhost.com");
            client.Send(new MailMessage()); //Send a welcome email. 
        }
    }
}
