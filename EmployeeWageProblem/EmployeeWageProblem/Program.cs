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

        private string company;
        private int empRatePerHours;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public Program(string company, int empRatePerHours, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHours = empRatePerHours;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;

        }


        public void ComputeEmpWage()
        {
            //Constants
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            //varibles
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
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
            totalEmpWage = totalEmpHrs * this.empRatePerHours;
            Console.WriteLine("Total Employee Wage for Company : "+ company + "is: " + totalEmpWage);
          

        }
        public string details()
        {
            return "Total Emp wage for Company : " + this.company + "is : " + this.totalEmpWage;
        }
           
    }
}
