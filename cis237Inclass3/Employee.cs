using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    abstract class Employee : IEmployee
    {
        #region Variables

        private string firstName;
        private string lastName;
        private string department;

        #endregion



        #region Constructor

        /// <summary>
        /// Base constructor.
        /// </summary>
        public Employee()
        {

        }


        public Employee(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        #endregion



        #region Properties

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Overrides inherited (from visual studio) ToString to display name and department.
        /// </summary>
        /// <returns>String of employee information.</returns>
        public override string ToString()
        {
            return firstName + " " + lastName + ", " + department;
        }

        /// <summary>
        /// Prints full name of employee.
        /// </summary>
        protected virtual void PrintFullEmployee()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        /// <summary>
        /// Abstract CalculateWeeklyGross class. Makes it so that all inheriting classes MUST
        /// have a class with the same name and properties.
        /// </summary>
        public abstract decimal CalculateWeeklyGross();

        /// <summary>
        /// Nonsensical method to show how interfaces work.
        /// Because method is in interface, it MUST be inherited in some manner.
        /// Interface does not give details so you have some room to decide exactly how it's implimented.
        /// </summary>
        /// <returns>A string of DoubleDepartment.</returns>
        public virtual string GetDepartmentTwice()
        {
            return this.Department + this.Department;
        }

        #endregion

    }
}
