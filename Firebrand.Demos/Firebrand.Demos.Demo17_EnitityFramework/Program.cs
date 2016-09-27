using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos.Demo17_EnitityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new FourthCoffeeEntities();

            var employees = context.Employees;

            foreach (var employee in employees)
            {
                Console.WriteLine("{0} this person was born in {1}", employee.FirstName, employee.DateOfBirth);
            }

            var emp = context.Employees.First(x => x.FirstName == "Charlie");

            Console.WriteLine("We found {0}, {1}", emp.LastName, emp.FirstName);
            emp.LastName = "Smith";
            context.SaveChanges();

            Console.ReadKey();
        }
    }
}
