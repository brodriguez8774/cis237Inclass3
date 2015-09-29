using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class HourlyEmployee : Employee
    {
        #region Variables

        private decimal hourlyRate;
        private double hoursWorked;
        
        #endregion



        #region Properties

        public decimal HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        #endregion



        #region Constructor

        /// <summary>
        /// 4 Parameter Inheriting Constructor.
        /// Calls the base constructor with initial 3 parameters,
        /// Then assigns the last one for hourlyRate.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="department"></param>
        /// <param name="hourlyRate"></param>
        public HourlyEmployee(string firstName, string lastName, string department, decimal hourlyRate)
            : base(firstName, lastName, department)
        {
            HourlyRate = hourlyRate;
        }

        #endregion



        #region Methods

        /// <summary>
        /// Overrides inherited (from employee) ToString to include hourly rate.
        /// </summary>
        /// <returns>String of employee information.</returns>
        public override string ToString()
        {
            return base.ToString() + ", " + hourlyRate.ToString("C");
        }

        /* Note: Did not override the PrintFullEmployee protected virtual method.
         * Even though it is protected and virtual, you don't have to override it.
         * Calling it now will just call the parent version as is. */

        /// <summary>
        /// Returns the weekly gross pay.
        /// </summary>
        /// <param name="hoursWorked"></param>
        /// <returns></returns>
        public decimal CalculateWeeklyGross()
        {
            return hourlyRate * (decimal)hoursWorked;
        }

        #endregion

    }
}
