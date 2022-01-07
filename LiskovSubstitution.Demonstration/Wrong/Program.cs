using LiskovSubstitution.Demonstration.Correct;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Demonstration.Wrong
{
    public class Program
    {
        public void Main()
        {
            DbLogger dbLogger = new DbLogger();

            UserService userService = new UserService(dbLogger);

            userService.SaveUserDetails();

        }
    }
}
