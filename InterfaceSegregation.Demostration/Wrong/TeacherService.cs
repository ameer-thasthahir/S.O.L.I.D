using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Demostration.Wrong
{
    public class TeacherService : ISchoolService
    {
        public string GetAdminPassword()
        {
            throw new NotImplementedException();
        }

        public double GetGradeMarks()
        {
            throw new NotImplementedException();
        }

        public string GetPricipalContactDetails()
        {
            throw new NotImplementedException();
        }

        public double GetSalaryDetails()
        {
            return 15000;
        }

        public string GetStudentContactDetails()
        {
            throw new NotImplementedException();
        }

        public string GetTeacherContactDetails()
        {
            return "+919876543210";
        }
    }
}
