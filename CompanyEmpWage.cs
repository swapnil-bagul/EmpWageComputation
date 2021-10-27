using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string companyName, int maxWorkingDay, int maxWorkingHrs, int empRate);
        public void computeEmpWage();

        public int getTotalWage(string company);
    }
    class CompanyEmpWage
    {
        public int empRate;
        public int maxWorkingDay;
        public int maxWorkingHrs;
        public int totalEmpWage;
        public string companyName;

        public CompanyEmpWage (string companyName, int maxWorkingDay, int maxWorkingHrs, int empRate)
        {
            this.companyName = companyName;
            this.maxWorkingDay = maxWorkingDay;
            this.maxWorkingHrs = maxWorkingHrs;
            this.empRate = empRate;
            this.totalEmpWage = 0;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;

        }
        public string toString()
        {
            return "Total Employee Wage For " + companyName + " " + "is " + totalEmpWage;
        }
    }
  
}
