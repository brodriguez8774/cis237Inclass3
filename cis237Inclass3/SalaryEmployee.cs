using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class SalaryEmployee : Employee
    {
        #region Variables

        private decimal yearlySalary;

        

        #endregion



        #region Properties

        public decimal YearlySalary
        {
            get { return yearlySalary; }
            set { yearlySalary = value; }
        }

        #endregion



        #region constructor

        /// <summary>
        /// 4 Parameter Inheriting Constructor.
        /// Calls the base constructor with initial 3 parameters,
        /// Then assigns the last one for yearlySalary.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="department"></param>
        /// <param name="yearlySalary"></param>
        public SalaryEmployee(string firstName, string lastName, string department, decimal yearlySalary)
            : base(firstName, lastName, department)
        {
            YearlySalary = yearlySalary;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Overrides inherited (from employee) ToString to include yearly salary.
        /// </summary>
        /// <returns>String of employee information.</returns>
        public override string ToString()
        {
            return base.ToString() + ", " + yearlySalary.ToString("C");
        }

        /// <summary>
        /// Prints full name of employee.
        /// </summary>
        protected override void PrintFullEmployee()
        {
            Console.WriteLine(base.ToString() + ", " + yearlySalary.ToString("C"));
        }

        public override decimal CalculateWeeklyGross()
        {
            return yearlySalary / 52;
        }

        #endregion

    }
}
