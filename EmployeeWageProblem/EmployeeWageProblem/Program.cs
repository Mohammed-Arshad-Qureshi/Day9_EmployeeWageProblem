using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants
            int IS_Full_Time = 0;
            Random r = new Random();
            int empCheck = r.Next(0, 2);
            
            if(empCheck == IS_Full_Time)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}
