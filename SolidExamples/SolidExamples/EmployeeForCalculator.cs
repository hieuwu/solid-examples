using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples
{
    class EmployeeForCalculator: Employee
    {
        public
          override void CalculateSalary()
        {
            Console.WriteLine("Calculator is processing...");
        }
    }
}
