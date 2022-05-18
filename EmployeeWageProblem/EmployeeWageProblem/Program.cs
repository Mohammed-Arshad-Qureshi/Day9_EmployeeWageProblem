using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    class Program
    {
        public const int IS_Full_Time = 1, IS_Part_Time = 2, Emp_Rate_Per_Hrs = 20, Num_Of_Working_Days = 20;
        public const int Max_Hrs_In_Month = 100;

        static void Main(string[] args)
        {
            //Constants
            //varibles
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_Days)
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
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hrs;
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);

            Console.ReadLine();
        }
    }
}
