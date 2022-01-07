using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Demonstration.Wrong
{
    public class DbLogger: FileLogger
    {
        public override void Log()
        {
            //I Log in database tables
        }
    }
}
