using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    class EmpWageBuilderArray
    {
        public const int IS_Full_Time = 1;
        public const int IS_Part_Time = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyWage(string company, int empRatePerHours, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHours, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].details());
            }
        }
        public int computeEmpWage(CompanyEmpWage computeEmpWage)
        {
            //Constants
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            //varibles
            while (totalEmpHrs <= computeEmpWage.maxHoursPerMonth && totalWorkingDays < computeEmpWage.numOfWorkingDays)
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
           return totalEmpHrs * computeEmpWage.empRatePerHours;


        }
    }

}
