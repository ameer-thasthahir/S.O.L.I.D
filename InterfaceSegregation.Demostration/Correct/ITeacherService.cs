using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Demostration.Correct
{
    public interface ITeacherService
    {
        string GetTeacherContactDetails();

        double GetSalaryDetails();
    }
}
