using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace SingleResposibility.Demostration.Correct
{
    public class MailService : IMailService
    {
        public void SendMail()
        {
            SmtpClient client = new SmtpClient("smtp.myhost.com");
            client.Send(new MailMessage()); //Send a welcome email. 
        }
    }
}
