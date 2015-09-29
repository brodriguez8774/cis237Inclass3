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
            Console.WriteLine();

            SalaryEmployee salaryEmployee = new SalaryEmployee("Aa", "Aaa", "IT", 150000);

            Console.WriteLine(salaryEmployee.ToString());

            Console.WriteLine(salaryEmployee.CalculateWeeklyGross());

            Console.WriteLine(Environment.NewLine + "".PadLeft(15, '~') + Environment.NewLine);

            HourlyEmployee hourlyEmployee = new HourlyEmployee("Bb", "Bbb", "HR", 8.37m);
            hourlyEmployee.HoursWorked = 40;

            Console.WriteLine(hourlyEmployee.ToString());
            Console.WriteLine(hourlyEmployee.CalculateWeeklyGross());
        }
    }
}
