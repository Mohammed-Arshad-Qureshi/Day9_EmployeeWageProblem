using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    interface ICompanyEmpWage
    {
        void addCompanyWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        void computeEmpWage();
        int computeEmpWage(CompanyEmpWage computeEmpWage);

    }
}
