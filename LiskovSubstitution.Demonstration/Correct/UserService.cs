using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Demonstration.Correct
{
    public class UserService
    {
        private readonly Logger logger;

        public UserService(Logger logger)
        {
            this.logger = logger;
        }

        public void SaveUserDetails()
        {
            //Save user details

            //Log the details
            logger.Log();
        }
    }
}
