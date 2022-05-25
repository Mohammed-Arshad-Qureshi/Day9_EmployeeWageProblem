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
            Program p1 = new Program("Dmart",20,2,10);
            p1.ComputeEmpWage();
            Console.WriteLine(p1.details());
            Program p2 = new Program("Reliance", 10, 4, 20);
            p2.ComputeEmpWage();
            Console.WriteLine(p2.details());
            Console.ReadLine();
        }

    }
}
