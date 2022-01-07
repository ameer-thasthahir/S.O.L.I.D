using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Demostration.Correct
{
    public class StudentService : IStudentService
    {
        public double GetGradeMarks()
        {
            return 5.1;
        }

        public string GetStudentContactDetails()
        {
            return "student@school.com";
        }
    }
}
