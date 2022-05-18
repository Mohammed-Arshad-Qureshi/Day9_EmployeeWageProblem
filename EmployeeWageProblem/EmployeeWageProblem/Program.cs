using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    class Program
    {
        public const int IS_Full_Time = 1;
        public const int IS_Part_Time = 2;


        public static int ComputeEmpWage(string company,int empRatePerHours,int numOfWorkingDays,int maxHoursPerMonth)
        {
            //Constants
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            //varibles
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                Random r = new Random();
                int empCheck = r.Next(0, 3);
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
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day# :" + totalWorkingDays + "Emp Hrs :  " + empHrs);
                totalWorkingDays++;
            }
            int totalEmpWage = totalEmpHrs * empRatePerHours;
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
            return totalEmpWage;

        }

        static void Main(string[] args)
        {
            ComputeEmpWage("Dmart",20,2,10);
            ComputeEmpWage("Reliance",10,4,20);
            Console.ReadLine();
        }
           
    }
}
