using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> allEmployees = new List<Employee>();
            allEmployees.Add(new Manager());
            allEmployees.Add(new Developer());
            Employee.CalculateAllSalaries(allEmployees);
            Console.ReadKey();
        }
    }
}