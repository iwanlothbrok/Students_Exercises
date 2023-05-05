using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace SoftUni
{
    public class StartUp
    {
        static void Main()
        {
            SoftUniContext context = new SoftUniContext();
			//TODO: 5.Threads and Database
			Thread t1 = new Thread(() => Get10EmployeesFullInformation(context));
			t1.Start();

			t1.Join(); // Wait for t1 to finish before moving on

			Thread t2 = new Thread(() => GetEmployeesWithSalaryOver50000(context));
			t2.Start();
		}

        public static void Get10EmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .Select(x => new
                {
                    x.EmployeeId,
                    x.FirstName,
                    x.LastName,
                    x.MiddleName,
                    x.JobTitle,
                    x.Salary
                }
                ).Take(10)
                .OrderBy(e => e.EmployeeId).ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:F2}");
            }
            Console.WriteLine(sb.ToString());
        }

        public static void GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees.Where(x => x.Salary > 50000)
                .Select(x => new
                {
                    x.FirstName,
                    x.Salary
                }
                )
                .OrderBy(e => e.FirstName).ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.Salary:F2}");
            }
            Console.WriteLine(sb);
        }

    }
}
