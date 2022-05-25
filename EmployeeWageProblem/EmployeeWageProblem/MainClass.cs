using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    class MainClass
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.ReadLine();
        }

    }
}
