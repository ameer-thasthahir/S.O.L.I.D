using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Demostration.Correct
{
    public class TeacherService : ITeacherService
    {
        public double GetSalaryDetails()
        {
            return 15000;
        }

        public string GetTeacherContactDetails()
        {
            return "+919876543210";
        }
    }
}
