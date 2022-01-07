using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Demonstration.Correct
{
    public class DbLogger: Logger
    {
        public override void Log()
        {
            //I Log in database tables
        }
    }
}
