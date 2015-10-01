using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    /// <summary>
    /// Interface for Employee.
    /// Interfaces are for "High level/general" thinking? They don't provide details, only general "this is needed in some manner" logic.
    /// Interfaces are often called a "contract" because anything that inherits from it MUST provide the same things.
    /// </summary>
    interface IEmployee
    {
        decimal CalculateWeeklyGross();

        string GetDepartmentTwice();
    }
}
