using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Demostration.Wrong
{
    public class StudentService : ISchoolService
    {
        public string GetAdminPassword()
        {
            throw new NotImplementedException();
        }

        public double GetGradeMarks()
        {
            return 5.1;
        }

        public string GetPricipalContactDetails()
        {
            throw new NotImplementedException();
        }

        public double GetSalaryDetails()
        {
            throw new NotImplementedException();
        }

        public string GetStudentContactDetails()
        {
            return "student@school.com";
        }

        public string GetTeacherContactDetails()
        {
            throw new NotImplementedException();
        }
    }
}
