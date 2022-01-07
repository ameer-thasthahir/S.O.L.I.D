using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Demostration.Wrong
{
    public interface ISchoolService
    {
        double GetSalaryDetails();

        double GetGradeMarks();

        string GetPricipalContactDetails();

        string GetStudentContactDetails();

        string GetTeacherContactDetails();

        string GetAdminPassword();


    }
}
