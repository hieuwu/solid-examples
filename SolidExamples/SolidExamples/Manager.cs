using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples
{
    class Manager:Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Manager salary");
        }
    }
}
