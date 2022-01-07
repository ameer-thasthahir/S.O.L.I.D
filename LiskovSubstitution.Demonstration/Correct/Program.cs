using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Demonstration.Correct
{
    public class Program
    {
        public void Main()
        {
            Logger dbLogger = new DbLogger();

            Logger fileLogger = new FileLogger();

            UserService userService = new UserService(dbLogger);

            userService.SaveUserDetails();


            UserService userServiceFileLogger = new UserService(fileLogger);

            userServiceFileLogger.SaveUserDetails();

        }
    }
}
