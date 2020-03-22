using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples
{
    class Employee
    {
        //This locked design violates the SRP
        //public
        //    void CalculateSalary()
        //{

        //    Console.WriteLine("Calculatting salary...");
        //}
        //void Output()
        //    {
        //    Console.WriteLine("Salary printed");
        //    }
        public
           virtual void CalculateSalary()
        {
            Console.WriteLine("Calculatting salary...");
        }
    }
}
