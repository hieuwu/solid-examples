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
        private
            String employeeType;
        public
           virtual void CalculateSalary()
        {
            Console.WriteLine("Calculatting salary...");
        }

        //This locked part below violates the Open-closed principle
        //public
        //int CalcDevSalary()
        //{
        //    Console.WriteLine("Developer Salary");
        //    return 0;
        //}
        //int CalcManagerSalary()
        //{
        //    Console.WriteLine("Manager Salary");
        //    return 0;
        //}

        //void CalculateAllSalaries(List<Employee> allEmployees)
        //{
        //    int totalSalary = 0;
        //    foreach(var employee in allEmployees)
        //    {
        //        switch (employee.employeeType)
        //        {
        //            case "Manager":
        //                {
        //                    totalSalary += employee.CalcManagerSalary();
        //                    break;
        //                }
        //            case "Developer":
        //                {
        //                    totalSalary += employee.CalcDevSalary();
        //                    break;
        //                }
        //        }             
        //    }
        //    Console.WriteLine("Total salary is calculated");
        //}

            //This static function used to test
       public static void CalculateAllSalaries(List<Employee> allEmployees)
        {
            foreach (var employee in allEmployees)
            {
               employee.CalculateSalary();
            }
             Console.WriteLine("Total salary is calculated");

        }

    }
}
