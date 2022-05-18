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
            int IS_Full_Time = 1, Emp_Rate_Per_Hr = 20;
            //varibles
            int empHrs = 0 ,empWage = 0;
            Random r = new Random();
            int empCheck = r.Next(0, 2);

            if (empCheck == IS_Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs + Emp_Rate_Per_Hr;
            Console.WriteLine("Employee Wage : " + empWage);
            Console.ReadLine();
        }
    }
}
