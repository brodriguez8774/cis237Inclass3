
/* Note: This class frequently has notes refering to "higher" or "lower" level objects.
 * This is refering to a "chain of inheritance" with the upper/starting/higher objects being the interface/abstract employee.
 * The things inheriting from these objects are the lower/ending/last-in-inheritance-chain objects.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class Program
    {
        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args">Main-Line args.</param>
        static void Main(string[] args)
        {
            #region Intial Inheritance Work

            Console.WriteLine();
            Console.WriteLine("".PadRight(20, '*'));
            Console.WriteLine("Initial Inheritance Work");
            Console.WriteLine("".PadRight(20, '*'));
            
            // Creates Salary Employee (inheriting from the abstract class and interface) and displays information.
            SalaryEmployee salaryEmployee = new SalaryEmployee("Aa", "Aaa", "IT", 150000);

            Console.WriteLine(salaryEmployee.ToString());
            Console.WriteLine(salaryEmployee.CalculateWeeklyGross().ToString("C"));
            Console.WriteLine("Department: " + salaryEmployee.GetDepartmentTwice());


            Console.WriteLine(Environment.NewLine + "".PadLeft(15, '~') + Environment.NewLine);

            // Creates Hourly Employee (inheriting from the abstract class and interface) and displays information.
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Bb", "Bbb", "HR", 8.37m);
            hourlyEmployee.HoursWorked = 40;

            Console.WriteLine(hourlyEmployee.ToString());
            Console.WriteLine(hourlyEmployee.CalculateWeeklyGross().ToString("C"));
            Console.WriteLine("Department: " + hourlyEmployee.GetDepartmentTwice());

            Console.WriteLine();
            Console.WriteLine("".PadRight(20, '*'));
            Console.WriteLine("End Inheritance Work");
            Console.WriteLine("".PadRight(20, '*'));

            #endregion



            #region Polymorphism Work

            Console.WriteLine();
            Console.WriteLine("".PadRight(20, '*'));
            Console.WriteLine("Polymorphism Work");
            Console.WriteLine("".PadRight(20, '*'));

            // Declares instances of employees.
            SalaryEmployee aa = new SalaryEmployee("Aa", "Aaa", "IT", 150000);
            HourlyEmployee bb = new HourlyEmployee("Bb", "Bbb", "HR", 8.37m);
            HourlyEmployee cc = new HourlyEmployee("Cc", "Ccc", "No", 50m);
            cc.HoursWorked = 40;

            // Puts all created employees into a list. Because they are of different types,
            // must use polymorphism to create a compatible container.
            IEmployee[] employeeList = { aa, bb, cc, new SalaryEmployee("Dd", "ddd", "Yus", 500), new HourlyEmployee("Ee", "Eee", "Uh", 12m) };
            IEmployee Ee = new HourlyEmployee("Ee", "Eee", "Uh", 12m);

            ((HourlyEmployee)employeeList[4]).HoursWorked = 40;
            ((HourlyEmployee)Ee).HoursWorked = 40;

            /* Loops through list to call CalculateWeeklyGross on each employee. Due to properties of polymorphism,
             * program knows which version of each method to call based on theactual employee instance version. This
             * only works if the methods are a part of the top classand then is overridden/inherited by the lower classes.
             * Anything which is only in the lowerclasses CANNOT be called/used/changed via the polymorphized top class.
             * To do this you must cast class first, as in two lines of code directly above.
             * NOTE: By casting like the above two lines of code, you have potential to crash your program if done incorrectly.
             * */
            foreach (IEmployee employee in employeeList)
            {
                Console.WriteLine(employee.ToString());
                Console.WriteLine(employee.CalculateWeeklyGross().ToString("C"));
                Console.WriteLine();
            }

            // You can also simply create an array of the interface/abstract class and then add lower level objects afterwards.

            Console.WriteLine(Environment.NewLine + "".PadRight(15, '~') + Environment.NewLine);

            IEmployee[] anotherEmployeeList;
            anotherEmployeeList = new IEmployee[5];
            anotherEmployeeList[0] = aa;
            anotherEmployeeList[1] = bb;
            anotherEmployeeList[2] = cc;

            foreach (IEmployee employee in anotherEmployeeList)
            {
                if (employee != null)
                {
                    Console.WriteLine(employee.ToString());
                    Console.WriteLine(employee.CalculateWeeklyGross().ToString("C"));
                    Console.WriteLine();
                }
            }

            #endregion

        }
    }
}
