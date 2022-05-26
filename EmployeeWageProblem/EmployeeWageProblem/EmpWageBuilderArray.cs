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
        private List<CompanyEmpWage> arr;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpWageBuilderArray()
        {
            this.arr = new List<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void addCompanyWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.arr.Add(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage data in arr)
            {
                data.setTotalWage(this.computeEmpWage(data));
                Console.WriteLine(data.details() + "\n\n");

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
                Console.WriteLine("Day# : " + totalWorkingDays + "Emp Hrs :  " + empHrs + "   for day  ---   Salary : " + empHrs * computeEmpWage.empRatePerHour);
                totalWorkingDays++;
            }
            return totalEmpHrs * computeEmpWage.empRatePerHour;
        }
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }

    }


}
