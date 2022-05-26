using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    class EmpWageBuilderArray : ICompanyEmpWage
    {
        public const int IS_Full_Time = 1;
        public const int IS_Part_Time = 2;

        private int numOfCompany = 0;
        //private CompanyEmpWage[] companyEmpWageArray;
        private List<CompanyEmpWage> arr;

        public EmpWageBuilderArray()
        {
            //this.companyEmpWageArray = new CompanyEmpWage[5];
            this.arr = new List<CompanyEmpWage>();
        }
        public void addCompanyWage(string company, int empRatePerHours, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHours, numOfWorkingDays, maxHoursPerMonth);
            this.arr.Add(companyEmpWage);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage data in arr)
            {
                data.setTotalWage(this.computeEmpWage(data));
                Console.WriteLine(data.details());

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
