using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    class Program
    {
        public const int IS_Full_Time = 1, IS_Part_Time = 2, Emp_Rate_Per_Hr = 20, Num_Of_Working_Days=2;

        static void Main(string[] args)
        {
            //Constants
            //varibles
            int empHrs = 0, empWage = 0, totalEmpWage = 0;
            for (int day = 0; day < Num_Of_Working_Days; day++)
            {
                Random r = new Random();
                int empCheck = r.Next(0, 2);
                switch (empCheck)
                {
                    case IS_Full_Time:
                        empHrs = 8;
                        break;
                    case IS_Part_Time:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs + Emp_Rate_Per_Hr;
                totalEmpWage = totalEmpWage + empWage;
                Console.WriteLine("Employee Wage : " + empWage);
            }
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);

            Console.ReadLine();
        }
    }
}
