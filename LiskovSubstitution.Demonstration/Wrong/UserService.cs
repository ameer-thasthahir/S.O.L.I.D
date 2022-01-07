using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Demonstration.Wrong
{
    public class UserService
    {
        private readonly FileLogger fileLogger;

        public UserService(FileLogger fileLogger)
        {
            this.fileLogger = fileLogger;
        }

        public void SaveUserDetails()
        {
            //Save user details

            //Log the details
            fileLogger.Log();
        }
    }
}
