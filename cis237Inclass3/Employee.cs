using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class Employee
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


        public Employee(string FirstName, string LastName, string Department)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.department = Department;
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

        protected virtual void PrintFullEmployee()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        #endregion

    }
}
